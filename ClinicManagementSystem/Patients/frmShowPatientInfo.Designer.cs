using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmShowPatientInfo : Form
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
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            pnlFooter = new Panel();
            btnClose = new Button();
            pnlBody = new Panel();
            tcPatientDetails = new TabControl();

            tpPersonalInfo = new TabPage();
            lblNationalNo = new Label();
            txtNationalNo = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();

            tpMedicalInfo = new TabPage();
            lblBloodType = new Label();
            txtBloodType = new TextBox();
            lblEmergencyContact = new Label();
            txtEmergencyContact = new TextBox();
            lblEmergencyPhone = new Label();
            txtEmergencyPhone = new TextBox();
            lblPatientId = new Label();
            txtPatientId = new TextBox();
            lblPersonId = new Label();
            txtPersonId = new TextBox();
            lblCreatedDate = new Label();
            txtCreatedDate = new TextBox();
            lblAllergies = new Label();
            txtAllergies = new TextBox();
            lblMedicalHistory = new Label();
            txtMedicalHistory = new TextBox();
            lblIsActiveSection = new Label();
            chkIsActive = new CheckBox();

            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            tcPatientDetails.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpMedicalInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 37, 51);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(680, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(680, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "الملف الكامل للمريض";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 584);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(680, 56);
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
            btnClose.Location = new Point(275, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(tcPatientDetails);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 60);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(15);
            pnlBody.Size = new Size(680, 524);
            pnlBody.TabIndex = 2;
            // 
            // tcPatientDetails
            // 
            tcPatientDetails.Controls.Add(tpPersonalInfo);
            tcPatientDetails.Controls.Add(tpMedicalInfo);
            tcPatientDetails.Dock = DockStyle.Fill;
            tcPatientDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tcPatientDetails.Location = new Point(15, 15);
            tcPatientDetails.Name = "tcPatientDetails";
            tcPatientDetails.SelectedIndex = 0;
            tcPatientDetails.Size = new Size(650, 494);
            tcPatientDetails.TabIndex = 0;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.BackColor = Color.White;
            tpPersonalInfo.Controls.Add(lblNationalNo);
            tpPersonalInfo.Controls.Add(txtNationalNo);
            tpPersonalInfo.Controls.Add(lblFullName);
            tpPersonalInfo.Controls.Add(txtFullName);
            tpPersonalInfo.Controls.Add(lblAge);
            tpPersonalInfo.Controls.Add(txtAge);
            tpPersonalInfo.Controls.Add(lblPhone);
            tpPersonalInfo.Controls.Add(txtPhone);
            tpPersonalInfo.Controls.Add(lblEmail);
            tpPersonalInfo.Controls.Add(txtEmail);
            tpPersonalInfo.Location = new Point(4, 26);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(20);
            tpPersonalInfo.Size = new Size(642, 464);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "البيانات الشخصية";
            // 
            // lblNationalNo
            // 
            lblNationalNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNationalNo.ForeColor = Color.FromArgb(55, 65, 81);
            lblNationalNo.Location = new Point(335, 20);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(285, 22);
            lblNationalNo.TabIndex = 0;
            lblNationalNo.Text = "الرقم القومي / الهوية:";
            // 
            // txtNationalNo
            // 
            txtNationalNo.BackColor = Color.White;
            txtNationalNo.BorderStyle = BorderStyle.FixedSingle;
            txtNationalNo.Font = new Font("Segoe UI", 9.5F);
            txtNationalNo.Location = new Point(335, 45);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.ReadOnly = true;
            txtNationalNo.Size = new Size(285, 24);
            txtNationalNo.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(55, 65, 81);
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(285, 22);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "الاسم الكامل:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 9.5F);
            txtFullName.Location = new Point(20, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(285, 24);
            txtFullName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(55, 65, 81);
            lblAge.Location = new Point(335, 85);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(285, 22);
            lblAge.TabIndex = 4;
            lblAge.Text = "العمر:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 9.5F);
            txtAge.Location = new Point(335, 110);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(285, 24);
            txtAge.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone.Location = new Point(20, 85);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(285, 22);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "رقم الهاتف:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 9.5F);
            txtPhone.Location = new Point(20, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(285, 24);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmail.Location = new Point(20, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(600, 22);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "البريد الإلكتروني:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(20, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(600, 24);
            txtEmail.TabIndex = 9;
            // 
            // tpMedicalInfo
            // 
            tpMedicalInfo.BackColor = Color.White;
            tpMedicalInfo.Controls.Add(lblBloodType);
            tpMedicalInfo.Controls.Add(txtBloodType);
            tpMedicalInfo.Controls.Add(lblEmergencyContact);
            tpMedicalInfo.Controls.Add(txtEmergencyContact);
            tpMedicalInfo.Controls.Add(lblEmergencyPhone);
            tpMedicalInfo.Controls.Add(txtEmergencyPhone);
            tpMedicalInfo.Controls.Add(lblPatientId);
            tpMedicalInfo.Controls.Add(txtPatientId);
            tpMedicalInfo.Controls.Add(lblPersonId);
            tpMedicalInfo.Controls.Add(txtPersonId);
            tpMedicalInfo.Controls.Add(lblCreatedDate);
            tpMedicalInfo.Controls.Add(txtCreatedDate);
            tpMedicalInfo.Controls.Add(lblAllergies);
            tpMedicalInfo.Controls.Add(txtAllergies);
            tpMedicalInfo.Controls.Add(lblMedicalHistory);
            tpMedicalInfo.Controls.Add(txtMedicalHistory);
            tpMedicalInfo.Controls.Add(lblIsActiveSection);
            tpMedicalInfo.Controls.Add(chkIsActive);
            tpMedicalInfo.Location = new Point(4, 26);
            tpMedicalInfo.Name = "tpMedicalInfo";
            tpMedicalInfo.Padding = new Padding(20);
            tpMedicalInfo.Size = new Size(642, 464);
            tpMedicalInfo.TabIndex = 1;
            tpMedicalInfo.Text = "البيانات الطبية والطوارئ";
            // 
            // lblBloodType
            // 
            lblBloodType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBloodType.ForeColor = Color.FromArgb(55, 65, 81);
            lblBloodType.Location = new Point(335, 20);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(285, 22);
            lblBloodType.TabIndex = 0;
            lblBloodType.Text = "فصيلة الدم:";
            // 
            // txtBloodType
            // 
            txtBloodType.BackColor = Color.White;
            txtBloodType.BorderStyle = BorderStyle.FixedSingle;
            txtBloodType.Font = new Font("Segoe UI", 9.5F);
            txtBloodType.Location = new Point(335, 45);
            txtBloodType.Name = "txtBloodType";
            txtBloodType.ReadOnly = true;
            txtBloodType.Size = new Size(285, 24);
            txtBloodType.TabIndex = 1;
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmergencyContact.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmergencyContact.Location = new Point(20, 20);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(285, 22);
            lblEmergencyContact.TabIndex = 2;
            lblEmergencyContact.Text = "اسم شخص للطوارئ:";
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.BackColor = Color.White;
            txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyContact.Font = new Font("Segoe UI", 9.5F);
            txtEmergencyContact.Location = new Point(20, 45);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.ReadOnly = true;
            txtEmergencyContact.Size = new Size(285, 24);
            txtEmergencyContact.TabIndex = 3;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmergencyPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmergencyPhone.Location = new Point(335, 85);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(285, 22);
            lblEmergencyPhone.TabIndex = 4;
            lblEmergencyPhone.Text = "رقم هاتف شخص الطوارئ:";
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.BackColor = Color.White;
            txtEmergencyPhone.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyPhone.Font = new Font("Segoe UI", 9.5F);
            txtEmergencyPhone.Location = new Point(335, 110);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.ReadOnly = true;
            txtEmergencyPhone.Size = new Size(285, 24);
            txtEmergencyPhone.TabIndex = 5;
            // 
            // lblPatientId
            // 
            lblPatientId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPatientId.ForeColor = Color.FromArgb(55, 65, 81);
            lblPatientId.Location = new Point(20, 85);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(285, 22);
            lblPatientId.TabIndex = 6;
            lblPatientId.Text = "كود المريض المتسلسل:";
            // 
            // txtPatientId
            // 
            txtPatientId.BackColor = Color.White;
            txtPatientId.BorderStyle = BorderStyle.FixedSingle;
            txtPatientId.Font = new Font("Segoe UI", 9.5F);
            txtPatientId.Location = new Point(20, 110);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.ReadOnly = true;
            txtPatientId.Size = new Size(285, 24);
            txtPatientId.TabIndex = 7;
            // 
            // lblPersonId
            // 
            lblPersonId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPersonId.ForeColor = Color.FromArgb(55, 65, 81);
            lblPersonId.Location = new Point(335, 150);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(285, 22);
            lblPersonId.TabIndex = 8;
            lblPersonId.Text = "معرف الشخص (Person ID):";
            // 
            // txtPersonId
            // 
            txtPersonId.BackColor = Color.White;
            txtPersonId.BorderStyle = BorderStyle.FixedSingle;
            txtPersonId.Font = new Font("Segoe UI", 9.5F);
            txtPersonId.Location = new Point(335, 175);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.ReadOnly = true;
            txtPersonId.Size = new Size(285, 24);
            txtPersonId.TabIndex = 9;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCreatedDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblCreatedDate.Location = new Point(20, 150);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(285, 22);
            lblCreatedDate.TabIndex = 10;
            lblCreatedDate.Text = "تاريخ التسجيل في النظام:";
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.BackColor = Color.White;
            txtCreatedDate.BorderStyle = BorderStyle.FixedSingle;
            txtCreatedDate.Font = new Font("Segoe UI", 9.5F);
            txtCreatedDate.Location = new Point(20, 175);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(285, 24);
            txtCreatedDate.TabIndex = 11;
            // 
            // lblAllergies
            // 
            lblAllergies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAllergies.ForeColor = Color.FromArgb(55, 65, 81);
            lblAllergies.Location = new Point(20, 215);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(600, 22);
            lblAllergies.TabIndex = 12;
            lblAllergies.Text = "الحساسية (Allergies):";
            // 
            // txtAllergies
            // 
            txtAllergies.BackColor = Color.White;
            txtAllergies.BorderStyle = BorderStyle.FixedSingle;
            txtAllergies.Font = new Font("Segoe UI", 9.5F);
            txtAllergies.Location = new Point(20, 240);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.ReadOnly = true;
            txtAllergies.Size = new Size(600, 50);
            txtAllergies.TabIndex = 13;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedicalHistory.ForeColor = Color.FromArgb(55, 65, 81);
            lblMedicalHistory.Location = new Point(20, 300);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(600, 22);
            lblMedicalHistory.TabIndex = 14;
            lblMedicalHistory.Text = "التاريخ المرضي (Medical History):";
            // 
            // txtMedicalHistory
            // 
            txtMedicalHistory.BackColor = Color.White;
            txtMedicalHistory.BorderStyle = BorderStyle.FixedSingle;
            txtMedicalHistory.Font = new Font("Segoe UI", 9.5F);
            txtMedicalHistory.Location = new Point(20, 325);
            txtMedicalHistory.Multiline = true;
            txtMedicalHistory.Name = "txtMedicalHistory";
            txtMedicalHistory.ReadOnly = true;
            txtMedicalHistory.Size = new Size(600, 50);
            txtMedicalHistory.TabIndex = 15;
            // 
            // lblIsActiveSection
            // 
            lblIsActiveSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIsActiveSection.ForeColor = Color.FromArgb(55, 65, 81);
            lblIsActiveSection.Location = new Point(20, 385);
            lblIsActiveSection.Name = "lblIsActiveSection";
            lblIsActiveSection.Size = new Size(285, 22);
            lblIsActiveSection.TabIndex = 16;
            lblIsActiveSection.Text = "حالة المريض الجارية:";
            // 
            // chkIsActive
            // 
            chkIsActive.Enabled = false;
            chkIsActive.Font = new Font("Segoe UI", 9.5F);
            chkIsActive.Location = new Point(20, 410);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(285, 24);
            chkIsActive.TabIndex = 17;
            chkIsActive.Text = "مريض نشط ومفعّل في المنظومة";
            // 
            // frmShowPatientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(680, 640);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowPatientInfo";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بيانات المريض الحالية";
            
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            tcPatientDetails.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpPersonalInfo.PerformLayout();
            tpMedicalInfo.ResumeLayout(false);
            tpMedicalInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblFormTitle;
        private Panel pnlFooter;
        private Button btnClose;
        private Panel pnlBody;
        private TabControl tcPatientDetails;
        private TabPage tpPersonalInfo;
        private TabPage tpMedicalInfo;

        // Personal Fields (من PatientViewDTO المسطحة)
        private Label lblNationalNo;
        private TextBox txtNationalNo;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;

        // Medical & Emergency Fields
        private Label lblBloodType;
        private TextBox txtBloodType;
        private Label lblEmergencyContact;
        private TextBox txtEmergencyContact;
        private Label lblEmergencyPhone;
        private TextBox txtEmergencyPhone;
        private Label lblPatientId;
        private TextBox txtPatientId;
        private Label lblPersonId;
        private TextBox txtPersonId;
        private Label lblCreatedDate;
        private TextBox txtCreatedDate;
        private Label lblAllergies;
        private TextBox txtAllergies;
        private Label lblMedicalHistory;
        private TextBox txtMedicalHistory;
        private Label lblIsActiveSection;
        private CheckBox chkIsActive;
    }
}