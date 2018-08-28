using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cssversion
    {
        public int CssVersionId { get; set; }
        public int CssId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int VersionId { get; set; }
        public string DesktopCss { get; set; }
        public string TabletCss { get; set; }
        public string MobileCss { get; set; }

        public Css Css { get; set; }
    }
}
