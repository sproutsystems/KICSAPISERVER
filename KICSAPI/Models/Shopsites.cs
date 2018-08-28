using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopsites
    {
        public short ShopSiteId { get; set; }
        public Guid ShopId { get; set; }
        public Guid SiteId { get; set; }

        public Shop Shop { get; set; }
        public Site Site { get; set; }
    }
}
