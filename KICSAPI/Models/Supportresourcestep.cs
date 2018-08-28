using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Supportresourcestep
    {
        public int SupportResourceStepId { get; set; }
        public int SupportResourceId { get; set; }
        public int StepNumber { get; set; }
        public string Instructions { get; set; }
        public string LinkUrl { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }

        public Supportresource SupportResource { get; set; }
    }
}
