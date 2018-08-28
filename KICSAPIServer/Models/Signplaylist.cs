using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Signplaylist
    {
        public Signplaylist()
        {
            Signplaylistcontents = new HashSet<Signplaylistcontents>();
            Signplaylistschedule = new HashSet<Signplaylistschedule>();
        }

        public Guid SignPlaylistId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
        public bool IsRandomPlayback { get; set; }
        public Guid SignId { get; set; }
        public DateTime ModifyDateTime { get; set; }

        public Sign Sign { get; set; }
        public ICollection<Signplaylistcontents> Signplaylistcontents { get; set; }
        public ICollection<Signplaylistschedule> Signplaylistschedule { get; set; }
    }
}
