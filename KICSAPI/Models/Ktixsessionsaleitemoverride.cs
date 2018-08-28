using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixsessionsaleitemoverride
    {
        public int KtixsessionSaleItemOverrideId { get; set; }
        public long KtixSessionId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public Guid KtixSaleItemId { get; set; }
        public int? NumberAvailablePerSession { get; set; }
        public decimal? Price { get; set; }
        public decimal? BookingFee { get; set; }

        public Ktixsaleitem KtixSaleItem { get; set; }
    }
}
