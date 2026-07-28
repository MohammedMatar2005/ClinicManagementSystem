
namespace ClinicManagementSystem
{
    public partial class frmActivation : Form
    {
        public frmActivation()
        {
            InitializeComponent();
        }

        private void frmActivation_Load(object sender, EventArgs e)
        {
            // عرض كود الجهاز للعميل ليرسله لك
            txtHardwareId.Text = DeviceFingerprint.GetHardwareId();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (LicenseManager.SaveLicense(txtLicenseKey.Text))
            {
                MessageBox.Show("تم تفعيل البرنامج بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("مفتاح التفعيل غير صحيح لهذا الجهاز.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}