using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemastercrmlog
    {
        public long VenueMasterCrmlogId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid? MemberId { get; set; }
        public bool IsError { get; set; }
        public bool IsImportant { get; set; }
        public int VenueMasterCrmconfigId { get; set; }
        public int? MemberCrmactionId { get; set; }

        public Membercrmaction MemberCrmaction { get; set; }
        public Venuemastercrmconfig VenueMasterCrmconfig { get; set; }
    }
}
