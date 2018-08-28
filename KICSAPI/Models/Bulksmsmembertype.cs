using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Bulksmsmembertype
    {
        public int BulkSmsMemberTypeId { get; set; }
        public Guid BulkSmsId { get; set; }
        public Guid MembertypeId { get; set; }

        public Bulksms BulkSms { get; set; }
        public Membertype Membertype { get; set; }
    }
}
