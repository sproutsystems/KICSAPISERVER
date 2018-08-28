using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Fullimagebackground
    {
        public Fullimagebackground()
        {
            Cinemafullimagebackground = new HashSet<Cinemafullimagebackground>();
        }

        public Guid FullImageBackgroundId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid? MovieId { get; set; }
        public Guid? CompanyId { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsBottomAligned { get; set; }
        public bool IsFixed { get; set; }

        public Company Company { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Cinemafullimagebackground> Cinemafullimagebackground { get; set; }
    }
}
