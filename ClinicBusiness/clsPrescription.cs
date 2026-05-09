using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsPrescription
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // =========================
        // Properties
        // =========================
        public int PrescriptionId { get; set; }
        public int VisitId { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public int? Duration { get; set; } // تم التعديل ليكون Nullable
        public string Instructions { get; set; }
        public int? Quantity { get; set; } // تم التعديل ليكون Nullable
        public DateTime? StartDate { get; set; } // تم التعديل ليكون Nullable
        public DateTime? EndDate { get; set; } // تم التعديل ليكون Nullable
        public DateTime CreatedDate { get; set; }

        // =========================
        // Constructors
        // =========================

        // 1. Default Constructor (Add New Mode)
        public clsPrescription()
        {
            this.PrescriptionId = -1;
            this.VisitId = -1;
            this.MedicineName = string.Empty;
            this.Dosage = string.Empty;
            this.Frequency = string.Empty;
            this.Duration = null;
            this.Instructions = string.Empty;
            this.Quantity = null;
            this.StartDate = null;
            this.EndDate = null;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode)
        private clsPrescription(int PrescriptionId, int VisitId, string MedicineName, string Dosage,
            string Frequency, int? Duration, string Instructions, int? Quantity,
            DateTime? StartDate, DateTime? EndDate, DateTime CreatedDate)
        {
            this.PrescriptionId = PrescriptionId;
            this.VisitId = VisitId;
            this.MedicineName = MedicineName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.Duration = Duration;
            this.Instructions = Instructions;
            this.Quantity = Quantity;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        // =========================
        // Methods
        // =========================

        // 3. Find Method
        public static clsPrescription Find(int PrescriptionId)
        {
            int VisitId = -1;
            string MedicineName = "";
            string Dosage = "";
            string Frequency = "";
            int? Duration = null;
            string Instructions = "";
            int? Quantity = null;
            DateTime? StartDate = null;
            DateTime? EndDate = null;
            DateTime CreatedDate = DateTime.Now;

            bool isFound = clsPrescriptionsData.GetPrescriptionInfoByID(
                PrescriptionId, ref VisitId, ref MedicineName, ref Dosage, ref Frequency,
                ref Duration, ref Instructions, ref Quantity, ref StartDate, ref EndDate, ref CreatedDate);

            if (isFound)
                return new clsPrescription(PrescriptionId, VisitId, MedicineName, Dosage,
                    Frequency, Duration, Instructions, Quantity, StartDate, EndDate, CreatedDate);
            else
                return null;
        }

        // 4. Save Method
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPrescription())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePrescription();
            }
            return false;
        }

        // 5. Private CRUD helpers
        private bool _AddNewPrescription()
        {
            this.PrescriptionId = clsPrescriptionsData.AddNewPrescription(
                this.VisitId, this.MedicineName, this.Dosage, this.Frequency,
                this.Duration, this.Instructions, this.Quantity, this.StartDate, this.EndDate);

            return (this.PrescriptionId != -1);
        }

        private bool _UpdatePrescription()
        {
            return clsPrescriptionsData.UpdatePrescription(
                this.PrescriptionId, this.VisitId, this.MedicineName, this.Dosage,
                this.Frequency, this.Duration, this.Instructions, this.Quantity,
                this.StartDate, this.EndDate);
        }

        // =========================
        // Static Methods
        // =========================

        public static DataTable GetAllPrescriptions()
        {
            return clsPrescriptionsData.GetAllPrescriptions();
        }

        public static DataTable GetPrescriptionsByVisit(int VisitId)
        {
            return clsPrescriptionsData.GetPrescriptionsByVisit(VisitId);
        }

        public static DataTable GetPrescriptionsByPatient(int PatientId)
        {
            return clsPrescriptionsData.GetPrescriptionsByPatient(PatientId);
        }

        public static bool Delete(int PrescriptionId)
        {
            return clsPrescriptionsData.DeletePrescription(PrescriptionId);
        }

        public static bool IsExist(int PrescriptionId)
        {
            return clsPrescriptionsData.IsPrescriptionExist(PrescriptionId);
        }
    }
}