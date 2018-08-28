using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Flyerpromotions = new HashSet<Flyerpromotions>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Movieinstance = new HashSet<Movieinstance>();
            Promotioncinemas = new HashSet<Promotioncinemas>();
            Promotionelement = new HashSet<Promotionelement>();
            Promotionmembertypes = new HashSet<Promotionmembertypes>();
        }

        public Guid PromotionId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public DateTime DisplayStartDateTime { get; set; }
        public DateTime DisplayFinishDateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsActive { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public string ExternalLinkUrl { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsGenerateReminders { get; set; }
        public Guid PromotionCategoryId { get; set; }
        public bool? IsShowOnMainInteractive { get; set; }
        public string MainInteractiveTitle { get; set; }
        public bool IsOngoing { get; set; }
        public bool? IsShowDates { get; set; }

        public AspnetUsers ApprovedByUser { get; set; }
        public AspnetUsers AuthorUser { get; set; }
        public Company Company { get; set; }
        public Promotioncategory PromotionCategory { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Flyerpromotions> Flyerpromotions { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Movieinstance> Movieinstance { get; set; }
        public ICollection<Promotioncinemas> Promotioncinemas { get; set; }
        public ICollection<Promotionelement> Promotionelement { get; set; }
        public ICollection<Promotionmembertypes> Promotionmembertypes { get; set; }
    }
}
