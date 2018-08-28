using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingpromo
    {
        public Venuemasterticketingpromo()
        {
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
            Venuemasterticketingticketsetting = new HashSet<Venuemasterticketingticketsetting>();
        }

        public int VenueMasterTicketingPromoId { get; set; }
        public Guid VenueMasterTicketingSettingId { get; set; }
        public string PromoCode { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int MaximumNumberOfRedemptions { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsActive { get; set; }

        public Venuemasterticketingsetting VenueMasterTicketingSetting { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
        public ICollection<Venuemasterticketingticketsetting> Venuemasterticketingticketsetting { get; set; }
    }
}
