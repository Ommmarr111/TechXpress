using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechXpress.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public virtual User User { get; set; }
    }
}
