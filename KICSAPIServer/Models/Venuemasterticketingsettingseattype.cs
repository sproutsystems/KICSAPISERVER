using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingsettingseattype
    {
        public short VenueMasterTicketingSettingSeatTypeId { get; set; }
        public Guid VenueMasterTicketingTicketSettingId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Venuemasterticketingsetting VenueMasterTicketingTicketSetting { get; set; }
    }
}
