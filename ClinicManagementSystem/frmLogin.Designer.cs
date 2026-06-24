
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    partial class frmLogin : Form
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
            mainContainerPanel = new Panel();
            mainLayoutGrid = new TableLayoutPanel();
            brandPanel = new Panel();
            lblSubTitle = new Label();
            lblMainTitle = new Label();
            lineDecorator = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            loginCardPanel = new Panel();
            loginCardContentLayout = new TableLayoutPanel();
            iconContainer = new Panel();
            lblIcon = new Label();
            lblLoginHeader = new Label();
            lblLoginSubHeader = new Label();
            lblUsernameTitle = new Label();
            txtUserBorder = new Panel();
            txtUserLayout = new TableLayoutPanel();
            lblUserIcon = new Label();
            txtUsername = new TextBox();
            lblPasswordTitle = new Label();
            txtPassBorder = new Panel();
            txtPassLayout = new TableLayoutPanel();
            lblPassIcon = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            windowControlsFlowPanel = new FlowLayoutPanel();
            btnClose = new Button();
            btnMinimize = new Button();
            mainContainerPanel.SuspendLayout();
            mainLayoutGrid.SuspendLayout();
            brandPanel.SuspendLayout();
            loginCardPanel.SuspendLayout();
            loginCardContentLayout.SuspendLayout();
            iconContainer.SuspendLayout();
            txtUserBorder.SuspendLayout();
            txtUserLayout.SuspendLayout();
            txtPassBorder.SuspendLayout();
            txtPassLayout.SuspendLayout();
            windowControlsFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.BackColor = Color.FromArgb(30, 41, 59);
            mainContainerPanel.Controls.Add(mainLayoutGrid);
            mainContainerPanel.Controls.Add(windowControlsFlowPanel);
            mainContainerPanel.Dock = DockStyle.Fill;
            mainContainerPanel.Location = new Point(0, 0);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Padding = new Padding(45);
            mainContainerPanel.Size = new Size(1000, 650);
            mainContainerPanel.TabIndex = 0;
            // 
            // mainLayoutGrid
            // 
            mainLayoutGrid.BackColor = Color.Transparent;
            mainLayoutGrid.ColumnCount = 2;
            mainLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            mainLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            mainLayoutGrid.Controls.Add(brandPanel, 0, 0);
            mainLayoutGrid.Controls.Add(loginCardPanel, 1, 0);
            mainLayoutGrid.Dock = DockStyle.Fill;
            mainLayoutGrid.Location = new Point(45, 45);
            mainLayoutGrid.Name = "mainLayoutGrid";
            mainLayoutGrid.RowCount = 1;
            mainLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutGrid.Size = new Size(910, 560);
            mainLayoutGrid.TabIndex = 0;
            // 
            // brandPanel
            // 
            brandPanel.Controls.Add(lblSubTitle);
            brandPanel.Controls.Add(lblMainTitle);
            brandPanel.Controls.Add(lineDecorator);
            brandPanel.Controls.Add(lblTime);
            brandPanel.Controls.Add(lblDate);
            brandPanel.Dock = DockStyle.Fill;
            brandPanel.Location = new Point(413, 3);
            brandPanel.Name = "brandPanel";
            brandPanel.Size = new Size(494, 554);
            brandPanel.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI Light", 24F);
            lblSubTitle.ForeColor = Color.FromArgb(16, 185, 129);
            lblSubTitle.Location = new Point(150, 95);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(259, 45);
            lblSubTitle.TabIndex = 0;
            lblSubTitle.Text = "مرحباً بك مجدداً 👋";
            lblSubTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMainTitle
            // 
            lblMainTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.White;
            lblMainTitle.Location = new Point(3, 150);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(465, 74);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "عيادة الشفاء الذكية";
            lblMainTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lineDecorator
            // 
            lineDecorator.Anchor = AnchorStyles.Left;
            lineDecorator.BackColor = Color.FromArgb(16, 185, 129);
            lineDecorator.Location = new Point(415, 239);
            lineDecorator.Name = "lineDecorator";
            lineDecorator.Size = new Size(60, 5);
            lineDecorator.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 56F, FontStyle.Bold);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(3, 260);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(350, 100);
            lblTime.TabIndex = 3;
            lblTime.Text = "12:00 PM";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 18F);
            lblDate.ForeColor = Color.FromArgb(148, 147, 184);
            lblDate.Location = new Point(3, 365);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(146, 32);
            lblDate.TabIndex = 4;
            lblDate.Text = "الأحد، 31 مايو";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loginCardPanel
            // 
            loginCardPanel.BackColor = Color.FromArgb(248, 250, 252);
            loginCardPanel.Controls.Add(loginCardContentLayout);
            loginCardPanel.Dock = DockStyle.Fill;
            loginCardPanel.Location = new Point(3, 3);
            loginCardPanel.MaximumSize = new Size(400, 550);
            loginCardPanel.Name = "loginCardPanel";
            loginCardPanel.Padding = new Padding(35, 30, 35, 30);
            loginCardPanel.Size = new Size(400, 550);
            loginCardPanel.TabIndex = 1;
            // 
            // loginCardContentLayout
            // 
            loginCardContentLayout.BackColor = Color.Transparent;
            loginCardContentLayout.ColumnCount = 1;
            loginCardContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginCardContentLayout.Controls.Add(iconContainer, 0, 0);
            loginCardContentLayout.Controls.Add(lblLoginHeader, 0, 1);
            loginCardContentLayout.Controls.Add(lblLoginSubHeader, 0, 2);
            loginCardContentLayout.Controls.Add(lblUsernameTitle, 0, 3);
            loginCardContentLayout.Controls.Add(txtUserBorder, 0, 4);
            loginCardContentLayout.Controls.Add(lblPasswordTitle, 0, 5);
            loginCardContentLayout.Controls.Add(txtPassBorder, 0, 6);
            loginCardContentLayout.Controls.Add(btnLogin, 0, 7);
            loginCardContentLayout.Dock = DockStyle.Fill;
            loginCardContentLayout.Location = new Point(35, 30);
            loginCardContentLayout.Name = "loginCardContentLayout";
            loginCardContentLayout.RowCount = 8;
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            loginCardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            loginCardContentLayout.Size = new Size(330, 490);
            loginCardContentLayout.TabIndex = 0;
            // 
            // iconContainer
            // 
            iconContainer.Anchor = AnchorStyles.None;
            iconContainer.BackColor = Color.FromArgb(220, 252, 231);
            iconContainer.Controls.Add(lblIcon);
            iconContainer.Location = new Point(130, 3);
            iconContainer.Name = "iconContainer";
            iconContainer.Size = new Size(70, 69);
            iconContainer.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.Dock = DockStyle.Fill;
            lblIcon.Font = new Font("Segoe UI", 28F);
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(70, 69);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "🏥";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginHeader
            // 
            lblLoginHeader.Dock = DockStyle.Fill;
            lblLoginHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLoginHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblLoginHeader.Location = new Point(3, 75);
            lblLoginHeader.Name = "lblLoginHeader";
            lblLoginHeader.Size = new Size(324, 40);
            lblLoginHeader.TabIndex = 1;
            lblLoginHeader.Text = "تسجيل الدخول";
            lblLoginHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginSubHeader
            // 
            lblLoginSubHeader.Dock = DockStyle.Fill;
            lblLoginSubHeader.Font = new Font("Segoe UI", 10F);
            lblLoginSubHeader.ForeColor = Color.FromArgb(100, 116, 139);
            lblLoginSubHeader.Location = new Point(3, 115);
            lblLoginSubHeader.Name = "lblLoginSubHeader";
            lblLoginSubHeader.Size = new Size(324, 35);
            lblLoginSubHeader.TabIndex = 2;
            lblLoginSubHeader.Text = "الرجاء إدخال بيانات الاعتماد للوصول";
            lblLoginSubHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsernameTitle
            // 
            lblUsernameTitle.Dock = DockStyle.Bottom;
            lblUsernameTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsernameTitle.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsernameTitle.Location = new Point(3, 153);
            lblUsernameTitle.Name = "lblUsernameTitle";
            lblUsernameTitle.Size = new Size(324, 19);
            lblUsernameTitle.TabIndex = 3;
            lblUsernameTitle.Text = "اسم المستخدم";
            lblUsernameTitle.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtUserBorder
            // 
            txtUserBorder.BackColor = Color.White;
            txtUserBorder.BorderStyle = BorderStyle.FixedSingle;
            txtUserBorder.Controls.Add(txtUserLayout);
            txtUserBorder.Dock = DockStyle.Fill;
            txtUserBorder.Location = new Point(3, 175);
            txtUserBorder.Name = "txtUserBorder";
            txtUserBorder.Padding = new Padding(1);
            txtUserBorder.Size = new Size(324, 54);
            txtUserBorder.TabIndex = 4;
            // 
            // txtUserLayout
            // 
            txtUserLayout.ColumnCount = 2;
            txtUserLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            txtUserLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            txtUserLayout.Controls.Add(lblUserIcon, 0, 0);
            txtUserLayout.Controls.Add(txtUsername, 1, 0);
            txtUserLayout.Dock = DockStyle.Fill;
            txtUserLayout.Location = new Point(1, 1);
            txtUserLayout.Name = "txtUserLayout";
            txtUserLayout.RowCount = 1;
            txtUserLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            txtUserLayout.Size = new Size(320, 50);
            txtUserLayout.TabIndex = 0;
            // 
            // lblUserIcon
            // 
            lblUserIcon.Dock = DockStyle.Fill;
            lblUserIcon.Font = new Font("Segoe UI", 14F);
            lblUserIcon.ForeColor = Color.FromArgb(16, 185, 129);
            lblUserIcon.Location = new Point(278, 0);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(39, 50);
            lblUserIcon.TabIndex = 0;
            lblUserIcon.Text = "👤";
            lblUserIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.ForeColor = Color.FromArgb(30, 41, 59);
            txtUsername.Location = new Point(3, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 25);
            txtUsername.TabIndex = 1;
            // 
            // lblPasswordTitle
            // 
            lblPasswordTitle.Dock = DockStyle.Bottom;
            lblPasswordTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPasswordTitle.ForeColor = Color.FromArgb(51, 65, 85);
            lblPasswordTitle.Location = new Point(3, 235);
            lblPasswordTitle.Name = "lblPasswordTitle";
            lblPasswordTitle.Size = new Size(324, 19);
            lblPasswordTitle.TabIndex = 5;
            lblPasswordTitle.Text = "كلمة المرور";
            lblPasswordTitle.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtPassBorder
            // 
            txtPassBorder.BackColor = Color.White;
            txtPassBorder.BorderStyle = BorderStyle.FixedSingle;
            txtPassBorder.Controls.Add(txtPassLayout);
            txtPassBorder.Dock = DockStyle.Fill;
            txtPassBorder.Location = new Point(3, 257);
            txtPassBorder.Name = "txtPassBorder";
            txtPassBorder.Padding = new Padding(1);
            txtPassBorder.Size = new Size(324, 59);
            txtPassBorder.TabIndex = 6;
            // 
            // txtPassLayout
            // 
            txtPassLayout.ColumnCount = 2;
            txtPassLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            txtPassLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            txtPassLayout.Controls.Add(lblPassIcon, 0, 0);
            txtPassLayout.Controls.Add(txtPassword, 1, 0);
            txtPassLayout.Dock = DockStyle.Fill;
            txtPassLayout.Location = new Point(1, 1);
            txtPassLayout.Name = "txtPassLayout";
            txtPassLayout.RowCount = 1;
            txtPassLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            txtPassLayout.Size = new Size(320, 55);
            txtPassLayout.TabIndex = 0;
            // 
            // lblPassIcon
            // 
            lblPassIcon.Dock = DockStyle.Fill;
            lblPassIcon.Font = new Font("Segoe UI", 14F);
            lblPassIcon.ForeColor = Color.FromArgb(16, 185, 129);
            lblPassIcon.Location = new Point(278, 0);
            lblPassIcon.Name = "lblPassIcon";
            lblPassIcon.Size = new Size(39, 55);
            lblPassIcon.TabIndex = 0;
            lblPassIcon.Text = "🔒";
            lblPassIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.ForeColor = Color.FromArgb(30, 41, 59);
            txtPassword.Location = new Point(3, 15);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(16, 185, 129);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(3, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(324, 165);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "دخول النظام";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // windowControlsFlowPanel
            // 
            windowControlsFlowPanel.BackColor = Color.Transparent;
            windowControlsFlowPanel.Controls.Add(btnClose);
            windowControlsFlowPanel.Controls.Add(btnMinimize);
            windowControlsFlowPanel.Location = new Point(900, 0);
            windowControlsFlowPanel.Name = "windowControlsFlowPanel";
            windowControlsFlowPanel.Size = new Size(100, 45);
            windowControlsFlowPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(51, 65, 85);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(239, 68, 68);
            btnClose.Location = new Point(65, 3);
            btnClose.Margin = new Padding(0, 3, 3, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(51, 65, 85);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(27, 3);
            btnMinimize.Margin = new Padding(0, 3, 3, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1000, 650);
            Controls.Add(mainContainerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            mainContainerPanel.ResumeLayout(false);
            mainLayoutGrid.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            brandPanel.PerformLayout();
            loginCardPanel.ResumeLayout(false);
            loginCardContentLayout.ResumeLayout(false);
            iconContainer.ResumeLayout(false);
            txtUserBorder.ResumeLayout(false);
            txtUserLayout.ResumeLayout(false);
            txtUserLayout.PerformLayout();
            txtPassBorder.ResumeLayout(false);
            txtPassLayout.ResumeLayout(false);
            txtPassLayout.PerformLayout();
            windowControlsFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.Panel mainContainerPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayoutGrid;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel lineDecorator;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel loginCardPanel;
        private System.Windows.Forms.TableLayoutPanel loginCardContentLayout;
        private System.Windows.Forms.Panel iconContainer;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Label lblLoginSubHeader;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Panel txtUserBorder;
        private System.Windows.Forms.TableLayoutPanel txtUserLayout;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Panel txtPassBorder;
        private System.Windows.Forms.TableLayoutPanel txtPassLayout;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.FlowLayoutPanel windowControlsFlowPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
    }
}