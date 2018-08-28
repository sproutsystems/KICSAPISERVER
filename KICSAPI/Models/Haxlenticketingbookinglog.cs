using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingbookinglog
    {
        public long HaxlenTicketingBookingLogId { get; set; }
        public Guid HaxlenTicketingBookingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Haxlenticketingbooking HaxlenTicketingBooking { get; set; }
    }
}
