using ClinicBusiness.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Models;
using ClinicBusiness.DTO.PatientsDTOs;

namespace ClinicManagementSystem
{
    public partial class frmShowPatientInfo : Form
    {
        private readonly clsPatient _patientService;
        private readonly int _selectedPatientId;
        private PatientSaveDTO _patientSaveDTO;

        public frmShowPatientInfo(int selectedPatientId)
        {
            InitializeComponent();
            _selectedPatientId = selectedPatientId;

            // إنشاء الـ Context وحقنه في السيرفس
            var context = new ClinicManagementSystemContext();
            _patientService = new clsPatient(context);

            // ربط الأحداث (كانت غير موجودة في كود المصمم المرفق)
            Load += frmShowPatientInfo_Load;
            btnClose.Click += btnClose_Click;
        }

        private async Task<bool> _FillDataInDTOs()
        {
            try
            {
                // جلب كائن الـ DTO المجمع بالكامل في طلب واحد فقط للخادم
                _patientSaveDTO = await _patientService.GetPatientByIdAsync(_selectedPatientId);

                // إذا كان الـ DTO فارغاً، فهذا يعني أن المريض غير موجود في قاعدة البيانات
                if (_patientSaveDTO == null || _patientSaveDTO.PatientDetails == null)
                {
                    MessageBox.Show(
                        "لم يتم العثور على بيانات هذا المريض، قد يكون قد تم حذفه.",
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
                var patient = _patientSaveDTO.PatientDetails;

                // ── تبويب البيانات الشخصية ──
                txtNationalNo.Text = patient.NationalNumber;
                txtFullName.Text = patient.PatientFullName;
                txtAge.Text = patient.Age.ToString();
                txtPhone.Text = patient.PhoneNumber;
                txtEmail.Text = patient.Email;

                // ── تبويب البيانات الطبية والطوارئ ──
                txtBloodType.Text = patient.BloodType;
                txtEmergencyContact.Text = patient.EmergencyContact;
                txtEmergencyPhone.Text = patient.EmergencyPhone;
                txtPatientId.Text = patient.PatientId.ToString();
                txtPersonId.Text = patient.PersonId.ToString();
                txtCreatedDate.Text = patient.CreatedDate.ToString("yyyy-MM-dd HH:mm");
                txtAllergies.Text = patient.Allergies;
                txtMedicalHistory.Text = patient.MedicalHistory;
                chkIsActive.Checked = patient.IsActive;
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

        private async void _LoadPatientData()
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
                MessageBox.Show($"فشل تحميل واجهة المريض: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        private void frmShowPatientInfo_Load(object sender, EventArgs e)
        {
            _LoadPatientData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}