using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Bounce
    {
        public int BounceId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string EmailId { get; set; }
        public string Code { get; set; }
    }
}
