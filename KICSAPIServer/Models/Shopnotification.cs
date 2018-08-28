using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shopnotification
    {
        public Shopnotification()
        {
            Shopnotificationcinemas = new HashSet<Shopnotificationcinemas>();
        }

        public int ShopNotificationId { get; set; }
        public Guid ShopId { get; set; }
        public int ReportDeliveryFrequencyInDays { get; set; }
        public DateTime LastReportDeliveryDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public bool? IsSendNotificationEmailPerOrder { get; set; }

        public Shop Shop { get; set; }
        public ICollection<Shopnotificationcinemas> Shopnotificationcinemas { get; set; }
    }
}
