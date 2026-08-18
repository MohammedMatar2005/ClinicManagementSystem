using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;

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
                // 1. إنشاء الرسالة وتحديد المحتوى وتنسيقه
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("عيادة الأسنان / إدارة النظام", "matarmohammed567@gmail.com"));
                message.To.Add(new MailboxAddress("", "matarmohammed567@gmail.com"));
                message.Subject = "تأكيد موعد المراجعة الطبي";

                // تجهيز جسم الرسالة بصيغة HTML
                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = "<h3>مرحباً بك،</h3><p>نود تذكيرك بموعد زيارتك القادمة في العيادة. نتمنى لك وافر الصحة والعافية.</p>"
                };
                message.Body = bodyBuilder.ToMessageBody();

                // 2. الاتصال بسيرفر Gmail عبر MailKit SmtpClient
                using (var client = new SmtpClient())
                {
                    // الاتصال بالسيرفر مع تشفير StartTls على المنفذ 587
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    // المصادقة باستخدام إيميلك وكلمة مرور التطبيقات (App Password)
                    await client.AuthenticateAsync("matarmohammed567@gmail.com", "your_16_digit_app_password");

                    // الإرسال بشكل غير متزامن
                    await client.SendAsync(message);

                    // قطع الاتصال بنظافة
                    await client.DisconnectAsync(true);
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
