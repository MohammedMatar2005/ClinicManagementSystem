
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace ClinicBusiness
{
    public class clsAppointmentStatuse
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppointmentStatusId { get; set; }
        public string Title { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsAppointmentStatuse()
        {
            this.AppointmentStatusId = -1;
            // تعيين القيم الافتراضية هنا
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsAppointmentStatuse(int AppointmentStatusId, string Title)
        {
            this.AppointmentStatusId = AppointmentStatusId;
            this.Title = Title;

            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsAppointmentStatuse Find(int AppointmentStatusId)
        {
            string Title = "";


            // استدعاء الـ DAL التي تستخدم SP_AppointmentStatuses_GetByID
            bool isFound = clsAppointmentStatusesData.GetAppointmentStatuseInfoByID(AppointmentStatusId, ref Title);

            if (isFound)
                return new clsAppointmentStatuse(AppointmentStatusId, Title);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointmentStatuse())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateAppointmentStatuse();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewAppointmentStatuse()
        {
            // استدعاء الـ DAL التي تستخدم SP_AppointmentStatuses_Add
            this.AppointmentStatusId = clsAppointmentStatusesData.AddNewAppointmentStatuse(this.Title);
            return (this.AppointmentStatusId != -1);
        }

        private bool _UpdateAppointmentStatuse()
        {
            // استدعاء الـ DAL التي تستخدم SP_AppointmentStatuses_Update
            return clsAppointmentStatusesData.UpdateAppointmentStatuse(this.AppointmentStatusId, this.Title);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsAppointmentStatuse> GetAllAppointmentStatuses() =>
            clsAppointmentStatusesData.GetAllAppointmentStatuses().ToObservableCollection<clsAppointmentStatuse>();


        public static bool Delete(int AppointmentStatusId)
        {
            return clsAppointmentStatusesData.DeleteAppointmentStatuse(AppointmentStatusId);
        }

        public static bool IsExist(int AppointmentStatusId)
        {
            return clsAppointmentStatusesData.IsAppointmentStatuseExist(AppointmentStatusId);
        }
    }
}