using System.Windows.Forms;
using System;



namespace  ClinicManagementSystem// تأكد من مطابقة اسم الـ Namespace لمشروعك
{
    partial class frmSystemLogs
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlFilters = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbSeverity = new ComboBox();
            lblSeverity = new Label();
            dgvLogs = new DataGridView();
            pnlFooter = new Panel();
            lblTotalCount = new Label();
            btnClearOldLogs = new Button();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(45, 45, 48);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(831, 49);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(19, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📄 سجل أحداث النظام والـ Logs";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.FromArgb(245, 247, 250);
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Controls.Add(cmbSeverity);
            pnlFilters.Controls.Add(lblSeverity);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 49);
            pnlFilters.Margin = new Padding(3, 2, 3, 2);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(831, 52);
            pnlFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(0, 122, 204);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(718, 11);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 27);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "تحديث البيانات";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(394, 14);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 25);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(64, 64, 64);
            lblSearch.Location = new Point(298, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 17);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "بحث في الحدث:";
            // 
            // cmbSeverity
            // 
            cmbSeverity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeverity.Font = new Font("Segoe UI", 10F);
            cmbSeverity.FormattingEnabled = true;
            cmbSeverity.Location = new Point(105, 14);
            cmbSeverity.Margin = new Padding(3, 2, 3, 2);
            cmbSeverity.Name = "cmbSeverity";
            cmbSeverity.Size = new Size(158, 25);
            cmbSeverity.TabIndex = 1;
            cmbSeverity.SelectedIndexChanged += cmbSeverity_SelectedIndexChanged;
            // 
            // lblSeverity
            // 
            lblSeverity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeverity.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeverity.Location = new Point(10, 16);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(87, 17);
            lblSeverity.TabIndex = 0;
            lblSeverity.Text = "درجة الخطورة:";
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToOrderColumns = true;
            dgvLogs.AllowUserToResizeRows = false;
            dgvLogs.BackgroundColor = Color.White;
            dgvLogs.BorderStyle = BorderStyle.None;
            dgvLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(240, 243, 246);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(240, 243, 246);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvLogs.ColumnHeadersHeight = 45;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(230, 242, 250);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvLogs.DefaultCellStyle = dataGridViewCellStyle11;
            dgvLogs.Dock = DockStyle.Fill;
            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.GridColor = Color.FromArgb(224, 224, 224);
            dgvLogs.Location = new Point(0, 101);
            dgvLogs.Margin = new Padding(3, 2, 3, 2);
            dgvLogs.MultiSelect = false;
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.RowTemplate.Height = 35;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(831, 266);
            dgvLogs.TabIndex = 2;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(240, 243, 246);
            pnlFooter.Controls.Add(lblTotalCount);
            pnlFooter.Controls.Add(btnClearOldLogs);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 367);
            pnlFooter.Margin = new Padding(3, 2, 3, 2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(831, 45);
            pnlFooter.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotalCount.Location = new Point(19, 14);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(154, 19);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "إجمالي السجلات: 0 سجل";
            // 
            // btnClearOldLogs
            // 
            btnClearOldLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearOldLogs.BackColor = Color.FromArgb(192, 57, 43);
            btnClearOldLogs.Cursor = Cursors.Hand;
            btnClearOldLogs.FlatAppearance.BorderSize = 0;
            btnClearOldLogs.FlatStyle = FlatStyle.Flat;
            btnClearOldLogs.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClearOldLogs.ForeColor = Color.White;
            btnClearOldLogs.Location = new Point(652, 9);
            btnClearOldLogs.Margin = new Padding(3, 2, 3, 2);
            btnClearOldLogs.Name = "btnClearOldLogs";
            btnClearOldLogs.Size = new Size(162, 27);
            btnClearOldLogs.TabIndex = 0;
            btnClearOldLogs.Text = "تنظيف الأرشيف القديم";
            btnClearOldLogs.UseVisualStyleBackColor = false;
            btnClearOldLogs.Click += btnClearOldLogs_Click;
            // 
            // frmSystemLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 412);
            Controls.Add(dgvLogs);
            Controls.Add(pnlFooter);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(746, 385);
            Name = "frmSystemLogs";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة سجلات نظام عيادتي الذكية";
            WindowState = FormWindowState.Maximized;
            Load += frmSystemLogs_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlFilters;
    private System.Windows.Forms.ComboBox cmbSeverity;
    private System.Windows.Forms.Label lblSeverity;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.DataGridView dgvLogs;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Button btnClearOldLogs;
    private System.Windows.Forms.Label lblTotalCount;
}
}