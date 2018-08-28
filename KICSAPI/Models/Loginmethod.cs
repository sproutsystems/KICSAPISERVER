using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Loginmethod
    {
        public Loginmethod()
        {
            Siteloginmethods = new HashSet<Siteloginmethods>();
        }

        public short LoginMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string SpecialNotes { get; set; }

        public ICollection<Siteloginmethods> Siteloginmethods { get; set; }
    }
}
