using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopcategory
    {
        public Shopcategory()
        {
            Shopproduct = new HashSet<Shopproduct>();
        }

        public Guid ShopCategoryId { get; set; }
        public string Name { get; set; }
        public string IntroductionText { get; set; }
        public Guid ShopId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public short ListOrder { get; set; }
        public bool? IsShowProductDetail { get; set; }
        public Guid? PageId { get; set; }

        public Shop Shop { get; set; }
        public ICollection<Shopproduct> Shopproduct { get; set; }
    }
}
