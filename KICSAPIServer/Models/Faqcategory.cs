using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Faqcategory
    {
        public Faqcategory()
        {
            Faq = new HashSet<Faq>();
        }

        public Guid FaqcategoryId { get; set; }
        public string Name { get; set; }
        public short DisplayOrder { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }

        public Company Company { get; set; }
        public ICollection<Faq> Faq { get; set; }
    }
}
