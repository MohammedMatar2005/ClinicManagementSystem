using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmSupport : Form
    {
        public frmSupport()
        {
            InitializeComponent();
        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            string phoneNumber = "+972599623752"; // ضع الرقم بصيغة دولية بدون +

            string whatsappUrl = $"https://wa.me/{phoneNumber}";

            Process.Start(new ProcessStartInfo
            {
                FileName = whatsappUrl,
                UseShellExecute = true
            });
        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. تجهيز نص الرسالة وبيانات المرسل والمستقبل
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("matarmohammed567@gmail.com", "عيادة الأسنان / إدارة النظام"); // إيميلك واسم العيادة
                    mail.To.Add("matarmohammed567@gmail.com"); // إيميل الشخص الموجه له الرسالة
                    mail.Subject = "تأكيد موعد المراجعة الطبي";
                    mail.Body = "<h3>مرحباً بك،</h3><p>نود تذكيرك بموعد زيارتك القادمة في العيادة. نتمنى لك وافر الصحة والعافية.</p>";
                    mail.IsBodyHtml = true; // تفعيل الـ HTML للحصول على تنسيق نصوص جميل

                    // 2. إعدادات خادم السيرفر (SMTP Client) الخاص بـ Gmail
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        // ⚠️ ضع هنا إيميلك و "كلمة مرور التطبيق" (App Password) المكونة من 16 حرفاً من حساب جوجل
                        smtp.Credentials = new NetworkCredential("matarmohammed567@gmail.com", "your_16_digit_app_password");
                        smtp.EnableSsl = true; // تفعيل التشفير والأمان وهو إجباري في Gmail

                        // 3. الإرسال بشكل غير متزامن للحفاظ على خفة وسرعة الواجهة
                        await smtp.SendMailAsync(mail);
                    }
                }

                MessageBox.Show("تم إرسال البريد الإلكتروني بنجاح!", "نجاح الإرسال",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل إرسال البريد الإلكتروني بسبب:\n{ex.Message}", "خطأ في الإرسال",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
    }
}
