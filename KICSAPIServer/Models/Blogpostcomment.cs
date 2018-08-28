using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Blogpostcomment
    {
        public short BlogPostCommentId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
        public bool IsApproved { get; set; }
        public Guid UserId { get; set; }
        public Guid BlogPostId { get; set; }

        public Blogpost BlogPost { get; set; }
        public AspnetUsers User { get; set; }
    }
}
