using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Paymentgatewaytransaction
    {
        public Paymentgatewaytransaction()
        {
            Haxlenticketingbooking = new HashSet<Haxlenticketingbooking>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Membercrmaction = new HashSet<Membercrmaction>();
            Membertransaction = new HashSet<Membertransaction>();
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
        }

        public int PaymentGatewayTransactionId { get; set; }
        public short PaymentGatewayId { get; set; }
        public Guid CompanyId { get; set; }
        public decimal Amount { get; set; }
        public string GatewayTransactionNumber { get; set; }
        public string BankAuthCode { get; set; }
        public string ResponseCode { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CustomerIpaddress { get; set; }
        public short? CompanyCreditCardTypeId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiryMonth { get; set; }
        public string CreditCardExpiryYear { get; set; }
        public DateTime MerchantDate { get; set; }
        public Guid? CinemaPaymentGatewayId { get; set; }

        public Cinemapaymentgateway CinemaPaymentGateway { get; set; }
        public Company Company { get; set; }
        public Companycreditcardtypes CompanyCreditCardType { get; set; }
        public Paymentgateway PaymentGateway { get; set; }
        public ICollection<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Membercrmaction> Membercrmaction { get; set; }
        public ICollection<Membertransaction> Membertransaction { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
    }
}
