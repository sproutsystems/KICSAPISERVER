using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Helpdeskcategoryroles
    {
        public short HelpdeskCategoryRolesId { get; set; }
        public short HelpdeskCategoryId { get; set; }
        public Guid RoleId { get; set; }

        public Helpdeskcategory HelpdeskCategory { get; set; }
        public AspnetRoles Role { get; set; }
    }
}
