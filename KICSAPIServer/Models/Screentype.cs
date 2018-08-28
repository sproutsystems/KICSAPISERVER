using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Screentype
    {
        public Screentype()
        {
            Screen = new HashSet<Screen>();
        }

        public Guid ScreenTypeId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool IsImportant { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Screen> Screen { get; set; }
    }
}
