using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public
        class DoctorsModel
    {
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public decimal Salary { get; set; }
        public string OfficeLocation { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
