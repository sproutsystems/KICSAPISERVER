using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shop
    {
        public Shop()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Shopcart = new HashSet<Shopcart>();
            Shopcategory = new HashSet<Shopcategory>();
            Shopcinema = new HashSet<Shopcinema>();
            Shopdeliverymethod = new HashSet<Shopdeliverymethod>();
            Shopnotification = new HashSet<Shopnotification>();
            Shoporder = new HashSet<Shoporder>();
            Shoppricegroup = new HashSet<Shoppricegroup>();
            Shopsites = new HashSet<Shopsites>();
        }

        public Guid ShopId { get; set; }
        public string Name { get; set; }
        public string ReceiptText { get; set; }
        public Guid CompanyId { get; set; }
        public decimal DefaultPostageAndHandlingFeeIncludingTax { get; set; }
        public string SendingAddress { get; set; }
        public string SendingName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string IntroductionText { get; set; }
        public bool? IsShopTaxInformationOnReceipt { get; set; }
        public string TaxName { get; set; }
        public int TaxPercent { get; set; }
        public string EmailProductDeliveryText { get; set; }
        public bool IsDeliveryPolicyWritten { get; set; }
        public bool IsReturnPolicyWritten { get; set; }
        public string Currency { get; set; }
        public bool? IsGenerateAlerts { get; set; }
        public bool IsGiftEnabled { get; set; }
        public int? CssId { get; set; }
        public bool CommitOrdersToVenue { get; set; }

        public Company Company { get; set; }
        public Css Css { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Shopcart> Shopcart { get; set; }
        public ICollection<Shopcategory> Shopcategory { get; set; }
        public ICollection<Shopcinema> Shopcinema { get; set; }
        public ICollection<Shopdeliverymethod> Shopdeliverymethod { get; set; }
        public ICollection<Shopnotification> Shopnotification { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
        public ICollection<Shoppricegroup> Shoppricegroup { get; set; }
        public ICollection<Shopsites> Shopsites { get; set; }
    }
}
