using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sitefooterlinks
    {
        public Guid SiteFooterLinkId { get; set; }
        public Guid SiteId { get; set; }
        public Guid PageId { get; set; }
        public string Title { get; set; }
        public short DisplayOrder { get; set; }
        public bool? IsDisplayOnMobile { get; set; }
        public bool? IsDisplayOnTablet { get; set; }
        public bool? IsDisplayOnDesktop { get; set; }
        public short DisplayOrderDesktop { get; set; }
        public short DisplayOrderTablet { get; set; }
        public short DisplayOrderMobile { get; set; }

        public Page Page { get; set; }
        public Site Site { get; set; }
    }
}
