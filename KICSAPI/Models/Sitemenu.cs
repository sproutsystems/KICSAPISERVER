using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sitemenu
    {
        public Sitemenu()
        {
            Page = new HashSet<Page>();
            Siteconfig = new HashSet<Siteconfig>();
        }

        public Guid SiteMenuId { get; set; }
        public Guid SiteId { get; set; }
        public string Name { get; set; }

        public ICollection<Page> Page { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
    }
}
