using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cronjoblog
    {
        public int CronJobLogId { get; set; }
        public int CronJobId { get; set; }
        public string Text { get; set; }

        public Cronjob CronJob { get; set; }
    }
}
