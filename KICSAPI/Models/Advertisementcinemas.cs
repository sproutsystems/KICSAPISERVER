using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisementcinemas
    {
        public int AdvertisementCinemaId { get; set; }
        public Guid AdvertisementId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Advertisement Advertisement { get; set; }
        public Cinema Cinema { get; set; }
    }
}
