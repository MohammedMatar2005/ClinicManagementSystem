using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ClinicManagementApplication.Infrastructure;
using ClinicBusiness;


namespace ClinicManagementApplication.ViewModels
{
    public class VisitsViewModel : BaseViewModel
    {
        // ====== الخصائص (Properties) ======

        private clsPatientVisit _selectedVisit;
        public clsPatientVisit SelectedVisit
        {
            get => _selectedVisit;
            set { _selectedVisit = value; OnPropertyChanged(); }
        }

        // قوائم الاختيار (ComboBoxes)
        public ObservableCollection<clsPatient> Patients { get; set; }
        public ObservableCollection<clsDoctor> Doctors { get; set; }

        // ====== الأوامر (Commands) ======
        public ICommand SaveVisitCommand { get; }
        public ICommand ClearCommand { get; }

        public VisitsViewModel()
        {
            // تهيئة زيارة جديدة
            InitializeNewVisit();

            // تحميل البيانات (مفترض وجود كلاسات داتا أكسس)
            LoadInitialData();

            // تعريف الأوامر
            SaveVisitCommand = new RelayCommand(p => SaveVisit());
            ClearCommand = new RelayCommand(p => InitializeNewVisit());
        }

        private void InitializeNewVisit()
        {
            SelectedVisit = new clsPatientVisit
            {
                VisitDate = DateTime.Now,
                CreatedDate = DateTime.Now
                // الحقول الأخرى ستكون null تلقائياً لأنها Nullable
            };
        }

        private void LoadInitialData()
        {
            // هنا تضع كود جلب البيانات من قاعدة البيانات
            // Patients = new ObservableCollection<clsPatient>(clsPatient.GetAll());
            // Doctors = new ObservableCollection<clsDoctor>(clsDoctor.GetAll());
        }

        private void SaveVisit()
        {
            try
            {
                // تأكد من اختيار المريض والطبيب أولاً
                if (SelectedVisit.PatientId == 0 || SelectedVisit.DoctorId == 0)
                {
                    MessageBox.Show("يرجى اختيار المريض والطبيب أولاً.");
                    return;
                }

                // كود الحفظ في قاعدة البيانات
                // bool success = clsVisits.Save(SelectedVisit);

                // if (success) {
                MessageBox.Show("تم حفظ الزيارة بنجاح!");
                InitializeNewVisit(); // تصفير الشاشة بعد الحفظ
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء الحفظ: {ex.Message}");
            }
        }
    }
}