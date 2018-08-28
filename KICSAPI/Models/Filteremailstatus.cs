using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filteremailstatus
    {
        public Filteremailstatus()
        {
            Filter = new HashSet<Filter>();
        }

        public int FilterEmailStatusId { get; set; }
        public string Name { get; set; }

        public ICollection<Filter> Filter { get; set; }
    }
}
