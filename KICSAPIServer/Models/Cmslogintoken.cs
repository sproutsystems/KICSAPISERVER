using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cmslogintoken
    {
        public Guid CmsloginTokenId { get; set; }
        public Guid CmsuserId { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public Guid HelpdeskTicketId { get; set; }
        public DateTime? RedemptionDateTime { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Helpdeskticket HelpdeskTicket { get; set; }
    }
}
