
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ClinicBusiness
{

    public class clsDoctor : ValidationBase, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       

        public enum enMode { AddNew = 0, Update = 1, Failed = 2 };
        public enMode Mode = enMode.AddNew;

        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public decimal Salary { get; set; }
        public string OfficeLocation { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsUser UserInfo { get; set; }

        private string _fullName = "";


        public string FullName
        {
            get => !string.IsNullOrEmpty(UserInfo?.PersonInfo?.FullName)
                       ? UserInfo.PersonInfo.FullName
                       : _fullName;
            set => _fullName = value ?? "";
        }




        // 1. Default Constructor (Add New Mode)
        public clsDoctor()
        {
            this.DoctorId = -1;
            this.UserId = -1;
            this.Salary = 0;
            this.CreatedDate = DateTime.Now;
            this.IsActive = true;
            this.LicenseNumber = "";
            this.Specialization = "";

            Mode = enMode.AddNew;

            this.UserInfo = new clsUser();
            this.UserInfo.PersonInfo = new clsPeople();

        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsDoctor(int DoctorId, int UserId, string Specialization, string LicenseNumber, decimal Salary, string OfficeLocation, int ExperienceYears, bool IsActive, DateTime CreatedDate)
        {
            this.DoctorId = DoctorId;
            this.UserId = UserId;
            this.Specialization = Specialization;
            this.LicenseNumber = LicenseNumber;
            this.Salary = Salary;
            this.OfficeLocation = OfficeLocation;
            this.ExperienceYears = ExperienceYears;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;
            this.UserInfo = clsUser.Find(UserId);

            Mode = enMode.Update;
        }


        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsDoctor Find(int DoctorId)
        {
            int UserId = -1;
            string Specialization = "";
            string LicenseNumber = "";
            decimal Salary = 0;
            string OfficeLocation = "";
            int ExperienceYears = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;


            // استدعاء الـ DAL التي تستخدم SP_Doctors_GetByID
            bool isFound = clsDoctorsData.GetDoctorInfoByID(DoctorId, ref UserId, ref Specialization, ref LicenseNumber, ref Salary, ref OfficeLocation, ref ExperienceYears, ref IsActive, ref CreatedDate);

            if (isFound)
                return new clsDoctor(DoctorId, UserId, Specialization, LicenseNumber, Salary, OfficeLocation, ExperienceYears, IsActive, CreatedDate);
            else
                return null;
        }

        public override string ToString()
        {
            return FullName ?? "";
        }



        // 4. Save Method (The core Business Logic decision)
        //public bool Save()
        //{
        //    switch (Mode)
        //    {
        //        case enMode.AddNew:
        //            if (_AddNewDoctor())
        //            {
        //                Mode = enMode.Update;
        //                return true;
        //            }
        //            return false;

        //        case enMode.Update:
        //            return _UpdateDoctor();
        //    }
        //    return false;
        //}

        public enMode Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
                    {
                        Mode = enMode.Update;
                        return enMode.AddNew;
                    }
                    return enMode.Failed;

                case enMode.Update:
                    if (_UpdateDoctor())
                        return enMode.Update;

                    return enMode.Failed;
            }

            return enMode.Failed;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewDoctor()
        {
            // استدعاء الـ DAL التي تستخدم SP_Doctors_Add
            this.DoctorId = clsDoctorsData.AddNewDoctor(this.UserId, this.Specialization, this.LicenseNumber, this.Salary, this.OfficeLocation, this.ExperienceYears, this.IsActive, this.CreatedDate);
            return (this.DoctorId != -1);
        }

        private bool _UpdateDoctor()
        {
            // استدعاء الـ DAL التي تستخدم SP_Doctors_Update
            return clsDoctorsData.UpdateDoctor(this.DoctorId, this.UserId, this.Specialization, this.LicenseNumber, this.Salary, this.OfficeLocation, this.ExperienceYears, this.IsActive, this.CreatedDate);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsDoctor> GetAllDoctors()
        {


            return clsDoctorsData.GetAllDoctors().ToObservableCollection<clsDoctor>();
        }

        public static bool Delete(int DoctorId)
        {
            return clsDoctorsData.DeleteDoctor(DoctorId);
        }

        public static bool IsExist(int DoctorId)
        {
            return clsDoctorsData.IsDoctorExist(DoctorId);
        }

        // في clsDoctor
        protected override string ValidateProperty(string columnName)
        {
            switch (columnName)
            {
                case nameof(LicenseNumber):
                    if (string.IsNullOrWhiteSpace(LicenseNumber)) return "رقم الرخصة مطلوب";
                    break;

                case nameof(Specialization):
                    if (string.IsNullOrWhiteSpace(Specialization)) return "التخصص مطلوب";
                    break;

                case nameof(Salary):
                    if (Salary <= 0) return "يرجى إدخال الراتب";
                    break;

                case nameof(ExperienceYears):
                    if (ExperienceYears < 0) return "سنوات الخبرة غير صحيحة";
                    break;

                case nameof(OfficeLocation):
                    if (string.IsNullOrWhiteSpace(OfficeLocation)) return "موقع العيادة مطلوب";
                    break;
            }
            return null;
        }

    }
}