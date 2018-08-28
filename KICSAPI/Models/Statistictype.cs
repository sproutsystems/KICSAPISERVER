using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Statistictype
    {
        public Statistictype()
        {
            Statistic = new HashSet<Statistic>();
            Statisticdaily = new HashSet<Statisticdaily>();
            Statisticlog = new HashSet<Statisticlog>();
        }

        public int StatisticTypeId { get; set; }
        public string Name { get; set; }
        public string RelatedTable { get; set; }
        public string RelatedIdName { get; set; }

        public ICollection<Statistic> Statistic { get; set; }
        public ICollection<Statisticdaily> Statisticdaily { get; set; }
        public ICollection<Statisticlog> Statisticlog { get; set; }
    }
}
