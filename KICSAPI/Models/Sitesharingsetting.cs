using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sitesharingsetting
    {
        public Guid SiteSharingSettingId { get; set; }
        public Guid SiteId { get; set; }
        public bool? IsUserMovieCommentsShared { get; set; }
        public bool? IsExternalUserMovieCommentsShown { get; set; }
        public bool? IsShowFaceBookIconOnMainInteractive { get; set; }
        public bool? IsShowTwitterIconOnMainInteractive { get; set; }
        public int FacebookColorSchemeId { get; set; }

        public Facebookcolorscheme FacebookColorScheme { get; set; }
        public Site Site { get; set; }
    }
}
