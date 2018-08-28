using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemafullimagebackground
    {
        public short CinemaFullImageBackgroundId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid FullImageBackgroundId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public Cinema Cinema { get; set; }
        public Fullimagebackground FullImageBackground { get; set; }
    }
}
