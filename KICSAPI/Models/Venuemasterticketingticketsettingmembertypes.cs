using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingticketsettingmembertypes
    {
        public short VenueMasterTicketingTicketSettingMemberTypeId { get; set; }
        public Guid VenueMasterTicketingTicketSettingId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Venuemasterticketingticketsetting VenueMasterTicketingTicketSetting { get; set; }
    }
}
