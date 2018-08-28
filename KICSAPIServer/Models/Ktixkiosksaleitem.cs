using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
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
        public decimal DefaultPrice { get; set; }
        public Guid KtixKioskCategoryId { get; set; }
        public int MaxQuantity { get; set; }
        public int DisplayOrder { get; set; }
        public Boolean IsAvaliable { get; set; }
        public Boolean IsSoldOut { get; set; }


        public Ktixkioskcategory KtixKioskCategory { get; set; }
        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixkioskordersaleitem> Ktixkioskordersaleitem { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
