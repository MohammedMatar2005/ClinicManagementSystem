using ClinicBusiness;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ClinicManagementApplication.Infrastructure;
using System.Windows.Controls;

namespace ClinicManagementApplication.ViewModels
{
    public class DoctorsViewModel : BaseViewModel
    {
        private ObservableCollection<clsDoctor> _doctors = new ObservableCollection<clsDoctor>();
        public ObservableCollection<clsDoctor> Doctors
        {
            get => _doctors;
            set { _doctors = value; OnPropertyChanged(); }
        }

        // قوائم للـ ComboBoxes في الواجهة
        public ObservableCollection<clsPeople> PeopleList { get; set; } = new ObservableCollection<clsPeople>();
        public ObservableCollection<clsUser> UsersList { get; set; } = new ObservableCollection<clsUser>();

        private clsDoctor _selectedDoctor;
        public clsDoctor SelectedDoctor
        {
            get => _selectedDoctor;
            set { _selectedDoctor = value; OnPropertyChanged(); }
        }

        private clsPeople _selectedPerson; // تم تصحيح الخطأ الإملائي هنا Perosn -> Person
        public clsPeople SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; OnPropertyChanged(); }
        }

        private clsUser _selectedUser;
        public clsUser SelectedUser
        {
            get => _selectedUser;
            set { _selectedUser = value; OnPropertyChanged(); }
        }

        #region PersonProperties
        // ملاحظة هامة: الـ View الآن سيبحث عن هذه الخصائص مباشرة
        public string FirstName { get => SelectedPerson.FirstName; set { SelectedPerson.FirstName = value; OnPropertyChanged(); } }
        public string SecondName { get => SelectedPerson.SecondName; set { SelectedPerson.SecondName = value; OnPropertyChanged(); } }
        public string ThirdName { get => SelectedPerson.ThirdName; set { SelectedPerson.ThirdName = value; OnPropertyChanged(); } }
        public string LastName { get => SelectedPerson.LastName; set { SelectedPerson.LastName = value; OnPropertyChanged(); } }
        public DateTime DateOfBirth { get => SelectedPerson.DateOfBirth; set { SelectedPerson.DateOfBirth = value; OnPropertyChanged(); } }
        public string PhoneNumber { get => SelectedPerson.Phone; set { SelectedPerson.Phone = value; OnPropertyChanged(); } }
        public byte Gender { get => SelectedPerson.Gender; set { SelectedPerson.Gender = value; OnPropertyChanged(); } }
        public string Email { get => SelectedPerson.Email; set { SelectedPerson.Email = value; OnPropertyChanged(); } }
        public string Address { get => SelectedPerson.Address; set { SelectedPerson.Address = value; OnPropertyChanged(); } }
        public string ImagePath { get => SelectedPerson.ImagePath; set { SelectedPerson.ImagePath = ""; OnPropertyChanged(); } }

        #endregion

        #region UserProperties
        public string Username { get => SelectedUser.Username; set { SelectedUser.Username = value; OnPropertyChanged(); } }
        public string Password { get => SelectedUser.PasswordHash; set { SelectedUser.PasswordHash = value; OnPropertyChanged(); } }
        public int RoleId { get => SelectedUser.RoleId; set { SelectedUser.RoleId = value; OnPropertyChanged(); } }
        public bool IsActive { get => SelectedUser.IsActive; set { SelectedUser.IsActive = value; OnPropertyChanged(); } }

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
                // بمجرد تغيير التأكيد، نبلغ الواجهة أن حالة التطابق قد تغيرت
                OnPropertyChanged(nameof(IsPasswordMatch));
            }
        }

        // هذه الخاصية لا تحتاج متغير private لأنها تعتمد على خصائص أخرى
        public bool IsPasswordMatch
        {
            get
            {
                // نتحقق من أن كلمة المرور ليست فارغة وأنها تطابق التأكيد
                if (string.IsNullOrEmpty(SelectedUser?.PasswordHash) || string.IsNullOrEmpty(ConfirmPassword))
                    return false;

                return SelectedUser.PasswordHash == ConfirmPassword;
            }
        }
        #endregion


        private int _currentTabIndex = 0;
        public int CurrentTabIndex
        {
            get => _currentTabIndex;
            set
            {
                _currentTabIndex = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NextBtnVisible));
                OnPropertyChanged(nameof(BackBtnVisible));
                OnPropertyChanged(nameof(SaveBtnVisible));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public Visibility NextBtnVisible => (CurrentTabIndex < 2) ? Visibility.Visible : Visibility.Collapsed;
        public Visibility BackBtnVisible => (CurrentTabIndex > 0) ? Visibility.Visible : Visibility.Collapsed;
        public Visibility SaveBtnVisible => (CurrentTabIndex == 2) ? Visibility.Visible : Visibility.Collapsed;

        public ICommand SaveDoctorCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand SavePersonCommand { get; }
        public ICommand SaveUserCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand BackCommand { get; }

        public DoctorsViewModel()
        {
            ResetAllData();

            SaveDoctorCommand = new RelayCommand(async (p) => await SaveDoctor());
            ClearCommand = new RelayCommand((p) => ResetAllData());
            SavePersonCommand = new RelayCommand(async (p) => await SavePerson());
            SaveUserCommand = new RelayCommand(async (p) => await SaveUser());
            NextCommand = new RelayCommand(ExecuteNext, CanExecuteNext);
            BackCommand = new RelayCommand(ExecuteBack, CanExecuteBack);

            _ = LoadDoctors();
        }

        private void ResetAllData()
        {
            SelectedDoctor = new clsDoctor();
            SelectedPerson = new clsPeople();
            SelectedUser = new clsUser();
            CurrentTabIndex = 0;
        }

        private async Task LoadDoctors()
        {
            IsLoading = true;
            try
            {
                Doctors = await Task.Run(() => clsDoctor.GetAllDoctors());
                // تحميل القوائم للـ ComboBoxes إذا لزم الأمر
                var people = await Task.Run(() => clsPeople.GetAllPeople());
                PeopleList = new ObservableCollection<clsPeople>(people);
                OnPropertyChanged(nameof(PeopleList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}");
            }
            finally { IsLoading = false; }
        }

        private async Task SavePerson()
        {
            bool success = await Task.Run(() => SelectedPerson.Save());
            if (success)
            {
                MessageBox.Show("تم حفظ بيانات الشخص بنجاح");

                PeopleList.Add(SelectedPerson);
                SelectedUser.PersonId = SelectedPerson.PersonId; // ربط تلقائي
                CurrentTabIndex = 1; // انتقال تلقائي للتاب التالي
            }
            else { MessageBox.Show("فشل حفظ بيانات الشخص"); }
        }

        private async Task SaveUser()
        {
            SelectedUser.PersonInfo = SelectedPerson;
            bool success = await Task.Run(() => SelectedUser.Save());
            if (success)
            {
                MessageBox.Show("تم حفظ بيانات المستخدم بنجاح");
                SelectedDoctor.UserId = SelectedUser.UserId; // ربط تلقائي
                CurrentTabIndex = 2; // انتقال للتاب الأخير
            }
            else { MessageBox.Show("فشل حفظ بيانات المستخدم"); }
        }

        private bool CanSaveUser(object p)
        {
            return IsPasswordMatch && !string.IsNullOrEmpty(ConfirmPassword);
        }

        private async Task SaveDoctor()
        {
            if (!IsPasswordMatch)
            {
                MessageBox.Show("كلمة المرور غير متطابقة، يرجى التأكد قبل الحفظ النهائي");
                CurrentTabIndex = 1;
                return;
            }

            var result = await Task.Run(() => SelectedDoctor.Save());

            switch (result)
            {
                case clsDoctor.enMode.AddNew:
                    MessageBox.Show("تم إضافة الطبيب بنجاح");
                    await LoadDoctors();
                    ResetAllData();
                    break;

                case clsDoctor.enMode.Update:
                    MessageBox.Show("تم تحديث بيانات الطبيب بنجاح");
                    await LoadDoctors();
                    ResetAllData();
                    break;

                case clsDoctor.enMode.Failed:
                    MessageBox.Show("فشل حفظ بيانات الطبيب");
                    break;
            }
        }
        //private async Task SaveDoctor()
        //{
        //    if (!IsPasswordMatch)
        //    {
        //        MessageBox.Show("كلمة المرور غير متطابقة، يرجى التأكد قبل الحفظ النهائي");
        //        CurrentTabIndex = 1; // إرجاع المستخدم لتبويب الحساب لتصحيح الخطأ
        //        return;
        //    }

        //    bool success = await Task.Run(() => SelectedDoctor.Save());
        //    if (success)
        //    {
        //        MessageBox.Show("تم حفظ الطبيب بنجاح");
        //        await LoadDoctors();
        //        ResetAllData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("فشل حفظ بيانات الطبيب");
        //    }
        //}
        private void ExecuteNext(object p) => CurrentTabIndex++;
        private bool CanExecuteNext(object p) => CurrentTabIndex < 2;
        private void ExecuteBack(object p) => CurrentTabIndex--;
        private bool CanExecuteBack(object p) => CurrentTabIndex > 0;
    }
}