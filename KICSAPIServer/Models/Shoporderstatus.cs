using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shoporderstatus
    {
        public Shoporderstatus()
        {
            Shoporder = new HashSet<Shoporder>();
        }

        public short ShopOrderStatusId { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public bool IsDefault { get; set; }

        public ICollection<Shoporder> Shoporder { get; set; }
    }
}
