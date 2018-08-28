using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Haxlenticketbookingvifprl
    {
        public Haxlenticketbookingvifprl()
        {
            Haxlenticketingbookingtickets = new HashSet<Haxlenticketingbookingtickets>();
        }

        public long HaxlenTicketBookingVifprlid { get; set; }
        public string PriceGroup { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public bool IsValid { get; set; }
        public long HaxlenTicketBookingViftktid { get; set; }
        public Guid HaxlenTicketingBookingId { get; set; }

        public Haxlenticketbookingviftkt HaxlenTicketBookingViftkt { get; set; }
        public Haxlenticketingbooking HaxlenTicketingBooking { get; set; }
        public ICollection<Haxlenticketingbookingtickets> Haxlenticketingbookingtickets { get; set; }
    }
}
