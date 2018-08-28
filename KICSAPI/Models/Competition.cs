using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Competition
    {
        public Competition()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Competitioncinemas = new HashSet<Competitioncinemas>();
            Competitionentry = new HashSet<Competitionentry>();
            Competitionmembertypes = new HashSet<Competitionmembertypes>();
            Competitionprize = new HashSet<Competitionprize>();
            Competitionquestion = new HashSet<Competitionquestion>();
            Competitionwinner = new HashSet<Competitionwinner>();
        }

        public Guid CompetitionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? MovieDetailId { get; set; }
        public bool IsActive { get; set; }
        public bool IsClosed { get; set; }
        public string TermsAndConditions { get; set; }
        public string ExternalLinkUrl { get; set; }
        public int MinimumMemberPointsRequiredToEnter { get; set; }
        public int MemberPointsCostToEnter { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsGenerateReminders { get; set; }
        public Guid? EmailGroupId { get; set; }
        public bool? IsShowOnMainInteractive { get; set; }
        public string MainInteractiveTitle { get; set; }
        public string AdditionalContent { get; set; }

        public Moviedetail MovieDetail { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Competitioncinemas> Competitioncinemas { get; set; }
        public ICollection<Competitionentry> Competitionentry { get; set; }
        public ICollection<Competitionmembertypes> Competitionmembertypes { get; set; }
        public ICollection<Competitionprize> Competitionprize { get; set; }
        public ICollection<Competitionquestion> Competitionquestion { get; set; }
        public ICollection<Competitionwinner> Competitionwinner { get; set; }
    }
}
