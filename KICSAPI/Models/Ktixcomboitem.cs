using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixcomboitem
    {
        public Ktixcomboitem()
        {
            Ktixcomboitemsaleitems = new HashSet<Ktixcomboitemsaleitems>();
            Ktixpricegroupcomboitems = new HashSet<Ktixpricegroupcomboitems>();
        }

        public Guid KtixComboItemId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal DefaultBookingFee { get; set; }
        public Guid KtixItemGroupId { get; set; }
        public string Description { get; set; }

        public Ktixitemgroup KtixItemGroup { get; set; }
        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixcomboitemsaleitems> Ktixcomboitemsaleitems { get; set; }
        public ICollection<Ktixpricegroupcomboitems> Ktixpricegroupcomboitems { get; set; }
    }
}
