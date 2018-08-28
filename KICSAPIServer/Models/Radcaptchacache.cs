using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Radcaptchacache
    {
        public int Id { get; set; }
        public string TableKey { get; set; }
        public byte[] TableContent { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
