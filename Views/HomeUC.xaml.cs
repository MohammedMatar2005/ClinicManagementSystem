using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ClinicManagementApplication.Views
{
    public partial class HomeUC : UserControl
    {
        DispatcherTimer timer;

        public HomeUC()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // تحديث الساعة والوقت
            //lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //lblDate.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy");

            // مثال بسيط للعد التنازلي (يمكنك ربطه بـ API مواقيت الصلاة لاحقاً)
            // لنفترض أن الصلاة القادمة في الساعة 16:15
            DateTime prayerTime = DateTime.Today.AddHours(16).AddMinutes(15);
            TimeSpan diff = prayerTime - DateTime.Now;

           
        }
    }
}