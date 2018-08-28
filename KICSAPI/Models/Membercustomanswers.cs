using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membercustomanswers
    {
        public Membercustomanswers()
        {
            Membercustomansweroptions = new HashSet<Membercustomansweroptions>();
        }

        public long MemberCustomAnswerId { get; set; }
        public Guid MemberId { get; set; }
        public Guid MemberTypeCustomQuestionId { get; set; }
        public string WrittenAnswer { get; set; }

        public Member Member { get; set; }
        public Membertypecustomquestion MemberTypeCustomQuestion { get; set; }
        public ICollection<Membercustomansweroptions> Membercustomansweroptions { get; set; }
    }
}
