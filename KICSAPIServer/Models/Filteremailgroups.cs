using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filteremailgroups
    {
        public int FilterEmailGroupId { get; set; }
        public Guid FilterId { get; set; }
        public Guid EmailGroupId { get; set; }

        public Emailgroup EmailGroup { get; set; }
        public Filter Filter { get; set; }
    }
}
