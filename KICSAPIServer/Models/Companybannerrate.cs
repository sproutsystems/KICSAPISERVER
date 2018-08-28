using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companybannerrate
    {
        public short CompanyBannerRateId { get; set; }
        public int NumberOfBannersStart { get; set; }
        public int NumberOfBannersFinish { get; set; }
        public decimal RatePerBanner { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
