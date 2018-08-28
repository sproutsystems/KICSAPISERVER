using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cmsusercinemas
    {
        public short CmsuserCinemaId { get; set; }
        public Guid CmsuserId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Cmsuser Cmsuser { get; set; }
    }
}
