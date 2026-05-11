using System;

namespace WpfApp3.Models
{
    public class PatientsModel
    {
        // المعرفات الأساسية
        public int PatientId { get; set; }
        public int PersonId { get; set; }

        // معلومات الشخص (ضرورية للعرض في القوائم)
        public string PatientFullName { get; set; } // الاسم الكامل من جدول الأشخاص
        public string PhoneNumber { get; set; }     // رقم الهاتف الأساسي
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }   // لحساب العمر في الواجهة
        public string Gender { get; set; }

        // معلومات الطوارئ والبيانات الطبية
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string MedicalHistory { get; set; }

        // حالة الحساب والتدقيق
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}