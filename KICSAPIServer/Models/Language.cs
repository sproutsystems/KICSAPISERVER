using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Language
    {
        public Language()
        {
            Blogpost = new HashSet<Blogpost>();
            Gender = new HashSet<Gender>();
            Genre = new HashSet<Genre>();
        }

        public short LanguageId { get; set; }
        public string Name { get; set; }
        public string Encoding { get; set; }

        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Gender> Gender { get; set; }
        public ICollection<Genre> Genre { get; set; }
    }
}
