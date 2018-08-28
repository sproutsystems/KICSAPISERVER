using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementlocationcinemagroup
    {
        public Advertisementlocationcinemagroup()
        {
            Advertisementlocationplaylistschedule = new HashSet<Advertisementlocationplaylistschedule>();
            Advertisementplaylist = new HashSet<Advertisementplaylist>();
        }

        public Guid AdvertisementLocationCinemaGroupId { get; set; }
        public Guid AdvertisementLocationId { get; set; }
        public Guid? CinemaGroupId { get; set; }

        public Advertisementlocation AdvertisementLocation { get; set; }
        public Cinemagroup CinemaGroup { get; set; }
        public ICollection<Advertisementlocationplaylistschedule> Advertisementlocationplaylistschedule { get; set; }
        public ICollection<Advertisementplaylist> Advertisementplaylist { get; set; }
    }
}
