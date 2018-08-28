using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shoporderproducts
    {
        public int ShopOrderProductId { get; set; }
        public int Quantity { get; set; }
        public Guid ShopOrderId { get; set; }
        public Guid ShopProductVariationPriceId { get; set; }
        public string TicketCode { get; set; }
        public string VenueVoucherBarcode { get; set; }
        public DateTime? ExpiryDateTime { get; set; }

        public Shoporder ShopOrder { get; set; }
        public Shopproductvariationprice ShopProductVariationPrice { get; set; }
    }
}
