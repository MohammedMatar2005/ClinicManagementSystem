using System;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            tabControl = new TabControl();
            tabNewPayment = new TabPage();
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
            tabPaymentsHistory = new TabPage();
            pnlHistoryCard = new Panel();
            tlpHistoryLayout = new TableLayoutPanel();
            flpHistoryHeader = new FlowLayoutPanel();
            lblHistoryTitle = new Label();
            btnExportPdf = new Button();
            btnExportThisPayment = new Button();
            txtSearchValue = new TextBox();
            dgvPayments = new DataGridView();
            colPaymentId = new DataGridViewTextBoxColumn();
            colInvoiceNumber = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colAmountPaid = new DataGridViewTextBoxColumn();
            colPaymentDate = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colInvoiceStatus = new DataGridViewTextBoxColumn();
            epPayment = new ErrorProvider(components);
            mainPanel.SuspendLayout();
            tabControl.SuspendLayout();
            tabNewPayment.SuspendLayout();
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
            tabPaymentsHistory.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            tlpHistoryLayout.SuspendLayout();
            flpHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epPayment).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(244, 247, 250);
            mainPanel.Controls.Add(tabControl);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(1084, 749);
            mainPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNewPayment);
            tabControl.Controls.Add(tabPaymentsHistory);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.ItemSize = new Size(180, 45);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1064, 729);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabNewPayment
            // 
            tabNewPayment.BackColor = Color.Transparent;
            tabNewPayment.Controls.Add(scrollContainer);
            tabNewPayment.Location = new Point(4, 49);
            tabNewPayment.Name = "tabNewPayment";
            tabNewPayment.Size = new Size(1056, 676);
            tabNewPayment.TabIndex = 0;
            tabNewPayment.Text = "إضافة دفعة جديدة";
            // 
            // scrollContainer
            // 
            scrollContainer.AutoScroll = true;
            scrollContainer.Controls.Add(tlpTabNewRoot);
            scrollContainer.Dock = DockStyle.Fill;
            scrollContainer.Location = new Point(0, 0);
            scrollContainer.Name = "scrollContainer";
            scrollContainer.Size = new Size(1056, 676);
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
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabNewRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tlpTabNewRoot.Size = new Size(1039, 760);
            tlpTabNewRoot.TabIndex = 0;
            // 
            // pnlPaymentMetaCard
            // 
            pnlPaymentMetaCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPaymentMetaCard.BackColor = Color.White;
            pnlPaymentMetaCard.Controls.Add(tlpMetaCardLayout);
            pnlPaymentMetaCard.Location = new Point(10, 10);
            pnlPaymentMetaCard.Margin = new Padding(10);
            pnlPaymentMetaCard.Name = "pnlPaymentMetaCard";
            pnlPaymentMetaCard.Padding = new Padding(20);
            pnlPaymentMetaCard.Size = new Size(1019, 140);
            pnlPaymentMetaCard.TabIndex = 0;
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
            tlpMetaCardLayout.Size = new Size(979, 100);
            tlpMetaCardLayout.TabIndex = 0;
            // 
            // flpMetaFieldsLeft
            // 
            flpMetaFieldsLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldsLeft.Controls.Add(lblMetaTitle);
            flpMetaFieldsLeft.Controls.Add(pnlChooseInvoice);
            flpMetaFieldsLeft.FlowDirection = FlowDirection.TopDown;
            flpMetaFieldsLeft.Location = new Point(183, 3);
            flpMetaFieldsLeft.Name = "flpMetaFieldsLeft";
            flpMetaFieldsLeft.Size = new Size(793, 94);
            flpMetaFieldsLeft.TabIndex = 0;
            flpMetaFieldsLeft.WrapContents = false;
            // 
            // lblMetaTitle
            // 
            flpMetaFieldsLeft.SetFlowBreak(lblMetaTitle, true);
            lblMetaTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblMetaTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblMetaTitle.Location = new Point(3, 0);
            lblMetaTitle.Name = "lblMetaTitle";
            lblMetaTitle.Size = new Size(787, 30);
            lblMetaTitle.TabIndex = 0;
            lblMetaTitle.Text = "بيانات الدفعة";
            // 
            // pnlChooseInvoice
            // 
            pnlChooseInvoice.Controls.Add(txtInvoiceId);
            pnlChooseInvoice.Controls.Add(btnChooseInvoice);
            pnlChooseInvoice.Controls.Add(lblChooseInvoiceCaption);
            pnlChooseInvoice.Location = new Point(493, 30);
            pnlChooseInvoice.Margin = new Padding(0, 0, 20, 0);
            pnlChooseInvoice.Name = "pnlChooseInvoice";
            pnlChooseInvoice.Size = new Size(300, 63);
            pnlChooseInvoice.TabIndex = 4;
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Location = new Point(153, 31);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(144, 29);
            txtInvoiceId.TabIndex = 7;
            // 
            // btnChooseInvoice
            // 
            btnChooseInvoice.BackColor = Color.FromArgb(46, 204, 113);
            btnChooseInvoice.FlatStyle = FlatStyle.Flat;
            btnChooseInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnChooseInvoice.ForeColor = Color.White;
            btnChooseInvoice.Location = new Point(7, 20);
            btnChooseInvoice.Margin = new Padding(5, 30, 5, 5);
            btnChooseInvoice.Name = "btnChooseInvoice";
            btnChooseInvoice.Size = new Size(120, 38);
            btnChooseInvoice.TabIndex = 6;
            btnChooseInvoice.Text = "اختر فاتورة";
            btnChooseInvoice.UseVisualStyleBackColor = false;
            // 
            // lblChooseInvoiceCaption
            // 
            lblChooseInvoiceCaption.Dock = DockStyle.Top;
            lblChooseInvoiceCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChooseInvoiceCaption.ForeColor = Color.FromArgb(93, 122, 149);
            lblChooseInvoiceCaption.Location = new Point(0, 0);
            lblChooseInvoiceCaption.Name = "lblChooseInvoiceCaption";
            lblChooseInvoiceCaption.RightToLeft = RightToLeft.No;
            lblChooseInvoiceCaption.Size = new Size(300, 22);
            lblChooseInvoiceCaption.TabIndex = 4;
            lblChooseInvoiceCaption.Text = "اختر الفاتورة المرتبطة بالدفعة";
            lblChooseInvoiceCaption.TextAlign = ContentAlignment.TopRight;
            // 
            // flpMetaFieldRight
            // 
            flpMetaFieldRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMetaFieldRight.Controls.Add(lblPaymentDateTitle);
            flpMetaFieldRight.Controls.Add(dtpPaymentDate);
            flpMetaFieldRight.FlowDirection = FlowDirection.RightToLeft;
            flpMetaFieldRight.Location = new Point(3, 3);
            flpMetaFieldRight.Name = "flpMetaFieldRight";
            flpMetaFieldRight.Padding = new Padding(0, 33, 0, 0);
            flpMetaFieldRight.Size = new Size(174, 94);
            flpMetaFieldRight.TabIndex = 1;
            // 
            // lblPaymentDateTitle
            // 
            lblPaymentDateTitle.AutoSize = true;
            lblPaymentDateTitle.Font = new Font("Segoe UI", 9F);
            lblPaymentDateTitle.ForeColor = Color.FromArgb(143, 163, 184);
            lblPaymentDateTitle.Location = new Point(0, 33);
            lblPaymentDateTitle.Margin = new Padding(0, 0, 0, 5);
            lblPaymentDateTitle.Name = "lblPaymentDateTitle";
            lblPaymentDateTitle.Size = new Size(66, 15);
            lblPaymentDateTitle.TabIndex = 0;
            lblPaymentDateTitle.Text = "تاريخ الدفعة";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 11.25F);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(0, 53);
            dtpPaymentDate.Margin = new Padding(0);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(150, 27);
            dtpPaymentDate.TabIndex = 1;
            // 
            // pnlDetailsCard
            // 
            pnlDetailsCard.BackColor = Color.White;
            pnlDetailsCard.Controls.Add(tlpDetailsCardLayout);
            pnlDetailsCard.Dock = DockStyle.Fill;
            pnlDetailsCard.Location = new Point(10, 170);
            pnlDetailsCard.Margin = new Padding(10);
            pnlDetailsCard.Name = "pnlDetailsCard";
            pnlDetailsCard.Padding = new Padding(20);
            pnlDetailsCard.Size = new Size(1019, 390);
            pnlDetailsCard.TabIndex = 1;
            // 
            // tlpDetailsCardLayout
            // 
            tlpDetailsCardLayout.ColumnCount = 1;
            tlpDetailsCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetailsCardLayout.Controls.Add(tlpUniformGridPaymentFields, 0, 0);
            tlpDetailsCardLayout.Controls.Add(pnlBrandingSplash, 0, 1);
            tlpDetailsCardLayout.Dock = DockStyle.Fill;
            tlpDetailsCardLayout.Location = new Point(20, 20);
            tlpDetailsCardLayout.Name = "tlpDetailsCardLayout";
            tlpDetailsCardLayout.RowCount = 2;
            tlpDetailsCardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpDetailsCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetailsCardLayout.Size = new Size(979, 350);
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
            tlpUniformGridPaymentFields.Margin = new Padding(3, 3, 3, 20);
            tlpUniformGridPaymentFields.Name = "tlpUniformGridPaymentFields";
            tlpUniformGridPaymentFields.RowCount = 1;
            tlpUniformGridPaymentFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniformGridPaymentFields.Size = new Size(973, 67);
            tlpUniformGridPaymentFields.TabIndex = 0;
            // 
            // pnlAmountPaidField
            // 
            pnlAmountPaidField.Controls.Add(lblAmountPaidTitle);
            pnlAmountPaidField.Controls.Add(txtAmountPaid);
            pnlAmountPaidField.Dock = DockStyle.Fill;
            pnlAmountPaidField.Location = new Point(735, 5);
            pnlAmountPaidField.Margin = new Padding(5);
            pnlAmountPaidField.Name = "pnlAmountPaidField";
            pnlAmountPaidField.Size = new Size(233, 57);
            pnlAmountPaidField.TabIndex = 0;
            // 
            // lblAmountPaidTitle
            // 
            lblAmountPaidTitle.AutoSize = true;
            lblAmountPaidTitle.Font = new Font("Segoe UI", 9F);
            lblAmountPaidTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblAmountPaidTitle.Location = new Point(157, 0);
            lblAmountPaidTitle.Name = "lblAmountPaidTitle";
            lblAmountPaidTitle.Size = new Size(78, 15);
            lblAmountPaidTitle.TabIndex = 0;
            lblAmountPaidTitle.Text = "المبلغ المدفوع";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Dock = DockStyle.Bottom;
            txtAmountPaid.Font = new Font("Segoe UI", 11.25F);
            txtAmountPaid.Location = new Point(0, 19);
            txtAmountPaid.Multiline = true;
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(233, 38);
            txtAmountPaid.TabIndex = 1;
            // 
            // pnlPaymentMethodField
            // 
            pnlPaymentMethodField.Controls.Add(lblPaymentMethodTitle);
            pnlPaymentMethodField.Controls.Add(cmbPaymentMethod);
            pnlPaymentMethodField.Dock = DockStyle.Fill;
            pnlPaymentMethodField.Location = new Point(492, 5);
            pnlPaymentMethodField.Margin = new Padding(5);
            pnlPaymentMethodField.Name = "pnlPaymentMethodField";
            pnlPaymentMethodField.Size = new Size(233, 57);
            pnlPaymentMethodField.TabIndex = 1;
            // 
            // lblPaymentMethodTitle
            // 
            lblPaymentMethodTitle.AutoSize = true;
            lblPaymentMethodTitle.Font = new Font("Segoe UI", 9F);
            lblPaymentMethodTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblPaymentMethodTitle.Location = new Point(161, 0);
            lblPaymentMethodTitle.Name = "lblPaymentMethodTitle";
            lblPaymentMethodTitle.Size = new Size(68, 15);
            lblPaymentMethodTitle.TabIndex = 0;
            lblPaymentMethodTitle.Text = "طريقة الدفع";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Dock = DockStyle.Bottom;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Segoe UI", 11.25F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "نقداً", "بطاقة ائتمان", "تحويل بنكي", "تأمين صحي" });
            cmbPaymentMethod.Location = new Point(0, 29);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(233, 28);
            cmbPaymentMethod.TabIndex = 1;
            // 
            // pnlRemainingField
            // 
            pnlRemainingField.Controls.Add(lblRemainingTitle);
            pnlRemainingField.Controls.Add(txtRemainingAfterPayment);
            pnlRemainingField.Dock = DockStyle.Fill;
            pnlRemainingField.Location = new Point(249, 5);
            pnlRemainingField.Margin = new Padding(5);
            pnlRemainingField.Name = "pnlRemainingField";
            pnlRemainingField.Size = new Size(233, 57);
            pnlRemainingField.TabIndex = 2;
            // 
            // lblRemainingTitle
            // 
            lblRemainingTitle.AutoSize = true;
            lblRemainingTitle.Font = new Font("Segoe UI", 9F);
            lblRemainingTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblRemainingTitle.Location = new Point(149, 0);
            lblRemainingTitle.Name = "lblRemainingTitle";
            lblRemainingTitle.Size = new Size(94, 15);
            lblRemainingTitle.TabIndex = 0;
            lblRemainingTitle.Text = "المتبقي بعد الدفع";
            // 
            // txtRemainingAfterPayment
            // 
            txtRemainingAfterPayment.BackColor = Color.FromArgb(244, 247, 250);
            txtRemainingAfterPayment.Dock = DockStyle.Bottom;
            txtRemainingAfterPayment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtRemainingAfterPayment.Location = new Point(0, 19);
            txtRemainingAfterPayment.Multiline = true;
            txtRemainingAfterPayment.Name = "txtRemainingAfterPayment";
            txtRemainingAfterPayment.ReadOnly = true;
            txtRemainingAfterPayment.Size = new Size(233, 38);
            txtRemainingAfterPayment.TabIndex = 1;
            // 
            // pnlNotesField
            // 
            pnlNotesField.Controls.Add(lblNotesTitle);
            pnlNotesField.Controls.Add(txtNotes);
            pnlNotesField.Dock = DockStyle.Fill;
            pnlNotesField.Location = new Point(5, 5);
            pnlNotesField.Margin = new Padding(5);
            pnlNotesField.Name = "pnlNotesField";
            pnlNotesField.Size = new Size(234, 57);
            pnlNotesField.TabIndex = 3;
            // 
            // lblNotesTitle
            // 
            lblNotesTitle.AutoSize = true;
            lblNotesTitle.Font = new Font("Segoe UI", 9F);
            lblNotesTitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblNotesTitle.Location = new Point(191, 0);
            lblNotesTitle.Name = "lblNotesTitle";
            lblNotesTitle.Size = new Size(52, 15);
            lblNotesTitle.TabIndex = 0;
            lblNotesTitle.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Bottom;
            txtNotes.Font = new Font("Segoe UI", 11.25F);
            txtNotes.Location = new Point(0, 19);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(234, 38);
            txtNotes.TabIndex = 1;
            // 
            // pnlBrandingSplash
            // 
            pnlBrandingSplash.BackColor = Color.FromArgb(232, 245, 233);
            pnlBrandingSplash.Controls.Add(tlpBrandingCentering);
            pnlBrandingSplash.Dock = DockStyle.Fill;
            pnlBrandingSplash.Location = new Point(3, 93);
            pnlBrandingSplash.Name = "pnlBrandingSplash";
            pnlBrandingSplash.Size = new Size(973, 254);
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
            tlpBrandingCentering.Size = new Size(973, 254);
            tlpBrandingCentering.TabIndex = 0;
            // 
            // lblBrandingIcon
            // 
            lblBrandingIcon.Dock = DockStyle.Fill;
            lblBrandingIcon.Font = new Font("Segoe UI", 48F);
            lblBrandingIcon.Location = new Point(3, 0);
            lblBrandingIcon.Name = "lblBrandingIcon";
            lblBrandingIcon.Size = new Size(967, 114);
            lblBrandingIcon.TabIndex = 0;
            lblBrandingIcon.Text = "💳";
            lblBrandingIcon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblBrandingTitle
            // 
            lblBrandingTitle.Dock = DockStyle.Fill;
            lblBrandingTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblBrandingTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblBrandingTitle.Location = new Point(3, 114);
            lblBrandingTitle.Name = "lblBrandingTitle";
            lblBrandingTitle.Size = new Size(967, 63);
            lblBrandingTitle.TabIndex = 1;
            lblBrandingTitle.Text = "نظام إدارة المدفوعات المالية";
            lblBrandingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandingSubtitle
            // 
            lblBrandingSubtitle.Dock = DockStyle.Fill;
            lblBrandingSubtitle.Font = new Font("Segoe UI", 12F);
            lblBrandingSubtitle.ForeColor = Color.FromArgb(102, 187, 106);
            lblBrandingSubtitle.Location = new Point(3, 177);
            lblBrandingSubtitle.Name = "lblBrandingSubtitle";
            lblBrandingSubtitle.Size = new Size(967, 77);
            lblBrandingSubtitle.TabIndex = 2;
            lblBrandingSubtitle.Text = "تأكد من مطابقة المبلغ المدفوع مع قيمة الفاتورة قبل الحفظ";
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
            pnlFooterCard.Size = new Size(1019, 170);
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
            tlpFooterCardLayout.Size = new Size(969, 120);
            tlpFooterCardLayout.TabIndex = 0;
            // 
            // tlpFooterLeftActions
            // 
            tlpFooterLeftActions.ColumnCount = 1;
            tlpFooterLeftActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Controls.Add(tlpUniformGridInvoiceSummary, 0, 0);
            tlpFooterLeftActions.Controls.Add(flpActionButtons, 0, 1);
            tlpFooterLeftActions.Dock = DockStyle.Fill;
            tlpFooterLeftActions.Location = new Point(353, 3);
            tlpFooterLeftActions.Name = "tlpFooterLeftActions";
            tlpFooterLeftActions.RowCount = 2;
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpFooterLeftActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterLeftActions.Size = new Size(613, 114);
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
            tlpUniformGridInvoiceSummary.Size = new Size(590, 54);
            tlpUniformGridInvoiceSummary.TabIndex = 0;
            // 
            // pnlInvoiceTotalField
            // 
            pnlInvoiceTotalField.Controls.Add(lblInvoiceTotalTitle);
            pnlInvoiceTotalField.Controls.Add(txtInvoiceTotal);
            pnlInvoiceTotalField.Dock = DockStyle.Fill;
            pnlInvoiceTotalField.Location = new Point(305, 0);
            pnlInvoiceTotalField.Margin = new Padding(0, 0, 10, 0);
            pnlInvoiceTotalField.Name = "pnlInvoiceTotalField";
            pnlInvoiceTotalField.Size = new Size(285, 54);
            pnlInvoiceTotalField.TabIndex = 0;
            // 
            // lblInvoiceTotalTitle
            // 
            lblInvoiceTotalTitle.AutoSize = true;
            lblInvoiceTotalTitle.Font = new Font("Segoe UI", 9F);
            lblInvoiceTotalTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblInvoiceTotalTitle.Location = new Point(232, 0);
            lblInvoiceTotalTitle.Name = "lblInvoiceTotalTitle";
            lblInvoiceTotalTitle.Size = new Size(80, 15);
            lblInvoiceTotalTitle.TabIndex = 0;
            lblInvoiceTotalTitle.Text = "إجمالي الفاتورة";
            // 
            // txtInvoiceTotal
            // 
            txtInvoiceTotal.BackColor = Color.FromArgb(44, 62, 80);
            txtInvoiceTotal.BorderStyle = BorderStyle.None;
            txtInvoiceTotal.Dock = DockStyle.Bottom;
            txtInvoiceTotal.Font = new Font("Segoe UI", 11.25F);
            txtInvoiceTotal.ForeColor = Color.White;
            txtInvoiceTotal.Location = new Point(0, 19);
            txtInvoiceTotal.Multiline = true;
            txtInvoiceTotal.Name = "txtInvoiceTotal";
            txtInvoiceTotal.ReadOnly = true;
            txtInvoiceTotal.Size = new Size(285, 35);
            txtInvoiceTotal.TabIndex = 1;
            // 
            // pnlPaidSoFarField
            // 
            pnlPaidSoFarField.Controls.Add(lblPaidSoFarTitle);
            pnlPaidSoFarField.Controls.Add(txtPaidSoFar);
            pnlPaidSoFarField.Dock = DockStyle.Fill;
            pnlPaidSoFarField.Location = new Point(0, 0);
            pnlPaidSoFarField.Margin = new Padding(0);
            pnlPaidSoFarField.Name = "pnlPaidSoFarField";
            pnlPaidSoFarField.Size = new Size(295, 54);
            pnlPaidSoFarField.TabIndex = 1;
            // 
            // lblPaidSoFarTitle
            // 
            lblPaidSoFarTitle.AutoSize = true;
            lblPaidSoFarTitle.Font = new Font("Segoe UI", 9F);
            lblPaidSoFarTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblPaidSoFarTitle.Location = new Point(240, 0);
            lblPaidSoFarTitle.Name = "lblPaidSoFarTitle";
            lblPaidSoFarTitle.Size = new Size(68, 15);
            lblPaidSoFarTitle.TabIndex = 0;
            lblPaidSoFarTitle.Text = "مدفوع سابقاً";
            // 
            // txtPaidSoFar
            // 
            txtPaidSoFar.BackColor = Color.FromArgb(44, 62, 80);
            txtPaidSoFar.BorderStyle = BorderStyle.None;
            txtPaidSoFar.Dock = DockStyle.Bottom;
            txtPaidSoFar.Font = new Font("Segoe UI", 11.25F);
            txtPaidSoFar.ForeColor = Color.White;
            txtPaidSoFar.Location = new Point(0, 19);
            txtPaidSoFar.Multiline = true;
            txtPaidSoFar.Name = "txtPaidSoFar";
            txtPaidSoFar.ReadOnly = true;
            txtPaidSoFar.Size = new Size(295, 35);
            txtPaidSoFar.TabIndex = 1;
            // 
            // flpActionButtons
            // 
            flpActionButtons.Controls.Add(btnSavePayment);
            flpActionButtons.Controls.Add(btnNewPayment);
            flpActionButtons.Dock = DockStyle.Fill;
            flpActionButtons.Location = new Point(3, 63);
            flpActionButtons.Name = "flpActionButtons";
            flpActionButtons.Size = new Size(607, 48);
            flpActionButtons.TabIndex = 1;
            // 
            // btnSavePayment
            // 
            btnSavePayment.BackColor = Color.FromArgb(39, 174, 96);
            btnSavePayment.FlatAppearance.BorderSize = 0;
            btnSavePayment.FlatStyle = FlatStyle.Flat;
            btnSavePayment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSavePayment.ForeColor = Color.White;
            btnSavePayment.Location = new Point(447, 3);
            btnSavePayment.Margin = new Padding(0, 3, 10, 3);
            btnSavePayment.Name = "btnSavePayment";
            btnSavePayment.Size = new Size(160, 45);
            btnSavePayment.TabIndex = 0;
            btnSavePayment.Text = "✅ حفظ الدفعة";
            btnSavePayment.UseVisualStyleBackColor = false;
            btnSavePayment.Click += btnSavePayment_Click_1;
            // 
            // btnNewPayment
            // 
            btnNewPayment.BackColor = Color.FromArgb(127, 142, 141);
            btnNewPayment.FlatAppearance.BorderSize = 0;
            btnNewPayment.FlatStyle = FlatStyle.Flat;
            btnNewPayment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnNewPayment.ForeColor = Color.White;
            btnNewPayment.Location = new Point(274, 3);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(160, 45);
            btnNewPayment.TabIndex = 1;
            btnNewPayment.Text = "🔄 دفعة جديدة";
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
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpFooterRightTotals.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterRightTotals.Size = new Size(344, 114);
            tlpFooterRightTotals.TabIndex = 1;
            // 
            // lblAmountPaidNowTitle
            // 
            lblAmountPaidNowTitle.Dock = DockStyle.Fill;
            lblAmountPaidNowTitle.Font = new Font("Segoe UI", 10F);
            lblAmountPaidNowTitle.ForeColor = Color.FromArgb(171, 178, 185);
            lblAmountPaidNowTitle.Location = new Point(175, 0);
            lblAmountPaidNowTitle.Name = "lblAmountPaidNowTitle";
            lblAmountPaidNowTitle.Size = new Size(166, 28);
            lblAmountPaidNowTitle.TabIndex = 0;
            lblAmountPaidNowTitle.Text = "المبلغ المدفوع الآن:";
            lblAmountPaidNowTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountPaidNowValue
            // 
            lblAmountPaidNowValue.Dock = DockStyle.Fill;
            lblAmountPaidNowValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAmountPaidNowValue.ForeColor = Color.White;
            lblAmountPaidNowValue.Location = new Point(3, 0);
            lblAmountPaidNowValue.Name = "lblAmountPaidNowValue";
            lblAmountPaidNowValue.Size = new Size(166, 28);
            lblAmountPaidNowValue.TabIndex = 1;
            lblAmountPaidNowValue.Text = "0.00";
            lblAmountPaidNowValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRemainingTitle2
            // 
            lblRemainingTitle2.Dock = DockStyle.Fill;
            lblRemainingTitle2.Font = new Font("Segoe UI", 10F);
            lblRemainingTitle2.ForeColor = Color.FromArgb(171, 178, 185);
            lblRemainingTitle2.Location = new Point(175, 28);
            lblRemainingTitle2.Name = "lblRemainingTitle2";
            lblRemainingTitle2.Size = new Size(166, 28);
            lblRemainingTitle2.TabIndex = 2;
            lblRemainingTitle2.Text = "المبلغ المتبقي:";
            lblRemainingTitle2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRemainingValue
            // 
            lblRemainingValue.Dock = DockStyle.Fill;
            lblRemainingValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRemainingValue.ForeColor = Color.FromArgb(231, 76, 60);
            lblRemainingValue.Location = new Point(3, 28);
            lblRemainingValue.Name = "lblRemainingValue";
            lblRemainingValue.Size = new Size(166, 28);
            lblRemainingValue.TabIndex = 3;
            lblRemainingValue.Text = "0.00";
            lblRemainingValue.TextAlign = ContentAlignment.MiddleRight;
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
            // lblInvoiceStatusTitle
            // 
            lblInvoiceStatusTitle.Dock = DockStyle.Fill;
            lblInvoiceStatusTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInvoiceStatusTitle.ForeColor = Color.White;
            lblInvoiceStatusTitle.Location = new Point(175, 71);
            lblInvoiceStatusTitle.Name = "lblInvoiceStatusTitle";
            lblInvoiceStatusTitle.Size = new Size(166, 43);
            lblInvoiceStatusTitle.TabIndex = 5;
            lblInvoiceStatusTitle.Text = "حالة الفاتورة:";
            lblInvoiceStatusTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceStatusValue
            // 
            lblInvoiceStatusValue.Dock = DockStyle.Fill;
            lblInvoiceStatusValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInvoiceStatusValue.ForeColor = Color.FromArgb(231, 76, 60);
            lblInvoiceStatusValue.Location = new Point(3, 71);
            lblInvoiceStatusValue.Name = "lblInvoiceStatusValue";
            lblInvoiceStatusValue.Size = new Size(166, 43);
            lblInvoiceStatusValue.TabIndex = 6;
            lblInvoiceStatusValue.Text = "غير مدفوعة";
            lblInvoiceStatusValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPaymentsHistory
            // 
            tabPaymentsHistory.BackColor = Color.Transparent;
            tabPaymentsHistory.Controls.Add(pnlHistoryCard);
            tabPaymentsHistory.Location = new Point(4, 49);
            tabPaymentsHistory.Name = "tabPaymentsHistory";
            tabPaymentsHistory.Size = new Size(1056, 676);
            tabPaymentsHistory.TabIndex = 1;
            tabPaymentsHistory.Text = "سجل الدفعات";
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
            pnlHistoryCard.Size = new Size(1056, 676);
            pnlHistoryCard.TabIndex = 0;
            // 
            // tlpHistoryLayout
            // 
            tlpHistoryLayout.ColumnCount = 1;
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Controls.Add(flpHistoryHeader, 0, 0);
            tlpHistoryLayout.Controls.Add(dgvPayments, 0, 1);
            tlpHistoryLayout.Dock = DockStyle.Fill;
            tlpHistoryLayout.Location = new Point(20, 20);
            tlpHistoryLayout.Name = "tlpHistoryLayout";
            tlpHistoryLayout.RowCount = 2;
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Size = new Size(1016, 636);
            tlpHistoryLayout.TabIndex = 0;
            // 
            // flpHistoryHeader
            // 
            flpHistoryHeader.Controls.Add(lblHistoryTitle);
            flpHistoryHeader.Controls.Add(btnExportPdf);
            flpHistoryHeader.Controls.Add(btnExportThisPayment);
            flpHistoryHeader.Controls.Add(txtSearchValue);
            flpHistoryHeader.Dock = DockStyle.Fill;
            flpHistoryHeader.FlowDirection = FlowDirection.RightToLeft;
            flpHistoryHeader.Location = new Point(3, 3);
            flpHistoryHeader.Name = "flpHistoryHeader";
            flpHistoryHeader.Size = new Size(1010, 44);
            flpHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(26, 37, 51);
            lblHistoryTitle.Location = new Point(3, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(250, 40);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "قائمة الدفعات المسجلة";
            lblHistoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(22, 160, 133);
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(286, 3);
            btnExportPdf.Margin = new Padding(0, 3, 30, 3);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Padding = new Padding(15, 0, 15, 0);
            btnExportPdf.Size = new Size(197, 38);
            btnExportPdf.TabIndex = 1;
            btnExportPdf.Text = "📄 تصدير الكل إلى PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // btnExportThisPayment
            // 
            btnExportThisPayment.BackColor = Color.FromArgb(52, 152, 219);
            btnExportThisPayment.FlatAppearance.BorderSize = 0;
            btnExportThisPayment.FlatStyle = FlatStyle.Flat;
            btnExportThisPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExportThisPayment.ForeColor = Color.White;
            btnExportThisPayment.Location = new Point(513, 3);
            btnExportThisPayment.Margin = new Padding(0, 3, 30, 3);
            btnExportThisPayment.Name = "btnExportThisPayment";
            btnExportThisPayment.Padding = new Padding(15, 0, 15, 0);
            btnExportThisPayment.Size = new Size(197, 38);
            btnExportThisPayment.TabIndex = 3;
            btnExportThisPayment.Text = "تصدير إلى PDF 📄";
            btnExportThisPayment.UseVisualStyleBackColor = false;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Anchor = AnchorStyles.None;
            txtSearchValue.BorderStyle = BorderStyle.FixedSingle;
            txtSearchValue.ForeColor = Color.Gray;
            txtSearchValue.Location = new Point(713, 7);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(260, 29);
            txtSearchValue.TabIndex = 2;
            txtSearchValue.Text = "🔍 أدخل رقم الفاتورة أو اسم المريض للبحث السريع...";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 247, 250);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.ColumnHeadersHeight = 45;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colPaymentId, colInvoiceNumber, colPatientName, colAmountPaid, colPaymentDate, colPaymentMethod, colInvoiceStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 243, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.FromArgb(235, 240, 245);
            dgvPayments.Location = new Point(3, 53);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowTemplate.Height = 40;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1010, 580);
            dgvPayments.TabIndex = 1;
            // 
            // colPaymentId
            // 
            colPaymentId.DataPropertyName = "PaymentId";
            colPaymentId.HeaderText = "معرف الدفعة";
            colPaymentId.Name = "colPaymentId";
            colPaymentId.ReadOnly = true;
            colPaymentId.Width = 90; // تم تصغيره ليتناسب مع رقم تعريفي قصير

            // 
            // colInvoiceNumber
            // 
            colInvoiceNumber.DataPropertyName = "InvoiceNumber";
            colInvoiceNumber.HeaderText = "رقم الفاتورة";
            colInvoiceNumber.Name = "colInvoiceNumber";
            colInvoiceNumber.ReadOnly = true;
            colInvoiceNumber.Width = 100; // حجم ممتاز لأرقام الفواتير

            // 
            // colPatientName
            // 
            colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // يملأ باقي المساحة ديناميكياً
            colPatientName.MinimumWidth = 180; // حد أدنى لمنع اختفاء اسم المريض في الشاشات الصغيرة
            colPatientName.DataPropertyName = "PatientFullName";
            colPatientName.HeaderText = "اسم المريض";
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;

            // 
            // colAmountPaid
            // 
            colAmountPaid.DataPropertyName = "AmountPaid";
            colAmountPaid.HeaderText = "المبلغ المدفوع";
            colAmountPaid.Name = "colAmountPaid";
            colAmountPaid.ReadOnly = true;
            colAmountPaid.Width = 110; // حجم متناسق جداً للمبالغ المالية والعملات

            // 
            // colPaymentDate
            // 
            colPaymentDate.DataPropertyName = "PaymentDate";
            colPaymentDate.HeaderText = "تاريخ الدفعة";
            colPaymentDate.Name = "colPaymentDate";
            colPaymentDate.ReadOnly = true;
            colPaymentDate.Width = 120; // يتسع للتاريخ والوقت القصير بشكل كامل

            // 
            // colPaymentMethod
            // 
            colPaymentMethod.DataPropertyName = "PaymentMethod";
            colPaymentMethod.HeaderText = "طريقة الدفع";
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            colPaymentMethod.Width = 110; // كافٍ جداً لكلمات مثل (نقداً، فيزا، شيك...)

            // 
            // colInvoiceStatus
            // 
            colInvoiceStatus.DataPropertyName = "InvoiceStatus";
            colInvoiceStatus.HeaderText = "حالة الفاتورة";
            colInvoiceStatus.Name = "colInvoiceStatus";
            colInvoiceStatus.ReadOnly = true;
            colInvoiceStatus.Width = 110; // ممتاز لكلمات مثل (مسددة، مسددة جزئياً، مسودة)

            // محاذاة المبالغ والتواريخ في المنتصف لجعلها مقروءة بوضوح
            colAmountPaid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // المبالغ يمين    
            colPaymentDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // التاريخ وسط
            colInvoiceNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // رقم الفاتورة وسط
            // 
            // epPayment
            // 
            epPayment.ContainerControl = this;
            // 
            // frmPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1084, 749);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9.75F);
            Name = "frmPayments";
            RightToLeft = RightToLeft.Yes;
            WindowState = FormWindowState.Maximized;
            mainPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabNewPayment.ResumeLayout(false);
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
            tabPaymentsHistory.ResumeLayout(false);
            pnlHistoryCard.ResumeLayout(false);
            tlpHistoryLayout.ResumeLayout(false);
            flpHistoryHeader.ResumeLayout(false);
            flpHistoryHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)epPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNewPayment;
        private System.Windows.Forms.Panel scrollContainer;
        private System.Windows.Forms.TableLayoutPanel tlpTabNewRoot;
        private System.Windows.Forms.Panel pnlPaymentMetaCard;
        private System.Windows.Forms.TableLayoutPanel tlpMetaCardLayout;
        private System.Windows.Forms.FlowLayoutPanel flpMetaFieldsLeft;
        private System.Windows.Forms.Label lblMetaTitle;
        private System.Windows.Forms.Panel pnlChooseInvoice;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Button btnChooseInvoice;
        private System.Windows.Forms.Label lblChooseInvoiceCaption;
        private System.Windows.Forms.FlowLayoutPanel flpMetaFieldRight;
        private System.Windows.Forms.Label lblPaymentDateTitle;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Panel pnlDetailsCard;
        private System.Windows.Forms.TableLayoutPanel tlpDetailsCardLayout;
        private System.Windows.Forms.TableLayoutPanel tlpUniformGridPaymentFields;
        private System.Windows.Forms.Panel pnlAmountPaidField;
        private System.Windows.Forms.Label lblAmountPaidTitle;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Panel pnlPaymentMethodField;
        private System.Windows.Forms.Label lblPaymentMethodTitle;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Panel pnlRemainingField;
        private System.Windows.Forms.Label lblRemainingTitle;
        private System.Windows.Forms.TextBox txtRemainingAfterPayment;
        private System.Windows.Forms.Panel pnlNotesField;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlBrandingSplash;
        private System.Windows.Forms.TableLayoutPanel tlpBrandingCentering;
        private System.Windows.Forms.Label lblBrandingIcon;
        private System.Windows.Forms.Label lblBrandingTitle;
        private System.Windows.Forms.Label lblBrandingSubtitle;
        private System.Windows.Forms.Panel pnlFooterCard;
        private System.Windows.Forms.TableLayoutPanel tlpFooterCardLayout;
        private System.Windows.Forms.TableLayoutPanel tlpFooterLeftActions;
        private System.Windows.Forms.TableLayoutPanel tlpUniformGridInvoiceSummary;
        private System.Windows.Forms.Panel pnlInvoiceTotalField;
        private System.Windows.Forms.Label lblInvoiceTotalTitle;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Panel pnlPaidSoFarField;
        private System.Windows.Forms.Label lblPaidSoFarTitle;
        private System.Windows.Forms.TextBox txtPaidSoFar;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnNewPayment;
        private System.Windows.Forms.TableLayoutPanel tlpFooterRightTotals;
        private System.Windows.Forms.Label lblAmountPaidNowTitle;
        private System.Windows.Forms.Label lblAmountPaidNowValue;
        private System.Windows.Forms.Label lblRemainingTitle2;
        private System.Windows.Forms.Label lblRemainingValue;
        private System.Windows.Forms.Panel pnlFooterSeparator;
        private System.Windows.Forms.Label lblInvoiceStatusTitle;
        private System.Windows.Forms.Label lblInvoiceStatusValue;
        private System.Windows.Forms.TabPage tabPaymentsHistory;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.TableLayoutPanel tlpHistoryLayout;
        private System.Windows.Forms.FlowLayoutPanel flpHistoryHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceStatus;
        private TextBox txtSearchValue;
        private Button btnExportThisPayment;
        private ErrorProvider epPayment;
    }
}