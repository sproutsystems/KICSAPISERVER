using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingsettingseattype
    {
        public short RetrieverTicketingSettingSeatTypeId { get; set; }
        public Guid RetrieverTicketingTicketSettingId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Retrieverticketingsetting RetrieverTicketingTicketSetting { get; set; }
    }
}
