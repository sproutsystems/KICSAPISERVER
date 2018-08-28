using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Flyertypeimageposition
    {
        public Flyertypeimageposition()
        {
            Flyerimage = new HashSet<Flyerimage>();
        }

        public int FlyerTypeImagePositionId { get; set; }
        public int FlyerTypeId { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Flyertype FlyerType { get; set; }
        public ICollection<Flyerimage> Flyerimage { get; set; }
    }
}
