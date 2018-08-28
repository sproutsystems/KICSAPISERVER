using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixbookingsaleitems
    {
        public int KtixBookingSaleItemId { get; set; }
        public Guid KtixBookingId { get; set; }
        public int KtixPriceGroupSaleItemId { get; set; }
        public int? KtixBookingVoucherId { get; set; }

        public Ktixbooking KtixBooking { get; set; }
        public Ktixbookingvouchers KtixBookingVoucher { get; set; }
        public Ktixpricegroupsaleitems KtixPriceGroupSaleItem { get; set; }
    }
}
