using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membercinemas
    {
        public long MemberCinemaId { get; set; }
        public Guid MemberId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Member Member { get; set; }
    }
}
