namespace ClinicManagementSystem
{
    partial class frmSupport : Form
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupport));
            mainContainerPanel = new TableLayoutPanel();
            pnlCenterCard = new Panel();
            cardContentLayout = new TableLayoutPanel();
            pbProfileImage = new PictureBox();
            lblDeveloperName = new Label();
            lblDeveloperTitle = new Label();
            pnlSeparator = new Panel();
            infoRowsLayout = new TableLayoutPanel();
            pnlPhoneRow = new TableLayoutPanel();
            lblPhoneHeader = new Label();
            txtPhoneValue = new TextBox();
            pnlEmailRow = new TableLayoutPanel();
            lblEmailHeader = new Label();
            txtEmailValue = new TextBox();
            pnlLinkedInRow = new TableLayoutPanel();
            lblLinkedInHeader = new Label();
            txtLinkedInValue = new TextBox();
            pnlSupportNoticeCard = new Panel();
            noticeLayout = new TableLayoutPanel();
            lblNoticeIcon = new Label();
            lblNoticeText = new Label();
            buttonsUniformGrid = new TableLayoutPanel();
            btnSendMessage = new Button();
            btnWhatsApp = new Button();
            mainContainerPanel.SuspendLayout();
            pnlCenterCard.SuspendLayout();
            cardContentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).BeginInit();
            infoRowsLayout.SuspendLayout();
            pnlPhoneRow.SuspendLayout();
            pnlEmailRow.SuspendLayout();
            pnlLinkedInRow.SuspendLayout();
            pnlSupportNoticeCard.SuspendLayout();
            noticeLayout.SuspendLayout();
            buttonsUniformGrid.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.ColumnCount = 3;
            mainContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 550F));
            mainContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainContainerPanel.Controls.Add(pnlCenterCard, 1, 1);
            mainContainerPanel.Dock = DockStyle.Fill;
            mainContainerPanel.Location = new Point(0, 0);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.RowCount = 3;
            mainContainerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainContainerPanel.RowStyles.Add(new RowStyle());
            mainContainerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainContainerPanel.Size = new Size(884, 661);
            mainContainerPanel.TabIndex = 0;
            // 
            // pnlCenterCard
            // 
            pnlCenterCard.BackColor = Color.White;
            pnlCenterCard.Controls.Add(cardContentLayout);
            pnlCenterCard.Dock = DockStyle.Fill;
            pnlCenterCard.Location = new Point(207, 24);
            pnlCenterCard.Margin = new Padding(40);
            pnlCenterCard.Name = "pnlCenterCard";
            pnlCenterCard.Padding = new Padding(30);
            pnlCenterCard.Size = new Size(470, 613);
            pnlCenterCard.TabIndex = 0;
            // 
            // cardContentLayout
            // 
            cardContentLayout.ColumnCount = 1;
            cardContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cardContentLayout.Controls.Add(pbProfileImage, 0, 0);
            cardContentLayout.Controls.Add(lblDeveloperName, 0, 1);
            cardContentLayout.Controls.Add(lblDeveloperTitle, 0, 2);
            cardContentLayout.Controls.Add(pnlSeparator, 0, 3);
            cardContentLayout.Controls.Add(infoRowsLayout, 0, 4);
            cardContentLayout.Controls.Add(pnlSupportNoticeCard, 0, 5);
            cardContentLayout.Controls.Add(buttonsUniformGrid, 0, 6);
            cardContentLayout.Dock = DockStyle.Fill;
            cardContentLayout.Location = new Point(30, 30);
            cardContentLayout.Name = "cardContentLayout";
            cardContentLayout.RowCount = 7;
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            cardContentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardContentLayout.Size = new Size(410, 553);
            cardContentLayout.TabIndex = 0;
            // 
            // pbProfileImage
            // 
            pbProfileImage.Anchor = AnchorStyles.Top;
            pbProfileImage.BackColor = Color.Gainsboro;
            pbProfileImage.Image = (Image)resources.GetObject("pbProfileImage.Image");
            pbProfileImage.ImageLocation = "C:\\Users\\hp15-DW\\Downloads\\MyImage.png";
            pbProfileImage.Location = new Point(150, 0);
            pbProfileImage.Margin = new Padding(0, 0, 0, 15);
            pbProfileImage.Name = "pbProfileImage";
            pbProfileImage.Size = new Size(110, 110);
            pbProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfileImage.TabIndex = 0;
            pbProfileImage.TabStop = false;
            // 
            // lblDeveloperName
            // 
            lblDeveloperName.AutoSize = true;
            lblDeveloperName.Dock = DockStyle.Fill;
            lblDeveloperName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDeveloperName.ForeColor = Color.FromArgb(26, 37, 51);
            lblDeveloperName.Location = new Point(3, 125);
            lblDeveloperName.Name = "lblDeveloperName";
            lblDeveloperName.Size = new Size(404, 35);
            lblDeveloperName.TabIndex = 1;
            lblDeveloperName.Text = "م. محمد مطر";
            lblDeveloperName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDeveloperTitle
            // 
            lblDeveloperTitle.AutoSize = true;
            lblDeveloperTitle.Dock = DockStyle.Fill;
            lblDeveloperTitle.Font = new Font("Segoe UI", 9.5F);
            lblDeveloperTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblDeveloperTitle.Location = new Point(3, 160);
            lblDeveloperTitle.Margin = new Padding(3, 0, 3, 25);
            lblDeveloperTitle.Name = "lblDeveloperTitle";
            lblDeveloperTitle.Size = new Size(404, 25);
            lblDeveloperTitle.TabIndex = 2;
            lblDeveloperTitle.Text = "Software Architect & Backend Developer";
            lblDeveloperTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(236, 240, 241);
            pnlSeparator.Dock = DockStyle.Top;
            pnlSeparator.Location = new Point(20, 210);
            pnlSeparator.Margin = new Padding(20, 0, 20, 20);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(370, 1);
            pnlSeparator.TabIndex = 3;
            // 
            // infoRowsLayout
            // 
            infoRowsLayout.ColumnCount = 1;
            infoRowsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoRowsLayout.Controls.Add(pnlPhoneRow, 0, 0);
            infoRowsLayout.Controls.Add(pnlEmailRow, 0, 1);
            infoRowsLayout.Controls.Add(pnlLinkedInRow, 0, 2);
            infoRowsLayout.Dock = DockStyle.Fill;
            infoRowsLayout.Location = new Point(15, 232);
            infoRowsLayout.Margin = new Padding(15, 0, 15, 0);
            infoRowsLayout.Name = "infoRowsLayout";
            infoRowsLayout.RowCount = 3;
            infoRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            infoRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            infoRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            infoRowsLayout.Size = new Size(380, 120);
            infoRowsLayout.TabIndex = 4;
            // 
            // pnlPhoneRow
            // 
            pnlPhoneRow.ColumnCount = 2;
            pnlPhoneRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlPhoneRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlPhoneRow.Controls.Add(lblPhoneHeader, 0, 0);
            pnlPhoneRow.Controls.Add(txtPhoneValue, 1, 0);
            pnlPhoneRow.Dock = DockStyle.Fill;
            pnlPhoneRow.Location = new Point(0, 4);
            pnlPhoneRow.Margin = new Padding(0, 4, 0, 4);
            pnlPhoneRow.Name = "pnlPhoneRow";
            pnlPhoneRow.RowCount = 1;
            pnlPhoneRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlPhoneRow.Size = new Size(380, 32);
            pnlPhoneRow.TabIndex = 0;
            // 
            // lblPhoneHeader
            // 
            lblPhoneHeader.AutoSize = true;
            lblPhoneHeader.Dock = DockStyle.Fill;
            lblPhoneHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneHeader.ForeColor = Color.FromArgb(93, 122, 149);
            lblPhoneHeader.Location = new Point(263, 0);
            lblPhoneHeader.Name = "lblPhoneHeader";
            lblPhoneHeader.Size = new Size(114, 32);
            lblPhoneHeader.TabIndex = 0;
            lblPhoneHeader.Text = "📞 الهاتف:";
            lblPhoneHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhoneValue
            // 
            txtPhoneValue.BackColor = Color.White;
            txtPhoneValue.BorderStyle = BorderStyle.None;
            txtPhoneValue.Dock = DockStyle.Fill;
            txtPhoneValue.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPhoneValue.ForeColor = Color.FromArgb(44, 62, 80);
            txtPhoneValue.Location = new Point(3, 6);
            txtPhoneValue.Margin = new Padding(3, 6, 3, 3);
            txtPhoneValue.Name = "txtPhoneValue";
            txtPhoneValue.ReadOnly = true;
            txtPhoneValue.Size = new Size(254, 19);
            txtPhoneValue.TabIndex = 1;
            txtPhoneValue.Text = "00972599623752";
            // 
            // pnlEmailRow
            // 
            pnlEmailRow.ColumnCount = 2;
            pnlEmailRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlEmailRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlEmailRow.Controls.Add(lblEmailHeader, 0, 0);
            pnlEmailRow.Controls.Add(txtEmailValue, 1, 0);
            pnlEmailRow.Dock = DockStyle.Fill;
            pnlEmailRow.Location = new Point(0, 44);
            pnlEmailRow.Margin = new Padding(0, 4, 0, 4);
            pnlEmailRow.Name = "pnlEmailRow";
            pnlEmailRow.RowCount = 1;
            pnlEmailRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlEmailRow.Size = new Size(380, 32);
            pnlEmailRow.TabIndex = 1;
            // 
            // lblEmailHeader
            // 
            lblEmailHeader.AutoSize = true;
            lblEmailHeader.Dock = DockStyle.Fill;
            lblEmailHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmailHeader.ForeColor = Color.FromArgb(93, 122, 149);
            lblEmailHeader.Location = new Point(263, 0);
            lblEmailHeader.Name = "lblEmailHeader";
            lblEmailHeader.Size = new Size(114, 32);
            lblEmailHeader.TabIndex = 0;
            lblEmailHeader.Text = "📧 البريد:";
            lblEmailHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmailValue
            // 
            txtEmailValue.BackColor = Color.White;
            txtEmailValue.BorderStyle = BorderStyle.None;
            txtEmailValue.Dock = DockStyle.Fill;
            txtEmailValue.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtEmailValue.ForeColor = Color.FromArgb(44, 62, 80);
            txtEmailValue.Location = new Point(3, 6);
            txtEmailValue.Margin = new Padding(3, 6, 3, 3);
            txtEmailValue.Name = "txtEmailValue";
            txtEmailValue.ReadOnly = true;
            txtEmailValue.Size = new Size(254, 19);
            txtEmailValue.TabIndex = 1;
            txtEmailValue.Text = "matarmohammed567@gmail.com";
            // 
            // pnlLinkedInRow
            // 
            pnlLinkedInRow.ColumnCount = 2;
            pnlLinkedInRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlLinkedInRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLinkedInRow.Controls.Add(lblLinkedInHeader, 0, 0);
            pnlLinkedInRow.Controls.Add(txtLinkedInValue, 1, 0);
            pnlLinkedInRow.Dock = DockStyle.Fill;
            pnlLinkedInRow.Location = new Point(0, 84);
            pnlLinkedInRow.Margin = new Padding(0, 4, 0, 4);
            pnlLinkedInRow.Name = "pnlLinkedInRow";
            pnlLinkedInRow.RowCount = 1;
            pnlLinkedInRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLinkedInRow.Size = new Size(380, 32);
            pnlLinkedInRow.TabIndex = 2;
            // 
            // lblLinkedInHeader
            // 
            lblLinkedInHeader.AutoSize = true;
            lblLinkedInHeader.Dock = DockStyle.Fill;
            lblLinkedInHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLinkedInHeader.ForeColor = Color.FromArgb(93, 122, 149);
            lblLinkedInHeader.Location = new Point(263, 0);
            lblLinkedInHeader.Name = "lblLinkedInHeader";
            lblLinkedInHeader.Size = new Size(114, 32);
            lblLinkedInHeader.TabIndex = 0;
            lblLinkedInHeader.Text = "🔗 LinkedIn:";
            lblLinkedInHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLinkedInValue
            // 
            txtLinkedInValue.BackColor = Color.White;
            txtLinkedInValue.BorderStyle = BorderStyle.None;
            txtLinkedInValue.Dock = DockStyle.Fill;
            txtLinkedInValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtLinkedInValue.ForeColor = Color.FromArgb(44, 62, 80);
            txtLinkedInValue.Location = new Point(3, 4);
            txtLinkedInValue.Margin = new Padding(3, 4, 3, 3);
            txtLinkedInValue.Multiline = true;
            txtLinkedInValue.Name = "txtLinkedInValue";
            txtLinkedInValue.ReadOnly = true;
            txtLinkedInValue.Size = new Size(254, 25);
            txtLinkedInValue.TabIndex = 1;
            txtLinkedInValue.Text = "linkedin.com/in/mohammed-matar-857962336";
            // 
            // pnlSupportNoticeCard
            // 
            pnlSupportNoticeCard.BackColor = Color.FromArgb(240, 249, 255);
            pnlSupportNoticeCard.Controls.Add(noticeLayout);
            pnlSupportNoticeCard.Dock = DockStyle.Fill;
            pnlSupportNoticeCard.Location = new Point(0, 382);
            pnlSupportNoticeCard.Margin = new Padding(0, 30, 0, 0);
            pnlSupportNoticeCard.Name = "pnlSupportNoticeCard";
            pnlSupportNoticeCard.Padding = new Padding(20);
            pnlSupportNoticeCard.Size = new Size(410, 80);
            pnlSupportNoticeCard.TabIndex = 5;
            // 
            // noticeLayout
            // 
            noticeLayout.BackColor = Color.Transparent;
            noticeLayout.ColumnCount = 2;
            noticeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            noticeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            noticeLayout.Controls.Add(lblNoticeIcon, 0, 0);
            noticeLayout.Controls.Add(lblNoticeText, 1, 0);
            noticeLayout.Dock = DockStyle.Fill;
            noticeLayout.Location = new Point(20, 20);
            noticeLayout.Name = "noticeLayout";
            noticeLayout.RowCount = 1;
            noticeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            noticeLayout.Size = new Size(370, 40);
            noticeLayout.TabIndex = 0;
            // 
            // lblNoticeIcon
            // 
            lblNoticeIcon.AutoSize = true;
            lblNoticeIcon.Dock = DockStyle.Fill;
            lblNoticeIcon.Font = new Font("Segoe UI", 12F);
            lblNoticeIcon.Location = new Point(343, 0);
            lblNoticeIcon.Name = "lblNoticeIcon";
            lblNoticeIcon.Size = new Size(24, 40);
            lblNoticeIcon.TabIndex = 0;
            lblNoticeIcon.Text = "ℹ️";
            lblNoticeIcon.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNoticeText
            // 
            lblNoticeText.AutoSize = true;
            lblNoticeText.Dock = DockStyle.Fill;
            lblNoticeText.Font = new Font("Segoe UI", 9.5F);
            lblNoticeText.ForeColor = Color.FromArgb(52, 73, 94);
            lblNoticeText.Location = new Point(3, 0);
            lblNoticeText.Name = "lblNoticeText";
            lblNoticeText.Size = new Size(334, 40);
            lblNoticeText.TabIndex = 1;
            lblNoticeText.Text = "الدعم الفني متاح من السبت إلى الخميس\r\nمن الساعة 9:00 صباحاً وحتى 5:00 مساءً";
            lblNoticeText.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonsUniformGrid
            // 
            buttonsUniformGrid.ColumnCount = 2;
            buttonsUniformGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsUniformGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsUniformGrid.Controls.Add(btnSendMessage, 0, 0);
            buttonsUniformGrid.Controls.Add(btnWhatsApp, 1, 0);
            buttonsUniformGrid.Dock = DockStyle.Fill;
            buttonsUniformGrid.Location = new Point(0, 487);
            buttonsUniformGrid.Margin = new Padding(0, 25, 0, 0);
            buttonsUniformGrid.Name = "buttonsUniformGrid";
            buttonsUniformGrid.RowCount = 1;
            buttonsUniformGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsUniformGrid.Size = new Size(410, 66);
            buttonsUniformGrid.TabIndex = 6;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.FromArgb(26, 37, 51);
            btnSendMessage.Dock = DockStyle.Top;
            btnSendMessage.FlatAppearance.BorderSize = 0;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.Location = new Point(210, 5);
            btnSendMessage.Margin = new Padding(5);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(195, 45);
            btnSendMessage.TabIndex = 0;
            btnSendMessage.Text = "إرسال رسالة";
            btnSendMessage.UseVisualStyleBackColor = false;
            // 
            // btnWhatsApp
            // 
            btnWhatsApp.BackColor = Color.FromArgb(39, 174, 96);
            btnWhatsApp.Dock = DockStyle.Top;
            btnWhatsApp.FlatAppearance.BorderSize = 0;
            btnWhatsApp.FlatStyle = FlatStyle.Flat;
            btnWhatsApp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWhatsApp.ForeColor = Color.White;
            btnWhatsApp.Location = new Point(5, 5);
            btnWhatsApp.Margin = new Padding(5);
            btnWhatsApp.Name = "btnWhatsApp";
            btnWhatsApp.Size = new Size(195, 45);
            btnWhatsApp.TabIndex = 1;
            btnWhatsApp.Text = "واتساب";
            btnWhatsApp.UseVisualStyleBackColor = false;
            // 
            // frmSupport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(884, 661);
            Controls.Add(mainContainerPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "frmSupport";
            RightToLeft = RightToLeft.Yes;
            mainContainerPanel.ResumeLayout(false);
            pnlCenterCard.ResumeLayout(false);
            cardContentLayout.ResumeLayout(false);
            cardContentLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).EndInit();
            infoRowsLayout.ResumeLayout(false);
            pnlPhoneRow.ResumeLayout(false);
            pnlPhoneRow.PerformLayout();
            pnlEmailRow.ResumeLayout(false);
            pnlEmailRow.PerformLayout();
            pnlLinkedInRow.ResumeLayout(false);
            pnlLinkedInRow.PerformLayout();
            pnlSupportNoticeCard.ResumeLayout(false);
            noticeLayout.ResumeLayout(false);
            noticeLayout.PerformLayout();
            buttonsUniformGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainerPanel;
        private System.Windows.Forms.Panel pnlCenterCard;
        private System.Windows.Forms.TableLayoutPanel cardContentLayout;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label lblDeveloperTitle;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.TableLayoutPanel infoRowsLayout;
        private System.Windows.Forms.TableLayoutPanel pnlPhoneRow;
        private System.Windows.Forms.Label lblPhoneHeader;
        private System.Windows.Forms.TextBox txtPhoneValue;
        private System.Windows.Forms.TableLayoutPanel pnlEmailRow;
        private System.Windows.Forms.Label lblEmailHeader;
        private System.Windows.Forms.TextBox txtEmailValue;
        private System.Windows.Forms.TableLayoutPanel pnlLinkedInRow;
        private System.Windows.Forms.Label lblLinkedInHeader;
        private System.Windows.Forms.TextBox txtLinkedInValue;
        private System.Windows.Forms.Panel pnlSupportNoticeCard;
        private System.Windows.Forms.TableLayoutPanel noticeLayout;
        private System.Windows.Forms.Label lblNoticeIcon;
        private System.Windows.Forms.Label lblNoticeText;
        private System.Windows.Forms.TableLayoutPanel buttonsUniformGrid;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnWhatsApp;
    }
}