using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Smslog
    {
        public Smslog()
        {
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
        }

        public int SmslogId { get; set; }
        public string RecipientNumber { get; set; }
        public Guid CompanyId { get; set; }
        public string Message { get; set; }
        public bool? IsSent { get; set; }
        public bool IsConfirmed { get; set; }
        public string GatewayReceiptNumber { get; set; }
        public string GatewayResponse { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? ConfirmationDateTime { get; set; }

        public Company Company { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
    }
}
