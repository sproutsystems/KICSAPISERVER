using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sessionimportattemptlog
    {
        public long SessionImportAttemptLogId { get; set; }
        public int SessionImportAttemptId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsImportant { get; set; }
        public bool IsError { get; set; }

        public Sessionimportattempt SessionImportAttempt { get; set; }
    }
}
