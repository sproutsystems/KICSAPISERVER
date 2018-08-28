using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membergenres
    {
        public int MemberGenreId { get; set; }
        public Guid MemberId { get; set; }
        public short GenreId { get; set; }

        public Genre Genre { get; set; }
        public Member Member { get; set; }
    }
}
