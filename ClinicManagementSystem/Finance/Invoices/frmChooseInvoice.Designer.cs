namespace ClinicManagementSystem.Invoices
{
    partial class frmChooseInvoice : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            lblHeaderTitle = new Label();
            txtSearch = new TextBox();
            dgvInvoices = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripShowInvoiceInfo = new ToolStripMenuItem();
            toolStripUpdateInvoice = new ToolStripMenuItem();
            toolStripAddNewInvoice = new ToolStripMenuItem();
            toolStripDeleteInvoice = new ToolStripMenuItem();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddNewInvoice = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.FromArgb(45, 52, 71);
            pnlTopHeader.Controls.Add(lblHeaderTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(850, 56);
            pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(10, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(176, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "البحث واختيار الفاتورة";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(16, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(818, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "🔍 أدخل اسم المريض أو رقم الفاتورة للبحث...";
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dgvInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvInvoices.BorderStyle = BorderStyle.None;
            dgvInvoices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoices.ColumnHeadersHeight = 40;
            dgvInvoices.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.GridColor = Color.FromArgb(225, 230, 240);
            dgvInvoices.Location = new Point(16, 120);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.RowTemplate.Height = 35;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(818, 350);
            dgvInvoices.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripShowInvoiceInfo, toolStripUpdateInvoice, toolStripAddNewInvoice, toolStripDeleteInvoice });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(211, 108);
            // 
            // toolStripShowInvoiceInfo
            // 
            toolStripShowInvoiceInfo.Name = "toolStripShowInvoiceInfo";
            toolStripShowInvoiceInfo.Size = new Size(210, 26);
            toolStripShowInvoiceInfo.Text = "عرض بيانات الفاتورة";
            toolStripShowInvoiceInfo.Click += toolStripShowInvoiceInfo_Click_1;
            // 
            // toolStripUpdateInvoice
            // 
            toolStripUpdateInvoice.Name = "toolStripUpdateInvoice";
            toolStripUpdateInvoice.Size = new Size(210, 26);
            toolStripUpdateInvoice.Text = "تحديث الفاتورة";
            toolStripUpdateInvoice.Click += toolStripUpdateInvoice_Click_1;
            // 
            // toolStripAddNewInvoice
            // 
            toolStripAddNewInvoice.ForeColor = Color.Green;
            toolStripAddNewInvoice.Name = "toolStripAddNewInvoice";
            toolStripAddNewInvoice.Size = new Size(210, 26);
            toolStripAddNewInvoice.Text = "إنشاء فاتورة جديدة";
            toolStripAddNewInvoice.Click += toolStripAddNewInvoice_Click_1;
            // 
            // toolStripDeleteInvoice
            // 
            toolStripDeleteInvoice.ForeColor = Color.Red;
            toolStripDeleteInvoice.Name = "toolStripDeleteInvoice";
            toolStripDeleteInvoice.Size = new Size(210, 26);
            toolStripDeleteInvoice.Text = "حذف الفاتورة";
            toolStripDeleteInvoice.Click += toolStripDeleteInvoice_Click_1;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.BackColor = Color.FromArgb(40, 167, 69);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(720, 490);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(114, 39);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "تأكيد الاختيار";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(108, 117, 125);
            btnCancel.Location = new Point(598, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "إغلاق";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddNewInvoice
            // 
            btnAddNewInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNewInvoice.BackColor = Color.FromArgb(0, 123, 255);
            btnAddNewInvoice.FlatStyle = FlatStyle.Flat;
            btnAddNewInvoice.Font = new Font("Segoe UI", 10F);
            btnAddNewInvoice.ForeColor = Color.White;
            btnAddNewInvoice.Location = new Point(16, 490);
            btnAddNewInvoice.Name = "btnAddNewInvoice";
            btnAddNewInvoice.Size = new Size(158, 39);
            btnAddNewInvoice.TabIndex = 5;
            btnAddNewInvoice.Text = "➕ إنشاء فاتورة جديدة";
            btnAddNewInvoice.UseVisualStyleBackColor = false;
            // 
            // frmChooseInvoice
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(850, 550);
            Controls.Add(btnAddNewInvoice);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvInvoices);
            Controls.Add(txtSearch);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(750, 500);
            Name = "frmChooseInvoice";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة اختيار فاتورة";
            WindowState = FormWindowState.Maximized;
            Load += frmChooseInvoice_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewInvoice;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripShowInvoiceInfo;
        private ToolStripMenuItem toolStripUpdateInvoice;
        private ToolStripMenuItem toolStripAddNewInvoice;
        private ToolStripMenuItem toolStripDeleteInvoice;
    }
}