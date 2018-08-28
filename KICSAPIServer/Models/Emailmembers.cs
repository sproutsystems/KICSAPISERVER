using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emailmembers
    {
        public int EmailMemberId { get; set; }
        public Guid EmailId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime? SentDateTime { get; set; }
        public bool IsSent { get; set; }
        public long? EmailArchiveId { get; set; }
        public bool IsOpened { get; set; }
        public bool IsBounced { get; set; }

        public Email Email { get; set; }
        public Emailarchive EmailArchive { get; set; }
        public Member Member { get; set; }
    }
}
