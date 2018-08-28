using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketbookingviftkt
    {
        public Haxlenticketbookingviftkt()
        {
            Haxlenticketbookingvifprl = new HashSet<Haxlenticketbookingvifprl>();
        }

        public long HaxlenTicketBookingViftktid { get; set; }
        public Guid HaxlenTicketingBookingId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? DefaultPrice { get; set; }
        public bool? IsTicket { get; set; }
        public string LinkCode { get; set; }
        public int LinkQuantity { get; set; }
        public Guid? HaxlenTicketingTicketTypeId { get; set; }
        public bool IsForSale { get; set; }

        public Haxlenticketingbooking HaxlenTicketingBooking { get; set; }
        public Haxlenticketingtickettype HaxlenTicketingTicketType { get; set; }
        public ICollection<Haxlenticketbookingvifprl> Haxlenticketbookingvifprl { get; set; }
    }
}
