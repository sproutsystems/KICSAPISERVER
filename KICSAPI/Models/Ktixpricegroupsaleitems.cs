using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixpricegroupsaleitems
    {
        public Ktixpricegroupsaleitems()
        {
            Ktixbookingsaleitems = new HashSet<Ktixbookingsaleitems>();
            Ktixtransactioncartitems = new HashSet<Ktixtransactioncartitems>();
        }

        public int KtixPriceGroupSaleItemId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public Guid KtixSaleItemId { get; set; }
        public short DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public decimal BookingFee { get; set; }
        public bool? IsListed { get; set; }
        public int NumberAvailablePerSession { get; set; }

        public Ktixpricegroup KtixPriceGroup { get; set; }
        public Ktixsaleitem KtixSaleItem { get; set; }
        public ICollection<Ktixbookingsaleitems> Ktixbookingsaleitems { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
