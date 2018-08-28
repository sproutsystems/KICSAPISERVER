using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Siteloginmethods
    {
        public short SiteLoginMethodId { get; set; }
        public Guid SiteId { get; set; }
        public short LoginMethodId { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string SpecialNotes { get; set; }
        public bool IsEnabled { get; set; }
        public short DisplayOrder { get; set; }

        public Loginmethod LoginMethod { get; set; }
        public Site Site { get; set; }
    }
}
