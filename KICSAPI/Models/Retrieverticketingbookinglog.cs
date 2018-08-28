using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingbookinglog
    {
        public long RetrieverTicketingBookingLogId { get; set; }
        public Guid RetrieverTicketingBookingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Retrieverticketingbooking RetrieverTicketingBooking { get; set; }
    }
}
