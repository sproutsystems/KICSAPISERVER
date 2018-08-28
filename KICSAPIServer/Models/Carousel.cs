using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Carousel
    {
        public Carousel()
        {
            Carouselcontent = new HashSet<Carouselcontent>();
            Page = new HashSet<Page>();
        }

        public int CarouselId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public bool? IsAutoPlay { get; set; }

        public Company Company { get; set; }
        public ICollection<Carouselcontent> Carouselcontent { get; set; }
        public ICollection<Page> Page { get; set; }
    }
}
