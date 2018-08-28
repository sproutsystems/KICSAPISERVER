using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filtermembers
    {
        public int FilterMemberId { get; set; }
        public Guid FilterId { get; set; }
        public Guid? MemberId { get; set; }
        public string PhoneNo { get; set; }

        public Filter Filter { get; set; }
        public Member Member { get; set; }
    }
}
