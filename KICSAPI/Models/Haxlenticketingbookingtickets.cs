using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingbookingtickets
    {
        public Guid HaxlenTicketingBookingTicketId { get; set; }
        public Guid HaxlenTicketingBookingId { get; set; }
        public string Code { get; set; }
        public decimal Cost { get; set; }
        public decimal BookingFee { get; set; }
        public string SeatNumber { get; set; }
        public string TicketName { get; set; }
        public long HaxlenTicketBookingVifprlid { get; set; }
        public Guid? HaxlenTicketingTicketSettingId { get; set; }

        public Haxlenticketbookingvifprl HaxlenTicketBookingVifprl { get; set; }
        public Haxlenticketingbooking HaxlenTicketingBooking { get; set; }
        public Haxlenticketingticketsetting HaxlenTicketingTicketSetting { get; set; }
    }
}
