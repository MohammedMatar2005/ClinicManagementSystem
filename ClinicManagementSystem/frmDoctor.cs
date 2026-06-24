using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس
using ClinicBusiness.Services;
using ClinicBusiness.Utils;   // في حال وجود دالة التشفير SecUtil أو ما يشابهها
using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusiness.DTO;
using ClinicBusiness.DTO.DoctorsDTOs;
using ClinicBusiness.DTO.PeopleDTOs;
using ClinicBusiness.DTO.UsersDTOs;

namespace ClinicManagementSystem
{
    public partial class frmDoctor : Form
    {
        private static readonly Color ColorPrimary = Color.FromArgb(37, 99, 235); // أزرق رئيسي
        private static readonly Color ColorSuccess = Color.FromArgb(37, 162, 87); // أخضر الحفظ
        private static readonly Color ColorNeutral = Color.FromArgb(160, 174, 192); // رمادي السابق/الإلغاء

        // الاعتماد مباشرة على الـ DbContext والسيرفس
        private readonly ClinicManagementSystemContext _context;
        private readonly clsDoctor _doctorService;

        // عناوين المراحل الثلاث
        private static readonly string[] StepTitles = {
            "المعلومات الشخصية",
            "بيانات حساب المستخدم",
            "البيانات المهنية للطبيب"
        };

        public frmDoctor()
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم والسيرفس
            _context = new ClinicManagementSystemContext();
            _doctorService = new clsDoctor(_context);
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            InitializeNumericControls();
            InitializeDefaultValues();
            UpdateButtonStates(); // ضبط حالة الأزرار والعناوين عند الإقلاع
        }

        private void InitializeComboBoxes()
        {
            // الجنس
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.SelectedIndex = 0;

            // الصلاحية
            cmbRoleId.Items.Clear();
            cmbRoleId.Items.Add("طبيب");
            cmbRoleId.SelectedIndex = 0;
        }

        private void InitializeNumericControls()
        {
            nudSalary.Minimum = 0;
            nudSalary.Maximum = 999_999;
            nudSalary.DecimalPlaces = 2;
            nudSalary.ThousandsSeparator = true;
            nudSalary.Value = 0;

            nudExperienceYears.Minimum = 0;
            nudExperienceYears.Maximum = 60;
            nudExperienceYears.Value = 0;
        }

        private void InitializeDefaultValues()
        {
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-30);
            chkUserIsActive.Checked = true;
            chkDoctorIsActive.Checked = true;
            wizardTabs.SelectedIndex = 0;
        }

        private void UpdateButtonStates()
        {
            int currentStep = wizardTabs.SelectedIndex;
            int totalSteps = wizardTabs.TabCount;

            // تحديث عنوان المرحلة الحالية في الفورم إن وجد ليبل للعناوين
            this.Text = $"إضافة طبيب جديد - {StepTitles[currentStep]}";

            if (currentStep == 0)
            {
                // الخطوة الأولى
                btnNext.Visible = true;
                btnSave.Visible = false;
                btnNext.BringToFront();
                btnBack.Visible = false;
            }
            else if (currentStep < totalSteps - 1)
            {
                // الخطوات الوسطى
                btnNext.Visible = true;
                btnSave.Visible = false;
                btnNext.BringToFront();
                btnBack.Visible = true;
                btnBack.BringToFront();
            }
            else
            {
                // الخطوة الأخيرة
                btnNext.Visible = false;
                btnSave.Visible = true;
                btnSave.BringToFront();
                btnBack.Visible = true;
                btnBack.BringToFront();
            }
        }

        // حدث نقرة زر التالي الموحد لتنفيذ التحقق أولاً
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            int current = wizardTabs.SelectedIndex;

            if (!ValidateCurrentStep(current))
                return;

            if (wizardTabs.SelectedIndex < wizardTabs.TabCount - 1)
            {
                wizardTabs.SelectedIndex++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex > 0)
            {
                wizardTabs.SelectedIndex--;
            }
        }

        // حدث تغيير التاب يدوياً أو برمجياً لتحديث حالة الأزرار فوراً
        private void wizardTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int current = wizardTabs.SelectedIndex;

            if (!ValidateCurrentStep(current))
                return;

            SaveDoctor();
        }

        private bool ValidateCurrentStep(int stepIndex)
        {
            return stepIndex switch
            {
                0 => ValidatePersonalInfo(),
                1 => ValidateCredentials(),
                2 => ValidateProfessionalInfo(),
                _ => true
            };
        }

        private bool ValidatePersonalInfo()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowValidationError("الاسم الأول حقل إجباري.", txtFirstName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowValidationError("اللقب / العائلة حقل إجباري.", txtLastName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                ShowValidationError("رقم الجوال حقل إجباري.", txtPhone);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNumber.Text))
            {
                ShowValidationError("الرقم الوطني حقل إجباري.", txtNationalNumber);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                ShowValidationError("صيغة البريد الإلكتروني غير صحيحة.", txtEmail);
                return false;
            }

            return true;
        }

        private bool ValidateCredentials()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowValidationError("اسم المستخدم حقل إجباري.", txtUsername);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowValidationError("كلمة المرور حقل إجباري.", txtPassword);
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                ShowValidationError("كلمة المرور يجب أن تتكون من 6 أحرف على الأقل.", txtPassword);
                return false;
            }

            if (cmbRoleId.SelectedIndex < 0)
            {
                ShowValidationError("يرجى تحديد الصلاحية / الدور.", cmbRoleId);
                return false;
            }

            return true;
        }

        private bool ValidateProfessionalInfo()
        {
            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                ShowValidationError("التخصص الطبي حقل إجباري.", txtSpecialization);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                ShowValidationError("رقم الرخصة الطبية حقل إجباري.", txtLicenseNumber);
                return false;
            }

            return true;
        }

        private async void SaveDoctor()
        {
            try
            {
                // ── 1. إنشاء وكتابة كائن الشخص (Person) ──
                var doctorSaveDto = new DoctorSaveDTO
                {
                    // ── 2. تعبئة بيانات الشخص الشخصية ──
                    Person = new PersonSaveDTO
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        SecondName = txtSecondName.Text.Trim(),
                        ThirdName = txtThirdName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value),
                        Gender = cmbGender.SelectedItem?.ToString() == "ذكر" ? true : false,
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        NationalNumber = txtNationalNumber.Text.Trim(),
                        Address = txtAddress.Text.Trim()
                    },

                    // ── 3. تعبئة بيانات الحساب (User) ──
                    User = new UserSaveDTO 
                    {
                        Username = txtUsername.Text.Trim(),
                        PasswordHash = txtPassword.Text.Trim(), // سيتم تشفيره لاحقاً في السيرفس أو هنا
                        IsActive = chkUserIsActive.Checked,
                        RoleId = 1 // أو جلب القيمة من الكومبو بوكس إن وجدت ديناميكياً
                    },

                    // ── 4. تعبئة البيانات المهنية الخاصة بالطبيب ──
                    DoctorDetails = new DoctorDetailsDTO
                    {
                        Specialization = txtSpecialization.Text.Trim(),
                        LicenseNumber = txtLicenseNumber.Text.Trim(),
                        Salary = nudSalary.Value,
                        OfficeLocation = txtOfficeLocation.Text.Trim(),
                        ExperienceYears = (byte)nudExperienceYears.Value,
                        IsActive = chkDoctorIsActive.Checked
                    }
                };
                // ── 4. استدعاء السيرفس بشكل غير متزامن بالكامل ──
                int newId = await _doctorService.AddNewDoctorAsync(doctorSaveDto);

                if (newId <= 0)
                    throw new Exception("فشل حفظ بيانات الطبيب في قاعدة البيانات.");

                // ── 5. إبلاغ المستخدم بالنجاح ──
                MessageBox.Show(
                    "تم حفظ بيانات الطبيب وحسابه بنجاح.",
                    "تم الحفظ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ أثناء حفظ البيانات:\n{ex.Message}",
                    "خطأ في الحفظ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private static void ShowValidationError(string message, Control focusControl)
        {
            MessageBox.Show(
                message,
                "بيانات غير مكتملة",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            focusControl.Focus();
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}