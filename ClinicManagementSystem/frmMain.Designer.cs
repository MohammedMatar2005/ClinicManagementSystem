using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;

namespace ClinicManagementSystem
{
    partial class frmMain : Form
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
            components = new System.ComponentModel.Container();
            mainLayoutGrid = new TableLayoutPanel();
            sidebarPanel = new TableLayoutPanel();
            logoContainer = new TableLayoutPanel();
            windowControlsFlow = new FlowLayoutPanel();
            btnClose = new Button();
            btnMinimize = new Button();
            appBrandingLayout = new TableLayoutPanel();
            lblAppName = new Label();
            lblAppSubtitle = new Label();
            panelLogoIcon = new Panel();
            lblLogoIcon = new Label();
            menuScrollViewer = new Panel();
            menuStackPanel = new FlowLayoutPanel();
            lblMainMenuHeader = new Label();
            btnHome = new Button();
            btnPatients = new Button();
            btnAppointments = new Button();
            btnDoctors = new Button();
            btnPharmacy = new Button();
            btnBilling = new Button();
            btnPayment = new Button();
            menuSeparator = new Panel();
            lblAdminHeader = new Label();
            btnSettings = new Button();
            btnSupport = new Button();
            userProfileCard = new TableLayoutPanel();
            btnProfileMenu = new Button();
            cmsOptions = new ContextMenuStrip(components);
            toolStripShowInfo = new ToolStripMenuItem();
            toolStripChangePassword = new ToolStripMenuItem();
            toolStripLogout = new ToolStripMenuItem();
            userProfileTextLayout = new TableLayoutPanel();
            lblUserName = new Label();
            lblUserRole = new Label();
            avatarContainer = new Panel();
            panelOnlineStatus = new Panel();
            contentAreaGrid = new TableLayoutPanel();
            topHeaderSpacer = new Panel();
            pagesContainer = new TableLayoutPanel();
            welcomeHeaderStack = new FlowLayoutPanel();
            lblWelcomeTitle = new Label();
            lblWelcomeSubtitle = new Label();
            tlpBrandingCentering = new TableLayoutPanel();
            lblBrandingIcon = new Label();
            lblBrandingTitle = new Label();
            lblBrandingSubtitle = new Label();
            tlpContentSplitter = new TableLayoutPanel();
            dashboardCardsUniformGrid = new TableLayoutPanel();
            cardPatientsToday = new Panel();
            cardPatientsStack = new FlowLayoutPanel();
            iconWrapperPatients = new Panel();
            lblIconPatients = new Label();
            lblTitlePatients = new Label();
            lblValuePatients = new Label();
            cardAppointments = new Panel();
            cardAppointmentsStack = new FlowLayoutPanel();
            iconWrapperAppointments = new Panel();
            lblIconAppointments = new Label();
            lblTitleAppointments = new Label();
            lblValueAppointments = new Label();
            cardRevenue = new Panel();
            cardRevenueStack = new FlowLayoutPanel();
            iconWrapperRevenue = new Panel();
            lblIconRevenue = new Label();
            lblTitleRevenue = new Label();
            lblValueRevenue = new Label();
            mainLayoutGrid.SuspendLayout();
            sidebarPanel.SuspendLayout();
            logoContainer.SuspendLayout();
            windowControlsFlow.SuspendLayout();
            appBrandingLayout.SuspendLayout();
            panelLogoIcon.SuspendLayout();
            menuScrollViewer.SuspendLayout();
            menuStackPanel.SuspendLayout();
            userProfileCard.SuspendLayout();
            cmsOptions.SuspendLayout();
            userProfileTextLayout.SuspendLayout();
            avatarContainer.SuspendLayout();
            contentAreaGrid.SuspendLayout();
            pagesContainer.SuspendLayout();
            welcomeHeaderStack.SuspendLayout();
            tlpBrandingCentering.SuspendLayout();
            dashboardCardsUniformGrid.SuspendLayout();
            cardPatientsToday.SuspendLayout();
            cardPatientsStack.SuspendLayout();
            iconWrapperPatients.SuspendLayout();
            cardAppointments.SuspendLayout();
            cardAppointmentsStack.SuspendLayout();
            iconWrapperAppointments.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardRevenueStack.SuspendLayout();
            iconWrapperRevenue.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutGrid
            // 
            mainLayoutGrid.ColumnCount = 2;
            mainLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            mainLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutGrid.Controls.Add(sidebarPanel, 0, 0);
            mainLayoutGrid.Controls.Add(contentAreaGrid, 1, 0);
            mainLayoutGrid.Dock = DockStyle.Fill;
            mainLayoutGrid.Location = new Point(0, 0);
            mainLayoutGrid.Margin = new Padding(0);
            mainLayoutGrid.Name = "mainLayoutGrid";
            mainLayoutGrid.RowCount = 1;
            mainLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutGrid.Size = new Size(1300, 788);
            mainLayoutGrid.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(26, 38, 53);
            sidebarPanel.ColumnCount = 1;
            sidebarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidebarPanel.Controls.Add(logoContainer, 0, 0);
            sidebarPanel.Controls.Add(menuScrollViewer, 0, 1);
            sidebarPanel.Controls.Add(userProfileCard, 0, 2);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(1065, 0);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.RowCount = 3;
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            sidebarPanel.Size = new Size(235, 788);
            sidebarPanel.TabIndex = 0;
            // 
            // logoContainer
            // 
            logoContainer.ColumnCount = 1;
            logoContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            logoContainer.Controls.Add(windowControlsFlow, 0, 0);
            logoContainer.Controls.Add(appBrandingLayout, 0, 1);
            logoContainer.Dock = DockStyle.Fill;
            logoContainer.Location = new Point(0, 0);
            logoContainer.Margin = new Padding(0);
            logoContainer.Name = "logoContainer";
            logoContainer.Padding = new Padding(15, 15, 15, 10);
            logoContainer.RowCount = 2;
            logoContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            logoContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            logoContainer.Size = new Size(235, 120);
            logoContainer.TabIndex = 0;
            // 
            // windowControlsFlow
            // 
            windowControlsFlow.Controls.Add(btnClose);
            windowControlsFlow.Controls.Add(btnMinimize);
            windowControlsFlow.Dock = DockStyle.Fill;
            windowControlsFlow.Location = new Point(15, 15);
            windowControlsFlow.Margin = new Padding(0);
            windowControlsFlow.Name = "windowControlsFlow";
            windowControlsFlow.Size = new Size(205, 25);
            windowControlsFlow.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 95, 86);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(74, 0, 0);
            btnClose.Location = new Point(187, 0);
            btnClose.Margin = new Padding(4, 0, 4, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(14, 14);
            btnClose.TabIndex = 0;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(255, 189, 46);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.FromArgb(90, 62, 0);
            btnMinimize.Location = new Point(165, 0);
            btnMinimize.Margin = new Padding(4, 0, 4, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(14, 14);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // appBrandingLayout
            // 
            appBrandingLayout.ColumnCount = 2;
            appBrandingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            appBrandingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            appBrandingLayout.Controls.Add(lblAppName, 0, 0);
            appBrandingLayout.Controls.Add(lblAppSubtitle, 0, 1);
            appBrandingLayout.Controls.Add(panelLogoIcon, 1, 0);
            appBrandingLayout.Dock = DockStyle.Fill;
            appBrandingLayout.Location = new Point(15, 40);
            appBrandingLayout.Margin = new Padding(0);
            appBrandingLayout.Name = "appBrandingLayout";
            appBrandingLayout.RowCount = 2;
            appBrandingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            appBrandingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            appBrandingLayout.Size = new Size(205, 70);
            appBrandingLayout.TabIndex = 1;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Fill;
            lblAppName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(55, 0);
            lblAppName.Margin = new Padding(0, 0, 10, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(150, 38);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "عيادتي الذكية";
            lblAppName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.Dock = DockStyle.Fill;
            lblAppSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblAppSubtitle.ForeColor = Color.FromArgb(93, 122, 149);
            lblAppSubtitle.Location = new Point(55, 38);
            lblAppSubtitle.Margin = new Padding(0, 0, 10, 0);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(150, 32);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "نظام إدارة العيادات";
            lblAppSubtitle.TextAlign = ContentAlignment.TopRight;
            // 
            // panelLogoIcon
            // 
            panelLogoIcon.BackColor = Color.FromArgb(52, 152, 219);
            panelLogoIcon.Controls.Add(lblLogoIcon);
            panelLogoIcon.Dock = DockStyle.Fill;
            panelLogoIcon.Location = new Point(0, 0);
            panelLogoIcon.Margin = new Padding(0);
            panelLogoIcon.Name = "panelLogoIcon";
            appBrandingLayout.SetRowSpan(panelLogoIcon, 2);
            panelLogoIcon.Size = new Size(45, 70);
            panelLogoIcon.TabIndex = 2;
            // 
            // lblLogoIcon
            // 
            lblLogoIcon.Dock = DockStyle.Fill;
            lblLogoIcon.Font = new Font("Segoe UI", 16F);
            lblLogoIcon.ForeColor = Color.White;
            lblLogoIcon.Location = new Point(0, 0);
            lblLogoIcon.Name = "lblLogoIcon";
            lblLogoIcon.Size = new Size(45, 70);
            lblLogoIcon.TabIndex = 0;
            lblLogoIcon.Text = "🌙";
            lblLogoIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuScrollViewer
            // 
            menuScrollViewer.AutoScroll = true;
            menuScrollViewer.Controls.Add(menuStackPanel);
            menuScrollViewer.Dock = DockStyle.Fill;
            menuScrollViewer.Location = new Point(0, 120);
            menuScrollViewer.Margin = new Padding(0);
            menuScrollViewer.Name = "menuScrollViewer";
            menuScrollViewer.Size = new Size(235, 583);
            menuScrollViewer.TabIndex = 1;
            // 
            // menuStackPanel
            // 
            menuStackPanel.Controls.Add(lblMainMenuHeader);
            menuStackPanel.Controls.Add(btnHome);
            menuStackPanel.Controls.Add(btnPatients);
            menuStackPanel.Controls.Add(btnAppointments);
            menuStackPanel.Controls.Add(btnDoctors);
            menuStackPanel.Controls.Add(btnPharmacy);
            menuStackPanel.Controls.Add(btnBilling);
            menuStackPanel.Controls.Add(btnPayment);
            menuStackPanel.Controls.Add(menuSeparator);
            menuStackPanel.Controls.Add(lblAdminHeader);
            menuStackPanel.Controls.Add(btnSettings);
            menuStackPanel.Controls.Add(btnSupport);
            menuStackPanel.Dock = DockStyle.Top;
            menuStackPanel.FlowDirection = FlowDirection.TopDown;
            menuStackPanel.Location = new Point(0, 0);
            menuStackPanel.Margin = new Padding(0);
            menuStackPanel.Name = "menuStackPanel";
            menuStackPanel.Padding = new Padding(0, 12, 0, 0);
            menuStackPanel.Size = new Size(218, 600);
            menuStackPanel.TabIndex = 0;
            menuStackPanel.WrapContents = false;
            // 
            // lblMainMenuHeader
            // 
            lblMainMenuHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMainMenuHeader.ForeColor = Color.FromArgb(61, 90, 114);
            lblMainMenuHeader.Location = new Point(7, 18);
            lblMainMenuHeader.Margin = new Padding(0, 6, 24, 8);
            lblMainMenuHeader.Name = "lblMainMenuHeader";
            lblMainMenuHeader.Size = new Size(211, 20);
            lblMainMenuHeader.TabIndex = 0;
            lblMainMenuHeader.Text = "القائمة الرئيسية";
            lblMainMenuHeader.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(52, 152, 219);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(-7, 49);
            btnHome.Margin = new Padding(10, 3, 10, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(215, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "الرئيسية           🏠";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.Transparent;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Segoe UI", 10F);
            btnPatients.ForeColor = Color.FromArgb(189, 195, 199);
            btnPatients.Location = new Point(-7, 95);
            btnPatients.Margin = new Padding(10, 3, 10, 3);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(215, 40);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "المرضى           👥";
            btnPatients.TextAlign = ContentAlignment.MiddleRight;
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.Transparent;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Segoe UI", 10F);
            btnAppointments.ForeColor = Color.FromArgb(189, 195, 199);
            btnAppointments.Location = new Point(-7, 141);
            btnAppointments.Margin = new Padding(10, 3, 10, 3);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(215, 40);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "المواعيد           📅";
            btnAppointments.TextAlign = ContentAlignment.MiddleRight;
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.Transparent;
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.Font = new Font("Segoe UI", 10F);
            btnDoctors.ForeColor = Color.FromArgb(189, 195, 199);
            btnDoctors.Location = new Point(-7, 187);
            btnDoctors.Margin = new Padding(10, 3, 10, 3);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(215, 40);
            btnDoctors.TabIndex = 4;
            btnDoctors.Text = "الأطباء           \U0001fa7a";
            btnDoctors.TextAlign = ContentAlignment.MiddleRight;
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnPharmacy
            // 
            btnPharmacy.BackColor = Color.Transparent;
            btnPharmacy.FlatAppearance.BorderSize = 0;
            btnPharmacy.FlatStyle = FlatStyle.Flat;
            btnPharmacy.Font = new Font("Segoe UI", 10F);
            btnPharmacy.ForeColor = Color.FromArgb(189, 195, 199);
            btnPharmacy.Location = new Point(-7, 233);
            btnPharmacy.Margin = new Padding(10, 3, 10, 3);
            btnPharmacy.Name = "btnPharmacy";
            btnPharmacy.Size = new Size(215, 40);
            btnPharmacy.TabIndex = 5;
            btnPharmacy.Text = "الصيدلية           💊";
            btnPharmacy.TextAlign = ContentAlignment.MiddleRight;
            btnPharmacy.UseVisualStyleBackColor = false;
            btnPharmacy.Click += btnPharmacy_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.Transparent;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 10F);
            btnBilling.ForeColor = Color.FromArgb(189, 195, 199);
            btnBilling.Location = new Point(-7, 279);
            btnBilling.Margin = new Padding(10, 3, 10, 3);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(215, 40);
            btnBilling.TabIndex = 6;
            btnBilling.Text = "الفواتير       💳";
            btnBilling.TextAlign = ContentAlignment.MiddleRight;
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Transparent;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 10F);
            btnPayment.ForeColor = Color.FromArgb(189, 195, 199);
            btnPayment.Location = new Point(-7, 325);
            btnPayment.Margin = new Padding(10, 3, 10, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(215, 40);
            btnPayment.TabIndex = 7;
            btnPayment.Text = "المدفوعات والمعاملات 💳";
            btnPayment.TextAlign = ContentAlignment.MiddleRight;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayments_Click;
            // 
            // menuSeparator
            // 
            menuSeparator.BackColor = Color.FromArgb(38, 54, 71);
            menuSeparator.Location = new Point(3, 382);
            menuSeparator.Margin = new Padding(20, 14, 20, 14);
            menuSeparator.Name = "menuSeparator";
            menuSeparator.Size = new Size(195, 1);
            menuSeparator.TabIndex = 8;
            // 
            // lblAdminHeader
            // 
            lblAdminHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdminHeader.ForeColor = Color.FromArgb(61, 90, 114);
            lblAdminHeader.Location = new Point(7, 397);
            lblAdminHeader.Margin = new Padding(0, 0, 24, 8);
            lblAdminHeader.Name = "lblAdminHeader";
            lblAdminHeader.Size = new Size(211, 20);
            lblAdminHeader.TabIndex = 9;
            lblAdminHeader.Text = "الإدارة والنظام";
            lblAdminHeader.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.FromArgb(189, 195, 199);
            btnSettings.Location = new Point(-7, 428);
            btnSettings.Margin = new Padding(10, 3, 10, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(215, 40);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "الإعدادات           ⚙️";
            btnSettings.TextAlign = ContentAlignment.MiddleRight;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSupport
            // 
            btnSupport.BackColor = Color.Transparent;
            btnSupport.FlatAppearance.BorderSize = 0;
            btnSupport.FlatStyle = FlatStyle.Flat;
            btnSupport.Font = new Font("Segoe UI", 10F);
            btnSupport.ForeColor = Color.FromArgb(189, 195, 199);
            btnSupport.Location = new Point(-7, 474);
            btnSupport.Margin = new Padding(10, 3, 10, 3);
            btnSupport.Name = "btnSupport";
            btnSupport.Size = new Size(215, 40);
            btnSupport.TabIndex = 13;
            btnSupport.Text = "الدعم الفني          ❓";
            btnSupport.TextAlign = ContentAlignment.MiddleRight;
            btnSupport.UseVisualStyleBackColor = false;
            btnSupport.Click += btnSupport_Click;
            // 
            // userProfileCard
            // 
            userProfileCard.BackColor = Color.FromArgb(44, 62, 80);
            userProfileCard.ColumnCount = 3;
            userProfileCard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            userProfileCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            userProfileCard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            userProfileCard.Controls.Add(btnProfileMenu, 0, 0);
            userProfileCard.Controls.Add(userProfileTextLayout, 1, 0);
            userProfileCard.Controls.Add(avatarContainer, 2, 0);
            userProfileCard.Dock = DockStyle.Fill;
            userProfileCard.Location = new Point(15, 713);
            userProfileCard.Margin = new Padding(15, 10, 15, 10);
            userProfileCard.Name = "userProfileCard";
            userProfileCard.RowCount = 1;
            userProfileCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            userProfileCard.Size = new Size(205, 65);
            userProfileCard.TabIndex = 2;
            // 
            // btnProfileMenu
            // 
            btnProfileMenu.BackColor = Color.Transparent;
            btnProfileMenu.ContextMenuStrip = cmsOptions;
            btnProfileMenu.Dock = DockStyle.Fill;
            btnProfileMenu.FlatAppearance.BorderSize = 0;
            btnProfileMenu.FlatStyle = FlatStyle.Flat;
            btnProfileMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProfileMenu.ForeColor = Color.FromArgb(149, 165, 166);
            btnProfileMenu.Location = new Point(170, 0);
            btnProfileMenu.Margin = new Padding(0);
            btnProfileMenu.Name = "btnProfileMenu";
            btnProfileMenu.Size = new Size(35, 65);
            btnProfileMenu.TabIndex = 0;
            btnProfileMenu.Text = "⋮";
            btnProfileMenu.UseVisualStyleBackColor = false;
            btnProfileMenu.Click += btnProfileMenu_Click;
            // 
            // cmsOptions
            // 
            cmsOptions.Items.AddRange(new ToolStripItem[] { toolStripShowInfo, toolStripChangePassword, toolStripLogout });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RightToLeft = RightToLeft.Yes;
            cmsOptions.Size = new Size(157, 70);
            // 
            // toolStripShowInfo
            // 
            toolStripShowInfo.Name = "toolStripShowInfo";
            toolStripShowInfo.Size = new Size(156, 22);
            toolStripShowInfo.Text = "عرض البيانات";
            toolStripShowInfo.Click += toolStripShowInfo_Click;
            // 
            // toolStripChangePassword
            // 
            toolStripChangePassword.Name = "toolStripChangePassword";
            toolStripChangePassword.Size = new Size(156, 22);
            toolStripChangePassword.Text = "تغيير كلمة المرور";
            // 
            // toolStripLogout
            // 
            toolStripLogout.Name = "toolStripLogout";
            toolStripLogout.Size = new Size(156, 22);
            toolStripLogout.Text = "تسجيل الخروج";
            toolStripLogout.Click += toolStripLogout_Click;
            // 
            // userProfileTextLayout
            // 
            userProfileTextLayout.ColumnCount = 1;
            userProfileTextLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            userProfileTextLayout.Controls.Add(lblUserName, 0, 0);
            userProfileTextLayout.Controls.Add(lblUserRole, 0, 1);
            userProfileTextLayout.Dock = DockStyle.Fill;
            userProfileTextLayout.Location = new Point(55, 0);
            userProfileTextLayout.Margin = new Padding(0);
            userProfileTextLayout.Name = "userProfileTextLayout";
            userProfileTextLayout.RowCount = 2;
            userProfileTextLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            userProfileTextLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            userProfileTextLayout.Size = new Size(115, 65);
            userProfileTextLayout.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(3, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(109, 32);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "د. محمد علي";
            lblUserName.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblUserRole
            // 
            lblUserRole.Dock = DockStyle.Fill;
            lblUserRole.Font = new Font("Segoe UI", 8.5F);
            lblUserRole.ForeColor = Color.FromArgb(189, 195, 199);
            lblUserRole.Location = new Point(3, 32);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(109, 33);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "مستخدم النظام";
            lblUserRole.TextAlign = ContentAlignment.TopRight;
            // 
            // avatarContainer
            // 
            avatarContainer.BackgroundImageLayout = ImageLayout.Stretch;
            avatarContainer.Controls.Add(panelOnlineStatus);
            avatarContainer.Dock = DockStyle.Fill;
            avatarContainer.Location = new Point(10, 10);
            avatarContainer.Margin = new Padding(3, 10, 10, 10);
            avatarContainer.Name = "avatarContainer";
            avatarContainer.Size = new Size(42, 45);
            avatarContainer.TabIndex = 2;
            // 
            // panelOnlineStatus
            // 
            panelOnlineStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelOnlineStatus.BackColor = Color.FromArgb(46, 204, 113);
            panelOnlineStatus.Location = new Point(0, 33);
            panelOnlineStatus.Name = "panelOnlineStatus";
            panelOnlineStatus.Size = new Size(12, 12);
            panelOnlineStatus.TabIndex = 0;
            // 
            // contentAreaGrid
            // 
            contentAreaGrid.BackColor = Color.White;
            contentAreaGrid.ColumnCount = 1;
            contentAreaGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentAreaGrid.Controls.Add(topHeaderSpacer, 0, 0);
            contentAreaGrid.Controls.Add(pagesContainer, 0, 1);
            contentAreaGrid.Dock = DockStyle.Fill;
            contentAreaGrid.Location = new Point(0, 0);
            contentAreaGrid.Margin = new Padding(0);
            contentAreaGrid.Name = "contentAreaGrid";
            contentAreaGrid.RowCount = 2;
            contentAreaGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            contentAreaGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentAreaGrid.Size = new Size(1065, 788);
            contentAreaGrid.TabIndex = 1;
            // 
            // topHeaderSpacer
            // 
            topHeaderSpacer.BackColor = Color.FromArgb(61, 90, 114);
            topHeaderSpacer.Dock = DockStyle.Fill;
            topHeaderSpacer.Location = new Point(0, 0);
            topHeaderSpacer.Margin = new Padding(0);
            topHeaderSpacer.Name = "topHeaderSpacer";
            topHeaderSpacer.Size = new Size(1065, 68);
            topHeaderSpacer.TabIndex = 0;
            // 
            // pagesContainer
            // 
            pagesContainer.ColumnCount = 1;
            pagesContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pagesContainer.Controls.Add(welcomeHeaderStack, 0, 0);
            pagesContainer.Controls.Add(tlpBrandingCentering, 0, 1);
            pagesContainer.Dock = DockStyle.Fill;
            pagesContainer.Location = new Point(25, 93);
            pagesContainer.Margin = new Padding(25);
            pagesContainer.Name = "pagesContainer";
            pagesContainer.RowCount = 2;
            pagesContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            pagesContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagesContainer.Size = new Size(1015, 670);
            pagesContainer.TabIndex = 1;
            // 
            // welcomeHeaderStack
            // 
            welcomeHeaderStack.Controls.Add(lblWelcomeTitle);
            welcomeHeaderStack.Controls.Add(lblWelcomeSubtitle);
            welcomeHeaderStack.Dock = DockStyle.Fill;
            welcomeHeaderStack.FlowDirection = FlowDirection.TopDown;
            welcomeHeaderStack.Location = new Point(0, 0);
            welcomeHeaderStack.Margin = new Padding(0, 0, 0, 30);
            welcomeHeaderStack.Name = "welcomeHeaderStack";
            welcomeHeaderStack.Size = new Size(1015, 60);
            welcomeHeaderStack.TabIndex = 0;
            welcomeHeaderStack.WrapContents = false;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.DarkSlateGray;
            lblWelcomeTitle.Location = new Point(587, 0);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(425, 37);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "أهلاً بك دكتور محمد، طاب يومك! 👋";
            lblWelcomeTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWelcomeSubtitle
            // 
            lblWelcomeSubtitle.AutoSize = true;
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 10F);
            lblWelcomeSubtitle.ForeColor = Color.FromArgb(127, 140, 141);
            lblWelcomeSubtitle.Location = new Point(759, 42);
            lblWelcomeSubtitle.Margin = new Padding(0, 5, 0, 0);
            lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            lblWelcomeSubtitle.Size = new Size(256, 19);
            lblWelcomeSubtitle.TabIndex = 1;
            lblWelcomeSubtitle.Text = "إليك نظرة سريعة على نشاط العيادة اليوم.";
            lblWelcomeSubtitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpBrandingCentering
            // 
            tlpBrandingCentering.BackColor = Color.White;
            tlpBrandingCentering.ColumnCount = 1;
            tlpBrandingCentering.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBrandingCentering.Controls.Add(lblBrandingIcon, 0, 0);
            tlpBrandingCentering.Controls.Add(lblBrandingTitle, 0, 1);
            tlpBrandingCentering.Controls.Add(lblBrandingSubtitle, 0, 2);
            tlpBrandingCentering.Dock = DockStyle.Fill;
            tlpBrandingCentering.Location = new Point(100, 120);
            tlpBrandingCentering.Margin = new Padding(100, 30, 100, 100);
            tlpBrandingCentering.Name = "tlpBrandingCentering";
            tlpBrandingCentering.RowCount = 3;
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpBrandingCentering.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpBrandingCentering.Size = new Size(815, 450);
            tlpBrandingCentering.TabIndex = 1;
            // 
            // lblBrandingIcon
            // 
            lblBrandingIcon.Dock = DockStyle.Fill;
            lblBrandingIcon.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBrandingIcon.ForeColor = Color.FromArgb(46, 117, 89);
            lblBrandingIcon.Location = new Point(3, 0);
            lblBrandingIcon.Name = "lblBrandingIcon";
            lblBrandingIcon.Size = new Size(809, 180);
            lblBrandingIcon.TabIndex = 0;
            lblBrandingIcon.Text = "⚕️ مِـنَـصَّـةُ شِـفَـاءْ الـرَّقْـمِـيَّـة";
            lblBrandingIcon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblBrandingTitle
            // 
            lblBrandingTitle.Dock = DockStyle.Fill;
            lblBrandingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandingTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblBrandingTitle.Location = new Point(3, 180);
            lblBrandingTitle.Name = "lblBrandingTitle";
            lblBrandingTitle.Size = new Size(809, 112);
            lblBrandingTitle.TabIndex = 1;
            lblBrandingTitle.Text = "نظام إدارة عيادتك الطبية المطور";
            lblBrandingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandingSubtitle
            // 
            lblBrandingSubtitle.Dock = DockStyle.Fill;
            lblBrandingSubtitle.Font = new Font("Segoe UI", 12F);
            lblBrandingSubtitle.ForeColor = Color.Gray;
            lblBrandingSubtitle.Location = new Point(3, 292);
            lblBrandingSubtitle.Name = "lblBrandingSubtitle";
            lblBrandingSubtitle.Size = new Size(809, 158);
            lblBrandingSubtitle.TabIndex = 2;
            lblBrandingSubtitle.Text = "نظام متكامل مصمم لإدارة المواعيد بدقة، وتنظيم سجلات المرضى الحالية، ومتابعة جميع المدفوعات والحسابات اليومية للعيادة بكل سهولة وأمان.";
            lblBrandingSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // tlpContentSplitter
            // 
            tlpContentSplitter.ColumnCount = 1;
            tlpContentSplitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContentSplitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContentSplitter.Dock = DockStyle.Fill;
            tlpContentSplitter.Location = new Point(0, 90);
            tlpContentSplitter.Margin = new Padding(0);
            tlpContentSplitter.Name = "tlpContentSplitter";
            tlpContentSplitter.RowCount = 1;
            tlpContentSplitter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContentSplitter.Size = new Size(1015, 580);
            tlpContentSplitter.TabIndex = 2;
            // 
            // dashboardCardsUniformGrid
            // 
            dashboardCardsUniformGrid.ColumnCount = 3;
            dashboardCardsUniformGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            dashboardCardsUniformGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            dashboardCardsUniformGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            dashboardCardsUniformGrid.Controls.Add(cardPatientsToday, 2, 0);
            dashboardCardsUniformGrid.Controls.Add(cardAppointments, 1, 0);
            dashboardCardsUniformGrid.Controls.Add(cardRevenue, 0, 0);
            dashboardCardsUniformGrid.Dock = DockStyle.Top;
            dashboardCardsUniformGrid.Location = new Point(0, 90);
            dashboardCardsUniformGrid.Margin = new Padding(0);
            dashboardCardsUniformGrid.Name = "dashboardCardsUniformGrid";
            dashboardCardsUniformGrid.RowCount = 1;
            dashboardCardsUniformGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            dashboardCardsUniformGrid.Size = new Size(1015, 180);
            dashboardCardsUniformGrid.TabIndex = 1;
            // 
            // cardPatientsToday
            // 
            cardPatientsToday.BackColor = Color.White;
            cardPatientsToday.Controls.Add(cardPatientsStack);
            cardPatientsToday.Dock = DockStyle.Fill;
            cardPatientsToday.Location = new Point(686, 10);
            cardPatientsToday.Margin = new Padding(10);
            cardPatientsToday.Name = "cardPatientsToday";
            cardPatientsToday.Padding = new Padding(20);
            cardPatientsToday.Size = new Size(319, 160);
            cardPatientsToday.TabIndex = 0;
            // 
            // cardPatientsStack
            // 
            cardPatientsStack.Controls.Add(iconWrapperPatients);
            cardPatientsStack.Controls.Add(lblTitlePatients);
            cardPatientsStack.Controls.Add(lblValuePatients);
            cardPatientsStack.Dock = DockStyle.Fill;
            cardPatientsStack.FlowDirection = FlowDirection.TopDown;
            cardPatientsStack.Location = new Point(20, 20);
            cardPatientsStack.Margin = new Padding(0);
            cardPatientsStack.Name = "cardPatientsStack";
            cardPatientsStack.Size = new Size(279, 120);
            cardPatientsStack.TabIndex = 0;
            cardPatientsStack.WrapContents = false;
            // 
            // iconWrapperPatients
            // 
            iconWrapperPatients.BackColor = Color.FromArgb(227, 242, 253);
            iconWrapperPatients.Controls.Add(lblIconPatients);
            iconWrapperPatients.Location = new Point(0, 0);
            iconWrapperPatients.Margin = new Padding(0);
            iconWrapperPatients.Name = "iconWrapperPatients";
            iconWrapperPatients.Size = new Size(45, 45);
            iconWrapperPatients.TabIndex = 0;
            // 
            // lblIconPatients
            // 
            lblIconPatients.Dock = DockStyle.Fill;
            lblIconPatients.Font = new Font("Segoe UI", 16F);
            lblIconPatients.Location = new Point(0, 0);
            lblIconPatients.Name = "lblIconPatients";
            lblIconPatients.Size = new Size(45, 45);
            lblIconPatients.TabIndex = 0;
            lblIconPatients.Text = "👥";
            lblIconPatients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitlePatients
            // 
            lblTitlePatients.Font = new Font("Segoe UI", 10F);
            lblTitlePatients.ForeColor = Color.FromArgb(127, 140, 141);
            lblTitlePatients.Location = new Point(0, 60);
            lblTitlePatients.Margin = new Padding(0, 15, 0, 5);
            lblTitlePatients.Name = "lblTitlePatients";
            lblTitlePatients.Size = new Size(279, 20);
            lblTitlePatients.TabIndex = 1;
            lblTitlePatients.Text = "مرضى اليوم";
            lblTitlePatients.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValuePatients
            // 
            lblValuePatients.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValuePatients.ForeColor = Color.Black;
            lblValuePatients.Location = new Point(0, 85);
            lblValuePatients.Margin = new Padding(0);
            lblValuePatients.Name = "lblValuePatients";
            lblValuePatients.Size = new Size(279, 35);
            lblValuePatients.TabIndex = 2;
            lblValuePatients.Text = "24 مريض";
            lblValuePatients.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cardAppointments
            // 
            cardAppointments.BackColor = Color.White;
            cardAppointments.Controls.Add(cardAppointmentsStack);
            cardAppointments.Dock = DockStyle.Fill;
            cardAppointments.Location = new Point(348, 10);
            cardAppointments.Margin = new Padding(10);
            cardAppointments.Name = "cardAppointments";
            cardAppointments.Padding = new Padding(20);
            cardAppointments.Size = new Size(318, 160);
            cardAppointments.TabIndex = 1;
            // 
            // cardAppointmentsStack
            // 
            cardAppointmentsStack.Controls.Add(iconWrapperAppointments);
            cardAppointmentsStack.Controls.Add(lblTitleAppointments);
            cardAppointmentsStack.Controls.Add(lblValueAppointments);
            cardAppointmentsStack.Dock = DockStyle.Fill;
            cardAppointmentsStack.FlowDirection = FlowDirection.TopDown;
            cardAppointmentsStack.Location = new Point(20, 20);
            cardAppointmentsStack.Margin = new Padding(0);
            cardAppointmentsStack.Name = "cardAppointmentsStack";
            cardAppointmentsStack.Size = new Size(278, 120);
            cardAppointmentsStack.TabIndex = 0;
            cardAppointmentsStack.WrapContents = false;
            // 
            // iconWrapperAppointments
            // 
            iconWrapperAppointments.BackColor = Color.FromArgb(241, 248, 233);
            iconWrapperAppointments.Controls.Add(lblIconAppointments);
            iconWrapperAppointments.Location = new Point(0, 0);
            iconWrapperAppointments.Margin = new Padding(0);
            iconWrapperAppointments.Name = "iconWrapperAppointments";
            iconWrapperAppointments.Size = new Size(45, 45);
            iconWrapperAppointments.TabIndex = 0;
            // 
            // lblIconAppointments
            // 
            lblIconAppointments.Dock = DockStyle.Fill;
            lblIconAppointments.Font = new Font("Segoe UI", 16F);
            lblIconAppointments.Location = new Point(0, 0);
            lblIconAppointments.Name = "lblIconAppointments";
            lblIconAppointments.Size = new Size(45, 45);
            lblIconAppointments.TabIndex = 0;
            lblIconAppointments.Text = "📅";
            lblIconAppointments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleAppointments
            // 
            lblTitleAppointments.Font = new Font("Segoe UI", 10F);
            lblTitleAppointments.ForeColor = Color.FromArgb(127, 140, 141);
            lblTitleAppointments.Location = new Point(0, 60);
            lblTitleAppointments.Margin = new Padding(0, 15, 0, 5);
            lblTitleAppointments.Name = "lblTitleAppointments";
            lblTitleAppointments.Size = new Size(278, 20);
            lblTitleAppointments.TabIndex = 1;
            lblTitleAppointments.Text = "المواعيد القادمة";
            lblTitleAppointments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValueAppointments
            // 
            lblValueAppointments.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValueAppointments.ForeColor = Color.Black;
            lblValueAppointments.Location = new Point(0, 85);
            lblValueAppointments.Margin = new Padding(0);
            lblValueAppointments.Name = "lblValueAppointments";
            lblValueAppointments.Size = new Size(278, 35);
            lblValueAppointments.TabIndex = 2;
            lblValueAppointments.Text = "8 مواعيد";
            lblValueAppointments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(cardRevenueStack);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(10, 10);
            cardRevenue.Margin = new Padding(10);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(20);
            cardRevenue.Size = new Size(318, 160);
            cardRevenue.TabIndex = 2;
            // 
            // cardRevenueStack
            // 
            cardRevenueStack.Controls.Add(iconWrapperRevenue);
            cardRevenueStack.Controls.Add(lblTitleRevenue);
            cardRevenueStack.Controls.Add(lblValueRevenue);
            cardRevenueStack.Dock = DockStyle.Fill;
            cardRevenueStack.FlowDirection = FlowDirection.TopDown;
            cardRevenueStack.Location = new Point(20, 20);
            cardRevenueStack.Margin = new Padding(0);
            cardRevenueStack.Name = "cardRevenueStack";
            cardRevenueStack.Size = new Size(278, 120);
            cardRevenueStack.TabIndex = 0;
            cardRevenueStack.WrapContents = false;
            // 
            // iconWrapperRevenue
            // 
            iconWrapperRevenue.BackColor = Color.FromArgb(255, 243, 244);
            iconWrapperRevenue.Controls.Add(lblIconRevenue);
            iconWrapperRevenue.Location = new Point(0, 0);
            iconWrapperRevenue.Margin = new Padding(0);
            iconWrapperRevenue.Name = "iconWrapperRevenue";
            iconWrapperRevenue.Size = new Size(45, 45);
            iconWrapperRevenue.TabIndex = 0;
            // 
            // lblIconRevenue
            // 
            lblIconRevenue.Dock = DockStyle.Fill;
            lblIconRevenue.Font = new Font("Segoe UI", 16F);
            lblIconRevenue.Location = new Point(0, 0);
            lblIconRevenue.Name = "lblIconRevenue";
            lblIconRevenue.Size = new Size(45, 45);
            lblIconRevenue.TabIndex = 0;
            lblIconRevenue.Text = "💰";
            lblIconRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleRevenue
            // 
            lblTitleRevenue.Font = new Font("Segoe UI", 10F);
            lblTitleRevenue.ForeColor = Color.FromArgb(127, 140, 141);
            lblTitleRevenue.Location = new Point(0, 60);
            lblTitleRevenue.Margin = new Padding(0, 15, 0, 5);
            lblTitleRevenue.Name = "lblTitleRevenue";
            lblTitleRevenue.Size = new Size(278, 20);
            lblTitleRevenue.TabIndex = 1;
            lblTitleRevenue.Text = "دخل اليوم";
            lblTitleRevenue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValueRevenue
            // 
            lblValueRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValueRevenue.ForeColor = Color.FromArgb(39, 174, 96);
            lblValueRevenue.Location = new Point(0, 85);
            lblValueRevenue.Margin = new Padding(0);
            lblValueRevenue.Name = "lblValueRevenue";
            lblValueRevenue.Size = new Size(278, 35);
            lblValueRevenue.TabIndex = 2;
            lblValueRevenue.Text = "1,250 $";
            lblValueRevenue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1300, 788);
            Controls.Add(mainLayoutGrid);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 600);
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة العيادة الطبية";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            mainLayoutGrid.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            logoContainer.ResumeLayout(false);
            windowControlsFlow.ResumeLayout(false);
            appBrandingLayout.ResumeLayout(false);
            panelLogoIcon.ResumeLayout(false);
            menuScrollViewer.ResumeLayout(false);
            menuStackPanel.ResumeLayout(false);
            userProfileCard.ResumeLayout(false);
            cmsOptions.ResumeLayout(false);
            userProfileTextLayout.ResumeLayout(false);
            avatarContainer.ResumeLayout(false);
            contentAreaGrid.ResumeLayout(false);
            pagesContainer.ResumeLayout(false);
            welcomeHeaderStack.ResumeLayout(false);
            welcomeHeaderStack.PerformLayout();
            tlpBrandingCentering.ResumeLayout(false);
            dashboardCardsUniformGrid.ResumeLayout(false);
            cardPatientsToday.ResumeLayout(false);
            cardPatientsStack.ResumeLayout(false);
            iconWrapperPatients.ResumeLayout(false);
            cardAppointments.ResumeLayout(false);
            cardAppointmentsStack.ResumeLayout(false);
            iconWrapperAppointments.ResumeLayout(false);
            cardRevenue.ResumeLayout(false);
            cardRevenueStack.ResumeLayout(false);
            iconWrapperRevenue.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutGrid;
        private System.Windows.Forms.TableLayoutPanel sidebarPanel;
        private System.Windows.Forms.TableLayoutPanel logoContainer;
        private System.Windows.Forms.FlowLayoutPanel windowControlsFlow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TableLayoutPanel appBrandingLayout;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelLogoIcon;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Panel menuScrollViewer;
        private System.Windows.Forms.FlowLayoutPanel menuStackPanel;
        private System.Windows.Forms.Label lblMainMenuHeader;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnPharmacy;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel menuSeparator;
        private System.Windows.Forms.Label lblAdminHeader;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.TableLayoutPanel userProfileCard;
        private System.Windows.Forms.Button btnProfileMenu;
        private System.Windows.Forms.TableLayoutPanel userProfileTextLayout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel avatarContainer;
        private System.Windows.Forms.Panel panelOnlineStatus;
        private System.Windows.Forms.TableLayoutPanel contentAreaGrid;
        private System.Windows.Forms.Panel topHeaderSpacer;
        public System.Windows.Forms.TableLayoutPanel pagesContainer;
        private System.Windows.Forms.FlowLayoutPanel welcomeHeaderStack;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.TableLayoutPanel dashboardCardsUniformGrid;
        private System.Windows.Forms.Panel cardPatientsToday;
        private System.Windows.Forms.FlowLayoutPanel cardPatientsStack;
        private System.Windows.Forms.Panel iconWrapperPatients;
        private System.Windows.Forms.Label lblIconPatients;
        private System.Windows.Forms.Label lblTitlePatients;
        private System.Windows.Forms.Label lblValuePatients;
        private System.Windows.Forms.Panel cardAppointments;
        private System.Windows.Forms.FlowLayoutPanel cardAppointmentsStack;
        private System.Windows.Forms.Panel iconWrapperAppointments;
        private System.Windows.Forms.Label lblIconAppointments;
        private System.Windows.Forms.Label lblTitleAppointments;
        private System.Windows.Forms.Label lblValueAppointments;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.FlowLayoutPanel cardRevenueStack;
        private System.Windows.Forms.Panel iconWrapperRevenue;
        private System.Windows.Forms.Label lblIconRevenue;
        private System.Windows.Forms.Label lblTitleRevenue;
        private System.Windows.Forms.Label lblValueRevenue;
        private ContextMenuStrip cmsOptions;
        private ToolStripMenuItem toolStripShowInfo;
        private ToolStripMenuItem toolStripChangePassword;
        private ToolStripMenuItem toolStripLogout;
        private TableLayoutPanel tlpContentSplitter;
        private TableLayoutPanel tlpBrandingCentering;
        private Label lblBrandingIcon;
        private Label lblBrandingTitle;
        private Label lblBrandingSubtitle;
    }
}