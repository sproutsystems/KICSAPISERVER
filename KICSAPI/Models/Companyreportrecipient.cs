using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyreportrecipient
    {
        public int CompanyReportRecipientId { get; set; }
        public Guid CompanyId { get; set; }
        public int ReportDeliveryFrequencyInDays { get; set; }
        public DateTime LastReportDeliveryDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public bool IsCsvformat { get; set; }

        public Company Company { get; set; }
    }
}
