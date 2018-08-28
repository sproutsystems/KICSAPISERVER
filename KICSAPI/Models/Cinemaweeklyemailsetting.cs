using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemaweeklyemailsetting
    {
        public Guid CinemaWeeklyEmailSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public Guid EmailGroupId { get; set; }
        public string DefaultSubject { get; set; }
        public string DefaultIntroduction { get; set; }
        public Guid? EmailId { get; set; }
        public bool IsSelectRandomEmailSubjectTemplate { get; set; }

        public Cinema Cinema { get; set; }
        public Email Email { get; set; }
        public Emailgroup EmailGroup { get; set; }
    }
}
