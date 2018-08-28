using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstancemoviecategories
    {
        public int MovieCategoryMovieId { get; set; }
        public Guid MovieCategoryId { get; set; }
        public Guid MovieInstanceId { get; set; }

        public Moviecategory MovieCategory { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
