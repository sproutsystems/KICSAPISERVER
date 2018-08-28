using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailarchive
    {
        public Emailarchive()
        {
            Emailmembers = new HashSet<Emailmembers>();
        }

        public long EmailArchiveId { get; set; }
        public Guid EmailId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CinemaList { get; set; }
        public string Html { get; set; }
        public bool IsSent { get; set; }
        public string MessageGearsResponseId { get; set; }
        public bool IsCancelled { get; set; }

        public Email Email { get; set; }
        public ICollection<Emailmembers> Emailmembers { get; set; }
    }
}
