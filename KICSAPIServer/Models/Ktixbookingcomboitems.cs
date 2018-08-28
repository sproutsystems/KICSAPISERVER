using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixbookingcomboitems
    {
        public int KtixBookingComboItemId { get; set; }
        public Guid KtixBookingId { get; set; }
        public int KtixPriceGroupComboItemId { get; set; }

        public Ktixbooking KtixBooking { get; set; }
        public Ktixpricegroupcomboitems KtixPriceGroupComboItem { get; set; }
    }
}
