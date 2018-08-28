using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Memberpolloptionlog
    {
        public int MemberPollOptionLogId { get; set; }
        public Guid MemberId { get; set; }
        public Guid PollOptionId { get; set; }
        public DateTime VoteDateTime { get; set; }

        public Member Member { get; set; }
        public Polloption PollOption { get; set; }
    }
}
