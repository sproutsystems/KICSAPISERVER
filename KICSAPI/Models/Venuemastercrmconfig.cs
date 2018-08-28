using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemastercrmconfig
    {
        public Venuemastercrmconfig()
        {
            Cinemavenuemasterconfig = new HashSet<Cinemavenuemasterconfig>();
            Venuemastercrmaction = new HashSet<Venuemastercrmaction>();
            Venuemastercrmlog = new HashSet<Venuemastercrmlog>();
        }

        public int VenueMasterCrmconfigId { get; set; }
        public int ConnectionPort { get; set; }
        public string AuthorisationCode { get; set; }
        public string SiteCode { get; set; }
        public string Ipaddress { get; set; }
        public string IsSendEmailMatchingFieldName { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? OptOut1EmailGroupId { get; set; }
        public Guid? OptOut2EmailGroupId { get; set; }
        public Guid? OptOut3EmailGroupId { get; set; }
        public string WebServerPort { get; set; }
        public string AdministrationEmail { get; set; }

        public Company Company { get; set; }
        public Emailgroup OptOut1EmailGroup { get; set; }
        public Emailgroup OptOut2EmailGroup { get; set; }
        public Emailgroup OptOut3EmailGroup { get; set; }
        public ICollection<Cinemavenuemasterconfig> Cinemavenuemasterconfig { get; set; }
        public ICollection<Venuemastercrmaction> Venuemastercrmaction { get; set; }
        public ICollection<Venuemastercrmlog> Venuemastercrmlog { get; set; }
    }
}
