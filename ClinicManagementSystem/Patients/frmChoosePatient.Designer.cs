namespace ClinicManagementSystem.Appointments
{
    partial class frmChoosePatient : Form
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
            dgvPatients = new DataGridView();
            cmsOptions = new ContextMenuStrip(components);
            tsmiViewPatientDetails = new ToolStripMenuItem();
            tsmiAddNewPatient = new ToolStripMenuItem();
            tsmiUpdatePatientInfo = new ToolStripMenuItem();
            tsmiDeletePatient = new ToolStripMenuItem();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddNewPatient = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            cmsOptions.SuspendLayout();
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
            lblHeaderTitle.Size = new Size(181, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "البحث واختيار المريض";
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
            txtSearch.Text = "🔍 أدخل الرقم الوطني للبحث السريع...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AllowUserToResizeRows = false;
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeight = 40;
            dgvPatients.ContextMenuStrip = cmsOptions;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = Color.FromArgb(225, 230, 240);
            dgvPatients.Location = new Point(16, 120);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 35;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(818, 350);
            dgvPatients.TabIndex = 2;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            // 
            // cmsOptions
            // 
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { tsmiViewPatientDetails, tsmiAddNewPatient, tsmiUpdatePatientInfo, tsmiDeletePatient });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RightToLeft = RightToLeft.Yes;
            cmsOptions.Size = new Size(164, 92);
            // 
            // tsmiViewPatientDetails
            // 
            tsmiViewPatientDetails.Name = "tsmiViewPatientDetails";
            tsmiViewPatientDetails.Size = new Size(163, 22);
            tsmiViewPatientDetails.Text = "👁️   عرض البيانات";
            tsmiViewPatientDetails.Click += tsmiViewPatientDetails_Click;
            // 
            // tsmiAddNewPatient
            // 
            tsmiAddNewPatient.Name = "tsmiAddNewPatient";
            tsmiAddNewPatient.Size = new Size(163, 22);
            tsmiAddNewPatient.Text = "➕   إضافة مريض";
            tsmiAddNewPatient.Click += tsmiAddNewPatient_Click;
            // 
            // tsmiUpdatePatientInfo
            // 
            tsmiUpdatePatientInfo.Name = "tsmiUpdatePatientInfo";
            tsmiUpdatePatientInfo.Size = new Size(163, 22);
            tsmiUpdatePatientInfo.Text = "✏️   تعديل البيانات";
            // 
            // tsmiDeletePatient
            // 
            tsmiDeletePatient.ForeColor = Color.DarkRed;
            tsmiDeletePatient.Name = "tsmiDeletePatient";
            tsmiDeletePatient.Size = new Size(163, 22);
            tsmiDeletePatient.Text = "❌   حذف المريض";
            tsmiDeletePatient.Click += tsmiDeletePatient_Click;
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
            btnSelect.Click += btnSelect_Click;
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
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddNewPatient
            // 
            btnAddNewPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNewPatient.BackColor = Color.FromArgb(0, 123, 255);
            btnAddNewPatient.FlatStyle = FlatStyle.Flat;
            btnAddNewPatient.Font = new Font("Segoe UI", 10F);
            btnAddNewPatient.ForeColor = Color.White;
            btnAddNewPatient.Location = new Point(16, 490);
            btnAddNewPatient.Name = "btnAddNewPatient";
            btnAddNewPatient.Size = new Size(158, 39);
            btnAddNewPatient.TabIndex = 5;
            btnAddNewPatient.Text = "➕ إضافة مريض جديد";
            btnAddNewPatient.UseVisualStyleBackColor = false;
            btnAddNewPatient.Click += btnAddNewPatient_Click;
            // 
            // frmChoosePatient
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(850, 550);
            Controls.Add(btnAddNewPatient);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvPatients);
            Controls.Add(txtSearch);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(750, 500);
            Name = "frmChoosePatient";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة اختيار مريض";
            Load += frmChoosePatient_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewPatient;
        private ContextMenuStrip cmsOptions;

        
        // الأزرار الأربعة الجديدة:
        private System.Windows.Forms.ToolStripMenuItem tsmiViewPatientDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPatient;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePatient;
    }
}