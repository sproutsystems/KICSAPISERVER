using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class AppPushNotificationStatistics
    {
        public int AppPushNotificationStatisticsId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid? OfferId { get; set; }
        public Guid? PromotionId { get; set; }
        public DateTime SentDateTime { get; set; }
        public int? Success { get; set; }
        public int? Failure { get; set; }
        public string Message { get; set; }
        public string UdidAsString { get; set; }
    }
}
