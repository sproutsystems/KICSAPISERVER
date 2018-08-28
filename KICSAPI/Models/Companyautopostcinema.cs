using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyautopostcinema
    {
        public int CompanyAutoPostCinemaId { get; set; }
        public int CompanyAutoPostId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Companyautopost CompanyAutoPost { get; set; }
    }
}
