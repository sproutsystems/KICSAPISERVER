using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Screenseat
    {
        public int ScreenSeatId { get; set; }
        public Guid ScreenId { get; set; }
        public short MapRow { get; set; }
        public short MapColumn { get; set; }
        public string DisplayName { get; set; }

        public Screen Screen { get; set; }
    }
}
