using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Crmtype
    {
        public Crmtype()
        {
            Cinema = new HashSet<Cinema>();
        }

        public short CrmtypeId { get; set; }
        public string Name { get; set; }
        public bool IsLogCreate { get; set; }
        public bool IsLogUpdate { get; set; }
        public bool IsLogRenewal { get; set; }

        public ICollection<Cinema> Cinema { get; set; }
    }
}
