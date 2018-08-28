using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemaretrieverconfig
    {
        public int CinemaRetrieverConfigId { get; set; }
        public Guid CinemaId { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
    }
}
