using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Day
    {
        public Day()
        {
            Advertisementdays = new HashSet<Advertisementdays>();
            Company = new HashSet<Company>();
            Flyer = new HashSet<Flyer>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
            Siteconfig = new HashSet<Siteconfig>();
            Time = new HashSet<Time>();
        }

        public short DayId { get; set; }
        public string Name { get; set; }
        public int EnumValue { get; set; }

        public ICollection<Advertisementdays> Advertisementdays { get; set; }
        public ICollection<Company> Company { get; set; }
        public ICollection<Flyer> Flyer { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
        public ICollection<Siteconfig> Siteconfig { get; set; }
        public ICollection<Time> Time { get; set; }
    }
}
