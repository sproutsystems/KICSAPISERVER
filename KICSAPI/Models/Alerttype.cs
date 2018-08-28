using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Alerttype
    {
        public Alerttype()
        {
            Alert = new HashSet<Alert>();
            Cmsuseralerttypes = new HashSet<Cmsuseralerttypes>();
        }

        public int AlertTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Alert> Alert { get; set; }
        public ICollection<Cmsuseralerttypes> Cmsuseralerttypes { get; set; }
    }
}
