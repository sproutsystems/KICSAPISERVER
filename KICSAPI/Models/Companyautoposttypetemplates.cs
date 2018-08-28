using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyautoposttypetemplates
    {
        public int CompanyAutoPostTypeTemplateId { get; set; }
        public int AutoPostTypeTemplateId { get; set; }
        public int CompanyAutoPostId { get; set; }

        public Autoposttypetemplate AutoPostTypeTemplate { get; set; }
        public Companyautopost CompanyAutoPost { get; set; }
    }
}
