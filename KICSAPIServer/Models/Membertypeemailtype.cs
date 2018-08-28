using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypeemailtype
    {
        public Membertypeemailtype()
        {
            Membertypeemail = new HashSet<Membertypeemail>();
        }

        public short MemberTypeEmailTypeId { get; set; }
        public string Name { get; set; }
        public bool? IsPaidMemberOnly { get; set; }
        public string DefaultText { get; set; }
        public string DefaultSubject { get; set; }

        public ICollection<Membertypeemail> Membertypeemail { get; set; }
    }
}
