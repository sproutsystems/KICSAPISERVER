using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class AppPushNoticificationUser
    {
        public long AppPushNoticificationUserId { get; set; }
        public Guid CinemaId { get; set; }
        public string UserDeviceId { get; set; }
        public string DeviceType { get; set; }
    }
}
