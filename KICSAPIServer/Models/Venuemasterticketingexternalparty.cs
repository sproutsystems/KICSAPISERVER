using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingexternalparty
    {
        public Venuemasterticketingexternalparty()
        {
            Venuemasterticketingsettingexternalparties = new HashSet<Venuemasterticketingsettingexternalparties>();
            Venuemasterticketingtickettype = new HashSet<Venuemasterticketingtickettype>();
        }

        public int VenueMasterTicketingExternalPartyId { get; set; }
        public string Name { get; set; }

        public ICollection<Venuemasterticketingsettingexternalparties> Venuemasterticketingsettingexternalparties { get; set; }
        public ICollection<Venuemasterticketingtickettype> Venuemasterticketingtickettype { get; set; }
    }
}
