using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shoppricegroupmembertypes
    {
        public short ShopPriceGroupMemberTypeId { get; set; }
        public Guid ShopPriceGroupId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Shoppricegroup ShopPriceGroup { get; set; }
    }
}
