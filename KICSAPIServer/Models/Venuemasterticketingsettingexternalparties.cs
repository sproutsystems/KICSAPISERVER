using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingsettingexternalparties
    {
        public int VenueMasterTicketingSettingExternalPartyId { get; set; }
        public Guid VenueMasterTicketingSettingId { get; set; }
        public int VenueMasterTicketingExternalPartyId { get; set; }
        public string OrderCompleteText { get; set; }

        public Venuemasterticketingexternalparty VenueMasterTicketingExternalParty { get; set; }
        public Venuemasterticketingsetting VenueMasterTicketingSetting { get; set; }
    }
}
