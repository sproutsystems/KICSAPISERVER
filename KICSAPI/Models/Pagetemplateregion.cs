using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pagetemplateregion
    {
        public Guid PageTemplateRegionId { get; set; }
        public string Name { get; set; }
        public string DescriptionOfContent { get; set; }
        public Guid PageTemplateId { get; set; }
        public bool IsUserEditable { get; set; }
        public short DisplayOrder { get; set; }
        public Guid IncludeElementId { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Pagetemplate PageTemplate { get; set; }
    }
}
