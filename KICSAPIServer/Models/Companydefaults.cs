using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companydefaults
    {
        public Guid CompanyDefaultId { get; set; }
        public Guid CompanyId { get; set; }
        public string CompetitionTermsAndConditions { get; set; }
        public string OfferTermsAndConditions { get; set; }
        public string CompetitionTextForWinningEmail { get; set; }
        public string OfferRedemptionInstruction { get; set; }
        public short WeeklyEmailFrequency { get; set; }

        public Company Company { get; set; }
    }
}
