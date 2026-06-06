namespace ClinicManagementSystem.Appointments
{
    partial class frmChooseDoctor : Form
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            lblHeaderTitle = new Label();
            txtSearch = new TextBox();
            dgvDoctors = new DataGridView();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddNewDoctor = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
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
            lblHeaderTitle.Size = new Size(174, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "البحث واختيار الطبيب";
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
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AllowUserToResizeRows = false;
            dgvDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvDoctors.BorderStyle = BorderStyle.None;
            dgvDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDoctors.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDoctors.EnableHeadersVisualStyles = false;
            dgvDoctors.GridColor = Color.FromArgb(225, 230, 240);
            dgvDoctors.Location = new Point(16, 120);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.RowTemplate.Height = 35;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(818, 350);
            dgvDoctors.TabIndex = 2;
            dgvDoctors.CellContentDoubleClick += dgvDoctors_CellDoubleClick;
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
            // btnAddNewDoctor
            // 
            btnAddNewDoctor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNewDoctor.BackColor = Color.FromArgb(0, 123, 255);
            btnAddNewDoctor.FlatStyle = FlatStyle.Flat;
            btnAddNewDoctor.Font = new Font("Segoe UI", 10F);
            btnAddNewDoctor.ForeColor = Color.White;
            btnAddNewDoctor.Location = new Point(16, 490);
            btnAddNewDoctor.Name = "btnAddNewDoctor";
            btnAddNewDoctor.Size = new Size(158, 39);
            btnAddNewDoctor.TabIndex = 5;
            btnAddNewDoctor.Text = "➕ إضافة طبيب جديد";
            btnAddNewDoctor.UseVisualStyleBackColor = false;
            // 
            // frmChooseDoctor
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(850, 550);
            Controls.Add(btnAddNewDoctor);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvDoctors);
            Controls.Add(txtSearch);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(750, 500);
            Name = "frmChooseDoctor";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة اختيار طبيب";
            Load += frmChooseDoctor_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewDoctor;
    }
}