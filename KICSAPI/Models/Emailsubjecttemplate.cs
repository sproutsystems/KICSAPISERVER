using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailsubjecttemplate
    {
        public Emailsubjecttemplate()
        {
            Companyemailsubjecttemplate = new HashSet<Companyemailsubjecttemplate>();
        }

        public int EmailSubjectTemplateId { get; set; }
        public string Text { get; set; }
        public Guid? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Companyemailsubjecttemplate> Companyemailsubjecttemplate { get; set; }
    }
}
