using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixgiftcardstate
    {
        public Ktixgiftcardstate()
        {
            Ktixgiftcard = new HashSet<Ktixgiftcard>();
        }

        public int KtixGiftCardStateId { get; set; }
        public string Name { get; set; }

        public ICollection<Ktixgiftcard> Ktixgiftcard { get; set; }
    }
}
