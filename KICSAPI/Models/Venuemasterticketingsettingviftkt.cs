using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingsettingviftkt
    {
        public Venuemasterticketingsettingviftkt()
        {
            Venuemasterticketingsettingvifprl = new HashSet<Venuemasterticketingsettingvifprl>();
        }

        public long VenueMasterTicketingSettingViftktid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? DefaultPrice { get; set; }
        public bool? IsTicket { get; set; }
        public string LinkCode { get; set; }
        public int LinkQuantity { get; set; }
        public Guid? VenueMasterTicketingTicketTypeId { get; set; }
        public bool IsForSale { get; set; }
        public int VenueMasterTicketingSettingVifdataId { get; set; }
        public bool IsRelatedToTicket { get; set; }
        public long? IsRelatedToTicketId { get; set; }
        public int NumberOfSeats { get; set; }

        public Venuemasterticketingsettingvifdata VenueMasterTicketingSettingVifdata { get; set; }
        public Venuemasterticketingtickettype VenueMasterTicketingTicketType { get; set; }
        public ICollection<Venuemasterticketingsettingvifprl> Venuemasterticketingsettingvifprl { get; set; }
    }
}
