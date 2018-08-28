using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Flyerpageorientation
    {
        public Flyerpageorientation()
        {
            Flyertype = new HashSet<Flyertype>();
        }

        public int FlyerPageOrientationId { get; set; }
        public string Name { get; set; }

        public ICollection<Flyertype> Flyertype { get; set; }
    }
}
