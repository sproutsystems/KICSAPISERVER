using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Helpdeskstandardresponse
    {
        public short HelpdeskStandardResponseId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public short HelpdeskTicketStatusId { get; set; }
        public short? HelpdeskCategoryId { get; set; }

        public Helpdeskcategory HelpdeskCategory { get; set; }
        public Helpdeskticketstatus HelpdeskTicketStatus { get; set; }
    }
}
