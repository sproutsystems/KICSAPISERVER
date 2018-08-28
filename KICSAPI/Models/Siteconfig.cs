using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Siteconfig
    {
        public Guid SiteConfigId { get; set; }
        public Guid SiteId { get; set; }
        public short PosterWidthFull { get; set; }
        public short PosterHeightFull { get; set; }
        public short DayId { get; set; }
        public string MemberExitPollOptionList { get; set; }
        public Guid? HeaderAdvertisementLocationId { get; set; }
        public bool IsSslcertificateInstalled { get; set; }
        public string GoogleAnalyticsAccountNumber { get; set; }
        public string GoogleAnalyticsDomainName { get; set; }
        public bool IsWildcardSsl { get; set; }
        public bool IsRedirectToHomeAfterCinemaSelection { get; set; }
        public bool? IsUsePopUpCinemaSelection { get; set; }
        public bool IsRedirectAllRequestsToMobile { get; set; }
        public int RedirectPercentageOfRequestsToMobile { get; set; }
        public bool? IsRedirectIpadToMobile { get; set; }
        public bool? IsRedirectNewRequestsOnly { get; set; }
        public int CacheRefreshInMinutesHome { get; set; }
        public int CacheRefreshInMinutesPromotion { get; set; }
        public int CacheRefreshInMinutesOther { get; set; }
        public Guid? FooterId { get; set; }
        public Guid? DrawerId { get; set; }
        public Guid? SiteMenuId { get; set; }
        public Guid? SidebarId { get; set; }

        public Day Day { get; set; }
        public Drawer Drawer { get; set; }
        public Footer Footer { get; set; }
        public Advertisementlocation HeaderAdvertisementLocation { get; set; }
        public Sidebar Sidebar { get; set; }
        public Site Site { get; set; }
        public Sitemenu SiteMenu { get; set; }
    }
}
