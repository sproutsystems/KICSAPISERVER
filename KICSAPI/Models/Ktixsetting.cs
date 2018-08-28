using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixsetting
    {
        public Ktixsetting()
        {
            Ktixbooking = new HashSet<Ktixbooking>();
            Ktixcomboitem = new HashSet<Ktixcomboitem>();
            Ktixitemgroup = new HashSet<Ktixitemgroup>();
            Ktixkioskcategory = new HashSet<Ktixkioskcategory>();
            Ktixkioskorder = new HashSet<Ktixkioskorder>();
            Ktixkiosksaleitem = new HashSet<Ktixkiosksaleitem>();
            Ktixpricegroup = new HashSet<Ktixpricegroup>();
            Ktixsettingcheckbox = new HashSet<Ktixsettingcheckbox>();
            Ktixvouchertype = new HashSet<Ktixvouchertype>();
        }

        public Guid KtixSettingId { get; set; }
        public Guid CompanyId { get; set; }
        public string SendReceiptFromEmailAddress { get; set; }
        public string SendReceiptFromName { get; set; }
        public string EmergencyContactEmailAddress { get; set; }
        public string EmergencyContactMobile { get; set; }
        public bool IsActive { get; set; }
        public bool? IsSortedByPrice { get; set; }
        public string StartPageMessage { get; set; }
        public string VoucherRedemptionInstructions { get; set; }
        public string GeneralTermsAndConditionsText { get; set; }
        public string GeneralReceiptText { get; set; }
        public short MinimumTicketsPerOrder { get; set; }
        public short MaximumTicketsPerOrder { get; set; }
        public decimal DefaultBookingFeePerTicket { get; set; }
        public string MobileReceiptText { get; set; }
        public string MobileIntroduction { get; set; }
        public int CutoffNumberOfMinutes { get; set; }

        public Company Company { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Ktixcomboitem> Ktixcomboitem { get; set; }
        public ICollection<Ktixitemgroup> Ktixitemgroup { get; set; }
        public ICollection<Ktixkioskcategory> Ktixkioskcategory { get; set; }
        public ICollection<Ktixkioskorder> Ktixkioskorder { get; set; }
        public ICollection<Ktixkiosksaleitem> Ktixkiosksaleitem { get; set; }
        public ICollection<Ktixpricegroup> Ktixpricegroup { get; set; }
        public ICollection<Ktixsettingcheckbox> Ktixsettingcheckbox { get; set; }
        public ICollection<Ktixvouchertype> Ktixvouchertype { get; set; }
    }
}
