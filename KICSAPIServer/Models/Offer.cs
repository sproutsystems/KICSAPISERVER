using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Offer
    {
        public Offer()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Memberofferviewlog = new HashSet<Memberofferviewlog>();
            Mobilealert = new HashSet<Mobilealert>();
            Offercinemas = new HashSet<Offercinemas>();
            Offermembertypes = new HashSet<Offermembertypes>();
            Offersites = new HashSet<Offersites>();
        }

        public Guid OfferId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TextOnVoucher { get; set; }
        public string RedemptionInstruction { get; set; }
        public string PriceInformation { get; set; }
        public DateTime ValidStartDateTime { get; set; }
        public DateTime ValidFinishDateTime { get; set; }
        public DateTime DisplayStartDateTime { get; set; }
        public DateTime DisplayFinishDateTime { get; set; }
        public string CashierCode { get; set; }
        public string TermsAndConditions { get; set; }
        public bool? IsPublic { get; set; }
        public string ExternalLinkUrl { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? MovieDetailId { get; set; }
        public int MinimumMemberPointsRequiredToView { get; set; }
        public int MemberPointsCostToView { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public bool? IsGenerateReminders { get; set; }
        public bool? IsShowOnMainInteractive { get; set; }
        public bool? IsVoucherRequired { get; set; }
        public string MainInteractiveTitle { get; set; }
        public bool? IsShowOnMobileApp { get; set; }
        public bool IsOngoing { get; set; }

        public Company Company { get; set; }
        public Moviedetail MovieDetail { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Memberofferviewlog> Memberofferviewlog { get; set; }
        public ICollection<Mobilealert> Mobilealert { get; set; }
        public ICollection<Offercinemas> Offercinemas { get; set; }
        public ICollection<Offermembertypes> Offermembertypes { get; set; }
        public ICollection<Offersites> Offersites { get; set; }
    }
}
