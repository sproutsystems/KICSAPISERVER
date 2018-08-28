using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementcampaign
    {
        public Advertisementcampaign()
        {
            Advertisement = new HashSet<Advertisement>();
        }

        public Guid AdvertisementCampaignId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid AdvertisementClientId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }

        public Advertisementclient AdvertisementClient { get; set; }
        public Company Company { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
    }
}
