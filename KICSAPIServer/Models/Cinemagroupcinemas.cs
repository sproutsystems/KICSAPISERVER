using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemagroupcinemas
    {
        public int CinemaGroupCinemasId { get; set; }
        public Guid CinemaGroupId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Cinemagroup CinemaGroup { get; set; }
    }
}
