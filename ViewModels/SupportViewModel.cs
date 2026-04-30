using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ClinicManagementApplication.Infrastructure;

namespace ClinicManagementApplication.ViewModels
{
    public class SupportViewModel : BaseViewModel
    {
        // 1. خصائص نصية لوصف المشكلة أو الرسالة
        private string _subject;
        public string Subject
        {
            get => _subject;
            set { _subject = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(); }
        }

        // 2. أوامر (إرسال الرسالة، فتح موقع الدعم)
        public ICommand SendMessageCommand { get; }
        public ICommand OpenGuideCommand { get; }

        public SupportViewModel()
        {
            SendMessageCommand = new RelayCommand(async (p) => await SendMessage());
            OpenGuideCommand = new RelayCommand((p) => OpenUserGuide());
        }

        private async Task SendMessage()
        {
            if (string.IsNullOrEmpty(Message)) return;

            IsLoading = true;
            try
            {
                // هنا ممكن تحط منطق إرسال إيميل أو حفظ الرسالة في قاعدة البيانات
                // await Task.Run(() => clsSupport.Send(Subject, Message));

                // بعد الإرسال نصفر الحقول
                Subject = string.Empty;
                Message = string.Empty;
            }
            finally
            {
                IsLoading = false;
            }
        }

        private void OpenUserGuide()
        {
            // منطق لفتح ملف PDF أو رابط خارجي لتعليمات الاستخدام
            // System.Diagnostics.Process.Start("gmail.com");
        }
    }
}