using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Globalcssversion
    {
        public Globalcssversion()
        {
            Site = new HashSet<Site>();
        }

        public int GlobalCssversionId { get; set; }
        public int GlobalCssid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int VersionId { get; set; }
        public string GlobalCsstext { get; set; }
        public string EmailCss { get; set; }
        public string DesktopCss { get; set; }
        public string TabletCss { get; set; }
        public string MobileCss { get; set; }

        public Globalcss GlobalCss { get; set; }
        public ICollection<Site> Site { get; set; }
    }
}
