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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            lblHeaderTitle = new Label();
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
            btnAddPayment = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.FromArgb(45, 52, 71);
            pnlTopHeader.Controls.Add(lblHeaderTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1084, 56);
            pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(16, 14);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(205, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "سجل المدفوعات السابقة";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchValue.BorderStyle = BorderStyle.FixedSingle;
            txtSearchValue.Font = new Font("Segoe UI", 11F);
            txtSearchValue.ForeColor = Color.Black;
            txtSearchValue.Location = new Point(16, 75);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.PlaceholderText = "ابحث بالاسم أو رقم الفاتورة...";
            txtSearchValue.Size = new Size(1052, 27);
            txtSearchValue.TabIndex = 1;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.ColumnHeadersHeight = 40;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colPaymentId, colInvoiceId, colPatientName, colDoctorName, colPaymentAmount, colPaymentDate, colPaymentMethod, colTransactionReference, colPaymentStatusName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.FromArgb(225, 230, 240);
            dgvPayments.Location = new Point(16, 120);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.RowTemplate.Height = 35;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1052, 555);
            dgvPayments.TabIndex = 2;
            // 
            // colPaymentId
            // 
            colPaymentId.DataPropertyName = "PaymentId";
            colPaymentId.HeaderText = "رقم الدفعة";
            colPaymentId.Name = "colPaymentId";
            colPaymentId.ReadOnly = true;
            // 
            // colInvoiceId
            // 
            colInvoiceId.DataPropertyName = "InvoiceId";
            colInvoiceId.HeaderText = "رقم الفاتورة";
            colInvoiceId.Name = "colInvoiceId";
            colInvoiceId.ReadOnly = true;
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
            // btnAddPayment
            // 
            btnAddPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPayment.BackColor = Color.FromArgb(40, 167, 69);
            btnAddPayment.FlatStyle = FlatStyle.Flat;
            btnAddPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.Location = new Point(16, 690);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(160, 39);
            btnAddPayment.TabIndex = 3;
            btnAddPayment.Text = "➕ إضافة دفعة جديدة";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // frmPaymentsHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 749);
            Controls.Add(btnAddPayment);
            Controls.Add(dgvPayments);
            Controls.Add(txtSearchValue);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(850, 550);
            Name = "frmPaymentsHistory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سجل المدفوعات المالية";
            WindowState = FormWindowState.Maximized;
            Load += frmPaymentsHistory_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopHeader;
        private Label lblHeaderTitle;
        private TextBox txtSearchValue;
        private DataGridView dgvPayments;
        private Button btnAddPayment;

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