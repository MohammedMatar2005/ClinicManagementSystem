
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Appointments
{
    partial class frmUpdateAppointment : Form
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
            btnSave = new Button();
            btnClose = new Button();
            pnlBody = new Panel();
            cmbAppointmentStatus = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            lblAppointmentId = new Label();
            txtAppointmentId = new TextBox();
            lblCreatedDate = new Label();
            txtCreatedDate = new TextBox();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblUpdatedDate = new Label();
            txtUpdatedDate = new TextBox();
            lblDoctorName = new Label();
            txtDoctorName = new TextBox();
            lblStatusName = new Label();
            lblAppointmentDate = new Label();
            lblIsActiveSection = new Label();
            chkIsActive = new CheckBox();
            lblReasonForVisit = new Label();
            txtReasonForVisit = new TextBox();
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
            lblFormTitle.Text = "تعديل الموعد";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 544);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(650, 56);
            pnlFooter.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(495, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ التعديلات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnClose.Location = new Point(25, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(cmbAppointmentStatus);
            pnlBody.Controls.Add(dtpAppointmentDate);
            pnlBody.Controls.Add(lblAppointmentId);
            pnlBody.Controls.Add(txtAppointmentId);
            pnlBody.Controls.Add(lblCreatedDate);
            pnlBody.Controls.Add(txtCreatedDate);
            pnlBody.Controls.Add(lblPatientName);
            pnlBody.Controls.Add(txtPatientName);
            pnlBody.Controls.Add(lblUpdatedDate);
            pnlBody.Controls.Add(txtUpdatedDate);
            pnlBody.Controls.Add(lblDoctorName);
            pnlBody.Controls.Add(txtDoctorName);
            pnlBody.Controls.Add(lblStatusName);
            pnlBody.Controls.Add(lblAppointmentDate);
            pnlBody.Controls.Add(lblIsActiveSection);
            pnlBody.Controls.Add(chkIsActive);
            pnlBody.Controls.Add(lblReasonForVisit);
            pnlBody.Controls.Add(txtReasonForVisit);
            pnlBody.Controls.Add(lblNotes);
            pnlBody.Controls.Add(txtNotes);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 60);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(650, 484);
            pnlBody.TabIndex = 2;
            // 
            // cmbAppointmentStatus
            // 
            cmbAppointmentStatus.FormattingEnabled = true;
            cmbAppointmentStatus.Items.AddRange(new object[] { "انتظار", "مؤكد", "معلق", "ملغي" });
            cmbAppointmentStatus.Location = new Point(25, 175);
            cmbAppointmentStatus.Name = "cmbAppointmentStatus";
            cmbAppointmentStatus.Size = new Size(285, 23);
            cmbAppointmentStatus.TabIndex = 21;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CustomFormat = "yyyy/mm/dd - hh:mm";
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new Point(340, 240);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(285, 23);
            dtpAppointmentDate.TabIndex = 20;
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppointmentId.ForeColor = Color.FromArgb(55, 65, 81);
            lblAppointmentId.Location = new Point(340, 20);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(285, 22);
            lblAppointmentId.TabIndex = 0;
            lblAppointmentId.Text = "رقم الموعد:";
            lblAppointmentId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.BackColor = Color.White;
            txtAppointmentId.BorderStyle = BorderStyle.FixedSingle;
            txtAppointmentId.Font = new Font("Segoe UI", 9.5F);
            txtAppointmentId.ForeColor = Color.FromArgb(31, 41, 55);
            txtAppointmentId.Location = new Point(340, 45);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.ReadOnly = true;
            txtAppointmentId.Size = new Size(285, 24);
            txtAppointmentId.TabIndex = 1;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCreatedDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblCreatedDate.Location = new Point(25, 20);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(285, 22);
            lblCreatedDate.TabIndex = 2;
            lblCreatedDate.Text = "تاريخ الإنشاء:";
            lblCreatedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.BackColor = Color.White;
            txtCreatedDate.BorderStyle = BorderStyle.FixedSingle;
            txtCreatedDate.Font = new Font("Segoe UI", 9.5F);
            txtCreatedDate.ForeColor = Color.FromArgb(31, 41, 55);
            txtCreatedDate.Location = new Point(25, 45);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(285, 24);
            txtCreatedDate.TabIndex = 3;
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
            // lblUpdatedDate
            // 
            lblUpdatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdatedDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblUpdatedDate.Location = new Point(25, 85);
            lblUpdatedDate.Name = "lblUpdatedDate";
            lblUpdatedDate.Size = new Size(285, 22);
            lblUpdatedDate.TabIndex = 6;
            lblUpdatedDate.Text = "تاريخ آخر تحديث:";
            lblUpdatedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdatedDate
            // 
            txtUpdatedDate.BackColor = Color.White;
            txtUpdatedDate.BorderStyle = BorderStyle.FixedSingle;
            txtUpdatedDate.Font = new Font("Segoe UI", 9.5F);
            txtUpdatedDate.ForeColor = Color.FromArgb(31, 41, 55);
            txtUpdatedDate.Location = new Point(25, 110);
            txtUpdatedDate.Name = "txtUpdatedDate";
            txtUpdatedDate.ReadOnly = true;
            txtUpdatedDate.Size = new Size(285, 24);
            txtUpdatedDate.TabIndex = 7;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoctorName.ForeColor = Color.FromArgb(55, 65, 81);
            lblDoctorName.Location = new Point(340, 150);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(285, 22);
            lblDoctorName.TabIndex = 8;
            lblDoctorName.Text = "اسم الطبيب:";
            lblDoctorName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDoctorName
            // 
            txtDoctorName.BackColor = Color.White;
            txtDoctorName.BorderStyle = BorderStyle.FixedSingle;
            txtDoctorName.Font = new Font("Segoe UI", 9.5F);
            txtDoctorName.ForeColor = Color.FromArgb(31, 41, 55);
            txtDoctorName.Location = new Point(340, 175);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.ReadOnly = true;
            txtDoctorName.Size = new Size(285, 24);
            txtDoctorName.TabIndex = 9;
            // 
            // lblStatusName
            // 
            lblStatusName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusName.ForeColor = Color.FromArgb(55, 65, 81);
            lblStatusName.Location = new Point(25, 150);
            lblStatusName.Name = "lblStatusName";
            lblStatusName.Size = new Size(285, 22);
            lblStatusName.TabIndex = 10;
            lblStatusName.Text = "حالة الموعد:";
            lblStatusName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppointmentDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblAppointmentDate.Location = new Point(340, 215);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(285, 22);
            lblAppointmentDate.TabIndex = 12;
            lblAppointmentDate.Text = "تاريخ الموعد:";
            lblAppointmentDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIsActiveSection
            // 
            lblIsActiveSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIsActiveSection.ForeColor = Color.FromArgb(55, 65, 81);
            lblIsActiveSection.Location = new Point(25, 215);
            lblIsActiveSection.Name = "lblIsActiveSection";
            lblIsActiveSection.Size = new Size(285, 22);
            lblIsActiveSection.TabIndex = 14;
            lblIsActiveSection.Text = "الحالة في النظام:";
            lblIsActiveSection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            chkIsActive.Enabled = false;
            chkIsActive.Font = new Font("Segoe UI", 9.5F);
            chkIsActive.ForeColor = Color.FromArgb(31, 41, 55);
            chkIsActive.Location = new Point(25, 240);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(285, 24);
            chkIsActive.TabIndex = 15;
            chkIsActive.Text = "الموعد نشط في النظام";
            // 
            // lblReasonForVisit
            // 
            lblReasonForVisit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReasonForVisit.ForeColor = Color.FromArgb(55, 65, 81);
            lblReasonForVisit.Location = new Point(25, 280);
            lblReasonForVisit.Name = "lblReasonForVisit";
            lblReasonForVisit.Size = new Size(600, 22);
            lblReasonForVisit.TabIndex = 16;
            lblReasonForVisit.Text = "سبب الزيارة:";
            lblReasonForVisit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtReasonForVisit
            // 
            txtReasonForVisit.BackColor = Color.White;
            txtReasonForVisit.BorderStyle = BorderStyle.FixedSingle;
            txtReasonForVisit.Font = new Font("Segoe UI", 9.5F);
            txtReasonForVisit.ForeColor = Color.FromArgb(31, 41, 55);
            txtReasonForVisit.Location = new Point(25, 305);
            txtReasonForVisit.Multiline = true;
            txtReasonForVisit.Name = "txtReasonForVisit";
            txtReasonForVisit.ScrollBars = ScrollBars.Vertical;
            txtReasonForVisit.Size = new Size(600, 50);
            txtReasonForVisit.TabIndex = 17;
            // 
            // lblNotes
            // 
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(55, 65, 81);
            lblNotes.Location = new Point(25, 365);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(600, 22);
            lblNotes.TabIndex = 18;
            lblNotes.Text = "ملاحظات:";
            lblNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.White;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Segoe UI", 9.5F);
            txtNotes.ForeColor = Color.FromArgb(31, 41, 55);
            txtNotes.Location = new Point(25, 390);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(600, 50);
            txtNotes.TabIndex = 19;
            // 
            // frmUpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(650, 600);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateAppointment";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل الموعد";
            Load += frmUpdateAppointment_Load;
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

        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.TextBox txtCreatedDate;

        // المتغيرات الجديدة بالأسماء 
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblStatusName;

        private System.Windows.Forms.Label lblUpdatedDate;
        private System.Windows.Forms.TextBox txtUpdatedDate;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblIsActiveSection;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblReasonForVisit;
        private System.Windows.Forms.TextBox txtReasonForVisit;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private DateTimePicker dtpAppointmentDate;
        private Button btnSave;
        private ComboBox cmbAppointmentStatus;
    }
}