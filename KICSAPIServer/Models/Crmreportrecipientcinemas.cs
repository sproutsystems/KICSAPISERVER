using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Crmreportrecipientcinemas
    {
        public int CrmreportRecipientCinemaId { get; set; }
        public int CrmreportRecipientId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Crmreportrecipient CrmreportRecipient { get; set; }
    }
}
