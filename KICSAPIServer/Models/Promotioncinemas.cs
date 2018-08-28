using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Promotioncinemas
    {
        public short PromotionCinemaId { get; set; }
        public Guid PromotionId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Promotion Promotion { get; set; }
    }
}
