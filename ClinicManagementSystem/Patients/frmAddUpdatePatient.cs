using ClinicBusiness.DTO.PatientsDTOs;
using ClinicBusiness.DTO.PeopleDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAddUpdatePatient : Form
    {
        private readonly int _patientID = -1;

        // كائن لحفظ البيانات محلياً أثناء الإضافة أو التعديل
        private PatientSaveDTO _patientSaveDto;

        // 1. باني موحد يتكفل بالحالتين (الإضافة والتعديل)
        public frmAddUpdatePatient(int patientID = -1)
        {
            InitializeComponent();
            _patientID = patientID;
        }

        private async void frmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            _resetDefaultValues();

            if (_patientID == -1)
            {
                if (lblFormTitle != null) lblFormTitle.Text = "إضافة مريض جديد";
                this.Text = "إضافة مريض جديد";
            }
            else
            {
                if (lblFormTitle != null) lblFormTitle.Text = "تعديل بيانات المريض";
                this.Text = "تعديل بيانات المريض";
                await _LoadPatientData();
            }
        }

        private void _resetDefaultValues()
        {
            if (cmbGender.Items.Count > 0) cmbGender.SelectedIndex = 0; // ذكر افتراضياً
            if (cmbBloodType.Items.Count > 0) cmbBloodType.SelectedIndex = cmbBloodType.Items.Count - 1; // "غير معروف"

            dtpDateOfBirth.MaxDate = DateTime.Now;

            txtFirstName.Text = "";
            txtFatherName.Text = "";
            txtGrandFatherName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtEmergencyName.Text = "";
            txtEmergencyPhone.Text = "";
            rtbAddress.Text = "";
        }

        private async Task _LoadPatientData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // جلب البيانات مع فتح سياق معزول ونظيف
                using (var freshContext = new ClinicManagementSystemContext())
                {
                    var isolatedPatientService = new clsPatient(freshContext);
                    _patientSaveDto = await isolatedPatientService.GetPatientByIdAsync(_patientID);
                }

                if (_patientSaveDto == null || _patientSaveDto.Person == null || _patientSaveDto.PatientDetails == null)
                {
                    MessageBox.Show("عذراً، لم يتم العثور على بيانات هذا المريض في النظام.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 1. ملء بيانات الشخص الأساسية من كائن Person
                txtFirstName.Text = _patientSaveDto.Person.FirstName;
                txtFatherName.Text = _patientSaveDto.Person.SecondName;
                txtGrandFatherName.Text = _patientSaveDto.Person.ThirdName;
                txtLastName.Text = _patientSaveDto.Person.LastName;
                txtNationalNo.Text = _patientSaveDto.Person.NationalNumber;

                string genderText = _patientSaveDto.Person.Gender ? "ذكر" : "أنثى";
                cmbGender.SelectedIndex = cmbGender.FindString(genderText);

                dtpDateOfBirth.Value = _patientSaveDto.Person.DateOfBirth.ToDateTime(TimeOnly.MinValue);

                txtPhone1.Text = _patientSaveDto.Person.Phone;
                txtEmail.Text = _patientSaveDto.Person.Email;
                rtbAddress.Text = _patientSaveDto.Person.Address;

                // 2. ملء البيانات الطبية ومعلومات الطوارئ من كائن PatientDetails
                cmbBloodType.SelectedIndex = cmbBloodType.FindString(_patientSaveDto.PatientDetails.BloodType ?? "غير معروف");
                txtPhone2.Text = _patientSaveDto.PatientDetails.PhoneNumber;
                txtEmergencyName.Text = _patientSaveDto.PatientDetails.EmergencyContact;
                txtEmergencyPhone.Text = _patientSaveDto.PatientDetails.EmergencyPhone;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل بيانات المريض:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool _validateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المريض الأول واللقب على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tabControl != null && tpPersonalInfo != null) tabControl.SelectedTab = tpPersonalInfo;
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                MessageBox.Show("يرجى إدخال الرقم القومي / الهوية للمريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tabControl != null && tpPersonalInfo != null) tabControl.SelectedTab = tpPersonalInfo;
                txtNationalNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone1.Text))
            {
                MessageBox.Show("رقم الهاتف الأول يعتبر حقلاً إلزامياً للتواصل مع المريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tabControl != null && tpContactInfo != null) tabControl.SelectedTab = tpContactInfo;
                txtPhone1.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!_validateRequiredFields())
                return;

            // تهيئة كائنات الـ DTO إن كانت null (في حالة الإضافة الجديدة)
            if (_patientSaveDto == null) _patientSaveDto = new PatientSaveDTO();
            if (_patientSaveDto.Person == null) _patientSaveDto.Person = new PersonSaveDTO();
            if (_patientSaveDto.PatientDetails == null) _patientSaveDto.PatientDetails = new PatientViewDTO();

            // 1. إسناد الحقول لكائن Person
            _patientSaveDto.Person.FirstName = txtFirstName.Text.Trim();
            _patientSaveDto.Person.SecondName = txtFatherName.Text.Trim();
            _patientSaveDto.Person.ThirdName = txtGrandFatherName.Text.Trim();
            _patientSaveDto.Person.LastName = txtLastName.Text.Trim();
            _patientSaveDto.Person.NationalNumber = txtNationalNo.Text.Trim();
            _patientSaveDto.Person.Gender = (cmbGender.SelectedIndex == 0); // index 0 = ذكر
            _patientSaveDto.Person.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            _patientSaveDto.Person.Phone = txtPhone1.Text.Trim();
            _patientSaveDto.Person.Email = txtEmail.Text.Trim();
            _patientSaveDto.Person.Address = rtbAddress.Text.Trim();

            // 2. إسناد الحقول لكائن PatientDetails
            _patientSaveDto.PatientDetails.BloodType = cmbBloodType.SelectedItem?.ToString() ?? "غير معروف";
            _patientSaveDto.PatientDetails.PhoneNumber = txtPhone2.Text.Trim();
            _patientSaveDto.PatientDetails.EmergencyContact = txtEmergencyName.Text.Trim();
            _patientSaveDto.PatientDetails.EmergencyPhone = txtEmergencyPhone.Text.Trim();
            _patientSaveDto.PatientDetails.IsActive = true;

            btnSave.Enabled = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (var freshContext = new ClinicManagementSystemContext())
                {
                    var isolatedPatientService = new clsPatient(freshContext);

                    if (_patientID == -1)
                    {
                        // === وضع الإضافة ===
                        int newPatientId = await isolatedPatientService.AddNewPatientAsync(_patientSaveDto);

                        if (newPatientId > 0)
                        {
                            MessageBox.Show("تم حفظ بيانات المريض الجديد بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("فشلت عملية إضافة المريض، يرجى التحقق من البيانات والمدخلات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // === وضع التعديل ===
                        // 🔑 التأكيد على وجود المعرّفات الصحيحة حتى يميّز EF Core عملية التحديث
                        _patientSaveDto.PatientDetails.PatientId = _patientID;

                        bool isUpdated = await isolatedPatientService.UpdatePatientAsync(_patientSaveDto);

                        if (isUpdated)
                        {
                            MessageBox.Show("تم تحديث بيانات المريض بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("فشلت عملية تحديث البيانات المحددة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ في النظام أثناء معالجة البيانات:\n{ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }
    }
}