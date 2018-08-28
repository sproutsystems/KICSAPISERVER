using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Moviepurchasefiltertype
    {
        public Moviepurchasefiltertype()
        {
            Filter = new HashSet<Filter>();
        }

        public int MoviePurchaseFilterTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Filter> Filter { get; set; }
    }
}
