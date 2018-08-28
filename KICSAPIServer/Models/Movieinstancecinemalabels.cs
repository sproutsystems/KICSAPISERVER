using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstancecinemalabels
    {
        public int MovieInstanceCinemaLabelId { get; set; }
        public int MovieInstanceCinemaId { get; set; }
        public short LabelId { get; set; }

        public Label Label { get; set; }
        public Movieinstancecinemas MovieInstanceCinema { get; set; }
    }
}
