using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Page
    {
        public Page()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Movieinstance = new HashSet<Movieinstance>();
            PagelinksDestinationPage = new HashSet<Pagelinks>();
            PagelinksOriginPage = new HashSet<Pagelinks>();
            Pagemenu = new HashSet<Pagemenu>();
            Pagemenupages = new HashSet<Pagemenupages>();
            PageredirectDestinationPage = new HashSet<Pageredirect>();
            PageredirectOriginPage = new HashSet<Pageredirect>();
            Pageregion = new HashSet<Pageregion>();
            Sitefooterlinks = new HashSet<Sitefooterlinks>();
        }

        public Guid PageId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid SiteId { get; set; }
        public short PageTypeId { get; set; }
        public Guid? SidebarId { get; set; }
        public Guid? HeaderAdvertisementLocationId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int? CssId { get; set; }
        public bool IsUnique { get; set; }
        public Guid? FooterId { get; set; }
        public Guid? DrawerId { get; set; }
        public Guid? SiteMenuId { get; set; }
        public int? CarouselId { get; set; }

        public AspnetUsers AuthorUser { get; set; }
        public Carousel Carousel { get; set; }
        public Css Css { get; set; }
        public Drawer Drawer { get; set; }
        public Footer Footer { get; set; }
        public Pagetype PageType { get; set; }
        public Sidebar Sidebar { get; set; }
        public Site Site { get; set; }
        public Sitemenu SiteMenu { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Movieinstance> Movieinstance { get; set; }
        public ICollection<Pagelinks> PagelinksDestinationPage { get; set; }
        public ICollection<Pagelinks> PagelinksOriginPage { get; set; }
        public ICollection<Pagemenu> Pagemenu { get; set; }
        public ICollection<Pagemenupages> Pagemenupages { get; set; }
        public ICollection<Pageredirect> PageredirectDestinationPage { get; set; }
        public ICollection<Pageredirect> PageredirectOriginPage { get; set; }
        public ICollection<Pageregion> Pageregion { get; set; }
        public ICollection<Sitefooterlinks> Sitefooterlinks { get; set; }
    }
}
