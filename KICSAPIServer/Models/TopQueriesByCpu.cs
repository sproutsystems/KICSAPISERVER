using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class TopQueriesByCpu
    {
        public int TrackId { get; set; }
        public DateTime TrackDate { get; set; }
        public int? ITrackDate { get; set; }
        public int? ITrackTime { get; set; }
        public int CpuTime { get; set; }
        public string QueryText { get; set; }
        public int? Reads { get; set; }
        public int? LogicalReads { get; set; }
        public int? Writes { get; set; }
    }
}
