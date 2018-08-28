using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class VistaCacheLogs
    {
        public int VistaCacheLogsId { get; set; }
        public string VistaCacheId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }
    }
}
