using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Advertisementclient
    {
        public Advertisementclient()
        {
            Advertisement = new HashSet<Advertisement>();
            Advertisementcampaign = new HashSet<Advertisementcampaign>();
        }

        public Guid AdvertisementClientId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }

        public Company Company { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Advertisementcampaign> Advertisementcampaign { get; set; }
    }
}
