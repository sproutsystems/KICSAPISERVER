using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixpricegroupvouchertypes
    {
        public int KtixPriceGroupVoucherTypeId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public Guid KtixVoucherTypeId { get; set; }

        public Ktixpricegroup KtixPriceGroup { get; set; }
        public Ktixvouchertype KtixVoucherType { get; set; }
    }
}
