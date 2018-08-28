using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movieaudience
    {
        public Movieaudience()
        {
            InverseNextMovieAudience = new HashSet<Movieaudience>();
            Movie = new HashSet<Movie>();
        }

        public int MovieAudienceId { get; set; }
        public string Name { get; set; }
        public int? NextMovieAudienceId { get; set; }

        public Movieaudience NextMovieAudience { get; set; }
        public ICollection<Movieaudience> InverseNextMovieAudience { get; set; }
        public ICollection<Movie> Movie { get; set; }
    }
}
