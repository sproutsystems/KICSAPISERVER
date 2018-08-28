using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class AspnetUsers
    {
        public AspnetUsers()
        {
            AdvertisementApprovedByUser = new HashSet<Advertisement>();
            AdvertisementAuthorUser = new HashSet<Advertisement>();
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
            Blogpost = new HashSet<Blogpost>();
            Blogpostcomment = new HashSet<Blogpostcomment>();
            Cmsuser = new HashSet<Cmsuser>();
            Helpdeskmessage = new HashSet<Helpdeskmessage>();
            Helpdeskticket = new HashSet<Helpdeskticket>();
            Member = new HashSet<Member>();
            Moviecomment = new HashSet<Moviecomment>();
            Movierating = new HashSet<Movierating>();
            Page = new HashSet<Page>();
            PageregioncontentApprovedByUser = new HashSet<Pageregioncontent>();
            PageregioncontentAuthorUser = new HashSet<Pageregioncontent>();
            PromotionApprovedByUser = new HashSet<Promotion>();
            PromotionAuthorUser = new HashSet<Promotion>();
            Signcontent = new HashSet<Signcontent>();
            Systembug = new HashSet<Systembug>();
            Systembugcomment = new HashSet<Systembugcomment>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public AspnetApplications Application { get; set; }
        public AspnetMembership AspnetMembership { get; set; }
        public AspnetProfile AspnetProfile { get; set; }
        public ICollection<Advertisement> AdvertisementApprovedByUser { get; set; }
        public ICollection<Advertisement> AdvertisementAuthorUser { get; set; }
        public ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Blogpostcomment> Blogpostcomment { get; set; }
        public ICollection<Cmsuser> Cmsuser { get; set; }
        public ICollection<Helpdeskmessage> Helpdeskmessage { get; set; }
        public ICollection<Helpdeskticket> Helpdeskticket { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Moviecomment> Moviecomment { get; set; }
        public ICollection<Movierating> Movierating { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Pageregioncontent> PageregioncontentApprovedByUser { get; set; }
        public ICollection<Pageregioncontent> PageregioncontentAuthorUser { get; set; }
        public ICollection<Promotion> PromotionApprovedByUser { get; set; }
        public ICollection<Promotion> PromotionAuthorUser { get; set; }
        public ICollection<Signcontent> Signcontent { get; set; }
        public ICollection<Systembug> Systembug { get; set; }
        public ICollection<Systembugcomment> Systembugcomment { get; set; }
    }
}
