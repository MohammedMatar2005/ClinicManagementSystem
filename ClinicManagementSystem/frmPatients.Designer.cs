namespace ClinicManagementSystem
{
    partial class frmPatients : Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainTableLayout = new TableLayoutPanel();
            topDecorativeBorder = new Panel();
            pnlFormCard = new Panel();
            formLayout = new TableLayoutPanel();
            lblFormTitle = new Label();
            gridRow1 = new TableLayoutPanel();
            pnlFullName = new Panel();
            txtFullName = new TextBox();
            lblFullName = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            pnlBloodType = new Panel();
            cmbBloodType = new ComboBox();
            lblBloodType = new Label();
            pnlStatus = new Panel();
            chkIsActive = new CheckBox();
            lblStatus = new Label();
            gridRow2 = new TableLayoutPanel();
            pnlEmergencyContact = new Panel();
            txtEmergencyContact = new TextBox();
            lblEmergencyContact = new Label();
            pnlEmergencyPhone = new Panel();
            txtEmergencyPhone = new TextBox();
            lblEmergencyPhone = new Label();
            pnlAddress = new Panel();
            txtAddress = new TextBox();
            lblAddress = new Label();
            gridRow3 = new TableLayoutPanel();
            pnlAllergies = new Panel();
            txtAllergies = new TextBox();
            lblAllergies = new Label();
            pnlMedicalHistory = new Panel();
            txtMedicalHistory = new TextBox();
            lblMedicalHistory = new Label();
            actionsFlowLayout = new FlowLayoutPanel();
            btnSave = new Button();
            btnClear = new Button();
            pnlGridCard = new Panel();
            gridLayout = new TableLayoutPanel();
            lblGridTitle = new Label();
            dgvPatients = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colBloodType = new DataGridViewTextBoxColumn();
            colEmergencyContact = new DataGridViewTextBoxColumn();
            colEmergencyPhone = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewTextBoxColumn();
            mainTableLayout.SuspendLayout();
            pnlFormCard.SuspendLayout();
            formLayout.SuspendLayout();
            gridRow1.SuspendLayout();
            pnlFullName.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlBloodType.SuspendLayout();
            pnlStatus.SuspendLayout();
            gridRow2.SuspendLayout();
            pnlEmergencyContact.SuspendLayout();
            pnlEmergencyPhone.SuspendLayout();
            pnlAddress.SuspendLayout();
            gridRow3.SuspendLayout();
            pnlAllergies.SuspendLayout();
            pnlMedicalHistory.SuspendLayout();
            actionsFlowLayout.SuspendLayout();
            pnlGridCard.SuspendLayout();
            gridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(topDecorativeBorder, 0, 0);
            mainTableLayout.Controls.Add(pnlFormCard, 0, 1);
            mainTableLayout.Controls.Add(pnlGridCard, 0, 2);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            mainTableLayout.RowStyles.Add(new RowStyle());
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(984, 749);
            mainTableLayout.TabIndex = 0;
            // 
            // topDecorativeBorder
            // 
            topDecorativeBorder.BackColor = Color.FromArgb(46, 204, 113);
            topDecorativeBorder.Dock = DockStyle.Fill;
            topDecorativeBorder.Location = new Point(20, 10);
            topDecorativeBorder.Margin = new Padding(20, 10, 20, 0);
            topDecorativeBorder.Name = "topDecorativeBorder";
            topDecorativeBorder.Size = new Size(944, 4);
            topDecorativeBorder.TabIndex = 0;
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.Controls.Add(formLayout);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(20, 24);
            pnlFormCard.Margin = new Padding(20, 10, 20, 10);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(25);
            pnlFormCard.Size = new Size(944, 400);
            pnlFormCard.TabIndex = 1;
            // 
            // formLayout
            // 
            formLayout.ColumnCount = 1;
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayout.Controls.Add(lblFormTitle, 0, 0);
            formLayout.Controls.Add(gridRow1, 0, 1);
            formLayout.Controls.Add(gridRow2, 0, 2);
            formLayout.Controls.Add(gridRow3, 0, 3);
            formLayout.Controls.Add(actionsFlowLayout, 0, 4);
            formLayout.Dock = DockStyle.Fill;
            formLayout.Location = new Point(25, 25);
            formLayout.Name = "formLayout";
            formLayout.RowCount = 5;
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            formLayout.Size = new Size(894, 350);
            formLayout.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(3, 0);
            lblFormTitle.Margin = new Padding(3, 0, 3, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(888, 20);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "إدارة بيانات المرضى";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridRow1
            // 
            gridRow1.ColumnCount = 4;
            gridRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridRow1.Controls.Add(pnlFullName, 0, 0);
            gridRow1.Controls.Add(pnlEmail, 1, 0);
            gridRow1.Controls.Add(pnlBloodType, 2, 0);
            gridRow1.Controls.Add(pnlStatus, 3, 0);
            gridRow1.Dock = DockStyle.Fill;
            gridRow1.Location = new Point(0, 40);
            gridRow1.Margin = new Padding(0);
            gridRow1.Name = "gridRow1";
            gridRow1.RowCount = 1;
            gridRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridRow1.Size = new Size(894, 75);
            gridRow1.TabIndex = 1;
            // 
            // pnlFullName
            // 
            pnlFullName.Controls.Add(txtFullName);
            pnlFullName.Controls.Add(lblFullName);
            pnlFullName.Dock = DockStyle.Fill;
            pnlFullName.Location = new Point(681, 5);
            pnlFullName.Margin = new Padding(10, 5, 10, 5);
            pnlFullName.Name = "pnlFullName";
            pnlFullName.Size = new Size(203, 65);
            pnlFullName.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Dock = DockStyle.Bottom;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(0, 27);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(203, 38);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Dock = DockStyle.Top;
            lblFullName.Font = new Font("Segoe UI", 9.5F);
            lblFullName.ForeColor = Color.FromArgb(93, 122, 149);
            lblFullName.Location = new Point(0, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(118, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "اسم المريض بالكامل";
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Controls.Add(lblEmail);
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.Location = new Point(458, 5);
            pnlEmail.Margin = new Padding(10, 5, 10, 5);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(203, 65);
            pnlEmail.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Dock = DockStyle.Bottom;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(0, 27);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 38);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Top;
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.ForeColor = Color.FromArgb(93, 122, 149);
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(91, 17);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "البريد الإلكتروني";
            // 
            // pnlBloodType
            // 
            pnlBloodType.Controls.Add(cmbBloodType);
            pnlBloodType.Controls.Add(lblBloodType);
            pnlBloodType.Dock = DockStyle.Fill;
            pnlBloodType.Location = new Point(235, 5);
            pnlBloodType.Margin = new Padding(10, 5, 10, 5);
            pnlBloodType.Name = "pnlBloodType";
            pnlBloodType.Size = new Size(203, 65);
            pnlBloodType.TabIndex = 2;
            // 
            // cmbBloodType
            // 
            cmbBloodType.BackColor = Color.White;
            cmbBloodType.Dock = DockStyle.Bottom;
            cmbBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodType.Font = new Font("Segoe UI", 11F);
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbBloodType.Location = new Point(0, 37);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(203, 28);
            cmbBloodType.TabIndex = 1;
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Dock = DockStyle.Top;
            lblBloodType.Font = new Font("Segoe UI", 9.5F);
            lblBloodType.ForeColor = Color.FromArgb(93, 122, 149);
            lblBloodType.Location = new Point(0, 0);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(69, 17);
            lblBloodType.TabIndex = 0;
            lblBloodType.Text = "فصيلة الدم";
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(chkIsActive);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Fill;
            pnlStatus.Location = new Point(10, 5);
            pnlStatus.Margin = new Padding(10, 5, 10, 5);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(205, 65);
            pnlStatus.TabIndex = 3;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Dock = DockStyle.Bottom;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(0, 42);
            chkIsActive.Margin = new Padding(0, 10, 0, 0);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(205, 23);
            chkIsActive.TabIndex = 1;
            chkIsActive.Text = "نشط";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(93, 122, 149);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(37, 17);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "الحالة";
            // 
            // gridRow2
            // 
            gridRow2.ColumnCount = 3;
            gridRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            gridRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            gridRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            gridRow2.Controls.Add(pnlEmergencyContact, 0, 0);
            gridRow2.Controls.Add(pnlEmergencyPhone, 1, 0);
            gridRow2.Controls.Add(pnlAddress, 2, 0);
            gridRow2.Dock = DockStyle.Fill;
            gridRow2.Location = new Point(0, 125);
            gridRow2.Margin = new Padding(0, 10, 0, 0);
            gridRow2.Name = "gridRow2";
            gridRow2.RowCount = 1;
            gridRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridRow2.Size = new Size(894, 65);
            gridRow2.TabIndex = 2;
            // 
            // pnlEmergencyContact
            // 
            pnlEmergencyContact.Controls.Add(txtEmergencyContact);
            pnlEmergencyContact.Controls.Add(lblEmergencyContact);
            pnlEmergencyContact.Dock = DockStyle.Fill;
            pnlEmergencyContact.Location = new Point(606, 5);
            pnlEmergencyContact.Margin = new Padding(10, 5, 10, 5);
            pnlEmergencyContact.Name = "pnlEmergencyContact";
            pnlEmergencyContact.Size = new Size(278, 55);
            pnlEmergencyContact.TabIndex = 0;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.BackColor = Color.White;
            txtEmergencyContact.Dock = DockStyle.Bottom;
            txtEmergencyContact.Font = new Font("Segoe UI", 11F);
            txtEmergencyContact.Location = new Point(0, 17);
            txtEmergencyContact.Multiline = true;
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(278, 38);
            txtEmergencyContact.TabIndex = 1;
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.AutoSize = true;
            lblEmergencyContact.Dock = DockStyle.Top;
            lblEmergencyContact.Font = new Font("Segoe UI", 9.5F);
            lblEmergencyContact.ForeColor = Color.FromArgb(93, 122, 149);
            lblEmergencyContact.Location = new Point(0, 0);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(112, 17);
            lblEmergencyContact.TabIndex = 0;
            lblEmergencyContact.Text = "جهة اتصال الطوارئ";
            // 
            // pnlEmergencyPhone
            // 
            pnlEmergencyPhone.Controls.Add(txtEmergencyPhone);
            pnlEmergencyPhone.Controls.Add(lblEmergencyPhone);
            pnlEmergencyPhone.Dock = DockStyle.Fill;
            pnlEmergencyPhone.Location = new Point(308, 5);
            pnlEmergencyPhone.Margin = new Padding(10, 5, 10, 5);
            pnlEmergencyPhone.Name = "pnlEmergencyPhone";
            pnlEmergencyPhone.Size = new Size(278, 55);
            pnlEmergencyPhone.TabIndex = 1;
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.BackColor = Color.White;
            txtEmergencyPhone.Dock = DockStyle.Bottom;
            txtEmergencyPhone.Font = new Font("Segoe UI", 11F);
            txtEmergencyPhone.Location = new Point(0, 17);
            txtEmergencyPhone.Multiline = true;
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(278, 38);
            txtEmergencyPhone.TabIndex = 1;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.AutoSize = true;
            lblEmergencyPhone.Dock = DockStyle.Top;
            lblEmergencyPhone.Font = new Font("Segoe UI", 9.5F);
            lblEmergencyPhone.ForeColor = Color.FromArgb(93, 122, 149);
            lblEmergencyPhone.Location = new Point(0, 0);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(83, 17);
            lblEmergencyPhone.TabIndex = 0;
            lblEmergencyPhone.Text = "هاتف الطوارئ";
            // 
            // pnlAddress
            // 
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Controls.Add(lblAddress);
            pnlAddress.Dock = DockStyle.Fill;
            pnlAddress.Location = new Point(10, 5);
            pnlAddress.Margin = new Padding(10, 5, 10, 5);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(278, 55);
            pnlAddress.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Dock = DockStyle.Bottom;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(0, 17);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 38);
            txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Top;
            lblAddress.Font = new Font("Segoe UI", 9.5F);
            lblAddress.ForeColor = Color.FromArgb(93, 122, 149);
            lblAddress.Location = new Point(0, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 17);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "العنوان";
            // 
            // gridRow3
            // 
            gridRow3.ColumnCount = 2;
            gridRow3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridRow3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridRow3.Controls.Add(pnlAllergies, 0, 0);
            gridRow3.Controls.Add(pnlMedicalHistory, 1, 0);
            gridRow3.Dock = DockStyle.Fill;
            gridRow3.Location = new Point(0, 205);
            gridRow3.Margin = new Padding(0, 15, 0, 0);
            gridRow3.Name = "gridRow3";
            gridRow3.RowCount = 1;
            gridRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridRow3.Size = new Size(894, 80);
            gridRow3.TabIndex = 3;
            // 
            // pnlAllergies
            // 
            pnlAllergies.Controls.Add(txtAllergies);
            pnlAllergies.Controls.Add(lblAllergies);
            pnlAllergies.Dock = DockStyle.Fill;
            pnlAllergies.Location = new Point(457, 5);
            pnlAllergies.Margin = new Padding(10, 5, 10, 5);
            pnlAllergies.Name = "pnlAllergies";
            pnlAllergies.Size = new Size(427, 70);
            pnlAllergies.TabIndex = 0;
            // 
            // txtAllergies
            // 
            txtAllergies.AcceptsReturn = true;
            txtAllergies.BackColor = Color.White;
            txtAllergies.Dock = DockStyle.Bottom;
            txtAllergies.Font = new Font("Segoe UI", 10F);
            txtAllergies.Location = new Point(0, 10);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.ScrollBars = ScrollBars.Vertical;
            txtAllergies.Size = new Size(427, 60);
            txtAllergies.TabIndex = 1;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Dock = DockStyle.Top;
            lblAllergies.Font = new Font("Segoe UI", 9.5F);
            lblAllergies.ForeColor = Color.FromArgb(93, 122, 149);
            lblAllergies.Location = new Point(0, 0);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(121, 17);
            lblAllergies.TabIndex = 0;
            lblAllergies.Text = "الحساسية (Allergies)";
            // 
            // pnlMedicalHistory
            // 
            pnlMedicalHistory.Controls.Add(txtMedicalHistory);
            pnlMedicalHistory.Controls.Add(lblMedicalHistory);
            pnlMedicalHistory.Dock = DockStyle.Fill;
            pnlMedicalHistory.Location = new Point(10, 5);
            pnlMedicalHistory.Margin = new Padding(10, 5, 10, 5);
            pnlMedicalHistory.Name = "pnlMedicalHistory";
            pnlMedicalHistory.Size = new Size(427, 70);
            pnlMedicalHistory.TabIndex = 1;
            // 
            // txtMedicalHistory
            // 
            txtMedicalHistory.AcceptsReturn = true;
            txtMedicalHistory.BackColor = Color.White;
            txtMedicalHistory.Dock = DockStyle.Bottom;
            txtMedicalHistory.Font = new Font("Segoe UI", 10F);
            txtMedicalHistory.Location = new Point(0, 10);
            txtMedicalHistory.Multiline = true;
            txtMedicalHistory.Name = "txtMedicalHistory";
            txtMedicalHistory.ScrollBars = ScrollBars.Vertical;
            txtMedicalHistory.Size = new Size(427, 60);
            txtMedicalHistory.TabIndex = 1;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.Dock = DockStyle.Top;
            lblMedicalHistory.Font = new Font("Segoe UI", 9.5F);
            lblMedicalHistory.ForeColor = Color.FromArgb(93, 122, 149);
            lblMedicalHistory.Location = new Point(0, 0);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(187, 17);
            lblMedicalHistory.TabIndex = 0;
            lblMedicalHistory.Text = "التاريخ المرضي (Medical History)";
            // 
            // actionsFlowLayout
            // 
            actionsFlowLayout.Controls.Add(btnSave);
            actionsFlowLayout.Controls.Add(btnClear);
            actionsFlowLayout.Dock = DockStyle.Fill;
            actionsFlowLayout.Location = new Point(0, 305);
            actionsFlowLayout.Margin = new Padding(0, 20, 0, 0);
            actionsFlowLayout.Name = "actionsFlowLayout";
            actionsFlowLayout.Size = new Size(894, 45);
            actionsFlowLayout.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(734, 5);
            btnSave.Margin = new Padding(10, 5, 10, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(189, 195, 199);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(614, 5);
            btnClear.Margin = new Padding(10, 5, 10, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "تفريغ الحقول";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlGridCard
            // 
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.Controls.Add(gridLayout);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(20, 444);
            pnlGridCard.Margin = new Padding(20, 10, 20, 20);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(944, 285);
            pnlGridCard.TabIndex = 2;
            // 
            // gridLayout
            // 
            gridLayout.ColumnCount = 1;
            gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gridLayout.Controls.Add(lblGridTitle, 0, 0);
            gridLayout.Controls.Add(dgvPatients, 0, 1);
            gridLayout.Dock = DockStyle.Fill;
            gridLayout.Location = new Point(15, 15);
            gridLayout.Name = "gridLayout";
            gridLayout.RowCount = 2;
            gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridLayout.Size = new Size(914, 255);
            gridLayout.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Dock = DockStyle.Fill;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblGridTitle.Location = new Point(3, 5);
            lblGridTitle.Margin = new Padding(3, 5, 3, 15);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(908, 15);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "سجل المرضى المسجلين";
            lblGridTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AllowUserToResizeRows = false;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 122, 149);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeight = 40;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colFullName, colBloodType, colEmergencyContact, colEmergencyPhone, colCreatedDate, colIsActive });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 243, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = Color.FromArgb(235, 238, 245);
            dgvPatients.Location = new Point(3, 38);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(908, 214);
            dgvPatients.TabIndex = 1;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "الاسم";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 300;
            // 
            // colBloodType
            // 
            colBloodType.DataPropertyName = "BloodType";
            colBloodType.HeaderText = "فصيلة الدم";
            colBloodType.Name = "colBloodType";
            colBloodType.ReadOnly = true;
            // 
            // colEmergencyContact
            // 
            colEmergencyContact.DataPropertyName = "EmergencyContact";
            colEmergencyContact.HeaderText = "جهة الطوارئ";
            colEmergencyContact.Name = "colEmergencyContact";
            colEmergencyContact.ReadOnly = true;
            colEmergencyContact.Width = 170;
            // 
            // colEmergencyPhone
            // 
            colEmergencyPhone.DataPropertyName = "EmergencyPhone";
            colEmergencyPhone.HeaderText = "هاتف الطوارئ";
            colEmergencyPhone.Name = "colEmergencyPhone";
            colEmergencyPhone.ReadOnly = true;
            colEmergencyPhone.Width = 120;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDate";
            colCreatedDate.HeaderText = "تاريخ التسجيل";
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.ReadOnly = true;
            colCreatedDate.Width = 150;
            // 
            // colIsActive
            // 
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "الحالة";
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            // 
            // frmPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(984, 749);
            Controls.Add(mainTableLayout);
            Font = new Font("Segoe UI", 9F);
            Name = "frmPatients";
            RightToLeft = RightToLeft.Yes;
            mainTableLayout.ResumeLayout(false);
            pnlFormCard.ResumeLayout(false);
            formLayout.ResumeLayout(false);
            formLayout.PerformLayout();
            gridRow1.ResumeLayout(false);
            pnlFullName.ResumeLayout(false);
            pnlFullName.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlBloodType.ResumeLayout(false);
            pnlBloodType.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            gridRow2.ResumeLayout(false);
            pnlEmergencyContact.ResumeLayout(false);
            pnlEmergencyContact.PerformLayout();
            pnlEmergencyPhone.ResumeLayout(false);
            pnlEmergencyPhone.PerformLayout();
            pnlAddress.ResumeLayout(false);
            pnlAddress.PerformLayout();
            gridRow3.ResumeLayout(false);
            pnlAllergies.ResumeLayout(false);
            pnlAllergies.PerformLayout();
            pnlMedicalHistory.ResumeLayout(false);
            pnlMedicalHistory.PerformLayout();
            actionsFlowLayout.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            gridLayout.ResumeLayout(false);
            gridLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel topDecorativeBorder;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TableLayoutPanel gridRow1;
        private System.Windows.Forms.Panel pnlFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlBloodType;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TableLayoutPanel gridRow2;
        private System.Windows.Forms.Panel pnlEmergencyContact;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Panel pnlEmergencyPhone;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.TextBox txtEmergencyPhone;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TableLayoutPanel gridRow3;
        private System.Windows.Forms.Panel pnlAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Panel pnlMedicalHistory;
        private System.Windows.Forms.Label lblMedicalHistory;
        private System.Windows.Forms.TextBox txtMedicalHistory;
        private System.Windows.Forms.FlowLayoutPanel actionsFlowLayout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.TableLayoutPanel gridLayout;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
    }
}