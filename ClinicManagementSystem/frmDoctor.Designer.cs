using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmDoctor : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            headerPanel = new TableLayoutPanel();
            lblStepTitle = new Label();
            lblStepCount = new Label();
            contentCard = new Panel();
            cardLayout = new TableLayoutPanel();
            wizardTabs = new TabControl();
            tabStep1 = new TabPage();
            scrollStep1 = new Panel();
            gridStep1 = new TableLayoutPanel();
            pnlFirstName = new FlowLayoutPanel();
            lblFirstName = new Label();
            txtSecondName = new TextBox();
            pnlSecondName = new FlowLayoutPanel();
            lblSecondName = new Label();
            txtFirstName = new TextBox();
            pnlThirdName = new FlowLayoutPanel();
            lblThirdName = new Label();
            txtLastName = new TextBox();
            pnlLastName = new FlowLayoutPanel();
            lblLastName = new Label();
            txtThirdName = new TextBox();
            pnlNationalNumber = new FlowLayoutPanel();
            lblNationalNumber = new Label();
            txtNationalNumber = new TextBox();
            pnlPhone = new FlowLayoutPanel();
            lblPhone = new Label();
            txtPhone = new TextBox();
            pnlGender = new FlowLayoutPanel();
            lblGender = new Label();
            cmbGender = new ComboBox();
            pnlAddress = new FlowLayoutPanel();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tabStep2 = new TabPage();
            gridStep2 = new TableLayoutPanel();
            pnlAssociatedDoctor = new FlowLayoutPanel();
            lblAssociatedDoctor = new Label();
            txtAssociatedDoctor = new TextBox();
            pnlUsername = new FlowLayoutPanel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            pnlPassword = new FlowLayoutPanel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlConfirmPassword = new FlowLayoutPanel();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            pnlRole = new FlowLayoutPanel();
            lblRole = new Label();
            cmbRole = new ComboBox();
            pnlUserActive = new FlowLayoutPanel();
            chkUserActive = new CheckBox();
            tabStep3 = new TabPage();
            pnlStep3Wrapper = new TableLayoutPanel();
            gridStep3 = new TableLayoutPanel();
            pnlLicenseNumber = new FlowLayoutPanel();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            pnlSpecialization = new FlowLayoutPanel();
            lblSpecialization = new Label();
            txtSpecialization = new TextBox();
            pnlOfficeLocation = new FlowLayoutPanel();
            lblOfficeLocation = new Label();
            txtOfficeLocation = new TextBox();
            pnlSalary = new FlowLayoutPanel();
            lblSalary = new Label();
            txtSalary = new TextBox();
            pnlExperienceYears = new FlowLayoutPanel();
            lblExperienceYears = new Label();
            txtExperienceYears = new TextBox();
            pnlDoctorActive = new FlowLayoutPanel();
            chkDoctorActive = new CheckBox();
            btnSaveDoctor = new Button();
            navigationLayout = new TableLayoutPanel();
            btnNext = new Button();
            btnBack = new Button();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            contentCard.SuspendLayout();
            cardLayout.SuspendLayout();
            wizardTabs.SuspendLayout();
            tabStep1.SuspendLayout();
            scrollStep1.SuspendLayout();
            gridStep1.SuspendLayout();
            pnlFirstName.SuspendLayout();
            pnlSecondName.SuspendLayout();
            pnlThirdName.SuspendLayout();
            pnlLastName.SuspendLayout();
            pnlNationalNumber.SuspendLayout();
            pnlPhone.SuspendLayout();
            pnlGender.SuspendLayout();
            pnlAddress.SuspendLayout();
            tabStep2.SuspendLayout();
            gridStep2.SuspendLayout();
            pnlAssociatedDoctor.SuspendLayout();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlConfirmPassword.SuspendLayout();
            pnlRole.SuspendLayout();
            pnlUserActive.SuspendLayout();
            tabStep3.SuspendLayout();
            pnlStep3Wrapper.SuspendLayout();
            gridStep3.SuspendLayout();
            pnlLicenseNumber.SuspendLayout();
            pnlSpecialization.SuspendLayout();
            pnlOfficeLocation.SuspendLayout();
            pnlSalary.SuspendLayout();
            pnlExperienceYears.SuspendLayout();
            pnlDoctorActive.SuspendLayout();
            navigationLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(contentCard, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(20, 20);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(844, 621);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(49, 130, 206);
            headerPanel.ColumnCount = 2;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            headerPanel.Controls.Add(lblStepTitle, 1, 0);
            headerPanel.Controls.Add(lblStepCount, 0, 0);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0, 0, 0, 15);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(15, 10, 15, 10);
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerPanel.Size = new Size(844, 43);
            headerPanel.TabIndex = 0;
            // 
            // lblStepTitle
            // 
            lblStepTitle.Anchor = AnchorStyles.Right;
            lblStepTitle.AutoSize = true;
            lblStepTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblStepTitle.ForeColor = Color.White;
            lblStepTitle.Location = new Point(18, 10);
            lblStepTitle.Name = "lblStepTitle";
            lblStepTitle.Size = new Size(162, 23);
            lblStepTitle.TabIndex = 0;
            lblStepTitle.Text = "تسجيل ملف الطبيب";
            lblStepTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStepCount
            // 
            lblStepCount.Anchor = AnchorStyles.Left;
            lblStepCount.AutoSize = true;
            lblStepCount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStepCount.ForeColor = Color.FromArgb(226, 232, 240);
            lblStepCount.Location = new Point(729, 12);
            lblStepCount.Name = "lblStepCount";
            lblStepCount.Size = new Size(97, 19);
            lblStepCount.TabIndex = 1;
            lblStepCount.Text = "المرحلة 1 من 3";
            lblStepCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contentCard
            // 
            contentCard.BackColor = Color.White;
            contentCard.BorderStyle = BorderStyle.FixedSingle;
            contentCard.Controls.Add(cardLayout);
            contentCard.Dock = DockStyle.Fill;
            contentCard.Location = new Point(0, 58);
            contentCard.Margin = new Padding(0);
            contentCard.Name = "contentCard";
            contentCard.Padding = new Padding(20);
            contentCard.Size = new Size(844, 563);
            contentCard.TabIndex = 1;
            // 
            // cardLayout
            // 
            cardLayout.ColumnCount = 1;
            cardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cardLayout.Controls.Add(wizardTabs, 0, 0);
            cardLayout.Controls.Add(navigationLayout, 0, 1);
            cardLayout.Dock = DockStyle.Fill;
            cardLayout.Location = new Point(20, 20);
            cardLayout.Name = "cardLayout";
            cardLayout.RowCount = 2;
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            cardLayout.Size = new Size(802, 521);
            cardLayout.TabIndex = 0;
            // 
            // wizardTabs
            // 
            wizardTabs.Appearance = TabAppearance.FlatButtons;
            wizardTabs.Controls.Add(tabStep1);
            wizardTabs.Controls.Add(tabStep2);
            wizardTabs.Controls.Add(tabStep3);
            wizardTabs.Dock = DockStyle.Fill;
            wizardTabs.ItemSize = new Size(0, 1);
            wizardTabs.Location = new Point(0, 0);
            wizardTabs.Margin = new Padding(0);
            wizardTabs.Name = "wizardTabs";
            wizardTabs.SelectedIndex = 0;
            wizardTabs.Size = new Size(802, 468);
            wizardTabs.SizeMode = TabSizeMode.Fixed;
            wizardTabs.TabIndex = 0;
            // 
            // tabStep1
            // 
            tabStep1.BackColor = Color.White;
            tabStep1.Controls.Add(scrollStep1);
            tabStep1.Location = new Point(4, 5);
            tabStep1.Margin = new Padding(0);
            tabStep1.Name = "tabStep1";
            tabStep1.Size = new Size(794, 459);
            tabStep1.TabIndex = 0;
            // 
            // scrollStep1
            // 
            scrollStep1.AutoScroll = true;
            scrollStep1.Controls.Add(gridStep1);
            scrollStep1.Dock = DockStyle.Fill;
            scrollStep1.Location = new Point(0, 0);
            scrollStep1.Name = "scrollStep1";
            scrollStep1.Size = new Size(794, 459);
            scrollStep1.TabIndex = 0;
            // 
            // gridStep1
            // 
            gridStep1.ColumnCount = 2;
            gridStep1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep1.Controls.Add(pnlFirstName, 1, 0);
            gridStep1.Controls.Add(pnlSecondName, 0, 0);
            gridStep1.Controls.Add(pnlThirdName, 1, 1);
            gridStep1.Controls.Add(pnlLastName, 0, 1);
            gridStep1.Controls.Add(pnlNationalNumber, 1, 2);
            gridStep1.Controls.Add(pnlPhone, 0, 2);
            gridStep1.Controls.Add(pnlGender, 1, 3);
            gridStep1.Controls.Add(pnlAddress, 0, 3);
            gridStep1.Dock = DockStyle.Top;
            gridStep1.Location = new Point(0, 0);
            gridStep1.Name = "gridStep1";
            gridStep1.RowCount = 4;
            gridStep1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep1.Size = new Size(794, 300);
            gridStep1.TabIndex = 0;
            // 
            // pnlFirstName
            // 
            pnlFirstName.Controls.Add(lblFirstName);
            pnlFirstName.Controls.Add(txtSecondName);
            pnlFirstName.Dock = DockStyle.Fill;
            pnlFirstName.FlowDirection = FlowDirection.TopDown;
            pnlFirstName.Location = new Point(3, 3);
            pnlFirstName.Name = "pnlFirstName";
            pnlFirstName.Padding = new Padding(10, 0, 10, 0);
            pnlFirstName.Size = new Size(391, 69);
            pnlFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblFirstName.ForeColor = Color.FromArgb(74, 85, 104);
            lblFirstName.Location = new Point(301, 0);
            lblFirstName.Margin = new Padding(0, 0, 0, 4);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 17);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "الاسم الثاني";
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondName.Location = new Point(7, 21);
            txtSecondName.Margin = new Padding(0);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(364, 26);
            txtSecondName.TabIndex = 1;
            // 
            // pnlSecondName
            // 
            pnlSecondName.Controls.Add(lblSecondName);
            pnlSecondName.Controls.Add(txtFirstName);
            pnlSecondName.Dock = DockStyle.Fill;
            pnlSecondName.FlowDirection = FlowDirection.TopDown;
            pnlSecondName.Location = new Point(400, 3);
            pnlSecondName.Name = "pnlSecondName";
            pnlSecondName.Padding = new Padding(10, 0, 10, 0);
            pnlSecondName.Size = new Size(391, 69);
            pnlSecondName.TabIndex = 1;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSecondName.ForeColor = Color.FromArgb(74, 85, 104);
            lblSecondName.Location = new Point(300, 0);
            lblSecondName.Margin = new Padding(0, 0, 0, 4);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(71, 17);
            lblSecondName.TabIndex = 0;
            lblSecondName.Text = "الاسم الاول ";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstName.Location = new Point(6, 21);
            txtFirstName.Margin = new Padding(0);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(365, 26);
            txtFirstName.TabIndex = 1;
            // 
            // pnlThirdName
            // 
            pnlThirdName.Controls.Add(lblThirdName);
            pnlThirdName.Controls.Add(this.txtLastName);
            pnlThirdName.Dock = DockStyle.Fill;
            pnlThirdName.FlowDirection = FlowDirection.TopDown;
            pnlThirdName.Location = new Point(3, 78);
            pnlThirdName.Name = "pnlThirdName";
            pnlThirdName.Padding = new Padding(10, 0, 10, 0);
            pnlThirdName.Size = new Size(391, 69);
            pnlThirdName.TabIndex = 2;
            // 
            // lblThirdName
            // 
            lblThirdName.AutoSize = true;
            lblThirdName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblThirdName.ForeColor = Color.FromArgb(74, 85, 104);
            lblThirdName.Location = new Point(286, 0);
            lblThirdName.Margin = new Padding(0, 0, 0, 4);
            lblThirdName.Name = "lblThirdName";
            lblThirdName.Size = new Size(85, 17);
            lblThirdName.TabIndex = 0;
            lblThirdName.Text = "العائلة / اللقب";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtLastName.Location = new Point(7, 21);
            this.txtLastName.Margin = new Padding(0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(364, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // pnlLastName
            // 
            pnlLastName.Controls.Add(lblLastName);
            pnlLastName.Controls.Add(txtThirdName);
            pnlLastName.Dock = DockStyle.Fill;
            pnlLastName.FlowDirection = FlowDirection.TopDown;
            pnlLastName.Location = new Point(400, 78);
            pnlLastName.Name = "pnlLastName";
            pnlLastName.Padding = new Padding(10, 0, 10, 0);
            pnlLastName.Size = new Size(391, 69);
            pnlLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblLastName.ForeColor = Color.FromArgb(74, 85, 104);
            lblLastName.Location = new Point(300, 0);
            lblLastName.Margin = new Padding(0, 0, 0, 4);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 17);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "الاسم الثالث";
            // 
            // txtThirdName
            // 
            txtThirdName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtThirdName.Location = new Point(6, 21);
            txtThirdName.Margin = new Padding(0);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(365, 26);
            txtThirdName.TabIndex = 1;
            // 
            // pnlNationalNumber
            // 
            pnlNationalNumber.Controls.Add(lblNationalNumber);
            pnlNationalNumber.Controls.Add(txtNationalNumber);
            pnlNationalNumber.Dock = DockStyle.Fill;
            pnlNationalNumber.FlowDirection = FlowDirection.TopDown;
            pnlNationalNumber.Location = new Point(3, 153);
            pnlNationalNumber.Name = "pnlNationalNumber";
            pnlNationalNumber.Padding = new Padding(10, 0, 10, 0);
            pnlNationalNumber.Size = new Size(391, 69);
            pnlNationalNumber.TabIndex = 4;
            // 
            // lblNationalNumber
            // 
            lblNationalNumber.AutoSize = true;
            lblNationalNumber.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblNationalNumber.ForeColor = Color.FromArgb(74, 85, 104);
            lblNationalNumber.Location = new Point(307, 0);
            lblNationalNumber.Margin = new Padding(0, 0, 0, 4);
            lblNationalNumber.Name = "lblNationalNumber";
            lblNationalNumber.Size = new Size(64, 17);
            lblNationalNumber.TabIndex = 0;
            lblNationalNumber.Text = "رقم الهوية";
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNationalNumber.Location = new Point(7, 21);
            txtNationalNumber.Margin = new Padding(0);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(364, 26);
            txtNationalNumber.TabIndex = 1;
            // 
            // pnlPhone
            // 
            pnlPhone.Controls.Add(lblPhone);
            pnlPhone.Controls.Add(txtPhone);
            pnlPhone.Dock = DockStyle.Fill;
            pnlPhone.FlowDirection = FlowDirection.TopDown;
            pnlPhone.Location = new Point(400, 153);
            pnlPhone.Name = "pnlPhone";
            pnlPhone.Padding = new Padding(10, 0, 10, 0);
            pnlPhone.Size = new Size(391, 69);
            pnlPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPhone.ForeColor = Color.FromArgb(74, 85, 104);
            lblPhone.Location = new Point(306, 0);
            lblPhone.Margin = new Padding(0, 0, 0, 4);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 17);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "رقم الجوال";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.Location = new Point(6, 21);
            txtPhone.Margin = new Padding(0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(365, 26);
            txtPhone.TabIndex = 1;
            // 
            // pnlGender
            // 
            pnlGender.Controls.Add(lblGender);
            pnlGender.Controls.Add(cmbGender);
            pnlGender.Dock = DockStyle.Fill;
            pnlGender.FlowDirection = FlowDirection.TopDown;
            pnlGender.Location = new Point(3, 228);
            pnlGender.Name = "pnlGender";
            pnlGender.Padding = new Padding(10, 0, 10, 0);
            pnlGender.Size = new Size(391, 69);
            pnlGender.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblGender.ForeColor = Color.FromArgb(74, 85, 104);
            lblGender.Location = new Point(329, 0);
            lblGender.Margin = new Padding(0, 0, 0, 4);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(42, 17);
            lblGender.TabIndex = 0;
            lblGender.Text = "الجنس";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.Location = new Point(7, 21);
            cmbGender.Margin = new Padding(0);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(364, 27);
            cmbGender.TabIndex = 1;
            // 
            // pnlAddress
            // 
            pnlAddress.Controls.Add(lblAddress);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Dock = DockStyle.Fill;
            pnlAddress.FlowDirection = FlowDirection.TopDown;
            pnlAddress.Location = new Point(400, 228);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Padding = new Padding(10, 0, 10, 0);
            pnlAddress.Size = new Size(391, 69);
            pnlAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAddress.ForeColor = Color.FromArgb(74, 85, 104);
            lblAddress.Location = new Point(325, 0);
            lblAddress.Margin = new Padding(0, 0, 0, 4);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 17);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "العنوان";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.Location = new Point(6, 21);
            txtAddress.Margin = new Padding(0);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 26);
            txtAddress.TabIndex = 1;
            // 
            // tabStep2
            // 
            tabStep2.BackColor = Color.White;
            tabStep2.Controls.Add(gridStep2);
            tabStep2.Location = new Point(4, 5);
            tabStep2.Margin = new Padding(0);
            tabStep2.Name = "tabStep2";
            tabStep2.Size = new Size(794, 459);
            tabStep2.TabIndex = 1;
            // 
            // gridStep2
            // 
            gridStep2.ColumnCount = 2;
            gridStep2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep2.Controls.Add(pnlAssociatedDoctor, 1, 0);
            gridStep2.Controls.Add(pnlUsername, 0, 0);
            gridStep2.Controls.Add(pnlPassword, 1, 1);
            gridStep2.Controls.Add(pnlConfirmPassword, 0, 1);
            gridStep2.Controls.Add(pnlRole, 1, 2);
            gridStep2.Controls.Add(pnlUserActive, 0, 2);
            gridStep2.Dock = DockStyle.Top;
            gridStep2.Location = new Point(0, 0);
            gridStep2.Name = "gridStep2";
            gridStep2.RowCount = 3;
            gridStep2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep2.Size = new Size(794, 225);
            gridStep2.TabIndex = 0;
            // 
            // pnlAssociatedDoctor
            // 
            pnlAssociatedDoctor.Controls.Add(lblAssociatedDoctor);
            pnlAssociatedDoctor.Controls.Add(txtAssociatedDoctor);
            pnlAssociatedDoctor.Dock = DockStyle.Fill;
            pnlAssociatedDoctor.FlowDirection = FlowDirection.TopDown;
            pnlAssociatedDoctor.Location = new Point(3, 3);
            pnlAssociatedDoctor.Name = "pnlAssociatedDoctor";
            pnlAssociatedDoctor.Padding = new Padding(10, 0, 10, 0);
            pnlAssociatedDoctor.Size = new Size(391, 69);
            pnlAssociatedDoctor.TabIndex = 0;
            // 
            // lblAssociatedDoctor
            // 
            lblAssociatedDoctor.AutoSize = true;
            lblAssociatedDoctor.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAssociatedDoctor.ForeColor = Color.FromArgb(74, 85, 104);
            lblAssociatedDoctor.Location = new Point(283, 0);
            lblAssociatedDoctor.Margin = new Padding(0, 0, 0, 4);
            lblAssociatedDoctor.Name = "lblAssociatedDoctor";
            lblAssociatedDoctor.Size = new Size(88, 17);
            lblAssociatedDoctor.TabIndex = 0;
            lblAssociatedDoctor.Text = "الطبيب المرتبط";
            // 
            // txtAssociatedDoctor
            // 
            txtAssociatedDoctor.BackColor = Color.FromArgb(237, 242, 247);
            txtAssociatedDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtAssociatedDoctor.Location = new Point(-2, 21);
            txtAssociatedDoctor.Margin = new Padding(0);
            txtAssociatedDoctor.Name = "txtAssociatedDoctor";
            txtAssociatedDoctor.ReadOnly = true;
            txtAssociatedDoctor.Size = new Size(373, 26);
            txtAssociatedDoctor.TabIndex = 1;
            // 
            // pnlUsername
            // 
            pnlUsername.Controls.Add(lblUsername);
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Dock = DockStyle.Fill;
            pnlUsername.FlowDirection = FlowDirection.TopDown;
            pnlUsername.Location = new Point(400, 3);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Padding = new Padding(10, 0, 10, 0);
            pnlUsername.Size = new Size(391, 69);
            pnlUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblUsername.ForeColor = Color.FromArgb(74, 85, 104);
            lblUsername.Location = new Point(284, 0);
            lblUsername.Margin = new Padding(0, 0, 0, 4);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "اسم المستخدم";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.Location = new Point(-2, 21);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(373, 26);
            txtUsername.TabIndex = 1;
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Dock = DockStyle.Fill;
            pnlPassword.FlowDirection = FlowDirection.TopDown;
            pnlPassword.Location = new Point(3, 78);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(10, 0, 10, 0);
            pnlPassword.Size = new Size(391, 69);
            pnlPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPassword.ForeColor = Color.FromArgb(74, 85, 104);
            lblPassword.Location = new Point(302, 0);
            lblPassword.Margin = new Padding(0, 0, 0, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "كلمة المرور";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Location = new Point(-2, 21);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(373, 26);
            txtPassword.TabIndex = 1;
            // 
            // pnlConfirmPassword
            // 
            pnlConfirmPassword.Controls.Add(lblConfirmPassword);
            pnlConfirmPassword.Controls.Add(txtConfirmPassword);
            pnlConfirmPassword.Dock = DockStyle.Fill;
            pnlConfirmPassword.FlowDirection = FlowDirection.TopDown;
            pnlConfirmPassword.Location = new Point(400, 78);
            pnlConfirmPassword.Name = "pnlConfirmPassword";
            pnlConfirmPassword.Padding = new Padding(10, 0, 10, 0);
            pnlConfirmPassword.Size = new Size(391, 69);
            pnlConfirmPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblConfirmPassword.ForeColor = Color.FromArgb(74, 85, 104);
            lblConfirmPassword.Location = new Point(273, 0);
            lblConfirmPassword.Margin = new Padding(0, 0, 0, 4);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(98, 17);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "تأكيد كلمة المرور";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirmPassword.Location = new Point(-2, 21);
            txtConfirmPassword.Margin = new Padding(0);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(373, 26);
            txtConfirmPassword.TabIndex = 1;
            // 
            // pnlRole
            // 
            pnlRole.Controls.Add(lblRole);
            pnlRole.Controls.Add(cmbRole);
            pnlRole.Dock = DockStyle.Fill;
            pnlRole.FlowDirection = FlowDirection.TopDown;
            pnlRole.Location = new Point(3, 153);
            pnlRole.Name = "pnlRole";
            pnlRole.Padding = new Padding(10, 0, 10, 0);
            pnlRole.Size = new Size(391, 69);
            pnlRole.TabIndex = 4;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblRole.ForeColor = Color.FromArgb(74, 85, 104);
            lblRole.Location = new Point(317, 0);
            lblRole.Margin = new Padding(0, 0, 0, 4);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 17);
            lblRole.TabIndex = 0;
            lblRole.Text = "الصلاحية";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "طبيب" });
            cmbRole.Location = new Point(-2, 21);
            cmbRole.Margin = new Padding(0);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(373, 27);
            cmbRole.TabIndex = 1;
            // 
            // pnlUserActive
            // 
            pnlUserActive.Controls.Add(chkUserActive);
            pnlUserActive.Dock = DockStyle.Fill;
            pnlUserActive.FlowDirection = FlowDirection.TopDown;
            pnlUserActive.Location = new Point(400, 153);
            pnlUserActive.Name = "pnlUserActive";
            pnlUserActive.Padding = new Padding(10, 24, 10, 0);
            pnlUserActive.Size = new Size(391, 69);
            pnlUserActive.TabIndex = 5;
            // 
            // chkUserActive
            // 
            chkUserActive.AutoSize = true;
            chkUserActive.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkUserActive.Location = new Point(174, 24);
            chkUserActive.Margin = new Padding(0);
            chkUserActive.Name = "chkUserActive";
            chkUserActive.Size = new Size(197, 23);
            chkUserActive.TabIndex = 0;
            chkUserActive.Text = "الحساب نشط وفوري الفعالية";
            chkUserActive.UseVisualStyleBackColor = true;
            // 
            // tabStep3
            // 
            tabStep3.BackColor = Color.White;
            tabStep3.Controls.Add(pnlStep3Wrapper);
            tabStep3.Location = new Point(4, 5);
            tabStep3.Margin = new Padding(0);
            tabStep3.Name = "tabStep3";
            tabStep3.Size = new Size(794, 459);
            tabStep3.TabIndex = 2;
            // 
            // pnlStep3Wrapper
            // 
            pnlStep3Wrapper.ColumnCount = 1;
            pnlStep3Wrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlStep3Wrapper.Controls.Add(gridStep3, 0, 0);
            pnlStep3Wrapper.Controls.Add(btnSaveDoctor, 0, 1);
            pnlStep3Wrapper.Dock = DockStyle.Fill;
            pnlStep3Wrapper.Location = new Point(0, 0);
            pnlStep3Wrapper.Name = "pnlStep3Wrapper";
            pnlStep3Wrapper.RowCount = 2;
            pnlStep3Wrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 225F));
            pnlStep3Wrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlStep3Wrapper.Size = new Size(794, 459);
            pnlStep3Wrapper.TabIndex = 0;
            // 
            // gridStep3
            // 
            gridStep3.ColumnCount = 2;
            gridStep3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridStep3.Controls.Add(pnlLicenseNumber, 1, 0);
            gridStep3.Controls.Add(pnlSpecialization, 0, 0);
            gridStep3.Controls.Add(pnlOfficeLocation, 1, 1);
            gridStep3.Controls.Add(pnlSalary, 0, 1);
            gridStep3.Controls.Add(pnlExperienceYears, 1, 2);
            gridStep3.Controls.Add(pnlDoctorActive, 0, 2);
            gridStep3.Dock = DockStyle.Fill;
            gridStep3.Location = new Point(0, 0);
            gridStep3.Margin = new Padding(0);
            gridStep3.Name = "gridStep3";
            gridStep3.RowCount = 3;
            gridStep3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            gridStep3.Size = new Size(794, 225);
            gridStep3.TabIndex = 0;
            // 
            // pnlLicenseNumber
            // 
            pnlLicenseNumber.Controls.Add(lblLicenseNumber);
            pnlLicenseNumber.Controls.Add(txtLicenseNumber);
            pnlLicenseNumber.Dock = DockStyle.Fill;
            pnlLicenseNumber.FlowDirection = FlowDirection.TopDown;
            pnlLicenseNumber.Location = new Point(3, 3);
            pnlLicenseNumber.Name = "pnlLicenseNumber";
            pnlLicenseNumber.Padding = new Padding(10, 0, 10, 0);
            pnlLicenseNumber.Size = new Size(391, 69);
            pnlLicenseNumber.TabIndex = 0;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblLicenseNumber.ForeColor = Color.FromArgb(74, 85, 104);
            lblLicenseNumber.Location = new Point(263, 0);
            lblLicenseNumber.Margin = new Padding(0, 0, 0, 4);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(108, 17);
            lblLicenseNumber.TabIndex = 0;
            lblLicenseNumber.Text = "رقم الرخصة الطبية";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLicenseNumber.Location = new Point(-2, 21);
            txtLicenseNumber.Margin = new Padding(0);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(373, 26);
            txtLicenseNumber.TabIndex = 1;
            // 
            // pnlSpecialization
            // 
            pnlSpecialization.Controls.Add(lblSpecialization);
            pnlSpecialization.Controls.Add(txtSpecialization);
            pnlSpecialization.Dock = DockStyle.Fill;
            pnlSpecialization.FlowDirection = FlowDirection.TopDown;
            pnlSpecialization.Location = new Point(400, 3);
            pnlSpecialization.Name = "pnlSpecialization";
            pnlSpecialization.Padding = new Padding(10, 0, 10, 0);
            pnlSpecialization.Size = new Size(391, 69);
            pnlSpecialization.TabIndex = 1;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSpecialization.ForeColor = Color.FromArgb(74, 85, 104);
            lblSpecialization.Location = new Point(277, 0);
            lblSpecialization.Margin = new Padding(0, 0, 0, 4);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(94, 17);
            lblSpecialization.TabIndex = 0;
            lblSpecialization.Text = "التخصص الطبي";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSpecialization.Location = new Point(-2, 21);
            txtSpecialization.Margin = new Padding(0);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(373, 26);
            txtSpecialization.TabIndex = 1;
            // 
            // pnlOfficeLocation
            // 
            pnlOfficeLocation.Controls.Add(lblOfficeLocation);
            pnlOfficeLocation.Controls.Add(txtOfficeLocation);
            pnlOfficeLocation.Dock = DockStyle.Fill;
            pnlOfficeLocation.FlowDirection = FlowDirection.TopDown;
            pnlOfficeLocation.Location = new Point(3, 78);
            pnlOfficeLocation.Name = "pnlOfficeLocation";
            pnlOfficeLocation.Padding = new Padding(10, 0, 10, 0);
            pnlOfficeLocation.Size = new Size(391, 69);
            pnlOfficeLocation.TabIndex = 2;
            // 
            // lblOfficeLocation
            // 
            lblOfficeLocation.AutoSize = true;
            lblOfficeLocation.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblOfficeLocation.ForeColor = Color.FromArgb(74, 85, 104);
            lblOfficeLocation.Location = new Point(241, 0);
            lblOfficeLocation.Margin = new Padding(0, 0, 0, 4);
            lblOfficeLocation.Name = "lblOfficeLocation";
            lblOfficeLocation.Size = new Size(130, 17);
            lblOfficeLocation.TabIndex = 0;
            lblOfficeLocation.Text = "موقع العيادة / المكتب";
            // 
            // txtOfficeLocation
            // 
            txtOfficeLocation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOfficeLocation.Location = new Point(-2, 21);
            txtOfficeLocation.Margin = new Padding(0);
            txtOfficeLocation.Name = "txtOfficeLocation";
            txtOfficeLocation.Size = new Size(373, 26);
            txtOfficeLocation.TabIndex = 1;
            // 
            // pnlSalary
            // 
            pnlSalary.Controls.Add(lblSalary);
            pnlSalary.Controls.Add(txtSalary);
            pnlSalary.Dock = DockStyle.Fill;
            pnlSalary.FlowDirection = FlowDirection.TopDown;
            pnlSalary.Location = new Point(400, 78);
            pnlSalary.Name = "pnlSalary";
            pnlSalary.Padding = new Padding(10, 0, 10, 0);
            pnlSalary.Size = new Size(391, 69);
            pnlSalary.TabIndex = 3;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSalary.ForeColor = Color.FromArgb(74, 85, 104);
            lblSalary.Location = new Point(290, 0);
            lblSalary.Margin = new Padding(0, 0, 0, 4);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(81, 17);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "الراتب الشهري";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalary.Location = new Point(-2, 21);
            txtSalary.Margin = new Padding(0);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(373, 26);
            txtSalary.TabIndex = 1;
            // 
            // pnlExperienceYears
            // 
            pnlExperienceYears.Controls.Add(lblExperienceYears);
            pnlExperienceYears.Controls.Add(txtExperienceYears);
            pnlExperienceYears.Dock = DockStyle.Fill;
            pnlExperienceYears.FlowDirection = FlowDirection.TopDown;
            pnlExperienceYears.Location = new Point(3, 153);
            pnlExperienceYears.Name = "pnlExperienceYears";
            pnlExperienceYears.Padding = new Padding(10, 0, 10, 0);
            pnlExperienceYears.Size = new Size(391, 69);
            pnlExperienceYears.TabIndex = 4;
            // 
            // lblExperienceYears
            // 
            lblExperienceYears.AutoSize = true;
            lblExperienceYears.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblExperienceYears.ForeColor = Color.FromArgb(74, 85, 104);
            lblExperienceYears.Location = new Point(292, 0);
            lblExperienceYears.Margin = new Padding(0, 0, 0, 4);
            lblExperienceYears.Name = "lblExperienceYears";
            lblExperienceYears.Size = new Size(79, 17);
            lblExperienceYears.TabIndex = 0;
            lblExperienceYears.Text = "سنوات الخبرة";
            // 
            // txtExperienceYears
            // 
            txtExperienceYears.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExperienceYears.Location = new Point(-2, 21);
            txtExperienceYears.Margin = new Padding(0);
            txtExperienceYears.Name = "txtExperienceYears";
            txtExperienceYears.Size = new Size(373, 26);
            txtExperienceYears.TabIndex = 1;
            // 
            // pnlDoctorActive
            // 
            pnlDoctorActive.Controls.Add(chkDoctorActive);
            pnlDoctorActive.Dock = DockStyle.Fill;
            pnlDoctorActive.FlowDirection = FlowDirection.TopDown;
            pnlDoctorActive.Location = new Point(400, 153);
            pnlDoctorActive.Name = "pnlDoctorActive";
            pnlDoctorActive.Padding = new Padding(10, 24, 10, 0);
            pnlDoctorActive.Size = new Size(391, 69);
            pnlDoctorActive.TabIndex = 5;
            // 
            // chkDoctorActive
            // 
            chkDoctorActive.AutoSize = true;
            chkDoctorActive.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkDoctorActive.Location = new Point(210, 24);
            chkDoctorActive.Margin = new Padding(0);
            chkDoctorActive.Name = "chkDoctorActive";
            chkDoctorActive.Size = new Size(161, 23);
            chkDoctorActive.TabIndex = 0;
            chkDoctorActive.Text = "طبيب نشط بالمنظومة";
            chkDoctorActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveDoctor
            // 
            btnSaveDoctor.BackColor = Color.FromArgb(72, 187, 120);
            btnSaveDoctor.Dock = DockStyle.Top;
            btnSaveDoctor.FlatAppearance.BorderSize = 0;
            btnSaveDoctor.FlatStyle = FlatStyle.Flat;
            btnSaveDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnSaveDoctor.ForeColor = Color.White;
            btnSaveDoctor.Location = new Point(10, 245);
            btnSaveDoctor.Margin = new Padding(10, 20, 10, 10);
            btnSaveDoctor.Name = "btnSaveDoctor";
            btnSaveDoctor.Size = new Size(774, 42);
            btnSaveDoctor.TabIndex = 1;
            btnSaveDoctor.Text = "إتمام حفظ بيانات الطبيب بالكامل";
            btnSaveDoctor.UseVisualStyleBackColor = false;
            // 
            // navigationLayout
            // 
            navigationLayout.ColumnCount = 2;
            navigationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            navigationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            navigationLayout.Controls.Add(btnNext, 0, 0);
            navigationLayout.Controls.Add(btnBack, 1, 0);
            navigationLayout.Dock = DockStyle.Fill;
            navigationLayout.Location = new Point(0, 483);
            navigationLayout.Margin = new Padding(0, 15, 0, 0);
            navigationLayout.Name = "navigationLayout";
            navigationLayout.RowCount = 1;
            navigationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            navigationLayout.Size = new Size(802, 38);
            navigationLayout.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(49, 130, 206);
            btnNext.Dock = DockStyle.Left;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(692, 0);
            btnNext.Margin = new Padding(0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(110, 38);
            btnNext.TabIndex = 0;
            btnNext.Text = "التالي";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(160, 174, 192);
            btnBack.Dock = DockStyle.Right;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 38);
            btnBack.TabIndex = 1;
            btnBack.Text = "السابق";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 252);
            ClientSize = new Size(884, 661);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 9F);
            Name = "frmDoctor";
            Padding = new Padding(20);
            RightToLeft = RightToLeft.Yes;
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentCard.ResumeLayout(false);
            cardLayout.ResumeLayout(false);
            wizardTabs.ResumeLayout(false);
            tabStep1.ResumeLayout(false);
            scrollStep1.ResumeLayout(false);
            gridStep1.ResumeLayout(false);
            pnlFirstName.ResumeLayout(false);
            pnlFirstName.PerformLayout();
            pnlSecondName.ResumeLayout(false);
            pnlSecondName.PerformLayout();
            pnlThirdName.ResumeLayout(false);
            pnlThirdName.PerformLayout();
            pnlLastName.ResumeLayout(false);
            pnlLastName.PerformLayout();
            pnlNationalNumber.ResumeLayout(false);
            pnlNationalNumber.PerformLayout();
            pnlPhone.ResumeLayout(false);
            pnlPhone.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            pnlAddress.ResumeLayout(false);
            pnlAddress.PerformLayout();
            tabStep2.ResumeLayout(false);
            gridStep2.ResumeLayout(false);
            pnlAssociatedDoctor.ResumeLayout(false);
            pnlAssociatedDoctor.PerformLayout();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlConfirmPassword.ResumeLayout(false);
            pnlConfirmPassword.PerformLayout();
            pnlRole.ResumeLayout(false);
            pnlRole.PerformLayout();
            pnlUserActive.ResumeLayout(false);
            pnlUserActive.PerformLayout();
            tabStep3.ResumeLayout(false);
            pnlStep3Wrapper.ResumeLayout(false);
            gridStep3.ResumeLayout(false);
            pnlLicenseNumber.ResumeLayout(false);
            pnlLicenseNumber.PerformLayout();
            pnlSpecialization.ResumeLayout(false);
            pnlSpecialization.PerformLayout();
            pnlOfficeLocation.ResumeLayout(false);
            pnlOfficeLocation.PerformLayout();
            pnlSalary.ResumeLayout(false);
            pnlSalary.PerformLayout();
            pnlExperienceYears.ResumeLayout(false);
            pnlExperienceYears.PerformLayout();
            pnlDoctorActive.ResumeLayout(false);
            pnlDoctorActive.PerformLayout();
            navigationLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Label lblStepTitle;
        private System.Windows.Forms.Label lblStepCount;
        private System.Windows.Forms.Panel contentCard;
        private System.Windows.Forms.TableLayoutPanel cardLayout;
        private System.Windows.Forms.TabControl wizardTabs;
        private System.Windows.Forms.TabPage tabStep1;
        private System.Windows.Forms.Panel scrollStep1;
        private System.Windows.Forms.TableLayoutPanel gridStep1;
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
        private System.Windows.Forms.FlowLayoutPanel pnlNationalNumber;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.FlowLayoutPanel pnlPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.FlowLayoutPanel pnlGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.FlowLayoutPanel pnlAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TabPage tabStep2;
        private System.Windows.Forms.TableLayoutPanel gridStep2;
        private System.Windows.Forms.FlowLayoutPanel pnlAssociatedDoctor;
        private System.Windows.Forms.Label lblAssociatedDoctor;
        private System.Windows.Forms.TextBox txtAssociatedDoctor;
        private System.Windows.Forms.FlowLayoutPanel pnlUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.FlowLayoutPanel pnlPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel pnlConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.FlowLayoutPanel pnlRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.FlowLayoutPanel pnlUserActive;
        private System.Windows.Forms.CheckBox chkUserActive;
        private System.Windows.Forms.TabPage tabStep3;
        private System.Windows.Forms.TableLayoutPanel pnlStep3Wrapper;
        private System.Windows.Forms.TableLayoutPanel gridStep3;
        private System.Windows.Forms.FlowLayoutPanel pnlLicenseNumber;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.FlowLayoutPanel pnlSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.FlowLayoutPanel pnlOfficeLocation;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.TextBox txtOfficeLocation;
        private System.Windows.Forms.FlowLayoutPanel pnlSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.FlowLayoutPanel pnlExperienceYears;
        private System.Windows.Forms.Label lblExperienceYears;
        private System.Windows.Forms.TextBox txtExperienceYears;
        private System.Windows.Forms.FlowLayoutPanel pnlDoctorActive;
        private System.Windows.Forms.CheckBox chkDoctorActive;
        private System.Windows.Forms.Button btnSaveDoctor;
        private System.Windows.Forms.TableLayoutPanel navigationLayout;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}