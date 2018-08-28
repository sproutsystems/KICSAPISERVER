using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filtercustomquestionoptions
    {
        public int FilterCustomQuestionOptionId { get; set; }
        public int FilterCustomQuestionId { get; set; }
        public short MemberTypeCustomQuestionOptionId { get; set; }

        public Filtercustomquestions FilterCustomQuestion { get; set; }
    }
}
