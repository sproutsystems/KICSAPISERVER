using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Blogpostcinemas
    {
        public int BlogPostCinemaId { get; set; }
        public Guid BlogPostId { get; set; }
        public Guid CinemaId { get; set; }

        public Blogpost BlogPost { get; set; }
        public Cinema Cinema { get; set; }
    }
}
