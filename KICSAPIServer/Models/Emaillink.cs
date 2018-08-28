using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emaillink
    {
        public int EmailLinkId { get; set; }
        public Guid EmailId { get; set; }
        public string LinkUrl { get; set; }
        public int NumberOfClicks { get; set; }

        public Email Email { get; set; }
    }
}
