using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstancecinemas
    {
        public Movieinstancecinemas()
        {
            Movieinstancecinemalabels = new HashSet<Movieinstancecinemalabels>();
        }

        public int MovieInstanceCinemaId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsUpdateReleaseDate { get; set; }
        public bool IsSessionBypass { get; set; }
        public DateTime AdjustedReleaseDateNowShowing { get; set; }
        public DateTime AdjustedReleaseDateComingSoon { get; set; }
        public string PointOfSaleTitle { get; set; }
        public bool? IsUpdateLabels { get; set; }
        public bool? IsUpdatePointOfSaleTitle { get; set; }
        public bool IsVoucherRedeemableForFestival { get; set; }

        public Cinema Cinema { get; set; }
        public Movieinstance MovieInstance { get; set; }
        public ICollection<Movieinstancecinemalabels> Movieinstancecinemalabels { get; set; }
    }
}
