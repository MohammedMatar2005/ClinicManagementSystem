using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Input;
using ClinicBusiness; // مكتبة البزنس
using ClinicManagementApplication.Infrastructure;

namespace ClinicManagementApplication.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        // 1. الخصائص التي سنعرضها في كروت الإحصائيات (Cards)
        private int _totalPatients;
        public int TotalPatients
        {
            get => _totalPatients;
            set { _totalPatients = value; OnPropertyChanged(); }
        }

        private int _todayAppointments;
        public int TodayAppointments
        {
            get => _todayAppointments;
            set { _todayAppointments = value; OnPropertyChanged(); }
        }

        private int _totalDoctors;
        public int TotalDoctors
        {
            get => _totalDoctors;
            set { _totalDoctors = value; OnPropertyChanged(); }
        }

        // 2. أمر لتحديث الإحصائيات
        public ICommand RefreshCommand { get; }

        public HomeViewModel()
        {
            RefreshCommand = new RelayCommand(async (p) => await LoadDashboardData());

            // تحميل البيانات عند فتح الشاشة
            _ = LoadDashboardData();
        }

        private async Task LoadDashboardData()
        {
            IsLoading = true;

            try
            {
                // هنا نستدعي دوال من الـ BLL تجلب "Count" أو أرقام مباشرة
                // إذا لم يكن لديك دوال جاهزة للعد، يمكنك جلب الـ DataTable وعد الأسطر

                // مثال:
                // var dtPatients = await Task.Run(() => clsPatient.GetAllPatients());
                // TotalPatients = dtPatients.Rows.Count;

                // أو الأفضل لو عندك دالة مباشرة في البزنس:
                //TotalPatients = await Task.Run(() => clsPatient.());
                //TodayAppointments = await Task.Run(() => clsAppointment.GetTodayAppointmentsCount());
                //TotalDoctors = await Task.Run(() => clsDoctor.Count());
            }
            catch (Exception ex)
            {
                // منطق معالجة الأخطاء
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}