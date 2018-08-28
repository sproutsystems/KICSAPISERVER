using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingtickettype
    {
        public Haxlenticketingtickettype()
        {
            Haxlenticketbookingviftkt = new HashSet<Haxlenticketbookingviftkt>();
        }

        public Guid HaxlenTicketingTicketTypeId { get; set; }
        public Guid HaxlenTicketingTicketSettingId { get; set; }
        public string TicketCodeToMatch { get; set; }
        public bool? IsTicket { get; set; }
        public bool IsExcluded { get; set; }
        public decimal BookingFee { get; set; }
        public string TicketNameForDisplay { get; set; }
        public string TicketSelectionItemText { get; set; }

        public Haxlenticketingticketsetting HaxlenTicketingTicketSetting { get; set; }
        public ICollection<Haxlenticketbookingviftkt> Haxlenticketbookingviftkt { get; set; }
    }
}
