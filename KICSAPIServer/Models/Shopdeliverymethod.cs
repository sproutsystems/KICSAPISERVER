using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shopdeliverymethod
    {
        public Shopdeliverymethod()
        {
            Shoporder = new HashSet<Shoporder>();
            Shopproductshopdeliverymethods = new HashSet<Shopproductshopdeliverymethods>();
        }

        public short ShopDeliveryMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ShopId { get; set; }
        public decimal PostageAndHandlingFeeIncludingTax { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsPhysicalDelivery { get; set; }
        public string TrackingUrl { get; set; }
        public bool IsTrackingCodeRequired { get; set; }
        public string OrderCompleteEmailText { get; set; }
        public bool IsSendEmailOnOrderComplete { get; set; }

        public Shop Shop { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
        public ICollection<Shopproductshopdeliverymethods> Shopproductshopdeliverymethods { get; set; }
    }
}
