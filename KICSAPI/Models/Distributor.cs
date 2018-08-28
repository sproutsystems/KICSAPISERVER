using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Distributor
    {
        public Distributor()
        {
            Moviedetail = new HashSet<Moviedetail>();
        }

        public short DistributorId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public short CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Moviedetail> Moviedetail { get; set; }
    }
}
