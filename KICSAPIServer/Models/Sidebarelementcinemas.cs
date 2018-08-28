using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Sidebarelementcinemas
    {
        public short SidebarElementCinemaId { get; set; }
        public short SidebarElementId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Sidebarelement SidebarElement { get; set; }
    }
}
