using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Competitionentryanswers
    {
        public int CompetitionEntryAnswerId { get; set; }
        public int CompetitionEntryId { get; set; }
        public Guid CompetitionQuestionId { get; set; }
        public string WrittenAnswer { get; set; }
        public short? CompetitionQuestionOptionId { get; set; }

        public Competitionentry CompetitionEntry { get; set; }
        public Competitionquestion CompetitionQuestion { get; set; }
        public Competitionquestionoptions CompetitionQuestionOption { get; set; }
    }
}
