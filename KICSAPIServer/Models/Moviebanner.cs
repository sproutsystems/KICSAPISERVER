using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Moviebanner
    {
        public Guid MovieBannerId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid MovieId { get; set; }
        public Guid AdvertisementLocationTypeId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public bool IsFree { get; set; }

        public Advertisementlocationtype AdvertisementLocationType { get; set; }
        public Movie Movie { get; set; }
    }
}
