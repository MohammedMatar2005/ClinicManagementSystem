using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    partial class frmShowInvoiceInfo : Form
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
            grpGeneralInfo = new GroupBox();
            lblInvoiceNumber = new Label();
            txtInvoiceNumber = new Label();
            lblVisitId = new Label();
            txtVisitId = new Label();
            lblPatientName = new Label();
            txtPatientName = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceDate = new Label();
            lblDueDate = new Label();
            txtDueDate = new Label();
            lblCreatedDate = new Label();
            txtCreatedDate = new Label();
            grpFeesCharges = new GroupBox();
            lblConsultationFee = new Label();
            txtConsultationFee = new Label();
            lblLabTestFee = new Label();
            txtLabTestFee = new Label();
            lblProcedureFee = new Label();
            txtProcedureFee = new Label();
            lblOtherCharges = new Label();
            txtOtherCharges = new Label();
            grpFinancialSummary = new GroupBox();
            lblSubTotal = new Label();
            txtSubTotal = new Label();
            lblTaxPercentage = new Label();
            txtTaxPercentage = new Label();
            lblDiscountPercentage = new Label();
            txtDiscountPercentage = new Label();
            lblDiscountAmount = new Label();
            txtDiscountAmount = new Label();
            lblFinalTotal = new Label();
            txtFinalTotal = new Label();
            lblPaidAmount = new Label();
            txtPaidAmount = new Label();
            lblRemainingAmount = new Label();
            txtRemainingAmount = new Label();
            lblStatusName = new Label();
            txtStatusName = new Label();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            grpGeneralInfo.SuspendLayout();
            grpFeesCharges.SuspendLayout();
            grpFinancialSummary.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 37, 51);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(700, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "تفاصيل الفاتورة الشاملة";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 526);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(700, 56);
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
            btnClose.Location = new Point(285, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // pnlBody
            // 
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = Color.FromArgb(249, 250, 251);
            pnlBody.Controls.Add(grpGeneralInfo);
            pnlBody.Controls.Add(grpFeesCharges);
            pnlBody.Controls.Add(grpFinancialSummary);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 60);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(700, 466);
            pnlBody.TabIndex = 2;
            // 
            // grpGeneralInfo
            // 
            grpGeneralInfo.BackColor = Color.White;
            grpGeneralInfo.Controls.Add(lblInvoiceNumber);
            grpGeneralInfo.Controls.Add(txtInvoiceNumber);
            grpGeneralInfo.Controls.Add(lblVisitId);
            grpGeneralInfo.Controls.Add(txtVisitId);
            grpGeneralInfo.Controls.Add(lblPatientName);
            grpGeneralInfo.Controls.Add(txtPatientName);
            grpGeneralInfo.Controls.Add(lblInvoiceDate);
            grpGeneralInfo.Controls.Add(txtInvoiceDate);
            grpGeneralInfo.Controls.Add(lblDueDate);
            grpGeneralInfo.Controls.Add(txtDueDate);
            grpGeneralInfo.Controls.Add(lblCreatedDate);
            grpGeneralInfo.Controls.Add(txtCreatedDate);
            grpGeneralInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpGeneralInfo.ForeColor = Color.FromArgb(26, 37, 51);
            grpGeneralInfo.Location = new Point(20, 20);
            grpGeneralInfo.Name = "grpGeneralInfo";
            grpGeneralInfo.Size = new Size(660, 225);
            grpGeneralInfo.TabIndex = 0;
            grpGeneralInfo.TabStop = false;
            grpGeneralInfo.Text = "البيانات العامة الفاتورة";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.FromArgb(100, 110, 120);
            lblInvoiceNumber.Location = new Point(340, 25);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(300, 20);
            lblInvoiceNumber.TabIndex = 0;
            lblInvoiceNumber.Text = "رقم الفاتورة:";
            lblInvoiceNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.BackColor = Color.FromArgb(233, 236, 239);
            txtInvoiceNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtInvoiceNumber.ForeColor = Color.FromArgb(33, 37, 41);
            txtInvoiceNumber.Location = new Point(340, 49);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Padding = new Padding(10, 0, 10, 0);
            txtInvoiceNumber.Size = new Size(300, 28);
            txtInvoiceNumber.TabIndex = 1;
            txtInvoiceNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVisitId
            // 
            lblVisitId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVisitId.ForeColor = Color.FromArgb(100, 110, 120);
            lblVisitId.Location = new Point(20, 25);
            lblVisitId.Name = "lblVisitId";
            lblVisitId.Size = new Size(300, 20);
            lblVisitId.TabIndex = 2;
            lblVisitId.Text = "رقم الزيارة المرتبطة:";
            lblVisitId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVisitId
            // 
            txtVisitId.BackColor = Color.FromArgb(233, 236, 239);
            txtVisitId.Font = new Font("Segoe UI", 10F);
            txtVisitId.ForeColor = Color.FromArgb(33, 37, 41);
            txtVisitId.Location = new Point(20, 49);
            txtVisitId.Name = "txtVisitId";
            txtVisitId.Padding = new Padding(10, 0, 10, 0);
            txtVisitId.Size = new Size(300, 28);
            txtVisitId.TabIndex = 3;
            txtVisitId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPatientName
            // 
            lblPatientName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(100, 110, 120);
            lblPatientName.Location = new Point(340, 90);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(300, 20);
            lblPatientName.TabIndex = 4;
            lblPatientName.Text = "اسم المريض:";
            lblPatientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            txtPatientName.BackColor = Color.FromArgb(233, 236, 239);
            txtPatientName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPatientName.ForeColor = Color.FromArgb(26, 37, 51);
            txtPatientName.Location = new Point(340, 114);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Padding = new Padding(10, 0, 10, 0);
            txtPatientName.Size = new Size(300, 28);
            txtPatientName.TabIndex = 5;
            txtPatientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInvoiceDate.ForeColor = Color.FromArgb(100, 110, 120);
            lblInvoiceDate.Location = new Point(20, 90);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(300, 20);
            lblInvoiceDate.TabIndex = 6;
            lblInvoiceDate.Text = "تاريخ الفاتورة:";
            lblInvoiceDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.BackColor = Color.FromArgb(233, 236, 239);
            txtInvoiceDate.Font = new Font("Segoe UI", 10F);
            txtInvoiceDate.ForeColor = Color.FromArgb(33, 37, 41);
            txtInvoiceDate.Location = new Point(20, 114);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.Padding = new Padding(10, 0, 10, 0);
            txtInvoiceDate.Size = new Size(300, 28);
            txtInvoiceDate.TabIndex = 7;
            txtInvoiceDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDueDate
            // 
            lblDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDueDate.ForeColor = Color.FromArgb(100, 110, 120);
            lblDueDate.Location = new Point(340, 155);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(300, 20);
            lblDueDate.TabIndex = 8;
            lblDueDate.Text = "تاريخ الاستحقاق:";
            lblDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDueDate
            // 
            txtDueDate.BackColor = Color.FromArgb(233, 236, 239);
            txtDueDate.Font = new Font("Segoe UI", 10F);
            txtDueDate.ForeColor = Color.FromArgb(33, 37, 41);
            txtDueDate.Location = new Point(340, 179);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Padding = new Padding(10, 0, 10, 0);
            txtDueDate.Size = new Size(300, 28);
            txtDueDate.TabIndex = 9;
            txtDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCreatedDate.ForeColor = Color.FromArgb(100, 110, 120);
            lblCreatedDate.Location = new Point(20, 155);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(300, 20);
            lblCreatedDate.TabIndex = 10;
            lblCreatedDate.Text = "تاريخ الإنشاء:";
            lblCreatedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.BackColor = Color.FromArgb(233, 236, 239);
            txtCreatedDate.Font = new Font("Segoe UI", 10F);
            txtCreatedDate.ForeColor = Color.FromArgb(33, 37, 41);
            txtCreatedDate.Location = new Point(20, 179);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.Padding = new Padding(10, 0, 10, 0);
            txtCreatedDate.Size = new Size(300, 28);
            txtCreatedDate.TabIndex = 11;
            txtCreatedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpFeesCharges
            // 
            grpFeesCharges.BackColor = Color.White;
            grpFeesCharges.Controls.Add(lblConsultationFee);
            grpFeesCharges.Controls.Add(txtConsultationFee);
            grpFeesCharges.Controls.Add(lblLabTestFee);
            grpFeesCharges.Controls.Add(txtLabTestFee);
            grpFeesCharges.Controls.Add(lblProcedureFee);
            grpFeesCharges.Controls.Add(txtProcedureFee);
            grpFeesCharges.Controls.Add(lblOtherCharges);
            grpFeesCharges.Controls.Add(txtOtherCharges);
            grpFeesCharges.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFeesCharges.ForeColor = Color.FromArgb(26, 37, 51);
            grpFeesCharges.Location = new Point(20, 260);
            grpFeesCharges.Name = "grpFeesCharges";
            grpFeesCharges.Size = new Size(660, 165);
            grpFeesCharges.TabIndex = 1;
            grpFeesCharges.TabStop = false;
            grpFeesCharges.Text = "تفكيك الرسوم والخدمات";
            // 
            // lblConsultationFee
            // 
            lblConsultationFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsultationFee.ForeColor = Color.FromArgb(100, 110, 120);
            lblConsultationFee.Location = new Point(340, 25);
            lblConsultationFee.Name = "lblConsultationFee";
            lblConsultationFee.Size = new Size(300, 20);
            lblConsultationFee.TabIndex = 12;
            lblConsultationFee.Text = "رسوم الكشفية:";
            lblConsultationFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConsultationFee
            // 
            txtConsultationFee.BackColor = Color.FromArgb(240, 244, 248);
            txtConsultationFee.Font = new Font("Segoe UI", 10F);
            txtConsultationFee.ForeColor = Color.FromArgb(51, 65, 85);
            txtConsultationFee.Location = new Point(340, 49);
            txtConsultationFee.Name = "txtConsultationFee";
            txtConsultationFee.Padding = new Padding(10, 0, 10, 0);
            txtConsultationFee.Size = new Size(300, 28);
            txtConsultationFee.TabIndex = 13;
            txtConsultationFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLabTestFee
            // 
            lblLabTestFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLabTestFee.ForeColor = Color.FromArgb(100, 110, 120);
            lblLabTestFee.Location = new Point(20, 25);
            lblLabTestFee.Name = "lblLabTestFee";
            lblLabTestFee.Size = new Size(300, 20);
            lblLabTestFee.TabIndex = 14;
            lblLabTestFee.Text = "رسوم المختبر:";
            lblLabTestFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLabTestFee
            // 
            txtLabTestFee.BackColor = Color.FromArgb(240, 244, 248);
            txtLabTestFee.Font = new Font("Segoe UI", 10F);
            txtLabTestFee.ForeColor = Color.FromArgb(51, 65, 85);
            txtLabTestFee.Location = new Point(20, 49);
            txtLabTestFee.Name = "txtLabTestFee";
            txtLabTestFee.Padding = new Padding(10, 0, 10, 0);
            txtLabTestFee.Size = new Size(300, 28);
            txtLabTestFee.TabIndex = 15;
            txtLabTestFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProcedureFee
            // 
            lblProcedureFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProcedureFee.ForeColor = Color.FromArgb(100, 110, 120);
            lblProcedureFee.Location = new Point(340, 90);
            lblProcedureFee.Name = "lblProcedureFee";
            lblProcedureFee.Size = new Size(300, 20);
            lblProcedureFee.TabIndex = 16;
            lblProcedureFee.Text = "رسوم الإجراءات:";
            lblProcedureFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProcedureFee
            // 
            txtProcedureFee.BackColor = Color.FromArgb(240, 244, 248);
            txtProcedureFee.Font = new Font("Segoe UI", 10F);
            txtProcedureFee.ForeColor = Color.FromArgb(51, 65, 85);
            txtProcedureFee.Location = new Point(340, 114);
            txtProcedureFee.Name = "txtProcedureFee";
            txtProcedureFee.Padding = new Padding(10, 0, 10, 0);
            txtProcedureFee.Size = new Size(300, 28);
            txtProcedureFee.TabIndex = 17;
            txtProcedureFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOtherCharges
            // 
            lblOtherCharges.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOtherCharges.ForeColor = Color.FromArgb(100, 110, 120);
            lblOtherCharges.Location = new Point(20, 90);
            lblOtherCharges.Name = "lblOtherCharges";
            lblOtherCharges.Size = new Size(300, 20);
            lblOtherCharges.TabIndex = 18;
            lblOtherCharges.Text = "رسوم أخرى:";
            lblOtherCharges.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtOtherCharges
            // 
            txtOtherCharges.BackColor = Color.FromArgb(240, 244, 248);
            txtOtherCharges.Font = new Font("Segoe UI", 10F);
            txtOtherCharges.ForeColor = Color.FromArgb(51, 65, 85);
            txtOtherCharges.Location = new Point(20, 114);
            txtOtherCharges.Name = "txtOtherCharges";
            txtOtherCharges.Padding = new Padding(10, 0, 10, 0);
            txtOtherCharges.Size = new Size(300, 28);
            txtOtherCharges.TabIndex = 19;
            txtOtherCharges.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpFinancialSummary
            // 
            grpFinancialSummary.BackColor = Color.White;
            grpFinancialSummary.Controls.Add(lblSubTotal);
            grpFinancialSummary.Controls.Add(txtSubTotal);
            grpFinancialSummary.Controls.Add(lblTaxPercentage);
            grpFinancialSummary.Controls.Add(txtTaxPercentage);
            grpFinancialSummary.Controls.Add(lblDiscountPercentage);
            grpFinancialSummary.Controls.Add(txtDiscountPercentage);
            grpFinancialSummary.Controls.Add(lblDiscountAmount);
            grpFinancialSummary.Controls.Add(txtDiscountAmount);
            grpFinancialSummary.Controls.Add(lblFinalTotal);
            grpFinancialSummary.Controls.Add(txtFinalTotal);
            grpFinancialSummary.Controls.Add(lblPaidAmount);
            grpFinancialSummary.Controls.Add(txtPaidAmount);
            grpFinancialSummary.Controls.Add(lblRemainingAmount);
            grpFinancialSummary.Controls.Add(txtRemainingAmount);
            grpFinancialSummary.Controls.Add(lblStatusName);
            grpFinancialSummary.Controls.Add(txtStatusName);
            grpFinancialSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFinancialSummary.ForeColor = Color.FromArgb(26, 37, 51);
            grpFinancialSummary.Location = new Point(20, 440);
            grpFinancialSummary.Name = "grpFinancialSummary";
            grpFinancialSummary.Size = new Size(660, 300);
            grpFinancialSummary.TabIndex = 2;
            grpFinancialSummary.TabStop = false;
            grpFinancialSummary.Text = "الملخص المالي والحالة";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubTotal.ForeColor = Color.FromArgb(100, 110, 120);
            lblSubTotal.Location = new Point(340, 25);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(300, 20);
            lblSubTotal.TabIndex = 20;
            lblSubTotal.Text = "المجموع الفرعي:";
            lblSubTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(239, 246, 255);
            txtSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSubTotal.ForeColor = Color.FromArgb(30, 64, 111);
            txtSubTotal.Location = new Point(340, 49);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Padding = new Padding(10, 0, 10, 0);
            txtSubTotal.Size = new Size(300, 28);
            txtSubTotal.TabIndex = 21;
            txtSubTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTaxPercentage
            // 
            lblTaxPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTaxPercentage.ForeColor = Color.FromArgb(100, 110, 120);
            lblTaxPercentage.Location = new Point(20, 25);
            lblTaxPercentage.Name = "lblTaxPercentage";
            lblTaxPercentage.Size = new Size(300, 20);
            lblTaxPercentage.TabIndex = 22;
            lblTaxPercentage.Text = "نسبة الضريبة (%):";
            lblTaxPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTaxPercentage
            // 
            txtTaxPercentage.BackColor = Color.FromArgb(239, 246, 255);
            txtTaxPercentage.Font = new Font("Segoe UI", 10F);
            txtTaxPercentage.ForeColor = Color.FromArgb(30, 64, 111);
            txtTaxPercentage.Location = new Point(20, 49);
            txtTaxPercentage.Name = "txtTaxPercentage";
            txtTaxPercentage.Padding = new Padding(10, 0, 10, 0);
            txtTaxPercentage.Size = new Size(300, 28);
            txtTaxPercentage.TabIndex = 23;
            txtTaxPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscountPercentage
            // 
            lblDiscountPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiscountPercentage.ForeColor = Color.FromArgb(100, 110, 120);
            lblDiscountPercentage.Location = new Point(340, 90);
            lblDiscountPercentage.Name = "lblDiscountPercentage";
            lblDiscountPercentage.Size = new Size(300, 20);
            lblDiscountPercentage.TabIndex = 24;
            lblDiscountPercentage.Text = "نسبة الخصم (%):";
            lblDiscountPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercentage
            // 
            txtDiscountPercentage.BackColor = Color.FromArgb(254, 242, 242);
            txtDiscountPercentage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtDiscountPercentage.ForeColor = Color.FromArgb(220, 38, 38);
            txtDiscountPercentage.Location = new Point(340, 114);
            txtDiscountPercentage.Name = "txtDiscountPercentage";
            txtDiscountPercentage.Padding = new Padding(10, 0, 10, 0);
            txtDiscountPercentage.Size = new Size(300, 28);
            txtDiscountPercentage.TabIndex = 25;
            txtDiscountPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiscountAmount.ForeColor = Color.FromArgb(100, 110, 120);
            lblDiscountAmount.Location = new Point(20, 90);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(300, 20);
            lblDiscountAmount.TabIndex = 26;
            lblDiscountAmount.Text = "قيمة الخصم المالي:";
            lblDiscountAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.BackColor = Color.FromArgb(254, 242, 242);
            txtDiscountAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtDiscountAmount.ForeColor = Color.FromArgb(220, 38, 38);
            txtDiscountAmount.Location = new Point(20, 114);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Padding = new Padding(10, 0, 10, 0);
            txtDiscountAmount.Size = new Size(300, 28);
            txtDiscountAmount.TabIndex = 27;
            txtDiscountAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFinalTotal.ForeColor = Color.FromArgb(26, 37, 51);
            lblFinalTotal.Location = new Point(340, 155);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(300, 20);
            lblFinalTotal.TabIndex = 28;
            lblFinalTotal.Text = "الإجمالي النهائي المطالب به:";
            lblFinalTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFinalTotal
            // 
            txtFinalTotal.BackColor = Color.FromArgb(209, 250, 229);
            txtFinalTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtFinalTotal.ForeColor = Color.FromArgb(6, 95, 70);
            txtFinalTotal.Location = new Point(340, 179);
            txtFinalTotal.Name = "txtFinalTotal";
            txtFinalTotal.Padding = new Padding(10, 0, 10, 0);
            txtFinalTotal.Size = new Size(300, 32);
            txtFinalTotal.TabIndex = 29;
            txtFinalTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaidAmount.ForeColor = Color.FromArgb(100, 110, 120);
            lblPaidAmount.Location = new Point(20, 155);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(300, 20);
            lblPaidAmount.TabIndex = 30;
            lblPaidAmount.Text = "المبلغ المدفوع:";
            lblPaidAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.BackColor = Color.FromArgb(209, 250, 229);
            txtPaidAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPaidAmount.ForeColor = Color.FromArgb(6, 95, 70);
            txtPaidAmount.Location = new Point(20, 179);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Padding = new Padding(10, 0, 10, 0);
            txtPaidAmount.Size = new Size(300, 28);
            txtPaidAmount.TabIndex = 31;
            txtPaidAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRemainingAmount
            // 
            lblRemainingAmount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRemainingAmount.ForeColor = Color.FromArgb(100, 110, 120);
            lblRemainingAmount.Location = new Point(340, 220);
            lblRemainingAmount.Name = "lblRemainingAmount";
            lblRemainingAmount.Size = new Size(300, 20);
            lblRemainingAmount.TabIndex = 32;
            lblRemainingAmount.Text = "المبلغ المتبقي (المستحق):";
            lblRemainingAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.BackColor = Color.FromArgb(254, 242, 242);
            txtRemainingAmount.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtRemainingAmount.ForeColor = Color.FromArgb(220, 38, 38);
            txtRemainingAmount.Location = new Point(340, 244);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.Padding = new Padding(10, 0, 10, 0);
            txtRemainingAmount.Size = new Size(300, 28);
            txtRemainingAmount.TabIndex = 33;
            txtRemainingAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusName
            // 
            lblStatusName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusName.ForeColor = Color.FromArgb(100, 110, 120);
            lblStatusName.Location = new Point(20, 220);
            lblStatusName.Name = "lblStatusName";
            lblStatusName.Size = new Size(300, 20);
            lblStatusName.TabIndex = 34;
            lblStatusName.Text = "حالة الفاتورة الحالية:";
            lblStatusName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStatusName
            // 
            txtStatusName.BackColor = Color.FromArgb(238, 242, 255);
            txtStatusName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtStatusName.ForeColor = Color.FromArgb(79, 70, 229);
            txtStatusName.Location = new Point(20, 244);
            txtStatusName.Name = "txtStatusName";
            txtStatusName.Padding = new Padding(10, 0, 10, 0);
            txtStatusName.Size = new Size(300, 28);
            txtStatusName.TabIndex = 35;
            txtStatusName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmShowInvoiceInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(700, 582);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowInvoiceInfo";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل الفاتورة";
            Load += frmShowInvoiceInfo_Load;
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpGeneralInfo.ResumeLayout(false);
            grpFeesCharges.ResumeLayout(false);
            grpFinancialSummary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.GroupBox grpGeneralInfo;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label txtInvoiceNumber;
        private System.Windows.Forms.Label lblVisitId;
        private System.Windows.Forms.Label txtVisitId;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label txtPatientName;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label txtInvoiceDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label txtDueDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label txtCreatedDate;

        private System.Windows.Forms.GroupBox grpFeesCharges;
        private System.Windows.Forms.Label lblConsultationFee;
        private System.Windows.Forms.Label txtConsultationFee;
        private System.Windows.Forms.Label lblLabTestFee;
        private System.Windows.Forms.Label txtLabTestFee;
        private System.Windows.Forms.Label lblProcedureFee;
        private System.Windows.Forms.Label txtProcedureFee;
        private System.Windows.Forms.Label lblOtherCharges;
        private System.Windows.Forms.Label txtOtherCharges;

        private System.Windows.Forms.GroupBox grpFinancialSummary;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label txtDiscountPercentage;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.Label txtTaxPercentage;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label txtDiscountAmount;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label txtFinalTotal;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label txtPaidAmount;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label txtRemainingAmount;
        private System.Windows.Forms.Label lblStatusName;
        private System.Windows.Forms.Label txtStatusName;
    }
}