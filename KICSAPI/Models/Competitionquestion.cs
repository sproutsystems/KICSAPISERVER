using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Competitionquestion
    {
        public Competitionquestion()
        {
            Competitionentryanswers = new HashSet<Competitionentryanswers>();
            Competitionquestionoptions = new HashSet<Competitionquestionoptions>();
        }

        public Guid CompetitionQuestionId { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public short Points { get; set; }
        public short ListOrder { get; set; }
        public Guid CompetitionId { get; set; }
        public bool IsWrittenAnswer { get; set; }
        public short WrittenAnswerWordLimit { get; set; }

        public Competition Competition { get; set; }
        public ICollection<Competitionentryanswers> Competitionentryanswers { get; set; }
        public ICollection<Competitionquestionoptions> Competitionquestionoptions { get; set; }
    }
}
