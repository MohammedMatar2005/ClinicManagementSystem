using ClinicBusiness.DTO.PatientsDTOs;
using ClinicBusiness.DTO.PeopleDTOs;
using ClinicBusiness.Models;
using ClinicBusiness.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAddUpdatePatient : Form
    {
        // تعريف نمط الشاشة الحالي (إضافة أم تعديل)

        // تعديل السيرفيس لتتوافق مع اسم الكلاس لديك
        private readonly clsPatient _patientService;
        private readonly int _patientID;

        private readonly ClinicManagementSystemContext _context;

        // كائن لحفظ البيانات محلياً أثناء الإضافة أو التعديل
        private PatientSaveDTO _patientSaveDto;

        public frmAddUpdatePatient()
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();

            _patientService = new clsPatient(_context); // تهيئة السيرفيس


        }

        public frmAddUpdatePatient(int patientID)
        {
            InitializeComponent();
            _context = new ClinicManagementSystemContext();


            _patientService = new clsPatient(_context); // تهيئة السيرفيس
            _patientID = patientID;


        }

        private async void frmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            if (_patientID == 0)
                _resetDefaultValues();
            else
                await _LoadPatientData();

        }

        private void _resetDefaultValues()
        {


            if (cmbGender.Items.Count > 0) cmbGender.SelectedIndex = 0; // ذكر افتراضياً
            if (cmbBloodType.Items.Count > 0) cmbBloodType.SelectedIndex = 8; // "غير معروف"

            // تحديد الحد الأقصى لتاريخ الميلاد (اليوم)
            dtpDateOfBirth.MaxDate = DateTime.Now;

            // تنظيف الحقول
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
            // جلب البيانات بالـ DTO المتداخل الجديد
            _patientSaveDto = await _patientService.GetPatientByIdAsync(_patientID);

            if (_patientSaveDto == null || _patientSaveDto.Person == null || _patientSaveDto.PatientDetails == null)
            {
                MessageBox.Show("عذراً، لم يتم العثور على بيانات هذا المريض في النظام.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 1. ملء بيانات الشخص الأساسية (الاسم الرباعي والتفاصيل) من كائن Person
            txtFirstName.Text = _patientSaveDto.Person.FirstName;
            txtFatherName.Text = _patientSaveDto.Person.SecondName;
            txtGrandFatherName.Text = _patientSaveDto.Person.ThirdName;
            txtLastName.Text = _patientSaveDto.Person.LastName;
            txtNationalNo.Text = _patientSaveDto.Person.NationalNumber;

            // 🛠️ تعديل عرض الجنس بناءً على قيمة الـ bool (true = ذكر، false = أنثى)
            string genderText = _patientSaveDto.Person.Gender ? "ذكر" : "أنثى";
            cmbGender.SelectedIndex = cmbGender.FindString(genderText);

            // تحويل الـ DateOnly القادم إلى DateTime ليعرض في الأداة بسلاسة
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

        /// <summary>
        /// التحقق من صحة المدخلات الإلزامية قبل الحفظ لضمان سلامة قاعدة البيانات
        /// </summary>
        private bool _validateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المريض الأول واللقب على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tpPersonalInfo;
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                MessageBox.Show("يرجى إدخال الرقم القومي / الهوية للمريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tpPersonalInfo;
                txtNationalNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone1.Text))
            {
                MessageBox.Show("رقم الهاتف الأول يعتبر حقلاً إلزامياً للتواصل مع المريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tpContactInfo;
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

            // إذا كنا في وضع الإضافة، نقوم بتهيئة الأوبجكتات الفرعية لكي لا تكون Null
            if (_patientSaveDto == null) _patientSaveDto = new PatientSaveDTO();
            if (_patientSaveDto.Person == null) _patientSaveDto.Person = new PersonSaveDTO();
            if (_patientSaveDto.PatientDetails == null) _patientSaveDto.PatientDetails = new PatientViewDTO();

            // 1. إسناد الحقول لكائن الـ Person
            _patientSaveDto.Person.FirstName = txtFirstName.Text.Trim();
            _patientSaveDto.Person.SecondName = txtFatherName.Text.Trim();
            _patientSaveDto.Person.ThirdName = txtGrandFatherName.Text.Trim();
            _patientSaveDto.Person.LastName = txtLastName.Text.Trim();
            _patientSaveDto.Person.NationalNumber = txtNationalNo.Text.Trim();

            // 🛠️ التعديل المطلوب: (إذا كان السطر المختار هو الأول "ذكر" يسند true، غير ذلك يسند false)
            _patientSaveDto.Person.Gender = (cmbGender.SelectedIndex == 0);

            _patientSaveDto.Person.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            _patientSaveDto.Person.Phone = txtPhone1.Text.Trim();
            _patientSaveDto.Person.Email = txtEmail.Text.Trim();
            _patientSaveDto.Person.Address = rtbAddress.Text.Trim();

            // 2. إسناد الحقول لكائن الـ PatientDetails الطبية
            _patientSaveDto.PatientDetails.BloodType = cmbBloodType.SelectedItem.ToString();
            _patientSaveDto.PatientDetails.EmergencyContact = txtEmergencyName.Text.Trim();
            _patientSaveDto.PatientDetails.EmergencyPhone = txtEmergencyPhone.Text.Trim();
            _patientSaveDto.PatientDetails.IsActive = true;

            try
            {

                int newPatientId = await _patientService.AddNewPatientAsync(_patientSaveDto);

                if (newPatientId > 0)
                {
                    MessageBox.Show("تم حفظ بيانات المريض الجديد بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("فشلت عملية إضافة المريض، يرجى التحقق من المدخلات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                _patientSaveDto.PatientDetails.PatientId = _patientID;

                bool isUpdated = await _patientService.UpdatePatientAsync(_patientSaveDto);

                if (isUpdated)
                {
                    MessageBox.Show("تم تحديث بيانات المريض بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("فشلت عملية تحديث البيانات المحددة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ في النظام أثناء معالجة البيانات:\n{ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}