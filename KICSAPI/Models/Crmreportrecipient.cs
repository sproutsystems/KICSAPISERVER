using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Crmreportrecipient
    {
        public Crmreportrecipient()
        {
            Crmreportrecipientcinemas = new HashSet<Crmreportrecipientcinemas>();
        }

        public int CrmreportRecipientId { get; set; }
        public Guid CompanyId { get; set; }
        public int ReportDeliveryFrequencyInDays { get; set; }
        public DateTime LastReportDeliveryDate { get; set; }
        public string NotificationEmailAddress { get; set; }

        public Company Company { get; set; }
        public ICollection<Crmreportrecipientcinemas> Crmreportrecipientcinemas { get; set; }
    }
}
