using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Systembugcomment
    {
        public int SystemBugCommentId { get; set; }
        public int SystemBugId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Message { get; set; }

        public Systembug SystemBug { get; set; }
        public AspnetUsers User { get; set; }
    }
}
