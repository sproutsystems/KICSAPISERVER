using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pollsites
    {
        public short PollSiteId { get; set; }
        public Guid PollId { get; set; }
        public Guid SiteId { get; set; }

        public Poll Poll { get; set; }
        public Site Site { get; set; }
    }
}
