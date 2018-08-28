using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Competitioncinemas
    {
        public short CompetitionCinemaId { get; set; }
        public Guid CompetitionId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Competition Competition { get; set; }
    }
}
