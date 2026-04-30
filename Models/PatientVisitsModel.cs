using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class PatientVisitsModel
    {
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string BloodPressure { get; set; }
        public decimal Temperature { get; set; }
        public int HeartRate { get; set; }
        public int RespiratoryRate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
