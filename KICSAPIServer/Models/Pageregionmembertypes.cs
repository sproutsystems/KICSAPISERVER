using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pageregionmembertypes
    {
        public short PageRegionMemberTypeId { get; set; }
        public Guid PageRegionId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Pageregion PageRegion { get; set; }
    }
}
