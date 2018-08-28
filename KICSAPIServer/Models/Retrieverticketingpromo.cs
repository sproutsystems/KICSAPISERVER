using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingpromo
    {
        public Retrieverticketingpromo()
        {
            Retrieverticketingticketsetting = new HashSet<Retrieverticketingticketsetting>();
        }

        public int RetrieverTicketingPromoId { get; set; }
        public Guid RetrieverTicketingSettingId { get; set; }
        public string PromoCode { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int MaximumNumberOfRedemptions { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsActive { get; set; }

        public Retrieverticketingsetting RetrieverTicketingSetting { get; set; }
        public ICollection<Retrieverticketingticketsetting> Retrieverticketingticketsetting { get; set; }
    }
}
