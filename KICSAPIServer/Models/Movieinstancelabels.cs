using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstancelabels
    {
        public int MovieInstanceLabelId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public short LabelId { get; set; }

        public Label Label { get; set; }
        public Movieinstance MovieInstance { get; set; }
    }
}
