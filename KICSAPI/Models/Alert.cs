using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Alert
    {
        public int AlertId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int AlertTypeId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsActioned { get; set; }
        public Guid CinemaId { get; set; }
        public string RelatedId { get; set; }
        public Guid CmsuserId { get; set; }

        public Alerttype AlertType { get; set; }
        public Cinema Cinema { get; set; }
        public Cmsuser Cmsuser { get; set; }
    }
}
