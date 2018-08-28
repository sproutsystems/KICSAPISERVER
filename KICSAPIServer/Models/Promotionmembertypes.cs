using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Promotionmembertypes
    {
        public int PromotionMemberTypeId { get; set; }
        public Guid PromotionId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Promotion Promotion { get; set; }
    }
}
