using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Poll
    {
        public Poll()
        {
            Pollmembertypes = new HashSet<Pollmembertypes>();
            Polloption = new HashSet<Polloption>();
            Pollsites = new HashSet<Pollsites>();
        }

        public Guid PollId { get; set; }
        public string Question { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public bool IsActive { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string MessageToDisplayAfterEntry { get; set; }
        public bool? IsShowResultsAfterEntry { get; set; }

        public ICollection<Pollmembertypes> Pollmembertypes { get; set; }
        public ICollection<Polloption> Polloption { get; set; }
        public ICollection<Pollsites> Pollsites { get; set; }
    }
}
