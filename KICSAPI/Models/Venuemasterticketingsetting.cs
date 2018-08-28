using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingsetting
    {
        public Venuemasterticketingsetting()
        {
            Venuemasterticketingpromo = new HashSet<Venuemasterticketingpromo>();
            Venuemasterticketingsettingexternalparties = new HashSet<Venuemasterticketingsettingexternalparties>();
            Venuemasterticketingsettinglog = new HashSet<Venuemasterticketingsettinglog>();
            Venuemasterticketingsettingseattype = new HashSet<Venuemasterticketingsettingseattype>();
            Venuemasterticketingsettingvifdata = new HashSet<Venuemasterticketingsettingvifdata>();
            Venuemasterticketingsettingvifprl = new HashSet<Venuemasterticketingsettingvifprl>();
        }

        public Guid VenueMasterTicketingSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public int WorkstationIdFrom { get; set; }
        public int WorkstationIdTo { get; set; }
        public int LastWorkstationId { get; set; }
        public string CashierProfile { get; set; }
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
        public string MobileReceiptText { get; set; }
        public string MobileMemberLoginIntroductionText { get; set; }
        public string MobileIntroduction { get; set; }
        public int CutoffNumberOfMinutes { get; set; }
        public string VifdataCache { get; set; }
        public DateTime VifdataCacheExpiryDateTime { get; set; }
        public int VifdataCacheExpiryInMinutes { get; set; }
        public int VifdataTicketCacheExpiryInMinutes { get; set; }
        public DateTime ConnectionTestDateTime { get; set; }
        public int ConnectionTestFrequencyInMinutes { get; set; }
        public bool? ConnectionTestResult { get; set; }
        public decimal SmsratePerMessageBilledToCustomer { get; set; }
        public bool IsOfferSms { get; set; }
        public int ReportDeliveryFrequencyInDays { get; set; }
        public DateTime LastReportDeliveryDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public bool IsMaskCreditCardNumber { get; set; }
        public bool IsStoredValueCardAccepted { get; set; }
        public decimal BookingFeeForVoucherRedemptions { get; set; }
        public string JoinMailingListText { get; set; }
        public int RedirectPercentageOfTicketingRequestsToMobile { get; set; }
        public bool IsVoucherRedemptionAccepted { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Venuemasterticketingpromo> Venuemasterticketingpromo { get; set; }
        public ICollection<Venuemasterticketingsettingexternalparties> Venuemasterticketingsettingexternalparties { get; set; }
        public ICollection<Venuemasterticketingsettinglog> Venuemasterticketingsettinglog { get; set; }
        public ICollection<Venuemasterticketingsettingseattype> Venuemasterticketingsettingseattype { get; set; }
        public ICollection<Venuemasterticketingsettingvifdata> Venuemasterticketingsettingvifdata { get; set; }
        public ICollection<Venuemasterticketingsettingvifprl> Venuemasterticketingsettingvifprl { get; set; }
    }
}
