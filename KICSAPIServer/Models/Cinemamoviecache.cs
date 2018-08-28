using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemamoviecache
    {
        public int CinemaMovieCacheId { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsNowShowing { get; set; }
        public Guid MovieInstanceId { get; set; }
        public int DisplayOrder { get; set; }

        public Cinema Cinema { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
