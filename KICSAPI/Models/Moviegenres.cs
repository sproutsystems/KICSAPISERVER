using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Moviegenres
    {
        public int MovieGenreId { get; set; }
        public Guid MovieId { get; set; }
        public short GenreId { get; set; }

        public Genre Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
