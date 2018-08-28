using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Siteadvertisementlocationtypes
    {
        public short SiteAdvertisementLocationTypeId { get; set; }
        public Guid SiteId { get; set; }
        public Guid AdvertisementLocationTypeId { get; set; }

        public Advertisementlocationtype AdvertisementLocationType { get; set; }
        public Site Site { get; set; }
    }
}
