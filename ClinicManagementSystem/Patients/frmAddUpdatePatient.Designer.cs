using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmAddUpdatePatient : Form
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
            tabControl = new TabControl();
            tpPersonalInfo = new TabPage();
            tlpPersonal = new TableLayoutPanel();
            lblFullName = new Label();
            pnlNameFields = new Panel();
            tlpNameFields = new TableLayoutPanel();
            txtFirstName = new TextBox();
            txtFatherName = new TextBox();
            txtGrandFatherName = new TextBox();
            txtLastName = new TextBox();
            lblNationalNo = new Label();
            txtNationalNo = new TextBox();
            lblGender = new Label();
            lblBloodType = new Label();
            cmbGender = new ComboBox();
            cmbBloodType = new ComboBox();
            lblBirthDate = new Label();
            dtpDateOfBirth = new DateTimePicker();
            tpContactInfo = new TabPage();
            tlpContact = new TableLayoutPanel();
            lblPhone1 = new Label();
            lblPhone2 = new Label();
            txtPhone1 = new TextBox();
            txtPhone2 = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmergencyName = new Label();
            lblEmergencyPhone = new Label();
            txtEmergencyName = new TextBox();
            txtEmergencyPhone = new TextBox();
            lblAddress = new Label();
            rtbAddress = new RichTextBox();
            pnlFooter = new Panel();
            tlpFooter = new TableLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            mainLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tabControl.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tlpPersonal.SuspendLayout();
            pnlNameFields.SuspendLayout();
            tlpNameFields.SuspendLayout();
            tpContactInfo.SuspendLayout();
            tlpContact.SuspendLayout();
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
            lblFormTitle.Text = "تسجيل مريض جديد";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(tabControl);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 63);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(15);
            pnlBody.Size = new Size(714, 518);
            pnlBody.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpPersonalInfo);
            tabControl.Controls.Add(tpContactInfo);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl.Location = new Point(15, 15);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(684, 488);
            tabControl.TabIndex = 0;
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
            tpPersonalInfo.Text = "البيانات الشخصية والأساسية";
            // 
            // tlpPersonal
            // 
            tlpPersonal.ColumnCount = 2;
            tlpPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPersonal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPersonal.Controls.Add(lblFullName, 0, 0);
            tlpPersonal.Controls.Add(pnlNameFields, 0, 1);
            tlpPersonal.Controls.Add(lblNationalNo, 0, 2);
            tlpPersonal.Controls.Add(txtNationalNo, 0, 3);
            tlpPersonal.Controls.Add(lblGender, 0, 4);
            tlpPersonal.Controls.Add(lblBloodType, 1, 4);
            tlpPersonal.Controls.Add(cmbGender, 0, 5);
            tlpPersonal.Controls.Add(cmbBloodType, 1, 5);
            tlpPersonal.Controls.Add(lblBirthDate, 0, 6);
            tlpPersonal.Controls.Add(dtpDateOfBirth, 0, 7);
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
            lblFullName.TabIndex = 0;
            lblFullName.Text = "الاسم الرباعي (الأول — الأب — الجد — اللقب):";
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
            pnlNameFields.TabIndex = 1;
            // 
            // tlpNameFields
            // 
            tlpNameFields.ColumnCount = 4;
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.4285717F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.015873F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2857151F));
            tlpNameFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            tlpNameFields.Controls.Add(txtFirstName, 0, 0);
            tlpNameFields.Controls.Add(txtFatherName, 1, 0);
            tlpNameFields.Controls.Add(txtGrandFatherName, 2, 0);
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
            txtFirstName.TabIndex = 1;
            // 
            // txtFatherName
            // 
            txtFatherName.BorderStyle = BorderStyle.FixedSingle;
            txtFatherName.Dock = DockStyle.Fill;
            txtFatherName.Font = new Font("Segoe UI", 9.5F);
            txtFatherName.Location = new Point(290, 3);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.PlaceholderText = "الأب";
            txtFatherName.Size = new Size(139, 24);
            txtFatherName.TabIndex = 2;
            // 
            // txtGrandFatherName
            // 
            txtGrandFatherName.BorderStyle = BorderStyle.FixedSingle;
            txtGrandFatherName.Dock = DockStyle.Fill;
            txtGrandFatherName.Font = new Font("Segoe UI", 9.5F);
            txtGrandFatherName.Location = new Point(137, 3);
            txtGrandFatherName.Name = "txtGrandFatherName";
            txtGrandFatherName.PlaceholderText = "الجد";
            txtGrandFatherName.Size = new Size(147, 24);
            txtGrandFatherName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(3, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "اللقب";
            txtLastName.Size = new Size(128, 24);
            txtLastName.TabIndex = 4;
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
            lblNationalNo.TabIndex = 2;
            lblNationalNo.Text = "الرقم القومي / الهوية:";
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
            txtNationalNo.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.Dock = DockStyle.Fill;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(55, 65, 81);
            lblGender.Location = new Point(331, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(312, 26);
            lblGender.TabIndex = 4;
            lblGender.Text = "الجنس:";
            lblGender.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblBloodType
            // 
            lblBloodType.Dock = DockStyle.Fill;
            lblBloodType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBloodType.ForeColor = Color.FromArgb(55, 65, 81);
            lblBloodType.Location = new Point(13, 130);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(312, 26);
            lblBloodType.TabIndex = 5;
            lblBloodType.Text = "فصيلة الدم:";
            lblBloodType.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbGender
            // 
            cmbGender.Dock = DockStyle.Fill;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 9.5F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.Location = new Point(331, 159);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(312, 25);
            cmbGender.TabIndex = 6;
            // 
            // cmbBloodType
            // 
            cmbBloodType.Dock = DockStyle.Fill;
            cmbBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodType.Font = new Font("Segoe UI", 9.5F);
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "غير معروف" });
            cmbBloodType.Location = new Point(13, 159);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(312, 25);
            cmbBloodType.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            tlpPersonal.SetColumnSpan(lblBirthDate, 2);
            lblBirthDate.Dock = DockStyle.Fill;
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBirthDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblBirthDate.Location = new Point(13, 190);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(630, 26);
            lblBirthDate.TabIndex = 8;
            lblBirthDate.Text = "تاريخ الميلاد:";
            lblBirthDate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpDateOfBirth
            // 
            tlpPersonal.SetColumnSpan(dtpDateOfBirth, 2);
            dtpDateOfBirth.Dock = DockStyle.Fill;
            dtpDateOfBirth.Font = new Font("Segoe UI", 9.5F);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(13, 219);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(630, 24);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // tpContactInfo
            // 
            tpContactInfo.BackColor = Color.White;
            tpContactInfo.Controls.Add(tlpContact);
            tpContactInfo.Location = new Point(4, 26);
            tpContactInfo.Name = "tpContactInfo";
            tpContactInfo.Padding = new Padding(10);
            tpContactInfo.Size = new Size(676, 458);
            tpContactInfo.TabIndex = 1;
            tpContactInfo.Text = "معلومات الاتصال والطوارئ";
            // 
            // tlpContact
            // 
            tlpContact.ColumnCount = 2;
            tlpContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContact.Controls.Add(lblPhone1, 0, 0);
            tlpContact.Controls.Add(lblPhone2, 1, 0);
            tlpContact.Controls.Add(txtPhone1, 0, 1);
            tlpContact.Controls.Add(txtPhone2, 1, 1);
            tlpContact.Controls.Add(lblEmail, 0, 2);
            tlpContact.Controls.Add(txtEmail, 0, 3);
            tlpContact.Controls.Add(lblEmergencyName, 0, 4);
            tlpContact.Controls.Add(lblEmergencyPhone, 1, 4);
            tlpContact.Controls.Add(txtEmergencyName, 0, 5);
            tlpContact.Controls.Add(txtEmergencyPhone, 1, 5);
            tlpContact.Controls.Add(lblAddress, 0, 6);
            tlpContact.Controls.Add(rtbAddress, 0, 7);
            tlpContact.Dock = DockStyle.Fill;
            tlpContact.Location = new Point(10, 10);
            tlpContact.Name = "tlpContact";
            tlpContact.Padding = new Padding(10);
            tlpContact.RowCount = 8;
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContact.Size = new Size(656, 438);
            tlpContact.TabIndex = 0;
            // 
            // lblPhone1
            // 
            lblPhone1.Dock = DockStyle.Fill;
            lblPhone1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone1.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone1.Location = new Point(331, 10);
            lblPhone1.Name = "lblPhone1";
            lblPhone1.Size = new Size(312, 26);
            lblPhone1.TabIndex = 0;
            lblPhone1.Text = "رقم الهاتف الأول:";
            lblPhone1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPhone2
            // 
            lblPhone2.Dock = DockStyle.Fill;
            lblPhone2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone2.ForeColor = Color.FromArgb(55, 65, 81);
            lblPhone2.Location = new Point(13, 10);
            lblPhone2.Name = "lblPhone2";
            lblPhone2.Size = new Size(312, 26);
            lblPhone2.TabIndex = 1;
            lblPhone2.Text = "رقم الهاتف الثاني:";
            lblPhone2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPhone1
            // 
            txtPhone1.BorderStyle = BorderStyle.FixedSingle;
            txtPhone1.Dock = DockStyle.Fill;
            txtPhone1.Font = new Font("Segoe UI", 9.5F);
            txtPhone1.Location = new Point(331, 39);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(312, 24);
            txtPhone1.TabIndex = 2;
            // 
            // txtPhone2
            // 
            txtPhone2.BorderStyle = BorderStyle.FixedSingle;
            txtPhone2.Dock = DockStyle.Fill;
            txtPhone2.Font = new Font("Segoe UI", 9.5F);
            txtPhone2.Location = new Point(13, 39);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(312, 24);
            txtPhone2.TabIndex = 3;
            // 
            // lblEmail
            // 
            tlpContact.SetColumnSpan(lblEmail, 2);
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmail.Location = new Point(13, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(630, 26);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "البريد الإلكتروني:";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            tlpContact.SetColumnSpan(txtEmail, 2);
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(13, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(630, 24);
            txtEmail.TabIndex = 5;
            // 
            // lblEmergencyName
            // 
            lblEmergencyName.Dock = DockStyle.Fill;
            lblEmergencyName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmergencyName.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmergencyName.Location = new Point(331, 130);
            lblEmergencyName.Name = "lblEmergencyName";
            lblEmergencyName.Size = new Size(312, 26);
            lblEmergencyName.TabIndex = 6;
            lblEmergencyName.Text = "اسم شخص للطوارئ:";
            lblEmergencyName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.Dock = DockStyle.Fill;
            lblEmergencyPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmergencyPhone.ForeColor = Color.FromArgb(55, 65, 81);
            lblEmergencyPhone.Location = new Point(13, 130);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(312, 26);
            lblEmergencyPhone.TabIndex = 7;
            lblEmergencyPhone.Text = "رقم هاتف شخص الطوارئ:";
            lblEmergencyPhone.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyName.Dock = DockStyle.Fill;
            txtEmergencyName.Font = new Font("Segoe UI", 9.5F);
            txtEmergencyName.Location = new Point(331, 159);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(312, 24);
            txtEmergencyName.TabIndex = 8;
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyPhone.Dock = DockStyle.Fill;
            txtEmergencyPhone.Font = new Font("Segoe UI", 9.5F);
            txtEmergencyPhone.Location = new Point(13, 159);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(312, 24);
            txtEmergencyPhone.TabIndex = 9;
            // 
            // lblAddress
            // 
            tlpContact.SetColumnSpan(lblAddress, 2);
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(55, 65, 81);
            lblAddress.Location = new Point(13, 190);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(630, 26);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "العنوان:";
            lblAddress.TextAlign = ContentAlignment.BottomLeft;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            tlpContact.SetColumnSpan(rtbAddress, 2);
            rtbAddress.Dock = DockStyle.Fill;
            rtbAddress.Font = new Font("Segoe UI", 9.5F);
            rtbAddress.Location = new Point(13, 219);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(630, 206);
            rtbAddress.TabIndex = 11;
            rtbAddress.Text = "";
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
            tlpFooter.ColumnCount = 3;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooter.Controls.Add(btnCancel, 0, 0);
            tlpFooter.Controls.Add(btnSave, 1, 0);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(0, 0);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.Padding = new Padding(5);
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooter.Size = new Size(714, 50);
            tlpFooter.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(156, 163, 175);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(562, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 38, 53);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 52, 70);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(412, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ بيانات المريض";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // frmAddUpdatePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(720, 640);
            Controls.Add(mainLayout);
            MinimumSize = new Size(580, 520);
            Name = "frmAddUpdatePatient";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل مريض جديد";
            WindowState = FormWindowState.Maximized;
            mainLayout.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tlpPersonal.ResumeLayout(false);
            tlpPersonal.PerformLayout();
            pnlNameFields.ResumeLayout(false);
            tlpNameFields.ResumeLayout(false);
            tlpNameFields.PerformLayout();
            tpContactInfo.ResumeLayout(false);
            tlpContact.ResumeLayout(false);
            tlpContact.PerformLayout();
            pnlFooter.ResumeLayout(false);
            tlpFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ─── Layout ───────────────────────────────────────────────────────────
        private TableLayoutPanel mainLayout;

        // ─── Panels ───────────────────────────────────────────────────────────
        private Panel pnlHeader;
        private Panel pnlFooter;
        private Panel pnlBody;
        private Panel pnlNameFields;

        // ─── Labels ───────────────────────────────────────────────────────────
        private Label lblFormTitle;

        // ─── Tabs ─────────────────────────────────────────────────────────────
        private TabControl tabControl;
        private TabPage tpPersonalInfo;
        private TabPage tpContactInfo;

        // ─── Tab Layout Panels ────────────────────────────────────────────────
        private TableLayoutPanel tlpPersonal;
        private TableLayoutPanel tlpNameFields;
        private TableLayoutPanel tlpContact;
        private TableLayoutPanel tlpFooter;

        // ─── Buttons ──────────────────────────────────────────────────────────
        private Button btnSave;
        private Button btnCancel;

        // ─── Personal Fields ──────────────────────────────────────────────────
        private Label lblFullName;
        private TextBox txtFirstName;
        private TextBox txtFatherName;
        private TextBox txtGrandFatherName;
        private TextBox txtLastName;
        private Label lblNationalNo;
        private TextBox txtNationalNo;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblBloodType;
        private ComboBox cmbBloodType;
        private Label lblBirthDate;
        private DateTimePicker dtpDateOfBirth;

        // ─── Contact & Emergency Fields ───────────────────────────────────────
        private Label lblPhone1;
        private TextBox txtPhone1;
        private Label lblPhone2;
        private TextBox txtPhone2;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmergencyName;
        private TextBox txtEmergencyName;
        private Label lblEmergencyPhone;
        private TextBox txtEmergencyPhone;
        private Label lblAddress;
        private RichTextBox rtbAddress;
    }
}