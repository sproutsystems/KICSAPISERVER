using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pagemenupages
    {
        public Pagemenupages()
        {
            Pagemenupagecinemas = new HashSet<Pagemenupagecinemas>();
        }

        public short PageMenuPagesId { get; set; }
        public Guid PageMenuId { get; set; }
        public Guid PageId { get; set; }
        public short DisplayOrder { get; set; }
        public string Text { get; set; }
        public string Anchor { get; set; }

        public Page Page { get; set; }
        public Pagemenu PageMenu { get; set; }
        public ICollection<Pagemenupagecinemas> Pagemenupagecinemas { get; set; }
    }
}
