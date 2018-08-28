using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sidebarelementmembertypes
    {
        public short SidebarElementMemberTypeId { get; set; }
        public short SidebarElementId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Sidebarelement SidebarElement { get; set; }
    }
}
