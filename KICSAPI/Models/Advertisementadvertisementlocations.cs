using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisementadvertisementlocations
    {
        public int AdvertisementAdvertisementLocationId { get; set; }
        public Guid AdvertisementId { get; set; }
        public Guid AdvertisementLocationId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Advertisement Advertisement { get; set; }
        public Advertisementlocation AdvertisementLocation { get; set; }
    }
}
