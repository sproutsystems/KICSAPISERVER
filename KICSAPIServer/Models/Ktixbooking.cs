using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixbooking
    {
        public Ktixbooking()
        {
            Ktixbookingcomboitems = new HashSet<Ktixbookingcomboitems>();
            Ktixbookinglog = new HashSet<Ktixbookinglog>();
            Ktixbookingsaleitems = new HashSet<Ktixbookingsaleitems>();
            Ktixbookingvouchers = new HashSet<Ktixbookingvouchers>();
            Ktixmastertransaction = new HashSet<Ktixmastertransaction>();
        }

        public Guid KtixBookingId { get; set; }
        public Guid KtixSettingId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public Guid ScreenId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime SessionDateTime { get; set; }
        public DateTime BookingDateTime { get; set; }
        public long? SessionId { get; set; }
        public Guid? MemberId { get; set; }
        public string MembershipNumber { get; set; }
        public string NameOnCreditCard { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiryMonth { get; set; }
        public string CreditCardExpiryYear { get; set; }
        public string CreditCardNumberCvv { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerPostCode { get; set; }
        public decimal TotalCostOfItems { get; set; }
        public decimal TotalCostOfBookingFees { get; set; }
        public decimal TotalCost { get; set; }
        public string CustomerIpaddress { get; set; }
        public string BookingNumber { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsReceiptSent { get; set; }
        public string ReceiptHtml { get; set; }
        public bool IsError { get; set; }
        public string ErrorText { get; set; }
        public short? CompanyCreditCardTypeId { get; set; }
        public int? PaymentGatewayTransactionId { get; set; }
        public long? KtixSessionId { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsArchived { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Cinema Cinema { get; set; }
        public Companycreditcardtypes CompanyCreditCardType { get; set; }
        public Ktixpricegroup KtixPriceGroup { get; set; }
        public Ktixsession KtixSession { get; set; }
        public Ktixsetting KtixSetting { get; set; }
        public Member Member { get; set; }
        public Paymentgatewaytransaction PaymentGatewayTransaction { get; set; }
        public Screen Screen { get; set; }
        public Session Session { get; set; }
        public ICollection<Ktixbookingcomboitems> Ktixbookingcomboitems { get; set; }
        public ICollection<Ktixbookinglog> Ktixbookinglog { get; set; }
        public ICollection<Ktixbookingsaleitems> Ktixbookingsaleitems { get; set; }
        public ICollection<Ktixbookingvouchers> Ktixbookingvouchers { get; set; }
        public ICollection<Ktixmastertransaction> Ktixmastertransaction { get; set; }
    }
}
