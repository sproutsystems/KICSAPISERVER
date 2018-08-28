using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sidebarelement
    {
        public Sidebarelement()
        {
            Sidebarelementcinemas = new HashSet<Sidebarelementcinemas>();
            Sidebarelementmembertypes = new HashSet<Sidebarelementmembertypes>();
        }

        public short SidebarElementId { get; set; }
        public Guid SidebarId { get; set; }
        public Guid IncludeElementId { get; set; }
        public string PassThroughData { get; set; }
        public short DisplayOrder { get; set; }
        public string Text { get; set; }
        public bool? IsPublic { get; set; }
        public string Title { get; set; }
        public string InformationText { get; set; }
        public short Margin { get; set; }
        public short Limit { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Sidebar Sidebar { get; set; }
        public ICollection<Sidebarelementcinemas> Sidebarelementcinemas { get; set; }
        public ICollection<Sidebarelementmembertypes> Sidebarelementmembertypes { get; set; }
    }
}
