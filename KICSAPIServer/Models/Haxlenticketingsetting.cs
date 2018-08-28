using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Haxlenticketingsetting
    {
        public Guid HaxlenTicketingSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public int WorkstationIdFrom { get; set; }
        public int WorkstationIdTo { get; set; }
        public int LastWorkstationId { get; set; }
        public string CashierProfile { get; set; }
        public string EwayCustomerNumber { get; set; }
        public string SendReceiptFromEmailAddress { get; set; }
        public string SendReceiptFromName { get; set; }
        public string StartPageMessage { get; set; }
        public string EmergencyContactEmailAddress { get; set; }
        public string EmergencyContactMobile { get; set; }
        public bool IsActive { get; set; }
        public bool? IsSortedByPrice { get; set; }
        public string GeneralTermsAndConditionsText { get; set; }
        public string GeneralTicketSelectionPageTextAboveTable { get; set; }
        public string GeneralTicketSelectionPageTextBelowTable { get; set; }
        public string GeneralTicketSelectionPageItemIntroduction { get; set; }
        public string GeneralReceiptText { get; set; }
        public string MemberLoginIntroductionText { get; set; }
        public string NotAllocatedSessionPopupText { get; set; }
        public short MinimumTicketsPerOrder { get; set; }
        public short MaximumTicketsPerOrder { get; set; }
        public decimal DefaultBookingFeePerTicket { get; set; }
        public int CutoffNumberOfMinutes { get; set; }

        public Cinema Cinema { get; set; }
    }
}
