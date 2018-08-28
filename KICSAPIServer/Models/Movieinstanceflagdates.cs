using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstanceflagdates
    {
        public long MovieFlagDateId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public short FlagId { get; set; }
        public DateTime Date { get; set; }
        public Guid CinemaId { get; set; }

        public Flag Flag { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
