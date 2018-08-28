using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companyfeatures
    {
        public short CompanyFeatureId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public decimal CasualRatePerWeek { get; set; }
        public decimal OngoingRatePerWeek { get; set; }
        public bool IsReady { get; set; }
        public bool IsActiveCasual { get; set; }
        public bool IsActiveOngoing { get; set; }
        public bool IsRequired { get; set; }
        public Guid CompanyId { get; set; }
        public Guid FeatureId { get; set; }
        public short BillingFrequency { get; set; }
        public DateTime LastBilledDateTime { get; set; }

        public Company Company { get; set; }
        public Feature Feature { get; set; }
    }
}
