using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixvoucher
    {
        public Ktixvoucher()
        {
            Ktixbookingvouchers = new HashSet<Ktixbookingvouchers>();
            Ktixtransactioncartitems = new HashSet<Ktixtransactioncartitems>();
        }

        public Guid KtixVoucherId { get; set; }
        public Guid KtixVoucherTypeId { get; set; }
        public string SerialNumber { get; set; }
        public string Pin { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? PurchaseDateTime { get; set; }
        public DateTime? RedemptionDateTime { get; set; }
        public DateTime ExpiryDateTime { get; set; }

        public Ktixvouchertype KtixVoucherType { get; set; }
        public ICollection<Ktixbookingvouchers> Ktixbookingvouchers { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
