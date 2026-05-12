    using System;
    using System.Data;
    using ClinicDataAccess;

    namespace ClinicBusiness
    {
        public class clsAppointment
        {
            public enum enMode { AddNew = 0, Update = 1 }
            public enMode Mode { get; set; }

            public int AppointmentId { get; set; }
            public int PatientId { get; set; }
            public int DoctorId { get; set; }
            public int StatusId { get; set; }
            public DateTime AppointmentDate { get; set; }
            public string ReasonForVisit { get; set; }
            public string Notes { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }
            public bool IsActive { get; set; }

            public string PatientFullName { get; private set; }
            public string DoctorFullName { get; private set; }
            public string StatusName { get; set; }

        // =========================
        // Constructor (AddNew)
        // =========================
        public clsAppointment()
            {
                AppointmentId = -1;
                PatientId = -1;
                DoctorId = -1;
                StatusId = 1;

                AppointmentDate = DateTime.Now;

                ReasonForVisit = string.Empty;
                Notes = string.Empty;

                CreatedDate = DateTime.Now;
                UpdatedDate = DateTime.Now;

                IsActive = true;

                Mode = enMode.AddNew;
            }

        // =========================
        // Constructor (Update)
        // =========================
        private clsAppointment(int appointmentId,
                               int patientId,
                               string patientFullName,
                               int doctorId,
                               string doctorFullName,
                               DateTime appointmentDate,
                               string reasonForVisit,
                               int statusId,
                               string statusName,
                               string notes,
                               DateTime createdDate,
                               DateTime updatedDate,
                               bool isActive)
        {
            this.AppointmentId = appointmentId;
            this.PatientId = patientId;
            this.PatientFullName = patientFullName; // تخزين الاسم
            this.DoctorId = doctorId;
            this.DoctorFullName = doctorFullName; // تخزين الاسم
            this.AppointmentDate = appointmentDate;
            this.ReasonForVisit = reasonForVisit;
            this.StatusId = statusId;
            this.StatusName = statusName; // تخزين حالة الموعد نصياً
            this.Notes = notes;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.IsActive = isActive;
            this.Mode = enMode.Update;
        }

        // =========================
        // Find
        // =========================
        public static clsAppointment Find(int id)
            {
                int patientId = -1, doctorId = -1, statusId = -1;

                DateTime appDate = DateTime.MinValue;
                DateTime created = DateTime.MinValue;
                DateTime updated = DateTime.MinValue;

                bool isActive = false;

                string reason = string.Empty;
                string notes = string.Empty;

                string DoctorFullName = string.Empty;
                string PatientFullName = string.Empty;
                string StatusName = string.Empty;   

                bool found = clsAppointmentsData.GetAppointmentById(
                    id,
                    ref patientId,
                    ref PatientFullName,
                    ref doctorId,
                    ref DoctorFullName,
                    ref appDate,
                    ref reason,
                    ref statusId,
                    ref StatusName,
                    ref notes,
                    ref created,
                    ref updated,
                    ref isActive);

                if (!found)
                    return null;

                return new clsAppointment(
                    id,
                    patientId,
                    PatientFullName,
                    doctorId,
                    DoctorFullName,
                    appDate,
                    reason,
                    statusId,
                    StatusName,
                    notes,
                    created,
                    updated,
                    isActive);
            }

            // =========================
            // Add
            // =========================
            private bool _AddNewAppointment()
            {
                AppointmentId = clsAppointmentsData.AddNewAppointment(
                    PatientId,
                    DoctorId,
                    AppointmentDate,
                    ReasonForVisit,
                    StatusId,
                    Notes,
                    IsActive
                );

                if (AppointmentId != -1)
                {
                    CreatedDate = DateTime.Now;
                    UpdatedDate = DateTime.Now;
                    return true;
                }

                return false;
            }

            // =========================
            // Update
            // =========================
            private bool _UpdateAppointment()
            {
                UpdatedDate = DateTime.Now;

                return clsAppointmentsData.UpdateAppointment(
                    AppointmentId,
                    PatientId,
                    DoctorId,
                    AppointmentDate,
                    ReasonForVisit,
                    StatusId,
                    Notes,
                    IsActive
                );
            }

            // =========================
            // Save
            // =========================
            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewAppointment())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        return false;

                    case enMode.Update:
                        return _UpdateAppointment();

                    default:
                        return false;
                }
            }

            // =========================
            // Delete
            // =========================
            public static bool Delete(int id)
                => clsAppointmentsData.DeleteAppointment(id);

     
            // =========================
            // Get All 
            // =========================
            public static DataTable GetAll()
                => clsAppointmentsData.GetAllAppointments();

            // =========================
            // Filters
            // =========================
            public static DataTable GetByPatient(int patientId)
                => clsAppointmentsData.GetAppointmentsByPatient(patientId);

            public static DataTable GetByDoctor(int doctorId)
                => clsAppointmentsData.GetAppointmentsByDoctor(doctorId);

            public static DataTable GetByDateRange(DateTime start, DateTime end)
                => clsAppointmentsData.GetAppointmentsByDateRange(start, end);
        }
    }