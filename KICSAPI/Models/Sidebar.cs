using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sidebar
    {
        public Sidebar()
        {
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Page = new HashSet<Page>();
            Sidebarelement = new HashSet<Sidebarelement>();
            Siteconfig = new HashSet<Siteconfig>();
        }

        public Guid SidebarId { get; set; }
        public string Name { get; set; }
        public Guid SiteId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int FacebookColorSchemeId { get; set; }
        public bool? IsDisplayOnMobile { get; set; }
        public bool? IsDisplayOnTablet { get; set; }
        public bool? IsDisplayOnDesktop { get; set; }
        public int? CssId { get; set; }
        public bool IsDeleted { get; set; }

        public Css Css { get; set; }
        public Facebookcolorscheme FacebookColorScheme { get; set; }
        public Site Site { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Sidebarelement> Sidebarelement { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
    }
}
