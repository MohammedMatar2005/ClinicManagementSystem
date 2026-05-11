using System;
using System.Data;
using ClinicDataAccess;

namespace ClinicBusiness
{
    public class clsInvoice
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; }

        // =========================
        // Properties
        // =========================
        public int InvoiceId { get; set; }
        public int VisitId { get; set; }

        
        private string _InvoiceNumber = string.Empty;

        public string InvoiceNumber
        {
            get
            {

                if (string.IsNullOrEmpty(_InvoiceNumber) && Mode == enMode.AddNew)
                    _InvoiceNumber = GenerateInvoiceNumber();

                return _InvoiceNumber;
            }
            set => _InvoiceNumber = value;
        }

        // تعديل بسيط في الباني لتهيئته
       


        public DateTime InvoiceDate { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabTestFee { get; set; }
        public decimal ProcedureFee { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public byte StatusId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public decimal SubTotal { get; set; }
        public decimal FinalAmount { get; set; }

        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }



        // =========================
        // Constructor (AddNew)
        // =========================
        public clsInvoice()
        {
            this.InvoiceId = -1;
            this.VisitId = 0;
            this.InvoiceNumber = GenerateInvoiceNumber();
            this.InvoiceDate = DateTime.Now;
            this.ConsultationFee = 0.0M;
            this.LabTestFee = 0.0M;
            this.ProcedureFee = 0.0M;
            this.OtherCharges = 0.0M;
            this.TaxPercentage = 0.0M;  
            this.TaxAmount = 0.0M;
            this.DiscountPercentage = 0.0M;
            this.DiscountAmount = 0.0M;
            this.StatusId = 0;
            this.DueDate = null;
            this.CreatedDate = DateTime.Now;
            this.IsActive = true;
            this.SubTotal = 0.0M;
            this.FinalAmount = 0.0M;
            this.PatientFullName = "";
            this.DoctorFullName = "";

            Mode = enMode.AddNew;
        }

        // =========================
        // Constructor (Update)
        // =========================
        private clsInvoice(int InvoiceId, int VisitId, string PatientFullName, string DoctorFullName, string InvoiceNumber, DateTime InvoiceDate, decimal ConsultationFee, decimal LabTestFee, decimal ProcedureFee, decimal OtherCharges, decimal TaxPercentage, decimal TaxAmount, decimal DiscountPercentage, decimal DiscountAmount, byte StatusId, DateTime? DueDate, DateTime CreatedDate, bool IsActive, decimal SubTotal, decimal FinalAmount)
        {
            this.InvoiceId = InvoiceId; 
            this.VisitId = VisitId;
            this.InvoiceNumber = InvoiceNumber;
            this.InvoiceDate = InvoiceDate;
            this.ConsultationFee = ConsultationFee;
            this.LabTestFee = LabTestFee;
            this.ProcedureFee = ProcedureFee;
            this.OtherCharges = OtherCharges;
            this.TaxPercentage = TaxPercentage;
            this.TaxAmount = TaxAmount;
            this.DiscountPercentage = DiscountPercentage;
            this.DiscountAmount = DiscountAmount;
            this.StatusId = StatusId;
            this.DueDate = DueDate;
            this.CreatedDate = CreatedDate;
            this.IsActive = IsActive;
            this.SubTotal = SubTotal;
            this.FinalAmount = FinalAmount;
            this.PatientFullName = PatientFullName;
            this.DoctorFullName = DoctorFullName;

            Mode = enMode.Update;
        }

        // =========================
        // Find
        // =========================
        // =========================
        // Find
        // =========================
        // =========================
        // Find
        // =========================
        public static clsInvoice Find(int InvoiceId)
        {
            // تعريف المتغيرات لتتوافق مع بارامترات الـ DAL
            int VisitId = -1;
            string InvoiceNumber = "";
            DateTime InvoiceDate = DateTime.Now;
            decimal ConsultationFee = 0, LabTestFee = 0, ProcedureFee = 0, OtherCharges = 0;

            decimal? TaxPercentage = 0, TaxAmount = 0, DiscountPercentage = 0, DiscountAmount = 0;

            // أضفنا هذه المتغيرات لأن الـ DAL يطلبها الآن
            decimal SubTotal = 0;
            decimal FinalAmount = 0;

            byte StatusId = 0;
            DateTime? DueDate = null; // النوع Nullable كما في الـ DAL
            DateTime CreatedDate = DateTime.Now;
            bool IsActive = false;

            string  PatientFullName = string.Empty;
            string DoctorFullName   = string.Empty;

            // استدعاء دالة الـ DAL
            bool found = clsInvoicesData.GetInvoiceInfoByID(
                InvoiceId,
                ref VisitId, ref PatientFullName, ref DoctorFullName, ref InvoiceNumber, ref InvoiceDate, ref ConsultationFee,
                ref LabTestFee, ref ProcedureFee, ref OtherCharges,
                ref TaxPercentage, ref TaxAmount, ref DiscountPercentage, ref DiscountAmount,
                ref SubTotal, ref FinalAmount, // تمرير القيم المسترجعة من الـ DB
                ref StatusId, ref DueDate, ref CreatedDate, ref IsActive
            );

            if (found)
            {
                return new clsInvoice(
                    InvoiceId,
                    VisitId,
                    PatientFullName,
                    DoctorFullName,
                    InvoiceNumber,
                    InvoiceDate,
                    ConsultationFee,
                    LabTestFee,
                    ProcedureFee,
                    OtherCharges,
                    TaxPercentage ?? 0,
                    TaxAmount ?? 0,
                    DiscountPercentage ?? 0,
                    DiscountAmount ?? 0,
                    StatusId,
                    DueDate ?? DateTime.Now, // معالجة التاريخ إذا كان Null
                    CreatedDate,
                    IsActive,
                    SubTotal,
                    FinalAmount
                );
            }
            else
            {
                return null;
            }
        }        // =========================
                 // Add
                 // =========================
        private bool _AddInvoice()
        {
           
            this.InvoiceId = clsInvoicesData.AddNewInvoice(
                this.VisitId,
                this.InvoiceNumber,
                this.InvoiceDate,
                this.ConsultationFee,
                this.LabTestFee,
                this.ProcedureFee,
                this.OtherCharges,
                this.TaxPercentage,
                this.TaxAmount,
                this.DiscountPercentage,
                this.DiscountAmount,
                this.StatusId,
                this.DueDate
            );

            // إذا نجحت العملية سيعود الرقم المعرف للفاتورة، وإلا سيعود -1
            return (this.InvoiceId != -1);
        }

        // =========================
        // Update
        // =========================
        private bool _UpdateInvoice()
        {
           
            return clsInvoicesData.UpdateInvoice(
                this.InvoiceId,
                this.VisitId,
                this.InvoiceNumber,
                this.InvoiceDate,
                this.ConsultationFee,
                this.LabTestFee,
                this.ProcedureFee,
                this.OtherCharges,
                this.TaxPercentage,
                this.TaxAmount,
                this.DiscountPercentage,
                this.DiscountAmount,
                this.StatusId,
                this.DueDate,
                this.IsActive
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
                    if (_AddInvoice())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateInvoice();

                default:
                    return false;
            }
        }

        // =========================
        // Delete
        // =========================
        public static bool Delete(int id)
            => clsInvoicesData.DeleteInvoice(id);

        // =========================
        // Get All (DataTable)
        // =========================
        public static DataTable GetAll() 
            => clsInvoicesData.GetAllInvoices();

        // =========================
        // Is Exist
        // =========================
        public static string GenerateInvoiceNumber()
        {
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
        
            // إنشاء مصفوفة من 5 عناصر واختيار حرف عشوائي لكل عنصر
            char[] result = new char[5];
            for (int i = 0; i < 5; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
        
            return new string(result);
        }

        public static bool IsExist(int InvoiceId)
        {
            return clsInvoicesData.IsInvoiceExistById(InvoiceId);
        }
    }

}

