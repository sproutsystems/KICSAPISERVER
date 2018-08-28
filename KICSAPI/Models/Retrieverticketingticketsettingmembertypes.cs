using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingticketsettingmembertypes
    {
        public short RetrieverTicketingTicketSettingMemberTypeId { get; set; }
        public Guid RetrieverTicketingTicketSettingId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Retrieverticketingticketsetting RetrieverTicketingTicketSetting { get; set; }
    }
}
