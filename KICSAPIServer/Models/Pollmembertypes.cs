using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pollmembertypes
    {
        public short PollMemberTypeId { get; set; }
        public Guid PollId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Poll Poll { get; set; }
    }
}
