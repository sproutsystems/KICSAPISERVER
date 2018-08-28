using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Flyerpromotions
    {
        public int FlyerPromotionId { get; set; }
        public Guid FlyerId { get; set; }
        public Guid PromotionId { get; set; }

        public Flyer Flyer { get; set; }
        public Promotion Promotion { get; set; }
    }
}
