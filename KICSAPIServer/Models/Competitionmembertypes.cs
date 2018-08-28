using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Competitionmembertypes
    {
        public short CompetitionMemberTypeId { get; set; }
        public Guid CompetitionId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Competition Competition { get; set; }
        public Membertype MemberType { get; set; }
    }
}
