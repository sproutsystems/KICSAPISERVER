using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemapaymentgateway
    {
        public Cinemapaymentgateway()
        {
            Paymentgatewaytransaction = new HashSet<Paymentgatewaytransaction>();
        }

        public Guid CinemaPaymentGatewayId { get; set; }
        public Guid CinemaId { get; set; }
        public short PaymentGatewayId { get; set; }
        public string Credential1 { get; set; }
        public string Credential2 { get; set; }
        public string Credential3 { get; set; }
        public string Credential4 { get; set; }
        public string Credential5 { get; set; }
        public bool? IsTesting { get; set; }
        public string TimeZoneLocationId { get; set; }

        public Cinema Cinema { get; set; }
        public Paymentgateway PaymentGateway { get; set; }
        public ICollection<Paymentgatewaytransaction> Paymentgatewaytransaction { get; set; }
    }
}
