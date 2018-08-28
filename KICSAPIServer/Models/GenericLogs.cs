using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class GenericLogs
    {
        public int GenericLogsId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LogType { get; set; }
        public string LogText { get; set; }
    }
}
