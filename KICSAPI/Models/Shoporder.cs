using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shoporder
    {
        public Shoporder()
        {
            Shoporderactivitylog = new HashSet<Shoporderactivitylog>();
            Shoporderproducts = new HashSet<Shoporderproducts>();
        }

        public Guid ShopOrderId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ShipDateTime { get; set; }
        public decimal ProductCostIncludingTax { get; set; }
        public decimal DeliveryCostIncludingTax { get; set; }
        public decimal ProductTaxCost { get; set; }
        public decimal DeliveryTaxCost { get; set; }
        public decimal TotalTaxCost { get; set; }
        public decimal TotalCostIncludingTax { get; set; }
        public bool IsGift { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerSuburb { get; set; }
        public string CustomerPostCode { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string DeliveryFirstname { get; set; }
        public string DeliveryLastname { get; set; }
        public string DeliveryCompanyName { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliverySuburb { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryPhoneNumber { get; set; }
        public Guid? MemberId { get; set; }
        public short ShopOrderStatusId { get; set; }
        public short ShopDeliveryMethodId { get; set; }
        public string NameOnCreditCard { get; set; }
        public short? CompanyCreditCardTypeId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiryMonth { get; set; }
        public string CreditCardExpiryYear { get; set; }
        public string CreditCardNumberCvv { get; set; }
        public bool IsReceiptSent { get; set; }
        public Guid ShopId { get; set; }
        public bool IsDeleted { get; set; }
        public string AdministratorNotes { get; set; }
        public int? PaymentGatewayTransactionId { get; set; }
        public int? ShopCartId { get; set; }
        public int CustomerCountryStateId { get; set; }
        public int DeliveryCountryStateId { get; set; }
        public string ReceiptHtml { get; set; }
        public bool IsEmailDelivery { get; set; }
        public bool IsReceiptSkipped { get; set; }
        public Guid? CinemaId { get; set; }
        public bool IsPdfsent { get; set; }
        public string GiftMessage { get; set; }
        public string GiftSenderName { get; set; }
        public string GiftRecipientName { get; set; }
        public string SimpleCode { get; set; }
        public string TrackingCode { get; set; }
        public bool IsPayPal { get; set; }
        public bool? IsSameAddress { get; set; }
        public string GiftRecipientEmail { get; set; }
        public int WorkstationId { get; set; }
        public string VifbookingKey { get; set; }
        public bool CommitedToVenue { get; set; }

        public Cinema Cinema { get; set; }
        public Companycreditcardtypes CompanyCreditCardType { get; set; }
        public Countrystate CustomerCountryState { get; set; }
        public Countrystate DeliveryCountryState { get; set; }
        public Member Member { get; set; }
        public Shop Shop { get; set; }
        public Shopcart ShopCart { get; set; }
        public Shopdeliverymethod ShopDeliveryMethod { get; set; }
        public Shoporderstatus ShopOrderStatus { get; set; }
        public ICollection<Shoporderactivitylog> Shoporderactivitylog { get; set; }
        public ICollection<Shoporderproducts> Shoporderproducts { get; set; }
    }
}
