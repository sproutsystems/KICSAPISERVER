using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sessionflags
    {
        public long SessionFlagId { get; set; }
        public long SessionId { get; set; }
        public short FlagId { get; set; }

        public Flag Flag { get; set; }
        public Session Session { get; set; }
    }
}
