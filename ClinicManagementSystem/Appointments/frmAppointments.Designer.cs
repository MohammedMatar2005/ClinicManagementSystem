using System.ComponentModel;

namespace ClinicManagementSystem
{
    partial class frmAppointments : Form
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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainGridPanel = new Panel();
            tabControl = new TabControl();
            tabBookAppointment = new TabPage();
            tlpBookRoot = new TableLayoutPanel();
            pnlTopBorder = new Panel();
            pnlFormCard = new Panel();
            tlpFormLayout = new TableLayoutPanel();
            lblFormTitle = new Label();
            tlpRow1Uniform = new TableLayoutPanel();
            pnlPatientField = new Panel();
            txtPatinetId = new TextBox();
            lblPatient = new Label();
            pnlReasonField = new Panel();
            txtReason = new TextBox();
            lblReason = new Label();
            tlpRow2Uniform = new TableLayoutPanel();
            pnlDoctorField = new Panel();
            cmbDoctors = new ComboBox();
            lblDoctor = new Label();
            pnlDateField = new Panel();
            dtpAppointmentDate = new DateTimePicker();
            lblDate = new Label();
            pnlStatusField = new Panel();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            pnlNotesField = new Panel();
            txtNotes = new TextBox();
            lblNotes = new Label();
            flpButtonsContainer = new FlowLayoutPanel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            tabAppointmentHistory = new TabPage();
            pnlHistoryCard = new Panel();
            tlpHistoryLayout = new TableLayoutPanel();
            lblHistoryTitle = new Label();
            flpFilters = new FlowLayoutPanel();
            lblSearch = new Label();
            cmbSearchType = new ComboBox();
            txtSearchValue = new TextBox();
            dgvAppointments = new DataGridView();
            colAppointmentId = new DataGridViewTextBoxColumn();
            PatientNationalNumber = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            colAppointmentDate = new DataGridViewTextBoxColumn();
            colStatusName = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowInfoMenuItem = new ToolStripMenuItem();
            UpdateAppointmentMenuItem = new ToolStripMenuItem();
            DeleteAppointmentMenuItem = new ToolStripMenuItem();
            AddNewAppointmentMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            mainGridPanel.SuspendLayout();
            tabControl.SuspendLayout();
            tabBookAppointment.SuspendLayout();
            tlpBookRoot.SuspendLayout();
            pnlFormCard.SuspendLayout();
            tlpFormLayout.SuspendLayout();
            tlpRow1Uniform.SuspendLayout();
            pnlPatientField.SuspendLayout();
            pnlReasonField.SuspendLayout();
            tlpRow2Uniform.SuspendLayout();
            pnlDoctorField.SuspendLayout();
            pnlDateField.SuspendLayout();
            pnlStatusField.SuspendLayout();
            pnlNotesField.SuspendLayout();
            flpButtonsContainer.SuspendLayout();
            tabAppointmentHistory.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            tlpHistoryLayout.SuspendLayout();
            flpFilters.SuspendLayout();
            ((ISupportInitialize)dgvAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // mainGridPanel
            // 
            mainGridPanel.BackColor = Color.FromArgb(244, 247, 250);
            mainGridPanel.Controls.Add(tabControl);
            mainGridPanel.Dock = DockStyle.Fill;
            mainGridPanel.Location = new Point(0, 0);
            mainGridPanel.Name = "mainGridPanel";
            mainGridPanel.Padding = new Padding(10);
            mainGridPanel.Size = new Size(984, 661);
            mainGridPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBookAppointment);
            tabControl.Controls.Add(tabAppointmentHistory);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControl.ItemSize = new Size(160, 40);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(964, 641);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabBookAppointment
            // 
            tabBookAppointment.BackColor = Color.FromArgb(244, 247, 250);
            tabBookAppointment.Controls.Add(tlpBookRoot);
            tabBookAppointment.Font = new Font("Segoe UI", 10F);
            tabBookAppointment.Location = new Point(4, 44);
            tabBookAppointment.Name = "tabBookAppointment";
            tabBookAppointment.RightToLeft = RightToLeft.Yes;
            tabBookAppointment.Size = new Size(956, 593);
            tabBookAppointment.TabIndex = 0;
            tabBookAppointment.Text = "📅 حجز موعد";
            // 
            // tlpBookRoot
            // 
            tlpBookRoot.ColumnCount = 1;
            tlpBookRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBookRoot.Controls.Add(pnlTopBorder, 0, 0);
            tlpBookRoot.Controls.Add(pnlFormCard, 0, 1);
            tlpBookRoot.Dock = DockStyle.Fill;
            tlpBookRoot.Location = new Point(0, 0);
            tlpBookRoot.Name = "tlpBookRoot";
            tlpBookRoot.RowCount = 2;
            tlpBookRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tlpBookRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBookRoot.Size = new Size(956, 593);
            tlpBookRoot.TabIndex = 0;
            // 
            // pnlTopBorder
            // 
            pnlTopBorder.BackColor = Color.FromArgb(26, 37, 51);
            pnlTopBorder.Dock = DockStyle.Fill;
            pnlTopBorder.Location = new Point(10, 5);
            pnlTopBorder.Margin = new Padding(10, 5, 10, 0);
            pnlTopBorder.Name = "pnlTopBorder";
            pnlTopBorder.Size = new Size(936, 4);
            pnlTopBorder.TabIndex = 0;
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.Controls.Add(tlpFormLayout);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(10, 24);
            pnlFormCard.Margin = new Padding(10, 15, 10, 10);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(25);
            pnlFormCard.Size = new Size(936, 559);
            pnlFormCard.TabIndex = 1;
            // 
            // tlpFormLayout
            // 
            tlpFormLayout.ColumnCount = 1;
            tlpFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormLayout.Controls.Add(lblFormTitle, 0, 0);
            tlpFormLayout.Controls.Add(tlpRow1Uniform, 0, 1);
            tlpFormLayout.Controls.Add(tlpRow2Uniform, 0, 2);
            tlpFormLayout.Controls.Add(pnlNotesField, 0, 3);
            tlpFormLayout.Controls.Add(flpButtonsContainer, 0, 4);
            tlpFormLayout.Dock = DockStyle.Fill;
            tlpFormLayout.Location = new Point(25, 25);
            tlpFormLayout.Name = "tlpFormLayout";
            tlpFormLayout.RowCount = 5;
            tlpFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tlpFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFormLayout.Size = new Size(886, 509);
            tlpFormLayout.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblFormTitle.Location = new Point(691, 0);
            lblFormTitle.Margin = new Padding(0, 0, 0, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(195, 30);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "بيانات الموعد الطبي";
            // 
            // tlpRow1Uniform
            // 
            tlpRow1Uniform.ColumnCount = 2;
            tlpRow1Uniform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRow1Uniform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRow1Uniform.Controls.Add(pnlPatientField, 0, 0);
            tlpRow1Uniform.Controls.Add(pnlReasonField, 1, 0);
            tlpRow1Uniform.Dock = DockStyle.Fill;
            tlpRow1Uniform.Location = new Point(0, 45);
            tlpRow1Uniform.Margin = new Padding(0);
            tlpRow1Uniform.Name = "tlpRow1Uniform";
            tlpRow1Uniform.RowCount = 1;
            tlpRow1Uniform.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRow1Uniform.Size = new Size(886, 95);
            tlpRow1Uniform.TabIndex = 1;
            // 
            // pnlPatientField
            // 
            pnlPatientField.Controls.Add(txtPatinetId);
            pnlPatientField.Controls.Add(lblPatient);
            pnlPatientField.Dock = DockStyle.Fill;
            pnlPatientField.Location = new Point(453, 10);
            pnlPatientField.Margin = new Padding(10);
            pnlPatientField.Name = "pnlPatientField";
            pnlPatientField.Size = new Size(423, 75);
            pnlPatientField.TabIndex = 0;
            // 
            // txtPatinetId
            // 
            txtPatinetId.BorderStyle = BorderStyle.FixedSingle;
            txtPatinetId.Dock = DockStyle.Bottom;
            txtPatinetId.Font = new Font("Segoe UI", 12F);
            txtPatinetId.Location = new Point(0, 46);
            txtPatinetId.Name = "txtPatinetId";
            txtPatinetId.Size = new Size(423, 29);
            txtPatinetId.TabIndex = 2;
            // 
            // lblPatient
            // 
            lblPatient.Dock = DockStyle.Top;
            lblPatient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPatient.ForeColor = Color.FromArgb(93, 122, 149);
            lblPatient.Location = new Point(0, 0);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(423, 22);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "ادخل معرف المريض";
            lblPatient.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlReasonField
            // 
            pnlReasonField.Controls.Add(txtReason);
            pnlReasonField.Controls.Add(lblReason);
            pnlReasonField.Dock = DockStyle.Fill;
            pnlReasonField.Location = new Point(10, 10);
            pnlReasonField.Margin = new Padding(10);
            pnlReasonField.Name = "pnlReasonField";
            pnlReasonField.Size = new Size(423, 75);
            pnlReasonField.TabIndex = 1;
            // 
            // txtReason
            // 
            txtReason.BorderStyle = BorderStyle.FixedSingle;
            txtReason.Dock = DockStyle.Bottom;
            txtReason.Font = new Font("Segoe UI", 12F);
            txtReason.Location = new Point(0, 28);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(423, 47);
            txtReason.TabIndex = 1;
            // 
            // lblReason
            // 
            lblReason.Dock = DockStyle.Top;
            lblReason.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReason.ForeColor = Color.FromArgb(93, 122, 149);
            lblReason.Location = new Point(0, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(423, 25);
            lblReason.TabIndex = 0;
            lblReason.Text = "سبب الزيارة";
            lblReason.TextAlign = ContentAlignment.TopRight;
            // 
            // tlpRow2Uniform
            // 
            tlpRow2Uniform.ColumnCount = 3;
            tlpRow2Uniform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpRow2Uniform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpRow2Uniform.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpRow2Uniform.Controls.Add(pnlDoctorField, 0, 0);
            tlpRow2Uniform.Controls.Add(pnlDateField, 1, 0);
            tlpRow2Uniform.Controls.Add(pnlStatusField, 2, 0);
            tlpRow2Uniform.Dock = DockStyle.Fill;
            tlpRow2Uniform.Location = new Point(0, 140);
            tlpRow2Uniform.Margin = new Padding(0);
            tlpRow2Uniform.Name = "tlpRow2Uniform";
            tlpRow2Uniform.RowCount = 1;
            tlpRow2Uniform.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRow2Uniform.Size = new Size(886, 95);
            tlpRow2Uniform.TabIndex = 2;
            // 
            // pnlDoctorField
            // 
            pnlDoctorField.Controls.Add(cmbDoctors);
            pnlDoctorField.Controls.Add(lblDoctor);
            pnlDoctorField.Dock = DockStyle.Fill;
            pnlDoctorField.Location = new Point(601, 10);
            pnlDoctorField.Margin = new Padding(10);
            pnlDoctorField.Name = "pnlDoctorField";
            pnlDoctorField.Size = new Size(275, 75);
            pnlDoctorField.TabIndex = 0;
            // 
            // cmbDoctors
            // 
            cmbDoctors.Dock = DockStyle.Bottom;
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.Font = new Font("Segoe UI", 12F);
            cmbDoctors.Location = new Point(0, 46);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(275, 29);
            cmbDoctors.TabIndex = 1;
            // 
            // lblDoctor
            // 
            lblDoctor.Dock = DockStyle.Top;
            lblDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoctor.ForeColor = Color.FromArgb(93, 122, 149);
            lblDoctor.Location = new Point(0, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(275, 25);
            lblDoctor.TabIndex = 0;
            lblDoctor.Text = "الطبيب";
            lblDoctor.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlDateField
            // 
            pnlDateField.Controls.Add(dtpAppointmentDate);
            pnlDateField.Controls.Add(lblDate);
            pnlDateField.Dock = DockStyle.Fill;
            pnlDateField.Location = new Point(306, 10);
            pnlDateField.Margin = new Padding(10);
            pnlDateField.Name = "pnlDateField";
            pnlDateField.Size = new Size(275, 75);
            pnlDateField.TabIndex = 1;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CalendarFont = new Font("Segoe UI", 11F);
            dtpAppointmentDate.Dock = DockStyle.Bottom;
            dtpAppointmentDate.Font = new Font("Segoe UI", 12F);
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(0, 46);
            dtpAppointmentDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpAppointmentDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(275, 29);
            dtpAppointmentDate.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Top;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(93, 122, 149);
            lblDate.Location = new Point(0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(275, 25);
            lblDate.TabIndex = 0;
            lblDate.Text = "تاريخ الموعد";
            lblDate.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlStatusField
            // 
            pnlStatusField.Controls.Add(cmbStatus);
            pnlStatusField.Controls.Add(lblStatus);
            pnlStatusField.Dock = DockStyle.Fill;
            pnlStatusField.Location = new Point(10, 10);
            pnlStatusField.Margin = new Padding(10);
            pnlStatusField.Name = "pnlStatusField";
            pnlStatusField.Size = new Size(276, 75);
            pnlStatusField.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Bottom;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.Items.AddRange(new object[] { "انتظار", "مؤكد", "مكتمل", "ملغي" });
            cmbStatus.Location = new Point(0, 46);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(276, 29);
            cmbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(93, 122, 149);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(276, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "الحالة";
            lblStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlNotesField
            // 
            pnlNotesField.Controls.Add(txtNotes);
            pnlNotesField.Controls.Add(lblNotes);
            pnlNotesField.Dock = DockStyle.Fill;
            pnlNotesField.Location = new Point(10, 245);
            pnlNotesField.Margin = new Padding(10, 10, 10, 0);
            pnlNotesField.Name = "pnlNotesField";
            pnlNotesField.Size = new Size(866, 125);
            pnlNotesField.TabIndex = 3;
            // 
            // txtNotes
            // 
            txtNotes.AcceptsReturn = true;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Dock = DockStyle.Bottom;
            txtNotes.Font = new Font("Segoe UI", 11F);
            txtNotes.Location = new Point(0, 45);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(866, 80);
            txtNotes.TabIndex = 1;
            // 
            // lblNotes
            // 
            lblNotes.Dock = DockStyle.Top;
            lblNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(93, 122, 149);
            lblNotes.Location = new Point(0, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(866, 25);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "ملاحظات إضافية";
            lblNotes.TextAlign = ContentAlignment.TopRight;
            // 
            // flpButtonsContainer
            // 
            flpButtonsContainer.Controls.Add(btnSave);
            flpButtonsContainer.Controls.Add(btnClear);
            flpButtonsContainer.Controls.Add(btnDelete);
            flpButtonsContainer.Dock = DockStyle.Fill;
            flpButtonsContainer.Location = new Point(10, 370);
            flpButtonsContainer.Margin = new Padding(0, 0, 10, 0);
            flpButtonsContainer.Name = "flpButtonsContainer";
            flpButtonsContainer.Size = new Size(876, 139);
            flpButtonsContainer.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(751, 30);
            btnSave.Margin = new Padding(5, 30, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(26, 37, 51);
            btnClear.Location = new Point(621, 30);
            btnClear.Margin = new Padding(5, 30, 5, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 42);
            btnClear.TabIndex = 1;
            btnClear.Text = "جديد";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(491, 30);
            btnDelete.Margin = new Padding(5, 30, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف موعد";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tabAppointmentHistory
            // 
            tabAppointmentHistory.BackColor = Color.FromArgb(244, 247, 250);
            tabAppointmentHistory.Controls.Add(pnlHistoryCard);
            tabAppointmentHistory.Font = new Font("Segoe UI", 10F);
            tabAppointmentHistory.Location = new Point(4, 44);
            tabAppointmentHistory.Name = "tabAppointmentHistory";
            tabAppointmentHistory.RightToLeft = RightToLeft.Yes;
            tabAppointmentHistory.Size = new Size(956, 593);
            tabAppointmentHistory.TabIndex = 1;
            tabAppointmentHistory.Text = "💳 سجل المواعيد";
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.White;
            pnlHistoryCard.Controls.Add(tlpHistoryLayout);
            pnlHistoryCard.Dock = DockStyle.Fill;
            pnlHistoryCard.Location = new Point(0, 0);
            pnlHistoryCard.Margin = new Padding(10);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Padding = new Padding(20);
            pnlHistoryCard.Size = new Size(956, 593);
            pnlHistoryCard.TabIndex = 0;
            // 
            // tlpHistoryLayout
            // 
            tlpHistoryLayout.ColumnCount = 1;
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Controls.Add(lblHistoryTitle, 0, 0);
            tlpHistoryLayout.Controls.Add(flpFilters, 0, 1);
            tlpHistoryLayout.Controls.Add(dgvAppointments, 0, 2);
            tlpHistoryLayout.Dock = DockStyle.Fill;
            tlpHistoryLayout.Location = new Point(20, 20);
            tlpHistoryLayout.Name = "tlpHistoryLayout";
            tlpHistoryLayout.RowCount = 3;
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Size = new Size(916, 553);
            tlpHistoryLayout.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblHistoryTitle.Location = new Point(780, 0);
            lblHistoryTitle.Margin = new Padding(0, 0, 0, 20);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(136, 30);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "عرض المواعيد";
            // 
            // flpFilters
            // 
            flpFilters.Controls.Add(lblSearch);
            flpFilters.Controls.Add(cmbSearchType);
            flpFilters.Controls.Add(txtSearchValue);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(0, 62);
            flpFilters.Margin = new Padding(0, 0, 0, 15);
            flpFilters.Name = "flpFilters";
            flpFilters.Size = new Size(916, 33);
            flpFilters.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(813, 6);
            lblSearch.Margin = new Padding(5, 6, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(98, 19);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "البحث بواسطة:";
            // 
            // cmbSearchType
            // 
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "المعرف", "الرقم الوطني" });
            cmbSearchType.Location = new Point(684, 3);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(121, 25);
            cmbSearchType.TabIndex = 3;
            // 
            // txtSearchValue
            // 
            txtSearchValue.BorderStyle = BorderStyle.FixedSingle;
            txtSearchValue.Font = new Font("Segoe UI", 10F);
            txtSearchValue.Location = new Point(476, 3);
            txtSearchValue.Margin = new Padding(5, 3, 10, 3);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(200, 25);
            txtSearchValue.TabIndex = 2;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 37, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 37, 51);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.ColumnHeadersHeight = 40;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { colAppointmentId, PatientNationalNumber, colPatientName, colDoctorName, colAppointmentDate, colStatusName });
            dgvAppointments.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = Color.FromArgb(243, 244, 246);
            dgvAppointments.Location = new Point(3, 113);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(910, 437);
            dgvAppointments.TabIndex = 2;
            // 
            // colAppointmentId
            // 
            colAppointmentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colAppointmentId.HeaderText = "رقم الموعد";
            colAppointmentId.Name = "colAppointmentId";
            colAppointmentId.ReadOnly = true;
            colAppointmentId.Width = 87;
            // 
            // PatientNationalNumber
            // 
            PatientNationalNumber.HeaderText = "رقم المريض الوطني";
            PatientNationalNumber.Name = "PatientNationalNumber";
            PatientNationalNumber.ReadOnly = true;
            // 
            // colPatientName
            // 
            colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPatientName.FillWeight = 40F;
            colPatientName.HeaderText = "المريض";
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            // 
            // colDoctorName
            // 
            colDoctorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDoctorName.FillWeight = 40F;
            colDoctorName.HeaderText = "الطبيب";
            colDoctorName.Name = "colDoctorName";
            colDoctorName.ReadOnly = true;
            // 
            // colAppointmentDate
            // 
            colAppointmentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAppointmentDate.HeaderText = "التاريخ";
            colAppointmentDate.Name = "colAppointmentDate";
            colAppointmentDate.ReadOnly = true;
            colAppointmentDate.Width = 150;
            // 
            // colStatusName
            // 
            colStatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatusName.HeaderText = "الحالة";
            colStatusName.Name = "colStatusName";
            colStatusName.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI", 10F);
            contextMenuStrip1.ForeColor = Color.FromArgb(17, 24, 39);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowInfoMenuItem, UpdateAppointmentMenuItem, DeleteAppointmentMenuItem, AddNewAppointmentMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(210, 122);
            // 
            // ShowInfoMenuItem
            // 
            ShowInfoMenuItem.Name = "ShowInfoMenuItem";
            ShowInfoMenuItem.Size = new Size(209, 24);
            ShowInfoMenuItem.Text = "  عرض تفاصيل الموعد";
            ShowInfoMenuItem.Click += ShowInfoMenuItem_Click;
            // 
            // UpdateAppointmentMenuItem
            // 
            UpdateAppointmentMenuItem.Name = "UpdateAppointmentMenuItem";
            UpdateAppointmentMenuItem.Size = new Size(209, 24);
            UpdateAppointmentMenuItem.Text = "  تعديل بيانات الموعد";
            // 
            // DeleteAppointmentMenuItem
            // 
            DeleteAppointmentMenuItem.ForeColor = Color.FromArgb(220, 38, 38);
            DeleteAppointmentMenuItem.Name = "DeleteAppointmentMenuItem";
            DeleteAppointmentMenuItem.Size = new Size(209, 24);
            DeleteAppointmentMenuItem.Text = "  إلغاء / حذف الموعد";
            DeleteAppointmentMenuItem.Click += DeleteAppointmentMenuItem_Click;
            // 
            // AddNewAppointmentMenuItem
            // 
            AddNewAppointmentMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddNewAppointmentMenuItem.Name = "AddNewAppointmentMenuItem";
            AddNewAppointmentMenuItem.Size = new Size(209, 24);
            AddNewAppointmentMenuItem.Text = "  حجز موعد جديد...";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAppointments
            // 
            ClientSize = new Size(984, 661);
            Controls.Add(mainGridPanel);
            Name = "frmAppointments";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += frmAppointments_Load;
            mainGridPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabBookAppointment.ResumeLayout(false);
            tlpBookRoot.ResumeLayout(false);
            pnlFormCard.ResumeLayout(false);
            tlpFormLayout.ResumeLayout(false);
            tlpFormLayout.PerformLayout();
            tlpRow1Uniform.ResumeLayout(false);
            pnlPatientField.ResumeLayout(false);
            pnlPatientField.PerformLayout();
            pnlReasonField.ResumeLayout(false);
            pnlReasonField.PerformLayout();
            tlpRow2Uniform.ResumeLayout(false);
            pnlDoctorField.ResumeLayout(false);
            pnlDateField.ResumeLayout(false);
            pnlStatusField.ResumeLayout(false);
            pnlNotesField.ResumeLayout(false);
            pnlNotesField.PerformLayout();
            flpButtonsContainer.ResumeLayout(false);
            tabAppointmentHistory.ResumeLayout(false);
            pnlHistoryCard.ResumeLayout(false);
            tlpHistoryLayout.ResumeLayout(false);
            tlpHistoryLayout.PerformLayout();
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            ((ISupportInitialize)dgvAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainGridPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBookAppointment;
        private System.Windows.Forms.TableLayoutPanel tlpBookRoot;
        private System.Windows.Forms.Panel pnlTopBorder;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.TableLayoutPanel tlpFormLayout;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TableLayoutPanel tlpRow1Uniform;
        private System.Windows.Forms.Panel pnlReasonField;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TableLayoutPanel tlpRow2Uniform;
        private System.Windows.Forms.Panel pnlDoctorField;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.Panel pnlDateField;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Panel pnlStatusField;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlNotesField;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.FlowLayoutPanel flpButtonsContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabAppointmentHistory;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.TableLayoutPanel tlpHistoryLayout;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.FlowLayoutPanel flpFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Panel pnlPatientField;
        private ErrorProvider errorProvider1;
        private ComboBox cmbSearchType;
        private DataGridViewTextBoxColumn colPatientNationalNumber;
        private DataGridViewTextBoxColumn colAppointmentId;
        private DataGridViewTextBoxColumn PatientNationalNumber;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn colDoctorName;
        private DataGridViewTextBoxColumn colAppointmentDate;
        private DataGridViewTextBoxColumn colStatusName;
        private TextBox txtPatinetId;
        private Label lblPatient;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowInfoMenuItem;
        private ToolStripMenuItem DeleteAppointmentMenuItem;
        private ToolStripMenuItem UpdateAppointmentMenuItem;
        private ToolStripMenuItem AddNewAppointmentMenuItem;
    }
}