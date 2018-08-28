using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessionfilterbuttonmoviecategory
    {
        public int CinemaSessionFilterButtonMovieCategoryId { get; set; }
        public int CinemaSessionFilterButtonId { get; set; }
        public Guid MovieCategoryId { get; set; }

        public Cinemasessionfilterbutton CinemaSessionFilterButton { get; set; }
        public Moviecategory MovieCategory { get; set; }
    }
}
