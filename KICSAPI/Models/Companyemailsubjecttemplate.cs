using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyemailsubjecttemplate
    {
        public int CompanyEmailSubjectTemplateId { get; set; }
        public Guid CompanyId { get; set; }
        public int EmailSubjectTemplateId { get; set; }

        public Company Company { get; set; }
        public Emailsubjecttemplate EmailSubjectTemplate { get; set; }
    }
}
