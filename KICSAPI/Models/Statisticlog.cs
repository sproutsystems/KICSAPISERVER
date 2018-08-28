using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Statisticlog
    {
        public long StatisticLogId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string RelatedIdValue { get; set; }
        public bool? IsView { get; set; }
        public bool IsClick { get; set; }
        public int StatisticTypeId { get; set; }

        public Statistictype StatisticType { get; set; }
    }
}
