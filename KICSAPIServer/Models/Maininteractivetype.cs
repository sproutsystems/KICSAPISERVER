using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Maininteractivetype
    {
        public Maininteractivetype()
        {
            Sitedisplaysetting = new HashSet<Sitedisplaysetting>();
        }

        public int MainInteractiveTypeId { get; set; }
        public string Name { get; set; }
        public string UserControlFileName { get; set; }
        public int? CssId { get; set; }

        public Css Css { get; set; }
        public ICollection<Sitedisplaysetting> Sitedisplaysetting { get; set; }
    }
}
