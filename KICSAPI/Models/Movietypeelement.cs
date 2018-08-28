using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movietypeelement
    {
        public short MovieTypeElementId { get; set; }
        public Guid MovieTypeId { get; set; }
        public Guid IncludeElementId { get; set; }
        public short DisplayOrder { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Movietype MovieType { get; set; }
    }
}
