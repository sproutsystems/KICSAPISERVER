using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Maininteractiveautotype
    {
        public Maininteractiveautotype()
        {
            Sitemaininteractiveautoorder = new HashSet<Sitemaininteractiveautoorder>();
        }

        public int MainInteractiveAutoTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Sitemaininteractiveautoorder> Sitemaininteractiveautoorder { get; set; }
    }
}
