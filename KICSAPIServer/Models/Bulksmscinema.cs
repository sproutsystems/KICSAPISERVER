using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Bulksmscinema
    {
        public int BulkSmscinemaId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid BulkSmsid { get; set; }

        public Bulksms BulkSms { get; set; }
        public Cinema Cinema { get; set; }
    }
}
