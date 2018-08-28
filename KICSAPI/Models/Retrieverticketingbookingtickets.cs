using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingbookingtickets
    {
        public Guid RetrieverTicketingBookingTicketId { get; set; }
        public Guid RetrieverTicketingBookingId { get; set; }
        public string Code { get; set; }
        public decimal Cost { get; set; }
        public decimal BookingFee { get; set; }
        public string SeatNumber { get; set; }
        public string TicketName { get; set; }
        public long? RetrieverTicketingSettingVifprlid { get; set; }
        public Guid? RetrieverTicketingTicketSettingId { get; set; }
        public string VoucherCode { get; set; }
        public string PosseatId { get; set; }
        public bool IsRelatedToTicket { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public Guid? RelatedTicketId { get; set; }
        public bool? IsTicket { get; set; }

        public Retrieverticketingbooking RetrieverTicketingBooking { get; set; }
        public Retrieverticketingsettingpricegroup RetrieverTicketingSettingVifprl { get; set; }
        public Retrieverticketingticketsetting RetrieverTicketingTicketSetting { get; set; }
    }
}
