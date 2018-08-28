using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Haxlenticketingticketsettingmembertypes
    {
        public short HaxlenTicketingTicketSettingMemberTypeId { get; set; }
        public Guid HaxlenTicketingTicketSettingId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Haxlenticketingticketsetting HaxlenTicketingTicketSetting { get; set; }
        public Membertype MemberType { get; set; }
    }
}
