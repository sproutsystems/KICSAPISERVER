using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Pagetemplate
    {
        public Pagetemplate()
        {
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Pagetemplateregion = new HashSet<Pagetemplateregion>();
        }

        public Guid PageTemplateId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public short PageTypeId { get; set; }
        public int? CssId { get; set; }

        public Css Css { get; set; }
        public Pagetype PageType { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Pagetemplateregion> Pagetemplateregion { get; set; }
    }
}
