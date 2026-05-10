using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class AppointmentsModel
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ReasonForVisit { get; set; }
        public int StatusId { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        public string FullDateTimeDisplay => AppointmentDate.ToString("dd/MM/yyyy - hh:mm tt");
        public string PatientName
        { 
            get
            {
                return clsPatient.Find(PatientId).FullName.ToString();
            } 
            set { }
        }

        public string StatusColor
        {
            get
            {
                switch (StatusId)
                {
                    case 1:
                        return "#FFA500"; // Pending
                    case 2:
                        return "#2196F3"; // Confirmed
                    case 3:
                        return "#4CAF50"; // Completed
                    case 4:
                        return "#F44336"; // Cancelled
                    default:
                        return "#757575"; // Default
                }
            }
        }

        public string ActiveColor
        {
            get
            {
                if (IsActive)
                {
                    return "#28A745"; // أخضر (يدل على أن الحساب أو الموعد نشط)
                }
                else
                {
                    return "#6C757D"; // رمادي (يدل على أنه غير نشط أو "مطفي")
                }
            }
        }
    }
}
