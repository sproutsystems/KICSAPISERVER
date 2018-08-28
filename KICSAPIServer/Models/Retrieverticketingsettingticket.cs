using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingsettingticket
    {
        public Retrieverticketingsettingticket()
        {
            Retrieverticketingsettingpricegroup = new HashSet<Retrieverticketingsettingpricegroup>();
        }

        public long RetrieverTicketingSettingTicketId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? TicketTotal { get; set; }
        public bool IsTicket { get; set; }
        public string LinkCode { get; set; }
        public int LinkQuantity { get; set; }
        public Guid? RetrieverTicketingTicketTypeId { get; set; }
        public bool IsForSale { get; set; }
        public int RetrieverTicketingSettingDataId { get; set; }
        public decimal? TicketPrice { get; set; }
        public decimal? TicketTax { get; set; }
        public int? AreaCatStrCode { get; set; }
        public int NumberOfSeats { get; set; }

        public Retrieverticketingsettingdata RetrieverTicketingSettingData { get; set; }
        public Retrieverticketingtickettype RetrieverTicketingTicketType { get; set; }
        public ICollection<Retrieverticketingsettingpricegroup> Retrieverticketingsettingpricegroup { get; set; }
    }
}
