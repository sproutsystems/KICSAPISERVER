using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companymemberexportjob
    {
        public int CompanyMemberExportJobId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? FilterId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public int TimeTakenInSeconds { get; set; }
        public string RecipientEmailAddress { get; set; }
        public bool IsProcessed { get; set; }
        public int NumberOfRecordsExported { get; set; }
        public string ExportFileName { get; set; }

        public Company Company { get; set; }
        public Filter Filter { get; set; }
    }
}
