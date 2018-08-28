using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Paymentgateway
    {
        public Paymentgateway()
        {
            Cinemapaymentgateway = new HashSet<Cinemapaymentgateway>();
            Paymentgatewaytransaction = new HashSet<Paymentgatewaytransaction>();
        }

        public short PaymentGatewayId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Address { get; set; }
        public string TestingAddress { get; set; }
        public int DailyCutOffHour { get; set; }
        public bool? IsCreditCard { get; set; }

        public ICollection<Cinemapaymentgateway> Cinemapaymentgateway { get; set; }
        public ICollection<Paymentgatewaytransaction> Paymentgatewaytransaction { get; set; }
    }
}
