using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pointofsaletype
    {
        public Pointofsaletype()
        {
            Cinema = new HashSet<Cinema>();
        }

        public short PointOfSaleTypeId { get; set; }
        public string Name { get; set; }
        public bool IsAutomaticSessionImport { get; set; }
        public bool IsInstantImportEnabled { get; set; }
        public string ImportInstructions { get; set; }
        public string ImportFinishedInformation { get; set; }

        public ICollection<Cinema> Cinema { get; set; }
    }
}
