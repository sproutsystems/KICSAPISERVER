using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filtercinemas
    {
        public int FilterCinemaId { get; set; }
        public Guid FilterId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Filter Filter { get; set; }
    }
}
