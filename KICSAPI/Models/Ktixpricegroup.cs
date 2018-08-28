using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixpricegroup
    {
        public Ktixpricegroup()
        {
            Ktixbooking = new HashSet<Ktixbooking>();
            Ktixpricegroupcomboitems = new HashSet<Ktixpricegroupcomboitems>();
            Ktixpricegroupsaleitems = new HashSet<Ktixpricegroupsaleitems>();
            Ktixpricegroupvouchertypes = new HashSet<Ktixpricegroupvouchertypes>();
            Ktixsession = new HashSet<Ktixsession>();
        }

        public Guid KtixPriceGroupId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public bool? IsAllowTransferDestination { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Ktixpricegroupcomboitems> Ktixpricegroupcomboitems { get; set; }
        public ICollection<Ktixpricegroupsaleitems> Ktixpricegroupsaleitems { get; set; }
        public ICollection<Ktixpricegroupvouchertypes> Ktixpricegroupvouchertypes { get; set; }
        public ICollection<Ktixsession> Ktixsession { get; set; }
    }
}
