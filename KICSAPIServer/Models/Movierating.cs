using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movierating
    {
        public long MovieRatingId { get; set; }
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public decimal RatingOutOfFive { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Movie Movie { get; set; }
        public AspnetUsers User { get; set; }
    }
}
