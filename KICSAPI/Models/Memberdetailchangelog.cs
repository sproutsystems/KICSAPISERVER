using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Memberdetailchangelog
    {
        public int MemberDetailChangeLogId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
    }
}
