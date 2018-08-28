using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companyautopost
    {
        public Companyautopost()
        {
            Autopost = new HashSet<Autopost>();
            Companyautopostcinema = new HashSet<Companyautopostcinema>();
            Companyautoposttypetemplates = new HashSet<Companyautoposttypetemplates>();
        }

        public int CompanyAutoPostId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Credential1 { get; set; }
        public string Credential2 { get; set; }
        public string Credential3 { get; set; }
        public string Credential4 { get; set; }
        public string Credential5 { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool? IsActive { get; set; }
        public Guid SiteId { get; set; }
        public int AutoPostDestinationId { get; set; }
        public DateTime? TokenExpiryDateTime { get; set; }
        public bool? IsLastPostSuccessful { get; set; }

        public Autopostdestination AutoPostDestination { get; set; }
        public Company Company { get; set; }
        public Site Site { get; set; }
        public ICollection<Autopost> Autopost { get; set; }
        public ICollection<Companyautopostcinema> Companyautopostcinema { get; set; }
        public ICollection<Companyautoposttypetemplates> Companyautoposttypetemplates { get; set; }
    }
}
