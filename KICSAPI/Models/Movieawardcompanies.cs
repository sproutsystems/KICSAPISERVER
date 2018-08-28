using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movieawardcompanies
    {
        public int MovieAwardCompanyId { get; set; }
        public short MovieAwardId { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
        public Movieaward MovieAward { get; set; }
    }
}
