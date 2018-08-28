using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemaveeziconfig
    {
        public Guid VeeziConfigId { get; set; }
        public Guid CinemaId { get; set; }
        public string VeeziAccessToken { get; set; }
        public string SessionTimesApiurl { get; set; }
        public string OnlineTicketingUrl { get; set; }

        public Cinema Cinema { get; set; }
    }
}
