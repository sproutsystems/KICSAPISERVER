using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Screenscreenfeatures
    {
        public Guid ScreenScreenFeatureId { get; set; }
        public Guid ScreenId { get; set; }
        public Guid ScreenFeatureId { get; set; }

        public Screen Screen { get; set; }
        public Screenfeature ScreenFeature { get; set; }
    }
}
