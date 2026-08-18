using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    partial class frmPayments : Form
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
            pnlPaymentMetaCard = new Panel();
            tlpMetaCardLayout = new TableLayoutPanel();
            flpMetaFieldsLeft = new FlowLayoutPanel();
            lblMetaTitle = new Label();
            pnlChooseInvoice = new Panel();
            txtInvoiceId = new TextBox();
            btnChooseInvoice = new Button();
            lblChooseInvoiceCaption = new Label();
            flpMetaFieldRight = new FlowLayoutPanel();
            lblPaymentDateTitle = new Label();
            dtpPaymentDate = new DateTimePicker();
            pnlDetailsCard = new Panel();
            tlpDetailsCardLayout = new TableLayoutPanel();
            tlpUniformGridPaymentFields = new TableLayoutPanel();
            pnlAmountPaidField = new Panel();
            lblAmountPaidTitle = new Label();
            txtAmountPaid = new TextBox();
            pnlPaymentMethodField = new Panel();
            lblPaymentMethodTitle = new Label();
            cmbPaymentMethod = new ComboBox();
            pnlRemainingField = new Panel();
            lblRemainingTitle = new Label();
            txtRemainingAfterPayment = new TextBox();
            pnlNotesField = new Panel();
            lblNotesTitle = new Label();
            txtNotes = new TextBox();
            pnlBrandingSplash = new Panel();
            tlpBrandingCentering = new TableLayoutPanel();
            lblBrandingIcon = new Label();
            lblBrandingTitle = new Label();
            lblBrandingSubtitle = new Label();
            pnlFooterCard = new Panel();
            tlpFooterCardLayout = new TableLayoutPanel();
            tlpFooterLeftActions = new TableLayoutPanel();
            tlpUniformGridInvoiceSummary = new TableLayoutPanel();
            pnlInvoiceTotalField = new Panel();
            lblInvoiceTotalTitle = new Label();
            txtInvoiceTotal = new TextBox();
            pnlPaidSoFarField = new Panel();
            lblPaidSoFarTitle = new Label();
            txtPaidSoFar = new TextBox();
            flpActionButtons = new FlowLayoutPanel();
            btnSavePayment = new Button();
            btnNewPayment = new Button();
            tlpFooterRightTotals = new TableLayoutPanel();
            lblAmountPaidNowTitle = new Label();
            lblAmountPaidNowValue = new Label();
            lblRemainingTitle2 = new Label();
            lblRemainingValue = new Label();
            pnlFooterSeparator = new Panel();
            lblInvoiceStatusTitle = new Label();
            lblInvoiceStatusValue = new Label();
            epPayment = new ErrorProvider(components);
            mainPanel.SuspendLayout();
            scrollContainer.SuspendLayout();
            tlpTabNewRoot.SuspendLayout();
            pnlPaymentMetaCard.SuspendLayout();
            tlpMetaCardLayout.SuspendLayout();
            flpMetaFieldsLeft.SuspendLayout();
            pnlChooseInvoice.SuspendLayout();
            flpMetaFieldRight.SuspendLayout();
            pnlDetailsCard.SuspendLayout();
            tlpDetailsCardLayout.SuspendLayout();
            tlpUniformGridPaymentFields.SuspendLayout();
            pnlAmountPaidField.SuspendLayout();
            pnlPaymentMethodField.SuspendLayout();
            pnlRemainingField.SuspendLayout();
            pnlNotesField.SuspendLayout();
            pnlBrandingSplash.SuspendLayout();
            tlpBrandingCentering.SuspendLayout();
            pnlFooterCard.SuspendLayout();
            tlpFooterCardLayout.SuspendLayout();
            tlpFooterLeftActions.SuspendLayout();
            tlpUniformGridInvoiceSummary.SuspendLayout();
            pnlInvoiceTotalField.SuspendLayout();
            pnlPaidSoFarField.SuspendLayout();
            flpActionButtons.SuspendLayout();
            tlpFooterRightTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epPayment).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(248, 250, 252);
            mainPanel.Controls.Add(scrollContainer);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(16);
            mainPanel.Size = new Size(1084, 749);
            mainPanel.TabIndex = 0;
            // 
            // scrollContainer
            // 
            scrollContainer.AutoScroll = true;
            scrollContainer.Controls.Add(tlpTabNewRoot);
            scrollContainer.Dock = DockStyle.Fill;
            scrollContainer.Location = new Point(16, 16);
            scrollContainer.Name = "scrollContainer";
            scrollContainer.Size = new Size(1052, 717);
            scrollContainer.TabIndex = 0;
            // 
            // tlpTabNewRoot
            // 
            tlpTabNewRoot.ColumnCount = 1;
            tlpTabNewRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabNewRoot.Controls.Add(pnlPaymentMetaCard, 0, 0);
            tlpTabNewRoot.Controls.Add(pnlDetailsCard, 0, 1);
            tlpTabNewRoot.Controls.Add(pnlFooterCard, 0, 2);
            tlpTabNewRoot.Dock = DockStyle.Top;
            tlpTabNewRoot.Location = new Point(0, 0);
            tlpTabNewRoot.Name = "tlpTabNewRoot";
            tlpTabNewRoot.RowCount = 3;
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tlpTabNewRoot.Size = new Size(1027, 735);
            tlpTabNewRoot.TabIndex = 0;
            // 
            // pnlPaymentMetaCard
            // 
            pnlPaymentMetaCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPaymentMetaCard.BackColor = Color.White;
            pnlPaymentMetaCard.Controls.Add(tlpMetaCardLayout);
            pnlPaymentMetaCard.Location = new Point(12, 12);
            pnlPaymentMetaCard.Margin = new Padding(12);
            pnlPaymentMetaCard.Name = "pnlPaymentMetaCard";
            pnlPaymentMetaCard.Padding = new Padding(16);
            pnlPaymentMetaCard.Size = new Size(1003, 126);
            pnlPaymentMetaCard.TabIndex = 0;
            // 
            // tlpMetaCardLayout
            // 
            tlpMetaCardLayout.ColumnCount = 2;
            tlpMetaCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMetaCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpMetaCardLayout.Controls.Add(flpMetaFieldsLeft, 0, 0);
            tlpMetaCardLayout.Controls.Add(flpMetaFieldRight, 1, 0);
            tlpMetaCardLayout.Dock = DockStyle.Fill;
            tlpMetaCardLayout.Location = new Point(16, 16);
            tlpMetaCardLayout.Name = "tlpMetaCardLayout";
            tlpMetaCardLayout.RowCount = 1;
            tlpMetaCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMetaCardLayout.Size = new Size(971, 94);
            tlpMetaCardLayout.TabIndex = 0;
            // 
            // flpMetaFieldsLeft
            // 
            flpMetaFieldsLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldsLeft.Controls.Add(lblMetaTitle);
            flpMetaFieldsLeft.Controls.Add(pnlChooseInvoice);
            flpMetaFieldsLeft.FlowDirection = FlowDirection.TopDown;
            flpMetaFieldsLeft.Location = new Point(203, 3);
            flpMetaFieldsLeft.Name = "flpMetaFieldsLeft";
            flpMetaFieldsLeft.Size = new Size(765, 88);
            flpMetaFieldsLeft.TabIndex = 0;
            flpMetaFieldsLeft.WrapContents = false;
            // 
            // lblMetaTitle
            // 
            flpMetaFieldsLeft.SetFlowBreak(lblMetaTitle, true);
            lblMetaTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMetaTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetaTitle.Location = new Point(3, 0);
            lblMetaTitle.Name = "lblMetaTitle";
            lblMetaTitle.Size = new Size(759, 28);
            lblMetaTitle.TabIndex = 0;
            lblMetaTitle.Text = "بيانات الدفعة";
            // 
            // pnlChooseInvoice
            // 
            pnlChooseInvoice.Controls.Add(txtInvoiceId);
            pnlChooseInvoice.Controls.Add(btnChooseInvoice);
            pnlChooseInvoice.Controls.Add(lblChooseInvoiceCaption);
            pnlChooseInvoice.Location = new Point(442, 28);
            pnlChooseInvoice.Margin = new Padding(0, 0, 20, 0);
            pnlChooseInvoice.Name = "pnlChooseInvoice";
            pnlChooseInvoice.Size = new Size(323, 58);
            pnlChooseInvoice.TabIndex = 4;
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.BackColor = Color.FromArgb(241, 245, 249);
            txtInvoiceId.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtInvoiceId.ForeColor = Color.FromArgb(15, 23, 42);
            txtInvoiceId.Location = new Point(148, 26);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(170, 27);
            txtInvoiceId.TabIndex = 7;
            txtInvoiceId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnChooseInvoice
            // 
            btnChooseInvoice.BackColor = Color.FromArgb(37, 99, 235);
            btnChooseInvoice.Cursor = Cursors.Hand;
            btnChooseInvoice.FlatAppearance.BorderSize = 0;
            btnChooseInvoice.FlatStyle = FlatStyle.Flat;
            btnChooseInvoice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChooseInvoice.ForeColor = Color.White;
            btnChooseInvoice.Location = new Point(5, 24);
            btnChooseInvoice.Name = "btnChooseInvoice";
            btnChooseInvoice.Size = new Size(130, 31);
            btnChooseInvoice.TabIndex = 6;
            btnChooseInvoice.Text = "اختر فاتورة 🔍";
            btnChooseInvoice.UseVisualStyleBackColor = false;
            // 
            // lblChooseInvoiceCaption
            // 
            lblChooseInvoiceCaption.Dock = DockStyle.Top;
            lblChooseInvoiceCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChooseInvoiceCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblChooseInvoiceCaption.Location = new Point(0, 0);
            lblChooseInvoiceCaption.Name = "lblChooseInvoiceCaption";
            lblChooseInvoiceCaption.RightToLeft = RightToLeft.No;
            lblChooseInvoiceCaption.Size = new Size(323, 20);
            lblChooseInvoiceCaption.TabIndex = 4;
            lblChooseInvoiceCaption.Text = "اختر الفاتورة المرتبطة بالدفعة";
            lblChooseInvoiceCaption.TextAlign = ContentAlignment.TopRight;
            // 
            // flpMetaFieldRight
            // 
            flpMetaFieldRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldRight.Controls.Add(lblPaymentDateTitle);
            flpMetaFieldRight.Controls.Add(dtpPaymentDate);
            flpMetaFieldRight.FlowDirection = FlowDirection.TopDown;
            flpMetaFieldRight.Location = new Point(3, 3);
            flpMetaFieldRight.Name = "flpMetaFieldRight";
            flpMetaFieldRight.Padding = new Padding(0, 5, 0, 0);
            flpMetaFieldRight.Size = new Size(194, 88);
            flpMetaFieldRight.TabIndex = 1;
            // 
            // lblPaymentDateTitle
            // 
            lblPaymentDateTitle.AutoSize = true;
            lblPaymentDateTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaymentDateTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPaymentDateTitle.Location = new Point(128, 5);
            lblPaymentDateTitle.Margin = new Padding(0, 0, 0, 6);
            lblPaymentDateTitle.Name = "lblPaymentDateTitle";
            lblPaymentDateTitle.Size = new Size(66, 15);
            lblPaymentDateTitle.TabIndex = 0;
            lblPaymentDateTitle.Text = "تاريخ الدفعة";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 10.5F);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(14, 26);
            dtpPaymentDate.Margin = new Padding(0);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(180, 26);
            dtpPaymentDate.TabIndex = 1;
            // 
            // pnlDetailsCard
            // 
            pnlDetailsCard.BackColor = Color.White;
            pnlDetailsCard.Controls.Add(tlpDetailsCardLayout);
            pnlDetailsCard.Dock = DockStyle.Fill;
            pnlDetailsCard.Location = new Point(12, 162);
            pnlDetailsCard.Margin = new Padding(12);
            pnlDetailsCard.Name = "pnlDetailsCard";
            pnlDetailsCard.Padding = new Padding(16);
            pnlDetailsCard.Size = new Size(1003, 376);
            pnlDetailsCard.TabIndex = 1;
            // 
            // tlpDetailsCardLayout
            // 
            tlpDetailsCardLayout.ColumnCount = 1;
            tlpDetailsCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetailsCardLayout.Controls.Add(tlpUniformGridPaymentFields, 0, 0);
            tlpDetailsCardLayout.Controls.Add(pnlBrandingSplash, 0, 1);
            tlpDetailsCardLayout.Dock = DockStyle.Fill;
            tlpDetailsCardLayout.Location = new Point(16, 16);
            tlpDetailsCardLayout.Name = "tlpDetailsCardLayout";
            tlpDetailsCardLayout.RowCount = 2;
            tlpDetailsCardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpDetailsCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetailsCardLayout.Size = new Size(971, 344);
            tlpDetailsCardLayout.TabIndex = 0;
            // 
            // tlpUniformGridPaymentFields
            // 
            tlpUniformGridPaymentFields.ColumnCount = 4;
            tlpUniformGridPaymentFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridPaymentFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridPaymentFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridPaymentFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUniformGridPaymentFields.Controls.Add(pnlAmountPaidField, 0, 0);
            tlpUniformGridPaymentFields.Controls.Add(pnlPaymentMethodField, 1, 0);
            tlpUniformGridPaymentFields.Controls.Add(pnlRemainingField, 2, 0);
            tlpUniformGridPaymentFields.Controls.Add(pnlNotesField, 3, 0);
            tlpUniformGridPaymentFields.Dock = DockStyle.Fill;
            tlpUniformGridPaymentFields.Location = new Point(3, 3);
            tlpUniformGridPaymentFields.Margin = new Padding(3, 3, 3, 10);
            tlpUniformGridPaymentFields.Name = "tlpUniformGridPaymentFields";
            tlpUniformGridPaymentFields.RowCount = 1;
            tlpUniformGridPaymentFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniformGridPaymentFields.Size = new Size(965, 72);
            tlpUniformGridPaymentFields.TabIndex = 0;
            // 
            // pnlAmountPaidField
            // 
            pnlAmountPaidField.Controls.Add(lblAmountPaidTitle);
            pnlAmountPaidField.Controls.Add(txtAmountPaid);
            pnlAmountPaidField.Dock = DockStyle.Fill;
            pnlAmountPaidField.Location = new Point(728, 4);
            pnlAmountPaidField.Margin = new Padding(4);
            pnlAmountPaidField.Name = "pnlAmountPaidField";
            pnlAmountPaidField.Size = new Size(233, 64);
            pnlAmountPaidField.TabIndex = 0;
            // 
            // lblAmountPaidTitle
            // 
            lblAmountPaidTitle.AutoSize = true;
            lblAmountPaidTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAmountPaidTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblAmountPaidTitle.Location = new Point(148, 2);
            lblAmountPaidTitle.Name = "lblAmountPaidTitle";
            lblAmountPaidTitle.Size = new Size(78, 15);
            lblAmountPaidTitle.TabIndex = 0;
            lblAmountPaidTitle.Text = "المبلغ المدفوع";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.BorderStyle = BorderStyle.FixedSingle;
            txtAmountPaid.Dock = DockStyle.Bottom;
            txtAmountPaid.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            txtAmountPaid.ForeColor = Color.FromArgb(22, 163, 74);
            txtAmountPaid.Location = new Point(0, 36);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(233, 28);
            txtAmountPaid.TabIndex = 1;
            // 
            // pnlPaymentMethodField
            // 
            pnlPaymentMethodField.Controls.Add(lblPaymentMethodTitle);
            pnlPaymentMethodField.Controls.Add(cmbPaymentMethod);
            pnlPaymentMethodField.Dock = DockStyle.Fill;
            pnlPaymentMethodField.Location = new Point(487, 4);
            pnlPaymentMethodField.Margin = new Padding(4);
            pnlPaymentMethodField.Name = "pnlPaymentMethodField";
            pnlPaymentMethodField.Size = new Size(233, 64);
            pnlPaymentMethodField.TabIndex = 1;
            // 
            // lblPaymentMethodTitle
            // 
            lblPaymentMethodTitle.AutoSize = true;
            lblPaymentMethodTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaymentMethodTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblPaymentMethodTitle.Location = new Point(160, 2);
            lblPaymentMethodTitle.Name = "lblPaymentMethodTitle";
            lblPaymentMethodTitle.Size = new Size(68, 15);
            lblPaymentMethodTitle.TabIndex = 0;
            lblPaymentMethodTitle.Text = "طريقة الدفع";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Dock = DockStyle.Bottom;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Segoe UI", 10.5F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "نقداً", "بطاقة ائتمان", "تحويل بنكي", "تأمين صحي" });
            cmbPaymentMethod.Location = new Point(0, 37);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(233, 27);
            cmbPaymentMethod.TabIndex = 1;
            // 
            // pnlRemainingField
            // 
            pnlRemainingField.Controls.Add(lblRemainingTitle);
            pnlRemainingField.Controls.Add(txtRemainingAfterPayment);
            pnlRemainingField.Dock = DockStyle.Fill;
            pnlRemainingField.Location = new Point(246, 4);
            pnlRemainingField.Margin = new Padding(4);
            pnlRemainingField.Name = "pnlRemainingField";
            pnlRemainingField.Size = new Size(233, 64);
            pnlRemainingField.TabIndex = 2;
            // 
            // lblRemainingTitle
            // 
            lblRemainingTitle.AutoSize = true;
            lblRemainingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRemainingTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblRemainingTitle.Location = new Point(136, 2);
            lblRemainingTitle.Name = "lblRemainingTitle";
            lblRemainingTitle.Size = new Size(94, 15);
            lblRemainingTitle.TabIndex = 0;
            lblRemainingTitle.Text = "المتبقي بعد الدفع";
            // 
            // txtRemainingAfterPayment
            // 
            txtRemainingAfterPayment.BackColor = Color.FromArgb(241, 245, 249);
            txtRemainingAfterPayment.BorderStyle = BorderStyle.FixedSingle;
            txtRemainingAfterPayment.Dock = DockStyle.Bottom;
            txtRemainingAfterPayment.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            txtRemainingAfterPayment.ForeColor = Color.FromArgb(225, 29, 72);
            txtRemainingAfterPayment.Location = new Point(0, 36);
            txtRemainingAfterPayment.Name = "txtRemainingAfterPayment";
            txtRemainingAfterPayment.ReadOnly = true;
            txtRemainingAfterPayment.Size = new Size(233, 28);
            txtRemainingAfterPayment.TabIndex = 1;
            txtRemainingAfterPayment.TextChanged += txtAmount_TextChanged;
            // 
            // pnlNotesField
            // 
            pnlNotesField.Controls.Add(lblNotesTitle);
            pnlNotesField.Controls.Add(txtNotes);
            pnlNotesField.Dock = DockStyle.Fill;
            pnlNotesField.Location = new Point(4, 4);
            pnlNotesField.Margin = new Padding(4);
            pnlNotesField.Name = "pnlNotesField";
            pnlNotesField.Size = new Size(234, 64);
            pnlNotesField.TabIndex = 3;
            // 
            // lblNotesTitle
            // 
            lblNotesTitle.AutoSize = true;
            lblNotesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotesTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblNotesTitle.Location = new Point(177, 2);
            lblNotesTitle.Name = "lblNotesTitle";
            lblNotesTitle.Size = new Size(52, 15);
            lblNotesTitle.TabIndex = 0;
            lblNotesTitle.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Dock = DockStyle.Bottom;
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(0, 39);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(234, 25);
            txtNotes.TabIndex = 1;
            // 
            // pnlBrandingSplash
            // 
            pnlBrandingSplash.BackColor = Color.FromArgb(240, 253, 244);
            pnlBrandingSplash.Controls.Add(tlpBrandingCentering);
            pnlBrandingSplash.Dock = DockStyle.Fill;
            pnlBrandingSplash.Location = new Point(3, 88);
            pnlBrandingSplash.Name = "pnlBrandingSplash";
            pnlBrandingSplash.Size = new Size(965, 253);
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
            tlpBrandingCentering.Size = new Size(965, 253);
            tlpBrandingCentering.TabIndex = 0;
            // 
            // lblBrandingIcon
            // 
            lblBrandingIcon.Dock = DockStyle.Fill;
            lblBrandingIcon.Font = new Font("Segoe UI", 42F);
            lblBrandingIcon.Location = new Point(3, 0);
            lblBrandingIcon.Name = "lblBrandingIcon";
            lblBrandingIcon.Size = new Size(959, 113);
            lblBrandingIcon.TabIndex = 0;
            lblBrandingIcon.Text = "💳";
            lblBrandingIcon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblBrandingTitle
            // 
            lblBrandingTitle.Dock = DockStyle.Fill;
            lblBrandingTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBrandingTitle.ForeColor = Color.FromArgb(22, 101, 52);
            lblBrandingTitle.Location = new Point(3, 113);
            lblBrandingTitle.Name = "lblBrandingTitle";
            lblBrandingTitle.Size = new Size(959, 63);
            lblBrandingTitle.TabIndex = 1;
            lblBrandingTitle.Text = "نظام إدارة المدفوعات المالية";
            lblBrandingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandingSubtitle
            // 
            lblBrandingSubtitle.Dock = DockStyle.Fill;
            lblBrandingSubtitle.Font = new Font("Segoe UI", 11F);
            lblBrandingSubtitle.ForeColor = Color.FromArgb(22, 163, 74);
            lblBrandingSubtitle.Location = new Point(3, 176);
            lblBrandingSubtitle.Name = "lblBrandingSubtitle";
            lblBrandingSubtitle.Size = new Size(959, 77);
            lblBrandingSubtitle.TabIndex = 2;
            lblBrandingSubtitle.Text = "تأكد من مطابقة المبلغ المدفوع مع قيمة الفاتورة قبل الحفظ";
            lblBrandingSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlFooterCard
            // 
            pnlFooterCard.BackColor = Color.FromArgb(24, 32, 42);
            pnlFooterCard.Controls.Add(tlpFooterCardLayout);
            pnlFooterCard.Dock = DockStyle.Fill;
            pnlFooterCard.Location = new Point(12, 562);
            pnlFooterCard.Margin = new Padding(12);
            pnlFooterCard.Name = "pnlFooterCard";
            pnlFooterCard.Padding = new Padding(20);
            pnlFooterCard.Size = new Size(1003, 161);
            pnlFooterCard.TabIndex = 2;
            // 
            // tlpFooterCardLayout
            // 
            tlpFooterCardLayout.ColumnCount = 2;
            tlpFooterCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooterCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tlpFooterCardLayout.Controls.Add(tlpFooterLeftActions, 0, 0);
            tlpFooterCardLayout.Controls.Add(tlpFooterRightTotals, 1, 0);
            tlpFooterCardLayout.Dock = DockStyle.Fill;
            tlpFooterCardLayout.Location = new Point(20, 20);
            tlpFooterCardLayout.Name = "tlpFooterCardLayout";
            tlpFooterCardLayout.RowCount = 1;
            tlpFooterCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterCardLayout.Size = new Size(963, 121);
            tlpFooterCardLayout.TabIndex = 0;
            // 
            // tlpFooterLeftActions
            // 
            tlpFooterLeftActions.ColumnCount = 1;
            tlpFooterLeftActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Controls.Add(tlpUniformGridInvoiceSummary, 0, 0);
            tlpFooterLeftActions.Controls.Add(flpActionButtons, 0, 1);
            tlpFooterLeftActions.Dock = DockStyle.Fill;
            tlpFooterLeftActions.Location = new Point(363, 3);
            tlpFooterLeftActions.Name = "tlpFooterLeftActions";
            tlpFooterLeftActions.RowCount = 2;
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Size = new Size(597, 115);
            tlpFooterLeftActions.TabIndex = 0;
            // 
            // tlpUniformGridInvoiceSummary
            // 
            tlpUniformGridInvoiceSummary.ColumnCount = 2;
            tlpUniformGridInvoiceSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUniformGridInvoiceSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUniformGridInvoiceSummary.Controls.Add(pnlInvoiceTotalField, 0, 0);
            tlpUniformGridInvoiceSummary.Controls.Add(pnlPaidSoFarField, 1, 0);
            tlpUniformGridInvoiceSummary.Dock = DockStyle.Fill;
            tlpUniformGridInvoiceSummary.Location = new Point(20, 3);
            tlpUniformGridInvoiceSummary.Margin = new Padding(3, 3, 20, 3);
            tlpUniformGridInvoiceSummary.Name = "tlpUniformGridInvoiceSummary";
            tlpUniformGridInvoiceSummary.RowCount = 1;
            tlpUniformGridInvoiceSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniformGridInvoiceSummary.Size = new Size(574, 49);
            tlpUniformGridInvoiceSummary.TabIndex = 0;
            // 
            // pnlInvoiceTotalField
            // 
            pnlInvoiceTotalField.Controls.Add(lblInvoiceTotalTitle);
            pnlInvoiceTotalField.Controls.Add(txtInvoiceTotal);
            pnlInvoiceTotalField.Dock = DockStyle.Fill;
            pnlInvoiceTotalField.Location = new Point(297, 0);
            pnlInvoiceTotalField.Margin = new Padding(0, 0, 10, 0);
            pnlInvoiceTotalField.Name = "pnlInvoiceTotalField";
            pnlInvoiceTotalField.Size = new Size(277, 49);
            pnlInvoiceTotalField.TabIndex = 0;
            // 
            // lblInvoiceTotalTitle
            // 
            lblInvoiceTotalTitle.AutoSize = true;
            lblInvoiceTotalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInvoiceTotalTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblInvoiceTotalTitle.Location = new Point(165, 0);
            lblInvoiceTotalTitle.Name = "lblInvoiceTotalTitle";
            lblInvoiceTotalTitle.Size = new Size(106, 15);
            lblInvoiceTotalTitle.TabIndex = 0;
            lblInvoiceTotalTitle.Text = "إجمالي قيمة الفاتورة";
            // 
            // txtInvoiceTotal
            // 
            txtInvoiceTotal.BackColor = Color.FromArgb(30, 41, 59);
            txtInvoiceTotal.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceTotal.Dock = DockStyle.Bottom;
            txtInvoiceTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtInvoiceTotal.ForeColor = Color.White;
            txtInvoiceTotal.Location = new Point(0, 23);
            txtInvoiceTotal.Name = "txtInvoiceTotal";
            txtInvoiceTotal.ReadOnly = true;
            txtInvoiceTotal.Size = new Size(277, 26);
            txtInvoiceTotal.TabIndex = 1;
            txtInvoiceTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlPaidSoFarField
            // 
            pnlPaidSoFarField.Controls.Add(lblPaidSoFarTitle);
            pnlPaidSoFarField.Controls.Add(txtPaidSoFar);
            pnlPaidSoFarField.Dock = DockStyle.Fill;
            pnlPaidSoFarField.Location = new Point(0, 0);
            pnlPaidSoFarField.Margin = new Padding(0);
            pnlPaidSoFarField.Name = "pnlPaidSoFarField";
            pnlPaidSoFarField.Size = new Size(287, 49);
            pnlPaidSoFarField.TabIndex = 1;
            // 
            // lblPaidSoFarTitle
            // 
            lblPaidSoFarTitle.AutoSize = true;
            lblPaidSoFarTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPaidSoFarTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblPaidSoFarTitle.Location = new Point(175, 0);
            lblPaidSoFarTitle.Name = "lblPaidSoFarTitle";
            lblPaidSoFarTitle.Size = new Size(75, 15);
            lblPaidSoFarTitle.TabIndex = 0;
            lblPaidSoFarTitle.Text = "المدفوع سابقاً";
            // 
            // txtPaidSoFar
            // 
            txtPaidSoFar.BackColor = Color.FromArgb(30, 41, 59);
            txtPaidSoFar.BorderStyle = BorderStyle.FixedSingle;
            txtPaidSoFar.Dock = DockStyle.Bottom;
            txtPaidSoFar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPaidSoFar.ForeColor = Color.FromArgb(56, 189, 248);
            txtPaidSoFar.Location = new Point(0, 23);
            txtPaidSoFar.Name = "txtPaidSoFar";
            txtPaidSoFar.ReadOnly = true;
            txtPaidSoFar.Size = new Size(287, 26);
            txtPaidSoFar.TabIndex = 1;
            txtPaidSoFar.TextAlign = HorizontalAlignment.Center;
            // 
            // flpActionButtons
            // 
            flpActionButtons.Controls.Add(btnSavePayment);
            flpActionButtons.Controls.Add(btnNewPayment);
            flpActionButtons.Dock = DockStyle.Fill;
            flpActionButtons.Location = new Point(3, 58);
            flpActionButtons.Name = "flpActionButtons";
            flpActionButtons.Padding = new Padding(0, 4, 0, 0);
            flpActionButtons.Size = new Size(591, 54);
            flpActionButtons.TabIndex = 1;
            // 
            // btnSavePayment
            // 
            btnSavePayment.BackColor = Color.FromArgb(22, 163, 74);
            btnSavePayment.Cursor = Cursors.Hand;
            btnSavePayment.FlatAppearance.BorderSize = 0;
            btnSavePayment.FlatStyle = FlatStyle.Flat;
            btnSavePayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSavePayment.ForeColor = Color.White;
            btnSavePayment.Location = new Point(448, 7);
            btnSavePayment.Margin = new Padding(3, 3, 10, 3);
            btnSavePayment.Name = "btnSavePayment";
            btnSavePayment.Size = new Size(140, 38);
            btnSavePayment.TabIndex = 0;
            btnSavePayment.Text = "حفظ الدفعة 💾";
            btnSavePayment.UseVisualStyleBackColor = false;
            btnSavePayment.Click += btnSavePayment_Click;
            // 
            // btnNewPayment
            // 
            btnNewPayment.BackColor = Color.FromArgb(51, 65, 85);
            btnNewPayment.Cursor = Cursors.Hand;
            btnNewPayment.FlatAppearance.BorderSize = 0;
            btnNewPayment.FlatStyle = FlatStyle.Flat;
            btnNewPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewPayment.ForeColor = Color.White;
            btnNewPayment.Location = new Point(295, 7);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(140, 38);
            btnNewPayment.TabIndex = 1;
            btnNewPayment.Text = "دفعة جديدة ➕";
            btnNewPayment.UseVisualStyleBackColor = false;
            // 
            // tlpFooterRightTotals
            // 
            tlpFooterRightTotals.ColumnCount = 2;
            tlpFooterRightTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRightTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRightTotals.Controls.Add(lblAmountPaidNowTitle, 0, 0);
            tlpFooterRightTotals.Controls.Add(lblAmountPaidNowValue, 1, 0);
            tlpFooterRightTotals.Controls.Add(lblRemainingTitle2, 0, 1);
            tlpFooterRightTotals.Controls.Add(lblRemainingValue, 1, 1);
            tlpFooterRightTotals.Controls.Add(pnlFooterSeparator, 0, 2);
            tlpFooterRightTotals.Controls.Add(lblInvoiceStatusTitle, 0, 3);
            tlpFooterRightTotals.Controls.Add(lblInvoiceStatusValue, 1, 3);
            tlpFooterRightTotals.Dock = DockStyle.Fill;
            tlpFooterRightTotals.Location = new Point(3, 3);
            tlpFooterRightTotals.Name = "tlpFooterRightTotals";
            tlpFooterRightTotals.RowCount = 4;
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpFooterRightTotals.Size = new Size(354, 115);
            tlpFooterRightTotals.TabIndex = 1;
            // 
            // lblAmountPaidNowTitle
            // 
            lblAmountPaidNowTitle.AutoSize = true;
            lblAmountPaidNowTitle.Dock = DockStyle.Fill;
            lblAmountPaidNowTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAmountPaidNowTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblAmountPaidNowTitle.Location = new Point(180, 0);
            lblAmountPaidNowTitle.Name = "lblAmountPaidNowTitle";
            lblAmountPaidNowTitle.Size = new Size(171, 33);
            lblAmountPaidNowTitle.TabIndex = 0;
            lblAmountPaidNowTitle.Text = "المدفوع الآن:";
            lblAmountPaidNowTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountPaidNowValue
            // 
            lblAmountPaidNowValue.AutoSize = true;
            lblAmountPaidNowValue.Dock = DockStyle.Fill;
            lblAmountPaidNowValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAmountPaidNowValue.ForeColor = Color.FromArgb(74, 222, 128);
            lblAmountPaidNowValue.Location = new Point(3, 0);
            lblAmountPaidNowValue.Name = "lblAmountPaidNowValue";
            lblAmountPaidNowValue.Size = new Size(171, 33);
            lblAmountPaidNowValue.TabIndex = 1;
            lblAmountPaidNowValue.Text = "0.00 د.أ";
            lblAmountPaidNowValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRemainingTitle2
            // 
            lblRemainingTitle2.AutoSize = true;
            lblRemainingTitle2.Dock = DockStyle.Fill;
            lblRemainingTitle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRemainingTitle2.ForeColor = Color.FromArgb(148, 163, 184);
            lblRemainingTitle2.Location = new Point(180, 33);
            lblRemainingTitle2.Name = "lblRemainingTitle2";
            lblRemainingTitle2.Size = new Size(171, 33);
            lblRemainingTitle2.TabIndex = 2;
            lblRemainingTitle2.Text = "المتبقي بعد السداد:";
            lblRemainingTitle2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRemainingValue
            // 
            lblRemainingValue.AutoSize = true;
            lblRemainingValue.Dock = DockStyle.Fill;
            lblRemainingValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRemainingValue.ForeColor = Color.FromArgb(251, 113, 133);
            lblRemainingValue.Location = new Point(3, 33);
            lblRemainingValue.Name = "lblRemainingValue";
            lblRemainingValue.Size = new Size(171, 33);
            lblRemainingValue.TabIndex = 3;
            lblRemainingValue.Text = "0.00 د.أ";
            lblRemainingValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlFooterSeparator
            // 
            pnlFooterSeparator.BackColor = Color.FromArgb(51, 65, 85);
            tlpFooterRightTotals.SetColumnSpan(pnlFooterSeparator, 2);
            pnlFooterSeparator.Dock = DockStyle.Fill;
            pnlFooterSeparator.Location = new Point(3, 69);
            pnlFooterSeparator.Name = "pnlFooterSeparator";
            pnlFooterSeparator.Size = new Size(348, 1);
            pnlFooterSeparator.TabIndex = 4;
            // 
            // lblInvoiceStatusTitle
            // 
            lblInvoiceStatusTitle.AutoSize = true;
            lblInvoiceStatusTitle.Dock = DockStyle.Fill;
            lblInvoiceStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInvoiceStatusTitle.ForeColor = Color.FromArgb(226, 232, 240);
            lblInvoiceStatusTitle.Location = new Point(180, 68);
            lblInvoiceStatusTitle.Name = "lblInvoiceStatusTitle";
            lblInvoiceStatusTitle.Size = new Size(171, 47);
            lblInvoiceStatusTitle.TabIndex = 5;
            lblInvoiceStatusTitle.Text = "حالة الفاتورة:";
            lblInvoiceStatusTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceStatusValue
            // 
            lblInvoiceStatusValue.AutoSize = true;
            lblInvoiceStatusValue.Dock = DockStyle.Fill;
            lblInvoiceStatusValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInvoiceStatusValue.ForeColor = Color.FromArgb(250, 204, 21);
            lblInvoiceStatusValue.Location = new Point(3, 68);
            lblInvoiceStatusValue.Name = "lblInvoiceStatusValue";
            lblInvoiceStatusValue.Size = new Size(171, 47);
            lblInvoiceStatusValue.TabIndex = 6;
            lblInvoiceStatusValue.Text = "غير محددة";
            lblInvoiceStatusValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // epPayment
            // 
            epPayment.ContainerControl = this;
            // 
            // frmPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 749);
            Controls.Add(mainPanel);
            Name = "frmPayments";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة إصدار دفعة مالية";
            WindowState = FormWindowState.Maximized;
            Load += frmPayments_Load;
            mainPanel.ResumeLayout(false);
            scrollContainer.ResumeLayout(false);
            tlpTabNewRoot.ResumeLayout(false);
            pnlPaymentMetaCard.ResumeLayout(false);
            tlpMetaCardLayout.ResumeLayout(false);
            flpMetaFieldsLeft.ResumeLayout(false);
            pnlChooseInvoice.ResumeLayout(false);
            pnlChooseInvoice.PerformLayout();
            flpMetaFieldRight.ResumeLayout(false);
            flpMetaFieldRight.PerformLayout();
            pnlDetailsCard.ResumeLayout(false);
            tlpDetailsCardLayout.ResumeLayout(false);
            tlpUniformGridPaymentFields.ResumeLayout(false);
            pnlAmountPaidField.ResumeLayout(false);
            pnlAmountPaidField.PerformLayout();
            pnlPaymentMethodField.ResumeLayout(false);
            pnlPaymentMethodField.PerformLayout();
            pnlRemainingField.ResumeLayout(false);
            pnlRemainingField.PerformLayout();
            pnlNotesField.ResumeLayout(false);
            pnlNotesField.PerformLayout();
            pnlBrandingSplash.ResumeLayout(false);
            tlpBrandingCentering.ResumeLayout(false);
            pnlFooterCard.ResumeLayout(false);
            tlpFooterCardLayout.ResumeLayout(false);
            tlpFooterLeftActions.ResumeLayout(false);
            tlpUniformGridInvoiceSummary.ResumeLayout(false);
            pnlInvoiceTotalField.ResumeLayout(false);
            pnlInvoiceTotalField.PerformLayout();
            pnlPaidSoFarField.ResumeLayout(false);
            pnlPaidSoFarField.PerformLayout();
            flpActionButtons.ResumeLayout(false);
            tlpFooterRightTotals.ResumeLayout(false);
            tlpFooterRightTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel scrollContainer;
        private TableLayoutPanel tlpTabNewRoot;
        private Panel pnlPaymentMetaCard;
        private TableLayoutPanel tlpMetaCardLayout;
        private FlowLayoutPanel flpMetaFieldsLeft;
        private Label lblMetaTitle;
        private Panel pnlChooseInvoice;
        private TextBox txtInvoiceId;
        private Button btnChooseInvoice;
        private Label lblChooseInvoiceCaption;
        private FlowLayoutPanel flpMetaFieldRight;
        private Label lblPaymentDateTitle;
        private DateTimePicker dtpPaymentDate;
        private Panel pnlDetailsCard;
        private TableLayoutPanel tlpDetailsCardLayout;
        private TableLayoutPanel tlpUniformGridPaymentFields;
        private Panel pnlAmountPaidField;
        private Label lblAmountPaidTitle;
        private TextBox txtAmountPaid;
        private Panel pnlPaymentMethodField;
        private Label lblPaymentMethodTitle;
        private ComboBox cmbPaymentMethod;
        private Panel pnlRemainingField;
        private Label lblRemainingTitle;
        private TextBox txtRemainingAfterPayment;
        private Panel pnlNotesField;
        private Label lblNotesTitle;
        private TextBox txtNotes;
        private Panel pnlBrandingSplash;
        private TableLayoutPanel tlpBrandingCentering;
        private Label lblBrandingIcon;
        private Label lblBrandingTitle;
        private Label lblBrandingSubtitle;
        private Panel pnlFooterCard;
        private TableLayoutPanel tlpFooterCardLayout;
        private TableLayoutPanel tlpFooterLeftActions;
        private TableLayoutPanel tlpUniformGridInvoiceSummary;
        private Panel pnlInvoiceTotalField;
        private Label lblInvoiceTotalTitle;
        private TextBox txtInvoiceTotal;
        private Panel pnlPaidSoFarField;
        private Label lblPaidSoFarTitle;
        private TextBox txtPaidSoFar;
        private FlowLayoutPanel flpActionButtons;
        private Button btnSavePayment;
        private Button btnNewPayment;
        private TableLayoutPanel tlpFooterRightTotals;
        private Label lblAmountPaidNowTitle;
        private Label lblAmountPaidNowValue;
        private Label lblRemainingTitle2;
        private Label lblRemainingValue;
        private Panel pnlFooterSeparator;
        private Label lblInvoiceStatusTitle;
        private Label lblInvoiceStatusValue;
        private ErrorProvider epPayment;
    }
}