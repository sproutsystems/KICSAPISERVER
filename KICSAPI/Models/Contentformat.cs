using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Contentformat
    {
        public Contentformat()
        {
            Content = new HashSet<Content>();
            Contenttypeformats = new HashSet<Contenttypeformats>();
        }

        public short ContentFormatId { get; set; }
        public string Name { get; set; }
        public string FileExtension { get; set; }

        public ICollection<Content> Content { get; set; }
        public ICollection<Contenttypeformats> Contenttypeformats { get; set; }
    }
}
