
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace ClinicBusiness
{
    public class clsPrescription
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PrescriptionId { get; set; }
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public int Duration { get; set; }
        public string Instructions { get; set; }
        public int Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsPrescription()
        {
            this.PrescriptionId = -1;
            // تعيين القيم الافتراضية هنا
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsPrescription(int PrescriptionId, int VisitId, int PatientId, string MedicineName, string Dosage, string Frequency, int Duration, string Instructions, int Quantity, DateTime StartDate, DateTime EndDate, DateTime CreatedDate)
        {
            this.PrescriptionId = PrescriptionId;
            this.VisitId = VisitId;
            this.PatientId = PatientId;
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

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsPrescription Find(int PrescriptionId)
        {
            int VisitId = -1;
            int PatientId = -1;
            string MedicineName = "";
            string Dosage = "";
            string Frequency = "";
            int Duration = -1;
            string Instructions = "";
            int Quantity = -1;
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            DateTime CreatedDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_Prescriptions_GetByID
            bool isFound = clsPrescriptionsData.GetPrescriptionInfoByID(PrescriptionId, ref VisitId, ref PatientId, ref MedicineName, ref Dosage, ref Frequency, ref Duration, ref Instructions, ref Quantity, ref StartDate, ref EndDate, ref CreatedDate);

            if (isFound)
                return new clsPrescription(PrescriptionId, VisitId, PatientId, MedicineName, Dosage, Frequency, Duration, Instructions, Quantity, StartDate, EndDate, CreatedDate);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
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

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewPrescription()
        {
            // استدعاء الـ DAL التي تستخدم SP_Prescriptions_Add
            this.PrescriptionId = clsPrescriptionsData.AddNewPrescription(this.VisitId, this.PatientId, this.MedicineName, this.Dosage, this.Frequency, this.Duration, this.Instructions, this.Quantity, this.StartDate, this.EndDate, this.CreatedDate);
            return (this.PrescriptionId != -1);
        }

        private bool _UpdatePrescription()
        {
            // استدعاء الـ DAL التي تستخدم SP_Prescriptions_Update
            return clsPrescriptionsData.UpdatePrescription(this.PrescriptionId, this.VisitId, this.PatientId, this.MedicineName, this.Dosage, this.Frequency, this.Duration, this.Instructions, this.Quantity, this.StartDate, this.EndDate, this.CreatedDate);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsPrescription> GetAllPrescriptions()
        {
            return clsPrescriptionsData.GetAllPrescriptions().ToObservableCollection<clsPrescription>();
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