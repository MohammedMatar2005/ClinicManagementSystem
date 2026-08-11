using ClinicBusiness.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Models;
using ClinicBusiness.DTO.PatientVisitsDTOs;

namespace ClinicManagementSystem.PatientVisits
{
    public partial class frmUpdatePatientVisitInfo : Form
    {
        private readonly clsPatientVisit _visitService;
        private readonly int _selectedVisitId;

        // 🔹 استخدام الـ DTO الأصلي القادم من مكتبة الـ Business مباشرة دون تكرار
        private ClinicBusiness.DTO.PatientVisitsDTOs.PatientVisitDetailsDTO _visitDetailsDTO;

        public frmUpdatePatientVisitInfo(int selectedVisitId)
        {
            InitializeComponent();
            _selectedVisitId = selectedVisitId;

            // إنشاء الـ Context وحقنه في السيرفس
            var context = new ClinicManagementSystemContext();
            _visitService = new clsPatientVisit(context);
        }

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                // جلب كائن التفاصيل المجمع بالكامل في طلب واحد فقط للخادم
                _visitDetailsDTO = await _visitService.GetPatientVisitByIdAsync(_selectedVisitId);

                // إذا كان الـ DTO فارغاً، فهذا يعني أن الزيارة غير موجودة في قاعدة البيانات
                if (_visitDetailsDTO == null)
                {
                    MessageBox.Show(
                        "لم يتم العثور على بيانات هذه الزيارة، قد تكون قد حُذفت.",
                        "خطأ في البيانات",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ أثناء جلب البيانات من الخادم:\n{ex.Message}",
                    "خطأ في قاعدة البيانات",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return false;
            }
        }

        private void _MappingDataFormDTOsToControls()
        {
            try
            {
                // 🔹 قراءة البيانات مباشرة من الكائن المرجّع بشكل مسطح تماشياً مع الـ DTO الفعلي للبزنس
                var view = _visitDetailsDTO;

                // 1. بيانات العرض والزيارة الأساسية
                txtVisitId.Text = view.VisitId.ToString();

                // 🔹 تعديل تنسيق التاريخ ليتوافق مع كون الحقل DateOnly (بدون صيغة الوقت منعا للـ Crash)
                txtVisitDate.Text = view.VisitDate.ToString("yyyy-MM-dd");

                txtPatientName.Text = view.PatientFullName;
                txtDoctorName.Text = view.DoctorFullName;
                txtAppointmentReason.Text = view.AppointmentReason;


                // 2. البيانات السريرية والمؤشرات الحيوية
                txtBloodPressure.Text = view.BloodPressure;
                txtTemperature.Text = view.Temperature?.ToString("0.0");
                txtHeartRate.Text = view.HeartRate?.ToString();
                txtRespiratoryRate.Text = view.RespiratoryRate?.ToString();
                txtWeight.Text = view.Weight?.ToString("0.0");
                txtHeight.Text = view.Height?.ToString("0.0");

                txtSymptoms.Text = view.Symptoms;
                txtTreatmentPlan.Text = view.TreatmentPlan;
                txtNotes.Text = view.Notes;
                txtDiagnosis.Text = view.Diagnosis;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("تنبيه: بعض حقول البيانات فارغة أو غير مكتملة في النظام.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء عرض البيانات: {ex.Message}", "خطأ داخلي", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private async void _LoadVisitData()
        {
            try
            {
                if (await _FillDataInDTOs())
                {
                    _MappingDataFormDTOsToControls();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل تحميل واجهة الزيارة: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        private void frmShowPatientVisitInfo_Load(object sender, EventArgs e)
        {
            _LoadVisitData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // التأكد من أن بيانات الزيارة المجلوبة من الداتابيز موجودة
            if (_visitDetailsDTO == null) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // تجهيز كائن التعديل بالقيم الحالية/المعدلة
                PatientVisitSaveDTO visitSaveDTO = new PatientVisitSaveDTO
                {
                    VisitId = _selectedVisitId,
                    AppointmentId = _visitDetailsDTO.AppointmentId,

                    // إذا أبقى القيمة أو عدلها لرقم يحفظها، وإذا مسحها وجعلها فارغة يحفظ null
                    HeartRate = int.TryParse(txtHeartRate.Text, out int hr) ? hr : null,
                    RespiratoryRate = int.TryParse(txtRespiratoryRate.Text, out int rr) ? rr : null,
                    Temperature = decimal.TryParse(txtTemperature.Text, out decimal temp) ? temp : null,
                    Weight = decimal.TryParse(txtWeight.Text, out decimal w) ? w : null,
                    Height = decimal.TryParse(txtHeight.Text, out decimal h) ? h : null,

                    // معالجة النصوص وتنظيف المسافات
                    BloodPressure = string.IsNullOrWhiteSpace(txtBloodPressure.Text) ? null : txtBloodPressure.Text.Trim(),
                    Symptoms = string.IsNullOrWhiteSpace(txtSymptoms.Text) ? null : txtSymptoms.Text.Trim(),
                    Diagnosis = string.IsNullOrWhiteSpace(txtDiagnosis.Text) ? null : txtDiagnosis.Text.Trim(),
                    TreatmentPlan = string.IsNullOrWhiteSpace(txtTreatmentPlan.Text) ? null : txtTreatmentPlan.Text.Trim(),
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                bool isUpdated = await _visitService.UpdatePatientVisitAsync(visitSaveDTO);

                if (isUpdated)
                {
                    MessageBox.Show("تم تحديث بيانات الزيارة بنجاح.", "نجاح",
                        MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("فشل تحديث بيانات الزيارة. يرجى المحاولة مرة أخرى.", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحديث البيانات: {ex.Message}", "خطأ في النظام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}