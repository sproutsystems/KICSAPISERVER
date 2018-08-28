using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Globalcss
    {
        public Globalcss()
        {
            Globalcssversion = new HashSet<Globalcssversion>();
        }

        public int GlobalCssid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string GlobalCsstext { get; set; }
        public string EmailCss { get; set; }
        public string DesktopCss { get; set; }
        public string TabletCss { get; set; }
        public string MobileCss { get; set; }

        public ICollection<Globalcssversion> Globalcssversion { get; set; }
    }
}
