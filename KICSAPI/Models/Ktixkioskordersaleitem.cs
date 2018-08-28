using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixkioskordersaleitem
    {
        public int KtixKioskOrderSaleItemId { get; set; }
        public Guid KtixKioskOrderId { get; set; }
        public Guid KtixKioskSaleItemId { get; set; }
        public int? Quantity { get; set; }

        public Ktixkioskorder KtixKioskOrder { get; set; }
        public Ktixkiosksaleitem KtixKioskSaleItem { get; set; }
    }
}
