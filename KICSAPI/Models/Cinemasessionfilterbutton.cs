using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemasessionfilterbutton
    {
        public Cinemasessionfilterbutton()
        {
            Cinemasessionfilterbuttonflags = new HashSet<Cinemasessionfilterbuttonflags>();
            Cinemasessionfilterbuttonmoviecategory = new HashSet<Cinemasessionfilterbuttonmoviecategory>();
            Cinemasessionfilterbuttonmovietype = new HashSet<Cinemasessionfilterbuttonmovietype>();
        }

        public int CinemaSessionFilterButtonId { get; set; }
        public Guid CinemaSessionFilterId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public Cinemasessionfilter CinemaSessionFilter { get; set; }
        public ICollection<Cinemasessionfilterbuttonflags> Cinemasessionfilterbuttonflags { get; set; }
        public ICollection<Cinemasessionfilterbuttonmoviecategory> Cinemasessionfilterbuttonmoviecategory { get; set; }
        public ICollection<Cinemasessionfilterbuttonmovietype> Cinemasessionfilterbuttonmovietype { get; set; }
    }
}
