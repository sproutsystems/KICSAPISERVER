using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Flyer
    {
        public Flyer()
        {
            Flyermovieinstances = new HashSet<Flyermovieinstances>();
            Flyerpromotions = new HashSet<Flyerpromotions>();
        }

        public Guid FlyerId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime ReferenceDate { get; set; }
        public string Name { get; set; }
        public int FlyerTypeId { get; set; }
        public short? DayId { get; set; }

        public Cinema Cinema { get; set; }
        public Day Day { get; set; }
        public Flyertype FlyerType { get; set; }
        public ICollection<Flyermovieinstances> Flyermovieinstances { get; set; }
        public ICollection<Flyerpromotions> Flyerpromotions { get; set; }
    }
}
