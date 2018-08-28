using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypeemail
    {
        public Guid MemberTypeEmailId { get; set; }
        public Guid MemberTypeId { get; set; }
        public short MemberTypeEmailTypeId { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public bool? IsEnabled { get; set; }

        public Membertype MemberType { get; set; }
        public Membertypeemailtype MemberTypeEmailType { get; set; }
    }
}
