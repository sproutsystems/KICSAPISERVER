using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixkiosksaleitem
    {
        public Ktixkiosksaleitem()
        {
            Ktixkioskordersaleitem = new HashSet<Ktixkioskordersaleitem>();
            Ktixtransactioncartitems = new HashSet<Ktixtransactioncartitems>();
        }

        public Guid KtixKioskSaleItemId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public decimal? DefaultPrice { get; set; }
        public Guid KtixKioskCategoryId { get; set; }
        public int MaxQuantity { get; set; }

        public Ktixkioskcategory KtixKioskCategory { get; set; }
        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixkioskordersaleitem> Ktixkioskordersaleitem { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
