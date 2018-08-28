using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixmastertransaction
    {
        public Ktixmastertransaction()
        {
            Ktixmasterpaymenttype = new HashSet<Ktixmasterpaymenttype>();
        }

        public Guid KtixMasterTransactionId { get; set; }
        public Guid KtixBookingId { get; set; }
        public Guid KtixKioskOrderId { get; set; }
        public bool IsPosSale { get; set; }
        public Guid KtixPosTerminalId { get; set; }
        public Guid? CmsuserId { get; set; }
        public decimal? TotalCostOfTransaction { get; set; }
        public decimal? TotalCostOfKioskOrder { get; set; }
        public decimal? TotalCostOfBooking { get; set; }
        public bool IsCommited { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsRefunded { get; set; }
        public string RefundedMessage { get; set; }
        public string ReferenceNumber { get; set; }
        public long? KtixTransactionCartId { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Ktixbooking KtixBooking { get; set; }
        public Ktixkioskorder KtixKioskOrder { get; set; }
        public Ktixposterminal KtixPosTerminal { get; set; }
        public Ktixtransactioncart KtixTransactionCart { get; set; }
        public ICollection<Ktixmasterpaymenttype> Ktixmasterpaymenttype { get; set; }
    }
}
