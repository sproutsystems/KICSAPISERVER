using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movieinstancecontent
    {
        public int MovieInstanceContentId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public Guid ContentId { get; set; }
        public short DisplayOrder { get; set; }

        public Content Content { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
