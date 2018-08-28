using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pagemenu
    {
        public Pagemenu()
        {
            Pagemenupages = new HashSet<Pagemenupages>();
        }

        public Guid PageMenuId { get; set; }
        public string Name { get; set; }
        public Guid SiteId { get; set; }
        public short DisplayOrder { get; set; }
        public Guid? PageId { get; set; }
        public string Anchor { get; set; }
        public bool? IsDisplayOnMobile { get; set; }
        public bool? IsDisplayOnTablet { get; set; }
        public bool? IsDisplayOnDesktop { get; set; }
        public short DisplayOrderDesktop { get; set; }
        public short DisplayOrderTablet { get; set; }
        public short DisplayOrderMobile { get; set; }
        public Guid SiteMenuId { get; set; }

        public Page Page { get; set; }
        public Site Site { get; set; }
        public ICollection<Pagemenupages> Pagemenupages { get; set; }
    }
}
