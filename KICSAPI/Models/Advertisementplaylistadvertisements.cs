using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisementplaylistadvertisements
    {
        public int AdvertisementPlayListContentId { get; set; }
        public Guid AdvertisementPlayListId { get; set; }
        public Guid AdvertisementId { get; set; }
        public short PlaybackOrder { get; set; }

        public Advertisement Advertisement { get; set; }
        public Advertisementplaylist AdvertisementPlayList { get; set; }
    }
}
