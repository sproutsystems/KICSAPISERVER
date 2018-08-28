using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sitemaininteractiveautoorder
    {
        public int SiteMainInteractiveAutoOrderId { get; set; }
        public Guid SiteId { get; set; }
        public int MainInteractiveAutoTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public Maininteractiveautotype MainInteractiveAutoType { get; set; }
        public Site Site { get; set; }
    }
}
