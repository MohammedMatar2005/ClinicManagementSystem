using ClinicBusiness;
using ClinicManagementApplication.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ClinicManagementApplication.ViewModels
{
    public class AppointmentsViewModel : BaseViewModel
    {
        private clsAppointment _appointment = new clsAppointment();

        // ====== Properties ======

        public ObservableCollection<clsPatient> Patients { get; }
            = new ObservableCollection<clsPatient>();

        public ObservableCollection<clsDoctor> Doctors { get; set; }
            = new ObservableCollection<clsDoctor>();

        private ObservableCollection<clsAppointment> _appointments
            = new ObservableCollection<clsAppointment>();
        public ObservableCollection<clsAppointment> Appointments
        {
            get => _appointments;
            set { _appointments = value; OnPropertyChanged(); }
        }

        private clsPatient _selectedPatient;
        public clsPatient SelectedPatient
        {
            get => _selectedPatient;
            set
            {
                _selectedPatient = value;
                OnPropertyChanged();
                PatientId = _selectedPatient?.PatientId ?? -1;
            }
        }

        private clsDoctor _selectedDoctor;
        public clsDoctor SelectedDoctor
        {
            get => _selectedDoctor;
            set
            {
                _selectedDoctor = value;
                OnPropertyChanged();
                DoctorId = _selectedDoctor?.DoctorId ?? -1;
            }
        }

        private int _patientId = -1;
        public int PatientId
        {
            get => _patientId;
            set { _patientId = value; OnPropertyChanged(); }
        }

        private int _doctorId = -1;
        public int DoctorId
        {
            get => _doctorId;
            set { _doctorId = value; OnPropertyChanged(); }
        }

        private int _statusId = 1;
        public int StatusId
        {
            get => _statusId;
            set { _statusId = value; OnPropertyChanged(); }
        }

        private string _appointmentTime = DateTime.Now.ToString("HH:mm");
        public string AppointmentTime
        {
            get => _appointmentTime;
            set { _appointmentTime = value; OnPropertyChanged(); }
        }

        private bool _isActive = true;
        public bool IsActive
        {
            get => _isActive;
            set { _isActive = value; OnPropertyChanged(); }
        }

        public DateTime AppointmentDate
        {
            get => _appointment.AppointmentDate;
            set { _appointment.AppointmentDate = value; OnPropertyChanged(); }
        }

        public DateTime UpdatedDate
        {
            get => _appointment.UpdatedDate;
            set { _appointment.UpdatedDate = value; OnPropertyChanged(); }
        }

        public string PatientFullName
        {
            get => _appointment.PatientFullName;
            set { _appointment.PatientFullName = value; OnPropertyChanged(); }
        }

        public string DoctorFullName
        {
            get => _appointment.DoctorFullName;
            set { _appointment.DoctorFullName = value; OnPropertyChanged(); }
        }

        public string StatusName
        {
            get => _appointment.StatusName;
            set { _appointment.StatusName = value; OnPropertyChanged(); }
        }

        public string PatientPhone
        {
            get => _appointment.PatientPhone;
            set { _appointment.PatientPhone = value; OnPropertyChanged(); }
        }

        public string Notes
        {
            get => _appointment.Notes;
            set { _appointment.Notes = value; OnPropertyChanged(); }
        }

        public string ReasonForVisit
        {
            get => _appointment.ReasonForVisit;
            set { _appointment.ReasonForVisit = value; OnPropertyChanged(); }
        }

        // ====== Commands ======

        public ICommand SaveCommand { get; }
        public ICommand LoadDataCommand { get; }
        public ICommand RefreshCommand { get; }

        // ====== Constructor ======

        public AppointmentsViewModel()
        {
            if (System.ComponentModel.DesignerProperties
                    .GetIsInDesignMode(new DependencyObject())) return;

            // الصح: نلف async Task في RelayCommand بشكل صحيح
            SaveCommand = new RelayCommand(async _ => await SaveAppointmentAsync());
            LoadDataCommand = new RelayCommand(async _ => await LoadInitialDataAsync());
            RefreshCommand = new RelayCommand(async _ => await LoadInitialDataAsync());

            AppointmentDate = DateTime.Now;
        }

        // ====== Methods ======

        private async Task LoadInitialDataAsync()
        {
            IsLoading = true;
            try
            {
                // قبل
                // var dtApps = await Task.Run(() => clsAppointment.GetAllAppointments());
                // Appointments = DataTableConverter.ToObservableCollection<clsAppointment>(dtApps);

                // بعد ✅
                Appointments = await Task.Run(() => clsAppointment.GetAllAppointments());

                // قبل
                // var dtPts = await Task.Run(() => clsPatient.GetAllPatients());
                // var pts = DataTableConverter.ToObservableCollection<clsPatient>(dtPts);

                // بعد ✅
                var pts = await Task.Run(() => clsPatient.GetAllPatients());
                Patients.Clear();
                foreach (var p in pts) Patients.Add(p);

                // قبل
                // var dtDrs = await Task.Run(() => clsDoctor.GetAllDoctors());
                // var drs = DataTableConverter.ToObservableCollection<clsDoctor>(dtDrs);

                // بعد ✅
                var drs = await Task.Run(() => clsDoctor.GetAllDoctors());
                Doctors.Clear();
                foreach (var d in drs) Doctors.Add(d);
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
        private async Task SaveAppointmentAsync()
        {
            clsAppointment newAppointment = new clsAppointment
            {
                PatientId = PatientId,
                DoctorId = DoctorId,
                AppointmentDate = AppointmentDate,
                //AppointmentTime = AppointmentTime,
                StatusId = StatusId,
                Notes = Notes,
                ReasonForVisit = ReasonForVisit
            };
        }

        private void ClearFields()
        {
            SelectedPatient = null;  // يصفّر ComboBox تلقائياً
            DoctorId = -1;
            AppointmentDate = DateTime.Now;
            AppointmentTime = DateTime.Now.ToString("HH:mm");
            StatusId = 1;
            Notes = "";
            _appointment = new clsAppointment();
        }
    }
}
