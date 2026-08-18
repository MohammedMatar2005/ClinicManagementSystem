using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Finance
{
    partial class frmPaymentsHistory : Form
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHistoryCard = new Panel();
            tlpHistoryLayout = new TableLayoutPanel();
            flpHistoryHeader = new FlowLayoutPanel();
            lblHistoryTitle = new Label();
            btnExportPdf = new Button();
            btnExportThisPayment = new Button();
            txtSearchValue = new TextBox();
            dgvPayments = new DataGridView();
            colPaymentId = new DataGridViewTextBoxColumn();
            colInvoiceId = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            colPaymentAmount = new DataGridViewTextBoxColumn();
            colPaymentDate = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colTransactionReference = new DataGridViewTextBoxColumn();
            colPaymentStatusName = new DataGridViewTextBoxColumn();
            pnlHistoryCard.SuspendLayout();
            tlpHistoryLayout.SuspendLayout();
            flpHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.White;
            pnlHistoryCard.Controls.Add(tlpHistoryLayout);
            pnlHistoryCard.Dock = DockStyle.Fill;
            pnlHistoryCard.Location = new Point(0, 0);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Padding = new Padding(16);
            pnlHistoryCard.Size = new Size(1084, 749);
            pnlHistoryCard.TabIndex = 0;
            // 
            // tlpHistoryLayout
            // 
            tlpHistoryLayout.ColumnCount = 1;
            tlpHistoryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Controls.Add(flpHistoryHeader, 0, 0);
            tlpHistoryLayout.Controls.Add(dgvPayments, 0, 1);
            tlpHistoryLayout.Dock = DockStyle.Fill;
            tlpHistoryLayout.Location = new Point(16, 16);
            tlpHistoryLayout.Name = "tlpHistoryLayout";
            tlpHistoryLayout.RowCount = 2;
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpHistoryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryLayout.Size = new Size(1052, 717);
            tlpHistoryLayout.TabIndex = 0;
            // 
            // flpHistoryHeader
            // 
            flpHistoryHeader.Controls.Add(lblHistoryTitle);
            flpHistoryHeader.Controls.Add(btnExportPdf);
            flpHistoryHeader.Controls.Add(btnExportThisPayment);
            flpHistoryHeader.Controls.Add(txtSearchValue);
            flpHistoryHeader.Dock = DockStyle.Fill;
            flpHistoryHeader.Location = new Point(3, 3);
            flpHistoryHeader.Name = "flpHistoryHeader";
            flpHistoryHeader.Size = new Size(1046, 44);
            flpHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHistoryTitle.Location = new Point(863, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(180, 38);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "سجل المدفوعات السابقة";
            lblHistoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(225, 29, 72);
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(727, 3);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(130, 34);
            btnExportPdf.TabIndex = 1;
            btnExportPdf.Text = "تصدير الكل PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnExportThisPayment
            // 
            btnExportThisPayment.BackColor = Color.FromArgb(14, 116, 144);
            btnExportThisPayment.Cursor = Cursors.Hand;
            btnExportThisPayment.FlatAppearance.BorderSize = 0;
            btnExportThisPayment.FlatStyle = FlatStyle.Flat;
            btnExportThisPayment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExportThisPayment.ForeColor = Color.White;
            btnExportThisPayment.Location = new Point(581, 3);
            btnExportThisPayment.Name = "btnExportThisPayment";
            btnExportThisPayment.Size = new Size(140, 34);
            btnExportThisPayment.TabIndex = 2;
            btnExportThisPayment.Text = "طباعة السند الحالي";
            btnExportThisPayment.UseVisualStyleBackColor = false;
            btnExportThisPayment.Click += btnExportThisPayment_Click;
            // 
            // txtSearchValue
            // 
            txtSearchValue.BorderStyle = BorderStyle.FixedSingle;
            txtSearchValue.Font = new Font("Segoe UI", 10.5F);
            txtSearchValue.Location = new Point(348, 6);
            txtSearchValue.Margin = new Padding(10, 6, 3, 3);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.PlaceholderText = "ابحث بالاسم أو رقم الفاتورة...";
            txtSearchValue.Size = new Size(220, 26);
            txtSearchValue.TabIndex = 3;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPayments.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.ColumnHeadersHeight = 40;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colPaymentId, colInvoiceId, colPatientName, colDoctorName, colPaymentAmount, colPaymentDate, colPaymentMethod, colTransactionReference, colPaymentStatusName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.FromArgb(226, 232, 240);
            dgvPayments.Location = new Point(3, 53);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowTemplate.Height = 35;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1046, 661);
            dgvPayments.TabIndex = 1;
            // 
            // colPaymentId
            // 
            colPaymentId.DataPropertyName = "PaymentId";
            colPaymentId.HeaderText = "رقم الدفعة";
            colPaymentId.Name = "colPaymentId";
            colPaymentId.ReadOnly = true;
            colPaymentId.Width = 90;
            // 
            // colInvoiceId
            // 
            colInvoiceId.DataPropertyName = "InvoiceId";
            colInvoiceId.HeaderText = "رقم الفاتورة";
            colInvoiceId.Name = "colInvoiceId";
            colInvoiceId.ReadOnly = true;
            colInvoiceId.Width = 90;
            // 
            // colPatientName
            // 
            colPatientName.DataPropertyName = "PatientFullName";
            colPatientName.HeaderText = "اسم المريض";
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            // 
            // colDoctorName
            // 
            colDoctorName.DataPropertyName = "DoctorFullName";
            colDoctorName.HeaderText = "اسم الطبيب";
            colDoctorName.Name = "colDoctorName";
            colDoctorName.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            colPaymentAmount.DataPropertyName = "PaymentAmount";
            colPaymentAmount.HeaderText = "المبلغ المدفوع";
            colPaymentAmount.Name = "colPaymentAmount";
            colPaymentAmount.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            colPaymentDate.DataPropertyName = "PaymentDate";
            colPaymentDate.HeaderText = "تاريخ الدفع";
            colPaymentDate.Name = "colPaymentDate";
            colPaymentDate.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.DataPropertyName = "PaymentMethod";
            colPaymentMethod.HeaderText = "طريقة الدفع";
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            // 
            // colTransactionReference
            // 
            colTransactionReference.DataPropertyName = "TransactionReference";
            colTransactionReference.HeaderText = "الرقم المرجعي";
            colTransactionReference.Name = "colTransactionReference";
            colTransactionReference.ReadOnly = true;
            // 
            // colPaymentStatusName
            // 
            colPaymentStatusName.DataPropertyName = "PaymentStatusName";
            colPaymentStatusName.HeaderText = "حالة الدفعة";
            colPaymentStatusName.Name = "colPaymentStatusName";
            colPaymentStatusName.ReadOnly = true;
            // 
            // frmPaymentsHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 749);
            Controls.Add(pnlHistoryCard);
            Name = "frmPaymentsHistory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سجل الدفعات المالية";
            WindowState = FormWindowState.Maximized;
            Load += frmPaymentsHistory_Load;
            pnlHistoryCard.ResumeLayout(false);
            tlpHistoryLayout.ResumeLayout(false);
            flpHistoryHeader.ResumeLayout(false);
            flpHistoryHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHistoryCard;
        private TableLayoutPanel tlpHistoryLayout;
        private FlowLayoutPanel flpHistoryHeader;
        private Label lblHistoryTitle;
        private Button btnExportPdf;
        private Button btnExportThisPayment;
        private TextBox txtSearchValue;
        private DataGridView dgvPayments;
        private DataGridViewTextBoxColumn colPaymentId;
        private DataGridViewTextBoxColumn colInvoiceId;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn colDoctorName;
        private DataGridViewTextBoxColumn colPaymentAmount;
        private DataGridViewTextBoxColumn colPaymentDate;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colTransactionReference;
        private DataGridViewTextBoxColumn colPaymentStatusName;
    }
}