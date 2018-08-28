using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixposusetype
    {
        public Ktixposusetype()
        {
            Ktixposterminal = new HashSet<Ktixposterminal>();
        }

        public int KtixPosUseTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Ktixposterminal> Ktixposterminal { get; set; }
    }
}
