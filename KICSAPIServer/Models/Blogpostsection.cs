using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Blogpostsection
    {
        public Blogpostsection()
        {
            Blogpost = new HashSet<Blogpost>();
        }

        public short BlogPostSectionId { get; set; }
        public string Name { get; set; }

        public ICollection<Blogpost> Blogpost { get; set; }
    }
}
