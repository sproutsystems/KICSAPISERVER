using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Haxlenticketingbookingreceipt
    {
        public long HaxlenTicketingBookingReceiptId { get; set; }
        public Guid HaxlenTicketingBookingId { get; set; }
        public string ReceiptHtml { get; set; }

        public Haxlenticketingbooking HaxlenTicketingBooking { get; set; }
    }
}
