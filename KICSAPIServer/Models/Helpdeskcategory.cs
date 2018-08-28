using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Helpdeskcategory
    {
        public Helpdeskcategory()
        {
            Helpdeskcategoryroles = new HashSet<Helpdeskcategoryroles>();
            Helpdeskstandardresponse = new HashSet<Helpdeskstandardresponse>();
            Helpdeskticket = new HashSet<Helpdeskticket>();
        }

        public short HelpdeskCategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Helpdeskcategoryroles> Helpdeskcategoryroles { get; set; }
        public ICollection<Helpdeskstandardresponse> Helpdeskstandardresponse { get; set; }
        public ICollection<Helpdeskticket> Helpdeskticket { get; set; }
    }
}
