using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Faqcinemas
    {
        public short FaqcinemaId { get; set; }
        public Guid Faqid { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Faq Faq { get; set; }
    }
}
