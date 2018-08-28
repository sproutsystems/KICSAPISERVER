using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingsettingseattype
    {
        public short HaxlenTicketingSettingSeatTypeId { get; set; }
        public Guid HaxlenTicketingTicketSettingId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Haxlenticketingticketsetting HaxlenTicketingTicketSetting { get; set; }
    }
}
