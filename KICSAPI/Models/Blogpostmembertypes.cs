using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Blogpostmembertypes
    {
        public int BlogPostMemberTypeId { get; set; }
        public Guid BlogPostId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Blogpost BlogPost { get; set; }
        public Membertype MemberType { get; set; }
    }
}
