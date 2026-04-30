using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class PaymentsModel
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionReference { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }


    }
}
