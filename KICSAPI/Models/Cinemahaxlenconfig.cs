using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemahaxlenconfig
    {
        public Guid HaxlenConfigId { get; set; }
        public Guid CinemaId { get; set; }
        public int ConnectionPort { get; set; }
        public string AuthKey { get; set; }
        public string SiteCode { get; set; }
        public string AgentId { get; set; }
        public string Ipaddress { get; set; }
        public string SiteName { get; set; }

        public Cinema Cinema { get; set; }
    }
}
