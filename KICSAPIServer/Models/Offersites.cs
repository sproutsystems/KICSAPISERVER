using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Offersites
    {
        public short OfferSiteId { get; set; }
        public Guid OfferId { get; set; }
        public Guid SiteId { get; set; }

        public Offer Offer { get; set; }
        public Site Site { get; set; }
    }
}
