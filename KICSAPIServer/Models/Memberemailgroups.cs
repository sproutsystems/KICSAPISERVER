using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Memberemailgroups
    {
        public long MemberEmailGroupId { get; set; }
        public Guid MemberId { get; set; }
        public Guid EmailGroupId { get; set; }

        public Emailgroup EmailGroup { get; set; }
        public Member Member { get; set; }
    }
}
