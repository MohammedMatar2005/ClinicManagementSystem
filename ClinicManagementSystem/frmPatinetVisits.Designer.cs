using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmPatinetVisits : Form
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMainBackground = new Panel();
            tabControlVisits = new TabControl();
            tabNewVisit = new TabPage();
            scrollContainer = new Panel();
            tlpNewVisitMain = new TableLayoutPanel();
            lblVisitHeader = new Label();
            tlpColumnsContainer = new TableLayoutPanel();
            pnlGeneralDataCard = new Panel();
            tlpGeneralData = new TableLayoutPanel();
            lblGeneralDataTitle = new Label();
            tlpPatientDoctorGrid = new TableLayoutPanel();
            pnlPatientGroup = new Panel();
            lblPatient = new Label();
            cmbPatient = new ComboBox();
            pnlDoctorGroup = new Panel();
            lblDoctor = new Label();
            cmbDoctor = new ComboBox();
            pnlSeparator = new Panel();
            lblSymptoms = new Label();
            txtSymptoms = new TextBox();
            lblDiagnosis = new Label();
            txtDiagnosis = new TextBox();
            lblTreatmentPlan = new Label();
            txtTreatmentPlan = new TextBox();
            tlpRightSideCards = new TableLayoutPanel();
            pnlVitalsCard = new Panel();
            tlpVitals = new TableLayoutPanel();
            flpVitalsHeader = new FlowLayoutPanel();
            lblVitalsIcon = new Label();
            lblVitalsTitle = new Label();
            pnlBPGroup = new Panel();
            lblBloodPressure = new Label();
            txtBloodPressure = new TextBox();
            tlpTempPulseGrid = new TableLayoutPanel();
            pnlTempGroup = new Panel();
            lblTemperature = new Label();
            txtTemperature = new TextBox();
            pnlPulseGroup = new Panel();
            lblHeartRate = new Label();
            txtHeartRate = new TextBox();
            tlpWeightHeightGrid = new TableLayoutPanel();
            pnlWeightGroup = new Panel();
            lblWeight = new Label();
            txtWeight = new TextBox();
            pnlHeightGroup = new Panel();
            lblHeight = new Label();
            txtHeight = new TextBox();
            pnlNotesCard = new Panel();
            tlpNotes = new TableLayoutPanel();
            lblNotes = new Label();
            txtNotes = new TextBox();
            flpActionButtons = new FlowLayoutPanel();
            btnSaveVisit = new Button();
            btnClearFields = new Button();
            tabVisitHistory = new TabPage();
            pnlHistoryCard = new Panel();
            tlpHistoryMain = new TableLayoutPanel();
            tlpHistoryHeader = new TableLayoutPanel();
            lblHistoryTitle = new Label();
            txtSearchPatient = new TextBox();
            dgvVisitsHistory = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colPatient = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            colDiagnosis = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewImageColumn();
            pnlMainBackground.SuspendLayout();
            tabControlVisits.SuspendLayout();
            tabNewVisit.SuspendLayout();
            scrollContainer.SuspendLayout();
            tlpNewVisitMain.SuspendLayout();
            tlpColumnsContainer.SuspendLayout();
            pnlGeneralDataCard.SuspendLayout();
            tlpGeneralData.SuspendLayout();
            tlpPatientDoctorGrid.SuspendLayout();
            pnlPatientGroup.SuspendLayout();
            pnlDoctorGroup.SuspendLayout();
            tlpRightSideCards.SuspendLayout();
            pnlVitalsCard.SuspendLayout();
            tlpVitals.SuspendLayout();
            flpVitalsHeader.SuspendLayout();
            pnlBPGroup.SuspendLayout();
            tlpTempPulseGrid.SuspendLayout();
            pnlTempGroup.SuspendLayout();
            pnlPulseGroup.SuspendLayout();
            tlpWeightHeightGrid.SuspendLayout();
            pnlWeightGroup.SuspendLayout();
            pnlHeightGroup.SuspendLayout();
            pnlNotesCard.SuspendLayout();
            tlpNotes.SuspendLayout();
            flpActionButtons.SuspendLayout();
            tabVisitHistory.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            tlpHistoryMain.SuspendLayout();
            tlpHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitsHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlMainBackground
            // 
            pnlMainBackground.BackColor = Color.FromArgb(244, 247, 250);
            pnlMainBackground.Controls.Add(tabControlVisits);
            pnlMainBackground.Dock = DockStyle.Fill;
            pnlMainBackground.Location = new Point(0, 0);
            pnlMainBackground.Name = "pnlMainBackground";
            pnlMainBackground.Padding = new Padding(10);
            pnlMainBackground.Size = new Size(1100, 749);
            pnlMainBackground.TabIndex = 0;
            // 
            // tabControlVisits
            // 
            tabControlVisits.Controls.Add(tabNewVisit);
            tabControlVisits.Controls.Add(tabVisitHistory);
            tabControlVisits.Dock = DockStyle.Fill;
            tabControlVisits.Font = new Font("Segoe UI", 11.25F);
            tabControlVisits.Location = new Point(10, 10);
            tabControlVisits.Name = "tabControlVisits";
            tabControlVisits.Padding = new Point(20, 10);
            tabControlVisits.SelectedIndex = 0;
            tabControlVisits.Size = new Size(1080, 729);
            tabControlVisits.TabIndex = 0;
            // 
            // tabNewVisit
            // 
            tabNewVisit.BackColor = Color.Transparent;
            tabNewVisit.Controls.Add(scrollContainer);
            tabNewVisit.Location = new Point(4, 43);
            tabNewVisit.Name = "tabNewVisit";
            tabNewVisit.Size = new Size(1072, 682);
            tabNewVisit.TabIndex = 0;
            tabNewVisit.Text = "تسجيل زيارة جديدة";
            // 
            // scrollContainer
            // 
            scrollContainer.AutoScroll = true;
            scrollContainer.Controls.Add(tlpNewVisitMain);
            scrollContainer.Dock = DockStyle.Fill;
            scrollContainer.Location = new Point(0, 0);
            scrollContainer.Name = "scrollContainer";
            scrollContainer.Size = new Size(1072, 682);
            scrollContainer.TabIndex = 0;
            // 
            // tlpNewVisitMain
            // 
            tlpNewVisitMain.ColumnCount = 1;
            tlpNewVisitMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNewVisitMain.Controls.Add(lblVisitHeader, 0, 0);
            tlpNewVisitMain.Controls.Add(tlpColumnsContainer, 0, 1);
            tlpNewVisitMain.Controls.Add(flpActionButtons, 0, 2);
            tlpNewVisitMain.Dock = DockStyle.Top;
            tlpNewVisitMain.Location = new Point(0, 0);
            tlpNewVisitMain.Name = "tlpNewVisitMain";
            tlpNewVisitMain.Padding = new Padding(10);
            tlpNewVisitMain.RowCount = 3;
            tlpNewVisitMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpNewVisitMain.RowStyles.Add(new RowStyle());
            tlpNewVisitMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpNewVisitMain.Size = new Size(1055, 700);
            tlpNewVisitMain.TabIndex = 0;
            // 
            // lblVisitHeader
            // 
            lblVisitHeader.AutoSize = true;
            lblVisitHeader.Dock = DockStyle.Fill;
            lblVisitHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblVisitHeader.ForeColor = Color.FromArgb(26, 37, 51);
            lblVisitHeader.Location = new Point(10, 10);
            lblVisitHeader.Margin = new Padding(10, 0, 0, 15);
            lblVisitHeader.Name = "lblVisitHeader";
            lblVisitHeader.Size = new Size(1025, 35);
            lblVisitHeader.TabIndex = 0;
            lblVisitHeader.Text = "بيانات الزيارة الطبية";
            lblVisitHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpColumnsContainer
            // 
            tlpColumnsContainer.ColumnCount = 2;
            tlpColumnsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66666F));
            tlpColumnsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpColumnsContainer.Controls.Add(pnlGeneralDataCard, 0, 0);
            tlpColumnsContainer.Controls.Add(tlpRightSideCards, 1, 0);
            tlpColumnsContainer.Dock = DockStyle.Fill;
            tlpColumnsContainer.Location = new Point(13, 63);
            tlpColumnsContainer.Name = "tlpColumnsContainer";
            tlpColumnsContainer.RowCount = 1;
            tlpColumnsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpColumnsContainer.Size = new Size(1029, 550);
            tlpColumnsContainer.TabIndex = 1;
            // 
            // pnlGeneralDataCard
            // 
            pnlGeneralDataCard.BackColor = Color.White;
            pnlGeneralDataCard.Controls.Add(tlpGeneralData);
            pnlGeneralDataCard.Dock = DockStyle.Fill;
            pnlGeneralDataCard.Location = new Point(353, 10);
            pnlGeneralDataCard.Margin = new Padding(10);
            pnlGeneralDataCard.Name = "pnlGeneralDataCard";
            pnlGeneralDataCard.Padding = new Padding(20);
            pnlGeneralDataCard.Size = new Size(666, 530);
            pnlGeneralDataCard.TabIndex = 0;
            // 
            // tlpGeneralData
            // 
            tlpGeneralData.ColumnCount = 1;
            tlpGeneralData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGeneralData.Controls.Add(lblGeneralDataTitle, 0, 0);
            tlpGeneralData.Controls.Add(tlpPatientDoctorGrid, 0, 1);
            tlpGeneralData.Controls.Add(pnlSeparator, 0, 2);
            tlpGeneralData.Controls.Add(lblSymptoms, 0, 3);
            tlpGeneralData.Controls.Add(txtSymptoms, 0, 4);
            tlpGeneralData.Controls.Add(lblDiagnosis, 0, 5);
            tlpGeneralData.Controls.Add(txtDiagnosis, 0, 6);
            tlpGeneralData.Controls.Add(lblTreatmentPlan, 0, 7);
            tlpGeneralData.Controls.Add(txtTreatmentPlan, 0, 8);
            tlpGeneralData.Dock = DockStyle.Fill;
            tlpGeneralData.Location = new Point(20, 20);
            tlpGeneralData.Name = "tlpGeneralData";
            tlpGeneralData.RowCount = 9;
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpGeneralData.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpGeneralData.Size = new Size(626, 490);
            tlpGeneralData.TabIndex = 0;
            // 
            // lblGeneralDataTitle
            // 
            lblGeneralDataTitle.AutoSize = true;
            lblGeneralDataTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblGeneralDataTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblGeneralDataTitle.Location = new Point(473, 0);
            lblGeneralDataTitle.Margin = new Padding(0, 0, 0, 15);
            lblGeneralDataTitle.Name = "lblGeneralDataTitle";
            lblGeneralDataTitle.Size = new Size(153, 20);
            lblGeneralDataTitle.TabIndex = 0;
            lblGeneralDataTitle.Text = "البيانات العامة";
            // 
            // tlpPatientDoctorGrid
            // 
            tlpPatientDoctorGrid.ColumnCount = 2;
            tlpPatientDoctorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPatientDoctorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPatientDoctorGrid.Controls.Add(pnlPatientGroup, 0, 0);
            tlpPatientDoctorGrid.Controls.Add(pnlDoctorGroup, 1, 0);
            tlpPatientDoctorGrid.Dock = DockStyle.Fill;
            tlpPatientDoctorGrid.Location = new Point(0, 35);
            tlpPatientDoctorGrid.Margin = new Padding(0);
            tlpPatientDoctorGrid.Name = "tlpPatientDoctorGrid";
            tlpPatientDoctorGrid.RowCount = 1;
            tlpPatientDoctorGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPatientDoctorGrid.Size = new Size(626, 70);
            tlpPatientDoctorGrid.TabIndex = 1;
            // 
            // pnlPatientGroup
            // 
            pnlPatientGroup.Controls.Add(lblPatient);
            pnlPatientGroup.Controls.Add(cmbPatient);
            pnlPatientGroup.Dock = DockStyle.Fill;
            pnlPatientGroup.Location = new Point(318, 5);
            pnlPatientGroup.Margin = new Padding(5);
            pnlPatientGroup.Name = "pnlPatientGroup";
            pnlPatientGroup.Size = new Size(303, 60);
            pnlPatientGroup.TabIndex = 0;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 12F);
            lblPatient.ForeColor = Color.FromArgb(143, 163, 184);
            lblPatient.Location = new Point(0, 0);
            lblPatient.Margin = new Padding(0, 0, 0, 5);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(62, 21);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "المريض";
            // 
            // cmbPatient
            // 
            cmbPatient.Dock = DockStyle.Bottom;
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.Location = new Point(0, 32);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(303, 28);
            cmbPatient.TabIndex = 1;
            // 
            // pnlDoctorGroup
            // 
            pnlDoctorGroup.Controls.Add(lblDoctor);
            pnlDoctorGroup.Controls.Add(cmbDoctor);
            pnlDoctorGroup.Dock = DockStyle.Fill;
            pnlDoctorGroup.Location = new Point(5, 5);
            pnlDoctorGroup.Margin = new Padding(5);
            pnlDoctorGroup.Name = "pnlDoctorGroup";
            pnlDoctorGroup.Size = new Size(303, 60);
            pnlDoctorGroup.TabIndex = 1;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 12F);
            lblDoctor.ForeColor = Color.FromArgb(143, 163, 184);
            lblDoctor.Location = new Point(0, 0);
            lblDoctor.Margin = new Padding(0, 0, 0, 5);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(106, 21);
            lblDoctor.TabIndex = 0;
            lblDoctor.Text = "الطبيب المعالج";
            // 
            // cmbDoctor
            // 
            cmbDoctor.Dock = DockStyle.Bottom;
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.Location = new Point(0, 32);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(303, 28);
            cmbDoctor.TabIndex = 1;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(240, 240, 240);
            pnlSeparator.Dock = DockStyle.Fill;
            pnlSeparator.Location = new Point(0, 115);
            pnlSeparator.Margin = new Padding(0, 10, 0, 9);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(626, 1);
            pnlSeparator.TabIndex = 2;
            // 
            // lblSymptoms
            // 
            lblSymptoms.AutoSize = true;
            lblSymptoms.Font = new Font("Segoe UI", 12F);
            lblSymptoms.ForeColor = Color.FromArgb(143, 163, 184);
            lblSymptoms.Location = new Point(469, 125);
            lblSymptoms.Margin = new Padding(5, 0, 0, 5);
            lblSymptoms.Name = "lblSymptoms";
            lblSymptoms.Size = new Size(152, 20);
            lblSymptoms.TabIndex = 3;
            lblSymptoms.Text = "الأعراض (Symptoms)";
            // 
            // txtSymptoms
            // 
            txtSymptoms.BackColor = Color.FromArgb(249, 250, 251);
            txtSymptoms.BorderStyle = BorderStyle.FixedSingle;
            txtSymptoms.Dock = DockStyle.Fill;
            txtSymptoms.Location = new Point(3, 153);
            txtSymptoms.Multiline = true;
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.ScrollBars = ScrollBars.Vertical;
            txtSymptoms.Size = new Size(620, 79);
            txtSymptoms.TabIndex = 4;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI", 12F);
            lblDiagnosis.ForeColor = Color.FromArgb(143, 163, 184);
            lblDiagnosis.Location = new Point(467, 235);
            lblDiagnosis.Margin = new Padding(5, 0, 0, 5);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(154, 20);
            lblDiagnosis.TabIndex = 5;
            lblDiagnosis.Text = "التشخيص (Diagnosis)";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = Color.FromArgb(249, 250, 251);
            txtDiagnosis.BorderStyle = BorderStyle.FixedSingle;
            txtDiagnosis.Dock = DockStyle.Fill;
            txtDiagnosis.Location = new Point(3, 263);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(620, 79);
            txtDiagnosis.TabIndex = 6;
            // 
            // lblTreatmentPlan
            // 
            lblTreatmentPlan.AutoSize = true;
            lblTreatmentPlan.Font = new Font("Segoe UI", 12F);
            lblTreatmentPlan.ForeColor = Color.FromArgb(143, 163, 184);
            lblTreatmentPlan.Location = new Point(423, 345);
            lblTreatmentPlan.Margin = new Padding(5, 0, 0, 5);
            lblTreatmentPlan.Name = "lblTreatmentPlan";
            lblTreatmentPlan.Size = new Size(198, 20);
            lblTreatmentPlan.TabIndex = 7;
            lblTreatmentPlan.Text = "خطة العلاج (Treatment Plan)";
            // 
            // txtTreatmentPlan
            // 
            txtTreatmentPlan.BackColor = Color.FromArgb(249, 250, 251);
            txtTreatmentPlan.BorderStyle = BorderStyle.FixedSingle;
            txtTreatmentPlan.Dock = DockStyle.Fill;
            txtTreatmentPlan.Location = new Point(3, 373);
            txtTreatmentPlan.Multiline = true;
            txtTreatmentPlan.Name = "txtTreatmentPlan";
            txtTreatmentPlan.ScrollBars = ScrollBars.Vertical;
            txtTreatmentPlan.Size = new Size(620, 114);
            txtTreatmentPlan.TabIndex = 8;
            // 
            // tlpRightSideCards
            // 
            tlpRightSideCards.ColumnCount = 1;
            tlpRightSideCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRightSideCards.Controls.Add(pnlVitalsCard, 0, 0);
            tlpRightSideCards.Controls.Add(pnlNotesCard, 0, 1);
            tlpRightSideCards.Dock = DockStyle.Fill;
            tlpRightSideCards.Location = new Point(3, 3);
            tlpRightSideCards.Name = "tlpRightSideCards";
            tlpRightSideCards.RowCount = 2;
            tlpRightSideCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 330F));
            tlpRightSideCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRightSideCards.Size = new Size(337, 544);
            tlpRightSideCards.TabIndex = 1;
            // 
            // pnlVitalsCard
            // 
            pnlVitalsCard.BackColor = Color.FromArgb(232, 245, 233);
            pnlVitalsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlVitalsCard.Controls.Add(tlpVitals);
            pnlVitalsCard.Dock = DockStyle.Fill;
            pnlVitalsCard.Location = new Point(10, 10);
            pnlVitalsCard.Margin = new Padding(10);
            pnlVitalsCard.Name = "pnlVitalsCard";
            pnlVitalsCard.Padding = new Padding(20);
            pnlVitalsCard.Size = new Size(317, 310);
            pnlVitalsCard.TabIndex = 0;
            // 
            // tlpVitals
            // 
            tlpVitals.ColumnCount = 1;
            tlpVitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVitals.Controls.Add(flpVitalsHeader, 0, 0);
            tlpVitals.Controls.Add(pnlBPGroup, 0, 1);
            tlpVitals.Controls.Add(tlpTempPulseGrid, 0, 2);
            tlpVitals.Controls.Add(tlpWeightHeightGrid, 0, 3);
            tlpVitals.Dock = DockStyle.Fill;
            tlpVitals.Location = new Point(20, 20);
            tlpVitals.Name = "tlpVitals";
            tlpVitals.RowCount = 4;
            tlpVitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpVitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpVitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpVitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpVitals.Size = new Size(275, 268);
            tlpVitals.TabIndex = 0;
            // 
            // flpVitalsHeader
            // 
            flpVitalsHeader.Controls.Add(lblVitalsIcon);
            flpVitalsHeader.Controls.Add(lblVitalsTitle);
            flpVitalsHeader.Dock = DockStyle.Fill;
            flpVitalsHeader.Location = new Point(0, 0);
            flpVitalsHeader.Margin = new Padding(0, 0, 0, 15);
            flpVitalsHeader.Name = "flpVitalsHeader";
            flpVitalsHeader.Size = new Size(275, 20);
            flpVitalsHeader.TabIndex = 0;
            // 
            // lblVitalsIcon
            // 
            lblVitalsIcon.AutoSize = true;
            lblVitalsIcon.Font = new Font("Segoe UI", 20F);
            lblVitalsIcon.Location = new Point(221, 0);
            lblVitalsIcon.Margin = new Padding(0, 0, 10, 0);
            lblVitalsIcon.Name = "lblVitalsIcon";
            lblVitalsIcon.Size = new Size(54, 37);
            lblVitalsIcon.TabIndex = 0;
            lblVitalsIcon.Text = "\U0001fa7a";
            // 
            // lblVitalsTitle
            // 
            lblVitalsTitle.AutoSize = true;
            lblVitalsTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblVitalsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblVitalsTitle.Location = new Point(33, 0);
            lblVitalsTitle.Name = "lblVitalsTitle";
            lblVitalsTitle.Size = new Size(175, 32);
            lblVitalsTitle.TabIndex = 1;
            lblVitalsTitle.Text = "العلامات الحيوية";
            // 
            // pnlBPGroup
            // 
            pnlBPGroup.Controls.Add(lblBloodPressure);
            pnlBPGroup.Controls.Add(txtBloodPressure);
            pnlBPGroup.Dock = DockStyle.Fill;
            pnlBPGroup.Location = new Point(0, 40);
            pnlBPGroup.Margin = new Padding(0, 5, 0, 5);
            pnlBPGroup.Name = "pnlBPGroup";
            pnlBPGroup.Size = new Size(275, 55);
            pnlBPGroup.TabIndex = 1;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Font = new Font("Segoe UI", 11F);
            lblBloodPressure.ForeColor = Color.FromArgb(93, 122, 149);
            lblBloodPressure.Location = new Point(0, 0);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new Size(76, 20);
            lblBloodPressure.TabIndex = 0;
            lblBloodPressure.Text = "ضغط الدم";
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.BorderStyle = BorderStyle.FixedSingle;
            txtBloodPressure.Dock = DockStyle.Bottom;
            txtBloodPressure.Location = new Point(0, 28);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new Size(275, 27);
            txtBloodPressure.TabIndex = 1;
            // 
            // tlpTempPulseGrid
            // 
            tlpTempPulseGrid.ColumnCount = 2;
            tlpTempPulseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTempPulseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTempPulseGrid.Controls.Add(pnlTempGroup, 0, 0);
            tlpTempPulseGrid.Controls.Add(pnlPulseGroup, 1, 0);
            tlpTempPulseGrid.Dock = DockStyle.Fill;
            tlpTempPulseGrid.Location = new Point(0, 100);
            tlpTempPulseGrid.Margin = new Padding(0);
            tlpTempPulseGrid.Name = "tlpTempPulseGrid";
            tlpTempPulseGrid.RowCount = 1;
            tlpTempPulseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTempPulseGrid.Size = new Size(275, 65);
            tlpTempPulseGrid.TabIndex = 2;
            // 
            // pnlTempGroup
            // 
            pnlTempGroup.Controls.Add(lblTemperature);
            pnlTempGroup.Controls.Add(txtTemperature);
            pnlTempGroup.Dock = DockStyle.Fill;
            pnlTempGroup.Location = new Point(143, 5);
            pnlTempGroup.Margin = new Padding(0, 5, 5, 5);
            pnlTempGroup.Name = "pnlTempGroup";
            pnlTempGroup.Size = new Size(132, 55);
            pnlTempGroup.TabIndex = 0;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 11F);
            lblTemperature.ForeColor = Color.FromArgb(93, 122, 149);
            lblTemperature.Location = new Point(0, 0);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(78, 20);
            lblTemperature.TabIndex = 0;
            lblTemperature.Text = "الحرارة (C°)";
            // 
            // txtTemperature
            // 
            txtTemperature.BorderStyle = BorderStyle.FixedSingle;
            txtTemperature.Dock = DockStyle.Bottom;
            txtTemperature.Location = new Point(0, 28);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(132, 27);
            txtTemperature.TabIndex = 1;
            // 
            // pnlPulseGroup
            // 
            pnlPulseGroup.Controls.Add(lblHeartRate);
            pnlPulseGroup.Controls.Add(txtHeartRate);
            pnlPulseGroup.Dock = DockStyle.Fill;
            pnlPulseGroup.Location = new Point(0, 5);
            pnlPulseGroup.Margin = new Padding(5, 5, 0, 5);
            pnlPulseGroup.Name = "pnlPulseGroup";
            pnlPulseGroup.Size = new Size(133, 55);
            pnlPulseGroup.TabIndex = 1;
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Font = new Font("Segoe UI", 11F);
            lblHeartRate.ForeColor = Color.FromArgb(93, 122, 149);
            lblHeartRate.Location = new Point(0, 0);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(48, 20);
            lblHeartRate.TabIndex = 0;
            lblHeartRate.Text = "النبض";
            // 
            // txtHeartRate
            // 
            txtHeartRate.BorderStyle = BorderStyle.FixedSingle;
            txtHeartRate.Dock = DockStyle.Bottom;
            txtHeartRate.Location = new Point(0, 28);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.Size = new Size(133, 27);
            txtHeartRate.TabIndex = 1;
            // 
            // tlpWeightHeightGrid
            // 
            tlpWeightHeightGrid.ColumnCount = 2;
            tlpWeightHeightGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpWeightHeightGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpWeightHeightGrid.Controls.Add(pnlWeightGroup, 0, 0);
            tlpWeightHeightGrid.Controls.Add(pnlHeightGroup, 1, 0);
            tlpWeightHeightGrid.Dock = DockStyle.Fill;
            tlpWeightHeightGrid.Location = new Point(0, 170);
            tlpWeightHeightGrid.Margin = new Padding(0, 5, 0, 5);
            tlpWeightHeightGrid.Name = "tlpWeightHeightGrid";
            tlpWeightHeightGrid.RowCount = 1;
            tlpWeightHeightGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpWeightHeightGrid.Size = new Size(275, 93);
            tlpWeightHeightGrid.TabIndex = 3;
            // 
            // pnlWeightGroup
            // 
            pnlWeightGroup.Controls.Add(lblWeight);
            pnlWeightGroup.Controls.Add(txtWeight);
            pnlWeightGroup.Dock = DockStyle.Fill;
            pnlWeightGroup.Location = new Point(143, 0);
            pnlWeightGroup.Margin = new Padding(0, 0, 5, 0);
            pnlWeightGroup.Name = "pnlWeightGroup";
            pnlWeightGroup.Size = new Size(132, 93);
            pnlWeightGroup.TabIndex = 0;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 11F);
            lblWeight.ForeColor = Color.FromArgb(93, 122, 149);
            lblWeight.Location = new Point(0, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(72, 20);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "الوزن (kg)";
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Dock = DockStyle.Bottom;
            txtWeight.Location = new Point(0, 66);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(132, 27);
            txtWeight.TabIndex = 1;
            // 
            // pnlHeightGroup
            // 
            pnlHeightGroup.Controls.Add(lblHeight);
            pnlHeightGroup.Controls.Add(txtHeight);
            pnlHeightGroup.Dock = DockStyle.Fill;
            pnlHeightGroup.Location = new Point(0, 0);
            pnlHeightGroup.Margin = new Padding(5, 0, 0, 0);
            pnlHeightGroup.Name = "pnlHeightGroup";
            pnlHeightGroup.Size = new Size(133, 93);
            pnlHeightGroup.TabIndex = 1;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 11F);
            lblHeight.ForeColor = Color.FromArgb(93, 122, 149);
            lblHeight.Location = new Point(0, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(83, 20);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "الطول (cm)";
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Dock = DockStyle.Bottom;
            txtHeight.Location = new Point(0, 66);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(133, 27);
            txtHeight.TabIndex = 1;
            // 
            // pnlNotesCard
            // 
            pnlNotesCard.BackColor = Color.White;
            pnlNotesCard.Controls.Add(tlpNotes);
            pnlNotesCard.Dock = DockStyle.Fill;
            pnlNotesCard.Location = new Point(10, 340);
            pnlNotesCard.Margin = new Padding(10);
            pnlNotesCard.Name = "pnlNotesCard";
            pnlNotesCard.Padding = new Padding(20);
            pnlNotesCard.Size = new Size(317, 194);
            pnlNotesCard.TabIndex = 1;
            // 
            // tlpNotes
            // 
            tlpNotes.ColumnCount = 1;
            tlpNotes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNotes.Controls.Add(lblNotes, 0, 0);
            tlpNotes.Controls.Add(txtNotes, 0, 1);
            tlpNotes.Dock = DockStyle.Fill;
            tlpNotes.Location = new Point(20, 20);
            tlpNotes.Name = "tlpNotes";
            tlpNotes.RowCount = 2;
            tlpNotes.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpNotes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNotes.Size = new Size(277, 154);
            tlpNotes.TabIndex = 0;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 12F);
            lblNotes.ForeColor = Color.FromArgb(143, 163, 184);
            lblNotes.Location = new Point(159, 0);
            lblNotes.Margin = new Padding(0, 0, 0, 5);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(118, 20);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "ملاحظات إضافية";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(249, 250, 251);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(3, 28);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(271, 123);
            txtNotes.TabIndex = 1;
            // 
            // flpActionButtons
            // 
            flpActionButtons.Controls.Add(btnSaveVisit);
            flpActionButtons.Controls.Add(btnClearFields);
            flpActionButtons.Dock = DockStyle.Fill;
            flpActionButtons.Location = new Point(20, 626);
            flpActionButtons.Margin = new Padding(10);
            flpActionButtons.Name = "flpActionButtons";
            flpActionButtons.Size = new Size(1015, 54);
            flpActionButtons.TabIndex = 2;
            // 
            // btnSaveVisit
            // 
            btnSaveVisit.BackColor = Color.FromArgb(39, 174, 96);
            btnSaveVisit.FlatStyle = FlatStyle.Flat;
            btnSaveVisit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSaveVisit.ForeColor = Color.White;
            btnSaveVisit.Location = new Point(835, 0);
            btnSaveVisit.Margin = new Padding(0, 0, 15, 0);
            btnSaveVisit.Name = "btnSaveVisit";
            btnSaveVisit.Size = new Size(180, 45);
            btnSaveVisit.TabIndex = 0;
            btnSaveVisit.Text = "💾 حفظ الزيارة";
            btnSaveVisit.UseVisualStyleBackColor = false;
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.FromArgb(127, 140, 141);
            btnClearFields.FlatStyle = FlatStyle.Flat;
            btnClearFields.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnClearFields.ForeColor = Color.White;
            btnClearFields.Location = new Point(667, 3);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(150, 45);
            btnClearFields.TabIndex = 1;
            btnClearFields.Text = "🔄 مسح الحقول";
            btnClearFields.UseVisualStyleBackColor = false;
            // 
            // tabVisitHistory
            // 
            tabVisitHistory.BackColor = Color.Transparent;
            tabVisitHistory.Controls.Add(pnlHistoryCard);
            tabVisitHistory.Location = new Point(4, 43);
            tabVisitHistory.Name = "tabVisitHistory";
            tabVisitHistory.Size = new Size(1072, 783);
            tabVisitHistory.TabIndex = 1;
            tabVisitHistory.Text = "سجل الزيارات السابقة";
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.White;
            pnlHistoryCard.Controls.Add(tlpHistoryMain);
            pnlHistoryCard.Dock = DockStyle.Fill;
            pnlHistoryCard.Location = new Point(0, 0);
            pnlHistoryCard.Margin = new Padding(10);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Padding = new Padding(20);
            pnlHistoryCard.Size = new Size(1072, 783);
            pnlHistoryCard.TabIndex = 0;
            // 
            // tlpHistoryMain
            // 
            tlpHistoryMain.ColumnCount = 1;
            tlpHistoryMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryMain.Controls.Add(tlpHistoryHeader, 0, 0);
            tlpHistoryMain.Controls.Add(dgvVisitsHistory, 0, 1);
            tlpHistoryMain.Dock = DockStyle.Fill;
            tlpHistoryMain.Location = new Point(20, 20);
            tlpHistoryMain.Name = "tlpHistoryMain";
            tlpHistoryMain.RowCount = 2;
            tlpHistoryMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpHistoryMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryMain.Size = new Size(1032, 743);
            tlpHistoryMain.TabIndex = 0;
            // 
            // tlpHistoryHeader
            // 
            tlpHistoryHeader.ColumnCount = 2;
            tlpHistoryHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tlpHistoryHeader.Controls.Add(lblHistoryTitle, 0, 0);
            tlpHistoryHeader.Controls.Add(txtSearchPatient, 1, 0);
            tlpHistoryHeader.Dock = DockStyle.Fill;
            tlpHistoryHeader.Location = new Point(0, 0);
            tlpHistoryHeader.Margin = new Padding(0, 0, 0, 20);
            tlpHistoryHeader.Name = "tlpHistoryHeader";
            tlpHistoryHeader.RowCount = 1;
            tlpHistoryHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryHeader.Size = new Size(1032, 35);
            tlpHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Dock = DockStyle.Fill;
            lblHistoryTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblHistoryTitle.Location = new Point(283, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(746, 35);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "قائمة زيارات المرضى";
            lblHistoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearchPatient
            // 
            txtSearchPatient.Anchor = AnchorStyles.None;
            txtSearchPatient.BackColor = Color.FromArgb(249, 250, 251);
            txtSearchPatient.BorderStyle = BorderStyle.FixedSingle;
            txtSearchPatient.Location = new Point(0, 4);
            txtSearchPatient.Margin = new Padding(30, 0, 0, 0);
            txtSearchPatient.Name = "txtSearchPatient";
            txtSearchPatient.Size = new Size(250, 27);
            txtSearchPatient.TabIndex = 1;
            txtSearchPatient.Text = "بحث باسم المريض...";
            // 
            // dgvVisitsHistory
            // 
            dgvVisitsHistory.AllowUserToAddRows = false;
            dgvVisitsHistory.AllowUserToDeleteRows = false;
            dgvVisitsHistory.BackgroundColor = Color.White;
            dgvVisitsHistory.BorderStyle = BorderStyle.None;
            dgvVisitsHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVisitsHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 247, 250);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVisitsHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisitsHistory.ColumnHeadersHeight = 45;
            dgvVisitsHistory.Columns.AddRange(new DataGridViewColumn[] { colDate, colPatient, colDoctor, colDiagnosis, colActions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVisitsHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVisitsHistory.Dock = DockStyle.Fill;
            dgvVisitsHistory.EnableHeadersVisualStyles = false;
            dgvVisitsHistory.GridColor = Color.FromArgb(240, 240, 240);
            dgvVisitsHistory.Location = new Point(3, 58);
            dgvVisitsHistory.Name = "dgvVisitsHistory";
            dgvVisitsHistory.ReadOnly = true;
            dgvVisitsHistory.RowHeadersVisible = false;
            dgvVisitsHistory.RowTemplate.Height = 40;
            dgvVisitsHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitsHistory.Size = new Size(1026, 682);
            dgvVisitsHistory.TabIndex = 1;
            // 
            // colDate
            // 
            colDate.HeaderText = "التاريخ";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 150;
            // 
            // colPatient
            // 
            colPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPatient.HeaderText = "المريض";
            colPatient.Name = "colPatient";
            colPatient.ReadOnly = true;
            // 
            // colDoctor
            // 
            colDoctor.HeaderText = "الطبيب";
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            colDoctor.Width = 150;
            // 
            // colDiagnosis
            // 
            colDiagnosis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDiagnosis.FillWeight = 150F;
            colDiagnosis.HeaderText = "التشخيص";
            colDiagnosis.Name = "colDiagnosis";
            colDiagnosis.ReadOnly = true;
            // 
            // colActions
            // 
            colActions.HeaderText = "إجراءات";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Width = 120;
            // 
            // frmPatinetVisits
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1100, 749);
            Controls.Add(pnlMainBackground);
            Font = new Font("Segoe UI", 9.75F);
            Name = "frmPatinetVisits";
            RightToLeft = RightToLeft.Yes;
            pnlMainBackground.ResumeLayout(false);
            tabControlVisits.ResumeLayout(false);
            tabNewVisit.ResumeLayout(false);
            scrollContainer.ResumeLayout(false);
            tlpNewVisitMain.ResumeLayout(false);
            tlpNewVisitMain.PerformLayout();
            tlpColumnsContainer.ResumeLayout(false);
            pnlGeneralDataCard.ResumeLayout(false);
            tlpGeneralData.ResumeLayout(false);
            tlpGeneralData.PerformLayout();
            tlpPatientDoctorGrid.ResumeLayout(false);
            pnlPatientGroup.ResumeLayout(false);
            pnlPatientGroup.PerformLayout();
            pnlDoctorGroup.ResumeLayout(false);
            pnlDoctorGroup.PerformLayout();
            tlpRightSideCards.ResumeLayout(false);
            pnlVitalsCard.ResumeLayout(false);
            tlpVitals.ResumeLayout(false);
            flpVitalsHeader.ResumeLayout(false);
            flpVitalsHeader.PerformLayout();
            pnlBPGroup.ResumeLayout(false);
            pnlBPGroup.PerformLayout();
            tlpTempPulseGrid.ResumeLayout(false);
            pnlTempGroup.ResumeLayout(false);
            pnlTempGroup.PerformLayout();
            pnlPulseGroup.ResumeLayout(false);
            pnlPulseGroup.PerformLayout();
            tlpWeightHeightGrid.ResumeLayout(false);
            pnlWeightGroup.ResumeLayout(false);
            pnlWeightGroup.PerformLayout();
            pnlHeightGroup.ResumeLayout(false);
            pnlHeightGroup.PerformLayout();
            pnlNotesCard.ResumeLayout(false);
            tlpNotes.ResumeLayout(false);
            tlpNotes.PerformLayout();
            flpActionButtons.ResumeLayout(false);
            tabVisitHistory.ResumeLayout(false);
            pnlHistoryCard.ResumeLayout(false);
            tlpHistoryMain.ResumeLayout(false);
            tlpHistoryHeader.ResumeLayout(false);
            tlpHistoryHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitsHistory).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlMainBackground;
        private System.Windows.Forms.TabControl tabControlVisits;
        private System.Windows.Forms.TabPage tabNewVisit;
        private System.Windows.Forms.Panel scrollContainer;
        private System.Windows.Forms.TableLayoutPanel tlpNewVisitMain;
        private System.Windows.Forms.Label lblVisitHeader;
        private System.Windows.Forms.TableLayoutPanel tlpColumnsContainer;
        private System.Windows.Forms.Panel pnlGeneralDataCard;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralData;
        private System.Windows.Forms.Label lblGeneralDataTitle;
        private System.Windows.Forms.TableLayoutPanel tlpPatientDoctorGrid;
        private System.Windows.Forms.Panel pnlPatientGroup;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Panel pnlDoctorGroup;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblTreatmentPlan;
        private System.Windows.Forms.TextBox txtTreatmentPlan;
        private System.Windows.Forms.TableLayoutPanel tlpRightSideCards;
        private System.Windows.Forms.Panel pnlVitalsCard;
        private System.Windows.Forms.TableLayoutPanel tlpVitals;
        private System.Windows.Forms.FlowLayoutPanel flpVitalsHeader;
        private System.Windows.Forms.Label lblVitalsIcon;
        private System.Windows.Forms.Label lblVitalsTitle;
        private System.Windows.Forms.Panel pnlBPGroup;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.TableLayoutPanel tlpTempPulseGrid;
        private System.Windows.Forms.Panel pnlTempGroup;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Panel pnlPulseGroup;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TableLayoutPanel tlpWeightHeightGrid;
        private System.Windows.Forms.Panel pnlWeightGroup;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel pnlHeightGroup;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Panel pnlNotesCard;
        private System.Windows.Forms.TableLayoutPanel tlpNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnSaveVisit;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.TabPage tabVisitHistory;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.TableLayoutPanel tlpHistoryMain;
        private System.Windows.Forms.TableLayoutPanel tlpHistoryHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.DataGridView dgvVisitsHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnosis;
        private System.Windows.Forms.DataGridViewImageColumn colActions;
    }
}