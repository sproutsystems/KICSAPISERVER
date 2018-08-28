using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sign
    {
        public Sign()
        {
            Signplaylist = new HashSet<Signplaylist>();
            Signplaylistschedule = new HashSet<Signplaylistschedule>();
        }

        public Guid SignId { get; set; }
        public string Name { get; set; }
        public string LocationAndAccessDescription { get; set; }
        public Guid CinemaId { get; set; }
        public bool? IsLandscape { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public DateTime NextUpdateDateTime { get; set; }
        public int? CurrentSignPlaylistContentId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Signplaylist> Signplaylist { get; set; }
        public ICollection<Signplaylistschedule> Signplaylistschedule { get; set; }
    }
}
