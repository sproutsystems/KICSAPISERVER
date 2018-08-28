using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypecustomquestion
    {
        public Membertypecustomquestion()
        {
            Membercustomanswers = new HashSet<Membercustomanswers>();
            Membertypecustomquestionoption = new HashSet<Membertypecustomquestionoption>();
        }

        public Guid MemberTypeCustomQuestionId { get; set; }
        public string Question { get; set; }
        public short ListOrder { get; set; }
        public bool IsRequiredToSignup { get; set; }
        public string DefaultWrittenAnswerForImportedRecords { get; set; }
        public short MemberTypeCustomQuestionTypeId { get; set; }
        public Guid MemberTypeId { get; set; }

        public Membertype MemberType { get; set; }
        public Membertypecustomquestiontype MemberTypeCustomQuestionType { get; set; }
        public ICollection<Membercustomanswers> Membercustomanswers { get; set; }
        public ICollection<Membertypecustomquestionoption> Membertypecustomquestionoption { get; set; }
    }
}
