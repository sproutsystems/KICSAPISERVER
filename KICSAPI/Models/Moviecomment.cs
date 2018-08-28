using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Moviecomment
    {
        public long MovieCommentId { get; set; }
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsApproved { get; set; }
        public Guid CompanyId { get; set; }
        public decimal RatingOutOfFive { get; set; }

        public Company Company { get; set; }
        public Movie Movie { get; set; }
        public AspnetUsers User { get; set; }
    }
}
