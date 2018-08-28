using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Bulksmsrecipient
    {
        public Guid BulkSmsRecipientId { get; set; }
        public Guid BulkSmsId { get; set; }
        public bool IsSent { get; set; }
        public string GatewayReferenceNumber { get; set; }
        public string GatewayResponse { get; set; }
        public string RecipientNumber { get; set; }
        public Guid? MemberId { get; set; }

        public Bulksms BulkSms { get; set; }
        public Member Member { get; set; }
    }
}
