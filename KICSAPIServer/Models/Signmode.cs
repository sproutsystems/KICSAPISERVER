using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Signmode
    {
        public Signmode()
        {
            Signplaylistschedule = new HashSet<Signplaylistschedule>();
        }

        public short SignModeId { get; set; }
        public string Name { get; set; }

        public ICollection<Signplaylistschedule> Signplaylistschedule { get; set; }
    }
}
