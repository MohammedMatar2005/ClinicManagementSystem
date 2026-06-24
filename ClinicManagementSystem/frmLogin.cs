using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness.Services;
using ClinicBusiness.Models; // الاعتماد على الموديلز الموحدة للبزنس

namespace ClinicManagementSystem
{
    public partial class frmLogin : Form
    {
        private readonly ClinicManagementSystemContext _context;
        private readonly clsUser _userService;

        public frmLogin()
        {
            InitializeComponent();

            // 1. إنشاء الـ Context وحقنه مباشرة في السيرفس
            _context = new ClinicManagementSystemContext();
            _userService = new clsUser(_context);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // أي تهيئة إضافية للواجهة (مثل تصفير الخانات)
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من الخروج من النظام؟",
                "تأكيد الإغلاق",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 2. تصحيح التوقيع ليكون async void بدلاً من async Task ليتوافق مع حوادث WinForms
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور!", "خطأ في المدخلات",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return;
            }

            try
            {
                // تجهيز المدخلات
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text; // كلمة المرور الصافية (Plain Text) ليتم التحقق منها وتشفيرها بالبزنس

                // 3. استدعاء دالة التحقق من طبقة الـ Business Layer بشكل غير متزامن
                var loggedInUser = await _userService.LoginAsync(username, password);

                if (loggedInUser == null)
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", "فشل تسجيل الدخول",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return;
                }

                // 4. نجاح تسجيل الدخول
                MessageBox.Show($"أهلاً بك مجدداً، {loggedInUser.Username}!", "تم تسجيل الدخول بنجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                // فتح شاشة النظام الرئيسية وتمرير بيانات المستخدم الحالي لها
                frmMain mainMenu = new frmMain(loggedInUser);
                mainMenu.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "فشل تسجيل الدخول",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                // أخطاء السيرفر أو الاتصال بقاعدة البيانات
                MessageBox.Show($"حدث خطأ غير متوقع في النظام:\n{ex.Message}", "خطأ في النظام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
    }
}