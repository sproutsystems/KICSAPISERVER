using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Css
    {
        public Css()
        {
            Cssversion = new HashSet<Cssversion>();
            Drawer = new HashSet<Drawer>();
            Footer = new HashSet<Footer>();
            Includeelement = new HashSet<Includeelement>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Includeelementsites = new HashSet<Includeelementsites>();
            Maininteractivetype = new HashSet<Maininteractivetype>();
            Page = new HashSet<Page>();
            Pagetemplate = new HashSet<Pagetemplate>();
            Pagetype = new HashSet<Pagetype>();
            Shop = new HashSet<Shop>();
            Sidebar = new HashSet<Sidebar>();
            Site = new HashSet<Site>();
        }

        public int CssId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string DesktopCss { get; set; }
        public string TabletCss { get; set; }
        public string MobileCss { get; set; }
        public Guid? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Cssversion> Cssversion { get; set; }
        public ICollection<Drawer> Drawer { get; set; }
        public ICollection<Footer> Footer { get; set; }
        public ICollection<Includeelement> Includeelement { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Includeelementsites> Includeelementsites { get; set; }
        public ICollection<Maininteractivetype> Maininteractivetype { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Pagetemplate> Pagetemplate { get; set; }
        public ICollection<Pagetype> Pagetype { get; set; }
        public ICollection<Shop> Shop { get; set; }
        public ICollection<Sidebar> Sidebar { get; set; }
        public ICollection<Site> Site { get; set; }
    }
}
