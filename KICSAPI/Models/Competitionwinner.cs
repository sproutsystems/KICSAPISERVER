using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Competitionwinner
    {
        public int CompetitionWinnerId { get; set; }
        public Guid CompetitionId { get; set; }
        public Guid MemberId { get; set; }
        public int CompetitionPrizeId { get; set; }
        public int CompetitionEntryId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? EmailDateTime { get; set; }

        public Competition Competition { get; set; }
        public Competitionentry CompetitionEntry { get; set; }
        public Competitionprize CompetitionPrize { get; set; }
    }
}
