using ClinicBusiness;
using ClinicDataAccess;
using ClinicManagementApplication.Infrastructure;
using ClinicProject.Models;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp3.Models;

namespace ClinicManagementApplication.ViewModels
{
    public class DoctorsViewModel : BaseViewModel
    {
        #region Private Members

        private ObservableCollection<DoctorsModel> _doctors;
        private DoctorsModel _selectedDoctor;
        private DoctorsModel _currentDoctor;

        private ObservableCollection<PersonsModel> _people;
        private PersonsModel _selectedPerson;

        private ObservableCollection<UsersModel> _users;
        private UsersModel _selectedUser;

        private string _confirmPassword;
        private bool _isActive = true;
        private int _mainTabIndex = 0;
        private int _registrationStepIndex = 0;

        #endregion

        #region Properties

        public ObservableCollection<DoctorsModel> Doctors
        {
            get => _doctors;
            set => SetProperty(ref _doctors, value);
        }

        public DoctorsModel SelectedDoctor
        {
            get => _selectedDoctor;
            set
            {
                if (SetProperty(ref _selectedDoctor, value))
                {
                    PrepareForUpdate();
                }
            }
        }

        public DoctorsModel CurrentDoctor
        {
            get => _currentDoctor;
            set => SetProperty(ref _currentDoctor, value);
        }

        public ObservableCollection<PersonsModel> PeopleList
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        public PersonsModel SelectedPerson
        {
            get => _selectedPerson;
            set => SetProperty(ref _selectedPerson, value);
        }

        public ObservableCollection<UsersModel> UsersList
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        public UsersModel SelectedUser
        {
            get => _selectedUser;
            set => SetProperty(ref _selectedUser, value);
        }

        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        #region UI Logic Properties

        public int MainTabIndex
        {
            get => _mainTabIndex;
            set
            {
                if (SetProperty(ref _mainTabIndex, value))
                {
                    OnPropertyChanged(nameof(IsRegistrationTabSelected));
                    OnPropertyChanged(nameof(IsListTabSelected));
                }
            }
        }

        public bool IsRegistrationTabSelected
        {
            get => MainTabIndex == 0;
            set { if (value) MainTabIndex = 0; }
        }

        public bool IsListTabSelected
        {
            get => MainTabIndex == 1;
            set { if (value) MainTabIndex = 1; }
        }

        public string RegistrationStepTitle
        {
            get
            {
                switch (RegistrationStepIndex)
                {
                    case 0:
                        return "بيانات الشخص الأساسية";
                    case 1:
                        return "إعدادات حساب المستخدم";
                    case 2:
                        return "البيانات المهنية والراتب";
                    default:
                        return "";
                }
            }
        }

        // رقم المرحلة للعرض (1، 2، 3)
        public int CurrentRegistrationStep => RegistrationStepIndex + 1;

        public int RegistrationStepIndex
        {
            get => _registrationStepIndex;
            set
            {
                if (SetProperty(ref _registrationStepIndex, value))
                {
                    // تحديث رؤية الأزرار وعناوين المراحل
                    OnPropertyChanged(nameof(NextBtnVisible));
                    OnPropertyChanged(nameof(BackBtnVisible));
                    OnPropertyChanged(nameof(SaveBtnVisible));
                    OnPropertyChanged(nameof(RegistrationStepTitle));
                    OnPropertyChanged(nameof(CurrentRegistrationStep));
                }
            }
        }
        public Visibility NextBtnVisible => (RegistrationStepIndex < 2) ? Visibility.Visible : Visibility.Collapsed;
        public Visibility BackBtnVisible => (RegistrationStepIndex > 0) ? Visibility.Visible : Visibility.Collapsed;
        public Visibility SaveBtnVisible => (RegistrationStepIndex == 2) ? Visibility.Visible : Visibility.Collapsed;

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                if (SetProperty(ref _confirmPassword, value))
                {
                    OnPropertyChanged(nameof(IsPasswordMatch));
                }
            }
        }

        public bool IsPasswordMatch =>
            !string.IsNullOrEmpty(SelectedUser?.PasswordHash) &&
            SelectedUser.PasswordHash == ConfirmPassword;
        #endregion

        #endregion

        #region Commands

        public ICommand SavePersonCommand { get; }
        public ICommand SaveUserCommand { get; }
        public ICommand SaveDoctorCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand RefreshCommand { get; }

        #endregion

        public DoctorsViewModel()
        {
            SavePersonCommand = new RelayCommand(async (p) => await ExecuteSavePerson(), (p) => CanSavePerson());
            SaveUserCommand = new RelayCommand(async (p) => await ExecuteSaveUser(), (p) => CanSaveUser());
            SaveDoctorCommand = new RelayCommand(async (p) => await ExecuteSaveDoctor(), (p) => CanSaveDoctor());

            ClearCommand = new RelayCommand((p) => ExecuteClear());
            NextCommand = new RelayCommand((p) => RegistrationStepIndex++, (p) => RegistrationStepIndex < 2);
            BackCommand = new RelayCommand((p) => RegistrationStepIndex--, (p) => RegistrationStepIndex > 0);
            RefreshCommand = new RelayCommand(async (p) => await LoadDoctors());

            LoadData();
            ExecuteClear();
        }

        #region Load Methods

        private void LoadData()
        {
            _ = LoadDoctors();
            _ = LoadPeople();
        }

        private async Task LoadDoctors()
        {
            IsLoading = true;
            try
            {
                DataTable dt = await Task.Run(() => clsDoctor.GetAll());
                Doctors = dt.ToObservableCollection<DoctorsModel>();
            }
            catch (Exception ex) { MessageBox.Show($"خطأ في تحميل الأطباء: {ex.Message}"); }
            finally { IsLoading = false; }
        }

        private async Task LoadPeople()
        {
            try
            {
                DataTable dt = await Task.Run(() => clsPeople.GetAll());
                PeopleList = dt.ToObservableCollection<PersonsModel>();
            }
            catch { /* Error Handling */ }
        }

        #endregion

        #region CRUD Operations

        private async Task ExecuteSavePerson()
        {
            IsLoading = true;
            try
            {
                // تحويل الموديل إلى فئة البزنس للحفظ
                clsPeople personBL = (SelectedPerson.PersonId == -1) ? new clsPeople() : clsPeople.Find(SelectedPerson.PersonId);

                personBL.FirstName = SelectedPerson.FirstName;
                personBL.SecondName = SelectedPerson.SecondName;
                personBL.ThirdName = SelectedPerson.ThirdName;

                personBL.LastName = SelectedPerson.LastName;
                personBL.Email = SelectedPerson.Email;
                personBL.Phone = SelectedPerson.Phone;
                personBL.Address = SelectedPerson.Address;
                personBL.DateOfBirth = SelectedPerson.DateOfBirth;
                personBL.Gender = SelectedPerson.Gender;
                personBL.NationalNumber = SelectedPerson.NationalNumber;

                if (await Task.Run(() => personBL.Save()))
                {
                    SelectedPerson.PersonId = personBL.PersonId; // تحديث الـ ID بعد الحفظ
                    MessageBox.Show("تم حفظ البيانات الشخصية بنجاح.");
                    RegistrationStepIndex = 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            finally { IsLoading = false; }
        }

        private async Task ExecuteSaveUser()
        {
            if (!IsPasswordMatch) { MessageBox.Show("كلمات المرور غير متطابقة!"); return; }

            IsLoading = true;
            try
            {
                clsUser userBL = (SelectedUser.UserId == -1) ? new clsUser() : clsUser.Find(SelectedUser.UserId);

                userBL.PersonId = SelectedPerson.PersonId;
                userBL.Username = SelectedUser.Username;
                userBL.PasswordHash = SelectedUser.PasswordHash;
                userBL.RoleId = SelectedUser.RoleId;
                userBL.IsActive = SelectedUser.IsActive;
                userBL.CreatedDate = DateTime.Now;
                

                if (await Task.Run(() => userBL.Save()))
                {
                    SelectedUser.UserId = userBL.UserId;
                    MessageBox.Show("تم إنشاء الحساب بنجاح.");
                    RegistrationStepIndex = 2;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { IsLoading = false; }
        }

        private async Task ExecuteSaveDoctor()
        {
            IsLoading = true;
            try
            {
                clsDoctor doctorBL = (CurrentDoctor.DoctorId == -1) ? new clsDoctor() : clsDoctor.Find(CurrentDoctor.DoctorId);

                doctorBL.UserId = SelectedUser.UserId;
                doctorBL.Specialization = CurrentDoctor.Specialization;
                doctorBL.LicenseNumber = CurrentDoctor.LicenseNumber;
                doctorBL.Salary = CurrentDoctor.Salary;
                doctorBL.ExperienceYears = CurrentDoctor.ExperienceYears;
                doctorBL.OfficeLocation = CurrentDoctor.OfficeLocation;
                doctorBL.IsActive = true;

                if (await Task.Run(() => doctorBL.Save()))
                {
                    MessageBox.Show("تم تسجيل الطبيب بنجاح!");
                    await LoadDoctors();
                    ExecuteClear();
                    MainTabIndex = 1; // الانتقال لقائمة الأطباء
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { IsLoading = false; }
        }

        #endregion

        private bool CanSavePerson() =>  SelectedPerson != null && !string.IsNullOrEmpty(SelectedPerson.FirstName);
        private bool CanSaveUser() =>
            SelectedUser != null &&
            !string.IsNullOrEmpty(SelectedUser.Username) &&
            SelectedUser.RoleId > 0 && 
            SelectedPerson?.PersonId != -1;

        private bool CanSaveDoctor() => CurrentDoctor != null && SelectedUser?.UserId != -1;

        private void ExecuteClear()
        {
            CurrentDoctor = new DoctorsModel { DoctorId = -1 };
            SelectedPerson = new PersonsModel { PersonId = -1 };
            SelectedUser = new UsersModel { UserId = -1, IsActive = true };
            ConfirmPassword = string.Empty;
            RegistrationStepIndex = 0;
            SelectedDoctor = null;
        }

        private void PrepareForUpdate()
        {
            if (SelectedDoctor == null) return;

            clsDoctor doctorBL = clsDoctor.Find(SelectedDoctor.DoctorId);
            if (doctorBL != null)
            {
                // تعبئة بيانات الطبيب
                CurrentDoctor = SelectedDoctor;

                // جلب وتحويل بيانات المستخدم
                clsUser userBL = clsUser.Find(doctorBL.UserId);
                if (userBL != null)
                {
                    SelectedUser = new UsersModel
                    {
                        UserId = userBL.UserId,
                        Username = userBL.Username,
                        PasswordHash = userBL.PasswordHash,
                        PersonId = userBL.PersonId,
                        IsActive = userBL.IsActive
                    };

                    // جلب وتحويل بيانات الشخص
                    clsPeople personBL = clsPeople.Find(userBL.PersonId);
                    if (personBL != null)
                    {
                        SelectedPerson = new PersonsModel
                        {
                            PersonId = personBL.PersonId,
                            FirstName = personBL.FirstName,
                            LastName = personBL.LastName,
                            Email = personBL.Email,
                            Phone = personBL.Phone,
                            Address = personBL.Address,
                            Gender = personBL.Gender,
                            DateOfBirth = personBL.DateOfBirth
                        };
                    }
                }

                ConfirmPassword = SelectedUser?.PasswordHash;
                MainTabIndex = 0; // الانتقال لتبويب التعديل
                RegistrationStepIndex = 0;
            }
        }
    }
}