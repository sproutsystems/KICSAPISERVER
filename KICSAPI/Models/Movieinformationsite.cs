using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movieinformationsite
    {
        public short MovieInformationSiteId { get; set; }
        public Guid MovieId { get; set; }
        public short InformationSiteId { get; set; }
        public string Url { get; set; }
        public string ExternalId { get; set; }

        public Informationsite InformationSite { get; set; }
        public Movie Movie { get; set; }
    }
}
