using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingsetting
    {
        public Retrieverticketingsetting()
        {
            Retrieverticketingpromo = new HashSet<Retrieverticketingpromo>();
            Retrieverticketingsettingdata = new HashSet<Retrieverticketingsettingdata>();
            Retrieverticketingsettingexternalparties = new HashSet<Retrieverticketingsettingexternalparties>();
            Retrieverticketingsettinglog = new HashSet<Retrieverticketingsettinglog>();
            Retrieverticketingsettingpricegroup = new HashSet<Retrieverticketingsettingpricegroup>();
            Retrieverticketingsettingseattype = new HashSet<Retrieverticketingsettingseattype>();
        }

        public Guid RetrieverTicketingSettingId { get; set; }
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
        public bool IsSortedByPrice { get; set; }
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
        public string DataCache { get; set; }
        public DateTime DataCacheExpiryDateTime { get; set; }
        public int DataCacheExpiryInMinutes { get; set; }
        public int DataTicketCacheExpiryInMinutes { get; set; }
        public DateTime ConnectionTestDateTime { get; set; }
        public int ConnectionTestFrequencyInMinutes { get; set; }
        public bool ConnectionTestResult { get; set; }
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
        public ICollection<Retrieverticketingpromo> Retrieverticketingpromo { get; set; }
        public ICollection<Retrieverticketingsettingdata> Retrieverticketingsettingdata { get; set; }
        public ICollection<Retrieverticketingsettingexternalparties> Retrieverticketingsettingexternalparties { get; set; }
        public ICollection<Retrieverticketingsettinglog> Retrieverticketingsettinglog { get; set; }
        public ICollection<Retrieverticketingsettingpricegroup> Retrieverticketingsettingpricegroup { get; set; }
        public ICollection<Retrieverticketingsettingseattype> Retrieverticketingsettingseattype { get; set; }
    }
}
