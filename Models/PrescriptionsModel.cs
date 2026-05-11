using System;

namespace WpfApp3.Models
{
    public class PrescriptionsModel
    {
        // المعرفات الأساسية للربط
        public int PrescriptionId { get; set; }
        public int VisitId { get; set; }
        public int PatientId { get; set; }

        // بيانات العرض (Display Properties)
        public string PatientFullName { get; set; } // لعرض اسم المريض في قائمة الوصفات العامة

        // تفاصيل الدواء والجرعات
        public string MedicineName { get; set; }
        public string Dosage { get; set; }        // مثل: 500mg
        public string Frequency { get; set; }     // مثل: 3 مرات يومياً
        public int Duration { get; set; }         // عدد الأيام
        public string Instructions { get; set; }  // تعليمات إضافية (قبل الأكل، بعد الأكل)
        public int Quantity { get; set; }         // الكمية الإجمالية المصروفة (علبة، شريط، الخ)

        // التواريخ والتدقيق
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}