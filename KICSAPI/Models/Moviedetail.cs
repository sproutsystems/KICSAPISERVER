using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Moviedetail
    {
        public Moviedetail()
        {
            Advertisement = new HashSet<Advertisement>();
            Blogpost = new HashSet<Blogpost>();
            Competition = new HashSet<Competition>();
            Membermoviepurchaselog = new HashSet<Membermoviepurchaselog>();
            Movieinstance = new HashSet<Movieinstance>();
            Offer = new HashSet<Offer>();
            Ratingchangelog = new HashSet<Ratingchangelog>();
            Retrieverticketingtickettypemovie = new HashSet<Retrieverticketingtickettypemovie>();
            Venuemasterticketingtickettypemovie = new HashSet<Venuemasterticketingtickettypemovie>();
        }

        public Guid MovieDetailId { get; set; }
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string ForeignTitle { get; set; }
        public string Director { get; set; }
        public string OfficialSiteUrl { get; set; }
        public string ExternalTrailerUrl { get; set; }
        public short? RunningTime { get; set; }
        public short? RatingId { get; set; }
        public string ConsumerAdvice { get; set; }
        public string Tagline { get; set; }
        public string Synopsis { get; set; }
        public string CountryOfOriginList { get; set; }
        public string AudioLanguageList { get; set; }
        public bool IsSubtitled { get; set; }
        public DateTime ReleaseDate { get; set; }
        public short? DistributorId { get; set; }
        public string Cast { get; set; }
        public short CountryId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public Guid? PosterContentId { get; set; }
        public Guid? PhotoContentId { get; set; }
        public string ImdbRating { get; set; }

        public Country Country { get; set; }
        public Distributor Distributor { get; set; }
        public Movie Movie { get; set; }
        public Rating Rating { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Competition> Competition { get; set; }
        public ICollection<Membermoviepurchaselog> Membermoviepurchaselog { get; set; }
        public ICollection<Movieinstance> Movieinstance { get; set; }
        public ICollection<Offer> Offer { get; set; }
        public ICollection<Ratingchangelog> Ratingchangelog { get; set; }
        public ICollection<Retrieverticketingtickettypemovie> Retrieverticketingtickettypemovie { get; set; }
        public ICollection<Venuemasterticketingtickettypemovie> Venuemasterticketingtickettypemovie { get; set; }
    }
}
