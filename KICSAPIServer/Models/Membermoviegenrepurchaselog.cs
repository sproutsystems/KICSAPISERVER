using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membermoviegenrepurchaselog
    {
        public long MemberMovieGenrePurchaseLogId { get; set; }
        public Guid MemberId { get; set; }
        public short GenreId { get; set; }

        public Genre Genre { get; set; }
        public Member Member { get; set; }
    }
}
