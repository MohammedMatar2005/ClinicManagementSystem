namespace ClinicManagementSystem.Appointments
{
    partial class frmChooseAppointment : Form
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
            dgvAppointments = new DataGridView();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddNewAppointment = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripShowAppointmentInfo = new ToolStripMenuItem();
            toolStripUpdateAppointment = new ToolStripMenuItem();
            toolStripAddNewAppointment = new ToolStripMenuItem();
            toolStripDeleteAppointmen = new ToolStripMenuItem();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
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
            lblHeaderTitle.Size = new Size(171, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "البحث واختيار الموعد";
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
            txtSearch.Text = "🔍 أدخل اسم المريض أو الطبيب للبحث...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = Color.FromArgb(225, 230, 240);
            dgvAppointments.Location = new Point(16, 120);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(818, 350);
            dgvAppointments.TabIndex = 2;
            dgvAppointments.CellContentDoubleClick += dgvAppointments_CellDoubleClick;
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
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNewAppointment.BackColor = Color.FromArgb(0, 123, 255);
            btnAddNewAppointment.FlatStyle = FlatStyle.Flat;
            btnAddNewAppointment.Font = new Font("Segoe UI", 10F);
            btnAddNewAppointment.ForeColor = Color.White;
            btnAddNewAppointment.Location = new Point(16, 490);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(158, 39);
            btnAddNewAppointment.TabIndex = 5;
            btnAddNewAppointment.Text = "➕ حجز موعد جديد";
            btnAddNewAppointment.UseVisualStyleBackColor = false;
            btnAddNewAppointment.Click += btnAddNewAppointment_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripShowAppointmentInfo, toolStripUpdateAppointment, toolStripAddNewAppointment, toolStripDeleteAppointmen });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(206, 108);
            // 
            // toolStripShowAppointmentInfo
            // 
            toolStripShowAppointmentInfo.Name = "toolStripShowAppointmentInfo";
            toolStripShowAppointmentInfo.Size = new Size(205, 26);
            toolStripShowAppointmentInfo.Text = "عرض بيانات الموعد";
            toolStripShowAppointmentInfo.Click += toolStripShowAppointmentInfo_Click;
            // 
            // toolStripUpdateAppointment
            // 
            toolStripUpdateAppointment.Name = "toolStripUpdateAppointment";
            toolStripUpdateAppointment.Size = new Size(205, 26);
            toolStripUpdateAppointment.Text = "تحديث الموعد";
            toolStripUpdateAppointment.Click += toolStripUpdateAppointment_Click;
            // 
            // toolStripAddNewAppointment
            // 
            toolStripAddNewAppointment.ForeColor = Color.Green;
            toolStripAddNewAppointment.Name = "toolStripAddNewAppointment";
            toolStripAddNewAppointment.Size = new Size(205, 26);
            toolStripAddNewAppointment.Text = "حجز موعد جديد";
            // 
            // toolStripDeleteAppointmen
            // 
            toolStripDeleteAppointmen.ForeColor = Color.Red;
            toolStripDeleteAppointmen.Name = "toolStripDeleteAppointmen";
            toolStripDeleteAppointmen.Size = new Size(205, 26);
            toolStripDeleteAppointmen.Text = "إلغاء الموعد";
            // 
            // frmChooseAppointment
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(850, 550);
            Controls.Add(btnAddNewAppointment);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvAppointments);
            Controls.Add(txtSearch);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(750, 500);
            Name = "frmChooseAppointment";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة اختيار موعد";
            Load += frmChooseAppointment_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripShowAppointmentInfo;
        private ToolStripMenuItem toolStripUpdateAppointment;
        private ToolStripMenuItem toolStripAddNewAppointment;
        private ToolStripMenuItem toolStripDeleteAppointmen;
    }
}