using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixbookinglog
    {
        public long KtixBookingLogId { get; set; }
        public Guid KtixBookingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Ktixbooking KtixBooking { get; set; }
    }
}
