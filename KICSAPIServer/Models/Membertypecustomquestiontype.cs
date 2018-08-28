using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypecustomquestiontype
    {
        public Membertypecustomquestiontype()
        {
            Membertypecustomquestion = new HashSet<Membertypecustomquestion>();
        }

        public short MemberTypeCustomQuestionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Membertypecustomquestion> Membertypecustomquestion { get; set; }
    }
}
