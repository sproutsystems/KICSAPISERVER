using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membermovieviewlog
    {
        public long MemberMovieViewLogId { get; set; }
        public Guid MemberId { get; set; }
        public Guid MovieId { get; set; }
        public DateTime DateTime { get; set; }

        public Member Member { get; set; }
        public Movie Movie { get; set; }
    }
}
