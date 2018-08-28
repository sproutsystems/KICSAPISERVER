using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Paymentblacklist
    {
        public int PaymentBlackListId { get; set; }
        public string CreditCardNumber { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
