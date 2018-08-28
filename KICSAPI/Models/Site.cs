using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Site
    {
        public Site()
        {
            Advertisementlocation = new HashSet<Advertisementlocation>();
            Cmsusersites = new HashSet<Cmsusersites>();
            Companyautopost = new HashSet<Companyautopost>();
            Drawer = new HashSet<Drawer>();
            Email = new HashSet<Email>();
            Footer = new HashSet<Footer>();
            Includeelementsites = new HashSet<Includeelementsites>();
            Member = new HashSet<Member>();
            Offersites = new HashSet<Offersites>();
            Page = new HashSet<Page>();
            Pagemenu = new HashSet<Pagemenu>();
            Pollsites = new HashSet<Pollsites>();
            Shopsites = new HashSet<Shopsites>();
            Sidebar = new HashSet<Sidebar>();
            Siteadvertisementlocationtypes = new HashSet<Siteadvertisementlocationtypes>();
            Sitecinemagroups = new HashSet<Sitecinemagroups>();
            Siteconfig = new HashSet<Siteconfig>();
            Sitedisplaysetting = new HashSet<Sitedisplaysetting>();
            Siteemailsetting = new HashSet<Siteemailsetting>();
            Sitefooterlinks = new HashSet<Sitefooterlinks>();
            Sitehomepagetab = new HashSet<Sitehomepagetab>();
            Siteloginmethods = new HashSet<Siteloginmethods>();
            Sitemaininteractiveautoorder = new HashSet<Sitemaininteractiveautoorder>();
            Sitememberpointawardsetting = new HashSet<Sitememberpointawardsetting>();
            Sitesharingsetting = new HashSet<Sitesharingsetting>();
        }

        public Guid SiteId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public string WebsiteUrl { get; set; }
        public string PageTitle { get; set; }
        public Guid? MemberTypeId { get; set; }
        public bool IsDefaultPagesCreated { get; set; }
        public bool IsResponsive { get; set; }
        public int CssversionNumber { get; set; }
        public string CompiledCsstext { get; set; }
        public int? CssId { get; set; }
        public int? GlobalCssversionId { get; set; }

        public Company Company { get; set; }
        public Css Css { get; set; }
        public Globalcssversion GlobalCssversion { get; set; }
        public Membertype MemberType { get; set; }
        public ICollection<Advertisementlocation> Advertisementlocation { get; set; }
        public ICollection<Cmsusersites> Cmsusersites { get; set; }
        public ICollection<Companyautopost> Companyautopost { get; set; }
        public ICollection<Drawer> Drawer { get; set; }
        public ICollection<Email> Email { get; set; }
        public ICollection<Footer> Footer { get; set; }
        public ICollection<Includeelementsites> Includeelementsites { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Offersites> Offersites { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Pagemenu> Pagemenu { get; set; }
        public ICollection<Pollsites> Pollsites { get; set; }
        public ICollection<Shopsites> Shopsites { get; set; }
        public ICollection<Sidebar> Sidebar { get; set; }
        public ICollection<Siteadvertisementlocationtypes> Siteadvertisementlocationtypes { get; set; }
        public ICollection<Sitecinemagroups> Sitecinemagroups { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
        public ICollection<Sitedisplaysetting> Sitedisplaysetting { get; set; }
        public ICollection<Siteemailsetting> Siteemailsetting { get; set; }
        public ICollection<Sitefooterlinks> Sitefooterlinks { get; set; }
        public ICollection<Sitehomepagetab> Sitehomepagetab { get; set; }
        public ICollection<Siteloginmethods> Siteloginmethods { get; set; }
        public ICollection<Sitemaininteractiveautoorder> Sitemaininteractiveautoorder { get; set; }
        public ICollection<Sitememberpointawardsetting> Sitememberpointawardsetting { get; set; }
        public ICollection<Sitesharingsetting> Sitesharingsetting { get; set; }
    }
}
