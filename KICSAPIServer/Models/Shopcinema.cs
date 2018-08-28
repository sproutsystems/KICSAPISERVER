using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shopcinema
    {
        public int ShopCinemaId { get; set; }
        public Guid ShopId { get; set; }
        public Guid CinemaId { get; set; }
        public int ReportDeliveryFrequencyInDays { get; set; }
        public DateTime LastReportDeliveryDate { get; set; }
        public string NotificationEmailAddress { get; set; }
        public bool? IsSendNotificationEmailPerOrder { get; set; }

        public Cinema Cinema { get; set; }
        public Shop Shop { get; set; }
    }
}
