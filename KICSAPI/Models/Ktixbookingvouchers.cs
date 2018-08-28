using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixbookingvouchers
    {
        public Ktixbookingvouchers()
        {
            Ktixbookingsaleitems = new HashSet<Ktixbookingsaleitems>();
        }

        public int KtixBookingVoucherId { get; set; }
        public Guid KtixBookingId { get; set; }
        public Guid KtixVoucherId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Ktixbooking KtixBooking { get; set; }
        public Ktixvoucher KtixVoucher { get; set; }
        public ICollection<Ktixbookingsaleitems> Ktixbookingsaleitems { get; set; }
    }
}
