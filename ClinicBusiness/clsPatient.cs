
using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;



namespace ClinicBusiness
{
    public class clsPatient : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string MedicalHistory { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }
        public clsPeople PersonInfo { get; set; } = new clsPeople();

        private string _phone = "";


        private string _fullName = "";


        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(); }
        }
        public string Phone
        {
            get => !string.IsNullOrEmpty(PersonInfo?.Phone)
                       ? PersonInfo.Phone
                       : _phone;
            set => _phone = value ?? "";
        }


        // 1. Default Constructor (Add New Mode)
        public clsPatient()
        {
            this.PatientId = -1;

            Mode = enMode.AddNew;
            PersonInfo = new clsPeople();
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsPatient(int PatientId, int PersonId, string EmergencyContact, string EmergencyPhone, string BloodType, string Allergies, string MedicalHistory, bool IsActive, DateTime CreatedDate, string Email)
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
            this.Email = Email;
            this.PersonInfo = clsPeople.Find(PersonId);
            this.Phone = PersonInfo.Phone;
            this.FullName = clsPeople.Find(PersonId).FullName;
            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
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
            string Email = "";


            // استدعاء الـ DAL التي تستخدم SP_Patients_GetByID
            bool isFound = clsPatientsData.GetPatientInfoByID(PatientId, ref PersonId, ref EmergencyContact, ref EmergencyPhone, ref BloodType, ref Allergies, ref MedicalHistory, ref IsActive, ref CreatedDate, ref Email);

            if (isFound)
                return new clsPatient(PatientId, PersonId, EmergencyContact, EmergencyPhone, BloodType, Allergies, MedicalHistory, IsActive, CreatedDate, Email);
            else
                return null;
        }


        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePatient();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewPatient()
        {
            // استدعاء الـ DAL التي تستخدم SP_Patients_Add
            this.PatientId = clsPatientsData.AddNewPatient(this.PersonId, this.EmergencyContact, this.EmergencyPhone, this.BloodType, this.Allergies, this.MedicalHistory, this.IsActive, this.CreatedDate, this.Email);
            return (this.PatientId != -1);
        }

        private bool _UpdatePatient()
        {
            // استدعاء الـ DAL التي تستخدم SP_Patients_Update
            return clsPatientsData.UpdatePatient(this.PatientId, this.PersonId, this.EmergencyContact, this.EmergencyPhone, this.BloodType, this.Allergies, this.MedicalHistory, this.IsActive, this.CreatedDate, this.Email);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsPatient> GetAllPatients()
        {
            return clsPatientsData.GetAllPatients().ToObservableCollection<clsPatient>();
        }

        public static bool Delete(int PatientId)
        {
            return clsPatientsData.DeletePatient(PatientId);
        }

        public static bool IsExist(int PatientId)
        {
            return clsPatientsData.IsPatientExist(PatientId);
        }


    }
}