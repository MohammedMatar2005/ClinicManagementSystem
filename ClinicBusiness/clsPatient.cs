using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsPatient
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; }

        // =========================
        // Properties
        // =========================
        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string MedicalHistory { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        //public string FullName => GetFullName(); // خاصية إضافية اختيارية

        //private string GetFullName()
        //{
        //    // يمكنك تخصيص هذا الجزء حسب أعمدة الاسم لديك
        //    return "";
        //}

        // =========================
        // Constructor (AddNew)
        // =========================
        public clsPatient()
        {
            this.PatientId = -1;
            this.PersonId = 0;
            this.EmergencyContact = string.Empty;
            this.EmergencyPhone = string.Empty;
            this.BloodType = string.Empty;
            this.Allergies = string.Empty;
            this.MedicalHistory = string.Empty;
            this.IsActive = false;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        // =========================
        // Constructor (Update)
        // =========================
        private clsPatient(int PatientId, int PersonId, string EmergencyContact, string EmergencyPhone, string BloodType, string Allergies, string MedicalHistory, bool IsActive, DateTime CreatedDate)
        {
            this.PatientId = PatientId;
            this.PersonId = PersonId;
            this.EmergencyContact = EmergencyContact;
            this.EmergencyPhone = EmergencyPhone;
            this.BloodType = BloodType;
            this.Allergies = Allergies;
            this.MedicalHistory = MedicalHistory;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        // =========================
        // Find
        // =========================
        public static clsPatient Find(int PatientId)
        {
            int PersonId = -1;
            string EmergencyContact = "";
            string EmergencyPhone = "";
            string BloodType = "";
            string Allergies = "";
            string MedicalHistory = "";
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;

            bool found = clsPatientsData.GetPatientById(
                PatientId,
                ref PersonId, ref EmergencyContact, ref EmergencyPhone, ref BloodType, ref Allergies, ref MedicalHistory, ref IsActive, ref CreatedDate
            );

            if (!found)
                return null;

            return new clsPatient(
                PatientId,
                PersonId, EmergencyContact, EmergencyPhone, BloodType, Allergies, MedicalHistory, IsActive, CreatedDate
            );
        }

        // =========================
        // Add
        // =========================
        private bool _Add()
        {
            this.PatientId = clsPatientsData.AddNewPatient(
                this.PersonId, this.EmergencyContact, this.EmergencyPhone, this.BloodType, this.Allergies, this.MedicalHistory, this.IsActive
            );

            return this.PatientId != -1;
        }

        // =========================
        // Update
        // =========================
        private bool _Update()
        {
            return clsPatientsData.UpdatePatient(
                this.PatientId,
                this.PersonId, this.EmergencyContact, this.EmergencyPhone, this.BloodType, this.Allergies, this.MedicalHistory, this.IsActive
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
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();

                default:
                    return false;
            }
        }

        // =========================
        // Delete
        // =========================
        public static bool Delete(int id)
            => clsPatientsData.DeletePatient(id);

        // =========================
        // Get All (DataTable)
        // =========================
        public static DataTable GetAll()
            => clsPatientsData.GetAllPatients();

        // =========================
        // Is Exist
        // =========================
        public static bool IsExist(int PatientId)
        {
            return clsPatientsData.IsPatientExistByPersonId(PatientId);         
        }
    }
}