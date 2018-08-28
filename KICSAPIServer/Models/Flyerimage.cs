using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Flyerimage
    {
        public Flyerimage()
        {
            Flyerimagecinemas = new HashSet<Flyerimagecinemas>();
        }

        public Guid FlyerImageId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CompanyId { get; set; }
        public int FlyerTypeImagePositionId { get; set; }

        public Company Company { get; set; }
        public Flyertypeimageposition FlyerTypeImagePosition { get; set; }
        public ICollection<Flyerimagecinemas> Flyerimagecinemas { get; set; }
    }
}
