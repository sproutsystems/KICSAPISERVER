using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companymovierate
    {
        public short CompanyMovieRateId { get; set; }
        public int NumberOfMoviesStart { get; set; }
        public int NumberOfMoviesFinish { get; set; }
        public decimal RatePerMovie { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
