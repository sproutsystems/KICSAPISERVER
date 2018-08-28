using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyemailrate
    {
        public short CompanyEmailRateId { get; set; }
        public int NumberOfEmailsStart { get; set; }
        public int NumberOfEmailsFinish { get; set; }
        public double RatePerEmail { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
