using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sitedisplaysetting
    {
        public Guid SiteDisplaySettingId { get; set; }
        public Guid SiteId { get; set; }
        public short ShortSynopsisLength { get; set; }
        public bool IsCustomerMovieCommentsEnabled { get; set; }
        public bool IsCustomerPostCommentsEnabled { get; set; }
        public bool? IsMovieRatingStarsVisible { get; set; }
        public bool IsCustomerMovieRatingEnabled { get; set; }
        public bool? IsMovieSynopsisShownOnSessionPage { get; set; }
        public bool? IsGlobalBlogPostsEnabled { get; set; }
        public bool IsGlobalCompetitionsEnabled { get; set; }
        public bool? IsCustomerCommentsApprovedByDefault { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public int ContentAreaWidth { get; set; }
        public int AlternateGalleryVideoHeight { get; set; }
        public string SessionTimeSeperatorSuffix { get; set; }
        public bool? IsShowFullRatingOnSessionsPage { get; set; }
        public bool IsShowUnratedRatings { get; set; }
        public bool IsShowLabelNextToTitleOnSessionsPage { get; set; }
        public bool? IsStrikeSoldOutSessionTimes { get; set; }
        public bool IsUseCinemaGroupInLocationBar { get; set; }
        public bool? IsShowAllMemberTypesOnSignupPage { get; set; }
        public bool? IsUseUniqueMemberIdForCache { get; set; }
        public bool? IsLinkToDirectorAndCast { get; set; }
        public int MainInteractiveTypeId { get; set; }
        public bool? IsAllowPreScreenAdvertisementSkip { get; set; }
        public int PreScreenShowPercent { get; set; }
        public bool IsShowFullImageBackgroundOnAllPages { get; set; }
        public bool IsShowSeatsRemaining { get; set; }
        public string FestivalsKeywords { get; set; }
        public string AdditionalHeadScripts { get; set; }
        public string GoogleTagHead { get; set; }
        public string GoogleTagBody { get; set; }

        public Maininteractivetype MainInteractiveType { get; set; }
        public Site Site { get; set; }
    }
}
