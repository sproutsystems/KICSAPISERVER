using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sitehomepagetabcinemas
    {
        public int SiteHomePageTabCinemaId { get; set; }
        public Guid SiteHomePageTabId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Sitehomepagetab SiteHomePageTab { get; set; }
    }
}
