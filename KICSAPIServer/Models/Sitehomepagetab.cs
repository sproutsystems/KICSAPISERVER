using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sitehomepagetab
    {
        public Sitehomepagetab()
        {
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Sitehomepagetabcinemas = new HashSet<Sitehomepagetabcinemas>();
        }

        public Guid SiteHomePageTabId { get; set; }
        public string Name { get; set; }
        public short DisplayOrder { get; set; }
        public Guid SiteId { get; set; }
        public string PassThroughData { get; set; }
        public Guid IncludeElementId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public short Limit { get; set; }
        public string InformationText { get; set; }
        public bool? IsShowSidebar { get; set; }
        public bool IsDefault { get; set; }
        public string BottomText { get; set; }
        public bool? IsDisplayOnMobile { get; set; }
        public bool? IsDisplayOnTablet { get; set; }
        public bool? IsDisplayOnDesktop { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Site Site { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Sitehomepagetabcinemas> Sitehomepagetabcinemas { get; set; }
    }
}
