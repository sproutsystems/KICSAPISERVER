using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Systembugtype
    {
        public Systembugtype()
        {
            Systembug = new HashSet<Systembug>();
        }

        public int SystemBugTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Systembug> Systembug { get; set; }
    }
}
