using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Competitionquestionoptions
    {
        public Competitionquestionoptions()
        {
            Competitionentryanswers = new HashSet<Competitionentryanswers>();
        }

        public short CompetitionQuestionOptionId { get; set; }
        public Guid CompetitionQuestionId { get; set; }
        public string Text { get; set; }
        public short ListOrder { get; set; }
        public bool IsCorrectAnswer { get; set; }

        public Competitionquestion CompetitionQuestion { get; set; }
        public ICollection<Competitionentryanswers> Competitionentryanswers { get; set; }
    }
}
