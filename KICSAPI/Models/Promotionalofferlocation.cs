using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotionalofferlocation
    {
        public short PromotionalOfferLocationId { get; set; }
        public string LocationName { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
