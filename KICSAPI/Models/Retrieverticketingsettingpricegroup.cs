using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Retrieverticketingsettingpricegroup
    {
        public Retrieverticketingsettingpricegroup()
        {
            Retrieverticketingbookingtickets = new HashSet<Retrieverticketingbookingtickets>();
        }

        public long RetrieverTicketSettingPriceGroupId { get; set; }
        public string PriceGroup { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public bool IsValid { get; set; }
        public long RetrieverTicketSettingTicketId { get; set; }
        public Guid RetrieverTicketingSettingId { get; set; }
        public string LinkCode { get; set; }
        public decimal PriceIncludingLinkedTicket { get; set; }
        public int RetrieverTicketingSettingDataId { get; set; }
        public string RetrieverCinemaId { get; set; }

        public Retrieverticketingsettingticket RetrieverTicketSettingTicket { get; set; }
        public Retrieverticketingsetting RetrieverTicketingSetting { get; set; }
        public Retrieverticketingsettingdata RetrieverTicketingSettingData { get; set; }
        public ICollection<Retrieverticketingbookingtickets> Retrieverticketingbookingtickets { get; set; }
    }
}
