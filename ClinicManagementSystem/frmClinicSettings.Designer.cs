using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmClinicSettings : Form
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
            tabControl = new TabControl();
            tabGeneral = new TabPage();
            tlpGeneralRoot = new TableLayoutPanel();
            tlpGeneralFields = new TableLayoutPanel();
            lblClinicNameAr = new Label();
            lblClinicNameEn = new Label();
            txtClinicNameAr = new TextBox();
            txtClinicNameEn = new TextBox();
            lblTaxNumber = new Label();
            txtTaxNumber = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            pnlLogoArea = new TableLayoutPanel();
            lblLogoCaption = new Label();
            picLogo = new PictureBox();
            flpLogoButtons = new FlowLayoutPanel();
            btnUploadLogo = new Button();
            btnRemoveLogo = new Button();
            tabContact = new TabPage();
            tlpContact = new TableLayoutPanel();
            lblPhone1 = new Label();
            lblPhone2 = new Label();
            txtPhone1 = new TextBox();
            txtPhone2 = new TextBox();
            lblEmail = new Label();
            lblWebsite = new Label();
            txtEmail = new TextBox();
            txtWebsite = new TextBox();
            tabScheduling = new TabPage();
            tlpSchedulingRoot = new TableLayoutPanel();
            tlpSchedulingFields = new TableLayoutPanel();
            lblAppointmentDuration = new Label();
            numAppointmentDuration = new NumericUpDown();
            lblWorkStart = new Label();
            dtpWorkStart = new DateTimePicker();
            lblWorkEnd = new Label();
            dtpWorkEnd = new DateTimePicker();
            pnlHolidaysArea = new TableLayoutPanel();
            lblHolidaysCaption = new Label();
            clbWeeklyHolidays = new CheckedListBox();
            tabFinancial = new TabPage();
            tlpFinancialRoot = new TableLayoutPanel();
            lblDefaultCurrency = new Label();
            lblTaxPercentage = new Label();
            cmbDefaultCurrency = new ComboBox();
            numTaxPercentage = new NumericUpDown();
            lblInvoiceNotes = new Label();
            txtInvoiceNotes = new TextBox();
            pnlFooter = new Panel();
            flpFooterButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            ofdLogo = new OpenFileDialog();
            AdvancedSettings = new LinkLabel();
            panel1 = new Panel();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabGeneral.SuspendLayout();
            tlpGeneralRoot.SuspendLayout();
            tlpGeneralFields.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            flpLogoButtons.SuspendLayout();
            tabContact.SuspendLayout();
            tlpContact.SuspendLayout();
            tabScheduling.SuspendLayout();
            tlpSchedulingRoot.SuspendLayout();
            tlpSchedulingFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAppointmentDuration).BeginInit();
            pnlHolidaysArea.SuspendLayout();
            tabFinancial.SuspendLayout();
            tlpFinancialRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTaxPercentage).BeginInit();
            pnlFooter.SuspendLayout();
            flpFooterButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 37, 51);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(1040, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "⚙️ إعدادات العيادة العامة";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGeneral);
            tabControl.Controls.Add(tabContact);
            tabControl.Controls.Add(tabScheduling);
            tabControl.Controls.Add(tabFinancial);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControl.ItemSize = new Size(190, 42);
            tabControl.Location = new Point(0, 60);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(12, 6);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1040, 596);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 1;
            // 
            // tabGeneral
            // 
            tabGeneral.BackColor = Color.FromArgb(244, 247, 250);
            tabGeneral.Controls.Add(tlpGeneralRoot);
            tabGeneral.Controls.Add(panel1);
            tabGeneral.Location = new Point(4, 46);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(20);
            tabGeneral.Size = new Size(1032, 546);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "البيانات العامة";
            // 
            // tlpGeneralRoot
            // 
            tlpGeneralRoot.ColumnCount = 2;
            tlpGeneralRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tlpGeneralRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpGeneralRoot.Controls.Add(tlpGeneralFields, 0, 0);
            tlpGeneralRoot.Controls.Add(pnlLogoArea, 1, 0);
            tlpGeneralRoot.Dock = DockStyle.Fill;
            tlpGeneralRoot.Location = new Point(20, 20);
            tlpGeneralRoot.Name = "tlpGeneralRoot";
            tlpGeneralRoot.RowCount = 1;
            tlpGeneralRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGeneralRoot.Size = new Size(992, 506);
            tlpGeneralRoot.TabIndex = 0;
            // 
            // tlpGeneralFields
            // 
            tlpGeneralFields.ColumnCount = 2;
            tlpGeneralFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpGeneralFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpGeneralFields.Controls.Add(lblClinicNameAr, 0, 0);
            tlpGeneralFields.Controls.Add(lblClinicNameEn, 1, 0);
            tlpGeneralFields.Controls.Add(txtClinicNameAr, 0, 1);
            tlpGeneralFields.Controls.Add(txtClinicNameEn, 1, 1);
            tlpGeneralFields.Controls.Add(lblTaxNumber, 0, 2);
            tlpGeneralFields.Controls.Add(txtTaxNumber, 0, 3);
            tlpGeneralFields.Controls.Add(lblAddress, 0, 4);
            tlpGeneralFields.Controls.Add(txtAddress, 0, 5);
            tlpGeneralFields.Dock = DockStyle.Fill;
            tlpGeneralFields.Location = new Point(333, 3);
            tlpGeneralFields.Margin = new Padding(3, 3, 15, 3);
            tlpGeneralFields.Name = "tlpGeneralFields";
            tlpGeneralFields.RowCount = 6;
            tlpGeneralFields.RowStyles.Add(new RowStyle());
            tlpGeneralFields.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpGeneralFields.RowStyles.Add(new RowStyle());
            tlpGeneralFields.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpGeneralFields.RowStyles.Add(new RowStyle());
            tlpGeneralFields.RowStyles.Add(new RowStyle(SizeType.Percent, 46F));
            tlpGeneralFields.Size = new Size(656, 500);
            tlpGeneralFields.TabIndex = 0;
            // 
            // lblClinicNameAr
            // 
            lblClinicNameAr.Dock = DockStyle.Fill;
            lblClinicNameAr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClinicNameAr.ForeColor = Color.FromArgb(100, 110, 120);
            lblClinicNameAr.Location = new Point(334, 3);
            lblClinicNameAr.Margin = new Padding(6, 3, 6, 2);
            lblClinicNameAr.Name = "lblClinicNameAr";
            lblClinicNameAr.Size = new Size(316, 22);
            lblClinicNameAr.TabIndex = 0;
            lblClinicNameAr.Text = "اسم العيادة (بالعربية):";
            lblClinicNameAr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClinicNameEn
            // 
            lblClinicNameEn.Dock = DockStyle.Fill;
            lblClinicNameEn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClinicNameEn.ForeColor = Color.FromArgb(100, 110, 120);
            lblClinicNameEn.Location = new Point(6, 3);
            lblClinicNameEn.Margin = new Padding(6, 3, 6, 2);
            lblClinicNameEn.Name = "lblClinicNameEn";
            lblClinicNameEn.Size = new Size(316, 22);
            lblClinicNameEn.TabIndex = 2;
            lblClinicNameEn.Text = "اسم العيادة (بالإنجليزية):";
            lblClinicNameEn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClinicNameAr
            // 
            txtClinicNameAr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClinicNameAr.BackColor = Color.FromArgb(233, 236, 239);
            txtClinicNameAr.BorderStyle = BorderStyle.FixedSingle;
            txtClinicNameAr.Font = new Font("Segoe UI", 10F);
            txtClinicNameAr.ForeColor = Color.FromArgb(33, 37, 41);
            txtClinicNameAr.Location = new Point(334, 29);
            txtClinicNameAr.Margin = new Padding(6, 2, 6, 8);
            txtClinicNameAr.Name = "txtClinicNameAr";
            txtClinicNameAr.Size = new Size(316, 25);
            txtClinicNameAr.TabIndex = 1;
            // 
            // txtClinicNameEn
            // 
            txtClinicNameEn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClinicNameEn.BackColor = Color.FromArgb(233, 236, 239);
            txtClinicNameEn.BorderStyle = BorderStyle.FixedSingle;
            txtClinicNameEn.Font = new Font("Segoe UI", 10F);
            txtClinicNameEn.ForeColor = Color.FromArgb(33, 37, 41);
            txtClinicNameEn.Location = new Point(6, 29);
            txtClinicNameEn.Margin = new Padding(6, 2, 6, 8);
            txtClinicNameEn.Name = "txtClinicNameEn";
            txtClinicNameEn.RightToLeft = RightToLeft.No;
            txtClinicNameEn.Size = new Size(316, 25);
            txtClinicNameEn.TabIndex = 3;
            // 
            // lblTaxNumber
            // 
            lblTaxNumber.Dock = DockStyle.Fill;
            lblTaxNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaxNumber.ForeColor = Color.FromArgb(100, 110, 120);
            lblTaxNumber.Location = new Point(334, 118);
            lblTaxNumber.Margin = new Padding(6, 8, 6, 2);
            lblTaxNumber.Name = "lblTaxNumber";
            lblTaxNumber.Size = new Size(316, 22);
            lblTaxNumber.TabIndex = 4;
            lblTaxNumber.Text = "الرقم الضريبي:";
            lblTaxNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTaxNumber.BackColor = Color.FromArgb(233, 236, 239);
            txtTaxNumber.BorderStyle = BorderStyle.FixedSingle;
            txtTaxNumber.Font = new Font("Segoe UI", 10F);
            txtTaxNumber.ForeColor = Color.FromArgb(33, 37, 41);
            txtTaxNumber.Location = new Point(334, 144);
            txtTaxNumber.Margin = new Padding(6, 2, 6, 8);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.Size = new Size(316, 25);
            txtTaxNumber.TabIndex = 5;
            // 
            // lblAddress
            // 
            tlpGeneralFields.SetColumnSpan(lblAddress, 2);
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(100, 110, 120);
            lblAddress.Location = new Point(6, 233);
            lblAddress.Margin = new Padding(6, 8, 6, 2);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(644, 22);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "عنوان العيادة:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.FromArgb(233, 236, 239);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            tlpGeneralFields.SetColumnSpan(txtAddress, 2);
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.ForeColor = Color.FromArgb(33, 37, 41);
            txtAddress.Location = new Point(6, 259);
            txtAddress.Margin = new Padding(6, 2, 6, 6);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(644, 235);
            txtAddress.TabIndex = 7;
            // 
            // pnlLogoArea
            // 
            pnlLogoArea.BackColor = Color.White;
            pnlLogoArea.BorderStyle = BorderStyle.FixedSingle;
            pnlLogoArea.ColumnCount = 1;
            pnlLogoArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLogoArea.Controls.Add(lblLogoCaption, 0, 0);
            pnlLogoArea.Controls.Add(picLogo, 0, 1);
            pnlLogoArea.Controls.Add(flpLogoButtons, 0, 2);
            pnlLogoArea.Dock = DockStyle.Fill;
            pnlLogoArea.Location = new Point(3, 3);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Padding = new Padding(15);
            pnlLogoArea.RowCount = 3;
            pnlLogoArea.RowStyles.Add(new RowStyle());
            pnlLogoArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLogoArea.RowStyles.Add(new RowStyle());
            pnlLogoArea.Size = new Size(312, 500);
            pnlLogoArea.TabIndex = 1;
            // 
            // lblLogoCaption
            // 
            lblLogoCaption.Dock = DockStyle.Fill;
            lblLogoCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogoCaption.ForeColor = Color.FromArgb(26, 37, 51);
            lblLogoCaption.Location = new Point(18, 15);
            lblLogoCaption.Margin = new Padding(3, 0, 3, 10);
            lblLogoCaption.Name = "lblLogoCaption";
            lblLogoCaption.Size = new Size(274, 24);
            lblLogoCaption.TabIndex = 0;
            lblLogoCaption.Text = "شعار العيادة";
            lblLogoCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(249, 250, 251);
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(18, 49);
            picLogo.Margin = new Padding(3, 0, 3, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(274, 378);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // flpLogoButtons
            // 
            flpLogoButtons.Anchor = AnchorStyles.None;
            flpLogoButtons.AutoSize = true;
            flpLogoButtons.Controls.Add(btnUploadLogo);
            flpLogoButtons.Controls.Add(btnRemoveLogo);
            flpLogoButtons.Location = new Point(48, 440);
            flpLogoButtons.Name = "flpLogoButtons";
            flpLogoButtons.Size = new Size(214, 40);
            flpLogoButtons.TabIndex = 2;
            // 
            // btnUploadLogo
            // 
            btnUploadLogo.BackColor = Color.FromArgb(52, 152, 219);
            btnUploadLogo.FlatAppearance.BorderSize = 0;
            btnUploadLogo.FlatStyle = FlatStyle.Flat;
            btnUploadLogo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUploadLogo.ForeColor = Color.White;
            btnUploadLogo.Location = new Point(113, 3);
            btnUploadLogo.Margin = new Padding(3, 3, 6, 3);
            btnUploadLogo.Name = "btnUploadLogo";
            btnUploadLogo.Size = new Size(98, 34);
            btnUploadLogo.TabIndex = 0;
            btnUploadLogo.Text = "⬆️ رفع";
            btnUploadLogo.UseVisualStyleBackColor = false;
            // 
            // btnRemoveLogo
            // 
            btnRemoveLogo.BackColor = Color.FromArgb(231, 76, 60);
            btnRemoveLogo.FlatAppearance.BorderSize = 0;
            btnRemoveLogo.FlatStyle = FlatStyle.Flat;
            btnRemoveLogo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveLogo.ForeColor = Color.White;
            btnRemoveLogo.Location = new Point(3, 3);
            btnRemoveLogo.Margin = new Padding(6, 3, 3, 3);
            btnRemoveLogo.Name = "btnRemoveLogo";
            btnRemoveLogo.Size = new Size(98, 34);
            btnRemoveLogo.TabIndex = 1;
            btnRemoveLogo.Text = "🗑️ حذف";
            btnRemoveLogo.UseVisualStyleBackColor = false;
            btnRemoveLogo.Click += btnRemoveLogo_Click_1;
            // 
            // tabContact
            // 
            tabContact.BackColor = Color.FromArgb(244, 247, 250);
            tabContact.Controls.Add(tlpContact);
            tabContact.Location = new Point(4, 46);
            tabContact.Name = "tabContact";
            tabContact.Padding = new Padding(20);
            tabContact.Size = new Size(1032, 546);
            tabContact.TabIndex = 1;
            tabContact.Text = "بيانات الاتصال";
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
            tlpContact.Controls.Add(lblWebsite, 1, 2);
            tlpContact.Controls.Add(txtEmail, 0, 3);
            tlpContact.Controls.Add(txtWebsite, 1, 3);
            tlpContact.Dock = DockStyle.Fill;
            tlpContact.Location = new Point(20, 20);
            tlpContact.Name = "tlpContact";
            tlpContact.RowCount = 4;
            tlpContact.RowStyles.Add(new RowStyle());
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContact.RowStyles.Add(new RowStyle());
            tlpContact.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContact.Size = new Size(992, 506);
            tlpContact.TabIndex = 0;
            // 
            // lblPhone1
            // 
            lblPhone1.Dock = DockStyle.Fill;
            lblPhone1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone1.ForeColor = Color.FromArgb(100, 110, 120);
            lblPhone1.Location = new Point(502, 3);
            lblPhone1.Margin = new Padding(6, 3, 6, 2);
            lblPhone1.Name = "lblPhone1";
            lblPhone1.Size = new Size(484, 22);
            lblPhone1.TabIndex = 0;
            lblPhone1.Text = "رقم الهاتف الأول:";
            lblPhone1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone2
            // 
            lblPhone2.Dock = DockStyle.Fill;
            lblPhone2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone2.ForeColor = Color.FromArgb(100, 110, 120);
            lblPhone2.Location = new Point(6, 3);
            lblPhone2.Margin = new Padding(6, 3, 6, 2);
            lblPhone2.Name = "lblPhone2";
            lblPhone2.Size = new Size(484, 22);
            lblPhone2.TabIndex = 2;
            lblPhone2.Text = "رقم الهاتف الثاني:";
            lblPhone2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone1
            // 
            txtPhone1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone1.BackColor = Color.FromArgb(233, 236, 239);
            txtPhone1.BorderStyle = BorderStyle.FixedSingle;
            txtPhone1.Font = new Font("Segoe UI", 10F);
            txtPhone1.ForeColor = Color.FromArgb(33, 37, 41);
            txtPhone1.Location = new Point(502, 29);
            txtPhone1.Margin = new Padding(6, 2, 6, 8);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(484, 25);
            txtPhone1.TabIndex = 1;
            // 
            // txtPhone2
            // 
            txtPhone2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone2.BackColor = Color.FromArgb(233, 236, 239);
            txtPhone2.BorderStyle = BorderStyle.FixedSingle;
            txtPhone2.Font = new Font("Segoe UI", 10F);
            txtPhone2.ForeColor = Color.FromArgb(33, 37, 41);
            txtPhone2.Location = new Point(6, 29);
            txtPhone2.Margin = new Padding(6, 2, 6, 8);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(484, 25);
            txtPhone2.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(100, 110, 120);
            lblEmail.Location = new Point(502, 258);
            lblEmail.Margin = new Padding(6, 8, 6, 2);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(484, 22);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "البريد الإلكتروني:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWebsite
            // 
            lblWebsite.Dock = DockStyle.Fill;
            lblWebsite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWebsite.ForeColor = Color.FromArgb(100, 110, 120);
            lblWebsite.Location = new Point(6, 258);
            lblWebsite.Margin = new Padding(6, 8, 6, 2);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(484, 22);
            lblWebsite.TabIndex = 6;
            lblWebsite.Text = "الموقع الإلكتروني:";
            lblWebsite.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(233, 236, 239);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(33, 37, 41);
            txtEmail.Location = new Point(502, 284);
            txtEmail.Margin = new Padding(6, 2, 6, 8);
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(484, 25);
            txtEmail.TabIndex = 5;
            // 
            // txtWebsite
            // 
            txtWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWebsite.BackColor = Color.FromArgb(233, 236, 239);
            txtWebsite.BorderStyle = BorderStyle.FixedSingle;
            txtWebsite.Font = new Font("Segoe UI", 10F);
            txtWebsite.ForeColor = Color.FromArgb(33, 37, 41);
            txtWebsite.Location = new Point(6, 284);
            txtWebsite.Margin = new Padding(6, 2, 6, 8);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.RightToLeft = RightToLeft.No;
            txtWebsite.Size = new Size(484, 25);
            txtWebsite.TabIndex = 7;
            // 
            // tabScheduling
            // 
            tabScheduling.BackColor = Color.FromArgb(244, 247, 250);
            tabScheduling.Controls.Add(tlpSchedulingRoot);
            tabScheduling.Location = new Point(4, 46);
            tabScheduling.Name = "tabScheduling";
            tabScheduling.Padding = new Padding(20);
            tabScheduling.Size = new Size(1032, 546);
            tabScheduling.TabIndex = 2;
            tabScheduling.Text = "جدولة المواعيد";
            // 
            // tlpSchedulingRoot
            // 
            tlpSchedulingRoot.ColumnCount = 2;
            tlpSchedulingRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpSchedulingRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpSchedulingRoot.Controls.Add(tlpSchedulingFields, 0, 0);
            tlpSchedulingRoot.Controls.Add(pnlHolidaysArea, 1, 0);
            tlpSchedulingRoot.Dock = DockStyle.Fill;
            tlpSchedulingRoot.Location = new Point(20, 20);
            tlpSchedulingRoot.Name = "tlpSchedulingRoot";
            tlpSchedulingRoot.RowCount = 1;
            tlpSchedulingRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSchedulingRoot.Size = new Size(992, 506);
            tlpSchedulingRoot.TabIndex = 0;
            // 
            // tlpSchedulingFields
            // 
            tlpSchedulingFields.ColumnCount = 1;
            tlpSchedulingFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSchedulingFields.Controls.Add(lblAppointmentDuration, 0, 0);
            tlpSchedulingFields.Controls.Add(numAppointmentDuration, 0, 1);
            tlpSchedulingFields.Controls.Add(lblWorkStart, 0, 2);
            tlpSchedulingFields.Controls.Add(dtpWorkStart, 0, 3);
            tlpSchedulingFields.Controls.Add(lblWorkEnd, 0, 4);
            tlpSchedulingFields.Controls.Add(dtpWorkEnd, 0, 5);
            tlpSchedulingFields.Dock = DockStyle.Fill;
            tlpSchedulingFields.Location = new Point(462, 3);
            tlpSchedulingFields.Margin = new Padding(3, 3, 15, 3);
            tlpSchedulingFields.Name = "tlpSchedulingFields";
            tlpSchedulingFields.RowCount = 6;
            tlpSchedulingFields.RowStyles.Add(new RowStyle());
            tlpSchedulingFields.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tlpSchedulingFields.RowStyles.Add(new RowStyle());
            tlpSchedulingFields.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tlpSchedulingFields.RowStyles.Add(new RowStyle());
            tlpSchedulingFields.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tlpSchedulingFields.Size = new Size(527, 500);
            tlpSchedulingFields.TabIndex = 0;
            // 
            // lblAppointmentDuration
            // 
            lblAppointmentDuration.Dock = DockStyle.Fill;
            lblAppointmentDuration.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAppointmentDuration.ForeColor = Color.FromArgb(100, 110, 120);
            lblAppointmentDuration.Location = new Point(6, 3);
            lblAppointmentDuration.Margin = new Padding(6, 3, 6, 2);
            lblAppointmentDuration.Name = "lblAppointmentDuration";
            lblAppointmentDuration.Size = new Size(515, 22);
            lblAppointmentDuration.TabIndex = 0;
            lblAppointmentDuration.Text = "مدة الموعد الواحد (بالدقائق):";
            lblAppointmentDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numAppointmentDuration
            // 
            numAppointmentDuration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numAppointmentDuration.Font = new Font("Segoe UI", 10F);
            numAppointmentDuration.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numAppointmentDuration.Location = new Point(6, 29);
            numAppointmentDuration.Margin = new Padding(6, 2, 6, 8);
            numAppointmentDuration.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            numAppointmentDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numAppointmentDuration.Name = "numAppointmentDuration";
            numAppointmentDuration.Size = new Size(515, 25);
            numAppointmentDuration.TabIndex = 1;
            numAppointmentDuration.TextAlign = HorizontalAlignment.Center;
            numAppointmentDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblWorkStart
            // 
            lblWorkStart.Dock = DockStyle.Fill;
            lblWorkStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkStart.ForeColor = Color.FromArgb(100, 110, 120);
            lblWorkStart.Location = new Point(6, 171);
            lblWorkStart.Margin = new Padding(6, 8, 6, 2);
            lblWorkStart.Name = "lblWorkStart";
            lblWorkStart.Size = new Size(515, 22);
            lblWorkStart.TabIndex = 2;
            lblWorkStart.Text = "وقت بدء الدوام:";
            lblWorkStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpWorkStart
            // 
            dtpWorkStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpWorkStart.Font = new Font("Segoe UI", 10F);
            dtpWorkStart.Format = DateTimePickerFormat.Time;
            dtpWorkStart.Location = new Point(6, 197);
            dtpWorkStart.Margin = new Padding(6, 2, 6, 8);
            dtpWorkStart.Name = "dtpWorkStart";
            dtpWorkStart.ShowUpDown = true;
            dtpWorkStart.Size = new Size(515, 25);
            dtpWorkStart.TabIndex = 3;
            // 
            // lblWorkEnd
            // 
            lblWorkEnd.Dock = DockStyle.Fill;
            lblWorkEnd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkEnd.ForeColor = Color.FromArgb(100, 110, 120);
            lblWorkEnd.Location = new Point(6, 339);
            lblWorkEnd.Margin = new Padding(6, 8, 6, 2);
            lblWorkEnd.Name = "lblWorkEnd";
            lblWorkEnd.Size = new Size(515, 22);
            lblWorkEnd.TabIndex = 4;
            lblWorkEnd.Text = "وقت انتهاء الدوام:";
            lblWorkEnd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpWorkEnd
            // 
            dtpWorkEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpWorkEnd.Font = new Font("Segoe UI", 10F);
            dtpWorkEnd.Format = DateTimePickerFormat.Time;
            dtpWorkEnd.Location = new Point(6, 365);
            dtpWorkEnd.Margin = new Padding(6, 2, 6, 6);
            dtpWorkEnd.Name = "dtpWorkEnd";
            dtpWorkEnd.ShowUpDown = true;
            dtpWorkEnd.Size = new Size(515, 25);
            dtpWorkEnd.TabIndex = 5;
            // 
            // pnlHolidaysArea
            // 
            pnlHolidaysArea.BackColor = Color.White;
            pnlHolidaysArea.BorderStyle = BorderStyle.FixedSingle;
            pnlHolidaysArea.ColumnCount = 1;
            pnlHolidaysArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlHolidaysArea.Controls.Add(lblHolidaysCaption, 0, 0);
            pnlHolidaysArea.Controls.Add(clbWeeklyHolidays, 0, 1);
            pnlHolidaysArea.Dock = DockStyle.Fill;
            pnlHolidaysArea.Location = new Point(3, 3);
            pnlHolidaysArea.Name = "pnlHolidaysArea";
            pnlHolidaysArea.Padding = new Padding(15);
            pnlHolidaysArea.RowCount = 2;
            pnlHolidaysArea.RowStyles.Add(new RowStyle());
            pnlHolidaysArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHolidaysArea.Size = new Size(441, 500);
            pnlHolidaysArea.TabIndex = 1;
            // 
            // lblHolidaysCaption
            // 
            lblHolidaysCaption.Dock = DockStyle.Fill;
            lblHolidaysCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHolidaysCaption.ForeColor = Color.FromArgb(26, 37, 51);
            lblHolidaysCaption.Location = new Point(18, 15);
            lblHolidaysCaption.Margin = new Padding(3, 0, 3, 10);
            lblHolidaysCaption.Name = "lblHolidaysCaption";
            lblHolidaysCaption.Size = new Size(403, 24);
            lblHolidaysCaption.TabIndex = 0;
            lblHolidaysCaption.Text = "أيام الإجازة الأسبوعية:";
            lblHolidaysCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // clbWeeklyHolidays
            // 
            clbWeeklyHolidays.BorderStyle = BorderStyle.FixedSingle;
            clbWeeklyHolidays.CheckOnClick = true;
            clbWeeklyHolidays.Dock = DockStyle.Fill;
            clbWeeklyHolidays.Font = new Font("Segoe UI", 10F);
            clbWeeklyHolidays.FormattingEnabled = true;
            clbWeeklyHolidays.Items.AddRange(new object[] { "السبت", "الأحد", "الاثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة" });
            clbWeeklyHolidays.Location = new Point(18, 49);
            clbWeeklyHolidays.Margin = new Padding(3, 0, 3, 0);
            clbWeeklyHolidays.Name = "clbWeeklyHolidays";
            clbWeeklyHolidays.Size = new Size(403, 434);
            clbWeeklyHolidays.TabIndex = 1;
            // 
            // tabFinancial
            // 
            tabFinancial.BackColor = Color.FromArgb(244, 247, 250);
            tabFinancial.Controls.Add(tlpFinancialRoot);
            tabFinancial.Location = new Point(4, 46);
            tabFinancial.Name = "tabFinancial";
            tabFinancial.Padding = new Padding(20);
            tabFinancial.Size = new Size(1032, 546);
            tabFinancial.TabIndex = 3;
            tabFinancial.Text = "الإعدادات المالية";
            // 
            // tlpFinancialRoot
            // 
            tlpFinancialRoot.ColumnCount = 2;
            tlpFinancialRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFinancialRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFinancialRoot.Controls.Add(lblDefaultCurrency, 0, 0);
            tlpFinancialRoot.Controls.Add(lblTaxPercentage, 1, 0);
            tlpFinancialRoot.Controls.Add(cmbDefaultCurrency, 0, 1);
            tlpFinancialRoot.Controls.Add(numTaxPercentage, 1, 1);
            tlpFinancialRoot.Controls.Add(lblInvoiceNotes, 0, 2);
            tlpFinancialRoot.Controls.Add(txtInvoiceNotes, 0, 3);
            tlpFinancialRoot.Dock = DockStyle.Fill;
            tlpFinancialRoot.Location = new Point(20, 20);
            tlpFinancialRoot.Name = "tlpFinancialRoot";
            tlpFinancialRoot.RowCount = 4;
            tlpFinancialRoot.RowStyles.Add(new RowStyle());
            tlpFinancialRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpFinancialRoot.RowStyles.Add(new RowStyle());
            tlpFinancialRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpFinancialRoot.Size = new Size(992, 506);
            tlpFinancialRoot.TabIndex = 0;
            // 
            // lblDefaultCurrency
            // 
            lblDefaultCurrency.Dock = DockStyle.Fill;
            lblDefaultCurrency.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDefaultCurrency.ForeColor = Color.FromArgb(100, 110, 120);
            lblDefaultCurrency.Location = new Point(502, 3);
            lblDefaultCurrency.Margin = new Padding(6, 3, 6, 2);
            lblDefaultCurrency.Name = "lblDefaultCurrency";
            lblDefaultCurrency.Size = new Size(484, 22);
            lblDefaultCurrency.TabIndex = 0;
            lblDefaultCurrency.Text = "العملة الافتراضية:";
            lblDefaultCurrency.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTaxPercentage
            // 
            lblTaxPercentage.Dock = DockStyle.Fill;
            lblTaxPercentage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaxPercentage.ForeColor = Color.FromArgb(100, 110, 120);
            lblTaxPercentage.Location = new Point(6, 3);
            lblTaxPercentage.Margin = new Padding(6, 3, 6, 2);
            lblTaxPercentage.Name = "lblTaxPercentage";
            lblTaxPercentage.Size = new Size(484, 22);
            lblTaxPercentage.TabIndex = 2;
            lblTaxPercentage.Text = "نسبة الضريبة المضافة الافتراضية (%):";
            lblTaxPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDefaultCurrency
            // 
            cmbDefaultCurrency.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDefaultCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDefaultCurrency.Font = new Font("Segoe UI", 10F);
            cmbDefaultCurrency.FormattingEnabled = true;
            cmbDefaultCurrency.Items.AddRange(new object[] { "شيكل (ILS)", "دولار (USD)", "دينار (JOD)", "يورو (EUR)" });
            cmbDefaultCurrency.Location = new Point(502, 29);
            cmbDefaultCurrency.Margin = new Padding(6, 2, 6, 8);
            cmbDefaultCurrency.Name = "cmbDefaultCurrency";
            cmbDefaultCurrency.Size = new Size(484, 25);
            cmbDefaultCurrency.TabIndex = 1;
            // 
            // numTaxPercentage
            // 
            numTaxPercentage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numTaxPercentage.DecimalPlaces = 2;
            numTaxPercentage.Font = new Font("Segoe UI", 10F);
            numTaxPercentage.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numTaxPercentage.Location = new Point(6, 29);
            numTaxPercentage.Margin = new Padding(6, 2, 6, 8);
            numTaxPercentage.Name = "numTaxPercentage";
            numTaxPercentage.Size = new Size(484, 25);
            numTaxPercentage.TabIndex = 3;
            numTaxPercentage.TextAlign = HorizontalAlignment.Center;
            // 
            // lblInvoiceNotes
            // 
            tlpFinancialRoot.SetColumnSpan(lblInvoiceNotes, 2);
            lblInvoiceNotes.Dock = DockStyle.Fill;
            lblInvoiceNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInvoiceNotes.ForeColor = Color.FromArgb(100, 110, 120);
            lblInvoiceNotes.Location = new Point(6, 118);
            lblInvoiceNotes.Margin = new Padding(6, 8, 6, 2);
            lblInvoiceNotes.Name = "lblInvoiceNotes";
            lblInvoiceNotes.Size = new Size(980, 22);
            lblInvoiceNotes.TabIndex = 4;
            lblInvoiceNotes.Text = "ملاحظات ثابتة تظهر أسفل كل فاتورة:";
            lblInvoiceNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceNotes
            // 
            txtInvoiceNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInvoiceNotes.BackColor = Color.FromArgb(233, 236, 239);
            txtInvoiceNotes.BorderStyle = BorderStyle.FixedSingle;
            tlpFinancialRoot.SetColumnSpan(txtInvoiceNotes, 2);
            txtInvoiceNotes.Font = new Font("Segoe UI", 10F);
            txtInvoiceNotes.ForeColor = Color.FromArgb(33, 37, 41);
            txtInvoiceNotes.Location = new Point(6, 144);
            txtInvoiceNotes.Margin = new Padding(6, 2, 6, 6);
            txtInvoiceNotes.Multiline = true;
            txtInvoiceNotes.Name = "txtInvoiceNotes";
            txtInvoiceNotes.ScrollBars = ScrollBars.Vertical;
            txtInvoiceNotes.Size = new Size(980, 356);
            txtInvoiceNotes.TabIndex = 5;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(26, 37, 51);
            pnlFooter.Controls.Add(flpFooterButtons);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 656);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1040, 64);
            pnlFooter.TabIndex = 2;
            // 
            // flpFooterButtons
            // 
            flpFooterButtons.Controls.Add(btnCancel);
            flpFooterButtons.Controls.Add(btnSave);
            flpFooterButtons.Controls.Add(AdvancedSettings);
            flpFooterButtons.Dock = DockStyle.Fill;
            flpFooterButtons.Location = new Point(0, 0);
            flpFooterButtons.Name = "flpFooterButtons";
            flpFooterButtons.Size = new Size(1040, 64);
            flpFooterButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 140, 141);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(917, 3);
            btnCancel.Margin = new Padding(3, 3, 10, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "✖️ إلغاء الأمر";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(23, 162, 148);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 138, 127);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(772, 3);
            btnSave.Margin = new Padding(0, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "💾 حفظ التغييرات";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // ofdLogo
            // 
            ofdLogo.Filter = "ملفات الصور|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
            ofdLogo.Title = "اختر شعار العيادة";
            // 
            // AdvancedSettings
            // 
            AdvancedSettings.Anchor = AnchorStyles.Left;
            AdvancedSettings.AutoSize = true;
            AdvancedSettings.LinkColor = Color.White;
            AdvancedSettings.Location = new Point(30, 44);
            AdvancedSettings.Margin = new Padding(900, 0, 3, 0);
            AdvancedSettings.Name = "AdvancedSettings";
            AdvancedSettings.Size = new Size(110, 17);
            AdvancedSettings.TabIndex = 2;
            AdvancedSettings.TabStop = true;
            AdvancedSettings.Text = "الاعدادات المتقدمة";
            AdvancedSettings.LinkClicked += AdvancedSettings_LinkClicked;
            // 
            // panel1
            // 
            panel1.Location = new Point(-4, 553);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 61);
            panel1.TabIndex = 3;
            // 
            // frmClinicSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1040, 720);
            Controls.Add(tabControl);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(880, 620);
            Name = "frmClinicSettings";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إعدادات العيادة";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            tlpGeneralRoot.ResumeLayout(false);
            tlpGeneralFields.ResumeLayout(false);
            tlpGeneralFields.PerformLayout();
            pnlLogoArea.ResumeLayout(false);
            pnlLogoArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            flpLogoButtons.ResumeLayout(false);
            tabContact.ResumeLayout(false);
            tlpContact.ResumeLayout(false);
            tlpContact.PerformLayout();
            tabScheduling.ResumeLayout(false);
            tlpSchedulingRoot.ResumeLayout(false);
            tlpSchedulingFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAppointmentDuration).EndInit();
            pnlHolidaysArea.ResumeLayout(false);
            tabFinancial.ResumeLayout(false);
            tlpFinancialRoot.ResumeLayout(false);
            tlpFinancialRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTaxPercentage).EndInit();
            pnlFooter.ResumeLayout(false);
            flpFooterButtons.ResumeLayout(false);
            flpFooterButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralRoot;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralFields;
        private System.Windows.Forms.Label lblClinicNameAr;
        private System.Windows.Forms.TextBox txtClinicNameAr;
        private System.Windows.Forms.Label lblClinicNameEn;
        private System.Windows.Forms.TextBox txtClinicNameEn;
        private System.Windows.Forms.Label lblTaxNumber;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TableLayoutPanel pnlLogoArea;
        private System.Windows.Forms.Label lblLogoCaption;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.FlowLayoutPanel flpLogoButtons;
        private System.Windows.Forms.Button btnUploadLogo;
        private System.Windows.Forms.Button btnRemoveLogo;

        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TableLayoutPanel tlpContact;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox txtWebsite;

        private System.Windows.Forms.TabPage tabScheduling;
        private System.Windows.Forms.TableLayoutPanel tlpSchedulingRoot;
        private System.Windows.Forms.TableLayoutPanel tlpSchedulingFields;
        private System.Windows.Forms.Label lblAppointmentDuration;
        private System.Windows.Forms.NumericUpDown numAppointmentDuration;
        private System.Windows.Forms.Label lblWorkStart;
        private System.Windows.Forms.DateTimePicker dtpWorkStart;
        private System.Windows.Forms.Label lblWorkEnd;
        private System.Windows.Forms.DateTimePicker dtpWorkEnd;
        private System.Windows.Forms.TableLayoutPanel pnlHolidaysArea;
        private System.Windows.Forms.Label lblHolidaysCaption;
        private System.Windows.Forms.CheckedListBox clbWeeklyHolidays;

        private System.Windows.Forms.TabPage tabFinancial;
        private System.Windows.Forms.TableLayoutPanel tlpFinancialRoot;
        private System.Windows.Forms.Label lblDefaultCurrency;
        private System.Windows.Forms.ComboBox cmbDefaultCurrency;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.NumericUpDown numTaxPercentage;
        private System.Windows.Forms.Label lblInvoiceNotes;
        private System.Windows.Forms.TextBox txtInvoiceNotes;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flpFooterButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private LinkLabel AdvancedSettings;
        private Panel panel1;
    }
}