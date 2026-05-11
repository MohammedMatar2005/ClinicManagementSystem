using System;
using System.Data;
using System.Security.Policy;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        // =========================
        // Properties
        // =========================
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public byte PaymentStatusId { get; set; }
        public string TransactionReference { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public string DoctorFullName { get; set; }
        public string PatientFullName { get; set; }
        // =========================
        // Constructors
        // =========================

        // 1. Default Constructor (Add New Mode)
        public clsPayment()
        {
            this.PaymentId = -1;
            this.InvoiceId = -1;
            this.PaymentAmount = 0;
            this.PaymentMethod = string.Empty;
            this.PaymentStatusId = 0;
            this.TransactionReference = string.Empty;
            this.PaymentDate = DateTime.Now;
            this.Notes = string.Empty;
            this.CreatedDate = DateTime.Now;
            this.IsActive = true;

            Mode = enMode.AddNew;
        }

        // 2. Private Constructor (Update Mode)
        private clsPayment(int PaymentId, int InvoiceId, string DoctorFullName, string PatientFullName, decimal PaymentAmount, string PaymentMethod,
            byte PaymentStatusId, string TransactionReference, DateTime PaymentDate, string Notes,
            DateTime CreatedDate, bool IsActive)
        {
            this.PaymentId = PaymentId;
            this.InvoiceId = InvoiceId;
            this.PaymentAmount = PaymentAmount;
            this.PaymentMethod = PaymentMethod;
            this.PaymentStatusId = PaymentStatusId;
            this.TransactionReference = TransactionReference;
            this.PaymentDate = PaymentDate;
            this.Notes = Notes;
            this.CreatedDate = CreatedDate;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        // =========================
        // Methods
        // =========================

        // 3. Find Method
        public static clsPayment Find(int PaymentId)
        {
            int InvoiceId = -1;
            decimal PaymentAmount = 0;
            string PaymentMethod = "";
            byte PaymentStatusId = 0;
            string TransactionReference = "";
            DateTime PaymentDate = DateTime.Now;
            string Notes = "";
            DateTime CreatedDate = DateTime.Now;
            bool IsActive = false;

            string DoctorFullName = "";
            string PatientFullName = "";

            bool isFound = clsPaymentsData.GetPaymentInfoByID(
                PaymentId, ref InvoiceId, ref PatientFullName, ref DoctorFullName, ref PaymentAmount, ref PaymentMethod,
                ref PaymentStatusId, ref TransactionReference, ref PaymentDate,
                ref Notes, ref CreatedDate, ref IsActive);

            if (isFound)
                return new clsPayment(PaymentId, InvoiceId, PatientFullName, DoctorFullName, PaymentAmount, PaymentMethod,
                    PaymentStatusId, TransactionReference, PaymentDate, Notes, CreatedDate, IsActive);
            else
                return null;
        }

        // 4. Save Method
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

        // 5. Private CRUD helpers
        private bool _AddNewPayment()
        {
            this.PaymentId = clsPaymentsData.AddNewPayment(
                this.InvoiceId, this.PaymentAmount, this.PaymentMethod,
                this.PaymentStatusId, this.TransactionReference, this.PaymentDate,
                this.Notes, this.CreatedDate, this.IsActive);

            return (this.PaymentId != -1);
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsData.UpdatePayment(
                this.PaymentId, this.InvoiceId, this.PaymentAmount, this.PaymentMethod,
                this.PaymentStatusId, this.TransactionReference, this.PaymentDate,
                this.Notes, this.CreatedDate, this.IsActive);
        }

        // 6. Static Methods
        public static DataTable GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments();
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