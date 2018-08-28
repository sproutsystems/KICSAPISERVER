using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pagetemplateregioncontent
    {
        public Guid PageTemplateRegionContentId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Guid PageTemplateRegionId { get; set; }
        public Guid IncludeElementId { get; set; }
        public string PassThroughData { get; set; }
        public string InformationText { get; set; }

        public Includeelement IncludeElement { get; set; }
    }
}
