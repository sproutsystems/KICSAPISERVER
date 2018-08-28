using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filtermoviepurchases
    {
        public int FilterMoviePurchaseId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MovieId { get; set; }

        public Filter Filter { get; set; }
        public Movie Movie { get; set; }
    }
}
