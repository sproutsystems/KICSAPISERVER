using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Advertisementdays
    {
        public int AdvertisementDayId { get; set; }
        public Guid AdvertisementId { get; set; }
        public short DayId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Advertisement Advertisement { get; set; }
        public Day Day { get; set; }
    }
}
