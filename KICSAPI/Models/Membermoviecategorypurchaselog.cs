using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membermoviecategorypurchaselog
    {
        public long MemberMovieCategoryPurchaseLogId { get; set; }
        public Guid MemberId { get; set; }
        public Guid MovieCategoryId { get; set; }

        public Member Member { get; set; }
        public Moviecategory MovieCategory { get; set; }
    }
}
