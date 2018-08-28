using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Includeelementtype
    {
        public Includeelementtype()
        {
            Includeelement = new HashSet<Includeelement>();
        }

        public short IncludeElementTypeId { get; set; }
        public string Name { get; set; }
        public bool IsUseCinemas { get; set; }
        public bool IsUseMemberTypes { get; set; }

        public ICollection<Includeelement> Includeelement { get; set; }
    }
}
