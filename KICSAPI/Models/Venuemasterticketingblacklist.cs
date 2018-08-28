using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingblacklist
    {
        public int VenueMasterTicketingBlackListId { get; set; }
        public string CreditCardNumber { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
