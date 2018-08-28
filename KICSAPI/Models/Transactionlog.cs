using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Transactionlog
    {
        public Transactionlog()
        {
            Quote = new HashSet<Quote>();
        }

        public int TransactionLogId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Description { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal AdditionalCinemaAdjustmentAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsInformationOnly { get; set; }
        public string RelatedId { get; set; }
        public Guid CompanyId { get; set; }
        public string RelatedTable { get; set; }

        public Company Company { get; set; }
        public ICollection<Quote> Quote { get; set; }
    }
}
