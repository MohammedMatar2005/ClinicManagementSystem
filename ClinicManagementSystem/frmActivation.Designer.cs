namespace ClinicManagementSystem
{
    partial class frmActivation
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
            txtHardwareId = new TextBox();
            txtLicenseKey = new TextBox();
            btnActivate = new Button();
            SuspendLayout();
            // 
            // txtHardwareId
            // 
            txtHardwareId.Location = new Point(337, 68);
            txtHardwareId.Name = "txtHardwareId";
            txtHardwareId.ReadOnly = true;
            txtHardwareId.Size = new Size(100, 23);
            txtHardwareId.TabIndex = 0;
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new Point(337, 233);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.ReadOnly = true;
            txtLicenseKey.Size = new Size(100, 23);
            txtLicenseKey.TabIndex = 1;
            // 
            // btnActivate
            // 
            btnActivate.Location = new Point(337, 326);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(150, 44);
            btnActivate.TabIndex = 2;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = true;
            // 
            // frmActivation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActivate);
            Controls.Add(txtLicenseKey);
            Controls.Add(txtHardwareId);
            Name = "frmActivation";
            Text = "frmActivation";
            Load += frmActivation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHardwareId;
        private TextBox txtLicenseKey;
        private Button btnActivate;
    }
}