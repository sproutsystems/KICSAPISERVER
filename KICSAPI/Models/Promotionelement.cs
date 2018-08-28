using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotionelement
    {
        public short PromotionElementId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public short DisplayOrder { get; set; }
        public Guid PromotionId { get; set; }
        public string PassThroughData { get; set; }
        public string InformationText { get; set; }
        public Guid IncludeElementId { get; set; }
        public short Limit { get; set; }

        public Includeelement IncludeElement { get; set; }
        public Promotion Promotion { get; set; }
    }
}
