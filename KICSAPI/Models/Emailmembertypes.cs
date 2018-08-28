using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailmembertypes
    {
        public int EmailMemberTypeId { get; set; }
        public Guid EmailId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Email Email { get; set; }
        public Membertype MemberType { get; set; }
    }
}
