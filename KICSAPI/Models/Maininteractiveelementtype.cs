using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Maininteractiveelementtype
    {
        public Maininteractiveelementtype()
        {
            Maininteractiveelement = new HashSet<Maininteractiveelement>();
        }

        public short MainInteractiveElementTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DataRequirements { get; set; }

        public ICollection<Maininteractiveelement> Maininteractiveelement { get; set; }
    }
}
