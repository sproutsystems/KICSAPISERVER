using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Time
    {
        public Time()
        {
            Advertisementlocationplaylistschedule = new HashSet<Advertisementlocationplaylistschedule>();
            Cinema = new HashSet<Cinema>();
            Signplaylistschedule = new HashSet<Signplaylistschedule>();
        }

        public short TimeId { get; set; }
        public short DayId { get; set; }
        public short Hour { get; set; }
        public string Text { get; set; }

        public Day Day { get; set; }
        public ICollection<Advertisementlocationplaylistschedule> Advertisementlocationplaylistschedule { get; set; }
        public ICollection<Cinema> Cinema { get; set; }
        public ICollection<Signplaylistschedule> Signplaylistschedule { get; set; }
    }
}
