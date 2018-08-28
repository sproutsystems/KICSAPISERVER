using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Flyermovieinstances
    {
        public int FlyerMovieInstanceId { get; set; }
        public Guid FlyerId { get; set; }
        public Guid MovieInstanceId { get; set; }

        public Flyer Flyer { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
