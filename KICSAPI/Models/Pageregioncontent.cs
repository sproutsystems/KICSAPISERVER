using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pageregioncontent
    {
        public Guid PageRegionContentId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public Guid PageRegionId { get; set; }
        public string PassThroughData { get; set; }
        public string InformationText { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public short Limit { get; set; }

        public AspnetUsers ApprovedByUser { get; set; }
        public AspnetUsers AuthorUser { get; set; }
        public Pageregion PageRegion { get; set; }
    }
}
