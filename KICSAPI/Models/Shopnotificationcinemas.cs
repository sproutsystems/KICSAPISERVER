using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Shopnotificationcinemas
    {
        public int ShopNotificationCinemaId { get; set; }
        public int ShopNotificationId { get; set; }
        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public Shopnotification ShopNotification { get; set; }
    }
}
