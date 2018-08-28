using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopcart
    {
        public Shopcart()
        {
            Shopcartitems = new HashSet<Shopcartitems>();
            Shoporder = new HashSet<Shoporder>();
        }

        public int ShopCartId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public Guid ShopId { get; set; }

        public Shop Shop { get; set; }
        public ICollection<Shopcartitems> Shopcartitems { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
    }
}
