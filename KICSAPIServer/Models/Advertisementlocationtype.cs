using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementlocationtype
    {
        public Advertisementlocationtype()
        {
            Advertisement = new HashSet<Advertisement>();
            Advertisementlocation = new HashSet<Advertisementlocation>();
            Moviebanner = new HashSet<Moviebanner>();
            Siteadvertisementlocationtypes = new HashSet<Siteadvertisementlocationtypes>();
        }

        public Guid AdvertisementLocationTypeId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public short ContentTypeId { get; set; }
        public bool? IsUseDayFilter { get; set; }

        public Contenttype ContentType { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Advertisementlocation> Advertisementlocation { get; set; }
        public ICollection<Moviebanner> Moviebanner { get; set; }
        public ICollection<Siteadvertisementlocationtypes> Siteadvertisementlocationtypes { get; set; }
    }
}
