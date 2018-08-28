using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessiondisplaymoviecategories
    {
        public int CinemaSessionDisplayMovieCategoryId { get; set; }
        public int CinemaSessionDisplayId { get; set; }
        public Guid MovieCategoryId { get; set; }

        public Cinemasessiondisplay CinemaSessionDisplay { get; set; }
        public Moviecategory MovieCategory { get; set; }
    }
}
