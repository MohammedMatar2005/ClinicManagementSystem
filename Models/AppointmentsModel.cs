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
        public string StatusName { get; set; }
    }
}