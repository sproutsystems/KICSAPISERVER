using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Offermembertypes
    {
        public short OfferMemberTypeId { get; set; }
        public Guid OfferId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Offer Offer { get; set; }
    }
}
