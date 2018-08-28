using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisementlocation
    {
        public Advertisementlocation()
        {
            Advertisementadvertisementlocations = new HashSet<Advertisementadvertisementlocations>();
            Advertisementlocationcinemagroup = new HashSet<Advertisementlocationcinemagroup>();
            Siteconfig = new HashSet<Siteconfig>();
        }

        public Guid AdvertisementLocationId { get; set; }
        public string Name { get; set; }
        public Guid AdvertisementLocationTypeId { get; set; }
        public Guid SiteId { get; set; }
        public bool? IsDeletable { get; set; }
        public bool IsDeleted { get; set; }

        public Advertisementlocationtype AdvertisementLocationType { get; set; }
        public Site Site { get; set; }
        public ICollection<Advertisementadvertisementlocations> Advertisementadvertisementlocations { get; set; }
        public ICollection<Advertisementlocationcinemagroup> Advertisementlocationcinemagroup { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
    }
}
