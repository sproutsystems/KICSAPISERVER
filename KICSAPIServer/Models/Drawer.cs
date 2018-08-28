using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Drawer
    {
        public Drawer()
        {
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Page = new HashSet<Page>();
            Siteconfig = new HashSet<Siteconfig>();
        }

        public Guid DrawerId { get; set; }
        public Guid SiteId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CssId { get; set; }
        public bool IsDeleted { get; set; }

        public Css Css { get; set; }
        public Site Site { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
    }
}
