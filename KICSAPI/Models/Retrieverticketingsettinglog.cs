using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingsettinglog
    {
        public int RetrieverTicketingSettingLogId { get; set; }
        public Guid RetrieverTicketingSettingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }

        public Retrieverticketingsetting RetrieverTicketingSetting { get; set; }
    }
}
