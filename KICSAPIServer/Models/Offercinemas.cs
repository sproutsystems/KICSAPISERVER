using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Offercinemas
    {
        public short OfferCinemaId { get; set; }
        public Guid OfferId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Offer Offer { get; set; }
    }
}
