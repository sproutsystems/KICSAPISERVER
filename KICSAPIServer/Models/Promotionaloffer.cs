using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Promotionaloffer
    {
        public Guid PromotionalOfferId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public short PromotionalOfferLocationId { get; set; }
        public Guid? PromotionalOfferImageId { get; set; }

        public Promotionaloffersimage PromotionalOfferImage { get; set; }
    }
}
