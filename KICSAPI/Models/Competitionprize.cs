using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Competitionprize
    {
        public Competitionprize()
        {
            Competitionentry = new HashSet<Competitionentry>();
            Competitionwinner = new HashSet<Competitionwinner>();
        }

        public int CompetitionPrizeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short NumberAvailable { get; set; }
        public Guid CompetitionId { get; set; }
        public string TextForWinningEmail { get; set; }
        public short ListOrder { get; set; }
        public string TestRecipientEmailAddress { get; set; }

        public Competition Competition { get; set; }
        public ICollection<Competitionentry> Competitionentry { get; set; }
        public ICollection<Competitionwinner> Competitionwinner { get; set; }
    }
}
