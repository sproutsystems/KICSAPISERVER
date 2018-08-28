using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemasessioncache
    {
        public int CinemaSessionCacheId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public string ShortGuid { get; set; }

        public Cinema Cinema { get; set; }
    }
}
