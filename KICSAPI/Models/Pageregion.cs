using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pageregion
    {
        public Pageregion()
        {
            Pageregioncinemas = new HashSet<Pageregioncinemas>();
            Pageregioncontent = new HashSet<Pageregioncontent>();
            Pageregionmembertypes = new HashSet<Pageregionmembertypes>();
        }

        public Guid PageRegionId { get; set; }
        public string Name { get; set; }
        public string DescriptionOfContent { get; set; }
        public Guid PageId { get; set; }
        public bool IsUserEditable { get; set; }
        public short DisplayOrder { get; set; }
        public Guid IncludeElementId { get; set; }
        public bool? IsPublic { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Page Page { get; set; }
        public ICollection<Pageregioncinemas> Pageregioncinemas { get; set; }
        public ICollection<Pageregioncontent> Pageregioncontent { get; set; }
        public ICollection<Pageregionmembertypes> Pageregionmembertypes { get; set; }
    }
}
