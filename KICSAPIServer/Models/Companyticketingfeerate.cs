using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companyticketingfeerate
    {
        public short CompanyTicketingFeeRateId { get; set; }
        public int NumberOfTicketsStart { get; set; }
        public int NumberOfTicketsFinish { get; set; }
        public decimal RatePerTicket { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
