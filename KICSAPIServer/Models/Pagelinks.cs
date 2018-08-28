using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pagelinks
    {
        public short PageLinkId { get; set; }
        public Guid OriginPageId { get; set; }
        public Guid DestinationPageId { get; set; }
        public short DisplayOrder { get; set; }
        public string Title { get; set; }

        public Page DestinationPage { get; set; }
        public Page OriginPage { get; set; }
    }
}
