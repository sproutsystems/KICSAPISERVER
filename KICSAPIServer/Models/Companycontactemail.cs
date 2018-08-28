using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companycontactemail
    {
        public Guid CompanyContactEmailId { get; set; }
        public Guid CompanyId { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }

        public Company Company { get; set; }
    }
}
