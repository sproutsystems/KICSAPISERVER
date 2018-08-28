using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixsession
    {
        public Ktixsession()
        {
            Ktixbooking = new HashSet<Ktixbooking>();
        }

        public long KtixSessionId { get; set; }
        public long SessionId { get; set; }
        public Guid KtixPriceGroupId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsArchived { get; set; }
        public bool IsCancelled { get; set; }
        public string CancellationReason { get; set; }

        public Ktixpricegroup KtixPriceGroup { get; set; }
        public Session Session { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
    }
}
