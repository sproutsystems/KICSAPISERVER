using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingvoucher
    {
        public int VenueMasterTicketingVoucherId { get; set; }
        public Guid VenueMasterTicketingBookingId { get; set; }
        public int? VoucherTypeId { get; set; }
        public string VoucherBarcode { get; set; }
        public string VoucherTicketCode { get; set; }
        public DateTime? VoucherRedemptionDate { get; set; }
        public DateTime? VoucherExpiryDate { get; set; }
        public bool? IsVoucherUsed { get; set; }
        public string VoucherTicketDescription { get; set; }
    }
}
