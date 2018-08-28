using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Faq
    {
        public Faq()
        {
            Faqcinemas = new HashSet<Faqcinemas>();
        }

        public Guid Faqid { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public short DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public Guid FaqcategoryId { get; set; }

        public Faqcategory Faqcategory { get; set; }
        public ICollection<Faqcinemas> Faqcinemas { get; set; }
    }
}
