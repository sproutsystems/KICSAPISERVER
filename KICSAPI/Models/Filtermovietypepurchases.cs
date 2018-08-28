using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filtermovietypepurchases
    {
        public int FilterMovieTypePurchasesId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MovieTypeId { get; set; }

        public Filter Filter { get; set; }
    }
}
