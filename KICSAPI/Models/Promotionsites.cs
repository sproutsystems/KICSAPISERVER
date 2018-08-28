using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotionsites
    {
        public short PromotionSiteId { get; set; }
        public Guid PromotionId { get; set; }
        public Guid SiteId { get; set; }
    }
}
