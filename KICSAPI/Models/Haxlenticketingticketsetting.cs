using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingticketsetting
    {
        public Haxlenticketingticketsetting()
        {
            Haxlenticketingbookingtickets = new HashSet<Haxlenticketingbookingtickets>();
            Haxlenticketingsettingseattype = new HashSet<Haxlenticketingsettingseattype>();
            Haxlenticketingticketsettingcheckbox = new HashSet<Haxlenticketingticketsettingcheckbox>();
            Haxlenticketingticketsettingmembertypes = new HashSet<Haxlenticketingticketsettingmembertypes>();
            Haxlenticketingtickettype = new HashSet<Haxlenticketingtickettype>();
        }

        public Guid HaxlenTicketingTicketSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string AdditionalReceiptTextAfterGenericText { get; set; }
        public string AdditionalTermsAndConditionsText { get; set; }
        public string AdditionalTicketSelectionPageText { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsPopUpMessage { get; set; }
        public string PopUpMessageText { get; set; }
        public decimal BookingFee { get; set; }

        public ICollection<Haxlenticketingbookingtickets> Haxlenticketingbookingtickets { get; set; }
        public ICollection<Haxlenticketingsettingseattype> Haxlenticketingsettingseattype { get; set; }
        public ICollection<Haxlenticketingticketsettingcheckbox> Haxlenticketingticketsettingcheckbox { get; set; }
        public ICollection<Haxlenticketingticketsettingmembertypes> Haxlenticketingticketsettingmembertypes { get; set; }
        public ICollection<Haxlenticketingtickettype> Haxlenticketingtickettype { get; set; }
    }
}
