using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixvouchertype
    {
        public Ktixvouchertype()
        {
            Ktixpricegroupvouchertypes = new HashSet<Ktixpricegroupvouchertypes>();
            Ktixvoucher = new HashSet<Ktixvoucher>();
            Ktixvouchertypeitems = new HashSet<Ktixvouchertypeitems>();
        }

        public Guid KtixVoucherTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid KtixSettingId { get; set; }
        public short DisplayOrder { get; set; }
        public string ReceiptHtml { get; set; }
        public string GiftHtml { get; set; }
        public int NumberOfDaysUntilExpiry { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixpricegroupvouchertypes> Ktixpricegroupvouchertypes { get; set; }
        public ICollection<Ktixvoucher> Ktixvoucher { get; set; }
        public ICollection<Ktixvouchertypeitems> Ktixvouchertypeitems { get; set; }
    }
}
