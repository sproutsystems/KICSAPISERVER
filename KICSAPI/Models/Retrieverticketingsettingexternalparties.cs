using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingsettingexternalparties
    {
        public int RetrieverTicketingSettingExternalPartyId { get; set; }
        public Guid RetrieverTicketingSettingId { get; set; }
        public int RetrieverTicketingExternalPartyId { get; set; }
        public string OrderCompleteText { get; set; }

        public Retrieverticketingexternalparty RetrieverTicketingExternalParty { get; set; }
        public Retrieverticketingsetting RetrieverTicketingSetting { get; set; }
    }
}
