using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Movieinstance
    {
        public Movieinstance()
        {
            Cinemamoviecache = new HashSet<Cinemamoviecache>();
            Featuredmovieelements = new HashSet<Featuredmovieelements>();
            Flyermovieinstances = new HashSet<Flyermovieinstances>();
            Membermoviepurchaseimport = new HashSet<Membermoviepurchaseimport>();
            Movieinstancecinemas = new HashSet<Movieinstancecinemas>();
            Movieinstancecontent = new HashSet<Movieinstancecontent>();
            Movieinstanceflagdates = new HashSet<Movieinstanceflagdates>();
            Movieinstancelabels = new HashSet<Movieinstancelabels>();
            Movieinstancemoviecategories = new HashSet<Movieinstancemoviecategories>();
            Session = new HashSet<Session>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
            Specialsession = new HashSet<Specialsession>();
        }

        public Guid MovieInstanceId { get; set; }
        public Guid MovieId { get; set; }
        public Guid CompanyId { get; set; }
        public string PointOfSaleTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool? IsUpdateReleaseDate { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public Guid MovieTypeId { get; set; }
        public string Synopsis { get; set; }
        public Guid? PosterContentId { get; set; }
        public string UniqueLabel { get; set; }
        public string UniqueLabelColor { get; set; }
        public bool IsSubtitled { get; set; }
        public Guid? PhotoContentId { get; set; }
        public Guid? PromotionId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? PageId { get; set; }
        public bool? IsUpdateContent { get; set; }
        public Guid MovieDetailId { get; set; }
        public short MovieImportanceTypeId { get; set; }
        public short RestoreMovieImportanceAfterHowManyDays { get; set; }
        public bool IsActive { get; set; }
        public string PointOfSaleId { get; set; }
        public bool? IsShowOnMainInteractive { get; set; }
        public string ShortTitle { get; set; }
        public bool IsUpdateSynopsis { get; set; }
        public bool? IsShowReleaseDate { get; set; }
        public short? RunningTimeWithAds { get; set; }
        public bool? IsShowOnYouMightAlsoLike { get; set; }
        public bool? IsShowOnNewsletter { get; set; }

        public Movie Movie { get; set; }
        public Moviedetail MovieDetail { get; set; }
        public Movieimportancetype MovieImportanceType { get; set; }
        public Movietype MovieType { get; set; }
        public Page Page { get; set; }
        public Content PhotoContent { get; set; }
        public Content PosterContent { get; set; }
        public Promotion Promotion { get; set; }
        public ICollection<Cinemamoviecache> Cinemamoviecache { get; set; }
        public ICollection<Featuredmovieelements> Featuredmovieelements { get; set; }
        public ICollection<Flyermovieinstances> Flyermovieinstances { get; set; }
        public ICollection<Membermoviepurchaseimport> Membermoviepurchaseimport { get; set; }
        public ICollection<Movieinstancecinemas> Movieinstancecinemas { get; set; }
        public ICollection<Movieinstancecontent> Movieinstancecontent { get; set; }
        public ICollection<Movieinstanceflagdates> Movieinstanceflagdates { get; set; }
        public ICollection<Movieinstancelabels> Movieinstancelabels { get; set; }
        public ICollection<Movieinstancemoviecategories> Movieinstancemoviecategories { get; set; }
        public ICollection<Session> Session { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
        public ICollection<Specialsession> Specialsession { get; set; }
    }
}
