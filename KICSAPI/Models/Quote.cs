using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Quote
    {
        public Guid QuoteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CompanyId { get; set; }
        public decimal? Cost { get; set; }
        public int? NumberOfHours { get; set; }
        public bool IsSharedCost { get; set; }
        public decimal? HourlyRate { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? TransactionLogId { get; set; }
        public Guid? CmsuserId { get; set; }
        public DateTime? ApprovalDateTime { get; set; }
        public Guid? HelpdeskTicketId { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeclined { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Company Company { get; set; }
        public Helpdeskticket HelpdeskTicket { get; set; }
        public Transactionlog TransactionLog { get; set; }
    }
}
