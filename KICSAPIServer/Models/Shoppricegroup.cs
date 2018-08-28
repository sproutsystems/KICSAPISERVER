using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shoppricegroup
    {
        public Shoppricegroup()
        {
            Shoppricegroupmembertypes = new HashSet<Shoppricegroupmembertypes>();
            Shopproductvariationprice = new HashSet<Shopproductvariationprice>();
        }

        public Guid ShopPriceGroupId { get; set; }
        public string Name { get; set; }
        public Guid ShopId { get; set; }
        public bool IsActive { get; set; }
        public double DefaultPercentDiscount { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsDeleted { get; set; }

        public Shop Shop { get; set; }
        public ICollection<Shoppricegroupmembertypes> Shoppricegroupmembertypes { get; set; }
        public ICollection<Shopproductvariationprice> Shopproductvariationprice { get; set; }
    }
}
