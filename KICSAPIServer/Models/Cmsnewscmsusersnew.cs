using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cmsnewscmsusersnew
    {
        public long CmsnewsCmsuserNewId { get; set; }
        public Guid CmsnewsId { get; set; }
        public Guid CmsuserId { get; set; }
        public bool IsRead { get; set; }

        public Cmsnews Cmsnews { get; set; }
        public Cmsuser CmsnewsNavigation { get; set; }
    }
}
