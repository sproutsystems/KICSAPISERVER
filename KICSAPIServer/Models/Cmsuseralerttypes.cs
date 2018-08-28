using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cmsuseralerttypes
    {
        public int CmsuserAlertTypeId { get; set; }
        public Guid CmsuserId { get; set; }
        public int AlertTypeId { get; set; }

        public Alerttype AlertType { get; set; }
        public Cmsuser Cmsuser { get; set; }
    }
}
