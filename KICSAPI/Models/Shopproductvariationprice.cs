using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopproductvariationprice
    {
        public Shopproductvariationprice()
        {
            Shopcartitems = new HashSet<Shopcartitems>();
            Shoporderproducts = new HashSet<Shoporderproducts>();
            Shopproductvariationpricecinemas = new HashSet<Shopproductvariationpricecinemas>();
        }

        public Guid ShopProductVariationPriceId { get; set; }
        public Guid ShopProductId { get; set; }
        public decimal PriceIncludingTax { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public short ListOrder { get; set; }
        public Guid? ShopPriceGroupId { get; set; }

        public Shoppricegroup ShopPriceGroup { get; set; }
        public Shopproduct ShopProduct { get; set; }
        public ICollection<Shopcartitems> Shopcartitems { get; set; }
        public ICollection<Shoporderproducts> Shoporderproducts { get; set; }
        public ICollection<Shopproductvariationpricecinemas> Shopproductvariationpricecinemas { get; set; }
    }
}
