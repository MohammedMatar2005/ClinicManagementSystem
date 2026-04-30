using System;
using System.Collections.ObjectModel;
using System.Data;
using ClinicBusiness;

namespace ClinicBusiness
{

    public class clsAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // --- خصائص الجدول الأساسي (للحفظ والتعديل) ---
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

        // --- خصائص العرض (تأتي من الـ View فقط عند العرض في الجدول) ---
        public string StatusName { get; set; }
        public string PatientFullName { get; set; }
        public string PatientPhone { get; set; }
        public string DoctorFullName { get; set; }

        // 1. Constructor الافتراضي
        public clsAppointment()
        {
            this.AppointmentId = -1;
            this.AppointmentDate = DateTime.Now;
            this.StatusId = 1;
            this.IsActive = true;
            this.Mode = enMode.AddNew;
        }

        // 2. Constructor خاص لوضع التعديل
        private clsAppointment(int appointmentId, int patientId, int doctorId, DateTime appointmentDate,
                               string reason, int statusId, string notes, DateTime createdDate,
                               DateTime updatedDate, bool isActive)
        {
            this.AppointmentId = appointmentId;
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.AppointmentDate = appointmentDate;
            this.ReasonForVisit = reason;
            this.StatusId = statusId;
            this.Notes = notes;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.IsActive = isActive;
            this.Mode = enMode.Update;
        }

        // 3. البحث عن موعد
        public static clsAppointment Find(int appointmentId)
        {
            int patientId = -1, doctorId = -1, statusId = -1;
            string reason = "", notes = "";
            DateTime appDate = DateTime.Now, createdDate = DateTime.Now, updatedDate = DateTime.Now;
            bool isActive = false;

            bool isFound = clsAppointmentsData.GetAppointmentInfoByID(
                appointmentId, ref patientId, ref doctorId, ref appDate,
                ref reason, ref statusId, ref notes, ref createdDate, ref updatedDate, ref isActive);

            return isFound ? new clsAppointment(appointmentId, patientId, doctorId, appDate,
                             reason, statusId, notes, createdDate, updatedDate, isActive) : null;
        }

        // 4. الحفظ (إضافة أو تعديل)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew()) { Mode = enMode.Update; return true; }
                    return false;
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }

        private bool _AddNew()
        {
            this.AppointmentId = clsAppointmentsData.AddNewAppointment(
                this.PatientId, this.DoctorId, this.AppointmentDate, this.ReasonForVisit,
                this.StatusId, this.Notes, this.CreatedDate, this.UpdatedDate, this.IsActive);
            return (this.AppointmentId != -1);
        }

        private bool _Update()
        {
            return clsAppointmentsData.UpdateAppointment(
                this.AppointmentId, this.PatientId, this.DoctorId, this.AppointmentDate,
                this.ReasonForVisit, this.StatusId, this.Notes, this.CreatedDate,
                this.UpdatedDate, this.IsActive);
        }

        // --- ميثودات ثابتة للقوائم ---
        public static ObservableCollection<clsAppointment> GetAllAppointments()
         => clsAppointmentsData.GetAllAppointments()
                               .ToObservableCollection<clsAppointment>();

        public static bool Delete(int id) => clsAppointmentsData.DeleteAppointment(id);

        public static bool IsExist(int id) => clsAppointmentsData.IsAppointmentExist(id);
    }
}