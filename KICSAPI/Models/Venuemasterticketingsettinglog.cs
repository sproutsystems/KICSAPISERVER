using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingsettinglog
    {
        public int VenueMasterTicketingSettingLogId { get; set; }
        public Guid VenueMasterTicketingSettingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Venuemasterticketingsetting VenueMasterTicketingSetting { get; set; }
    }
}
