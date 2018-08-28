using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemavenuemasterconfig
    {
        public Guid VenueMasterConfigId { get; set; }
        public Guid CinemaId { get; set; }
        public int ConnectionPort { get; set; }
        public string AuthKey { get; set; }
        public string SiteCode { get; set; }
        public string AgentId { get; set; }
        public string Ipaddress { get; set; }
        public string SiteName { get; set; }
        public bool IsCrminstalled { get; set; }
        public int? VenueMasterCrmconfigId { get; set; }

        public Cinema Cinema { get; set; }
        public Venuemastercrmconfig VenueMasterCrmconfig { get; set; }
    }
}
