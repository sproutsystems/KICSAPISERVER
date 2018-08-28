using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Formcinema
    {
        public int FormCinemaId { get; set; }
        public Guid FormId { get; set; }
        public Guid CinemaId { get; set; }
        public string EmailAddress { get; set; }

        public Cinema Cinema { get; set; }
        public Form Form { get; set; }
    }
}
