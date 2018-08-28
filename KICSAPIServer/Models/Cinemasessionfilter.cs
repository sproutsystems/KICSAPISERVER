using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinemasessionfilter
    {
        public Cinemasessionfilter()
        {
            Cinemasessionfilterbutton = new HashSet<Cinemasessionfilterbutton>();
        }

        public Guid CinemaSessionFilterId { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsDaySelectionVisible { get; set; }
        public string DefaultButtonName { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Cinemasessionfilterbutton> Cinemasessionfilterbutton { get; set; }
    }
}
