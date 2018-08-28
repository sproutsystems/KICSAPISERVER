using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Competitionentry
    {
        public Competitionentry()
        {
            Competitionentryanswers = new HashSet<Competitionentryanswers>();
            Competitionwinner = new HashSet<Competitionwinner>();
        }

        public int CompetitionEntryId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int RandomSeed { get; set; }
        public Guid CompetitionId { get; set; }
        public int Points { get; set; }
        public int? CompetitionPrizeId { get; set; }

        public Competition Competition { get; set; }
        public Competitionprize CompetitionPrize { get; set; }
        public Member Member { get; set; }
        public ICollection<Competitionentryanswers> Competitionentryanswers { get; set; }
        public ICollection<Competitionwinner> Competitionwinner { get; set; }
    }
}
