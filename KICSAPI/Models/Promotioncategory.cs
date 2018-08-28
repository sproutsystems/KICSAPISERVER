using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotioncategory
    {
        public Promotioncategory()
        {
            Promotion = new HashSet<Promotion>();
        }

        public Guid PromotionCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsSelectedByDefault { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }

        public Company Company { get; set; }
        public ICollection<Promotion> Promotion { get; set; }
    }
}
