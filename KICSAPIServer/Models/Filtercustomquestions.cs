using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filtercustomquestions
    {
        public Filtercustomquestions()
        {
            Filtercustomquestionoptions = new HashSet<Filtercustomquestionoptions>();
        }

        public int FilterCustomQuestionId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MemberTypeCustomQuestionId { get; set; }

        public Filter Filter { get; set; }
        public ICollection<Filtercustomquestionoptions> Filtercustomquestionoptions { get; set; }
    }
}
