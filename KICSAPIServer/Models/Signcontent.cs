using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Signcontent
    {
        public Guid SignContentId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Description { get; set; }
        public Guid AuthorUserId { get; set; }
        public bool? IsLandscape { get; set; }

        public AspnetUsers AuthorUser { get; set; }
        public Company Company { get; set; }
    }
}
