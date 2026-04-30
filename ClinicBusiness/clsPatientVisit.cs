
using System;
using System.Collections.ObjectModel;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{

    public class clsPatientVisit
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string BloodPressure { get; set; }
        public decimal Temperature { get; set; }
        public int HeartRate { get; set; }
        public int RespiratoryRate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsPatientVisit()
        {
            this.VisitId = -1;
            // تعيين القيم الافتراضية هنا
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsPatientVisit(int VisitId, int AppointmentId, int PatientId, int DoctorId, DateTime VisitDate, string Symptoms, string Diagnosis, string TreatmentPlan, string BloodPressure, decimal Temperature, int HeartRate, int RespiratoryRate, decimal Weight, decimal Height, string Notes, DateTime CreatedDate)
        {
            this.VisitId = VisitId;
            this.AppointmentId = AppointmentId;
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
            this.VisitDate = VisitDate;
            this.Symptoms = Symptoms;
            this.Diagnosis = Diagnosis;
            this.TreatmentPlan = TreatmentPlan;
            this.BloodPressure = BloodPressure;
            this.Temperature = Temperature;
            this.HeartRate = HeartRate;
            this.RespiratoryRate = RespiratoryRate;
            this.Weight = Weight;
            this.Height = Height;
            this.Notes = Notes;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsPatientVisit Find(int VisitId)
        {
            int AppointmentId = -1;
            int PatientId = -1;
            int DoctorId = -1;
            DateTime VisitDate = DateTime.Now;
            string Symptoms = "";
            string Diagnosis = "";
            string TreatmentPlan = "";
            string BloodPressure = "";
            decimal Temperature = 0;
            int HeartRate = -1;
            int RespiratoryRate = -1;
            decimal Weight = 0;
            decimal Height = 0;
            string Notes = "";
            DateTime CreatedDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_PatientVisits_GetByID
            bool isFound = clsPatientVisitsData.GetPatientVisitInfoByID(VisitId, ref AppointmentId, ref PatientId, ref DoctorId, ref VisitDate, ref Symptoms, ref Diagnosis, ref TreatmentPlan, ref BloodPressure, ref Temperature, ref HeartRate, ref RespiratoryRate, ref Weight, ref Height, ref Notes, ref CreatedDate);

            if (isFound)
                return new clsPatientVisit(VisitId, AppointmentId, PatientId, DoctorId, VisitDate, Symptoms, Diagnosis, TreatmentPlan, BloodPressure, Temperature, HeartRate, RespiratoryRate, Weight, Height, Notes, CreatedDate);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatientVisit())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePatientVisit();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewPatientVisit()
        {
            // استدعاء الـ DAL التي تستخدم SP_PatientVisits_Add
            this.VisitId = clsPatientVisitsData.AddNewPatientVisit(this.AppointmentId, this.PatientId, this.DoctorId, this.VisitDate, this.Symptoms, this.Diagnosis, this.TreatmentPlan, this.BloodPressure, this.Temperature, this.HeartRate, this.RespiratoryRate, this.Weight, this.Height, this.Notes, this.CreatedDate);
            return (this.VisitId != -1);
        }

        private bool _UpdatePatientVisit()
        {
            // استدعاء الـ DAL التي تستخدم SP_PatientVisits_Update
            return clsPatientVisitsData.UpdatePatientVisit(this.VisitId, this.AppointmentId, this.PatientId, this.DoctorId, this.VisitDate, this.Symptoms, this.Diagnosis, this.TreatmentPlan, this.BloodPressure, this.Temperature, this.HeartRate, this.RespiratoryRate, this.Weight, this.Height, this.Notes, this.CreatedDate);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsPatientVisit> GetAllPatientVisits()
        {
            return clsPatientVisitsData.GetAllPatientVisits().ToObservableCollection<clsPatientVisit>();
        }

        public static bool Delete(int VisitId)
        {
            return clsPatientVisitsData.DeletePatientVisit(VisitId);
        }

        public static bool IsExist(int VisitId)
        {
            return clsPatientVisitsData.IsPatientVisitExist(VisitId);
        }
    }
}