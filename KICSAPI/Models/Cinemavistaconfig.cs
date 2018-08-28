using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemavistaconfig
    {
        public Guid VistaConfigId { get; set; }
        public Guid CinemaId { get; set; }
        public string ShortName { get; set; }
        public string ServerIpaddress { get; set; }
        public DateTime NextSessionUpdateDateTime { get; set; }
        public string OnlineTicketingUrl { get; set; }

        public Cinema Cinema { get; set; }
    }
}
