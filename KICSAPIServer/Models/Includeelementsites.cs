using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Includeelementsites
    {
        public int IncludeElementSiteId { get; set; }
        public Guid IncludeElementId { get; set; }
        public Guid SiteId { get; set; }
        public int? CssId { get; set; }

        public Css Css { get; set; }
        public Includeelement IncludeElement { get; set; }
        public Site Site { get; set; }
    }
}
