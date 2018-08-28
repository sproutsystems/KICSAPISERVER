using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixvouchertypeitems
    {
        public int KtixVoucherTypeItemId { get; set; }
        public Guid KtixVoucherTypeId { get; set; }
        public Guid KtixSaleItemId { get; set; }
        public short DisplayOrder { get; set; }
        public int Quantity { get; set; }

        public Ktixsaleitem KtixSaleItem { get; set; }
        public Ktixvouchertype KtixVoucherType { get; set; }
    }
}
