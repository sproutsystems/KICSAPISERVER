using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Movietype
    {
        public Movietype()
        {
            Cinemasessiondisplaymovietypes = new HashSet<Cinemasessiondisplaymovietypes>();
            Cinemasessionfilterbuttonmovietype = new HashSet<Cinemasessionfilterbuttonmovietype>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Membermovietypepurchaselog = new HashSet<Membermovietypepurchaselog>();
            Movieinstance = new HashSet<Movieinstance>();
            Movietypeelement = new HashSet<Movietypeelement>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
        }

        public Guid MovieTypeId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSelectedByDefault { get; set; }
        public bool? IsShowRatingStars { get; set; }
        public string ReleaseDateText { get; set; }
        public bool? IsShowGallery { get; set; }
        public bool? IsShowTabs { get; set; }
        public bool? IsDisplayAllCinemaGroupSessions { get; set; }
        public bool? IsShowReleaseDateForNowShowing { get; set; }
        public string SessionTimeLabelSuffix { get; set; }

        public Company Company { get; set; }
        public ICollection<Cinemasessiondisplaymovietypes> Cinemasessiondisplaymovietypes { get; set; }
        public ICollection<Cinemasessionfilterbuttonmovietype> Cinemasessionfilterbuttonmovietype { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Membermovietypepurchaselog> Membermovietypepurchaselog { get; set; }
        public ICollection<Movieinstance> Movieinstance { get; set; }
        public ICollection<Movietypeelement> Movietypeelement { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
    }
}
