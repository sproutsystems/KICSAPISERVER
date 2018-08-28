using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class VistaCache
    {
        public int VistaCacheId { get; set; }
        public string VistaCinemaId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsOk { get; set; }
        public DateTime ExpiryDatetime { get; set; }
    }
}
