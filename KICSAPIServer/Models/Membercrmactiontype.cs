using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membercrmactiontype
    {
        public Membercrmactiontype()
        {
            Membercrmaction = new HashSet<Membercrmaction>();
        }

        public int MemberCrmactionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Membercrmaction> Membercrmaction { get; set; }
    }
}
