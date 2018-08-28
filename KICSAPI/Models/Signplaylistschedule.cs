using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Signplaylistschedule
    {
        public int SignPlaylistScheduleId { get; set; }
        public Guid SignId { get; set; }
        public short TimeId { get; set; }
        public Guid SignPlayListId { get; set; }
        public short SignModeId { get; set; }
        public DateTime ModifyDateTime { get; set; }

        public Sign Sign { get; set; }
        public Signmode SignMode { get; set; }
        public Signplaylist SignPlayList { get; set; }
        public Time Time { get; set; }
    }
}
