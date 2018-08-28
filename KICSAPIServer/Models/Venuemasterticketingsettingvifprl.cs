using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingsettingvifprl
    {
        public Venuemasterticketingsettingvifprl()
        {
            Venuemasterticketingbookingtickets = new HashSet<Venuemasterticketingbookingtickets>();
        }

        public long VenueMasterTicketSettingVifprlid { get; set; }
        public string PriceGroup { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public bool IsValid { get; set; }
        public long VenueMasterTicketSettingViftktid { get; set; }
        public Guid VenueMasterTicketingSettingId { get; set; }
        public string LinkCode { get; set; }
        public decimal PriceIncludingLinkedTicket { get; set; }
        public int VenueMasterTicketingSettingVifdataId { get; set; }

        public Venuemasterticketingsettingviftkt VenueMasterTicketSettingViftkt { get; set; }
        public Venuemasterticketingsetting VenueMasterTicketingSetting { get; set; }
        public Venuemasterticketingsettingvifdata VenueMasterTicketingSettingVifdata { get; set; }
        public ICollection<Venuemasterticketingbookingtickets> Venuemasterticketingbookingtickets { get; set; }
    }
}
