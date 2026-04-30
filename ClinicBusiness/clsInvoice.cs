
using System;
using System.Collections.ObjectModel;
using System.Data;
using ClinicDataAccess;
using System.Xml.Linq;
using ClinicBusiness;
public class clsInvoice
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public enum enStatus { Unpaid = 1,Partial = 2, Paid = 3, Refunded = 4 };
    public enStatus Status
    {
        get;set;
    }
    public int InvoiceId { get; set; }
    public int VisitId { get; set; }
    public int PatientId { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal LabTestFee { get; set; }
    public decimal ProcedureFee { get; set; }
    public decimal OtherCharges { get; set; }
    public decimal SubTotal { get; set; }
    public decimal TaxPercentage { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal DiscountPercentage { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalAmount { get; set; }
    public int StatusId { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsActive { get; set; }

    public string FullName { get; set; }



    // 1. Default Constructor (Add New Mode)
    public clsInvoice()
    {
        this.InvoiceId = -1;
       
        this.PatientId = -1;
        this.VisitId = -1;
        this.InvoiceNumber = "";
        this.InvoiceDate = DateTime.Now;
        this.ConsultationFee = 0;
        this.LabTestFee = 0;
        this.ProcedureFee = 0;
        this.OtherCharges = 0;
        this.SubTotal = 0;
        this.TaxPercentage = 0;
        this.TaxAmount = 0;
        this.IsActive =  false;
        this.FinalAmount = 0;
        this.DiscountAmount = 0;
        this.DueDate = DateTime.Now.AddDays(7); // Default due date is 7 days from now
        this.CreatedDate = DateTime.Now;
        this.FullName = "";

        Status = enStatus.Unpaid;
        Mode = enMode.AddNew;
    }

    // 2. Private Constructor (Update Mode - Used by Find)
    private clsInvoice(int InvoiceId, int VisitId, int PatientId, string InvoiceNumber, DateTime InvoiceDate, decimal ConsultationFee, decimal LabTestFee, decimal ProcedureFee, decimal OtherCharges, decimal SubTotal, decimal TaxPercentage, decimal TaxAmount, decimal DiscountPercentage, decimal DiscountAmount, decimal FinalAmount, int StatusId, DateTime DueDate, DateTime CreatedDate, bool IsActive)
    {
        this.InvoiceId = InvoiceId;
        this.VisitId = VisitId;
        this.PatientId = PatientId;
        this.InvoiceNumber = InvoiceNumber;
        this.InvoiceDate = InvoiceDate;
        this.ConsultationFee = ConsultationFee;
        this.LabTestFee = LabTestFee;
        this.ProcedureFee = ProcedureFee;
        this.OtherCharges = OtherCharges;
        this.SubTotal = SubTotal;
        this.TaxPercentage = TaxPercentage;
        this.TaxAmount = TaxAmount;
        this.DiscountPercentage = DiscountPercentage;
        this.DiscountAmount = DiscountAmount;
        this.FinalAmount = FinalAmount;
        this.StatusId = StatusId;
        this.DueDate = DueDate;
        this.CreatedDate = CreatedDate;
        this.IsActive = IsActive;
        this.FullName = clsPatient.Find(PatientId).FullName;
        Status = enStatus.Unpaid;
        Mode = enMode.Update;
    }

    // 3. Find Method (Business Logic handles the data retrieval via DAL)
    public static clsInvoice Find(int InvoiceId)
    {
        int VisitId = -1;
        int PatientId = -1;
        string InvoiceNumber = "";
        DateTime InvoiceDate = DateTime.Now;
        decimal ConsultationFee = 0;
        decimal LabTestFee = 0;
        decimal ProcedureFee = 0;
        decimal OtherCharges = 0;
        decimal SubTotal = 0;
        decimal TaxPercentage = 0;
        decimal TaxAmount = 0;
        decimal DiscountPercentage = 0;
        decimal DiscountAmount = 0;
        decimal FinalAmount = 0;
        int StatusId = -1;
        DateTime DueDate = DateTime.Now;
        DateTime CreatedDate = DateTime.Now;
        bool IsActive = false;


        // استدعاء الـ DAL التي تستخدم SP_Invoices_GetByID
        bool isFound = clsInvoicesData.GetInvoiceInfoByID(InvoiceId, ref VisitId, ref PatientId, ref InvoiceNumber, ref InvoiceDate, ref ConsultationFee, ref LabTestFee, ref ProcedureFee, ref OtherCharges, ref SubTotal, ref TaxPercentage, ref TaxAmount, ref DiscountPercentage, ref DiscountAmount, ref FinalAmount, ref StatusId, ref DueDate, ref CreatedDate, ref IsActive);

        if (isFound)
            return new clsInvoice(InvoiceId, VisitId, PatientId, InvoiceNumber, InvoiceDate, ConsultationFee, LabTestFee, ProcedureFee, OtherCharges, SubTotal, TaxPercentage, TaxAmount, DiscountPercentage, DiscountAmount, FinalAmount, StatusId, DueDate, CreatedDate, IsActive);
        else
            return null;
    }

    // 4. Save Method (The core Business Logic decision)
    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewInvoice())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateInvoice();
        }
        return false;
    }

    public string GenerateInvoiceNumber()
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


    // 5. Private CRUD helpers that talk to the DAL Stored Procedures
    private bool _AddNewInvoice()
    {
        // استدعاء الـ DAL التي تستخدم SP_Invoices_Add
        this.InvoiceId = clsInvoicesData.AddNewInvoice(this.VisitId, this.PatientId, this.InvoiceNumber, this.InvoiceDate, this.ConsultationFee, this.LabTestFee, this.ProcedureFee, this.OtherCharges, this.SubTotal, this.TaxPercentage, this.TaxAmount, this.DiscountPercentage, this.DiscountAmount, this.FinalAmount, this.StatusId, this.DueDate, this.CreatedDate, this.IsActive);
        return (this.InvoiceId != -1);
    }

    private bool _UpdateInvoice()
    {
        // استدعاء الـ DAL التي تستخدم SP_Invoices_Update
        return clsInvoicesData.UpdateInvoice(this.InvoiceId, this.VisitId, this.PatientId, this.InvoiceNumber, this.InvoiceDate, this.ConsultationFee, this.LabTestFee, this.ProcedureFee, this.OtherCharges, this.SubTotal, this.TaxPercentage, this.TaxAmount, this.DiscountPercentage, this.DiscountAmount, this.FinalAmount, this.StatusId, this.DueDate, this.CreatedDate, this.IsActive);
    }

    // 6. Static Methods for list operations
    public static ObservableCollection<clsInvoice> GetAllInvoices()
    {
        return clsInvoicesData.GetAllInvoices().ToObservableCollection<clsInvoice>();
    }

    public static ObservableCollection<clsInvoice> GetAllInvoices_Sorted()
    {
        return clsInvoicesData.GetAllInvoices_Sorted().ToObservableCollection<clsInvoice>();
    }

    public static bool Delete(int InvoiceId)
    {
        return clsInvoicesData.DeleteInvoice(InvoiceId);
    }

    public static bool IsExist(int InvoiceId)
    {
        return clsInvoicesData.IsInvoiceExist(InvoiceId);
    }
}