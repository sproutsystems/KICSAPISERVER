using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypecustomquestionoption
    {
        public Membertypecustomquestionoption()
        {
            Membercustomansweroptions = new HashSet<Membercustomansweroptions>();
        }

        public short MemberTypeCustomQuestionOptionId { get; set; }
        public string Text { get; set; }
        public short ListOrder { get; set; }
        public Guid MemberTypeCustomQuestionId { get; set; }
        public bool IsDefaultOptionForImportedRecords { get; set; }

        public Membertypecustomquestion MemberTypeCustomQuestion { get; set; }
        public ICollection<Membercustomansweroptions> Membercustomansweroptions { get; set; }
    }
}
