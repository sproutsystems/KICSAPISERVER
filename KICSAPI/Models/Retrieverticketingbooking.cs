using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingbooking
    {
        public Retrieverticketingbooking()
        {
            Retrieverticketingbookinglog = new HashSet<Retrieverticketingbookinglog>();
            Retrieverticketingbookingreceipt = new HashSet<Retrieverticketingbookingreceipt>();
            Retrieverticketingbookingtickets = new HashSet<Retrieverticketingbookingtickets>();
            Retrieverticketingvoucher = new HashSet<Retrieverticketingvoucher>();
        }

        public Guid RetrieverTicketingBookingId { get; set; }
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
        public bool IsCommitted { get; set; }
        public bool IsReceiptSent { get; set; }
        public bool IsError { get; set; }
        public int WorkstationId { get; set; }
        public string ErrorText { get; set; }
        public string PriceGroup { get; set; }
        public decimal DefaultBookingFeePerTicket { get; set; }
        public bool IsAllocatedSeating { get; set; }
        public string CreditCardNumberCvv { get; set; }
        public short? CompanyCreditCardTypeId { get; set; }
        public int? PaymentGatewayTransactionId { get; set; }
        public string Source { get; set; }
        public int? RetrieverTicketingSettingVifdataId { get; set; }
        public bool IsSendSms { get; set; }
        public int? SmslogId { get; set; }
        public decimal Smscost { get; set; }
        public string StoredValueCardNumber { get; set; }
        public string StoredValueCardPin { get; set; }
        public decimal? StoredValueCardStartingBalance { get; set; }
        public decimal? StoredValueCardClosingBalance { get; set; }
        public decimal StoredValueCardPaymentAmount { get; set; }
        public bool? IsStoredValueCardValid { get; set; }
        public bool? IsStoredValueCardCharged { get; set; }
        public decimal CreditCardPaymentAmount { get; set; }
        public bool IsJoinMailingList { get; set; }
        public int? RetrieverTicketingPromoId { get; set; }
        public bool? IsRedeemVoucher { get; set; }
        public Guid? RetrieverKey { get; set; }
        public string RetrieverConfimationNumber { get; set; }
        public bool IsPaypal { get; set; }

        public Cinema Cinema { get; set; }
        public Companycreditcardtypes CompanyCreditCardType { get; set; }
        public Paymentgatewaytransaction PaymentGatewayTransaction { get; set; }
        public Retrieverticketingbooking RetrieverTicketingBooking { get; set; }
        public Retrieverticketingsettingdata RetrieverTicketingSettingVifdata { get; set; }
        public Screen Screen { get; set; }
        public Session Session { get; set; }
        public Retrieverticketingbooking InverseRetrieverTicketingBooking { get; set; }
        public ICollection<Retrieverticketingbookinglog> Retrieverticketingbookinglog { get; set; }
        public ICollection<Retrieverticketingbookingreceipt> Retrieverticketingbookingreceipt { get; set; }
        public ICollection<Retrieverticketingbookingtickets> Retrieverticketingbookingtickets { get; set; }
        public ICollection<Retrieverticketingvoucher> Retrieverticketingvoucher { get; set; }
    }
}
