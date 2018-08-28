using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Nowshowingquerymethod
    {
        public Nowshowingquerymethod()
        {
            Cinema = new HashSet<Cinema>();
        }

        public int NowShowingQueryMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Cinema> Cinema { get; set; }
    }
}
