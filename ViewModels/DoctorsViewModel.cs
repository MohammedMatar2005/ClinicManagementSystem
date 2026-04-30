    using ClinicBusiness;
    using System;
    using System.Collections.ObjectModel;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;
    using ClinicManagementApplication.Infrastructure;

    namespace ClinicManagementApplication.ViewModels
{
        public class DoctorsViewModel : BaseViewModel
        {
        // 1. قائمة الأطباء التي سيتم عرضها في الـ DataGrid
            
        private ObservableCollection<clsDoctor> _doctors = new ObservableCollection<clsDoctor>();
        public ObservableCollection<clsDoctor> Doctors
        {
            get => _doctors;
            set { _doctors = value; OnPropertyChanged(); }
        }
        // 2. الطبيب المختار (للحفظ أو التعديل أو المسح)
        private clsDoctor _selectedDoctor;
            public clsDoctor SelectedDoctor
            {
                get => _selectedDoctor;
                set
                {
                    _selectedDoctor = value;
                    OnPropertyChanged(nameof(SelectedDoctor));
                }
            }

            public string FullName
            {
                get
                {
                    return _selectedDoctor.FullName;
                
                }
          
            }

            private int _currentTabIndex = 0;
            public int CurrentTabIndex
            {
                get => _currentTabIndex;
                set
                {
                    _currentTabIndex = value;
                    OnPropertyChanged(nameof(CurrentTabIndex));
                    OnPropertyChanged(nameof(NextBtnVisible));
                    OnPropertyChanged(nameof(BackBtnVisible));
                    OnPropertyChanged(nameof(SaveBtnVisible));

                    // هذا السطر يجبر الـ WPF على إعادة تشغيل ميثود CanExecute للأزرار فوراً
                    CommandManager.InvalidateRequerySuggested();
                }
            }
            public Visibility NextBtnVisible => (CurrentTabIndex < 2) ? Visibility.Visible : Visibility.Collapsed;

            // خاصية التحكم بظهور زر "السابق" 
            public Visibility BackBtnVisible => (CurrentTabIndex > 0) ? Visibility.Visible : Visibility.Collapsed;

            // خاصية التحكم بظهور زر "حفظ" (يظهر فقط في آخر تاب)
            public Visibility SaveBtnVisible => (CurrentTabIndex == 2) ? Visibility.Visible : Visibility.Collapsed;

            public ICommand SaveCommand { get; }
            public ICommand ClearCommand { get; }



            public DoctorsViewModel()
            {
                // تهيئة طبيب جديد افتراضياً عند فتح الشاشة
                ResetSelectedDoctor();

                SaveCommand = new RelayCommand(async (p) => await SaveDoctor());
                ClearCommand = new RelayCommand((p) => ResetSelectedDoctor());




                NextCommand = new RelayCommand(ExecuteNext, CanExecuteNext);
                BackCommand = new RelayCommand(ExecuteBack, CanExecuteBack);
                // تحميل البيانات عند التشغيل
                _ = LoadDoctors();
            }

            private void ResetSelectedDoctor()
            {
                SelectedDoctor = new clsDoctor();

                // برجماتياً: يجب تهيئة الكائنات الداخلية لتجنب NullReference في الـ Binding
                if (SelectedDoctor.UserInfo == null)
                {
                    SelectedDoctor.UserInfo = new clsUser();
                    SelectedDoctor.UserInfo.PersonInfo = new clsPeople();
                }
            }

            private async Task LoadDoctors()
            {
                IsLoading = true;
                try
                {
                    Doctors = await Task.Run(() => clsDoctor.GetAllDoctors());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}",
                        "خطأ في النظام", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    IsLoading = false;
                }
            }
            private async Task SaveDoctor()
            {
                // التحقق من صحة البيانات (Validation) بشكل بسيط وبراجماتي
                if (string.IsNullOrWhiteSpace(SelectedDoctor.UserInfo?.PersonInfo?.FullName))
                {
                    MessageBox.Show("يرجى إدخال اسم الطبيب");
                    return;
                }

                IsLoading = true;
                try
                {
                    // 1. أولاً يجب حفظ بيانات الشخص والمستخدم (إذا كان نظامك يتطلب ذلك)
                    // سأفترض هنا أن ميثود Save داخل clsDoctor تتعامل مع الـ UserInfo داخلياً

                    bool success = await Task.Run(() => SelectedDoctor.Save());

                    if (success)
                    {
                        MessageBox.Show("تم حفظ بيانات الطبيب بنجاح");
                        await LoadDoctors(); // تحديث القائمة
                        ResetSelectedDoctor(); // تفريغ الحقول للإدخال الجديد
                    }
                    else
                    {
                        MessageBox.Show("فشل حفظ البيانات، يرجى التحقق من المدخلات");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ غير متوقع: {ex.Message}");
                }
                finally
                {
                    IsLoading = false;
                }
            }


            public ICommand NextCommand { get; }
            public ICommand BackCommand { get; }
        private void ExecuteNext()
        {
            // بما أن الزر لن يكون فعالاً إلا إذا كان IsValid=True، 
            // فالفحص هنا إضافي للأمان أو لعرض رسالة
            if (SelectedDoctor?.UserInfo?.PersonInfo?.IsValid == true)
            {
                CurrentTabIndex++;
                // تحديث حالة الأزرار بعد تغيير التاب
                CommandManager.InvalidateRequerySuggested();
            }
            else
            {
                MessageBox.Show("يرجى تصحيح الأخطاء أولاً (الحقول المطلوبة)");
            }
        }

        private bool CanExecuteNext()
        {
            if (SelectedDoctor?.UserInfo?.PersonInfo == null) return false;

            // تعطيل الزر إذا كنا في التاب الأول والبيانات غير مكتملة
            if (CurrentTabIndex == 0)
                return SelectedDoctor.UserInfo.PersonInfo.IsValid;

            // تعطيل الزر إذا كنا في التاب الثاني وبيانات المستخدم غير مكتملة
            if (CurrentTabIndex == 1)
                return SelectedDoctor.UserInfo.PersonInfo.IsValid;

            return CurrentTabIndex < 2;
        }

        // أضف ميثود في الـ ViewModel لاستدعائها عند تغيير أي نص في الحقول
        public void RefreshCommands()
        {
            CommandManager.InvalidateRequerySuggested();
        }
        private void ExecuteBack()
        {
            if (CurrentTabIndex > 0)
            {
                CurrentTabIndex--;
                CommandManager.InvalidateRequerySuggested();
            }
        }

        private bool CanExecuteBack()
        {
            return CurrentTabIndex > 0;
        }
    }
    }