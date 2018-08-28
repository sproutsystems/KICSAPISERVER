using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Maininteractiveimage
    {
        public Guid MainInteractiveImageId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
