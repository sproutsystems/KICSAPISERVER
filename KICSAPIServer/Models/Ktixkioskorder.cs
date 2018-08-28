using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixkioskorder
    {
        public Ktixkioskorder()
        {
            Ktixkioskordersaleitem = new HashSet<Ktixkioskordersaleitem>();
            Ktixmastertransaction = new HashSet<Ktixmastertransaction>();
        }

        public Guid KtixKioskOrderId { get; set; }
        public Guid? KtixSettingId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public decimal? TotalCostOfKioskItems { get; set; }
        public string OrderNumber { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsError { get; set; }
        public string ErrorText { get; set; }
        public Guid CinemaId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool OptInMarketing { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixkioskordersaleitem> Ktixkioskordersaleitem { get; set; }
        public ICollection<Ktixmastertransaction> Ktixmastertransaction { get; set; }
    }
}
