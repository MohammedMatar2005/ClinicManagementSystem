using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmAddUpdateDoctor : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            pnlBody = new Panel();
            wizardTabs = new TabControl();
            tpPersonalInfo = new TabPage();
            tlpPersonal = new TableLayoutPanel();
            lblFullName = new Label();
            pnlNameFields = new Panel();
            tlpNameFields = new TableLayoutPanel();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtThirdName = new TextBox();
            txtLastName = new TextBox();
            lblNationalNo = new Label();
            txtNationalNo = new TextBox();
            lblBirthDate = new Label();
            lblGender = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            lblEmail = new Label();
            lblPhone = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tpUserInfo = new TabPage();
            tlpUser = new TableLayoutPanel();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPermissions = new Label();
            cmbRoleId = new ComboBox();
            lblUserIsActive = new Label();
            chkUserIsActive = new CheckBox();
            tpProfessionalInfo = new TabPage();
            tlpProfessional = new TableLayoutPanel();
            lblLicenseNo = new Label();
            lblSpecialization = new Label();
            txtLicenseNo = new TextBox();
            txtSpecialization = new TextBox();
            lblSalary = new Label();
            lblExperienceYears = new Label();
            nudSalary = new NumericUpDown();
            nudExperienceYears = new NumericUpDown();
            lblClinicRoom = new Label();
            txtClinicRoom = new TextBox();
            lblDoctorIsActive = new Label();
            chkDoctorIsActive = new CheckBox();
            pnlFooter = new Panel();
            tlpFooter = new TableLayoutPanel();
            btnClose = new Button();
            btnSave = new Button();
            btnBack = new Button();
            btnNext = new Button();
            mainLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            wizardTabs.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tlpPersonal.SuspendLayout();
            pnlNameFields.SuspendLayout();
            tlpNameFields.SuspendLayout();
            tpUserInfo.SuspendLayout();
            tlpUser.SuspendLayout();
            tpProfessionalInfo.SuspendLayout();
            tlpProfessional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudExperienceYears).BeginInit();
            pnlFooter.SuspendLayout();
            tlpFooter.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(pnlHeader, 0, 0);
            mainLayout.Controls.Add(pnlBody, 0, 1);
            mainLayout.Controls.Add(pnlFooter, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            mainLayout.Size = new Size(720, 640);
            mainLayout.TabIndex = 10;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 37, 51);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(714, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(714, 54);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "تسجيل طبيب جديد";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(wizardTabs);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 63);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(15);
            pnlBody.Size = new Size(714, 518);
            pnlBody.TabIndex = 2;
            // 
            // wizardTabs
            // 
            wizardTabs.Controls.Add(tpPersonalInfo);
            wizardTabs.Controls.Add(tpUserInfo);
            wizardTabs.Controls.Add(tpProfessionalInfo);
            wizardTabs.Dock = DockStyle.Fill;
            wizardTabs.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            wizardTabs.Location = new Point(15, 15);
            wizardTabs.Name = "wizardTabs";
            wizardTabs.SelectedIndex = 0;
            wizardTabs.Size = new Size(684, 488);
            wizardTabs.TabIndex = 0;
            wizardTabs.SelectedIndexChanged += wizardTabs_SelectedIndexChanged;
            wizardTabs.Selecting += wizardTabs_Selecting;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.BackColor = Color.White;
            tpPersonalInfo.Controls.Add(tlpPersonal);
            tpPersonalInfo.Location = new Point(4, 26);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(10);
            tpPersonalInfo.Size = new Size(676, 458);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "البيانات الشخصية";
            // 
            // tlpPersonal
            // 
            tlpPersonal.ColumnCount = 2;
            tlpPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.37107F));
            tlpPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.62893F));
            tlpPersonal.Controls.Add(lblFullName, 0, 0);
            tlpPersonal.Controls.Add(pnlNameFields, 0, 1);
            tlpPersonal.Controls.Add(lblNationalNo, 0, 2);
            tlpPersonal.Controls.Add(txtNationalNo, 0, 3);
            tlpPersonal.Controls.Add(lblBirthDate, 0, 4);
            tlpPersonal.Controls.Add(lblGender, 1, 4);
            tlpPersonal.Controls.Add(dtpDateOfBirth, 0, 5);
            tlpPersonal.Controls.Add(cmbGender, 1, 5);
            tlpPersonal.Controls.Add(lblEmail, 0, 6);
            tlpPersonal.Controls.Add(lblPhone, 1, 6);
            tlpPersonal.Controls.Add(txtEmail, 0, 7);
            tlpPersonal.Controls.Add(txtPhone, 1, 7);
            tlpPersonal.Controls.Add(lblAddress, 0, 8);
            tlpPersonal.Controls.Add(txtAddress, 0, 9);
            tlpPersonal.Dock = DockStyle.Fill;
            tlpPersonal.Location = new Point(10, 10);
            tlpPersonal.Name = "tlpPersonal";
            tlpPersonal.Padding = new Padding(10);
            tlpPersonal.RowCount = 9;
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpPersonal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPersonal.Size = new Size(656, 438);
            tlpPersonal.TabIndex = 0;
            // 
            // lblFullName
            // 
            tlpPersonal.SetColumnSpan(lblFullName, 2);
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(55, 65, 81);
            lblFullName.Location = new Point(13, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(630, 26);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "الاسم الرباعي (الأول — الثاني — الثالث — العائلة):";
            lblFullName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlNameFields
            // 
            tlpPersonal.SetColumnSpan(pnlNameFields, 2);
            pnlNameFields.Controls.Add(tlpNameFields);
            pnlNameFields.Dock = DockStyle.Fill;
            pnlNameFields.Location = new Point(13, 39);
            pnlNameFields.Name = "pnlNameFields";
            pnlNameFields.Size = new Size(630, 28);
            pnlNameFields.TabIndex = 99;
            // 
            // tlpNameFields
            // 
            tlpNameFields.ColumnCount = 4;
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.4285717F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.015873F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2857151F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            tlpNameFields.Controls.Add(txtFirstName, 0, 0);
            tlpNameFields.Controls.Add(txtSecondName, 1, 0);
            tlpNameFields.Controls.Add(txtThirdName, 2, 0);
            tlpNameFields.Controls.Add(txtLastName, 3, 0);
            tlpNameFields.Dock = DockStyle.Fill;
            tlpNameFields.Location = new Point(0, 0);
            tlpNameFields.Name = "tlpNameFields";
            tlpNameFields.RowCount = 1;
            tlpNameFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNameFields.Size = new Size(630, 28);
            tlpNameFields.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(435, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "الأول";
            txtFirstName.Size = new Size(192, 24);
            txtFirstName.TabIndex = 3;
            // 
            // txtSecondName
            // 
            txtSecondName.BorderStyle = BorderStyle.FixedSingle;
            txtSecondName.Dock = DockStyle.Fill;
            txtSecondName.Font = new Font("Segoe UI", 9.5F);
            txtSecondName.Location = new Point(290, 3);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.PlaceholderText = "الثاني";
            txtSecondName.Size = new Size(139, 24);
            txtSecondName.TabIndex = 4;
            // 
            // txtThirdName
            // 
            txtThirdName.BorderStyle = BorderStyle.FixedSingle;
            txtThirdName.Dock = DockStyle.Fill;
            txtThirdName.Font = new Font("Segoe UI", 9.5F);
            txtThirdName.Location = new Point(137, 3);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.PlaceholderText = "الثالث";
            txtThirdName.Size = new Size(147, 24);
            txtThirdName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(3, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "العائلة";
            txtLastName.Size = new Size(128, 24);
            txtLastName.TabIndex = 6;
            // 
            // lblNationalNo
            // 
            tlpPersonal.SetColumnSpan(lblNationalNo, 2);
            lblNationalNo.Dock = DockStyle.Fill;
            lblNationalNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNationalNo.ForeColor = Color.FromArgb(55, 65, 81);
            lblNationalNo.Location = new Point(13, 70);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(630, 26);
            lblNationalNo.TabIndex = 0;
            lblNationalNo.Text = "الرقم الوطني / الهوية:";
            lblNationalNo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNationalNo
            // 
            txtNationalNo.BorderStyle = BorderStyle.FixedSingle;
            tlpPersonal.SetColumnSpan(txtNationalNo, 2);
            txtNationalNo.Dock = DockStyle.Fill;
            txtNationalNo.Font = new Font("Segoe UI", 9.5F);
            txtNationalNo.Location = new Point(13, 99);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(630, 24);
            txtNationalNo.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Dock = DockStyle.Fill;
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBirthDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblBirthDate.Location = new Point(335, 130);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(308, 26);
            lblBirthDate.TabIndex = 9;
            lblBirthDate.Text = "تاريخ الميلاد:";
            lblBirthDate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblGender
            // 
            lblGender.Dock = DockStyle.Fill;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(55, 65, 81);
            lblGender.Location = new Point(13, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(316, 26);
            lblGender.TabIndex = 7;
            lblGender.Text = "الجنس:";
            lblGender.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Dock = DockStyle.Fill;
            dtpDateOfBirth.Font = new Font("Segoe UI", 9.5F);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(335, 159);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(308, 24);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.Dock = DockStyle.Fill;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 9.5F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.Location = new Point(13, 159);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(316, 25);
            cmbGender.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmail.Location = new Point(335, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(308, 26);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "البريد الإلكتروني:";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPhone
            // 
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone.Location = new Point(13, 190);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(316, 26);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "رقم الهاتف:";
            lblPhone.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(335, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 24);
            txtEmail.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = new Font("Segoe UI", 9.5F);
            txtPhone.Location = new Point(13, 219);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(316, 24);
            txtPhone.TabIndex = 12;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // lblAddress
            // 
            tlpPersonal.SetColumnSpan(lblAddress, 2);
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(55, 65, 81);
            lblAddress.Location = new Point(13, 250);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(630, 26);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "العنوان:";
            lblAddress.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            tlpPersonal.SetColumnSpan(txtAddress, 2);
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(13, 279);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(630, 146);
            txtAddress.TabIndex = 16;
            // 
            // tpUserInfo
            // 
            tpUserInfo.BackColor = Color.White;
            tpUserInfo.Controls.Add(tlpUser);
            tpUserInfo.Location = new Point(4, 26);
            tpUserInfo.Name = "tpUserInfo";
            tpUserInfo.Padding = new Padding(10);
            tpUserInfo.Size = new Size(676, 458);
            tpUserInfo.TabIndex = 2;
            tpUserInfo.Text = "حساب المستخدم";
            // 
            // tlpUser
            // 
            tlpUser.ColumnCount = 2;
            tlpUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUser.Controls.Add(lblPassword, 0, 0);
            tlpUser.Controls.Add(lblUsername, 1, 0);
            tlpUser.Controls.Add(txtPassword, 0, 1);
            tlpUser.Controls.Add(txtUsername, 1, 1);
            tlpUser.Controls.Add(lblPermissions, 0, 2);
            tlpUser.Controls.Add(cmbRoleId, 0, 3);
            tlpUser.Controls.Add(lblUserIsActive, 0, 4);
            tlpUser.Controls.Add(chkUserIsActive, 0, 5);
            tlpUser.Dock = DockStyle.Fill;
            tlpUser.Location = new Point(10, 10);
            tlpUser.Name = "tlpUser";
            tlpUser.Padding = new Padding(10);
            tlpUser.RowCount = 7;
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUser.Size = new Size(656, 438);
            tlpUser.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(55, 65, 81);
            lblPassword.Location = new Point(331, 10);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(312, 26);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "كلمة المرور:";
            lblPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblUsername
            // 
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(55, 65, 81);
            lblUsername.Location = new Point(13, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(312, 26);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "اسم المستخدم:";
            lblUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(331, 39);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 24);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 9.5F);
            txtUsername.Location = new Point(13, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 24);
            txtUsername.TabIndex = 1;
            // 
            // lblPermissions
            // 
            tlpUser.SetColumnSpan(lblPermissions, 2);
            lblPermissions.Dock = DockStyle.Fill;
            lblPermissions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPermissions.ForeColor = Color.FromArgb(55, 65, 81);
            lblPermissions.Location = new Point(13, 70);
            lblPermissions.Name = "lblPermissions";
            lblPermissions.Size = new Size(630, 26);
            lblPermissions.TabIndex = 4;
            lblPermissions.Text = "الصلاحيات الممنوحة:";
            lblPermissions.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbRoleId
            // 
            tlpUser.SetColumnSpan(cmbRoleId, 2);
            cmbRoleId.Dock = DockStyle.Fill;
            cmbRoleId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleId.Font = new Font("Segoe UI", 9.5F);
            cmbRoleId.FormattingEnabled = true;
            cmbRoleId.Items.AddRange(new object[] { "طبيب" });
            cmbRoleId.Location = new Point(13, 99);
            cmbRoleId.Name = "cmbRoleId";
            cmbRoleId.Size = new Size(630, 25);
            cmbRoleId.TabIndex = 5;
            // 
            // lblUserIsActive
            // 
            tlpUser.SetColumnSpan(lblUserIsActive, 2);
            lblUserIsActive.Dock = DockStyle.Fill;
            lblUserIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserIsActive.ForeColor = Color.FromArgb(55, 65, 81);
            lblUserIsActive.Location = new Point(13, 130);
            lblUserIsActive.Name = "lblUserIsActive";
            lblUserIsActive.Size = new Size(630, 26);
            lblUserIsActive.TabIndex = 6;
            lblUserIsActive.Text = "حالة الحساب فور الإنشاء:";
            lblUserIsActive.TextAlign = ContentAlignment.BottomLeft;
            // 
            // chkUserIsActive
            // 
            tlpUser.SetColumnSpan(chkUserIsActive, 2);
            chkUserIsActive.Dock = DockStyle.Fill;
            chkUserIsActive.Font = new Font("Segoe UI", 9.5F);
            chkUserIsActive.Location = new Point(13, 159);
            chkUserIsActive.Name = "chkUserIsActive";
            chkUserIsActive.Size = new Size(630, 28);
            chkUserIsActive.TabIndex = 7;
            chkUserIsActive.Text = "الحساب نشط ومصرح له بالدخول فور الإنشاء";
            chkUserIsActive.UseVisualStyleBackColor = true;
            // 
            // tpProfessionalInfo
            // 
            tpProfessionalInfo.BackColor = Color.White;
            tpProfessionalInfo.Controls.Add(tlpProfessional);
            tpProfessionalInfo.Location = new Point(4, 26);
            tpProfessionalInfo.Name = "tpProfessionalInfo";
            tpProfessionalInfo.Padding = new Padding(10);
            tpProfessionalInfo.Size = new Size(676, 458);
            tpProfessionalInfo.TabIndex = 1;
            tpProfessionalInfo.Text = "البيانات المهنية";
            // 
            // tlpProfessional
            // 
            tlpProfessional.ColumnCount = 2;
            tlpProfessional.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProfessional.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProfessional.Controls.Add(lblLicenseNo, 0, 0);
            tlpProfessional.Controls.Add(lblSpecialization, 1, 0);
            tlpProfessional.Controls.Add(txtLicenseNo, 0, 1);
            tlpProfessional.Controls.Add(txtSpecialization, 1, 1);
            tlpProfessional.Controls.Add(lblSalary, 0, 2);
            tlpProfessional.Controls.Add(lblExperienceYears, 1, 2);
            tlpProfessional.Controls.Add(nudSalary, 0, 3);
            tlpProfessional.Controls.Add(nudExperienceYears, 1, 3);
            tlpProfessional.Controls.Add(lblClinicRoom, 0, 4);
            tlpProfessional.Controls.Add(txtClinicRoom, 0, 5);
            tlpProfessional.Controls.Add(lblDoctorIsActive, 0, 6);
            tlpProfessional.Controls.Add(chkDoctorIsActive, 0, 7);
            tlpProfessional.Dock = DockStyle.Fill;
            tlpProfessional.Location = new Point(10, 10);
            tlpProfessional.Name = "tlpProfessional";
            tlpProfessional.Padding = new Padding(10);
            tlpProfessional.RowCount = 8;
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpProfessional.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpProfessional.Size = new Size(656, 438);
            tlpProfessional.TabIndex = 0;
            // 
            // lblLicenseNo
            // 
            lblLicenseNo.Dock = DockStyle.Fill;
            lblLicenseNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLicenseNo.ForeColor = Color.FromArgb(55, 65, 81);
            lblLicenseNo.Location = new Point(331, 10);
            lblLicenseNo.Name = "lblLicenseNo";
            lblLicenseNo.Size = new Size(312, 26);
            lblLicenseNo.TabIndex = 2;
            lblLicenseNo.Text = "رقم ترخيص الممارسة:";
            lblLicenseNo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSpecialization
            // 
            lblSpecialization.Dock = DockStyle.Fill;
            lblSpecialization.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpecialization.ForeColor = Color.FromArgb(55, 65, 81);
            lblSpecialization.Location = new Point(13, 10);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(312, 26);
            lblSpecialization.TabIndex = 0;
            lblSpecialization.Text = "التخصص الطبي:";
            lblSpecialization.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.BorderStyle = BorderStyle.FixedSingle;
            txtLicenseNo.Dock = DockStyle.Fill;
            txtLicenseNo.Font = new Font("Segoe UI", 9.5F);
            txtLicenseNo.Location = new Point(331, 39);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(312, 24);
            txtLicenseNo.TabIndex = 3;
            // 
            // txtSpecialization
            // 
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Dock = DockStyle.Fill;
            txtSpecialization.Font = new Font("Segoe UI", 9.5F);
            txtSpecialization.Location = new Point(13, 39);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(312, 24);
            txtSpecialization.TabIndex = 1;
            // 
            // lblSalary
            // 
            lblSalary.Dock = DockStyle.Fill;
            lblSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalary.ForeColor = Color.FromArgb(55, 65, 81);
            lblSalary.Location = new Point(331, 70);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(312, 26);
            lblSalary.TabIndex = 6;
            lblSalary.Text = "الراتب الشهري (₪):";
            lblSalary.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblExperienceYears
            // 
            lblExperienceYears.Dock = DockStyle.Fill;
            lblExperienceYears.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExperienceYears.ForeColor = Color.FromArgb(55, 65, 81);
            lblExperienceYears.Location = new Point(13, 70);
            lblExperienceYears.Name = "lblExperienceYears";
            lblExperienceYears.Size = new Size(312, 26);
            lblExperienceYears.TabIndex = 4;
            lblExperienceYears.Text = "سنوات الخبرة:";
            lblExperienceYears.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudSalary
            // 
            nudSalary.DecimalPlaces = 2;
            nudSalary.Dock = DockStyle.Fill;
            nudSalary.Font = new Font("Segoe UI", 9.5F);
            nudSalary.Location = new Point(331, 99);
            nudSalary.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudSalary.Name = "nudSalary";
            nudSalary.Size = new Size(312, 24);
            nudSalary.TabIndex = 7;
            nudSalary.ThousandsSeparator = true;
            // 
            // nudExperienceYears
            // 
            nudExperienceYears.Dock = DockStyle.Fill;
            nudExperienceYears.Font = new Font("Segoe UI", 9.5F);
            nudExperienceYears.Location = new Point(13, 99);
            nudExperienceYears.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudExperienceYears.Name = "nudExperienceYears";
            nudExperienceYears.Size = new Size(312, 24);
            nudExperienceYears.TabIndex = 5;
            // 
            // lblClinicRoom
            // 
            tlpProfessional.SetColumnSpan(lblClinicRoom, 2);
            lblClinicRoom.Dock = DockStyle.Fill;
            lblClinicRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClinicRoom.ForeColor = Color.FromArgb(55, 65, 81);
            lblClinicRoom.Location = new Point(13, 130);
            lblClinicRoom.Name = "lblClinicRoom";
            lblClinicRoom.Size = new Size(630, 26);
            lblClinicRoom.TabIndex = 8;
            lblClinicRoom.Text = "رقم العيادة / المكتب:";
            lblClinicRoom.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtClinicRoom
            // 
            txtClinicRoom.BorderStyle = BorderStyle.FixedSingle;
            tlpProfessional.SetColumnSpan(txtClinicRoom, 2);
            txtClinicRoom.Dock = DockStyle.Fill;
            txtClinicRoom.Font = new Font("Segoe UI", 9.5F);
            txtClinicRoom.Location = new Point(13, 159);
            txtClinicRoom.Name = "txtClinicRoom";
            txtClinicRoom.Size = new Size(630, 24);
            txtClinicRoom.TabIndex = 9;
            // 
            // lblDoctorIsActive
            // 
            tlpProfessional.SetColumnSpan(lblDoctorIsActive, 2);
            lblDoctorIsActive.Dock = DockStyle.Fill;
            lblDoctorIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoctorIsActive.ForeColor = Color.FromArgb(55, 65, 81);
            lblDoctorIsActive.Location = new Point(13, 190);
            lblDoctorIsActive.Name = "lblDoctorIsActive";
            lblDoctorIsActive.Size = new Size(630, 26);
            lblDoctorIsActive.TabIndex = 10;
            lblDoctorIsActive.Text = "حالة الطبيب في المنظومة:";
            lblDoctorIsActive.TextAlign = ContentAlignment.BottomLeft;
            // 
            // chkDoctorIsActive
            // 
            tlpProfessional.SetColumnSpan(chkDoctorIsActive, 2);
            chkDoctorIsActive.Dock = DockStyle.Fill;
            chkDoctorIsActive.Font = new Font("Segoe UI", 9.5F);
            chkDoctorIsActive.Location = new Point(13, 219);
            chkDoctorIsActive.Name = "chkDoctorIsActive";
            chkDoctorIsActive.Size = new Size(630, 206);
            chkDoctorIsActive.TabIndex = 11;
            chkDoctorIsActive.Text = "طبيب نشط ومفعّل في المنظومة";
            chkDoctorIsActive.UseVisualStyleBackColor = true;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(tlpFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(3, 587);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(714, 50);
            pnlFooter.TabIndex = 1;
            // 
            // tlpFooter
            // 
            tlpFooter.ColumnCount = 5;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpFooter.Controls.Add(btnClose, 0, 0);
            tlpFooter.Controls.Add(btnSave, 1, 0);
            tlpFooter.Controls.Add(btnBack, 4, 0);
            tlpFooter.Controls.Add(btnNext, 3, 0);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(0, 0);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.Padding = new Padding(5);
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooter.Size = new Size(714, 50);
            tlpFooter.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(156, 163, 175);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(572, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(134, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "إلغاء";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 162, 87);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 130, 65);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(432, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(8, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 34);
            btnBack.TabIndex = 2;
            btnBack.Text = "السابق >>";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Dock = DockStyle.Fill;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(148, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(134, 34);
            btnNext.TabIndex = 3;
            btnNext.Text = "<<التالي";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // frmAddUpdateDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(720, 640);
            Controls.Add(mainLayout);
            MinimumSize = new Size(580, 520);
            Name = "frmAddUpdateDoctor";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل طبيب جديد";
            WindowState = FormWindowState.Maximized;
            Load += frmDoctor_Load;
            mainLayout.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            wizardTabs.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tlpPersonal.ResumeLayout(false);
            tlpPersonal.PerformLayout();
            pnlNameFields.ResumeLayout(false);
            tlpNameFields.ResumeLayout(false);
            tlpNameFields.PerformLayout();
            tpUserInfo.ResumeLayout(false);
            tlpUser.ResumeLayout(false);
            tlpUser.PerformLayout();
            tpProfessionalInfo.ResumeLayout(false);
            tlpProfessional.ResumeLayout(false);
            tlpProfessional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudExperienceYears).EndInit();
            pnlFooter.ResumeLayout(false);
            tlpFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ─── Layout ───────────────────────────────────────────────────────────
        private TableLayoutPanel mainLayout;      // [جديد] الهيكل الرئيسي للنافذة

        // ─── Panels ───────────────────────────────────────────────────────────
        private Panel pnlHeader;
        private Panel pnlFooter;
        private Panel pnlBody;
        private Panel pnlNameFields;              // [جديد] حاوية حقول الاسم الرباعي

        // ─── Labels ───────────────────────────────────────────────────────────
        private Label lblFormTitle;

        // ─── Tabs ─────────────────────────────────────────────────────────────
        private TabControl wizardTabs;
        private TabPage tpPersonalInfo;
        private TabPage tpProfessionalInfo;
        private TabPage tpUserInfo;

        // ─── Tab Layout Panels ────────────────────────────────────────────────
        private TableLayoutPanel tlpPersonal;     // [جديد] شبكة تبويب الشخصية
        private TableLayoutPanel tlpNameFields;   // [جديد] شبكة حقول الاسم
        private TableLayoutPanel tlpProfessional; // [جديد] شبكة تبويب المهنية
        private TableLayoutPanel tlpUser;         // [جديد] شبكة تبويب المستخدم

        // ─── Buttons ──────────────────────────────────────────────────────────
        private Button btnSave;
        private Button btnClose;
        private Button btnBack;
        private Button btnNext;

        // ─── Personal Fields ──────────────────────────────────────────────────
        private Label lblNationalNo;
        private TextBox txtNationalNo;
        private Label lblFullName;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblBirthDate;
        private DateTimePicker dtpDateOfBirth;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;

        // ─── Professional Fields ──────────────────────────────────────────────
        private Label lblSpecialization;
        private TextBox txtSpecialization;
        private Label lblLicenseNo;
        private TextBox txtLicenseNo;
        private Label lblExperienceYears;
        private NumericUpDown nudExperienceYears;
        private Label lblSalary;
        private NumericUpDown nudSalary;
        private Label lblClinicRoom;
        private TextBox txtClinicRoom;
        private Label lblDoctorIsActive;
        private CheckBox chkDoctorIsActive;

        // ─── User Fields ──────────────────────────────────────────────────────
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPermissions;
        private ComboBox cmbRoleId;
        private Label lblUserIsActive;
        private CheckBox chkUserIsActive;
        private TableLayoutPanel tlpFooter;
    }
}