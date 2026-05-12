using System;

namespace ClinicProject.Models
{
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int StatusId { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string ReasonForVisit { get; set; }
        public string Notes { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }


        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }
        private string _statusName;
        public string StatusName
        {
            get
            {
                switch (_statusName)
                {
                    case "Pending":
                        return "قيد الانتظار";
                    case "Confirmed":
                        return "مؤكد";
                    case "Completed":
                        return "مكتمل";
                    case "Cancelled":
                        return "ملغي";
                    default:
                        return _statusName; // إرجاع القيمة الأصلية في حال لم تكن ضمن الحالات
                }
            }
            set
            {
                _statusName = value;
            }
        }


        public string StatusColor
        {
            get
            {
                if (string.IsNullOrEmpty(_statusName))
                    return "#000000"; // الأسود كحالة افتراضية

                switch (_statusName.Trim())
                {
                    case "Pending":
                        return "#FFA500"; // برتقالي (قيد الانتظار)
                    case "Confirmed":
                        return "#28A745"; // أخضر (مؤكد)
                    case "Completed":
                        return "#007BFF"; // أزرق (مكتمل)
                    case "Cancelled":
                        return "#DC3545"; // أحمر (ملغي)
                    default:
                        return "#6C757D"; // رمادي لأي حالة أخرى
                }
            }
        }

    }
}