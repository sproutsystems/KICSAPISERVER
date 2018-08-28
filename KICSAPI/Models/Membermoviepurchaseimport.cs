using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membermoviepurchaseimport
    {
        public int MemberMoviePurchaseImportId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Member Member { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
