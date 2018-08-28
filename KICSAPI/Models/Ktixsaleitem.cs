using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixsaleitem
    {
        public Ktixsaleitem()
        {
            Ktixpricegroupsaleitems = new HashSet<Ktixpricegroupsaleitems>();
            Ktixsessionsaleitemoverride = new HashSet<Ktixsessionsaleitemoverride>();
            Ktixvouchertypeitems = new HashSet<Ktixvouchertypeitems>();
        }

        public Guid KtixSaleItemId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal DefaultBookingFee { get; set; }
        public Guid KtixItemGroupId { get; set; }
        public bool? IsTicket { get; set; }
        public Guid? MasterKtixSaleItemId { get; set; }

        public Ktixitemgroup KtixItemGroup { get; set; }
        public ICollection<Ktixpricegroupsaleitems> Ktixpricegroupsaleitems { get; set; }
        public ICollection<Ktixsessionsaleitemoverride> Ktixsessionsaleitemoverride { get; set; }
        public ICollection<Ktixvouchertypeitems> Ktixvouchertypeitems { get; set; }
    }
}
