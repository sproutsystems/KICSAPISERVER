using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class VistaCinemas
    {
        public Guid VistaCinemasId { get; set; }
        public string CinemaId { get; set; }
        public string Name { get; set; }
        public string NameAlt { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Latitute { get; set; }
        public string Longitude { get; set; }
        public string ParkingInfo { get; set; }
        public string LoyaltyCode { get; set; }
        public bool? IsGiftStore { get; set; }
        public string Description { get; set; }
        public string DescriptionAlt { get; set; }
        public string PublicTransport { get; set; }
        public string CurrencyCode { get; set; }
        public bool? AllowPrintAtHomeBookings { get; set; }
        public bool? AllowOnlineVoucherValidation { get; set; }
        public bool? DisplaySofaSeats { get; set; }
        public string TimeZoneId { get; set; }
        public string Hopk { get; set; }
        public string NameTranslations { get; set; }
        public string DescriptionTranslations { get; set; }
        public string ParkingInfoTranslations { get; set; }
        public string PublicTransportTranslations { get; set; }
        public bool? TipsCompulsory { get; set; }
        public string TipPercentages { get; set; }
        public string ServerName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ExpiryDateTime { get; set; }
    }
}
