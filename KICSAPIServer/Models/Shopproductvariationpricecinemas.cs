using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shopproductvariationpricecinemas
    {
        public int ShopProductVariationPriceCinemaId { get; set; }
        public Guid ShopProductVariationPriceId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Shopproductvariationprice ShopProductVariationPrice { get; set; }
    }
}
