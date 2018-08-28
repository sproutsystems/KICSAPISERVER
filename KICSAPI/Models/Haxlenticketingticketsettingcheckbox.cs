using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingticketsettingcheckbox
    {
        public short HaxlenTicketingTicketSettingCheckBoxId { get; set; }
        public Guid HaxlenTicketingTicketSettingId { get; set; }
        public string Text { get; set; }
        public bool IsAlwaysShown { get; set; }
        public Guid CinemaId { get; set; }

        public Haxlenticketingticketsetting HaxlenTicketingTicketSetting { get; set; }
    }
}
