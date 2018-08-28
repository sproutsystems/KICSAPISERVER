using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movieaward
    {
        public Movieaward()
        {
            Movieawardcompanies = new HashSet<Movieawardcompanies>();
        }

        public short MovieAwardId { get; set; }
        public Guid MovieId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Url { get; set; }
        public Guid? CompanyId { get; set; }
        public bool IsActioned { get; set; }

        public Company Company { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Movieawardcompanies> Movieawardcompanies { get; set; }
    }
}
