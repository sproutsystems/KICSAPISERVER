using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emailcinemas
    {
        public int EmailCinemaId { get; set; }
        public Guid EmailId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Email Email { get; set; }
    }
}
