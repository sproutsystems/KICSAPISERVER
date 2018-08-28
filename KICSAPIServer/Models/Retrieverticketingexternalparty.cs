using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingexternalparty
    {
        public Retrieverticketingexternalparty()
        {
            Retrieverticketingsettingexternalparties = new HashSet<Retrieverticketingsettingexternalparties>();
            Retrieverticketingtickettype = new HashSet<Retrieverticketingtickettype>();
        }

        public int RetrieverTicketingExternalPartyId { get; set; }
        public string Name { get; set; }

        public ICollection<Retrieverticketingsettingexternalparties> Retrieverticketingsettingexternalparties { get; set; }
        public ICollection<Retrieverticketingtickettype> Retrieverticketingtickettype { get; set; }
    }
}
