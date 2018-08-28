using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Filtermovienotpurchases = new HashSet<Filtermovienotpurchases>();
            Filtermoviepurchases = new HashSet<Filtermoviepurchases>();
            Fullimagebackground = new HashSet<Fullimagebackground>();
            Membermovieviewlog = new HashSet<Membermovieviewlog>();
            Movieaward = new HashSet<Movieaward>();
            Moviebanner = new HashSet<Moviebanner>();
            Moviecomment = new HashSet<Moviecomment>();
            Moviedetail = new HashSet<Moviedetail>();
            Moviegenres = new HashSet<Moviegenres>();
            Movieinformationsite = new HashSet<Movieinformationsite>();
            Movieinstance = new HashSet<Movieinstance>();
            Movierating = new HashSet<Movierating>();
            Moviereview = new HashSet<Moviereview>();
        }

        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public short LanguageId { get; set; }
        public bool IsActive { get; set; }
        public bool IsArtworkCompleted { get; set; }
        public bool IsInfoCompleted { get; set; }
        public Guid? CompanyId { get; set; }
        public decimal RatingOutOfFive { get; set; }
        public int? MovieAudienceId { get; set; }

        public Company Company { get; set; }
        public Movieaudience MovieAudience { get; set; }
        public ICollection<Filtermovienotpurchases> Filtermovienotpurchases { get; set; }
        public ICollection<Filtermoviepurchases> Filtermoviepurchases { get; set; }
        public ICollection<Fullimagebackground> Fullimagebackground { get; set; }
        public ICollection<Membermovieviewlog> Membermovieviewlog { get; set; }
        public ICollection<Movieaward> Movieaward { get; set; }
        public ICollection<Moviebanner> Moviebanner { get; set; }
        public ICollection<Moviecomment> Moviecomment { get; set; }
        public ICollection<Moviedetail> Moviedetail { get; set; }
        public ICollection<Moviegenres> Moviegenres { get; set; }
        public ICollection<Movieinformationsite> Movieinformationsite { get; set; }
        public ICollection<Movieinstance> Movieinstance { get; set; }
        public ICollection<Movierating> Movierating { get; set; }
        public ICollection<Moviereview> Moviereview { get; set; }
    }
}
