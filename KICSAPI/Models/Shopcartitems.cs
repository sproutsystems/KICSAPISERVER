using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopcartitems
    {
        public long ShopCartItemId { get; set; }
        public int ShopCartId { get; set; }
        public Guid ShopProductVariationPriceId { get; set; }
        public short Quantity { get; set; }

        public Shopcart ShopCart { get; set; }
        public Shopproductvariationprice ShopProductVariationPrice { get; set; }
    }
}
