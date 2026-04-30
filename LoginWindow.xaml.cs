using System;
using System.Windows;
using System.Windows.Threading;
using System.Globalization; // ضروري لتنسيق التاريخ بالعربي
using ClinicManagementApplication.ViewModels;

namespace ClinicManagementApplication

{
    public partial class LoginWindow : Window
    {
        // تعريف التايمر كمتغير على مستوى الكلاس
        private DispatcherTimer _timer;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // إعداد التايمر وتكراره كل ثانية
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (s, ev) => UpdateTime();
            _timer.Start();

            // استدعاء الدالة فوراً لتجنب تأخير أول ثانية
            UpdateTime();
        }

        private void UpdateTime()
        {
            // تحديث الساعة (تنسيق 24 ساعة أو 12 ساعة حسب رغبتك)
            //lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

            //تحديث التاريخ بالعربي
            //lblDate.Text = DateTime.Now.ToString("dddd، d MMMM yyyy", new CultureInfo("ar-SA"));
        }

        // لجعل النافذة قابلة للسحب بما أن WindowStyle="None"
        protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

      
       


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // يفضل عمل تحقق بسيط قبل فتح النافذة
            if (txtUser.Text == "admin" && txtPass.Password == "123")
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close(); // نغلق اللوجن ونفتح المين
            }
            else
            {
                MessageBox.Show("خطأ في بيانات الدخول!");
            }
        }

       
    }
}