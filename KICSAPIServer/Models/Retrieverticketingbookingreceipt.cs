using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingbookingreceipt
    {
        public long RetrieverTicketingBookingReceiptId { get; set; }
        public Guid RetrieverTicketingBookingId { get; set; }
        public string ReceiptHtml { get; set; }

        public Retrieverticketingbooking RetrieverTicketingBooking { get; set; }
    }
}
