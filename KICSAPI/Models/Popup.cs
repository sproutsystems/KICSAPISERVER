using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Popup
    {
        public Popup()
        {
            Popupcinema = new HashSet<Popupcinema>();
        }

        public int PopUpId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool? IsActive { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public string LinkUrl { get; set; }
        public string ImageAltText { get; set; }
        public Guid CompanyId { get; set; }
        public string Html { get; set; }
        public bool? IsHomepageOnly { get; set; }

        public Company Company { get; set; }
        public ICollection<Popupcinema> Popupcinema { get; set; }
    }
}
