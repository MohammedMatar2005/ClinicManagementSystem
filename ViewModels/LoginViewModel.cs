using ClinicBusiness;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ClinicManagementApplication.Infrastructure;
using System.Threading.Tasks;

namespace ClinicManagementApplication.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Private Fields
        private string _username;
        private string _currentTime;
        private string _currentDate;
        private bool _isBusy;
        #endregion

        #region Properties
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        public string CurrentTime
        {
            get => _currentTime;
            set { _currentTime = value; OnPropertyChanged(); }
        }

        public string CurrentDate
        {
            get => _currentDate;
            set { _currentDate = value; OnPropertyChanged(); }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set { _isBusy = value; OnPropertyChanged(); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand MinimizeCommand { get; }
        #endregion

        public LoginViewModel()
        {
            // تحديث الوقت والتاريخ
            UpdateDateTime();

            // تعريف الأوامر باستخدام الـ RelayCommand الخاص بك
            LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
            CloseCommand = new RelayCommand((p) => Close_Click(p, null));
            MinimizeCommand = new RelayCommand((p) => Minimize_Click(p, null));
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void UpdateDateTime()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) =>
            {
                CurrentTime = DateTime.Now.ToString("HH:mm:ss");
                CurrentDate = DateTime.Now.ToString("dddd، d MMMM yyyy");
            };
            timer.Start();
        }

        private bool CanExecuteLogin(object parameter)
        {
            // الزر لا يفعّل إلا إذا كتب المستخدم اسماً
            return !string.IsNullOrWhiteSpace(Username) && !IsBusy;
        }

        private async void ExecuteLogin(object parameter)
        {
            // استلام الـ PasswordBox كـ parameter للأمان
            var passwordBox = parameter as System.Windows.Controls.PasswordBox;
            if (passwordBox == null) return;

            

            string password = passwordBox.Password;
             

            IsBusy = true;
            try
            {
                 //    هنا يتم الاستدعاء من طبقة البزنس(مثال)
                clsUser AuthenticatedUser = await Task.Run(() => clsUser.Login(Username, password));

                if(AuthenticatedUser == null)
                {
                    MessageBox.Show("خطأ في معلومات تسجيل الدخول");
                    return;
                }


                if (Username == AuthenticatedUser.Username && AuthenticatedUser.PasswordHash == password)
                {
                    // 1. إنشاء نسخة من الشاشة الرئيسية
                    var mainDashboard = new MainWindow();

                    // 2. إظهار الشاشة الرئيسية
                    mainDashboard.Show();

                    
                    Application.Current.Windows.OfType<Window>().FirstOrDefault(w => w is LoginWindow)?.Close();
                

                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}