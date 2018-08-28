using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Autoposttype
    {
        public Autoposttype()
        {
            Autoposttypetemplate = new HashSet<Autoposttypetemplate>();
            Blogpost = new HashSet<Blogpost>();
        }

        public int AutoPostTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Autoposttypetemplate> Autoposttypetemplate { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
    }
}
