using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixpricegroupcomboitems
    {
        public Ktixpricegroupcomboitems()
        {
            Ktixbookingcomboitems = new HashSet<Ktixbookingcomboitems>();
            Ktixtransactioncartitems = new HashSet<Ktixtransactioncartitems>();
        }

        public int KtixPriceGroupComboItemId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public Guid KtixComboItemId { get; set; }
        public short DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public decimal BookingFee { get; set; }
        public int NumberAvailablePerSession { get; set; }

        public Ktixcomboitem KtixComboItem { get; set; }
        public Ktixpricegroup KtixPriceGroup { get; set; }
        public ICollection<Ktixbookingcomboitems> Ktixbookingcomboitems { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
