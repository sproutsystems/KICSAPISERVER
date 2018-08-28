using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingsettingvifdata
    {
        public Venuemasterticketingsettingvifdata()
        {
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
            Venuemasterticketingsettingvifprl = new HashSet<Venuemasterticketingsettingvifprl>();
            Venuemasterticketingsettingviftkt = new HashSet<Venuemasterticketingsettingviftkt>();
        }

        public int VenueMasterTicketingSettingVifdataId { get; set; }
        public Guid VenueMasterTicketingSettingId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string VifdataCache { get; set; }
        public bool IsOk { get; set; }
        public DateTime ExpiryDateTime { get; set; }

        public Venuemasterticketingsetting VenueMasterTicketingSetting { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
        public ICollection<Venuemasterticketingsettingvifprl> Venuemasterticketingsettingvifprl { get; set; }
        public ICollection<Venuemasterticketingsettingviftkt> Venuemasterticketingsettingviftkt { get; set; }
    }
}
