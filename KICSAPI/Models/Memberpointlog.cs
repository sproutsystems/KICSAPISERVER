using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Memberpointlog
    {
        public long MemberPointLogId { get; set; }
        public int NumberOfPoints { get; set; }
        public string Reason { get; set; }
        public Guid MemberId { get; set; }
        public DateTime DateTime { get; set; }

        public Member Member { get; set; }
    }
}
