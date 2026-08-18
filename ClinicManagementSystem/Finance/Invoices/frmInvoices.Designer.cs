using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmInvoices : Form
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            scrollContainer = new Panel();
            tlpTabNewRoot = new TableLayoutPanel();
            pnlInvoiceMetaCard = new Panel();
            tlpMetaCardLayout = new TableLayoutPanel();
            flpMetaFieldsLeft = new FlowLayoutPanel();
            lblMetaTitle = new Label();
            panel1 = new Panel();
            txtPatientVisitId = new TextBox();
            btnChooseVisit = new Button();
            label1 = new Label();
            flpMetaFieldRight = new FlowLayoutPanel();
            lblDueDateTitle = new Label();
            dtpDueDate = new DateTimePicker();
            pnlFeesCard = new Panel();
            tlpFeesCardLayout = new TableLayoutPanel();
            tlpUniformGridFees = new TableLayoutPanel();
            pnlConsultationField = new Panel();
            lblConsultationTitle = new Label();
            txtConsultationFee = new TextBox();
            pnlLabField = new Panel();
            lblLabTitle = new Label();
            txtLabTestFee = new TextBox();
            pnlProcedureField = new Panel();
            lblProcedureTitle = new Label();
            txtProcedureFee = new TextBox();
            pnlOtherField = new Panel();
            lblOtherTitle = new Label();
            txtOtherCharges = new TextBox();
            pnlBrandingSplash = new Panel();
            tlpBrandingCentering = new TableLayoutPanel();
            lblBrandingIcon = new Label();
            lblBrandingTitle = new Label();
            lblBrandingSubtitle = new Label();
            pnlFooterCard = new Panel();
            tlpFooterCardLayout = new TableLayoutPanel();
            tlpFooterLeftActions = new TableLayoutPanel();
            tlpUniformGridPercentages = new TableLayoutPanel();
            pnlDiscountField = new Panel();
            lblDiscountTitle = new Label();
            txtDiscountPercentage = new TextBox();
            pnlTaxField = new Panel();
            lblTaxTitle = new Label();
            txtTaxPercentage = new TextBox();
            flpActionButtons = new FlowLayoutPanel();
            btnSaveInvoice = new Button();
            btnNewInvoice = new Button();
            tlpFooterRightTotals = new TableLayoutPanel();
            lblSubTotalTitle = new Label();
            lblSubTotalValue = new Label();
            lblDiscountAmtTitle = new Label();
            lblDiscountAmtValue = new Label();
            pnlFooterSeparator = new Panel();
            lblFinalTotalTitle = new Label();
            lblFinalTotalValue = new Label();
            epInvoice = new ErrorProvider(components);
            mainPanel.SuspendLayout();
            scrollContainer.SuspendLayout();
            tlpTabNewRoot.SuspendLayout();
            pnlInvoiceMetaCard.SuspendLayout();
            tlpMetaCardLayout.SuspendLayout();
            flpMetaFieldsLeft.SuspendLayout();
            panel1.SuspendLayout();
            flpMetaFieldRight.SuspendLayout();
            pnlFeesCard.SuspendLayout();
            tlpFeesCardLayout.SuspendLayout();
            tlpUniformGridFees.SuspendLayout();
            pnlConsultationField.SuspendLayout();
            pnlLabField.SuspendLayout();
            pnlProcedureField.SuspendLayout();
            pnlOtherField.SuspendLayout();
            pnlBrandingSplash.SuspendLayout();
            tlpBrandingCentering.SuspendLayout();
            pnlFooterCard.SuspendLayout();
            tlpFooterCardLayout.SuspendLayout();
            tlpFooterLeftActions.SuspendLayout();
            tlpUniformGridPercentages.SuspendLayout();
            pnlDiscountField.SuspendLayout();
            pnlTaxField.SuspendLayout();
            flpActionButtons.SuspendLayout();
            tlpFooterRightTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epInvoice).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(scrollContainer);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(1084, 749);
            mainPanel.TabIndex = 0;
            // 
            // scrollContainer
            // 
            scrollContainer.AutoScroll = true;
            scrollContainer.Controls.Add(tlpTabNewRoot);
            scrollContainer.Dock = DockStyle.Fill;
            scrollContainer.Location = new Point(10, 10);
            scrollContainer.Name = "scrollContainer";
            scrollContainer.Size = new Size(1064, 729);
            scrollContainer.TabIndex = 0;
            // 
            // tlpTabNewRoot
            // 
            tlpTabNewRoot.ColumnCount = 1;
            tlpTabNewRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabNewRoot.Controls.Add(pnlInvoiceMetaCard, 0, 0);
            tlpTabNewRoot.Controls.Add(pnlFeesCard, 0, 1);
            tlpTabNewRoot.Controls.Add(pnlFooterCard, 0, 2);
            tlpTabNewRoot.Dock = DockStyle.Top;
            tlpTabNewRoot.Location = new Point(0, 0);
            tlpTabNewRoot.Name = "tlpTabNewRoot";
            tlpTabNewRoot.RowCount = 3;
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tlpTabNewRoot.Size = new Size(1047, 760);
            tlpTabNewRoot.TabIndex = 0;
            // 
            // pnlInvoiceMetaCard
            // 
            pnlInvoiceMetaCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInvoiceMetaCard.BackColor = Color.White;
            pnlInvoiceMetaCard.Controls.Add(tlpMetaCardLayout);
            pnlInvoiceMetaCard.Location = new Point(10, 10);
            pnlInvoiceMetaCard.Margin = new Padding(10);
            pnlInvoiceMetaCard.Name = "pnlInvoiceMetaCard";
            pnlInvoiceMetaCard.Padding = new Padding(20);
            pnlInvoiceMetaCard.Size = new Size(1027, 140);
            pnlInvoiceMetaCard.TabIndex = 0;
            // 
            // tlpMetaCardLayout
            // 
            tlpMetaCardLayout.ColumnCount = 2;
            tlpMetaCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMetaCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpMetaCardLayout.Controls.Add(flpMetaFieldsLeft, 0, 0);
            tlpMetaCardLayout.Controls.Add(flpMetaFieldRight, 1, 0);
            tlpMetaCardLayout.Dock = DockStyle.Fill;
            tlpMetaCardLayout.Location = new Point(20, 20);
            tlpMetaCardLayout.Name = "tlpMetaCardLayout";
            tlpMetaCardLayout.RowCount = 1;
            tlpMetaCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMetaCardLayout.Size = new Size(987, 100);
            tlpMetaCardLayout.TabIndex = 0;
            // 
            // flpMetaFieldsLeft
            // 
            flpMetaFieldsLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldsLeft.Controls.Add(lblMetaTitle);
            flpMetaFieldsLeft.Controls.Add(panel1);
            flpMetaFieldsLeft.FlowDirection = FlowDirection.TopDown;
            flpMetaFieldsLeft.Location = new Point(183, 3);
            flpMetaFieldsLeft.Name = "flpMetaFieldsLeft";
            flpMetaFieldsLeft.Size = new Size(801, 94);
            flpMetaFieldsLeft.TabIndex = 0;
            flpMetaFieldsLeft.WrapContents = false;
            // 
            // lblMetaTitle
            // 
            flpMetaFieldsLeft.SetFlowBreak(lblMetaTitle, true);
            lblMetaTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblMetaTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblMetaTitle.Location = new Point(11, 0);
            lblMetaTitle.Name = "lblMetaTitle";
            lblMetaTitle.Size = new Size(787, 30);
            lblMetaTitle.TabIndex = 0;
            lblMetaTitle.Text = "بيانات الفاتورة";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPatientVisitId);
            panel1.Controls.Add(btnChooseVisit);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(501, 30);
            panel1.Margin = new Padding(0, 0, 20, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 63);
            panel1.TabIndex = 4;
            // 
            // txtPatientVisitId
            // 
            txtPatientVisitId.Location = new Point(153, 31);
            txtPatientVisitId.Name = "txtPatientVisitId";
            txtPatientVisitId.Size = new Size(144, 25);
            txtPatientVisitId.TabIndex = 7;
            // 
            // btnChooseVisit
            // 
            btnChooseVisit.BackColor = Color.FromArgb(46, 204, 113);
            btnChooseVisit.FlatStyle = FlatStyle.Flat;
            btnChooseVisit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnChooseVisit.ForeColor = Color.White;
            btnChooseVisit.Location = new Point(7, 20);
            btnChooseVisit.Margin = new Padding(5, 30, 5, 5);
            btnChooseVisit.Name = "btnChooseVisit";
            btnChooseVisit.Size = new Size(120, 38);
            btnChooseVisit.TabIndex = 6;
            btnChooseVisit.Text = "اختر زيارة";
            btnChooseVisit.UseVisualStyleBackColor = false;
            btnChooseVisit.Click += btnChooseVisit_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(93, 122, 149);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(300, 22);
            label1.TabIndex = 4;
            label1.Text = "اختر زيارة المريض";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // flpMetaFieldRight
            // 
            flpMetaFieldRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldRight.Controls.Add(lblDueDateTitle);
            flpMetaFieldRight.Controls.Add(dtpDueDate);
            flpMetaFieldRight.FlowDirection = FlowDirection.RightToLeft;
            flpMetaFieldRight.Location = new Point(3, 3);
            flpMetaFieldRight.Name = "flpMetaFieldRight";
            flpMetaFieldRight.Padding = new Padding(0, 33, 0, 0);
            flpMetaFieldRight.Size = new Size(174, 94);
            flpMetaFieldRight.TabIndex = 1;
            // 
            // lblDueDateTitle
            // 
            lblDueDateTitle.AutoSize = true;
            lblDueDateTitle.Font = new Font("Segoe UI", 9F);
            lblDueDateTitle.ForeColor = Color.FromArgb(143, 163, 184);
            lblDueDateTitle.Location = new Point(0, 33);
            lblDueDateTitle.Margin = new Padding(0, 0, 0, 5);
            lblDueDateTitle.Name = "lblDueDateTitle";
            lblDueDateTitle.Size = new Size(83, 15);
            lblDueDateTitle.TabIndex = 0;
            lblDueDateTitle.Text = "تاريخ الاستحقاق";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Segoe UI", 11.25F);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(0, 53);
            dtpDueDate.Margin = new Padding(0);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(150, 27);
            dtpDueDate.TabIndex = 1;
            // 
            // pnlFeesCard
            // 
            pnlFeesCard.BackColor = Color.White;
            pnlFeesCard.Controls.Add(tlpFeesCardLayout);
            pnlFeesCard.Dock = DockStyle.Fill;
            pnlFeesCard.Location = new Point(10, 170);
            pnlFeesCard.Margin = new Padding(10);
            pnlFeesCard.Name = "pnlFeesCard";
            pnlFeesCard.Padding = new Padding(20);
            pnlFeesCard.Size = new Size(1027, 390);
            pnlFeesCard.TabIndex = 1;
            // 
            // tlpFeesCardLayout
            // 
            tlpFeesCardLayout.ColumnCount = 1;
            tlpFeesCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFeesCardLayout.Controls.Add(tlpUniformGridFees, 0, 0);
            tlpFeesCardLayout.Controls.Add(pnlBrandingSplash, 0, 1);
            tlpFeesCardLayout.Dock = DockStyle.Fill;
            tlpFeesCardLayout.Location = new Point(20, 20);
            tlpFeesCardLayout.Name = "tlpFeesCardLayout";
            tlpFeesCardLayout.RowCount = 2;
            tlpFeesCardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpFeesCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFeesCardLayout.Size = new Size(987, 350);
            tlpFeesCardLayout.TabIndex = 0;
            // 
            // tlpUniformGridFees
            // 
            tlpUniformGridFees.ColumnCount = 4;
            tlpUniformGridFees.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridFees.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridFees.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridFees.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridFees.Controls.Add(pnlConsultationField, 0, 0);
            tlpUniformGridFees.Controls.Add(pnlLabField, 1, 0);
            tlpUniformGridFees.Controls.Add(pnlProcedureField, 2, 0);
            tlpUniformGridFees.Controls.Add(pnlOtherField, 3, 0);
            tlpUniformGridFees.Dock = DockStyle.Fill;
            tlpUniformGridFees.Location = new Point(3, 3);
            tlpUniformGridFees.Margin = new Padding(3, 3, 3, 20);
            tlpUniformGridFees.Name = "tlpUniformGridFees";
            tlpUniformGridFees.RowCount = 1;
            tlpUniformGridFees.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniformGridFees.Size = new Size(981, 67);
            tlpUniformGridFees.TabIndex = 0;
            // 
            // pnlConsultationField
            // 
            pnlConsultationField.Controls.Add(lblConsultationTitle);
            pnlConsultationField.Controls.Add(txtConsultationFee);
            pnlConsultationField.Dock = DockStyle.Fill;
            pnlConsultationField.Location = new Point(741, 5);
            pnlConsultationField.Margin = new Padding(5);
            pnlConsultationField.Name = "pnlConsultationField";
            pnlConsultationField.Size = new Size(235, 57);
            pnlConsultationField.TabIndex = 0;
            // 
            // lblConsultationTitle
            // 
            lblConsultationTitle.AutoSize = true;
            lblConsultationTitle.Font = new Font("Segoe UI", 9F);
            lblConsultationTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblConsultationTitle.Location = new Point(157, 0);
            lblConsultationTitle.Name = "lblConsultationTitle";
            lblConsultationTitle.Size = new Size(76, 15);
            lblConsultationTitle.TabIndex = 0;
            lblConsultationTitle.Text = "رسوم الكشفية";
            // 
            // txtConsultationFee
            // 
            txtConsultationFee.Dock = DockStyle.Bottom;
            txtConsultationFee.Font = new Font("Segoe UI", 11.25F);
            txtConsultationFee.Location = new Point(0, 19);
            txtConsultationFee.Multiline = true;
            txtConsultationFee.Name = "txtConsultationFee";
            txtConsultationFee.Size = new Size(235, 38);
            txtConsultationFee.TabIndex = 1;
            txtConsultationFee.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtConsultationFee.KeyPress += preventLetters_KeyPress;
            // 
            // pnlLabField
            // 
            pnlLabField.Controls.Add(lblLabTitle);
            pnlLabField.Controls.Add(txtLabTestFee);
            pnlLabField.Dock = DockStyle.Fill;
            pnlLabField.Location = new Point(496, 5);
            pnlLabField.Margin = new Padding(5);
            pnlLabField.Name = "pnlLabField";
            pnlLabField.Size = new Size(235, 57);
            pnlLabField.TabIndex = 1;
            // 
            // lblLabTitle
            // 
            lblLabTitle.AutoSize = true;
            lblLabTitle.Font = new Font("Segoe UI", 9F);
            lblLabTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblLabTitle.Location = new Point(161, 0);
            lblLabTitle.Name = "lblLabTitle";
            lblLabTitle.Size = new Size(71, 15);
            lblLabTitle.TabIndex = 0;
            lblLabTitle.Text = "رسوم المختبر";
            // 
            // txtLabTestFee
            // 
            txtLabTestFee.Dock = DockStyle.Bottom;
            txtLabTestFee.Font = new Font("Segoe UI", 11.25F);
            txtLabTestFee.Location = new Point(0, 19);
            txtLabTestFee.Multiline = true;
            txtLabTestFee.Name = "txtLabTestFee";
            txtLabTestFee.Size = new Size(235, 38);
            txtLabTestFee.TabIndex = 1;
            txtLabTestFee.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtLabTestFee.KeyPress += preventLetters_KeyPress;
            // 
            // pnlProcedureField
            // 
            pnlProcedureField.Controls.Add(lblProcedureTitle);
            pnlProcedureField.Controls.Add(txtProcedureFee);
            pnlProcedureField.Dock = DockStyle.Fill;
            pnlProcedureField.Location = new Point(251, 5);
            pnlProcedureField.Margin = new Padding(5);
            pnlProcedureField.Name = "pnlProcedureField";
            pnlProcedureField.Size = new Size(235, 57);
            pnlProcedureField.TabIndex = 2;
            // 
            // lblProcedureTitle
            // 
            lblProcedureTitle.AutoSize = true;
            lblProcedureTitle.Font = new Font("Segoe UI", 9F);
            lblProcedureTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblProcedureTitle.Location = new Point(149, 0);
            lblProcedureTitle.Name = "lblProcedureTitle";
            lblProcedureTitle.Size = new Size(80, 15);
            lblProcedureTitle.TabIndex = 0;
            lblProcedureTitle.Text = "رسوم الإجراءات";
            // 
            // txtProcedureFee
            // 
            txtProcedureFee.Dock = DockStyle.Bottom;
            txtProcedureFee.Font = new Font("Segoe UI", 11.25F);
            txtProcedureFee.Location = new Point(0, 19);
            txtProcedureFee.Multiline = true;
            txtProcedureFee.Name = "txtProcedureFee";
            txtProcedureFee.Size = new Size(235, 38);
            txtProcedureFee.TabIndex = 1;
            txtProcedureFee.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtProcedureFee.KeyPress += preventLetters_KeyPress;
            // 
            // pnlOtherField
            // 
            pnlOtherField.Controls.Add(lblOtherTitle);
            pnlOtherField.Controls.Add(txtOtherCharges);
            pnlOtherField.Dock = DockStyle.Fill;
            pnlOtherField.Location = new Point(5, 5);
            pnlOtherField.Margin = new Padding(5);
            pnlOtherField.Name = "pnlOtherField";
            pnlOtherField.Size = new Size(236, 57);
            pnlOtherField.TabIndex = 3;
            // 
            // lblOtherTitle
            // 
            lblOtherTitle.AutoSize = true;
            lblOtherTitle.Font = new Font("Segoe UI", 9F);
            lblOtherTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblOtherTitle.Location = new Point(206, 0);
            lblOtherTitle.Name = "lblOtherTitle";
            lblOtherTitle.Size = new Size(30, 15);
            lblOtherTitle.TabIndex = 0;
            lblOtherTitle.Text = "أخرى";
            // 
            // txtOtherCharges
            // 
            txtOtherCharges.Dock = DockStyle.Bottom;
            txtOtherCharges.Font = new Font("Segoe UI", 11.25F);
            txtOtherCharges.Location = new Point(0, 19);
            txtOtherCharges.Multiline = true;
            txtOtherCharges.Name = "txtOtherCharges";
            txtOtherCharges.Size = new Size(236, 38);
            txtOtherCharges.TabIndex = 1;
            txtOtherCharges.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtOtherCharges.KeyPress += preventLetters_KeyPress;
            // 
            // pnlBrandingSplash
            // 
            pnlBrandingSplash.BackColor = Color.FromArgb(232, 245, 233);
            pnlBrandingSplash.Controls.Add(tlpBrandingCentering);
            pnlBrandingSplash.Dock = DockStyle.Fill;
            pnlBrandingSplash.Location = new Point(3, 93);
            pnlBrandingSplash.Name = "pnlBrandingSplash";
            pnlBrandingSplash.Size = new Size(981, 254);
            pnlBrandingSplash.TabIndex = 1;
            // 
            // tlpBrandingCentering
            // 
            tlpBrandingCentering.ColumnCount = 1;
            tlpBrandingCentering.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBrandingCentering.Controls.Add(lblBrandingIcon, 0, 0);
            tlpBrandingCentering.Controls.Add(lblBrandingTitle, 0, 1);
            tlpBrandingCentering.Controls.Add(lblBrandingSubtitle, 0, 2);
            tlpBrandingCentering.Dock = DockStyle.Fill;
            tlpBrandingCentering.Location = new Point(0, 0);
            tlpBrandingCentering.Name = "tlpBrandingCentering";
            tlpBrandingCentering.RowCount = 3;
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpBrandingCentering.Size = new Size(981, 254);
            tlpBrandingCentering.TabIndex = 0;
            // 
            // lblBrandingIcon
            // 
            lblBrandingIcon.Dock = DockStyle.Fill;
            lblBrandingIcon.Font = new Font("Segoe UI", 48F);
            lblBrandingIcon.Location = new Point(3, 0);
            lblBrandingIcon.Name = "lblBrandingIcon";
            lblBrandingIcon.Size = new Size(975, 114);
            lblBrandingIcon.TabIndex = 0;
            lblBrandingIcon.Text = "\U0001fa7a";
            lblBrandingIcon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblBrandingTitle
            // 
            lblBrandingTitle.Dock = DockStyle.Fill;
            lblBrandingTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblBrandingTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblBrandingTitle.Location = new Point(3, 114);
            lblBrandingTitle.Name = "lblBrandingTitle";
            lblBrandingTitle.Size = new Size(975, 63);
            lblBrandingTitle.TabIndex = 1;
            lblBrandingTitle.Text = "نظام إدارة الفواتير الطبية";
            lblBrandingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandingSubtitle
            // 
            lblBrandingSubtitle.Dock = DockStyle.Fill;
            lblBrandingSubtitle.Font = new Font("Segoe UI", 12F);
            lblBrandingSubtitle.ForeColor = Color.FromArgb(102, 187, 106);
            lblBrandingSubtitle.Location = new Point(3, 177);
            lblBrandingSubtitle.Name = "lblBrandingSubtitle";
            lblBrandingSubtitle.Size = new Size(975, 77);
            lblBrandingSubtitle.TabIndex = 2;
            lblBrandingSubtitle.Text = "تأكد من مراجعة الرسوم بدقة قبل الحفظ";
            lblBrandingSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlFooterCard
            // 
            pnlFooterCard.BackColor = Color.FromArgb(26, 37, 51);
            pnlFooterCard.Controls.Add(tlpFooterCardLayout);
            pnlFooterCard.Dock = DockStyle.Fill;
            pnlFooterCard.Location = new Point(10, 580);
            pnlFooterCard.Margin = new Padding(10);
            pnlFooterCard.Name = "pnlFooterCard";
            pnlFooterCard.Padding = new Padding(25);
            pnlFooterCard.Size = new Size(1027, 170);
            pnlFooterCard.TabIndex = 2;
            // 
            // tlpFooterCardLayout
            // 
            tlpFooterCardLayout.ColumnCount = 2;
            tlpFooterCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooterCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpFooterCardLayout.Controls.Add(tlpFooterLeftActions, 0, 0);
            tlpFooterCardLayout.Controls.Add(tlpFooterRightTotals, 1, 0);
            tlpFooterCardLayout.Dock = DockStyle.Fill;
            tlpFooterCardLayout.Location = new Point(25, 25);
            tlpFooterCardLayout.Name = "tlpFooterCardLayout";
            tlpFooterCardLayout.RowCount = 1;
            tlpFooterCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterCardLayout.Size = new Size(977, 120);
            tlpFooterCardLayout.TabIndex = 0;
            // 
            // tlpFooterLeftActions
            // 
            tlpFooterLeftActions.ColumnCount = 1;
            tlpFooterLeftActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Controls.Add(tlpUniformGridPercentages, 0, 0);
            tlpFooterLeftActions.Controls.Add(flpActionButtons, 0, 1);
            tlpFooterLeftActions.Dock = DockStyle.Fill;
            tlpFooterLeftActions.Location = new Point(353, 3);
            tlpFooterLeftActions.Name = "tlpFooterLeftActions";
            tlpFooterLeftActions.RowCount = 2;
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Size = new Size(621, 114);
            tlpFooterLeftActions.TabIndex = 0;
            // 
            // tlpUniformGridPercentages
            // 
            tlpUniformGridPercentages.ColumnCount = 2;
            tlpUniformGridPercentages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUniformGridPercentages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUniformGridPercentages.Controls.Add(pnlDiscountField, 0, 0);
            tlpUniformGridPercentages.Controls.Add(pnlTaxField, 1, 0);
            tlpUniformGridPercentages.Dock = DockStyle.Fill;
            tlpUniformGridPercentages.Location = new Point(20, 3);
            tlpUniformGridPercentages.Margin = new Padding(3, 3, 20, 3);
            tlpUniformGridPercentages.Name = "tlpUniformGridPercentages";
            tlpUniformGridPercentages.RowCount = 1;
            tlpUniformGridPercentages.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniformGridPercentages.Size = new Size(598, 54);
            tlpUniformGridPercentages.TabIndex = 0;
            // 
            // pnlDiscountField
            // 
            pnlDiscountField.Controls.Add(lblDiscountTitle);
            pnlDiscountField.Controls.Add(txtDiscountPercentage);
            pnlDiscountField.Dock = DockStyle.Fill;
            pnlDiscountField.Location = new Point(309, 0);
            pnlDiscountField.Margin = new Padding(0, 0, 10, 0);
            pnlDiscountField.Name = "pnlDiscountField";
            pnlDiscountField.Size = new Size(289, 54);
            pnlDiscountField.TabIndex = 0;
            // 
            // lblDiscountTitle
            // 
            lblDiscountTitle.AutoSize = true;
            lblDiscountTitle.Font = new Font("Segoe UI", 9F);
            lblDiscountTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblDiscountTitle.Location = new Point(232, 0);
            lblDiscountTitle.Name = "lblDiscountTitle";
            lblDiscountTitle.Size = new Size(61, 15);
            lblDiscountTitle.TabIndex = 0;
            lblDiscountTitle.Text = "الخصم (%)";
            // 
            // txtDiscountPercentage
            // 
            txtDiscountPercentage.BackColor = Color.FromArgb(44, 62, 80);
            txtDiscountPercentage.BorderStyle = BorderStyle.None;
            txtDiscountPercentage.Dock = DockStyle.Bottom;
            txtDiscountPercentage.Font = new Font("Segoe UI", 11.25F);
            txtDiscountPercentage.ForeColor = Color.White;
            txtDiscountPercentage.Location = new Point(0, 19);
            txtDiscountPercentage.Multiline = true;
            txtDiscountPercentage.Name = "txtDiscountPercentage";
            txtDiscountPercentage.Size = new Size(289, 35);
            txtDiscountPercentage.TabIndex = 1;
            txtDiscountPercentage.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtDiscountPercentage.KeyPress += preventLetters_KeyPress;
            // 
            // pnlTaxField
            // 
            pnlTaxField.Controls.Add(lblTaxTitle);
            pnlTaxField.Controls.Add(txtTaxPercentage);
            pnlTaxField.Dock = DockStyle.Fill;
            pnlTaxField.Location = new Point(0, 0);
            pnlTaxField.Margin = new Padding(0);
            pnlTaxField.Name = "pnlTaxField";
            pnlTaxField.Size = new Size(299, 54);
            pnlTaxField.TabIndex = 1;
            // 
            // lblTaxTitle
            // 
            lblTaxTitle.AutoSize = true;
            lblTaxTitle.Font = new Font("Segoe UI", 9F);
            lblTaxTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblTaxTitle.Location = new Point(240, 0);
            lblTaxTitle.Name = "lblTaxTitle";
            lblTaxTitle.Size = new Size(66, 15);
            lblTaxTitle.TabIndex = 0;
            lblTaxTitle.Text = "الضريبة (%)";
            // 
            // txtTaxPercentage
            // 
            txtTaxPercentage.BackColor = Color.FromArgb(44, 62, 80);
            txtTaxPercentage.BorderStyle = BorderStyle.None;
            txtTaxPercentage.Dock = DockStyle.Bottom;
            txtTaxPercentage.Font = new Font("Segoe UI", 11.25F);
            txtTaxPercentage.ForeColor = Color.White;
            txtTaxPercentage.Location = new Point(0, 19);
            txtTaxPercentage.Multiline = true;
            txtTaxPercentage.Name = "txtTaxPercentage";
            txtTaxPercentage.Size = new Size(299, 35);
            txtTaxPercentage.TabIndex = 1;
            txtTaxPercentage.TextChanged += txtUpdateSummaryLables_TextChanged;
            txtTaxPercentage.KeyPress += preventLetters_KeyPress;
            // 
            // flpActionButtons
            // 
            flpActionButtons.Controls.Add(btnSaveInvoice);
            flpActionButtons.Controls.Add(btnNewInvoice);
            flpActionButtons.Dock = DockStyle.Fill;
            flpActionButtons.Location = new Point(3, 63);
            flpActionButtons.Name = "flpActionButtons";
            flpActionButtons.Size = new Size(615, 48);
            flpActionButtons.TabIndex = 1;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.BackColor = Color.FromArgb(39, 174, 96);
            btnSaveInvoice.FlatAppearance.BorderSize = 0;
            btnSaveInvoice.FlatStyle = FlatStyle.Flat;
            btnSaveInvoice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.Location = new Point(455, 3);
            btnSaveInvoice.Margin = new Padding(0, 3, 10, 3);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(160, 45);
            btnSaveInvoice.TabIndex = 0;
            btnSaveInvoice.Text = "✅ حفظ الفاتورة";
            btnSaveInvoice.UseVisualStyleBackColor = false;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.BackColor = Color.FromArgb(127, 142, 141);
            btnNewInvoice.FlatAppearance.BorderSize = 0;
            btnNewInvoice.FlatStyle = FlatStyle.Flat;
            btnNewInvoice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnNewInvoice.ForeColor = Color.White;
            btnNewInvoice.Location = new Point(282, 3);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.Size = new Size(160, 45);
            btnNewInvoice.TabIndex = 1;
            btnNewInvoice.Text = "🔄 فاتورة جديدة";
            btnNewInvoice.UseVisualStyleBackColor = false;
            btnNewInvoice.Click += btnNewInvoice_Click;
            // 
            // tlpFooterRightTotals
            // 
            tlpFooterRightTotals.ColumnCount = 2;
            tlpFooterRightTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRightTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRightTotals.Controls.Add(lblSubTotalTitle, 0, 0);
            tlpFooterRightTotals.Controls.Add(lblSubTotalValue, 1, 0);
            tlpFooterRightTotals.Controls.Add(lblDiscountAmtTitle, 0, 1);
            tlpFooterRightTotals.Controls.Add(lblDiscountAmtValue, 1, 1);
            tlpFooterRightTotals.Controls.Add(pnlFooterSeparator, 0, 2);
            tlpFooterRightTotals.Controls.Add(lblFinalTotalTitle, 0, 3);
            tlpFooterRightTotals.Controls.Add(lblFinalTotalValue, 1, 3);
            tlpFooterRightTotals.Dock = DockStyle.Fill;
            tlpFooterRightTotals.Location = new Point(3, 3);
            tlpFooterRightTotals.Name = "tlpFooterRightTotals";
            tlpFooterRightTotals.RowCount = 4;
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterRightTotals.Size = new Size(344, 114);
            tlpFooterRightTotals.TabIndex = 1;
            // 
            // lblSubTotalTitle
            // 
            lblSubTotalTitle.Dock = DockStyle.Fill;
            lblSubTotalTitle.Font = new Font("Segoe UI", 10F);
            lblSubTotalTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblSubTotalTitle.Location = new Point(175, 0);
            lblSubTotalTitle.Name = "lblSubTotalTitle";
            lblSubTotalTitle.Size = new Size(166, 28);
            lblSubTotalTitle.TabIndex = 0;
            lblSubTotalTitle.Text = "المجموع الفرعي:";
            lblSubTotalTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubTotalValue
            // 
            lblSubTotalValue.Dock = DockStyle.Fill;
            lblSubTotalValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSubTotalValue.ForeColor = Color.White;
            lblSubTotalValue.Location = new Point(3, 0);
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(166, 28);
            lblSubTotalValue.TabIndex = 1;
            lblSubTotalValue.Text = "0.00";
            lblSubTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscountAmtTitle
            // 
            lblDiscountAmtTitle.Dock = DockStyle.Fill;
            lblDiscountAmtTitle.Font = new Font("Segoe UI", 10F);
            lblDiscountAmtTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblDiscountAmtTitle.Location = new Point(175, 28);
            lblDiscountAmtTitle.Name = "lblDiscountAmtTitle";
            lblDiscountAmtTitle.Size = new Size(166, 28);
            lblDiscountAmtTitle.TabIndex = 2;
            lblDiscountAmtTitle.Text = "قيمة الخصم:";
            lblDiscountAmtTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscountAmtValue
            // 
            lblDiscountAmtValue.Dock = DockStyle.Fill;
            lblDiscountAmtValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDiscountAmtValue.ForeColor = Color.FromArgb(231, 76, 60);
            lblDiscountAmtValue.Location = new Point(3, 28);
            lblDiscountAmtValue.Name = "lblDiscountAmtValue";
            lblDiscountAmtValue.Size = new Size(166, 28);
            lblDiscountAmtValue.TabIndex = 3;
            lblDiscountAmtValue.Text = "0.00-";
            lblDiscountAmtValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlFooterSeparator
            // 
            pnlFooterSeparator.BackColor = Color.FromArgb(52, 73, 94);
            tlpFooterRightTotals.SetColumnSpan(pnlFooterSeparator, 2);
            pnlFooterSeparator.Dock = DockStyle.Top;
            pnlFooterSeparator.Location = new Point(3, 61);
            pnlFooterSeparator.Margin = new Padding(3, 5, 3, 5);
            pnlFooterSeparator.Name = "pnlFooterSeparator";
            pnlFooterSeparator.Size = new Size(338, 1);
            pnlFooterSeparator.TabIndex = 4;
            // 
            // lblFinalTotalTitle
            // 
            lblFinalTotalTitle.Dock = DockStyle.Fill;
            lblFinalTotalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinalTotalTitle.ForeColor = Color.White;
            lblFinalTotalTitle.Location = new Point(175, 71);
            lblFinalTotalTitle.Name = "lblFinalTotalTitle";
            lblFinalTotalTitle.Size = new Size(166, 43);
            lblFinalTotalTitle.TabIndex = 5;
            lblFinalTotalTitle.Text = "الإجمالي النهائي:";
            lblFinalTotalTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFinalTotalValue
            // 
            lblFinalTotalValue.Dock = DockStyle.Fill;
            lblFinalTotalValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFinalTotalValue.ForeColor = Color.FromArgb(46, 204, 113);
            lblFinalTotalValue.Location = new Point(3, 71);
            lblFinalTotalValue.Name = "lblFinalTotalValue";
            lblFinalTotalValue.Size = new Size(166, 43);
            lblFinalTotalValue.TabIndex = 6;
            lblFinalTotalValue.Text = "0.00 $";
            lblFinalTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // epInvoice
            // 
            epInvoice.ContainerControl = this;
            // 
            // frmInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1084, 749);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9.75F);
            Name = "frmInvoices";
            RightToLeft = RightToLeft.Yes;
            WindowState = FormWindowState.Maximized;
            Load += frmInvoices_Load;
            mainPanel.ResumeLayout(false);
            scrollContainer.ResumeLayout(false);
            tlpTabNewRoot.ResumeLayout(false);
            pnlInvoiceMetaCard.ResumeLayout(false);
            tlpMetaCardLayout.ResumeLayout(false);
            flpMetaFieldsLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpMetaFieldRight.ResumeLayout(false);
            flpMetaFieldRight.PerformLayout();
            pnlFeesCard.ResumeLayout(false);
            tlpFeesCardLayout.ResumeLayout(false);
            tlpUniformGridFees.ResumeLayout(false);
            pnlConsultationField.ResumeLayout(false);
            pnlConsultationField.PerformLayout();
            pnlLabField.ResumeLayout(false);
            pnlLabField.PerformLayout();
            pnlProcedureField.ResumeLayout(false);
            pnlProcedureField.PerformLayout();
            pnlOtherField.ResumeLayout(false);
            pnlOtherField.PerformLayout();
            pnlBrandingSplash.ResumeLayout(false);
            tlpBrandingCentering.ResumeLayout(false);
            pnlFooterCard.ResumeLayout(false);
            tlpFooterCardLayout.ResumeLayout(false);
            tlpFooterLeftActions.ResumeLayout(false);
            tlpUniformGridPercentages.ResumeLayout(false);
            pnlDiscountField.ResumeLayout(false);
            pnlDiscountField.PerformLayout();
            pnlTaxField.ResumeLayout(false);
            pnlTaxField.PerformLayout();
            flpActionButtons.ResumeLayout(false);
            tlpFooterRightTotals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel scrollContainer;
        private System.Windows.Forms.TableLayoutPanel tlpTabNewRoot;
        private System.Windows.Forms.Panel pnlInvoiceMetaCard;
        private System.Windows.Forms.TableLayoutPanel tlpMetaCardLayout;
        private System.Windows.Forms.FlowLayoutPanel flpMetaFieldsLeft;
        private System.Windows.Forms.Label lblMetaTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMetaFieldRight;
        private System.Windows.Forms.Label lblDueDateTitle;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Panel pnlFeesCard;
        private System.Windows.Forms.TableLayoutPanel tlpFeesCardLayout;
        private System.Windows.Forms.TableLayoutPanel tlpUniformGridFees;
        private System.Windows.Forms.Panel pnlConsultationField;
        private System.Windows.Forms.Label lblConsultationTitle;
        private System.Windows.Forms.TextBox txtConsultationFee;
        private System.Windows.Forms.Panel pnlLabField;
        private System.Windows.Forms.Label lblLabTitle;
        private System.Windows.Forms.TextBox txtLabTestFee;
        private System.Windows.Forms.Panel pnlProcedureField;
        private System.Windows.Forms.Label lblProcedureTitle;
        private System.Windows.Forms.TextBox txtProcedureFee;
        private System.Windows.Forms.Panel pnlOtherField;
        private System.Windows.Forms.Label lblOtherTitle;
        private System.Windows.Forms.TextBox txtOtherCharges;
        private System.Windows.Forms.Panel pnlBrandingSplash;
        private System.Windows.Forms.TableLayoutPanel tlpBrandingCentering;
        private System.Windows.Forms.Label lblBrandingIcon;
        private System.Windows.Forms.Label lblBrandingTitle;
        private System.Windows.Forms.Label lblBrandingSubtitle;
        private System.Windows.Forms.Panel pnlFooterCard;
        private System.Windows.Forms.TableLayoutPanel tlpFooterCardLayout;
        private System.Windows.Forms.TableLayoutPanel tlpFooterLeftActions;
        private System.Windows.Forms.TableLayoutPanel tlpUniformGridPercentages;
        private System.Windows.Forms.Panel pnlDiscountField;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.Panel pnlTaxField;
        private System.Windows.Forms.Label lblTaxTitle;
        private System.Windows.Forms.TextBox txtTaxPercentage;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.TableLayoutPanel tlpFooterRightTotals;
        private System.Windows.Forms.Label lblSubTotalTitle;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblDiscountAmtTitle;
        private System.Windows.Forms.Label lblDiscountAmtValue;
        private System.Windows.Forms.Panel pnlFooterSeparator;
        private System.Windows.Forms.Label lblFinalTotalTitle;
        private System.Windows.Forms.Label lblFinalTotalValue;
        private ErrorProvider epInvoice;
        private Panel panel1;
        private TextBox txtPatientVisitId;
        private Button btnChooseVisit;
        private Label label1;
    }
}