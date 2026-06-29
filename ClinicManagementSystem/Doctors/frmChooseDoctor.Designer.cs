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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            lblHeaderTitle = new Label();
            txtSearch = new TextBox();
            dgvDoctors = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripShowDoctorInfo = new ToolStripMenuItem();
            toolStripAddNewDoctor = new ToolStripMenuItem();
            toolStripUpdateDoctorData = new ToolStripMenuItem();
            toolStripDeleteDoctor = new ToolStripMenuItem();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddNewDoctor = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctors.ColumnHeadersHeight = 40;
            dgvDoctors.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle2;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripShowDoctorInfo, toolStripAddNewDoctor, toolStripUpdateDoctorData, toolStripDeleteDoctor });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(209, 100);
            // 
            // toolStripShowDoctorInfo
            // 
            toolStripShowDoctorInfo.Font = new Font("Segoe UI", 11.25F);
            toolStripShowDoctorInfo.ForeColor = Color.Black;
            toolStripShowDoctorInfo.Name = "toolStripShowDoctorInfo";
            toolStripShowDoctorInfo.Size = new Size(208, 24);
            toolStripShowDoctorInfo.Text = "عرض بيانات الطبيب";
            toolStripShowDoctorInfo.Click += toolStripShowDoctorInfo_Click;
            // 
            // toolStripAddNewDoctor
            // 
            toolStripAddNewDoctor.Font = new Font("Segoe UI", 11.25F);
            toolStripAddNewDoctor.ForeColor = Color.Green;
            toolStripAddNewDoctor.Name = "toolStripAddNewDoctor";
            toolStripAddNewDoctor.Size = new Size(208, 24);
            toolStripAddNewDoctor.Text = "إضافة طبيب جديد";
            toolStripAddNewDoctor.Click += toolStripAddNewDoctor_Click;
            // 
            // toolStripUpdateDoctorData
            // 
            toolStripUpdateDoctorData.Font = new Font("Segoe UI", 11.25F);
            toolStripUpdateDoctorData.ForeColor = Color.Blue;
            toolStripUpdateDoctorData.Name = "toolStripUpdateDoctorData";
            toolStripUpdateDoctorData.Size = new Size(208, 24);
            toolStripUpdateDoctorData.Text = "تحديث بيانات الطبيب";
            //toolStripUpdateDoctorData.Click += this.toolStripUpdateDoctorData_Click;
            // 
            // toolStripDeleteDoctor
            // 
            toolStripDeleteDoctor.Font = new Font("Segoe UI", 11.25F);
            toolStripDeleteDoctor.ForeColor = Color.Red;
            toolStripDeleteDoctor.Name = "toolStripDeleteDoctor";
            toolStripDeleteDoctor.Size = new Size(208, 24);
            toolStripDeleteDoctor.Text = "حذف الطبيب";
            toolStripDeleteDoctor.Click += toolStripDeleteDoctor_Click;
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
            btnAddNewDoctor.Click += btnAddNewDoctor_Click;
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
            contextMenuStrip1.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripShowDoctorInfo;
        private ToolStripMenuItem toolStripAddNewDoctor;
        private ToolStripMenuItem toolStripUpdateDoctorData;
        private ToolStripMenuItem toolStripDeleteDoctor;
    }
}