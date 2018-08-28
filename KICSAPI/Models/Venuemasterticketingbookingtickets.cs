using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingbookingtickets
    {
        public Guid VenueMasterTicketingBookingTicketId { get; set; }
        public Guid VenueMasterTicketingBookingId { get; set; }
        public string Code { get; set; }
        public decimal Cost { get; set; }
        public decimal BookingFee { get; set; }
        public string SeatNumber { get; set; }
        public string TicketName { get; set; }
        public long? VenueMasterTicketingSettingVifprlid { get; set; }
        public Guid? VenueMasterTicketingTicketSettingId { get; set; }
        public string VoucherCode { get; set; }
        public bool IsRelatedToTicket { get; set; }
        public bool? IsTicket { get; set; }
        public Guid? RelatedTicketId { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public Venuemasterticketingbooking VenueMasterTicketingBooking { get; set; }
        public Venuemasterticketingsettingvifprl VenueMasterTicketingSettingVifprl { get; set; }
        public Venuemasterticketingticketsetting VenueMasterTicketingTicketSetting { get; set; }
    }
}
