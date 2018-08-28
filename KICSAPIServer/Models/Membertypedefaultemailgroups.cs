using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypedefaultemailgroups
    {
        public short MemberTypeDefaultEmailGroupId { get; set; }
        public Guid MemberTypeId { get; set; }
        public Guid EmailGroupId { get; set; }

        public Emailgroup EmailGroup { get; set; }
        public Membertype MemberType { get; set; }
    }
}
