using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmShowDoctorInfo : Form
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
            tcDoctorDetails = new TabControl();
            tpPersonalInfo = new TabPage();
            lblNationalNo = new Label();
            txtNationalNo = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblGender = new Label();
            txtGender = new TextBox();
            lblBirthDate = new Label();
            txtBirthDate = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tpProfessionalInfo = new TabPage();
            lblDoctorId = new Label();
            txtDoctorId = new TextBox();
            lblSpecialization = new Label();
            txtSpecialization = new TextBox();
            lblLicenseNo = new Label();
            txtLicenseNo = new TextBox();
            lblExperienceYears = new Label();
            txtExperienceYears = new TextBox();
            lblClinicRoom = new Label();
            txtClinicRoom = new TextBox();
            tpUserInfo = new TabPage();
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPermissions = new Label();
            txtPermissions = new TextBox();
            lblIsActiveSection = new Label();
            chkIsActive = new CheckBox();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            tcDoctorDetails.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpProfessionalInfo.SuspendLayout();
            tpUserInfo.SuspendLayout();
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
            lblFormTitle.Text = "الملف الكامل للطبيب";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 544);
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
            btnClose.Click += btnClose_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(tcDoctorDetails);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 60);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(15);
            pnlBody.Size = new Size(680, 484);
            pnlBody.TabIndex = 2;
            // 
            // tcDoctorDetails
            // 
            tcDoctorDetails.Controls.Add(tpPersonalInfo);
            tcDoctorDetails.Controls.Add(tpProfessionalInfo);
            tcDoctorDetails.Controls.Add(tpUserInfo);
            tcDoctorDetails.Dock = DockStyle.Fill;
            tcDoctorDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tcDoctorDetails.Location = new Point(15, 15);
            tcDoctorDetails.Name = "tcDoctorDetails";
            tcDoctorDetails.SelectedIndex = 0;
            tcDoctorDetails.Size = new Size(650, 454);
            tcDoctorDetails.TabIndex = 0;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.BackColor = Color.White;
            tpPersonalInfo.Controls.Add(lblNationalNo);
            tpPersonalInfo.Controls.Add(txtNationalNo);
            tpPersonalInfo.Controls.Add(lblFullName);
            tpPersonalInfo.Controls.Add(txtFullName);
            tpPersonalInfo.Controls.Add(lblGender);
            tpPersonalInfo.Controls.Add(txtGender);
            tpPersonalInfo.Controls.Add(lblBirthDate);
            tpPersonalInfo.Controls.Add(txtBirthDate);
            tpPersonalInfo.Controls.Add(lblPhone);
            tpPersonalInfo.Controls.Add(txtPhone);
            tpPersonalInfo.Controls.Add(lblEmail);
            tpPersonalInfo.Controls.Add(txtEmail);
            tpPersonalInfo.Controls.Add(lblAddress);
            tpPersonalInfo.Controls.Add(txtAddress);
            tpPersonalInfo.Location = new Point(4, 26);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(20);
            tpPersonalInfo.Size = new Size(642, 424);
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
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(55, 65, 81);
            lblGender.Location = new Point(335, 85);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(285, 22);
            lblGender.TabIndex = 4;
            lblGender.Text = "الجنس:";
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.White;
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Segoe UI", 9.5F);
            txtGender.Location = new Point(335, 110);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(285, 24);
            txtGender.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBirthDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblBirthDate.Location = new Point(20, 85);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(285, 22);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "تاريخ الميلاد:";
            // 
            // txtBirthDate
            // 
            txtBirthDate.BackColor = Color.White;
            txtBirthDate.BorderStyle = BorderStyle.FixedSingle;
            txtBirthDate.Font = new Font("Segoe UI", 9.5F);
            txtBirthDate.Location = new Point(20, 110);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.ReadOnly = true;
            txtBirthDate.Size = new Size(285, 24);
            txtBirthDate.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone.Location = new Point(335, 150);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(285, 22);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "رقم الهاتف:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 9.5F);
            txtPhone.Location = new Point(335, 175);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(285, 24);
            txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmail.Location = new Point(20, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(285, 22);
            lblEmail.TabIndex = 10;
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
            txtEmail.Size = new Size(285, 24);
            txtEmail.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(55, 65, 81);
            lblAddress.Location = new Point(20, 215);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(600, 22);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "العنوان:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(20, 240);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(600, 50);
            txtAddress.TabIndex = 13;
            // 
            // tpProfessionalInfo
            // 
            tpProfessionalInfo.BackColor = Color.White;
            tpProfessionalInfo.Controls.Add(lblDoctorId);
            tpProfessionalInfo.Controls.Add(txtDoctorId);
            tpProfessionalInfo.Controls.Add(lblSpecialization);
            tpProfessionalInfo.Controls.Add(txtSpecialization);
            tpProfessionalInfo.Controls.Add(lblLicenseNo);
            tpProfessionalInfo.Controls.Add(txtLicenseNo);
            tpProfessionalInfo.Controls.Add(lblExperienceYears);
            tpProfessionalInfo.Controls.Add(txtExperienceYears);
            tpProfessionalInfo.Controls.Add(lblClinicRoom);
            tpProfessionalInfo.Controls.Add(txtClinicRoom);
            tpProfessionalInfo.Location = new Point(4, 26);
            tpProfessionalInfo.Name = "tpProfessionalInfo";
            tpProfessionalInfo.Padding = new Padding(20);
            tpProfessionalInfo.Size = new Size(642, 424);
            tpProfessionalInfo.TabIndex = 1;
            tpProfessionalInfo.Text = "البيانات المهنية";
            // 
            // lblDoctorId
            // 
            lblDoctorId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoctorId.ForeColor = Color.FromArgb(55, 65, 81);
            lblDoctorId.Location = new Point(335, 20);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(285, 22);
            lblDoctorId.TabIndex = 0;
            lblDoctorId.Text = "كود الطبيب المتسلسل:";
            // 
            // txtDoctorId
            // 
            txtDoctorId.BackColor = Color.White;
            txtDoctorId.BorderStyle = BorderStyle.FixedSingle;
            txtDoctorId.Font = new Font("Segoe UI", 9.5F);
            txtDoctorId.Location = new Point(335, 45);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.ReadOnly = true;
            txtDoctorId.Size = new Size(285, 24);
            txtDoctorId.TabIndex = 1;
            // 
            // lblSpecialization
            // 
            lblSpecialization.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpecialization.ForeColor = Color.FromArgb(55, 65, 81);
            lblSpecialization.Location = new Point(20, 20);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(285, 22);
            lblSpecialization.TabIndex = 2;
            lblSpecialization.Text = "التخصص الطبي:";
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.White;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Font = new Font("Segoe UI", 9.5F);
            txtSpecialization.Location = new Point(20, 45);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.ReadOnly = true;
            txtSpecialization.Size = new Size(285, 24);
            txtSpecialization.TabIndex = 3;
            // 
            // lblLicenseNo
            // 
            lblLicenseNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLicenseNo.ForeColor = Color.FromArgb(55, 65, 81);
            lblLicenseNo.Location = new Point(335, 85);
            lblLicenseNo.Name = "lblLicenseNo";
            lblLicenseNo.Size = new Size(285, 22);
            lblLicenseNo.TabIndex = 4;
            lblLicenseNo.Text = "رقم ترخيص الممارسة:";
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.BackColor = Color.White;
            txtLicenseNo.BorderStyle = BorderStyle.FixedSingle;
            txtLicenseNo.Font = new Font("Segoe UI", 9.5F);
            txtLicenseNo.Location = new Point(335, 110);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.ReadOnly = true;
            txtLicenseNo.Size = new Size(285, 24);
            txtLicenseNo.TabIndex = 5;
            // 
            // lblExperienceYears
            // 
            lblExperienceYears.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExperienceYears.ForeColor = Color.FromArgb(55, 65, 81);
            lblExperienceYears.Location = new Point(20, 85);
            lblExperienceYears.Name = "lblExperienceYears";
            lblExperienceYears.Size = new Size(285, 22);
            lblExperienceYears.TabIndex = 6;
            lblExperienceYears.Text = "سنوات الخبرة:";
            // 
            // txtExperienceYears
            // 
            txtExperienceYears.BackColor = Color.White;
            txtExperienceYears.BorderStyle = BorderStyle.FixedSingle;
            txtExperienceYears.Font = new Font("Segoe UI", 9.5F);
            txtExperienceYears.Location = new Point(20, 110);
            txtExperienceYears.Name = "txtExperienceYears";
            txtExperienceYears.ReadOnly = true;
            txtExperienceYears.Size = new Size(285, 24);
            txtExperienceYears.TabIndex = 7;
            // 
            // lblClinicRoom
            // 
            lblClinicRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClinicRoom.ForeColor = Color.FromArgb(55, 65, 81);
            lblClinicRoom.Location = new Point(335, 150);
            lblClinicRoom.Name = "lblClinicRoom";
            lblClinicRoom.Size = new Size(285, 22);
            lblClinicRoom.TabIndex = 8;
            lblClinicRoom.Text = "رقم العيادة / المكتب:";
            // 
            // txtClinicRoom
            // 
            txtClinicRoom.BackColor = Color.White;
            txtClinicRoom.BorderStyle = BorderStyle.FixedSingle;
            txtClinicRoom.Font = new Font("Segoe UI", 9.5F);
            txtClinicRoom.Location = new Point(335, 175);
            txtClinicRoom.Name = "txtClinicRoom";
            txtClinicRoom.ReadOnly = true;
            txtClinicRoom.Size = new Size(285, 24);
            txtClinicRoom.TabIndex = 9;
            // 
            // tpUserInfo
            // 
            tpUserInfo.BackColor = Color.White;
            tpUserInfo.Controls.Add(lblUserId);
            tpUserInfo.Controls.Add(txtUserId);
            tpUserInfo.Controls.Add(lblUsername);
            tpUserInfo.Controls.Add(txtUsername);
            tpUserInfo.Controls.Add(lblPermissions);
            tpUserInfo.Controls.Add(txtPermissions);
            tpUserInfo.Controls.Add(lblIsActiveSection);
            tpUserInfo.Controls.Add(chkIsActive);
            tpUserInfo.Location = new Point(4, 26);
            tpUserInfo.Name = "tpUserInfo";
            tpUserInfo.Padding = new Padding(20);
            tpUserInfo.Size = new Size(642, 424);
            tpUserInfo.TabIndex = 2;
            tpUserInfo.Text = "حساب المستخدم";
            // 
            // lblUserId
            // 
            lblUserId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserId.ForeColor = Color.FromArgb(55, 65, 81);
            lblUserId.Location = new Point(335, 20);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(285, 22);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "معرف المستخدم (User ID):";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.White;
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI", 9.5F);
            txtUserId.Location = new Point(335, 45);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(285, 24);
            txtUserId.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(55, 65, 81);
            lblUsername.Location = new Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(285, 22);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "اسم المستخدم:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9.5F);
            txtUsername.Location = new Point(20, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(285, 24);
            txtUsername.TabIndex = 3;
            // 
            // lblPermissions
            // 
            lblPermissions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPermissions.ForeColor = Color.FromArgb(55, 65, 81);
            lblPermissions.Location = new Point(335, 85);
            lblPermissions.Name = "lblPermissions";
            lblPermissions.Size = new Size(285, 22);
            lblPermissions.TabIndex = 4;
            lblPermissions.Text = "الصلاحيات الممنوحة:";
            // 
            // txtPermissions
            // 
            txtPermissions.BackColor = Color.White;
            txtPermissions.BorderStyle = BorderStyle.FixedSingle;
            txtPermissions.Font = new Font("Segoe UI", 9.5F);
            txtPermissions.Location = new Point(335, 110);
            txtPermissions.Name = "txtPermissions";
            txtPermissions.ReadOnly = true;
            txtPermissions.Size = new Size(285, 24);
            txtPermissions.TabIndex = 5;
            // 
            // lblIsActiveSection
            // 
            lblIsActiveSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIsActiveSection.ForeColor = Color.FromArgb(55, 65, 81);
            lblIsActiveSection.Location = new Point(20, 85);
            lblIsActiveSection.Name = "lblIsActiveSection";
            lblIsActiveSection.Size = new Size(285, 22);
            lblIsActiveSection.TabIndex = 6;
            lblIsActiveSection.Text = "حالة الحساب الجارية:";
            // 
            // chkIsActive
            // 
            chkIsActive.Enabled = false;
            chkIsActive.Font = new Font("Segoe UI", 9.5F);
            chkIsActive.Location = new Point(20, 110);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(285, 24);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "الحساب نشط ومصرح له بالدخول";
            // 
            // frmShowDoctorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(680, 600);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowDoctorInfo";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بيانات الطبيب الحالية";
            Load += frmShowDoctorInfo_Load;
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            tcDoctorDetails.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpPersonalInfo.PerformLayout();
            tpProfessionalInfo.ResumeLayout(false);
            tpProfessionalInfo.PerformLayout();
            tpUserInfo.ResumeLayout(false);
            tpUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblFormTitle;
        private Panel pnlFooter;
        private Button btnClose;
        private Panel pnlBody;
        private TabControl tcDoctorDetails;
        private TabPage tpPersonalInfo;
        private TabPage tpProfessionalInfo;
        private TabPage tpUserInfo;

        // Personal Fields
        private Label lblNationalNo;
        private TextBox txtNationalNo;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblGender;
        private TextBox txtGender;
        private Label lblBirthDate;
        private TextBox txtBirthDate;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;

        // Professional Fields
        private Label lblDoctorId;
        private TextBox txtDoctorId;
        private Label lblSpecialization;
        private TextBox txtSpecialization;
        private Label lblLicenseNo;
        private TextBox txtLicenseNo;
        private Label lblExperienceYears;
        private TextBox txtExperienceYears;
        private Label lblClinicRoom;
        private TextBox txtClinicRoom;

        // User Fields
        private Label lblUserId;
        private TextBox txtUserId;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPermissions;
        private TextBox txtPermissions;
        private Label lblIsActiveSection;
        private CheckBox chkIsActive;
    }
}