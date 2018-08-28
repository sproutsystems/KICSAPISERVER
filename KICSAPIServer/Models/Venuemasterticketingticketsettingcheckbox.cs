using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingticketsettingcheckbox
    {
        public short VenueMasterTicketingTicketSettingCheckBoxId { get; set; }
        public Guid VenueMasterTicketingTicketSettingId { get; set; }
        public string Text { get; set; }
        public bool IsAlwaysShown { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Venuemasterticketingticketsetting VenueMasterTicketingTicketSetting { get; set; }
    }
}
