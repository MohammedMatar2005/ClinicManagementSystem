using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClinicBusiness;
using ClinicManagementApplication;
using ClinicManagementApplication.Views;
using ClinicManagementApplication.ViewModels;


namespace ClinicManagementApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // هذا السطر السحري يخبر الويندوز بأن المستخدم بدأ بعملية سحب للنافذة
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnPatients_Click(object sender, RoutedEventArgs e)
        {
            PatientsUC patientsPage = new PatientsUC();

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = patientsPage;
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            HomeUC homePage = new HomeUC();

            PagesContainer.Content = homePage;

           
        }
       
        private void BtnDoctors_Click(object sender, RoutedEventArgs e)
        {
            DoctorsUC DoctorsPage = new DoctorsUC();

            DoctorsPage.DataContext = new DoctorsViewModel(); // اسم الكلاس الخاص بك

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = DoctorsPage;
        }

        private void BtnAppointments_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsUC AppointmentsPage = new AppointmentsUC();

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = AppointmentsPage;
        }

        private void BtnReports_Click(object sender, RoutedEventArgs e)
        {
            ReportsUC ReportsPage = new ReportsUC();

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = ReportsPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnBilling_Click(object sender, RoutedEventArgs e)
        {
            InvoicesUC InvoicesPage = new InvoicesUC();

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = InvoicesPage;
        }

        private void BtnPharmacy_Click(object sender, RoutedEventArgs e)
        {
            PharmacyUC PharmacyPage = new PharmacyUC();

            // 2. وضع الصفحة داخل الحاوية (ContentControl) التي سميناها PagesContainer
            PagesContainer.Content = PharmacyPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SettingsUC SettingsPage = new SettingsUC();

            PagesContainer.Content = SettingsPage;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SupportUC support = new SupportUC();

            PagesContainer.Content = support;
        }
    }
}
