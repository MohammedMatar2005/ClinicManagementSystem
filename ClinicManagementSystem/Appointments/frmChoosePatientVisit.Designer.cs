using System.Transactions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ClinicManagementSystem.Appointments
{
    public partial class frmChoosePatientVisit : Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            lblHeaderTitle = new Label();
            txtSearch = new TextBox();
            dgvVisits = new DataGridView();
            btnSelect = new Button();
            btnCancel = new Button();
            pnlTopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisits).BeginInit();
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
            lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(10, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(223, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "البحث واختيار زيارة المريض";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(16, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(818, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "🔍 ابحث بالتاريخ أو اسم الطبيب...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // dgvVisits
            // 
            dgvVisits.AllowUserToAddRows = false;
            dgvVisits.AllowUserToDeleteRows = false;
            dgvVisits.AllowUserToResizeRows = false;
            dgvVisits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVisits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisits.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvVisits.BorderStyle = BorderStyle.None;
            dgvVisits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVisits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 52, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisits.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 75, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 140, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVisits.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVisits.EnableHeadersVisualStyles = false;
            dgvVisits.GridColor = Color.FromArgb(225, 230, 240);
            dgvVisits.Location = new Point(16, 120);
            dgvVisits.MultiSelect = false;
            dgvVisits.Name = "dgvVisits";
            dgvVisits.ReadOnly = true;
            dgvVisits.RowHeadersVisible = false;
            dgvVisits.RowHeadersWidth = 51;
            dgvVisits.RowTemplate.Height = 35;
            dgvVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisits.Size = new Size(818, 350);
            dgvVisits.TabIndex = 2;
            dgvVisits.CellContentDoubleClick += dgvVisits_CellDoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.BackColor = Color.FromArgb(40, 167, 69);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
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
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(108, 117, 125);
            btnCancel.Location = new Point(598, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "إغلاق";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChoosePatientVisit
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(850, 550);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(dgvVisits);
            Controls.Add(txtSearch);
            Controls.Add(pnlTopHeader);
            MinimumSize = new Size(750, 500);
            Name = "frmChoosePatientVisit";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة اختيار زيارة المريض";
            Load += frmChoosePatientVisit_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}