using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Moviereviewcompanies
    {
        public int MovieReviewCompanyId { get; set; }
        public int MovieReviewId { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
        public Moviereview MovieReview { get; set; }
    }
}
