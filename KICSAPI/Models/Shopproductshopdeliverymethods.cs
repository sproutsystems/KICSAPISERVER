using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopproductshopdeliverymethods
    {
        public int ShopProductShopDeliveryMethodId { get; set; }
        public Guid ShopProductId { get; set; }
        public short ShopDeliveryMethodId { get; set; }

        public Shopdeliverymethod ShopDeliveryMethod { get; set; }
        public Shopproduct ShopProduct { get; set; }
    }
}
