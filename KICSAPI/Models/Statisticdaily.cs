using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Statisticdaily
    {
        public long StatisticDailyId { get; set; }
        public string RelatedIdValue { get; set; }
        public long ViewCount { get; set; }
        public long ClickCount { get; set; }
        public DateTime DataDate { get; set; }
        public int StatisticTypeId { get; set; }

        public Statistictype StatisticType { get; set; }
    }
}
