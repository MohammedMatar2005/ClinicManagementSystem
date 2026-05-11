using System;

namespace WpfApp3.Models
{
    public class InvoicesModel
    {
        // المعرفات الأساسية
        public int InvoiceId { get; set; }
        public int VisitId { get; set; }
        public int PatientId { get; set; } // مستخدم في الـ DAL/Model للربط

        // معلومات العرض (أسماء كاملة بدل المعرفات فقط)
        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }

        // تفاصيل الفاتورة
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }

        // المبالغ المالية
        public decimal ConsultationFee { get; set; }
        public decimal LabTestFee { get; set; }
        public decimal ProcedureFee { get; set; }
        public decimal OtherCharges { get; set; }

        // الحسابات الضريبية والخصومات
        public decimal SubTotal { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalAmount { get; set; }

        // الحالة والتدقيق
        public int StatusId { get; set; }
        public string StatusName { get; set; } // مفيد جداً للعرض في الـ DataGrid
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}