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
    public partial class frmAddUpdateDoctor : Form
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

        public frmAddUpdateDoctor()
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم والسيرفس
            _context = new ClinicManagementSystemContext();
            _doctorService = new clsDoctor(_context);
            _doctorId = null;
        }

        private readonly int? _doctorId;

        public frmAddUpdateDoctor(int doctorId)
        {
            InitializeComponent();

            // حقن الـ Context مباشرة للفورم والسيرفس
            _context = new ClinicManagementSystemContext();
            _doctorService = new clsDoctor(_context);
            _doctorId = doctorId;


        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            InitializeNumericControls();
            InitializeDefaultValues();
            UpdateButtonStates();

            if (_doctorId.HasValue)
                LoadDoctorData(_doctorId.Value);
        }

        private async void LoadDoctorData(int doctorId)
        {
            try
            {
                var dto = await _doctorService.GetDoctorByIdAsync(doctorId);

                if (dto is null)
                {
                    MessageBox.Show(
                        "لم يتم العثور على بيانات الطبيب.",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.Close();
                    return;
                }

                // ── البيانات الشخصية ──
                txtFirstName.Text = dto.FirstName;
                txtSecondName.Text = dto.SecondName;
                txtThirdName.Text = dto.ThirdName;
                txtLastName.Text = dto.LastName;
                txtNationalNo.Text = dto.NationalNumber;
                txtPhone.Text = dto.Phone;
                txtEmail.Text = dto.Email;
                txtAddress.Text = dto.Address;

                dtpDateOfBirth.Value = dto.DateOfBirth.ToDateTime(TimeOnly.MinValue);
                cmbGender.SelectedIndex = dto.Gender == true ? 0 : 1; // 0=ذكر، 1=أنثى

                // ── بيانات الحساب ──
                txtUsername.Text = dto.Username;
                txtPassword.Text = string.Empty; // لا تعرض كلمة المرور أبداً
                chkUserIsActive.Checked = dto.DoctorIsActive;

                // ── البيانات المهنية ──
                txtSpecialization.Text = dto.Specialization;
                txtLicenseNo.Text = dto.LicenseNumber;
                txtClinicRoom.Text = dto.OfficeLocation;
                nudSalary.Value = dto.Salary ?? 0;
                nudExperienceYears.Value = dto.ExperienceYears ?? 0;
                chkDoctorIsActive.Checked = dto.DoctorIsActive;

                // ── تحديث عنوان النافذة ──
                this.Text = $"تعديل بيانات الطبيب - {dto.FirstName} {dto.LastName}";
                lblFormTitle.Text = $"تعديل بيانات الطبيب - {dto.FirstName} {dto.LastName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ أثناء تحميل البيانات:\n{ex.Message}",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
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

        // ✅ الكود الصحيح لـ UpdateButtonStates
        private void UpdateButtonStates()
        {
            int currentStep = wizardTabs.SelectedIndex;
            int totalSteps = wizardTabs.TabCount;

            this.Text = $"إضافة طبيب جديد - {StepTitles[currentStep]}";

            bool isFirst = currentStep == 0;
            bool isLast = currentStep == totalSteps - 1;

            btnBack.Visible = !isFirst;
            btnNext.Visible = !isLast;
            btnSave.Visible = isLast;
        }


        private void wizardTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
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

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                ShowValidationError("الرقم الوطني حقل إجباري.", txtNationalNo);
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

            if (string.IsNullOrWhiteSpace(txtLicenseNo.Text))
            {
                ShowValidationError("رقم الرخصة الطبية حقل إجباري.", txtLicenseNo);
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
                        NationalNumber = txtNationalNo.Text.Trim(),
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
                        LicenseNumber = txtLicenseNo.Text.Trim(),
                        Salary = nudSalary.Value,
                        OfficeLocation = txtAddress.Text.Trim(),
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < wizardTabs.TabCount; i++)
            {
                if (!ValidateCurrentStep(i))
                {
                    wizardTabs.SelectedIndex = i;
                    return;
                }
            }

            SaveDoctor();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (!ValidateCurrentStep(wizardTabs.SelectedIndex)) return;

            if (wizardTabs.SelectedIndex < wizardTabs.TabCount - 1)
                wizardTabs.SelectedIndex++;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (wizardTabs.SelectedIndex > 0)
            {
                wizardTabs.SelectedIndex--;
            }
        }



      
    }
}