using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Contenttype
    {
        public Contenttype()
        {
            Advertisementlocationtype = new HashSet<Advertisementlocationtype>();
            Carouselcontent = new HashSet<Carouselcontent>();
            Content = new HashSet<Content>();
            Contenttypeformats = new HashSet<Contenttypeformats>();
            Includeelement = new HashSet<Includeelement>();
        }

        public short ContentTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RelatedTable { get; set; }
        public short? Width { get; set; }
        public short? Height { get; set; }
        public bool IsFixedSize { get; set; }
        public bool IsSuitableForSign { get; set; }
        public string Notes { get; set; }
        public bool IsDisplayCropWindow { get; set; }

        public ICollection<Advertisementlocationtype> Advertisementlocationtype { get; set; }
        public ICollection<Carouselcontent> Carouselcontent { get; set; }
        public ICollection<Content> Content { get; set; }
        public ICollection<Contenttypeformats> Contenttypeformats { get; set; }
        public ICollection<Includeelement> Includeelement { get; set; }
    }
}
