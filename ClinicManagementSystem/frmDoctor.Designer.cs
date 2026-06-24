using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmDoctor : Form
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
            headerPanel = new TableLayoutPanel();
            lblStepCount = new Label();
            lblFormTitle = new Label();
            contentCard = new Panel();
            cardLayout = new TableLayoutPanel();
            wizardTabs = new TabControl();
            tabPersonal = new TabPage();
            scrollPersonal = new Panel();
            gridPersonal = new TableLayoutPanel();
            pnlFirstName = new FlowLayoutPanel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            pnlSecondName = new FlowLayoutPanel();
            lblSecondName = new Label();
            txtSecondName = new TextBox();
            pnlThirdName = new FlowLayoutPanel();
            lblThirdName = new Label();
            txtThirdName = new TextBox();
            pnlLastName = new FlowLayoutPanel();
            lblLastName = new Label();
            txtLastName = new TextBox();
            pnlDateOfBirth = new FlowLayoutPanel();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            pnlGender = new FlowLayoutPanel();
            lblGender = new Label();
            cmbGender = new ComboBox();
            pnlPhone = new FlowLayoutPanel();
            lblPhone = new Label();
            txtPhone = new TextBox();
            pnlEmail = new FlowLayoutPanel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pnlNationalNumber = new FlowLayoutPanel();
            lblNationalNumber = new Label();
            txtNationalNumber = new TextBox();
            pnlAddress = new FlowLayoutPanel();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tabCredentials = new TabPage();
            gridCredentials = new TableLayoutPanel();
            pnlUsername = new FlowLayoutPanel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            pnlPassword = new FlowLayoutPanel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlRoleId = new FlowLayoutPanel();
            lblRoleId = new Label();
            cmbRoleId = new ComboBox();
            pnlUserIsActive = new FlowLayoutPanel();
            chkUserIsActive = new CheckBox();
            tabDoctor = new TabPage();
            gridDoctor = new TableLayoutPanel();
            pnlSpecialization = new FlowLayoutPanel();
            lblSpecialization = new Label();
            txtSpecialization = new TextBox();
            pnlLicenseNumber = new FlowLayoutPanel();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            pnlSalary = new FlowLayoutPanel();
            lblSalary = new Label();
            nudSalary = new NumericUpDown();
            pnlOfficeLocation = new FlowLayoutPanel();
            lblOfficeLocation = new Label();
            txtOfficeLocation = new TextBox();
            pnlExperienceYears = new FlowLayoutPanel();
            lblExperienceYears = new Label();
            nudExperienceYears = new NumericUpDown();
            pnlDoctorIsActive = new FlowLayoutPanel();
            chkDoctorIsActive = new CheckBox();
            actionBar = new TableLayoutPanel();
            btnBack = new Button();
            btnNext = new Button();
            btnSave = new Button();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            contentCard.SuspendLayout();
            cardLayout.SuspendLayout();
            wizardTabs.SuspendLayout();
            tabPersonal.SuspendLayout();
            scrollPersonal.SuspendLayout();
            gridPersonal.SuspendLayout();
            pnlFirstName.SuspendLayout();
            pnlSecondName.SuspendLayout();
            pnlThirdName.SuspendLayout();
            pnlLastName.SuspendLayout();
            pnlDateOfBirth.SuspendLayout();
            pnlGender.SuspendLayout();
            pnlPhone.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlNationalNumber.SuspendLayout();
            pnlAddress.SuspendLayout();
            tabCredentials.SuspendLayout();
            gridCredentials.SuspendLayout();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlRoleId.SuspendLayout();
            pnlUserIsActive.SuspendLayout();
            tabDoctor.SuspendLayout();
            gridDoctor.SuspendLayout();
            pnlSpecialization.SuspendLayout();
            pnlLicenseNumber.SuspendLayout();
            pnlSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).BeginInit();
            pnlOfficeLocation.SuspendLayout();
            pnlExperienceYears.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudExperienceYears).BeginInit();
            pnlDoctorIsActive.SuspendLayout();
            actionBar.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(contentCard, 0, 1);
            mainLayout.Controls.Add(actionBar, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(20, 20);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            mainLayout.Size = new Size(860, 660);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(37, 99, 235);
            headerPanel.ColumnCount = 2;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            headerPanel.Controls.Add(lblStepCount, 0, 0);
            headerPanel.Controls.Add(lblFormTitle, 1, 0);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0, 0, 0, 12);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(16, 0, 16, 0);
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerPanel.Size = new Size(860, 40);
            headerPanel.TabIndex = 0;
            // 
            // lblStepCount
            // 
            lblStepCount.Dock = DockStyle.Fill;
            lblStepCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStepCount.ForeColor = Color.FromArgb(186, 214, 255);
            lblStepCount.Location = new Point(433, 0);
            lblStepCount.Name = "lblStepCount";
            lblStepCount.Size = new Size(408, 40);
            lblStepCount.TabIndex = 0;
            lblStepCount.Text = "المرحلة 1 من 3";
            lblStepCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(19, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(408, 40);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "تسجيل بيانات الطبيب";
            lblFormTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contentCard
            // 
            contentCard.BackColor = Color.White;
            contentCard.BorderStyle = BorderStyle.FixedSingle;
            contentCard.Controls.Add(cardLayout);
            contentCard.Dock = DockStyle.Fill;
            contentCard.Location = new Point(0, 52);
            contentCard.Margin = new Padding(0);
            contentCard.Name = "contentCard";
            contentCard.Padding = new Padding(18);
            contentCard.Size = new Size(860, 554);
            contentCard.TabIndex = 1;
            // 
            // cardLayout
            // 
            cardLayout.ColumnCount = 1;
            cardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cardLayout.Controls.Add(wizardTabs, 0, 0);
            cardLayout.Dock = DockStyle.Fill;
            cardLayout.Location = new Point(18, 18);
            cardLayout.Margin = new Padding(0);
            cardLayout.Name = "cardLayout";
            cardLayout.RowCount = 1;
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardLayout.Size = new Size(822, 516);
            cardLayout.TabIndex = 0;
            // 
            // wizardTabs
            // 
            wizardTabs.Appearance = TabAppearance.FlatButtons;
            wizardTabs.Controls.Add(tabPersonal);
            wizardTabs.Controls.Add(tabCredentials);
            wizardTabs.Controls.Add(tabDoctor);
            wizardTabs.Dock = DockStyle.Fill;
            wizardTabs.ItemSize = new Size(0, 1);
            wizardTabs.Location = new Point(0, 0);
            wizardTabs.Margin = new Padding(0);
            wizardTabs.Name = "wizardTabs";
            wizardTabs.SelectedIndex = 0;
            wizardTabs.Size = new Size(822, 516);
            wizardTabs.SizeMode = TabSizeMode.Fixed;
            wizardTabs.TabIndex = 0;
            // 
            // tabPersonal
            // 
            tabPersonal.BackColor = Color.White;
            tabPersonal.Controls.Add(scrollPersonal);
            tabPersonal.Location = new Point(4, 5);
            tabPersonal.Margin = new Padding(0);
            tabPersonal.Name = "tabPersonal";
            tabPersonal.Size = new Size(814, 507);
            tabPersonal.TabIndex = 0;
            // 
            // scrollPersonal
            // 
            scrollPersonal.AutoScroll = true;
            scrollPersonal.Controls.Add(gridPersonal);
            scrollPersonal.Dock = DockStyle.Fill;
            scrollPersonal.Location = new Point(0, 0);
            scrollPersonal.Name = "scrollPersonal";
            scrollPersonal.Size = new Size(814, 507);
            scrollPersonal.TabIndex = 0;
            // 
            // gridPersonal
            // 
            gridPersonal.ColumnCount = 2;
            gridPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridPersonal.Controls.Add(pnlFirstName, 1, 0);
            gridPersonal.Controls.Add(pnlSecondName, 0, 0);
            gridPersonal.Controls.Add(pnlThirdName, 1, 1);
            gridPersonal.Controls.Add(pnlLastName, 0, 1);
            gridPersonal.Controls.Add(pnlDateOfBirth, 1, 2);
            gridPersonal.Controls.Add(pnlGender, 0, 2);
            gridPersonal.Controls.Add(pnlPhone, 1, 3);
            gridPersonal.Controls.Add(pnlEmail, 0, 3);
            gridPersonal.Controls.Add(pnlNationalNumber, 1, 4);
            gridPersonal.Controls.Add(pnlAddress, 0, 4);
            gridPersonal.Dock = DockStyle.Top;
            gridPersonal.Location = new Point(0, 0);
            gridPersonal.Margin = new Padding(0);
            gridPersonal.Name = "gridPersonal";
            gridPersonal.RowCount = 5;
            gridPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridPersonal.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            gridPersonal.Size = new Size(814, 410);
            gridPersonal.TabIndex = 0;
            // 
            // pnlFirstName
            // 
            pnlFirstName.Controls.Add(lblFirstName);
            pnlFirstName.Controls.Add(txtFirstName);
            pnlFirstName.Dock = DockStyle.Fill;
            pnlFirstName.FlowDirection = FlowDirection.TopDown;
            pnlFirstName.Location = new Point(3, 3);
            pnlFirstName.Name = "pnlFirstName";
            pnlFirstName.Size = new Size(401, 72);
            pnlFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(298, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "الاسم الثاني";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(11, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(387, 23);
            txtFirstName.TabIndex = 0;
            // 
            // pnlSecondName
            // 
            pnlSecondName.Controls.Add(lblSecondName);
            pnlSecondName.Controls.Add(txtSecondName);
            pnlSecondName.Dock = DockStyle.Fill;
            pnlSecondName.FlowDirection = FlowDirection.TopDown;
            pnlSecondName.Location = new Point(410, 3);
            pnlSecondName.Name = "pnlSecondName";
            pnlSecondName.Size = new Size(401, 72);
            pnlSecondName.TabIndex = 1;
            // 
            // lblSecondName
            // 
            lblSecondName.Location = new Point(298, 0);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(100, 23);
            lblSecondName.TabIndex = 0;
            lblSecondName.Text = "الاسم الأول";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(28, 26);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(370, 23);
            txtSecondName.TabIndex = 0;
            // 
            // pnlThirdName
            // 
            pnlThirdName.Controls.Add(lblThirdName);
            pnlThirdName.Controls.Add(txtThirdName);
            pnlThirdName.Dock = DockStyle.Fill;
            pnlThirdName.FlowDirection = FlowDirection.TopDown;
            pnlThirdName.Location = new Point(3, 81);
            pnlThirdName.Name = "pnlThirdName";
            pnlThirdName.Size = new Size(401, 72);
            pnlThirdName.TabIndex = 2;
            // 
            // lblThirdName
            // 
            lblThirdName.Location = new Point(298, 0);
            lblThirdName.Name = "lblThirdName";
            lblThirdName.Size = new Size(100, 23);
            lblThirdName.TabIndex = 0;
            lblThirdName.Text = "اسم العائلة";
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(11, 26);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(387, 23);
            txtThirdName.TabIndex = 0;
            // 
            // pnlLastName
            // 
            pnlLastName.Controls.Add(lblLastName);
            pnlLastName.Controls.Add(txtLastName);
            pnlLastName.Dock = DockStyle.Fill;
            pnlLastName.FlowDirection = FlowDirection.TopDown;
            pnlLastName.Location = new Point(410, 81);
            pnlLastName.Name = "pnlLastName";
            pnlLastName.Size = new Size(401, 72);
            pnlLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(298, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "الاسم الثالث";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(28, 26);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 23);
            txtLastName.TabIndex = 0;
            // 
            // pnlDateOfBirth
            // 
            pnlDateOfBirth.Controls.Add(lblDateOfBirth);
            pnlDateOfBirth.Controls.Add(dtpDateOfBirth);
            pnlDateOfBirth.Dock = DockStyle.Fill;
            pnlDateOfBirth.FlowDirection = FlowDirection.TopDown;
            pnlDateOfBirth.Location = new Point(3, 159);
            pnlDateOfBirth.Name = "pnlDateOfBirth";
            pnlDateOfBirth.Padding = new Padding(10, 4, 10, 4);
            pnlDateOfBirth.Size = new Size(401, 72);
            pnlDateOfBirth.TabIndex = 4;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(316, 4);
            lblDateOfBirth.Margin = new Padding(0, 0, 0, 4);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(65, 15);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "تاريخ الميلاد";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(11, 23);
            dtpDateOfBirth.Margin = new Padding(0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(370, 23);
            dtpDateOfBirth.TabIndex = 1;
            // 
            // pnlGender
            // 
            pnlGender.Controls.Add(lblGender);
            pnlGender.Controls.Add(cmbGender);
            pnlGender.Dock = DockStyle.Fill;
            pnlGender.FlowDirection = FlowDirection.TopDown;
            pnlGender.Location = new Point(410, 159);
            pnlGender.Name = "pnlGender";
            pnlGender.Padding = new Padding(10, 4, 10, 4);
            pnlGender.Size = new Size(401, 72);
            pnlGender.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(342, 4);
            lblGender.Margin = new Padding(0, 0, 0, 4);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(39, 15);
            lblGender.TabIndex = 0;
            lblGender.Text = "الجنس";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.Location = new Point(11, 23);
            cmbGender.Margin = new Padding(0);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(370, 23);
            cmbGender.TabIndex = 1;
            // 
            // pnlPhone
            // 
            pnlPhone.Controls.Add(lblPhone);
            pnlPhone.Controls.Add(txtPhone);
            pnlPhone.Dock = DockStyle.Fill;
            pnlPhone.FlowDirection = FlowDirection.TopDown;
            pnlPhone.Location = new Point(3, 237);
            pnlPhone.Name = "pnlPhone";
            pnlPhone.Padding = new Padding(10, 4, 10, 4);
            pnlPhone.Size = new Size(401, 72);
            pnlPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(322, 4);
            lblPhone.Margin = new Padding(0, 0, 0, 4);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 15);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(11, 23);
            txtPhone.Margin = new Padding(0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(370, 23);
            txtPhone.TabIndex = 1;
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(lblEmail);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.FlowDirection = FlowDirection.TopDown;
            pnlEmail.Location = new Point(410, 237);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Padding = new Padding(10, 4, 10, 4);
            pnlEmail.Size = new Size(401, 72);
            pnlEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(296, 4);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(85, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "البريد الإلكتروني";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(11, 23);
            txtEmail.Margin = new Padding(0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 23);
            txtEmail.TabIndex = 1;
            // 
            // pnlNationalNumber
            // 
            pnlNationalNumber.Controls.Add(lblNationalNumber);
            pnlNationalNumber.Controls.Add(txtNationalNumber);
            pnlNationalNumber.Dock = DockStyle.Fill;
            pnlNationalNumber.FlowDirection = FlowDirection.TopDown;
            pnlNationalNumber.Location = new Point(3, 315);
            pnlNationalNumber.Name = "pnlNationalNumber";
            pnlNationalNumber.Padding = new Padding(10, 4, 10, 4);
            pnlNationalNumber.Size = new Size(401, 92);
            pnlNationalNumber.TabIndex = 8;
            // 
            // lblNationalNumber
            // 
            lblNationalNumber.AutoSize = true;
            lblNationalNumber.Location = new Point(310, 4);
            lblNationalNumber.Margin = new Padding(0, 0, 0, 4);
            lblNationalNumber.Name = "lblNationalNumber";
            lblNationalNumber.Size = new Size(71, 15);
            lblNationalNumber.TabIndex = 0;
            lblNationalNumber.Text = "الرقم الوطني";
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(11, 23);
            txtNationalNumber.Margin = new Padding(0);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(370, 23);
            txtNationalNumber.TabIndex = 1;
            // 
            // pnlAddress
            // 
            pnlAddress.Controls.Add(lblAddress);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Dock = DockStyle.Fill;
            pnlAddress.FlowDirection = FlowDirection.TopDown;
            pnlAddress.Location = new Point(410, 315);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Padding = new Padding(10, 4, 10, 4);
            pnlAddress.Size = new Size(401, 92);
            pnlAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(339, 4);
            lblAddress.Margin = new Padding(0, 0, 0, 4);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(42, 15);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "العنوان";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(11, 23);
            txtAddress.Margin = new Padding(0);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(370, 52);
            txtAddress.TabIndex = 1;
            // 
            // tabCredentials
            // 
            tabCredentials.BackColor = Color.White;
            tabCredentials.Controls.Add(gridCredentials);
            tabCredentials.Location = new Point(4, 5);
            tabCredentials.Margin = new Padding(0);
            tabCredentials.Name = "tabCredentials";
            tabCredentials.Size = new Size(814, 507);
            tabCredentials.TabIndex = 1;
            // 
            // gridCredentials
            // 
            gridCredentials.ColumnCount = 2;
            gridCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridCredentials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridCredentials.Controls.Add(pnlUsername, 1, 0);
            gridCredentials.Controls.Add(pnlPassword, 0, 0);
            gridCredentials.Controls.Add(pnlRoleId, 1, 1);
            gridCredentials.Controls.Add(pnlUserIsActive, 0, 1);
            gridCredentials.Dock = DockStyle.Top;
            gridCredentials.Location = new Point(0, 0);
            gridCredentials.Margin = new Padding(0);
            gridCredentials.Name = "gridCredentials";
            gridCredentials.RowCount = 2;
            gridCredentials.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridCredentials.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridCredentials.Size = new Size(814, 156);
            gridCredentials.TabIndex = 0;
            // 
            // pnlUsername
            // 
            pnlUsername.Controls.Add(lblUsername);
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Dock = DockStyle.Fill;
            pnlUsername.FlowDirection = FlowDirection.TopDown;
            pnlUsername.Location = new Point(3, 3);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Padding = new Padding(10, 4, 10, 4);
            pnlUsername.Size = new Size(401, 72);
            pnlUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(295, 4);
            lblUsername.Margin = new Padding(0, 0, 0, 4);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "اسم المستخدم *";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(11, 23);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 23);
            txtUsername.TabIndex = 1;
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Dock = DockStyle.Fill;
            pnlPassword.FlowDirection = FlowDirection.TopDown;
            pnlPassword.Location = new Point(410, 3);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(10, 4, 10, 4);
            pnlPassword.Size = new Size(401, 72);
            pnlPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(311, 4);
            lblPassword.Margin = new Padding(0, 0, 0, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "كلمة المرور *";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(11, 23);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(370, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlRoleId
            // 
            pnlRoleId.Controls.Add(lblRoleId);
            pnlRoleId.Controls.Add(cmbRoleId);
            pnlRoleId.Dock = DockStyle.Fill;
            pnlRoleId.FlowDirection = FlowDirection.TopDown;
            pnlRoleId.Location = new Point(3, 81);
            pnlRoleId.Name = "pnlRoleId";
            pnlRoleId.Padding = new Padding(10, 4, 10, 4);
            pnlRoleId.Size = new Size(401, 72);
            pnlRoleId.TabIndex = 2;
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Location = new Point(296, 4);
            lblRoleId.Margin = new Padding(0, 0, 0, 4);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(85, 15);
            lblRoleId.TabIndex = 0;
            lblRoleId.Text = "الصلاحية / الدور";
            // 
            // cmbRoleId
            // 
            cmbRoleId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleId.FormattingEnabled = true;
            cmbRoleId.Items.AddRange(new object[] { "طبيب" });
            cmbRoleId.Location = new Point(11, 23);
            cmbRoleId.Margin = new Padding(0);
            cmbRoleId.Name = "cmbRoleId";
            cmbRoleId.Size = new Size(370, 23);
            cmbRoleId.TabIndex = 1;
            // 
            // pnlUserIsActive
            // 
            pnlUserIsActive.Controls.Add(chkUserIsActive);
            pnlUserIsActive.Dock = DockStyle.Fill;
            pnlUserIsActive.FlowDirection = FlowDirection.TopDown;
            pnlUserIsActive.Location = new Point(410, 81);
            pnlUserIsActive.Name = "pnlUserIsActive";
            pnlUserIsActive.Padding = new Padding(10, 28, 10, 4);
            pnlUserIsActive.Size = new Size(401, 72);
            pnlUserIsActive.TabIndex = 3;
            // 
            // chkUserIsActive
            // 
            chkUserIsActive.AutoSize = true;
            chkUserIsActive.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkUserIsActive.Location = new Point(223, 28);
            chkUserIsActive.Margin = new Padding(0);
            chkUserIsActive.Name = "chkUserIsActive";
            chkUserIsActive.Size = new Size(158, 21);
            chkUserIsActive.TabIndex = 0;
            chkUserIsActive.Text = "الحساب نشط فور الإنشاء";
            chkUserIsActive.UseVisualStyleBackColor = true;
            // 
            // tabDoctor
            // 
            tabDoctor.BackColor = Color.White;
            tabDoctor.Controls.Add(gridDoctor);
            tabDoctor.Location = new Point(4, 5);
            tabDoctor.Margin = new Padding(0);
            tabDoctor.Name = "tabDoctor";
            tabDoctor.Size = new Size(814, 507);
            tabDoctor.TabIndex = 2;
            // 
            // gridDoctor
            // 
            gridDoctor.ColumnCount = 2;
            gridDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridDoctor.Controls.Add(pnlSpecialization, 1, 0);
            gridDoctor.Controls.Add(pnlLicenseNumber, 0, 0);
            gridDoctor.Controls.Add(pnlSalary, 1, 1);
            gridDoctor.Controls.Add(pnlOfficeLocation, 0, 1);
            gridDoctor.Controls.Add(pnlExperienceYears, 1, 2);
            gridDoctor.Controls.Add(pnlDoctorIsActive, 0, 2);
            gridDoctor.Dock = DockStyle.Top;
            gridDoctor.Location = new Point(0, 0);
            gridDoctor.Margin = new Padding(0);
            gridDoctor.Name = "gridDoctor";
            gridDoctor.RowCount = 3;
            gridDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            gridDoctor.Size = new Size(814, 234);
            gridDoctor.TabIndex = 0;
            // 
            // pnlSpecialization
            // 
            pnlSpecialization.Controls.Add(lblSpecialization);
            pnlSpecialization.Controls.Add(txtSpecialization);
            pnlSpecialization.Dock = DockStyle.Fill;
            pnlSpecialization.FlowDirection = FlowDirection.TopDown;
            pnlSpecialization.Location = new Point(3, 3);
            pnlSpecialization.Name = "pnlSpecialization";
            pnlSpecialization.Padding = new Padding(10, 4, 10, 4);
            pnlSpecialization.Size = new Size(401, 72);
            pnlSpecialization.TabIndex = 0;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Location = new Point(328, 4);
            lblSpecialization.Margin = new Padding(0, 0, 0, 4);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(53, 15);
            lblSpecialization.TabIndex = 0;
            lblSpecialization.Text = "التخصص";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(11, 23);
            txtSpecialization.Margin = new Padding(0);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(370, 23);
            txtSpecialization.TabIndex = 1;
            // 
            // pnlLicenseNumber
            // 
            pnlLicenseNumber.Controls.Add(lblLicenseNumber);
            pnlLicenseNumber.Controls.Add(txtLicenseNumber);
            pnlLicenseNumber.Dock = DockStyle.Fill;
            pnlLicenseNumber.FlowDirection = FlowDirection.TopDown;
            pnlLicenseNumber.Location = new Point(410, 3);
            pnlLicenseNumber.Name = "pnlLicenseNumber";
            pnlLicenseNumber.Padding = new Padding(10, 4, 10, 4);
            pnlLicenseNumber.Size = new Size(401, 72);
            pnlLicenseNumber.TabIndex = 1;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(317, 4);
            lblLicenseNumber.Margin = new Padding(0, 0, 0, 4);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(64, 15);
            lblLicenseNumber.TabIndex = 0;
            lblLicenseNumber.Text = "رقم الرخصة";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(11, 23);
            txtLicenseNumber.Margin = new Padding(0);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(370, 23);
            txtLicenseNumber.TabIndex = 1;
            // 
            // pnlSalary
            // 
            pnlSalary.Controls.Add(lblSalary);
            pnlSalary.Controls.Add(nudSalary);
            pnlSalary.Dock = DockStyle.Fill;
            pnlSalary.FlowDirection = FlowDirection.TopDown;
            pnlSalary.Location = new Point(3, 81);
            pnlSalary.Name = "pnlSalary";
            pnlSalary.Padding = new Padding(10, 4, 10, 4);
            pnlSalary.Size = new Size(401, 72);
            pnlSalary.TabIndex = 2;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(289, 4);
            lblSalary.Margin = new Padding(0, 0, 0, 4);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(92, 15);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "الراتب الشهري (₪)";
            // 
            // nudSalary
            // 
            nudSalary.DecimalPlaces = 2;
            nudSalary.Location = new Point(11, 23);
            nudSalary.Margin = new Padding(0);
            nudSalary.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudSalary.Name = "nudSalary";
            nudSalary.Size = new Size(370, 23);
            nudSalary.TabIndex = 1;
            nudSalary.ThousandsSeparator = true;
            // 
            // pnlOfficeLocation
            // 
            pnlOfficeLocation.Controls.Add(lblOfficeLocation);
            pnlOfficeLocation.Controls.Add(txtOfficeLocation);
            pnlOfficeLocation.Dock = DockStyle.Fill;
            pnlOfficeLocation.FlowDirection = FlowDirection.TopDown;
            pnlOfficeLocation.Location = new Point(410, 81);
            pnlOfficeLocation.Name = "pnlOfficeLocation";
            pnlOfficeLocation.Padding = new Padding(10, 4, 10, 4);
            pnlOfficeLocation.Size = new Size(401, 72);
            pnlOfficeLocation.TabIndex = 3;
            // 
            // lblOfficeLocation
            // 
            lblOfficeLocation.AutoSize = true;
            lblOfficeLocation.Location = new Point(312, 4);
            lblOfficeLocation.Margin = new Padding(0, 0, 0, 4);
            lblOfficeLocation.Name = "lblOfficeLocation";
            lblOfficeLocation.Size = new Size(69, 15);
            lblOfficeLocation.TabIndex = 0;
            lblOfficeLocation.Text = "موقع العيادة";
            // 
            // txtOfficeLocation
            // 
            txtOfficeLocation.Location = new Point(11, 23);
            txtOfficeLocation.Margin = new Padding(0);
            txtOfficeLocation.Name = "txtOfficeLocation";
            txtOfficeLocation.Size = new Size(370, 23);
            txtOfficeLocation.TabIndex = 1;
            // 
            // pnlExperienceYears
            // 
            pnlExperienceYears.Controls.Add(lblExperienceYears);
            pnlExperienceYears.Controls.Add(nudExperienceYears);
            pnlExperienceYears.Dock = DockStyle.Fill;
            pnlExperienceYears.FlowDirection = FlowDirection.TopDown;
            pnlExperienceYears.Location = new Point(3, 159);
            pnlExperienceYears.Name = "pnlExperienceYears";
            pnlExperienceYears.Padding = new Padding(10, 4, 10, 4);
            pnlExperienceYears.Size = new Size(401, 72);
            pnlExperienceYears.TabIndex = 4;
            // 
            // lblExperienceYears
            // 
            lblExperienceYears.AutoSize = true;
            lblExperienceYears.Location = new Point(309, 4);
            lblExperienceYears.Margin = new Padding(0, 0, 0, 4);
            lblExperienceYears.Name = "lblExperienceYears";
            lblExperienceYears.Size = new Size(72, 15);
            lblExperienceYears.TabIndex = 0;
            lblExperienceYears.Text = "سنوات الخبرة";
            // 
            // nudExperienceYears
            // 
            nudExperienceYears.Location = new Point(11, 23);
            nudExperienceYears.Margin = new Padding(0);
            nudExperienceYears.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudExperienceYears.Name = "nudExperienceYears";
            nudExperienceYears.Size = new Size(370, 23);
            nudExperienceYears.TabIndex = 1;
            // 
            // pnlDoctorIsActive
            // 
            pnlDoctorIsActive.Controls.Add(chkDoctorIsActive);
            pnlDoctorIsActive.Dock = DockStyle.Fill;
            pnlDoctorIsActive.FlowDirection = FlowDirection.TopDown;
            pnlDoctorIsActive.Location = new Point(410, 159);
            pnlDoctorIsActive.Name = "pnlDoctorIsActive";
            pnlDoctorIsActive.Padding = new Padding(10, 28, 10, 4);
            pnlDoctorIsActive.Size = new Size(401, 72);
            pnlDoctorIsActive.TabIndex = 5;
            // 
            // chkDoctorIsActive
            // 
            chkDoctorIsActive.AutoSize = true;
            chkDoctorIsActive.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkDoctorIsActive.Location = new Point(233, 28);
            chkDoctorIsActive.Margin = new Padding(0);
            chkDoctorIsActive.Name = "chkDoctorIsActive";
            chkDoctorIsActive.Size = new Size(148, 21);
            chkDoctorIsActive.TabIndex = 0;
            chkDoctorIsActive.Text = "طبيب نشط بالمنظومة";
            chkDoctorIsActive.UseVisualStyleBackColor = true;
            // 
            // actionBar
            // 
            actionBar.ColumnCount = 3;
            actionBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            actionBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            actionBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            actionBar.Controls.Add(btnBack, 0, 0);
            actionBar.Controls.Add(btnNext, 1, 0);
            actionBar.Controls.Add(btnSave, 2, 0);
            actionBar.Dock = DockStyle.Fill;
            actionBar.Location = new Point(0, 616);
            actionBar.Margin = new Padding(0, 10, 0, 0);
            actionBar.Name = "actionBar";
            actionBar.Padding = new Padding(0, 6, 0, 0);
            actionBar.RowCount = 1;
            actionBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            actionBar.Size = new Size(860, 44);
            actionBar.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(724, 10);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(132, 30);
            btnBack.TabIndex = 5;
            btnBack.Text = "السابق";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.MenuHighlight;
            btnNext.Dock = DockStyle.Fill;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(584, 10);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(132, 30);
            btnNext.TabIndex = 3;
            btnNext.Text = "التالي";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 162, 87);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(4, 10);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(572, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(860, 660);
            Name = "frmDoctor";
            Padding = new Padding(20);
            RightToLeft = RightToLeft.Yes;
            Text = "تسجيل بيانات طبيب جديد";
            WindowState = FormWindowState.Maximized;
            Load += frmDoctor_Load;
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            contentCard.ResumeLayout(false);
            cardLayout.ResumeLayout(false);
            wizardTabs.ResumeLayout(false);
            tabPersonal.ResumeLayout(false);
            scrollPersonal.ResumeLayout(false);
            gridPersonal.ResumeLayout(false);
            pnlFirstName.ResumeLayout(false);
            pnlFirstName.PerformLayout();
            pnlSecondName.ResumeLayout(false);
            pnlSecondName.PerformLayout();
            pnlThirdName.ResumeLayout(false);
            pnlThirdName.PerformLayout();
            pnlLastName.ResumeLayout(false);
            pnlLastName.PerformLayout();
            pnlDateOfBirth.ResumeLayout(false);
            pnlDateOfBirth.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            pnlPhone.ResumeLayout(false);
            pnlPhone.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlNationalNumber.ResumeLayout(false);
            pnlNationalNumber.PerformLayout();
            pnlAddress.ResumeLayout(false);
            pnlAddress.PerformLayout();
            tabCredentials.ResumeLayout(false);
            gridCredentials.ResumeLayout(false);
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlRoleId.ResumeLayout(false);
            pnlRoleId.PerformLayout();
            pnlUserIsActive.ResumeLayout(false);
            pnlUserIsActive.PerformLayout();
            tabDoctor.ResumeLayout(false);
            gridDoctor.ResumeLayout(false);
            pnlSpecialization.ResumeLayout(false);
            pnlSpecialization.PerformLayout();
            pnlLicenseNumber.ResumeLayout(false);
            pnlLicenseNumber.PerformLayout();
            pnlSalary.ResumeLayout(false);
            pnlSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).EndInit();
            pnlOfficeLocation.ResumeLayout(false);
            pnlOfficeLocation.PerformLayout();
            pnlExperienceYears.ResumeLayout(false);
            pnlExperienceYears.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudExperienceYears).EndInit();
            pnlDoctorIsActive.ResumeLayout(false);
            pnlDoctorIsActive.PerformLayout();
            actionBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion        // ────────────────────────────────────────────────────────────────────────────
        // Private designer helpers  (keep inside the partial class; no logic here)
        // ────────────────────────────────────────────────────────────────────────────

        /// <summary>
        /// Builds a label + single-line TextBox inside a FlowLayoutPanel (TopDown).
        /// All field panels follow the same visual rhythm.
        /// </summary>
        private static void BuildFieldPanel(
            FlowLayoutPanel panel,
            Label label,
            string labelText,
            TextBox textBox)
        {
            panel.Controls.Add(label);
            panel.Controls.Add(textBox);
            panel.Dock = DockStyle.Fill;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Padding = new Padding(10, 4, 10, 4);

            label.AutoSize = true;
            label.Font = LabelFont();
            label.ForeColor = LabelColor();
            label.Margin = new Padding(0, 0, 0, 4);
            label.Text = labelText;

            textBox.Font = InputFont();
            textBox.Margin = new Padding(0);
            textBox.Size = new Size(370, 28);
        }

        private static Font LabelFont() => new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
        private static Font InputFont() => new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
        private static Color LabelColor() => Color.FromArgb(55, 65, 81);

        // ────────────────────────────────────────────────────────────────────────────
        // Field declarations
        // ────────────────────────────────────────────────────────────────────────────

        // Root
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblStepCount;
        private System.Windows.Forms.Panel contentCard;
        private System.Windows.Forms.TableLayoutPanel cardLayout;
        private System.Windows.Forms.TabControl wizardTabs;

        // Tab 1 – Personal Information
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.Panel scrollPersonal;
        private System.Windows.Forms.TableLayoutPanel gridPersonal;

        private System.Windows.Forms.FlowLayoutPanel pnlFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;

        private System.Windows.Forms.FlowLayoutPanel pnlSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;

        private System.Windows.Forms.FlowLayoutPanel pnlThirdName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox txtThirdName;

        private System.Windows.Forms.FlowLayoutPanel pnlLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.FlowLayoutPanel pnlDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;

        private System.Windows.Forms.FlowLayoutPanel pnlGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;

        private System.Windows.Forms.FlowLayoutPanel pnlPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.FlowLayoutPanel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.FlowLayoutPanel pnlNationalNumber;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.TextBox txtNationalNumber;

        private System.Windows.Forms.FlowLayoutPanel pnlAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        // Tab 2 – User Credentials
        private System.Windows.Forms.TabPage tabCredentials;
        private System.Windows.Forms.TableLayoutPanel gridCredentials;

        private System.Windows.Forms.FlowLayoutPanel pnlUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.FlowLayoutPanel pnlPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.FlowLayoutPanel pnlRoleId;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.ComboBox cmbRoleId;

        private System.Windows.Forms.FlowLayoutPanel pnlUserIsActive;
        private System.Windows.Forms.CheckBox chkUserIsActive;

        // Tab 3 – Professional Doctor Info
        private System.Windows.Forms.TabPage tabDoctor;
        private System.Windows.Forms.TableLayoutPanel gridDoctor;

        private System.Windows.Forms.FlowLayoutPanel pnlSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtSpecialization;

        private System.Windows.Forms.FlowLayoutPanel pnlLicenseNumber;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseNumber;

        private System.Windows.Forms.FlowLayoutPanel pnlSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown nudSalary;

        private System.Windows.Forms.FlowLayoutPanel pnlOfficeLocation;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.TextBox txtOfficeLocation;

        private System.Windows.Forms.FlowLayoutPanel pnlExperienceYears;
        private System.Windows.Forms.Label lblExperienceYears;
        private System.Windows.Forms.NumericUpDown nudExperienceYears;

        private System.Windows.Forms.FlowLayoutPanel pnlDoctorIsActive;
        private System.Windows.Forms.CheckBox chkDoctorIsActive;

        // Action bar
        private System.Windows.Forms.TableLayoutPanel actionBar;
        private System.Windows.Forms.Button btnSave;
        private Button btnNext;
        private Button button2;
        private Button btnBack;
    }
}