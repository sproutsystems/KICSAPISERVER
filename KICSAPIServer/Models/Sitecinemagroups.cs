using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sitecinemagroups
    {
        public short SiteCinemaGroupId { get; set; }
        public Guid SiteId { get; set; }
        public Guid CinemaGroupId { get; set; }

        public Cinemagroup CinemaGroup { get; set; }
        public Site Site { get; set; }
    }
}
