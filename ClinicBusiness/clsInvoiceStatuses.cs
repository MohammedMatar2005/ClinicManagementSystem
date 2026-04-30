
using System;
using System.Collections.ObjectModel;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsInvoiceStatuse
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public short StatusId { get; set; }
        public string StatusName { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsInvoiceStatuse()
        {
            this.StatusId = -1;
            // تعيين القيم الافتراضية هنا
            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsInvoiceStatuse(short StatusId, string StatusName)
        {
            this.StatusId = StatusId;
            this.StatusName = StatusName;

            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsInvoiceStatuse Find(short StatusId)
        {
            string StatusName = "";


            // استدعاء الـ DAL التي تستخدم SP_InvoiceStatuses_GetByID
            bool isFound = clsInvoiceStatusData.GetInvoiceStatuseInfoByID(StatusId, ref StatusName);

            if (isFound)
                return new clsInvoiceStatuse(StatusId, StatusName);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInvoiceStatuse())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateInvoiceStatuse();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewInvoiceStatuse()
        {
            // استدعاء الـ DAL التي تستخدم SP_InvoiceStatuses_Add
            this.StatusId = clsInvoiceStatusData.AddNewInvoiceStatuses(this.StatusName);
            return (this.StatusId != -1);
        }

        private bool _UpdateInvoiceStatuse()
        {
            // استدعاء الـ DAL التي تستخدم SP_InvoiceStatuses_Update
            return clsInvoiceStatusData.UpdateInvoiceStatuses(this.StatusId, this.StatusName);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsInvoiceStatuse> GetAllInvoiceStatuses()
        {
            return clsInvoiceStatusData.GetAllInvoiceStatus().ToObservableCollection<clsInvoiceStatuse>();
        }

        public static bool Delete(short StatusId)
        {
            return clsInvoiceStatusData.DeleteInvoiceStatus(StatusId);
        }

        public static bool IsExist(short StatusId)
        {
            return clsInvoiceStatusData.IsInvoiceStatusExist(StatusId);
        }
    }
}