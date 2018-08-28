using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Haxlenticketingbooking
    {
        public Haxlenticketingbooking()
        {
            Haxlenticketbookingvifprl = new HashSet<Haxlenticketbookingvifprl>();
            Haxlenticketbookingviftkt = new HashSet<Haxlenticketbookingviftkt>();
            Haxlenticketingbookinglog = new HashSet<Haxlenticketingbookinglog>();
            Haxlenticketingbookingreceipt = new HashSet<Haxlenticketingbookingreceipt>();
            Haxlenticketingbookingtickets = new HashSet<Haxlenticketingbookingtickets>();
        }

        public Guid HaxlenTicketingBookingId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid ScreenId { get; set; }
        public string SessionPointOfSaleId { get; set; }
        public DateTime SessionDateTime { get; set; }
        public string MovieTitle { get; set; }
        public DateTime BookingDateTime { get; set; }
        public long? SessionId { get; set; }
        public Guid? MemberId { get; set; }
        public string MembershipNumber { get; set; }
        public string NameOnCreditCard { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiryMonth { get; set; }
        public string CreditCardExpiryYear { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerPostCode { get; set; }
        public decimal TotalCostOfTickets { get; set; }
        public decimal TotalCostOfBookingFees { get; set; }
        public decimal TotalCost { get; set; }
        public string CustomerIpaddress { get; set; }
        public string VifalternateKey { get; set; }
        public string VifbookingKey { get; set; }
        public string VifbookingIndex { get; set; }
        public string ViftransactionNumber { get; set; }
        public string VifbookingPin { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsReceiptSent { get; set; }
        public string ReceiptHtml { get; set; }
        public bool IsError { get; set; }
        public int WorkstationId { get; set; }
        public string ErrorText { get; set; }
        public string PriceGroup { get; set; }
        public decimal DefaultBookingFeePerTicket { get; set; }
        public bool IsAllocatedSeating { get; set; }
        public string CreditCardNumberCvv { get; set; }
        public short? CompanyCreditCardTypeId { get; set; }
        public int? PaymentGatewayTransactionId { get; set; }
        public string EventName { get; set; }
        public bool IsPaypal { get; set; }

        public Cinema Cinema { get; set; }
        public Companycreditcardtypes CompanyCreditCardType { get; set; }
        public Paymentgatewaytransaction PaymentGatewayTransaction { get; set; }
        public Screen Screen { get; set; }
        public Session Session { get; set; }
        public ICollection<Haxlenticketbookingvifprl> Haxlenticketbookingvifprl { get; set; }
        public ICollection<Haxlenticketbookingviftkt> Haxlenticketbookingviftkt { get; set; }
        public ICollection<Haxlenticketingbookinglog> Haxlenticketingbookinglog { get; set; }
        public ICollection<Haxlenticketingbookingreceipt> Haxlenticketingbookingreceipt { get; set; }
        public ICollection<Haxlenticketingbookingtickets> Haxlenticketingbookingtickets { get; set; }
    }
}
