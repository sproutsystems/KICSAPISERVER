using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filtermembertype
    {
        public int FilterMemberTypeId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Filter Filter { get; set; }
        public Membertype MemberType { get; set; }
    }
}
