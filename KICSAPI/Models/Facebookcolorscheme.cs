using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Facebookcolorscheme
    {
        public Facebookcolorscheme()
        {
            Sidebar = new HashSet<Sidebar>();
            Sitesharingsetting = new HashSet<Sitesharingsetting>();
        }

        public int FacebookColorSchemeId { get; set; }
        public string Name { get; set; }

        public ICollection<Sidebar> Sidebar { get; set; }
        public ICollection<Sitesharingsetting> Sitesharingsetting { get; set; }
    }
}
