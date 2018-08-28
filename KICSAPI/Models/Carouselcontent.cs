using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Carouselcontent
    {
        public int CarouselContentId { get; set; }
        public int CarouselId { get; set; }
        public string Name { get; set; }
        public string LinkUrl { get; set; }
        public int DisplayOrder { get; set; }
        public short ContentTypeId { get; set; }

        public Carousel Carousel { get; set; }
        public Contenttype ContentType { get; set; }
    }
}
