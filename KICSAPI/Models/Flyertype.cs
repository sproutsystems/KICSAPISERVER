using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Flyertype
    {
        public Flyertype()
        {
            Flyer = new HashSet<Flyer>();
            Flyertypeimageposition = new HashSet<Flyertypeimageposition>();
        }

        public int FlyerTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int FlyerPageOrientationId { get; set; }
        public bool IsIncludesMovieList { get; set; }
        public bool IsIncludesPromotionList { get; set; }
        public int NumberOfImageLocations { get; set; }

        public Flyerpageorientation FlyerPageOrientation { get; set; }
        public ICollection<Flyer> Flyer { get; set; }
        public ICollection<Flyertypeimageposition> Flyertypeimageposition { get; set; }
    }
}
