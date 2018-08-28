using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companygenres
    {
        public int CompanyGenreId { get; set; }
        public Guid CompanyId { get; set; }
        public short GenreId { get; set; }

        public Company Company { get; set; }
        public Genre Genre { get; set; }
    }
}
