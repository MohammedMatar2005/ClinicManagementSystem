using ClinicBusiness;
//using ClinicManagementApplication.Converters;
using ClinicManagementApplication.Infrastructure;
using ClinicProject.Models;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace ClinicProject.ViewModels
{
    public class AppointmentsViewModel : BaseViewModel
    {
        #region Private Members

        private ObservableCollection<AppointmentModel> _appointments;
        private AppointmentModel _selectedAppointment;
        private AppointmentModel _currentAppointment;

        private ObservableCollection<clsPatient> _patients;
        private clsPatient _selectedPatient;

        private ObservableCollection<clsDoctor> _doctors;
        private clsDoctor _selectedDoctor;

        private bool _isActive = true;

        #endregion

        #region Properties

        public ObservableCollection<AppointmentModel> Appointments
        {
            get => _appointments;
            set => SetProperty(ref _appointments, value);
        }

        public AppointmentModel SelectedAppointment
        {
            get => _selectedAppointment;
            set
            {
                if (SetProperty(ref _selectedAppointment, value))
                {
                    PrepareForUpdate();
                }
            }
        }

        public AppointmentModel CurrentAppointment
        {
            get => _currentAppointment;
            set => SetProperty(ref _currentAppointment, value);
        }

        public ObservableCollection<clsPatient> Patients
        {
            get => _patients;
            set => SetProperty(ref _patients, value);
        }

        public clsPatient SelectedPatient
        {
            get => _selectedPatient;
            set
            {
                if (SetProperty(ref _selectedPatient, value))
                {
                    if (CurrentAppointment != null && value != null)
                    {
                        CurrentAppointment.PatientId = value.PatientId;
                        OnPropertyChanged(nameof(CurrentAppointment));
                    }
                }
            }
        }

        public ObservableCollection<clsDoctor> Doctors
        {
            get => _doctors;
            set => SetProperty(ref _doctors, value);
        }

        public clsDoctor SelectedDoctor
        {
            get => _selectedDoctor;
            set
            {
                if (SetProperty(ref _selectedDoctor, value))
                {
                    if (CurrentAppointment != null && value != null)
                    {
                        CurrentAppointment.DoctorId = value.DoctorId;
                        OnPropertyChanged(nameof(CurrentAppointment));
                    }
                }
            }
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (SetProperty(ref _isActive, value))
                {
                    FilterAppointments();
                }
            }
        }

        #endregion

        #region Commands

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand RefreshCommand { get; }
     

        #endregion

        public AppointmentsViewModel()
        {
            SaveCommand = new RelayCommand(ExecuteSave, CanExecuteSave);
            DeleteCommand = new RelayCommand(ExecuteDelete, CanExecuteDelete);
            ClearCommand = new RelayCommand(ExecuteClear);
            RefreshCommand = new RelayCommand(p => LoadAppointments());

            LoadData();
            ExecuteClear(null);
        }

        #region Load Methods

        private void LoadData()
        {
            LoadPatients();
            LoadDoctors();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            DataTable dt = clsAppointment.GetAll();
           
            Appointments = dt.ToObservableCollection<AppointmentModel>();

            FilterAppointments();
        }

        private void FilterAppointments()
        {
            if (Appointments == null)
                return;

            if (!IsActive)
            {
                Appointments = clsAppointment
                    .GetAll().ToObservableCollection<AppointmentModel>();

                return;
            }

            ObservableCollection<AppointmentModel> filtered =
                new ObservableCollection<AppointmentModel>();

            foreach (var item in clsAppointment
                         .GetAll()
                         .ToObservableCollection<AppointmentModel>())
            {
                if (item.IsActive)
                    filtered.Add(item);
            }

            Appointments = filtered;
        }

        private void LoadPatients()
        {
            DataTable dt = clsPatient.GetAll();

            Patients = dt.ToObservableCollection<clsPatient>();
        }

        private void LoadDoctors()
        {
            DataTable dt = clsDoctor.GetAll();

            Doctors = dt.ToObservableCollection<clsDoctor>();
        }

        #endregion

        #region CRUD Operations

        private void ExecuteSave(object parameter)
        {
            if (!IsValid())
            {
                MessageBox.Show(
                    "الرجاء تعبئة جميع الحقول المطلوبة",
                    "تنبيه",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            clsAppointment appointmentBL =
                CurrentAppointment.AppointmentId == -1
                ? new clsAppointment()
                : clsAppointment.Find(CurrentAppointment.AppointmentId);

            if (appointmentBL == null)
                return;

            appointmentBL.PatientId = CurrentAppointment.PatientId;
            appointmentBL.DoctorId = CurrentAppointment.DoctorId;
            appointmentBL.AppointmentDate = CurrentAppointment.AppointmentDate;
            appointmentBL.StatusId = CurrentAppointment.StatusId;
            appointmentBL.ReasonForVisit = CurrentAppointment.ReasonForVisit;
            appointmentBL.Notes = CurrentAppointment.Notes;
            appointmentBL.IsActive = CurrentAppointment.IsActive;
            appointmentBL.CreatedDate = DateTime.Now;
            appointmentBL.UpdatedDate = DateTime.Now;

            if (appointmentBL.Save())
            {
                MessageBox.Show(
                    "تم حفظ الموعد بنجاح",
                    "نجاح",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                LoadAppointments();
                ExecuteClear(null);
            }
            else
            {
                MessageBox.Show(
                    "فشل في عملية الحفظ",
                    "خطأ",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private bool CanExecuteSave(object parameter)
        {
            return CurrentAppointment != null;
        }

        private void ExecuteDelete(object parameter)
        {
            if (SelectedAppointment == null)
                return;

            MessageBoxResult result = MessageBox.Show(
                "هل أنت متأكد من حذف هذا الموعد؟",
                "تأكيد",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result != MessageBoxResult.Yes)
                return;

            if (clsAppointment.Delete(SelectedAppointment.AppointmentId))
            {
                MessageBox.Show(
                    "تم حذف الموعد بنجاح",
                    "نجاح",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                LoadAppointments();
                ExecuteClear(null);
            }
        }

        private bool CanExecuteDelete(object parameter)
        {
            return SelectedAppointment != null;
        }

        private void ExecuteClear(object parameter)
        {
            CurrentAppointment = new AppointmentModel
            {
                AppointmentId = -1,
                AppointmentDate = DateTime.Now,
                IsActive = true,
                StatusId = 1
            };

            SelectedAppointment = null;
            SelectedPatient = null;
            SelectedDoctor = null;
        }

        private void PrepareForUpdate()
        {
            if (SelectedAppointment == null)
                return;

            CurrentAppointment = new AppointmentModel
            {
                AppointmentId = SelectedAppointment.AppointmentId,
                PatientId = SelectedAppointment.PatientId,
                DoctorId = SelectedAppointment.DoctorId,
                AppointmentDate = SelectedAppointment.AppointmentDate,
                StatusId = SelectedAppointment.StatusId,
                ReasonForVisit = SelectedAppointment.ReasonForVisit,
                Notes = SelectedAppointment.Notes,
                IsActive = SelectedAppointment.IsActive
            };

            foreach (var patient in Patients)
            {
                if (patient.PatientId == CurrentAppointment.PatientId)
                {
                    SelectedPatient = patient;
                    break;
                }
            }

            foreach (var doctor in Doctors)
            {
                if (doctor.DoctorId == CurrentAppointment.DoctorId)
                {
                    SelectedDoctor = doctor;
                    break;
                }
            }
        }

        #endregion

        #region Validation

        private bool IsValid()
        {
            return CurrentAppointment != null
                   && CurrentAppointment.PatientId > 0
                   && CurrentAppointment.DoctorId > 0
                   && !string.IsNullOrWhiteSpace(CurrentAppointment.ReasonForVisit)
                   && CurrentAppointment.AppointmentDate >= DateTime.Today;
        }

        #endregion
    }
}