using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filtermoviecategorypurchases
    {
        public int FilterMovieCategoryPurchaseId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MovieCategoryId { get; set; }

        public Filter Filter { get; set; }
        public Moviecategory MovieCategory { get; set; }
    }
}
