using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shopproduct
    {
        public Shopproduct()
        {
            Shopproductshopdeliverymethods = new HashSet<Shopproductshopdeliverymethods>();
            Shopproductvariationprice = new HashSet<Shopproductvariationprice>();
        }

        public Guid ShopProductId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public short ListOrder { get; set; }
        public string ProcessingInstructions { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Guid ShopCategoryId { get; set; }
        public decimal PostageAndHandlingFeeIncludingTax { get; set; }
        public bool IsAllPriceVariationsDisplayed { get; set; }
        public Guid? DefaultContentId { get; set; }
        public string TermsAndConditions { get; set; }
        public bool? IsTaxable { get; set; }
        public string EmailDeliveryProductHtml { get; set; }
        public string PostageAndHandlingText { get; set; }
        public int MinimumPurchaseNumber { get; set; }
        public int? MaximumPurchaseNumber { get; set; }
        public string FooterDescription { get; set; }
        public bool GetBarcodesFromVenue { get; set; }

        public Shopcategory ShopCategory { get; set; }
        public ICollection<Shopproductshopdeliverymethods> Shopproductshopdeliverymethods { get; set; }
        public ICollection<Shopproductvariationprice> Shopproductvariationprice { get; set; }
    }
}
