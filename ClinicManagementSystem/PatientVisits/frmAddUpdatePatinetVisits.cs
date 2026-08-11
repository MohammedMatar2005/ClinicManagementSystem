using ClinicBusiness.DTO.PatientVisitsDTOs;
using ClinicBusiness.Services;
using ClinicManagementSystem.Appointments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAddUpdatePatinetVisits : Form
    {
        private int _selectedAppointmentId;
        private int _selectedDoctorId; // تأكد من إسناد قيمة له عند جلب البيانات إذا كان مطلوباً
        private int _currentVisitId;

        private readonly clsPatientVisit _patientVisitService;

        private DataTable _dtVisitsHistory = new DataTable();
        private PatientVisitDetailsDTO? _visitDetailsDTO;

        public frmAddUpdatePatinetVisits(clsPatientVisit patientVisitService, int selectedPatientVisitId = -1)
        {
            InitializeComponent();

            _patientVisitService = patientVisitService ?? throw new ArgumentNullException(nameof(patientVisitService));

            // إعدادات الواجهة
            pnlMainBackground.Dock = DockStyle.Fill;
           

            lblBloodPressure.BringToFront();
            lblTemperature.BringToFront();
            lblHeartRate.BringToFront();
            lblWeight.BringToFront();
            lblHeight.BringToFront();

            _currentVisitId = selectedPatientVisitId;

            // ❌ تم حذف شرط الـ Load من هنا لأن مكانه الصحيح في حدث Form_Load بعد تهيئة الأعمدة
        }

        private async void frmPatinetVisits_Load(object sender, EventArgs e)
        {
            
            await _LoadAllVisits();

            // 🌟 تحديد وضع الفورم (إضافة أو تعديل) بشكل آمن
            if (_currentVisitId > 0)
            {
                // حالة التحديث: جلب البيانات وعرضها
                await _LoadVisitData();
            }
            else
            {
                // حالة الإضافة: تنظيف الحقول والتأكد من القيمة الافتراضية
                ClearControls(this);
                _currentVisitId = -1;
            }
        }

        

        private async Task _LoadAllVisits()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<PatientVisitViewDTO> visitsList = await _patientVisitService.GetAllPatientVisitsAsync();
                _dtVisitsHistory = ConvertDTOListToDataTable(visitsList);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب الزيارات: {ex.Message}", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private DataTable ConvertDTOListToDataTable(List<PatientVisitViewDTO> items)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("VisitId", typeof(int));
            dt.Columns.Add("AppointmentId", typeof(int));
            dt.Columns.Add("VisitDate", typeof(DateTime));
            dt.Columns.Add("Diagnosis", typeof(string));
            dt.Columns.Add("PatientFullName", typeof(string));
            dt.Columns.Add("DoctorFullName", typeof(string));
            dt.Columns.Add("AppointmentReason", typeof(string));
            dt.Columns.Add("VisitStatusTitle", typeof(string));

            if (items != null)
            {
                foreach (var item in items)
                {
                    dt.Rows.Add(
                        item.VisitId,
                        item.AppointmentId,
                        item.VisitDate,
                        item.Diagnosis ?? (object)DBNull.Value,
                        item.PatientFullName ?? (object)DBNull.Value,
                        item.DoctorFullName ?? (object)DBNull.Value,
                        item.AppointmentReason ?? (object)DBNull.Value,
                        item.VisitStatusTitle ?? (object)DBNull.Value
                    );
                }
            }
            return dt;
        }

        private void btnChooseAppointment_Click(object sender, EventArgs e)
        {
            using (frmChooseAppointment frm = new frmChooseAppointment())
            {

                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedAppointmentId = frm.AppointmentId;
                    txtAppointmentId.Text = _selectedAppointmentId.ToString();
                }
            }
        }

        private bool _ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtAppointmentId.Text) || _selectedAppointmentId <= 0)
            {
                MessageBox.Show("يرجى اختيار موعد مرتبط بهذه الزيارة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChooseAppointment.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTemperature.Text) && !decimal.TryParse(txtTemperature.Text, out _))
            {
                MessageBox.Show("يرجى إدخال قيمة عشرية صحيحة لدرجة الحرارة.", "خطأ في المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemperature.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtHeartRate.Text) && !int.TryParse(txtHeartRate.Text, out _))
            {
                MessageBox.Show("يرجى إدخال قيمة عددية صحيحة لمعدل نبضات القلب.", "خطأ في المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeartRate.Focus();
                return false;
            }

            return true;
        }

        private async void btnSaveVisit_Click(object sender, EventArgs e)
        {
            if (!_ValidateFields()) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var visitSaveDTO = new PatientVisitSaveDTO
                {
                    VisitId = _currentVisitId,
                    AppointmentId = _selectedAppointmentId,
                    Symptoms = string.IsNullOrWhiteSpace(txtSymptoms.Text) ? null : txtSymptoms.Text.Trim(),
                    Diagnosis = string.IsNullOrWhiteSpace(txtDiagnosis.Text) ? null : txtDiagnosis.Text.Trim(),
                    TreatmentPlan = string.IsNullOrWhiteSpace(txtTreatmentPlan.Text) ? null : txtTreatmentPlan.Text.Trim(),
                    BloodPressure = string.IsNullOrWhiteSpace(txtBloodPressure.Text) ? null : txtBloodPressure.Text.Trim(),
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim(),
                    Temperature = decimal.TryParse(txtTemperature.Text, out decimal temp) ? temp : (decimal?)null,
                    HeartRate = int.TryParse(txtHeartRate.Text, out int heart) ? heart : (int?)null,
                    Weight = decimal.TryParse(txtWeight.Text, out decimal weight) ? weight : (decimal?)null,
                    Height = decimal.TryParse(txtHeight.Text, out decimal height) ? height : (decimal?)null
                };

                bool isSuccess = false;

                // 🌟 منطق التمييز بين الإضافة والتحديث (يعمل الآن بشكل صحيح)
                if (_currentVisitId > 0)
                {
                    isSuccess = await _patientVisitService.UpdatePatientVisitAsync(visitSaveDTO);
                }
                else
                {
                    int newId = await _patientVisitService.AddNewPatientVisitAsync(visitSaveDTO);
                    if (newId > 0)
                    {
                        _currentVisitId = newId; // تحديث المعرف الحالي بالجديد
                        isSuccess = true;
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("تم حفظ بيانات الزيارة الطبية بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls(this);
                    _currentVisitId = -1; // إعادة تعيين للفورم ليكون جاهزاً لإضافة جديدة
                    await _LoadAllVisits();
                }
                else
                {
                    MessageBox.Show("فشلت عملية حفظ الزيارة.", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء الحفظ: {ex.Message}", "خطأ نظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearControls(this);
            _currentVisitId = -1;
        }

        private void ClearControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt) txt.Clear();
                else if (c is ComboBox cmb) cmb.SelectedIndex = -1;
                else if (c is CheckBox chk) chk.Checked = false;
                else if (c is RadioButton rdb) rdb.Checked = false;

                if (c.HasChildren) ClearControls(c);
            }
        }

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                _visitDetailsDTO = await _patientVisitService.GetPatientVisitByIdAsync(_currentVisitId);

                if (_visitDetailsDTO == null)
                {
                    MessageBox.Show("لم يتم العثور على بيانات هذه الزيارة، قد تكون قد حُذفت.", "خطأ في البيانات",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب البيانات من الخادم:\n{ex.Message}", "خطأ في قاعدة البيانات",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return false;
            }
        }

        private void _MappingDataFormDTOsToControls()
        {
            try
            {
                var view = _visitDetailsDTO;
                if (view == null) return;

                // 🌟 تحديث المعرفات الداخلية الهامة حتى لا يفشل الـ Validation عند الحفظ
                _selectedAppointmentId = view.AppointmentId;

                txtAppointmentId.Text = view.AppointmentId.ToString();
                txtBloodPressure.Text = view.BloodPressure;
                txtDiagnosis.Text = view.Diagnosis;
                txtHeartRate.Text = view.HeartRate?.ToString();
                txtHeight.Text = view.Height?.ToString("0.0");
                txtNotes.Text = view.Notes;
            
                txtSymptoms.Text = view.Symptoms;
                txtTemperature.Text = view.Temperature?.ToString("0.0");
                txtTreatmentPlan.Text = view.TreatmentPlan;
                txtWeight.Text = view.Weight?.ToString("0.0");
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

        // 🌟 تحويل الدالة إلى Task لتتوافق مع الـ Async/Await بشكل سليم
        private async Task _LoadVisitData()
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

        private void tlpColumnsContainer_Paint(object sender, PaintEventArgs e) { }
    }
}