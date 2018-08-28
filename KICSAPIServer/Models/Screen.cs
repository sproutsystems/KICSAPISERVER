using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Screen
    {
        public Screen()
        {
            Haxlenticketingbooking = new HashSet<Haxlenticketingbooking>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Screenscreenfeatures = new HashSet<Screenscreenfeatures>();
            Screenseat = new HashSet<Screenseat>();
            Session = new HashSet<Session>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
        }

        public Guid ScreenId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public short DisplayRows { get; set; }
        public short DisplayCols { get; set; }
        public short SoldOutLimit { get; set; }
        public short NumberOfSeats { get; set; }
        public Guid ScreenTypeId { get; set; }
        public bool? IsDisplayOnSessionToolTip { get; set; }
        public bool? IsValidateSeatSelection { get; set; }
        public string SeatingMapText { get; set; }

        public Cinema Cinema { get; set; }
        public Screentype ScreenType { get; set; }
        public ICollection<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Screenscreenfeatures> Screenscreenfeatures { get; set; }
        public ICollection<Screenseat> Screenseat { get; set; }
        public ICollection<Session> Session { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
    }
}
