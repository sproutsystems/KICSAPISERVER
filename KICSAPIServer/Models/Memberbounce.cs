using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Memberbounce
    {
        public int MemberBounceId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Member Member { get; set; }
    }
}
