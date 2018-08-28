using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companybackgroundrate
    {
        public short CompanyBackgroundRateId { get; set; }
        public int NumberOfBackgroundsStart { get; set; }
        public int NumberOfBackgroundsFinish { get; set; }
        public decimal RatePerBackground { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
