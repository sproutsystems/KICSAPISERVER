using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessiondisplay
    {
        public Cinemasessiondisplay()
        {
            Cinemasessiondisplaymoviecategories = new HashSet<Cinemasessiondisplaymoviecategories>();
            Cinemasessiondisplaymovietypes = new HashSet<Cinemasessiondisplaymovietypes>();
        }

        public int CinemaSessionDisplayId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string Text { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Cinemasessiondisplaymoviecategories> Cinemasessiondisplaymoviecategories { get; set; }
        public ICollection<Cinemasessiondisplaymovietypes> Cinemasessiondisplaymovietypes { get; set; }
    }
}
