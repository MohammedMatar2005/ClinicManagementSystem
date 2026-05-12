using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ClinicManagementApplication.Infrastructure;
using ClinicBusiness;

namespace ClinicManagementApplication.ViewModels
{
    public class PatientsViewModel : BaseViewModel
    {
        #region Properties

        private ObservableCollection<clsPatient> _patients = new ObservableCollection<clsPatient>();
        public ObservableCollection<clsPatient> Patients
        {
            get => _patients;
            set { _patients = value; OnPropertyChanged(); }
        }

        private clsPatient _selectedPatient;
        public clsPatient SelectedPatient
        {
            get => _selectedPatient;
            set { _selectedPatient = value; OnPropertyChanged(); }
        }

        #endregion

        // ====== Commands ======

        public ICommand SavePatientCommand { get; }
        public ICommand DeletePatientCommand { get; }
        public ICommand ClearFieldsCommand { get; }

        // ====== Constructor ======

        public PatientsViewModel()
        {
            if (System.ComponentModel.DesignerProperties
                    .GetIsInDesignMode(new DependencyObject())) return;

            ResetSelectedPatient();

            SavePatientCommand = new RelayCommand(async _ => await SavePatient());
            ClearFieldsCommand = new RelayCommand(_ => ResetSelectedPatient());
            DeletePatientCommand = new RelayCommand(async p => await DeletePatient(p),
                                                         p => p != null);

            _ = LoadPatients();
        }

        // ====== Methods ======

        private void ResetSelectedPatient()
        {
            SelectedPatient = new clsPatient();
            //if (SelectedPatient.PersonInfo == null)
            //    SelectedPatient.PersonInfo = new clsPeople();
        }

        private async Task LoadPatients()
        {
            IsLoading = true;
            try
            {
                Patients = await Task.Run(() => clsPatient.GetAll().ToObservableCollection<clsPatient>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}",
                    "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async Task SavePatient()
        {
            if (string.IsNullOrWhiteSpace(SelectedPatient.PatientFullName))
            {
                MessageBox.Show("يرجى إدخال اسم المريض",
                    "تنبيه", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            IsLoading = true;
            try
            {
                bool success = await Task.Run(() => SelectedPatient.Save());

                if (success)
                {
                    MessageBox.Show("تم حفظ بيانات المريض بنجاح",
                        "نجاح", MessageBoxButton.OK, MessageBoxImage.Information);
                    await LoadPatients();
                    ResetSelectedPatient();
                }
                else
                {
                    MessageBox.Show("فشل حفظ البيانات.",
                        "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ غير متوقع: {ex.Message}",
                    "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async Task DeletePatient(object id)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف هذا المريض؟", "تأكيد",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                return;

            IsLoading = true;
            try
            {
                bool success = await Task.Run(() => clsPatient.Delete((int)id));
                if (success)
                    await LoadPatients();
                else
                    MessageBox.Show("فشل الحذف.",
                        "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ غير متوقع: {ex.Message}",
                    "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}