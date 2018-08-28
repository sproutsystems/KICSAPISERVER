using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membercustomansweroptions
    {
        public long MemberCustomAnswerOptionId { get; set; }
        public long MemberCustomAnswerId { get; set; }
        public short MemberTypeCustomQuestionOptionId { get; set; }

        public Membercustomanswers MemberCustomAnswer { get; set; }
        public Membertypecustomquestionoption MemberTypeCustomQuestionOption { get; set; }
    }
}
