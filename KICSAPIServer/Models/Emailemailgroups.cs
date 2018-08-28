using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emailemailgroups
    {
        public int EmailEmailGroupId { get; set; }
        public Guid EmailId { get; set; }
        public Guid EmailGroupId { get; set; }

        public Email Email { get; set; }
        public Emailgroup EmailGroup { get; set; }
    }
}
