using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessiondisplaymovietypes
    {
        public int CinemaSessionDisplayMovieTypeId { get; set; }
        public int CinemaSessionDisplayId { get; set; }
        public Guid MovieTypeId { get; set; }

        public Cinemasessiondisplay CinemaSessionDisplay { get; set; }
        public Movietype MovieType { get; set; }
    }
}
