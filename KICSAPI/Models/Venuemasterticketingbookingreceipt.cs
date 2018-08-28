using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingbookingreceipt
    {
        public long VenueMasterTicketingBookingReceiptId { get; set; }
        public Guid VenueMasterTicketingBookingId { get; set; }
        public string ReceiptHtml { get; set; }

        public Venuemasterticketingbooking VenueMasterTicketingBooking { get; set; }
    }
}
