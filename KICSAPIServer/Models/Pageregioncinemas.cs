using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pageregioncinemas
    {
        public short PageRegionCinemaId { get; set; }
        public Guid PageRegionId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Pageregion PageRegion { get; set; }
    }
}
