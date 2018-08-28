using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Featuredmovieelements
    {
        public short FeaturedMovieElementId { get; set; }
        public string PassThroughData { get; set; }
        public Guid CinemaGroupId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public short DisplayOrder { get; set; }
        public Guid MovieInstanceId { get; set; }

        public Cinemagroup CinemaGroup { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
