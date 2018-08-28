using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Memberofferviewlog
    {
        public long MemberOfferViewLogId { get; set; }
        public Guid MemberId { get; set; }
        public Guid OfferId { get; set; }
        public DateTime DateTime { get; set; }

        public Member Member { get; set; }
        public Offer Offer { get; set; }
    }
}
