using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Informationsite
    {
        public Informationsite()
        {
            Movieinformationsite = new HashSet<Movieinformationsite>();
        }

        public short InformationSiteId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<Movieinformationsite> Movieinformationsite { get; set; }
    }
}
