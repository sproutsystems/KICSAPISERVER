using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Helpdeskmessage
    {
        public Guid HelpdeskMessageId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public Guid HelpdeskTicketId { get; set; }
        public Guid UserId { get; set; }

        public Helpdeskticket HelpdeskTicket { get; set; }
        public AspnetUsers User { get; set; }
    }
}
