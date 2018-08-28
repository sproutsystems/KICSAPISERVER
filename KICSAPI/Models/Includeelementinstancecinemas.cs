using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Includeelementinstancecinemas
    {
        public int IncludeElementInstanceCinemaId { get; set; }
        public int IncludeElementInstanceId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Includeelementinstance IncludeElementInstance { get; set; }
    }
}
