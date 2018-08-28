using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Autopost
    {
        public int AutoPostId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? PostDateTime { get; set; }
        public int AutoPostTypeTemplateId { get; set; }
        public string Text { get; set; }
        public string RelatedId { get; set; }
        public string Subject { get; set; }
        public bool IsActioned { get; set; }
        public int CompanyAutoPostId { get; set; }

        public Autoposttypetemplate AutoPostTypeTemplate { get; set; }
        public Companyautopost CompanyAutoPost { get; set; }
    }
}
