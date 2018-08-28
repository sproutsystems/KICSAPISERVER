using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cronjob
    {
        public Cronjob()
        {
            Cronjoblog = new HashSet<Cronjoblog>();
        }

        public int CronJobId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Result { get; set; }

        public ICollection<Cronjoblog> Cronjoblog { get; set; }
    }
}
