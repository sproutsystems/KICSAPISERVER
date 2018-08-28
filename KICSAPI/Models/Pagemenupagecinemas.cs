using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pagemenupagecinemas
    {
        public int PageMenuPageCinemaId { get; set; }
        public short PageMenuPagesId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Pagemenupages PageMenuPages { get; set; }
    }
}
