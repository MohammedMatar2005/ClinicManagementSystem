using System;

namespace WpfApp3.Models
{
    public class PatientVisitsModel
    {
        // المعرفات الأساسية للربط بين الجداول
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // خصائص العرض (Display Properties) 
        // مهمة جداً لظهور الأسماء بدلاً من الأرقام في الواجهة
        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }

        // بيانات الزيارة الأساسية
        public DateTime VisitDate { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string Notes { get; set; }

        // العلامات الحيوية (Vital Signs)
        public string BloodPressure { get; set; }
        public decimal Temperature { get; set; }
        public int HeartRate { get; set; }
        public int RespiratoryRate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }

        // بيانات التدقيق
        public DateTime CreatedDate { get; set; }
    }
}