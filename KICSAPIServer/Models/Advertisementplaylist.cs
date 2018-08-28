using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementplaylist
    {
        public Advertisementplaylist()
        {
            Advertisementlocationplaylistschedule = new HashSet<Advertisementlocationplaylistschedule>();
            Advertisementplaylistadvertisements = new HashSet<Advertisementplaylistadvertisements>();
        }

        public Guid AdvertisementPlaylistId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
        public bool IsRandomPlayback { get; set; }
        public Guid AdvertisementLocationCinemaGroupId { get; set; }

        public Advertisementlocationcinemagroup AdvertisementLocationCinemaGroup { get; set; }
        public ICollection<Advertisementlocationplaylistschedule> Advertisementlocationplaylistschedule { get; set; }
        public ICollection<Advertisementplaylistadvertisements> Advertisementplaylistadvertisements { get; set; }
    }
}
