using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemagroup
    {
        public Cinemagroup()
        {
            Advertisementlocationcinemagroup = new HashSet<Advertisementlocationcinemagroup>();
            Cinemagroupcinemas = new HashSet<Cinemagroupcinemas>();
            Featuredmovieelements = new HashSet<Featuredmovieelements>();
            Maininteractiveelement = new HashSet<Maininteractiveelement>();
            Sitecinemagroups = new HashSet<Sitecinemagroups>();
        }

        public Guid CinemaGroupId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Advertisementlocationcinemagroup> Advertisementlocationcinemagroup { get; set; }
        public ICollection<Cinemagroupcinemas> Cinemagroupcinemas { get; set; }
        public ICollection<Featuredmovieelements> Featuredmovieelements { get; set; }
        public ICollection<Maininteractiveelement> Maininteractiveelement { get; set; }
        public ICollection<Sitecinemagroups> Sitecinemagroups { get; set; }
    }
}
