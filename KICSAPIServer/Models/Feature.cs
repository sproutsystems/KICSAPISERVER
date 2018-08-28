using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Feature
    {
        public Feature()
        {
            Companyfeatures = new HashSet<Companyfeatures>();
        }

        public Guid FeatureId { get; set; }
        public string Name { get; set; }
        public decimal DefaultCasualRatePerWeek { get; set; }
        public decimal DefaultOngoingRatePerWeek { get; set; }
        public bool IsReadyByDefault { get; set; }
        public bool IsActiveByDefault { get; set; }
        public bool IsRequiredByDefault { get; set; }
        public bool IsAdditionalCinemaAdjusted { get; set; }
        public string Description { get; set; }
        public short DefaultBillingFrequency { get; set; }
        public bool? IsBilledAutomatically { get; set; }
        public bool IsFreeDuringInitialPeriod { get; set; }

        public ICollection<Companyfeatures> Companyfeatures { get; set; }
    }
}
