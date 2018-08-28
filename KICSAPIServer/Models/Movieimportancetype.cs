using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieimportancetype
    {
        public Movieimportancetype()
        {
            Movieinstance = new HashSet<Movieinstance>();
        }

        public short MovieImportanceTypeId { get; set; }
        public string Name { get; set; }
        public short NumberOfAdjustmentDays { get; set; }

        public ICollection<Movieinstance> Movieinstance { get; set; }
    }
}
