using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingticketsettingcheckbox
    {
        public short RetrieverTicketingTicketSettingCheckBoxId { get; set; }
        public Guid RetrieverTicketingTicketSettingId { get; set; }
        public string Text { get; set; }
        public bool IsAlwaysShown { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Retrieverticketingticketsetting RetrieverTicketingTicketSetting { get; set; }
    }
}
