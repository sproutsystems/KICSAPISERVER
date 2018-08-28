using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixmasterpaymenttype
    {
        public long KtixMasterPaymentTypeId { get; set; }
        public Guid KtixMasterTransactionId { get; set; }
        public int KtixPaymentTypeId { get; set; }
        public decimal? CreditCardCardPaidAmount { get; set; }
        public string CreditCardGatewayTransactionNumber { get; set; }
        public bool? IsApproved { get; set; }
        public string BankAuthCode { get; set; }
        public string ResponseCode { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime?  MerchantDate { get; set; }
        public Guid? CinemaPaymentGatewayId { get; set; }
        public decimal? CashPaidAmount { get; set; }
        public Guid? KtixGiftCardId { get; set; }
        public string GiftCardNumber { get; set; }
        public decimal? GiftCardStartingBalance { get; set; }
        public decimal? GiftCardClosingBalance { get; set; }
        public decimal? GiftCardPaymentAmount { get; set; }
        public bool GiftCardValid { get; set; }
        public bool GiftCardCharged { get; set; }
        public decimal? CashReturnedAmount { get; set; }


        public Ktixgiftcard KtixGiftCard { get; set; }
        public Ktixmastertransaction KtixMasterTransaction { get; set; }
        public Ktixpaymenttype KtixPaymentType { get; set; }
    }
}
