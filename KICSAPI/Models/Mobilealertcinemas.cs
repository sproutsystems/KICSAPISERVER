using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Mobilealertcinemas
    {
        public int MobileAlertCinemaId { get; set; }
        public int MobileAlertId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Mobilealert MobileAlert { get; set; }
    }
}
