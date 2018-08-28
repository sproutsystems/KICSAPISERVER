using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pageredirect
    {
        public Guid PageRedirectId { get; set; }
        public Guid OriginPageId { get; set; }
        public Guid? DestinationPageId { get; set; }
        public string DestinationPageUrl { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Page DestinationPage { get; set; }
        public Page OriginPage { get; set; }
    }
}
