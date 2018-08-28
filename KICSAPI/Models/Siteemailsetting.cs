using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Siteemailsetting
    {
        public Guid SiteEmailSettingId { get; set; }
        public Guid SiteId { get; set; }
        public string SendingAddress { get; set; }
        public string SendingName { get; set; }
        public bool IsEmailTrackingEnabled { get; set; }
        public bool IsUseCustomEmail { get; set; }
        public string ReplyToAddress { get; set; }
        public string SendToAfriendIntroduction { get; set; }
        public string SendToAfriendSubject { get; set; }
        public string CompetitionSendingAddress { get; set; }
        public string CompetitionSendingName { get; set; }

        public Site Site { get; set; }
    }
}
