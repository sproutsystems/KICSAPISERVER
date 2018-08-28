using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotionaloffersimage
    {
        public Promotionaloffersimage()
        {
            Promotionaloffer = new HashSet<Promotionaloffer>();
        }

        public Guid PromotionalOffersImageId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Promotionaloffer> Promotionaloffer { get; set; }
    }
}
