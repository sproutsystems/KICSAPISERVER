using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementlocationplaylistschedule
    {
        public int AdvertisementLocationPlaylistScheduleId { get; set; }
        public Guid AdvertisementLocationCinemaGroupId { get; set; }
        public short TimeId { get; set; }
        public Guid AdvertisementPlayListId { get; set; }

        public Advertisementlocationcinemagroup AdvertisementLocationCinemaGroup { get; set; }
        public Advertisementplaylist AdvertisementPlayList { get; set; }
        public Time Time { get; set; }
    }
}
