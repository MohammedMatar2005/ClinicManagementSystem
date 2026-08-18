using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmAdvancedSettings : Form
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
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            tabControlAdvanced = new TabControl();
            tabDatabase = new TabPage();
            tlpDatabaseRoot = new TableLayoutPanel();
            gbConnectionString = new GroupBox();
            tlpConnString = new TableLayoutPanel();
            lblConnString = new Label();
            txtConnectionString = new TextBox();
            btnTestConnection = new Button();
            gbBackupSettings = new GroupBox();
            tlpBackup = new TableLayoutPanel();
            chkEnableAutoBackup = new CheckBox();
            lblBackupSchedule = new Label();
            cmbBackupSchedule = new ComboBox();
            lblBackupPath = new Label();
            tlpBackupPathRow = new TableLayoutPanel();
            txtBackupPath = new TextBox();
            btnBrowseBackupPath = new Button();
            tabSecurity = new TabPage();
            tlpSecurityRoot = new TableLayoutPanel();
            gbSystemLogs = new GroupBox();
            tlpLogs = new TableLayoutPanel();
            lblLogRetention = new Label();
            numLogRetentionMonths = new NumericUpDown();
            chkAutoPurgeLogs = new CheckBox();
            gbSessionSecurity = new GroupBox();
            tlpSession = new TableLayoutPanel();
            chkEnableAutoLogout = new CheckBox();
            lblLogoutTime = new Label();
            numAutoLogoutMinutes = new NumericUpDown();
            pnlFooter = new Panel();
            flpFooterButtons = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            fbdBackupLocation = new FolderBrowserDialog();
            pnlHeader.SuspendLayout();
            tabControlAdvanced.SuspendLayout();
            tabDatabase.SuspendLayout();
            tlpDatabaseRoot.SuspendLayout();
            gbConnectionString.SuspendLayout();
            tlpConnString.SuspendLayout();
            gbBackupSettings.SuspendLayout();
            tlpBackup.SuspendLayout();
            tlpBackupPathRow.SuspendLayout();
            tabSecurity.SuspendLayout();
            tlpSecurityRoot.SuspendLayout();
            gbSystemLogs.SuspendLayout();
            tlpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLogRetentionMonths).BeginInit();
            gbSessionSecurity.SuspendLayout();
            tlpSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAutoLogoutMinutes).BeginInit();
            pnlFooter.SuspendLayout();
            flpFooterButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(884, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(884, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "🛠️ إعدادات النظام المتقدمة والأمان";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControlAdvanced
            // 
            tabControlAdvanced.Controls.Add(tabDatabase);
            tabControlAdvanced.Controls.Add(tabSecurity);
            tabControlAdvanced.Dock = DockStyle.Fill;
            tabControlAdvanced.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControlAdvanced.ItemSize = new Size(220, 42);
            tabControlAdvanced.Location = new Point(0, 60);
            tabControlAdvanced.Name = "tabControlAdvanced";
            tabControlAdvanced.Padding = new Point(15, 6);
            tabControlAdvanced.SelectedIndex = 0;
            tabControlAdvanced.Size = new Size(884, 451);
            tabControlAdvanced.SizeMode = TabSizeMode.Fixed;
            tabControlAdvanced.TabIndex = 1;
            // 
            // tabDatabase
            // 
            tabDatabase.BackColor = Color.FromArgb(244, 247, 250);
            tabDatabase.Controls.Add(tlpDatabaseRoot);
            tabDatabase.Location = new Point(4, 46);
            tabDatabase.Name = "tabDatabase";
            tabDatabase.Padding = new Padding(20);
            tabDatabase.Size = new Size(876, 401);
            tabDatabase.TabIndex = 0;
            tabDatabase.Text = "قاعدة البيانات والنسخ الاحتياطي";
            // 
            // tlpDatabaseRoot
            // 
            tlpDatabaseRoot.ColumnCount = 1;
            tlpDatabaseRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDatabaseRoot.Controls.Add(gbConnectionString, 0, 0);
            tlpDatabaseRoot.Controls.Add(gbBackupSettings, 0, 1);
            tlpDatabaseRoot.Dock = DockStyle.Fill;
            tlpDatabaseRoot.Location = new Point(20, 20);
            tlpDatabaseRoot.Name = "tlpDatabaseRoot";
            tlpDatabaseRoot.RowCount = 2;
            tlpDatabaseRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpDatabaseRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDatabaseRoot.Size = new Size(836, 361);
            tlpDatabaseRoot.TabIndex = 0;
            // 
            // gbConnectionString
            // 
            gbConnectionString.BackColor = Color.White;
            gbConnectionString.Controls.Add(tlpConnString);
            gbConnectionString.Dock = DockStyle.Fill;
            gbConnectionString.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbConnectionString.ForeColor = Color.FromArgb(41, 128, 185);
            gbConnectionString.Location = new Point(3, 3);
            gbConnectionString.Margin = new Padding(3, 3, 3, 10);
            gbConnectionString.Name = "gbConnectionString";
            gbConnectionString.Padding = new Padding(12);
            gbConnectionString.Size = new Size(830, 112);
            gbConnectionString.TabIndex = 0;
            gbConnectionString.TabStop = false;
            gbConnectionString.Text = "اتصال خادم البيانات (SQL Server)";
            // 
            // tlpConnString
            // 
            tlpConnString.ColumnCount = 2;
            tlpConnString.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tlpConnString.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tlpConnString.Controls.Add(lblConnString, 0, 0);
            tlpConnString.Controls.Add(txtConnectionString, 0, 1);
            tlpConnString.Controls.Add(btnTestConnection, 1, 1);
            tlpConnString.Dock = DockStyle.Fill;
            tlpConnString.Location = new Point(12, 30);
            tlpConnString.Name = "tlpConnString";
            tlpConnString.RowCount = 2;
            tlpConnString.RowStyles.Add(new RowStyle());
            tlpConnString.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConnString.Size = new Size(806, 70);
            tlpConnString.TabIndex = 0;
            // 
            // lblConnString
            // 
            lblConnString.AutoSize = true;
            lblConnString.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConnString.ForeColor = Color.FromArgb(100, 110, 120);
            lblConnString.Location = new Point(565, 0);
            lblConnString.Margin = new Padding(3, 0, 3, 4);
            lblConnString.Name = "lblConnString";
            lblConnString.Size = new Size(238, 17);
            lblConnString.TabIndex = 0;
            lblConnString.Text = "نص الاتصال الحالي (Connection String):";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConnectionString.BackColor = Color.White;
            txtConnectionString.BorderStyle = BorderStyle.FixedSingle;
            txtConnectionString.Font = new Font("Consolas", 10F);
            txtConnectionString.ForeColor = Color.FromArgb(33, 37, 41);
            txtConnectionString.Location = new Point(146, 23);
            txtConnectionString.Margin = new Padding(3, 2, 8, 2);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.RightToLeft = RightToLeft.No;
            txtConnectionString.Size = new Size(657, 23);
            txtConnectionString.TabIndex = 1;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTestConnection.BackColor = Color.FromArgb(52, 152, 219);
            btnTestConnection.FlatAppearance.BorderSize = 0;
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(3, 22);
            btnTestConnection.Margin = new Padding(3, 1, 3, 3);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(132, 26);
            btnTestConnection.TabIndex = 2;
            btnTestConnection.Text = "⚡ فحص الاتصال";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // gbBackupSettings
            // 
            gbBackupSettings.BackColor = Color.White;
            gbBackupSettings.Controls.Add(tlpBackup);
            gbBackupSettings.Dock = DockStyle.Fill;
            gbBackupSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBackupSettings.ForeColor = Color.FromArgb(41, 128, 185);
            gbBackupSettings.Location = new Point(3, 128);
            gbBackupSettings.Name = "gbBackupSettings";
            gbBackupSettings.Padding = new Padding(12);
            gbBackupSettings.Size = new Size(830, 230);
            gbBackupSettings.TabIndex = 1;
            gbBackupSettings.TabStop = false;
            gbBackupSettings.Text = "النسخ الاحتياطي التلقائي للأمان المتقدم";
            // 
            // tlpBackup
            // 
            tlpBackup.ColumnCount = 1;
            tlpBackup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBackup.Controls.Add(chkEnableAutoBackup, 0, 0);
            tlpBackup.Controls.Add(lblBackupSchedule, 0, 1);
            tlpBackup.Controls.Add(cmbBackupSchedule, 0, 2);
            tlpBackup.Controls.Add(lblBackupPath, 0, 3);
            tlpBackup.Controls.Add(tlpBackupPathRow, 0, 4);
            tlpBackup.Dock = DockStyle.Fill;
            tlpBackup.Location = new Point(12, 30);
            tlpBackup.Name = "tlpBackup";
            tlpBackup.RowCount = 5;
            tlpBackup.RowStyles.Add(new RowStyle());
            tlpBackup.RowStyles.Add(new RowStyle());
            tlpBackup.RowStyles.Add(new RowStyle());
            tlpBackup.RowStyles.Add(new RowStyle());
            tlpBackup.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBackup.Size = new Size(806, 188);
            tlpBackup.TabIndex = 0;
            // 
            // chkEnableAutoBackup
            // 
            chkEnableAutoBackup.AutoSize = true;
            chkEnableAutoBackup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkEnableAutoBackup.ForeColor = Color.FromArgb(44, 62, 80);
            chkEnableAutoBackup.Location = new Point(589, 3);
            chkEnableAutoBackup.Margin = new Padding(3, 3, 3, 12);
            chkEnableAutoBackup.Name = "chkEnableAutoBackup";
            chkEnableAutoBackup.Size = new Size(214, 23);
            chkEnableAutoBackup.TabIndex = 0;
            chkEnableAutoBackup.Text = "تفعيل النسخ الاحتياطي التلقائي";
            chkEnableAutoBackup.UseVisualStyleBackColor = true;
            // 
            // lblBackupSchedule
            // 
            lblBackupSchedule.AutoSize = true;
            lblBackupSchedule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBackupSchedule.ForeColor = Color.FromArgb(100, 110, 120);
            lblBackupSchedule.Location = new Point(672, 38);
            lblBackupSchedule.Margin = new Padding(3, 0, 3, 4);
            lblBackupSchedule.Name = "lblBackupSchedule";
            lblBackupSchedule.Size = new Size(131, 17);
            lblBackupSchedule.TabIndex = 1;
            lblBackupSchedule.Text = "الجدول الزمني التكراري:";
            // 
            // cmbBackupSchedule
            // 
            cmbBackupSchedule.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBackupSchedule.Font = new Font("Segoe UI", 10F);
            cmbBackupSchedule.FormattingEnabled = true;
            cmbBackupSchedule.Items.AddRange(new object[] { "يومي (ينصح به بشدة لحفظ ملفات المرضى)", "أسبوعي", "شهري" });
            cmbBackupSchedule.Location = new Point(486, 59);
            cmbBackupSchedule.Margin = new Padding(3, 0, 3, 12);
            cmbBackupSchedule.Name = "cmbBackupSchedule";
            cmbBackupSchedule.Size = new Size(317, 25);
            cmbBackupSchedule.TabIndex = 2;
            // 
            // lblBackupPath
            // 
            lblBackupPath.AutoSize = true;
            lblBackupPath.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBackupPath.ForeColor = Color.FromArgb(100, 110, 120);
            lblBackupPath.Location = new Point(645, 96);
            lblBackupPath.Margin = new Padding(3, 0, 3, 4);
            lblBackupPath.Name = "lblBackupPath";
            lblBackupPath.Size = new Size(158, 17);
            lblBackupPath.TabIndex = 3;
            lblBackupPath.Text = "مسار حفظ النسخ الاحتياطية:";
            // 
            // tlpBackupPathRow
            // 
            tlpBackupPathRow.ColumnCount = 2;
            tlpBackupPathRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpBackupPathRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpBackupPathRow.Controls.Add(txtBackupPath, 0, 0);
            tlpBackupPathRow.Controls.Add(btnBrowseBackupPath, 1, 0);
            tlpBackupPathRow.Dock = DockStyle.Fill;
            tlpBackupPathRow.Location = new Point(3, 120);
            tlpBackupPathRow.Name = "tlpBackupPathRow";
            tlpBackupPathRow.RowCount = 1;
            tlpBackupPathRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBackupPathRow.Size = new Size(800, 65);
            tlpBackupPathRow.TabIndex = 4;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBackupPath.BackColor = Color.White;
            txtBackupPath.BorderStyle = BorderStyle.FixedSingle;
            txtBackupPath.Font = new Font("Segoe UI", 10F);
            txtBackupPath.ForeColor = Color.FromArgb(33, 37, 41);
            txtBackupPath.Location = new Point(128, 2);
            txtBackupPath.Margin = new Padding(3, 2, 8, 2);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.ReadOnly = true;
            txtBackupPath.Size = new Size(669, 25);
            txtBackupPath.TabIndex = 0;
            // 
            // btnBrowseBackupPath
            // 
            btnBrowseBackupPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBrowseBackupPath.BackColor = Color.FromArgb(142, 68, 173);
            btnBrowseBackupPath.FlatAppearance.BorderSize = 0;
            btnBrowseBackupPath.FlatStyle = FlatStyle.Flat;
            btnBrowseBackupPath.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBrowseBackupPath.ForeColor = Color.White;
            btnBrowseBackupPath.Location = new Point(3, 1);
            btnBrowseBackupPath.Margin = new Padding(3, 1, 3, 3);
            btnBrowseBackupPath.Name = "btnBrowseBackupPath";
            btnBrowseBackupPath.Size = new Size(114, 26);
            btnBrowseBackupPath.TabIndex = 1;
            btnBrowseBackupPath.Text = "📁 استعراض...";
            btnBrowseBackupPath.UseVisualStyleBackColor = false;
            // 
            // tabSecurity
            // 
            tabSecurity.BackColor = Color.FromArgb(244, 247, 250);
            tabSecurity.Controls.Add(tlpSecurityRoot);
            tabSecurity.Location = new Point(4, 46);
            tabSecurity.Name = "tabSecurity";
            tabSecurity.Padding = new Padding(20);
            tabSecurity.Size = new Size(876, 401);
            tabSecurity.TabIndex = 1;
            tabSecurity.Text = "الأمان والصيانة الحساسة";
            // 
            // tlpSecurityRoot
            // 
            tlpSecurityRoot.ColumnCount = 1;
            tlpSecurityRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSecurityRoot.Controls.Add(gbSystemLogs, 0, 0);
            tlpSecurityRoot.Controls.Add(gbSessionSecurity, 0, 1);
            tlpSecurityRoot.Dock = DockStyle.Fill;
            tlpSecurityRoot.Location = new Point(20, 20);
            tlpSecurityRoot.Name = "tlpSecurityRoot";
            tlpSecurityRoot.RowCount = 2;
            tlpSecurityRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpSecurityRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSecurityRoot.Size = new Size(836, 361);
            tlpSecurityRoot.TabIndex = 0;
            // 
            // gbSystemLogs
            // 
            gbSystemLogs.BackColor = Color.White;
            gbSystemLogs.Controls.Add(tlpLogs);
            gbSystemLogs.Dock = DockStyle.Fill;
            gbSystemLogs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbSystemLogs.ForeColor = Color.FromArgb(211, 84, 0);
            gbSystemLogs.Location = new Point(3, 3);
            gbSystemLogs.Margin = new Padding(3, 3, 3, 10);
            gbSystemLogs.Name = "gbSystemLogs";
            gbSystemLogs.Padding = new Padding(12);
            gbSystemLogs.Size = new Size(830, 117);
            gbSystemLogs.TabIndex = 0;
            gbSystemLogs.TabStop = false;
            gbSystemLogs.Text = "فترة الاحتفاظ بسجلات الأحداث والنظام (Log Retention)";
            // 
            // tlpLogs
            // 
            tlpLogs.ColumnCount = 2;
            tlpLogs.ColumnStyles.Add(new ColumnStyle());
            tlpLogs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogs.Controls.Add(lblLogRetention, 0, 0);
            tlpLogs.Controls.Add(numLogRetentionMonths, 1, 0);
            tlpLogs.Controls.Add(chkAutoPurgeLogs, 0, 1);
            tlpLogs.Dock = DockStyle.Fill;
            tlpLogs.Location = new Point(12, 30);
            tlpLogs.Name = "tlpLogs";
            tlpLogs.RowCount = 2;
            tlpLogs.RowStyles.Add(new RowStyle());
            tlpLogs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLogs.Size = new Size(806, 75);
            tlpLogs.TabIndex = 0;
            // 
            // lblLogRetention
            // 
            lblLogRetention.Anchor = AnchorStyles.Left;
            lblLogRetention.AutoSize = true;
            lblLogRetention.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLogRetention.ForeColor = Color.FromArgb(100, 110, 120);
            lblLogRetention.Location = new Point(628, 9);
            lblLogRetention.Margin = new Padding(3, 0, 6, 0);
            lblLogRetention.Name = "lblLogRetention";
            lblLogRetention.Size = new Size(175, 17);
            lblLogRetention.TabIndex = 0;
            lblLogRetention.Text = "الاحتفاظ بسجلات الأحداث لمدة:";
            // 
            // numLogRetentionMonths
            // 
            numLogRetentionMonths.Font = new Font("Segoe UI", 10F);
            numLogRetentionMonths.Location = new Point(504, 2);
            numLogRetentionMonths.Margin = new Padding(3, 2, 3, 8);
            numLogRetentionMonths.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numLogRetentionMonths.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLogRetentionMonths.Name = "numLogRetentionMonths";
            numLogRetentionMonths.Size = new Size(115, 25);
            numLogRetentionMonths.TabIndex = 1;
            numLogRetentionMonths.TextAlign = HorizontalAlignment.Center;
            numLogRetentionMonths.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // chkAutoPurgeLogs
            // 
            chkAutoPurgeLogs.AutoSize = true;
            tlpLogs.SetColumnSpan(chkAutoPurgeLogs, 2);
            chkAutoPurgeLogs.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkAutoPurgeLogs.ForeColor = Color.FromArgb(44, 62, 80);
            chkAutoPurgeLogs.Location = new Point(394, 38);
            chkAutoPurgeLogs.Name = "chkAutoPurgeLogs";
            chkAutoPurgeLogs.Size = new Size(409, 21);
            chkAutoPurgeLogs.TabIndex = 2;
            chkAutoPurgeLogs.Text = "حذف السجلات القديمة تلقائياً لتوفير مساحة وتخفيف حجم قاعدة البيانات";
            chkAutoPurgeLogs.UseVisualStyleBackColor = true;
            // 
            // gbSessionSecurity
            // 
            gbSessionSecurity.BackColor = Color.White;
            gbSessionSecurity.Controls.Add(tlpSession);
            gbSessionSecurity.Dock = DockStyle.Fill;
            gbSessionSecurity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbSessionSecurity.ForeColor = Color.FromArgb(192, 57, 43);
            gbSessionSecurity.Location = new Point(3, 133);
            gbSessionSecurity.Name = "gbSessionSecurity";
            gbSessionSecurity.Padding = new Padding(12);
            gbSessionSecurity.Size = new Size(830, 225);
            gbSessionSecurity.TabIndex = 1;
            gbSessionSecurity.TabStop = false;
            gbSessionSecurity.Text = "خصوصية بيانات المرضى وحماية الجلسة الخاملة";
            // 
            // tlpSession
            // 
            tlpSession.ColumnCount = 2;
            tlpSession.ColumnStyles.Add(new ColumnStyle());
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSession.Controls.Add(chkEnableAutoLogout, 0, 0);
            tlpSession.Controls.Add(lblLogoutTime, 0, 1);
            tlpSession.Controls.Add(numAutoLogoutMinutes, 1, 1);
            tlpSession.Dock = DockStyle.Fill;
            tlpSession.Location = new Point(12, 30);
            tlpSession.Name = "tlpSession";
            tlpSession.RowCount = 3;
            tlpSession.RowStyles.Add(new RowStyle());
            tlpSession.RowStyles.Add(new RowStyle());
            tlpSession.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSession.Size = new Size(806, 183);
            tlpSession.TabIndex = 0;
            // 
            // chkEnableAutoLogout
            // 
            chkEnableAutoLogout.AutoSize = true;
            tlpSession.SetColumnSpan(chkEnableAutoLogout, 2);
            chkEnableAutoLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkEnableAutoLogout.ForeColor = Color.FromArgb(44, 62, 80);
            chkEnableAutoLogout.Location = new Point(481, 3);
            chkEnableAutoLogout.Margin = new Padding(3, 3, 3, 12);
            chkEnableAutoLogout.Name = "chkEnableAutoLogout";
            chkEnableAutoLogout.Size = new Size(322, 23);
            chkEnableAutoLogout.TabIndex = 0;
            chkEnableAutoLogout.Text = "تفعيل قفل الشاشة / تسجيل الخروج التلقائي للأمان";
            chkEnableAutoLogout.UseVisualStyleBackColor = true;
            // 
            // lblLogoutTime
            // 
            lblLogoutTime.Anchor = AnchorStyles.Left;
            lblLogoutTime.AutoSize = true;
            lblLogoutTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLogoutTime.ForeColor = Color.FromArgb(100, 110, 120);
            lblLogoutTime.Location = new Point(577, 45);
            lblLogoutTime.Margin = new Padding(3, 0, 6, 0);
            lblLogoutTime.Name = "lblLogoutTime";
            lblLogoutTime.Size = new Size(226, 17);
            lblLogoutTime.TabIndex = 1;
            lblLogoutTime.Text = "المهلة الزمنية عند عدم الحركة (بالدقائق):";
            // 
            // numAutoLogoutMinutes
            // 
            numAutoLogoutMinutes.Font = new Font("Segoe UI", 10F);
            numAutoLogoutMinutes.Location = new Point(453, 41);
            numAutoLogoutMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numAutoLogoutMinutes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAutoLogoutMinutes.Name = "numAutoLogoutMinutes";
            numAutoLogoutMinutes.Size = new Size(115, 25);
            numAutoLogoutMinutes.TabIndex = 2;
            numAutoLogoutMinutes.TextAlign = HorizontalAlignment.Center;
            numAutoLogoutMinutes.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(233, 236, 239);
            pnlFooter.Controls.Add(flpFooterButtons);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 511);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(884, 60);
            pnlFooter.TabIndex = 2;
            // 
            // flpFooterButtons
            // 
            flpFooterButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpFooterButtons.AutoSize = true;
            flpFooterButtons.Controls.Add(btnCancel);
            flpFooterButtons.Controls.Add(btnSave);
            flpFooterButtons.FlowDirection = FlowDirection.RightToLeft;
            flpFooterButtons.Location = new Point(20, 10);
            flpFooterButtons.Name = "flpFooterButtons";
            flpFooterButtons.Size = new Size(244, 40);
            flpFooterButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(6, 3);
            btnCancel.Margin = new Padding(3, 3, 6, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "إلغاء الأمر";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(122, 3);
            btnSave.Margin = new Padding(6, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ التغييرات";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmAdvancedSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 571);
            Controls.Add(tabControlAdvanced);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(800, 550);
            Name = "frmAdvancedSettings";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الإعدادات المتقدمة";
            pnlHeader.ResumeLayout(false);
            tabControlAdvanced.ResumeLayout(false);
            tabDatabase.ResumeLayout(false);
            tlpDatabaseRoot.ResumeLayout(false);
            gbConnectionString.ResumeLayout(false);
            tlpConnString.ResumeLayout(false);
            tlpConnString.PerformLayout();
            gbBackupSettings.ResumeLayout(false);
            tlpBackup.ResumeLayout(false);
            tlpBackup.PerformLayout();
            tlpBackupPathRow.ResumeLayout(false);
            tlpBackupPathRow.PerformLayout();
            tabSecurity.ResumeLayout(false);
            tlpSecurityRoot.ResumeLayout(false);
            gbSystemLogs.ResumeLayout(false);
            tlpLogs.ResumeLayout(false);
            tlpLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLogRetentionMonths).EndInit();
            gbSessionSecurity.ResumeLayout(false);
            tlpSession.ResumeLayout(false);
            tlpSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAutoLogoutMinutes).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            flpFooterButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblFormTitle;
        private TabControl tabControlAdvanced;
        private TabPage tabDatabase;
        private TableLayoutPanel tlpDatabaseRoot;
        private GroupBox gbConnectionString;
        private TableLayoutPanel tlpConnString;
        private Label lblConnString;
        private TextBox txtConnectionString;
        private Button btnTestConnection;
        private GroupBox gbBackupSettings;
        private TableLayoutPanel tlpBackup;
        private CheckBox chkEnableAutoBackup;
        private Label lblBackupSchedule;
        private ComboBox cmbBackupSchedule;
        private Label lblBackupPath;
        private TableLayoutPanel tlpBackupPathRow;
        private TextBox txtBackupPath;
        private Button btnBrowseBackupPath;
        private TabPage tabSecurity;
        private TableLayoutPanel tlpSecurityRoot;
        private GroupBox gbSystemLogs;
        private TableLayoutPanel tlpLogs;
        private Label lblLogRetention;
        private NumericUpDown numLogRetentionMonths;
        private CheckBox chkAutoPurgeLogs;
        private GroupBox gbSessionSecurity;
        private TableLayoutPanel tlpSession;
        private CheckBox chkEnableAutoLogout;
        private Label lblLogoutTime;
        private NumericUpDown numAutoLogoutMinutes;
        private Panel pnlFooter;
        private FlowLayoutPanel flpFooterButtons;
        private Button btnCancel;
        private Button btnSave;
        private FolderBrowserDialog fbdBackupLocation;
    }
}