using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingbookinglog
    {
        public long VenueMasterTicketingBookingLogId { get; set; }
        public Guid VenueMasterTicketingBookingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Venuemasterticketingbooking VenueMasterTicketingBooking { get; set; }
    }
}
