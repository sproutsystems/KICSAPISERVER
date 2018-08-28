using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Autoposttypetemplate
    {
        public Autoposttypetemplate()
        {
            Autopost = new HashSet<Autopost>();
            Companyautoposttypetemplates = new HashSet<Companyautoposttypetemplates>();
        }

        public int AutoPostTypeTemplateId { get; set; }
        public int AutoPostTypeId { get; set; }
        public int AutoPostDestinationId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public Guid? CompanyId { get; set; }

        public Autopostdestination AutoPostDestination { get; set; }
        public Autoposttype AutoPostType { get; set; }
        public ICollection<Autopost> Autopost { get; set; }
        public ICollection<Companyautoposttypetemplates> Companyautoposttypetemplates { get; set; }
    }
}
