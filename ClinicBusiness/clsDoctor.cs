using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsDoctor
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; }

        // =========================
        // Properties
        // =========================
        public int DoctorId { get; set; }
        
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public decimal Salary { get; set; }
        public string OfficeLocation { get; set; }
        public int ExperienceYears { get; set; }
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
        public clsDoctor()
        {
            this.DoctorId = -1;
            this.UserId = 0;
            this.Specialization = string.Empty;
            this.LicenseNumber = string.Empty;
            this.Salary = 0.0M;
            this.OfficeLocation = string.Empty;
            this.ExperienceYears = 0;
            this.IsActive = false;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        // =========================
        // Constructor (Update)
        // =========================
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

            Mode = enMode.Update;
        }

        // =========================
        // Find
        // =========================
        public static clsDoctor Find(int DoctorId)
        {
            int UserId = -1;
            string Specialization = "";
            string LicenseNumber = "";
            decimal? Salary = 0;
            string OfficeLocation = "";
            int? ExperienceYears = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;


            bool found = clsDoctorsData.GetDoctorById(
                DoctorId,
                ref UserId, ref Specialization, ref LicenseNumber, ref Salary, ref OfficeLocation, ref ExperienceYears, ref IsActive, ref CreatedDate
            );

            if (!found)
                return null;

            return new clsDoctor(
                DoctorId,
                UserId, Specialization, LicenseNumber, Salary ?? 0, OfficeLocation, ExperienceYears ?? 0, IsActive, CreatedDate
            );
        }

        // =========================
        // Add
        // =========================
        private bool _Add()
        {
            this.DoctorId = clsDoctorsData.AddNewDoctor(
                this.UserId, this.Specialization, this.LicenseNumber, this.Salary, this.OfficeLocation, this.ExperienceYears, this.IsActive
            );

            return this.DoctorId != -1;
        }

        // =========================
        // Update
        // =========================
        private bool _Update()
        {
            return clsDoctorsData.UpdateDoctor(
                this.DoctorId,
                this.UserId, this.Specialization, this.LicenseNumber, this.Salary, this.OfficeLocation, this.ExperienceYears, this.IsActive
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
            => clsDoctorsData.DeleteDoctor(id);

        // =========================
        // Get All (DataTable)
        // =========================
        public static DataTable GetAll()
            => clsDoctorsData.GetAllDoctors();

        // =========================
        // Is Exist
        // =========================
        public static bool IsExist(int DoctorId)
        {
            int UserId = -1;
            string Specialization = "";
            string LicenseNumber = "";
            decimal? Salary = 0;
            string OfficeLocation = "";
            int? ExperienceYears = -1;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;

            bool isFound = clsDoctorsData.GetDoctorById(
                DoctorId,
                ref UserId, ref Specialization, ref LicenseNumber, ref Salary, ref OfficeLocation, ref ExperienceYears, ref IsActive, ref CreatedDate
            );

            return isFound;
        }
    }
}