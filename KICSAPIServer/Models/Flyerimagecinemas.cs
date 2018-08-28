using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Flyerimagecinemas
    {
        public int FlyerImageCinemaId { get; set; }
        public Guid FlyerImageId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Flyerimage FlyerImage { get; set; }
    }
}
