
using System;
using System.Collections.ObjectModel;
using System.Data;
using ClinicDataAccess;
namespace ClinicBusiness
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionReference { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }


        // 1. Default Constructor (Add New Mode)
        public clsPayment()
        {
            this.PaymentId = -1;
            // تعيين القيم الافتراضية هنا
            Mode = enMode.AddNew;
            this.IsActive = true;
        }

        // 2. Private Constructor (Update Mode - Used by Find)
        private clsPayment(int PaymentId, int InvoiceId, int PatientId, decimal PaymentAmount, string PaymentMethod, string PaymentStatus, string TransactionReference, DateTime PaymentDate, string Notes, DateTime CreatedDate, bool IsActive)
        {
            this.PaymentId = PaymentId;
            this.InvoiceId = InvoiceId;
            this.PatientId = PatientId;
            this.PaymentAmount = PaymentAmount;
            this.PaymentMethod = PaymentMethod;
            this.PaymentStatus = PaymentStatus;
            this.TransactionReference = TransactionReference;
            this.PaymentDate = PaymentDate;
            this.Notes = Notes;
            this.CreatedDate = CreatedDate;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        // 3. Find Method (Business Logic handles the data retrieval via DAL)
        public static clsPayment Find(int PaymentId)
        {
            int InvoiceId = -1;
            int PatientId = -1;
            decimal PaymentAmount = 0;
            string PaymentMethod = "";
            string PaymentStatus = "";
            string TransactionReference = "";
            DateTime PaymentDate = DateTime.Now;
            string Notes = "";
            DateTime CreatedDate = DateTime.Now;
            bool IsActive = false;

            // استدعاء الـ DAL التي تستخدم SP_Payments_GetByID
            bool isFound = clsPaymentsData.GetPaymentInfoByID(PaymentId, ref InvoiceId, ref PatientId, ref PaymentAmount, ref PaymentMethod, ref PaymentStatus, ref TransactionReference, ref PaymentDate, ref Notes, ref CreatedDate, ref IsActive);

            if (isFound)
                return new clsPayment(PaymentId, InvoiceId, PatientId, PaymentAmount, PaymentMethod, PaymentStatus, TransactionReference, PaymentDate, Notes, CreatedDate, IsActive);
            else
                return null;
        }

        // 4. Save Method (The core Business Logic decision)
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }

        // 5. Private CRUD helpers that talk to the DAL Stored Procedures
        private bool _AddNewPayment()
        {
            // استدعاء الـ DAL التي تستخدم SP_Payments_Add
            this.PaymentId = clsPaymentsData.AddNewPayment(this.InvoiceId, this.PatientId, this.PaymentAmount, this.PaymentMethod, this.PaymentStatus, this.TransactionReference, this.PaymentDate, this.Notes, this.CreatedDate, this.IsActive);
            return (this.PaymentId != -1);
        }

        private bool _UpdatePayment()
        {
            // استدعاء الـ DAL التي تستخدم SP_Payments_Update
            return clsPaymentsData.UpdatePayment(this.PaymentId, this.InvoiceId, this.PatientId, this.PaymentAmount, this.PaymentMethod, this.PaymentStatus, this.TransactionReference, this.PaymentDate, this.Notes, this.CreatedDate, this.IsActive);
        }

        // 6. Static Methods for list operations
        public static ObservableCollection<clsPayment> GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments().ToObservableCollection<clsPayment>();
        }

        public static bool Delete(int PaymentId)
        {
            return clsPaymentsData.DeletePayment(PaymentId);
        }

        public static bool IsExist(int PaymentId)
        {
            return clsPaymentsData.IsPaymentExist(PaymentId);
        }
    }
}