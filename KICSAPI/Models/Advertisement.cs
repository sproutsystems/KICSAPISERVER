using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            Advertisementadvertisementlocations = new HashSet<Advertisementadvertisementlocations>();
            Advertisementcinemas = new HashSet<Advertisementcinemas>();
            Advertisementdays = new HashSet<Advertisementdays>();
            Advertisementplaylistadvertisements = new HashSet<Advertisementplaylistadvertisements>();
        }

        public Guid AdvertisementId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AdvertisementClientId { get; set; }
        public Guid AdvertisementCampaignId { get; set; }
        public Guid AdvertisementLocationTypeId { get; set; }
        public string TooltipText { get; set; }
        public string DestinationUrl { get; set; }
        public Guid? MovieDetailId { get; set; }
        public Guid? PromotionId { get; set; }
        public Guid? CompetitionId { get; set; }
        public Guid? OfferId { get; set; }
        public Guid? BlogPostId { get; set; }
        public Guid? ShopId { get; set; }
        public Guid? PageId { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDateTime { get; set; }
        public Guid AuthorUserId { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public Guid? MovieBannerId { get; set; }

        public Advertisementcampaign AdvertisementCampaign { get; set; }
        public Advertisementclient AdvertisementClient { get; set; }
        public Advertisementlocationtype AdvertisementLocationType { get; set; }
        public AspnetUsers ApprovedByUser { get; set; }
        public AspnetUsers AuthorUser { get; set; }
        public Blogpost BlogPost { get; set; }
        public Company Company { get; set; }
        public Competition Competition { get; set; }
        public Moviedetail MovieDetail { get; set; }
        public Offer Offer { get; set; }
        public Page Page { get; set; }
        public Promotion Promotion { get; set; }
        public Shop Shop { get; set; }
        public ICollection<Advertisementadvertisementlocations> Advertisementadvertisementlocations { get; set; }
        public ICollection<Advertisementcinemas> Advertisementcinemas { get; set; }
        public ICollection<Advertisementdays> Advertisementdays { get; set; }
        public ICollection<Advertisementplaylistadvertisements> Advertisementplaylistadvertisements { get; set; }
    }
}
