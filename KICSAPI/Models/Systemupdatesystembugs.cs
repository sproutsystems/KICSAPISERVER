using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Systemupdatesystembugs
    {
        public int SystemUpdateSystemBugId { get; set; }
        public int SystemUpdateId { get; set; }
        public int SystemBugId { get; set; }

        public Systembug SystemBug { get; set; }
        public Systemupdate SystemUpdate { get; set; }
    }
}
