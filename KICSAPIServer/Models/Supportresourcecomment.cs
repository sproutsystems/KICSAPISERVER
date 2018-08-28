using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Supportresourcecomment
    {
        public int SupportResourceCommentId { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string Text { get; set; }
        public bool IsApproved { get; set; }
        public int SupportResourceId { get; set; }
        public Guid CmsuserId { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Supportresource SupportResource { get; set; }
    }
}
