using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Autopostdestination
    {
        public Autopostdestination()
        {
            Autoposttypetemplate = new HashSet<Autoposttypetemplate>();
            Companyautopost = new HashSet<Companyautopost>();
        }

        public int AutoPostDestinationId { get; set; }
        public string Name { get; set; }
        public bool IsSubjectRequired { get; set; }

        public ICollection<Autoposttypetemplate> Autoposttypetemplate { get; set; }
        public ICollection<Companyautopost> Companyautopost { get; set; }
    }
}
