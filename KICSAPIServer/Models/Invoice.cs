using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Invoice
    {
        public Guid InvoiceId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int BillingMonth { get; set; }
        public int BillingYear { get; set; }
        public string Number { get; set; }
        public Guid CompanyId { get; set; }
        public int SaasuInvoiceUid { get; set; }
    }
}
