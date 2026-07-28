using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.PatientVisits
{
    partial class frmShowPatientVisitInfo : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            pnlFooter = new Panel();
            btnClose = new Button();
            pnlBody = new Panel();
            lblVisitId = new Label();
            txtVisitId = new TextBox();
            lblVisitDate = new Label();
            txtVisitDate = new TextBox();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblDoctorName = new Label();
            txtDoctorName = new TextBox();
            lblAppointmentReason = new Label();
            txtAppointmentReason = new TextBox();
            lblVisitStatusTitle = new Label();
            txtVisitStatusTitle = new TextBox();
            lblBloodPressure = new Label();
            txtBloodPressure = new TextBox();
            lblTemperature = new Label();
            txtTemperature = new TextBox();
            lblHeartRate = new Label();
            txtHeartRate = new TextBox();
            lblRespiratoryRate = new Label();
            txtRespiratoryRate = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblSymptoms = new Label();
            txtSymptoms = new TextBox();
            lblDiagnosis = new Label();
            txtDiagnosis = new TextBox();
            lblTreatmentPlan = new Label();
            txtTreatmentPlan = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 37, 51);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(650, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(650, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "تفاصيل زيارة المريض";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 560); // تم رفعه للأعلى لأن الفورم أصبح أقصر
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(650, 56);
            pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(156, 163, 175);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(260, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlBody
            // 
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(lblVisitId);
            pnlBody.Controls.Add(txtVisitId);
            pnlBody.Controls.Add(lblVisitDate);
            pnlBody.Controls.Add(txtVisitDate);
            pnlBody.Controls.Add(lblPatientName);
            pnlBody.Controls.Add(txtPatientName);
            pnlBody.Controls.Add(lblDoctorName);
            pnlBody.Controls.Add(txtDoctorName);
            pnlBody.Controls.Add(lblAppointmentReason);
            pnlBody.Controls.Add(txtAppointmentReason);
            pnlBody.Controls.Add(lblVisitStatusTitle);
            pnlBody.Controls.Add(txtVisitStatusTitle);
            pnlBody.Controls.Add(lblBloodPressure);
            pnlBody.Controls.Add(txtBloodPressure);
            pnlBody.Controls.Add(lblTemperature);
            pnlBody.Controls.Add(txtTemperature);
            pnlBody.Controls.Add(lblHeartRate);
            pnlBody.Controls.Add(txtHeartRate);
            pnlBody.Controls.Add(lblRespiratoryRate);
            pnlBody.Controls.Add(txtRespiratoryRate);
            pnlBody.Controls.Add(lblWeight);
            pnlBody.Controls.Add(txtWeight);
            pnlBody.Controls.Add(lblHeight);
            pnlBody.Controls.Add(txtHeight);
            pnlBody.Controls.Add(lblSymptoms);
            pnlBody.Controls.Add(txtSymptoms);
            pnlBody.Controls.Add(lblDiagnosis);
            pnlBody.Controls.Add(txtDiagnosis);
            pnlBody.Controls.Add(lblTreatmentPlan);
            pnlBody.Controls.Add(txtTreatmentPlan);
            pnlBody.Controls.Add(lblNotes);
            pnlBody.Controls.Add(txtNotes);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 60);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(650, 500);
            pnlBody.TabIndex = 2;
            // 
            // lblVisitId
            // 
            lblVisitId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVisitId.ForeColor = Color.FromArgb(55, 65, 81);
            lblVisitId.Location = new Point(340, 20);
            lblVisitId.Name = "lblVisitId";
            lblVisitId.Size = new Size(285, 22);
            lblVisitId.TabIndex = 0;
            lblVisitId.Text = "رقم الزيارة:";
            lblVisitId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVisitId
            // 
            txtVisitId.BackColor = Color.White;
            txtVisitId.BorderStyle = BorderStyle.FixedSingle;
            txtVisitId.Font = new Font("Segoe UI", 9.5F);
            txtVisitId.ForeColor = Color.FromArgb(31, 41, 55);
            txtVisitId.Location = new Point(340, 45);
            txtVisitId.Name = "txtVisitId";
            txtVisitId.ReadOnly = true;
            txtVisitId.Size = new Size(285, 24);
            txtVisitId.TabIndex = 1;
            // 
            // lblVisitDate
            // 
            lblVisitDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVisitDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblVisitDate.Location = new Point(25, 20);
            lblVisitDate.Name = "lblVisitDate";
            lblVisitDate.Size = new Size(285, 22);
            lblVisitDate.TabIndex = 2;
            lblVisitDate.Text = "تاريخ الزيارة:";
            lblVisitDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVisitDate
            // 
            txtVisitDate.BackColor = Color.White;
            txtVisitDate.BorderStyle = BorderStyle.FixedSingle;
            txtVisitDate.Font = new Font("Segoe UI", 9.5F);
            txtVisitDate.ForeColor = Color.FromArgb(31, 41, 55);
            txtVisitDate.Location = new Point(25, 45);
            txtVisitDate.Name = "txtVisitDate";
            txtVisitDate.ReadOnly = true;
            txtVisitDate.Size = new Size(285, 24);
            txtVisitDate.TabIndex = 3;
            // 
            // lblPatientName
            // 
            lblPatientName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(55, 65, 81);
            lblPatientName.Location = new Point(340, 85);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(285, 22);
            lblPatientName.TabIndex = 4;
            lblPatientName.Text = "اسم المريض:";
            lblPatientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            txtPatientName.BackColor = Color.White;
            txtPatientName.BorderStyle = BorderStyle.FixedSingle;
            txtPatientName.Font = new Font("Segoe UI", 9.5F);
            txtPatientName.ForeColor = Color.FromArgb(31, 41, 55);
            txtPatientName.Location = new Point(340, 110);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new Size(285, 24);
            txtPatientName.TabIndex = 5;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoctorName.ForeColor = Color.FromArgb(55, 65, 81);
            lblDoctorName.Location = new Point(25, 85);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(285, 22);
            lblDoctorName.TabIndex = 6;
            lblDoctorName.Text = "اسم الطبيب:";
            lblDoctorName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDoctorName
            // 
            txtDoctorName.BackColor = Color.White;
            txtDoctorName.BorderStyle = BorderStyle.FixedSingle;
            txtDoctorName.Font = new Font("Segoe UI", 9.5F);
            txtDoctorName.ForeColor = Color.FromArgb(31, 41, 55);
            txtDoctorName.Location = new Point(25, 110);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.ReadOnly = true;
            txtDoctorName.Size = new Size(285, 24);
            txtDoctorName.TabIndex = 7;
            // 
            // lblAppointmentReason
            // 
            lblAppointmentReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppointmentReason.ForeColor = Color.FromArgb(55, 65, 81);
            lblAppointmentReason.Location = new Point(340, 150);
            lblAppointmentReason.Name = "lblAppointmentReason";
            lblAppointmentReason.Size = new Size(285, 22);
            lblAppointmentReason.TabIndex = 8;
            lblAppointmentReason.Text = "سبب الموعد:";
            lblAppointmentReason.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAppointmentReason
            // 
            txtAppointmentReason.BackColor = Color.White;
            txtAppointmentReason.BorderStyle = BorderStyle.FixedSingle;
            txtAppointmentReason.Font = new Font("Segoe UI", 9.5F);
            txtAppointmentReason.ForeColor = Color.FromArgb(31, 41, 55);
            txtAppointmentReason.Location = new Point(340, 175);
            txtAppointmentReason.Name = "txtAppointmentReason";
            txtAppointmentReason.ReadOnly = true;
            txtAppointmentReason.Size = new Size(285, 24);
            txtAppointmentReason.TabIndex = 9;
            // 
            // lblVisitStatusTitle
            // 
            lblVisitStatusTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVisitStatusTitle.ForeColor = Color.FromArgb(55, 65, 81);
            lblVisitStatusTitle.Location = new Point(25, 150);
            lblVisitStatusTitle.Name = "lblVisitStatusTitle";
            lblVisitStatusTitle.Size = new Size(285, 22);
            lblVisitStatusTitle.TabIndex = 10;
            lblVisitStatusTitle.Text = "حالة الزيارة:";
            lblVisitStatusTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVisitStatusTitle
            // 
            txtVisitStatusTitle.BackColor = Color.White;
            txtVisitStatusTitle.BorderStyle = BorderStyle.FixedSingle;
            txtVisitStatusTitle.Font = new Font("Segoe UI", 9.5F);
            txtVisitStatusTitle.ForeColor = Color.FromArgb(31, 41, 55);
            txtVisitStatusTitle.Location = new Point(25, 175);
            txtVisitStatusTitle.Name = "txtVisitStatusTitle";
            txtVisitStatusTitle.ReadOnly = true;
            txtVisitStatusTitle.Size = new Size(285, 24);
            txtVisitStatusTitle.TabIndex = 11;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBloodPressure.ForeColor = Color.FromArgb(55, 65, 81);
            lblBloodPressure.Location = new Point(340, 215);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new Size(285, 22);
            lblBloodPressure.TabIndex = 12;
            lblBloodPressure.Text = "ضغط الدم:";
            lblBloodPressure.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.BackColor = Color.White;
            txtBloodPressure.BorderStyle = BorderStyle.FixedSingle;
            txtBloodPressure.Font = new Font("Segoe UI", 9.5F);
            txtBloodPressure.ForeColor = Color.FromArgb(31, 41, 55);
            txtBloodPressure.Location = new Point(340, 240);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.ReadOnly = true;
            txtBloodPressure.Size = new Size(285, 24);
            txtBloodPressure.TabIndex = 13;
            // 
            // lblTemperature
            // 
            lblTemperature.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.FromArgb(55, 65, 81);
            lblTemperature.Location = new Point(25, 215);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(285, 22);
            lblTemperature.TabIndex = 14;
            lblTemperature.Text = "درجة الحرارة (180°C):";
            lblTemperature.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTemperature
            // 
            txtTemperature.BackColor = Color.White;
            txtTemperature.BorderStyle = BorderStyle.FixedSingle;
            txtTemperature.Font = new Font("Segoe UI", 9.5F);
            txtTemperature.ForeColor = Color.FromArgb(31, 41, 55);
            txtTemperature.Location = new Point(25, 240);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.ReadOnly = true;
            txtTemperature.Size = new Size(285, 24);
            txtTemperature.TabIndex = 15;
            // 
            // lblHeartRate
            // 
            lblHeartRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeartRate.ForeColor = Color.FromArgb(55, 65, 81);
            lblHeartRate.Location = new Point(340, 280);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(285, 22);
            lblHeartRate.TabIndex = 16;
            lblHeartRate.Text = "معدل ضربات القلب:";
            lblHeartRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHeartRate
            // 
            txtHeartRate.BackColor = Color.White;
            txtHeartRate.BorderStyle = BorderStyle.FixedSingle;
            txtHeartRate.Font = new Font("Segoe UI", 9.5F);
            txtHeartRate.ForeColor = Color.FromArgb(31, 41, 55);
            txtHeartRate.Location = new Point(340, 305);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.ReadOnly = true;
            txtHeartRate.Size = new Size(285, 24);
            txtHeartRate.TabIndex = 17;
            // 
            // lblRespiratoryRate
            // 
            lblRespiratoryRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRespiratoryRate.ForeColor = Color.FromArgb(55, 65, 81);
            lblRespiratoryRate.Location = new Point(25, 280);
            lblRespiratoryRate.Name = "lblRespiratoryRate";
            lblRespiratoryRate.Size = new Size(285, 22);
            lblRespiratoryRate.TabIndex = 18;
            lblRespiratoryRate.Text = "معدل التنفس:";
            lblRespiratoryRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRespiratoryRate
            // 
            txtRespiratoryRate.BackColor = Color.White;
            txtRespiratoryRate.BorderStyle = BorderStyle.FixedSingle;
            txtRespiratoryRate.Font = new Font("Segoe UI", 9.5F);
            txtRespiratoryRate.ForeColor = Color.FromArgb(31, 41, 55);
            txtRespiratoryRate.Location = new Point(25, 305);
            txtRespiratoryRate.Name = "txtRespiratoryRate";
            txtRespiratoryRate.ReadOnly = true;
            txtRespiratoryRate.Size = new Size(285, 24);
            txtRespiratoryRate.TabIndex = 19;
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWeight.ForeColor = Color.FromArgb(55, 65, 81);
            lblWeight.Location = new Point(340, 345);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(285, 22);
            lblWeight.TabIndex = 20;
            lblWeight.Text = "الوزن (كجم):";
            lblWeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.White;
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Segoe UI", 9.5F);
            txtWeight.ForeColor = Color.FromArgb(31, 41, 55);
            txtWeight.Location = new Point(340, 370);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(285, 24);
            txtWeight.TabIndex = 21;
            // 
            // lblHeight
            // 
            lblHeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeight.ForeColor = Color.FromArgb(55, 65, 81);
            lblHeight.Location = new Point(25, 345);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(285, 22);
            lblHeight.TabIndex = 22;
            lblHeight.Text = "الطول (سم):";
            lblHeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.White;
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Font = new Font("Segoe UI", 9.5F);
            txtHeight.ForeColor = Color.FromArgb(31, 41, 55);
            txtHeight.Location = new Point(25, 370);
            txtHeight.Name = "txtHeight";
            txtHeight.ReadOnly = true;
            txtHeight.Size = new Size(285, 24);
            txtHeight.TabIndex = 23;
            // 
            // ==========================================
            // التوزيع الجديد المتوازي للعناصر الكبيرة
            // ==========================================

            // 1. الأعراض (اليمين)
            lblSymptoms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSymptoms.ForeColor = Color.FromArgb(55, 65, 81);
            lblSymptoms.Location = new Point(340, 410);
            lblSymptoms.Name = "lblSymptoms";
            lblSymptoms.Size = new Size(285, 22);
            lblSymptoms.TabIndex = 24;
            lblSymptoms.Text = "الأعراض:";
            lblSymptoms.TextAlign = ContentAlignment.MiddleLeft;

            txtSymptoms.BackColor = Color.White;
            txtSymptoms.BorderStyle = BorderStyle.FixedSingle;
            txtSymptoms.Font = new Font("Segoe UI", 9.5F);
            txtSymptoms.ForeColor = Color.FromArgb(31, 41, 55);
            txtSymptoms.Location = new Point(340, 435);
            txtSymptoms.Multiline = true;
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.ReadOnly = true;
            txtSymptoms.ScrollBars = ScrollBars.Vertical;
            txtSymptoms.Size = new Size(285, 55);
            txtSymptoms.TabIndex = 25;

            // 2. التشخيص (اليسار - مقابل الأعراض)
            lblDiagnosis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiagnosis.ForeColor = Color.FromArgb(55, 65, 81);
            lblDiagnosis.Location = new Point(25, 410);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(285, 22);
            lblDiagnosis.TabIndex = 26;
            lblDiagnosis.Text = "التشخيص:";
            lblDiagnosis.TextAlign = ContentAlignment.MiddleLeft;

            txtDiagnosis.BackColor = Color.White;
            txtDiagnosis.BorderStyle = BorderStyle.FixedSingle;
            txtDiagnosis.Font = new Font("Segoe UI", 9.5F);
            txtDiagnosis.ForeColor = Color.FromArgb(31, 41, 55);
            txtDiagnosis.Location = new Point(25, 435);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(285, 55);
            txtDiagnosis.TabIndex = 27;

            // 3. خطة العلاج (اليمين)
            lblTreatmentPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTreatmentPlan.ForeColor = Color.FromArgb(55, 65, 81);
            lblTreatmentPlan.Location = new Point(340, 505);
            lblTreatmentPlan.Name = "lblTreatmentPlan";
            lblTreatmentPlan.Size = new Size(285, 22);
            lblTreatmentPlan.TabIndex = 28;
            lblTreatmentPlan.Text = "خطة العلاج:";
            lblTreatmentPlan.TextAlign = ContentAlignment.MiddleLeft;

            txtTreatmentPlan.BackColor = Color.White;
            txtTreatmentPlan.BorderStyle = BorderStyle.FixedSingle;
            txtTreatmentPlan.Font = new Font("Segoe UI", 9.5F);
            txtTreatmentPlan.ForeColor = Color.FromArgb(31, 41, 55);
            txtTreatmentPlan.Location = new Point(340, 530);
            txtTreatmentPlan.Multiline = true;
            txtTreatmentPlan.Name = "txtTreatmentPlan";
            txtTreatmentPlan.ReadOnly = true;
            txtTreatmentPlan.ScrollBars = ScrollBars.Vertical;
            txtTreatmentPlan.Size = new Size(285, 55);
            txtTreatmentPlan.TabIndex = 29;

            // 4. ملاحظات (اليسار - مقابل خطة العلاج)
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(55, 65, 81);
            lblNotes.Location = new Point(25, 505);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(285, 22);
            lblNotes.TabIndex = 30;
            lblNotes.Text = "ملاحظات:";
            lblNotes.TextAlign = ContentAlignment.MiddleLeft;

            txtNotes.BackColor = Color.White;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Segoe UI", 9.5F);
            txtNotes.ForeColor = Color.FromArgb(31, 41, 55);
            txtNotes.Location = new Point(25, 530);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(285, 55);
            txtNotes.TabIndex = 31;

            // 
            // frmShowPatientVisitInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(650, 616); // تم تقصير إجمالي ارتفاع الفورم من 749 إلى 616 ليظهر كاملاً
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowPatientVisitInfo";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل زيارة المريض";
            Load += frmShowPatientVisitInfo_Load;
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Label lblVisitId;
        private System.Windows.Forms.TextBox txtVisitId;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.TextBox txtVisitDate;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblAppointmentReason;
        private System.Windows.Forms.TextBox txtAppointmentReason;
        private System.Windows.Forms.Label lblVisitStatusTitle;
        private System.Windows.Forms.TextBox txtVisitStatusTitle;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.Label lblRespiratoryRate;
        private System.Windows.Forms.TextBox txtRespiratoryRate;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblTreatmentPlan;
        private System.Windows.Forms.TextBox txtTreatmentPlan;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}