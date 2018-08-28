using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemastercrmactiontype
    {
        public Venuemastercrmactiontype()
        {
            Venuemastercrmaction = new HashSet<Venuemastercrmaction>();
        }

        public int VenueMasterCrmactionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Venuemastercrmaction> Venuemastercrmaction { get; set; }
    }
}
