using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Label
    {
        public Label()
        {
            Movieinstancecinemalabels = new HashSet<Movieinstancecinemalabels>();
            Movieinstancelabels = new HashSet<Movieinstancelabels>();
        }

        public short LabelId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsRemoveOnReleaseDate { get; set; }
        public string ColorForEmail { get; set; }

        public Company Company { get; set; }
        public ICollection<Movieinstancecinemalabels> Movieinstancecinemalabels { get; set; }
        public ICollection<Movieinstancelabels> Movieinstancelabels { get; set; }
    }
}
