using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Session
    {
        public Session()
        {
            Haxlenticketingbooking = new HashSet<Haxlenticketingbooking>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Ktixsession = new HashSet<Ktixsession>();
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Sessionflags = new HashSet<Sessionflags>();
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
        }

        public long SessionId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid ScreenId { get; set; }
        public DateTime DateTime { get; set; }
        public string PointOfSaleId { get; set; }
        public short SeatsRemaining { get; set; }
        public bool IsOnlineTicketing { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string BookingUrl { get; set; }

        public Cinema Cinema { get; set; }
        public Movieinstance MovieInstance { get; set; }
        public Screen Screen { get; set; }
        public ICollection<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Ktixsession> Ktixsession { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Sessionflags> Sessionflags { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }

       
    }
}
