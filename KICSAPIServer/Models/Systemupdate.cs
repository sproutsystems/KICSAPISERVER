using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Systemupdate
    {
        public Systemupdate()
        {
            Systemupdatesystembugs = new HashSet<Systemupdatesystembugs>();
        }

        public int SystemUpdateId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UploadDateTime { get; set; }
        public bool? IsMinor { get; set; }
        public string Notes { get; set; }
        public int EstimatedDowntimeInMinutes { get; set; }
        public string AffectedSystems { get; set; }
        public bool IsNoticeEmailSent { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsFinished { get; set; }

        public ICollection<Systemupdatesystembugs> Systemupdatesystembugs { get; set; }
    }
}
