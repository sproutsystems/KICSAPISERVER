using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Memberexitpoll
    {
        public int MemberExitPollId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Answer { get; set; }
        public short DurationOfMembershipInDays { get; set; }

        public Company Company { get; set; }
    }
}
