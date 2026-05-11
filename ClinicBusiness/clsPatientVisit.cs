using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsPatientVisit
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; }

        // =========================
        // Properties
        // =========================
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string BloodPressure { get; set; }

        // استخدام Nullable Types لتتوافق مع قاعدة البيانات والـ DataAccess
        public decimal? Temperature { get; set; }
        public int? HeartRate { get; set; }
        public int? RespiratoryRate { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }

        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }

        // =========================
        // Constructors
        // =========================

        // Constructor for AddNew
        public clsPatientVisit()
        {
            this.VisitId = -1;
            this.AppointmentId = -1;
            this.VisitDate = DateTime.Now;
            this.Symptoms = string.Empty;
            this.Diagnosis = string.Empty;
            this.TreatmentPlan = string.Empty;
            this.BloodPressure = string.Empty;
            this.Temperature = null; // القيمة الافتراضية null بدل 0
            this.HeartRate = null;
            this.RespiratoryRate = null;
            this.Weight = null;
            this.Height = null;
            this.Notes = string.Empty;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        // Constructor for Update (Internal/Private)
        private clsPatientVisit(int VisitId, int AppointmentId, string PatientFullName, string DoctorFullName, DateTime VisitDate, string Symptoms,
            string Diagnosis, string TreatmentPlan, string BloodPressure, decimal? Temperature,
            int? HeartRate, int? RespiratoryRate, decimal? Weight, decimal? Height, string Notes, DateTime CreatedDate)
        {
            this.VisitId = VisitId;
            this.AppointmentId = AppointmentId;
            this.PatientFullName = PatientFullName;
            this.DoctorFullName = DoctorFullName;
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

        // =========================
        // Methods
        // =========================

        public static clsPatientVisit Find(int VisitId)
        {
            int AppointmentId = -1;
            DateTime VisitDate = DateTime.Now;
            string Symptoms = "", Diagnosis = "", TreatmentPlan = "", BloodPressure = "", Notes = "";
            decimal? Temperature = null, Weight = null, Height = null;
            int? HeartRate = null, RespiratoryRate = null;
            DateTime CreatedDate = DateTime.Now;
            string PatientFullName = "", DoctorFullName = "";

            bool found = clsPatientVisitsData.GetPatientVisitInfoByID(
                VisitId, ref AppointmentId, ref PatientFullName, ref DoctorFullName, ref VisitDate, ref Symptoms, ref Diagnosis,
                ref TreatmentPlan, ref BloodPressure, ref Temperature, ref HeartRate,
                ref RespiratoryRate, ref Weight, ref Height, ref Notes, ref CreatedDate
            );

            if (found)
                return new clsPatientVisit(VisitId, AppointmentId, PatientFullName, DoctorFullName, VisitDate, Symptoms, Diagnosis,
                    TreatmentPlan, BloodPressure, Temperature, HeartRate, RespiratoryRate,
                    Weight, Height, Notes, CreatedDate);
            else
                return null;
        }

        private bool _Add()
        {
            this.VisitId = clsPatientVisitsData.AddNewPatientVisit(
                this.AppointmentId, this.VisitDate, this.Symptoms, this.Diagnosis,
                this.TreatmentPlan, this.BloodPressure, this.Temperature, this.HeartRate,
                this.RespiratoryRate, this.Weight, this.Height, this.Notes
            );

            return (this.VisitId != -1);
        }

        private bool _Update()
        {
            return clsPatientVisitsData.UpdatePatientVisit(
                this.VisitId, this.AppointmentId, this.VisitDate, this.Symptoms,
                this.Diagnosis, this.TreatmentPlan, this.BloodPressure, this.Temperature,
                this.HeartRate, this.RespiratoryRate, this.Weight, this.Height, this.Notes
            );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool Delete(int VisitId)
        {
            return clsPatientVisitsData.DeletePatientVisit(VisitId);
        }

        public static DataTable GetAll()
        {
            return clsPatientVisitsData.GetAllPatientVisits();
        }

        public static bool IsExist(int VisitId)
        {
            return clsPatientVisitsData.IsPatientVisitExist(VisitId);
        }

        public static DataTable GetPatientHistory(int PatientId)
        {
            return clsPatientVisitsData.GetPatientHistory(PatientId);
        }
    }
}