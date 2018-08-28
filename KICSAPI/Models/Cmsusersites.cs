using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cmsusersites
    {
        public short CmsuserSiteId { get; set; }
        public Guid CmsuserId { get; set; }
        public Guid SiteId { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Site Site { get; set; }
    }
}
