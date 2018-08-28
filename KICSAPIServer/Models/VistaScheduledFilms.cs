using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class VistaScheduledFilms
    {
        public int VistaScheduledFilmsId { get; set; }
        public string VistaId { get; set; }
        public string ScheduledFilmId { get; set; }
        public string CinemaId { get; set; }
        public string Title { get; set; }
        public string TitleAlt { get; set; }
        public string Distributor { get; set; }
        public string Rating { get; set; }
        public string RatingAlt { get; set; }
        public string RatingDescription { get; set; }
        public string RatingDescriptionAlt { get; set; }
        public string Synopsis { get; set; }
        public string SynopsisAlt { get; set; }
        public string OpeningDate { get; set; }
        public string FilmHopk { get; set; }
        public string FilmHocode { get; set; }
        public string ShortCode { get; set; }
        public string RunTime { get; set; }
        public string TrailerUrl { get; set; }
        public string DisplaySequence { get; set; }
        public string TwitterTag { get; set; }
        public bool? HasSessionsAvailable { get; set; }
        public string GraphicUrl { get; set; }
        public string CinemaName { get; set; }
        public string CinemaNameAlt { get; set; }
        public bool? AllowTicketSales { get; set; }
        public bool? AdvertiseAdvanceBookingDate { get; set; }
        public string AdvanceBookingDate { get; set; }
        public string LoyaltyAdvanceBookingDate { get; set; }
        public bool? HasDynamicallyPricedTicketsAvailable { get; set; }
        public bool? IsPlayThroughMarketingFilm { get; set; }
        public string CustomerRatingStatisticsRatingCount { get; set; }
        public string CustomerRatingStatisticsAverageScore { get; set; }
        public string CustomerRatingTrailerStatisticsRatingCount { get; set; }
        public string CustomerRatingTrailerStatisticsAverageScore { get; set; }
        public string NationalOpeningDate { get; set; }
        public string CorporateFilmId { get; set; }
        public string Edicode { get; set; }
        public int? DataCacheId { get; set; }
    }
}
