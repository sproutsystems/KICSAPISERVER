using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixtransactioncartitems
    {
        public long KtixTransactionCartItemsId { get; set; }
        public long KtixTransactionCartId { get; set; }
        public int? KtixPriceGroupSaleItemId { get; set; }
        public int? KtixPriceGroupComboItemId { get; set; }
        public Guid? KtixVoucherId { get; set; }
        public int Quantity { get; set; }
        public Guid? KtixKioskSaleItemId { get; set; }
        public long? SessionId { get; set; }
        public Guid? KTixPriceGroupId { get; set; }

        public Ktixkiosksaleitem KtixKioskSaleItem { get; set; }
        public Ktixpricegroupcomboitems KtixPriceGroupComboItem { get; set; }
        public Ktixpricegroupsaleitems KtixPriceGroupSaleItem { get; set; }
        public Ktixtransactioncart KtixTransactionCart { get; set; }
        public Ktixvoucher KtixVoucher { get; set; }
    }
}
