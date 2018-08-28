using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Paymentcreditcardfailurelog
    {
        public long PaymentCreditCardFailureLogId { get; set; }
        public string CreditCardNumber { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
