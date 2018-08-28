using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Includeelementinstancemembertypes
    {
        public int IncludeElementInstanceMemberTypeId { get; set; }
        public int IncludeElementInstanceId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Includeelementinstance IncludeElementInstance { get; set; }
        public Membertype MemberType { get; set; }
    }
}
