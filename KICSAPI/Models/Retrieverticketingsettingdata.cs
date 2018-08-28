using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingsettingdata
    {
        public Retrieverticketingsettingdata()
        {
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Retrieverticketingsettingpricegroup = new HashSet<Retrieverticketingsettingpricegroup>();
            Retrieverticketingsettingticket = new HashSet<Retrieverticketingsettingticket>();
        }

        public int RetrieverTicketingSettingDataId { get; set; }
        public Guid RetrieverTicketingSettingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string DataCache { get; set; }
        public bool IsOk { get; set; }
        public DateTime ExpiryDateTime { get; set; }

        public Retrieverticketingsetting RetrieverTicketingSetting { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Retrieverticketingsettingpricegroup> Retrieverticketingsettingpricegroup { get; set; }
        public ICollection<Retrieverticketingsettingticket> Retrieverticketingsettingticket { get; set; }
    }
}
