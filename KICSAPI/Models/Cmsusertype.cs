using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cmsusertype
    {
        public Cmsusertype()
        {
            Cmsuser = new HashSet<Cmsuser>();
        }

        public short CmsuserTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Cmsuser> Cmsuser { get; set; }
    }
}
