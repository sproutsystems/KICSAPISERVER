using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membermoviepurchaselog
    {
        public long MemberMoviePurchaseLogId { get; set; }
        public Guid MovieDetailId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Member Member { get; set; }
        public Moviedetail MovieDetail { get; set; }
    }
}
