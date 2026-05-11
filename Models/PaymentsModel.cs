using System;

namespace WpfApp3.Models
{
    public class PaymentsModel
    {
        // المعرفات الأساسية
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }

        // بيانات العرض (للعرض في الـ DataGrid دون الحاجة لاستعلامات إضافية)
        public string PatientFullName { get; set; } // اسم المريض المرتبط بالدفع
        public string InvoiceNumber { get; set; }  // رقم الفاتورة التي تم سدادها

        // تفاصيل عملية الدفع
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }      // نقدي، بطاقة، إلخ
        public string PaymentStatus { get; set; }      // مكتمل، مسترجع، إلخ
        public string TransactionReference { get; set; } // رقم المرجع أو العملية
        public DateTime PaymentDate { get; set; }

        // ملاحظات وتدقيق
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}