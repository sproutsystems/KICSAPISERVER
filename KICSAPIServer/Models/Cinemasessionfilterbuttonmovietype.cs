using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessionfilterbuttonmovietype
    {
        public int CinemaSessionFilterButtonMovieTypeId { get; set; }
        public int CinemaSessionFilterButtonId { get; set; }
        public Guid MovieTypeId { get; set; }

        public Cinemasessionfilterbutton CinemaSessionFilterButton { get; set; }
        public Movietype MovieType { get; set; }
    }
}
