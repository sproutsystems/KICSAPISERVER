using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membermovietypepurchaselog
    {
        public long MemberMovieTypePurchaseLog1 { get; set; }
        public Guid MemberId { get; set; }
        public Guid MovieTypeId { get; set; }

        public Member Member { get; set; }
        public Movietype MovieType { get; set; }
    }
}
