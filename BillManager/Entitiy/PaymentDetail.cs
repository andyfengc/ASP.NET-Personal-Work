using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.Entitiy
{
    public class PaymentDetail
    {
        public string PayeeName { get; set; }
        public string AccountNumber{get;set;}
        public double Amount { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
