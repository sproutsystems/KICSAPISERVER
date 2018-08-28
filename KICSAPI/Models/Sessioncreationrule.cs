using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sessioncreationrule
    {
        public Guid SessionCreationRuleId { get; set; }
        public Guid? MovieCategoryId { get; set; }
        public Guid? MovieInstanceId { get; set; }
        public Guid CinemaId { get; set; }
        public Guid? ScreenId { get; set; }
        public short? FlagId { get; set; }
        public short? DayId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Guid? MovieTypeId { get; set; }
        public bool? IsOnlineTicketing { get; set; }
        public string InformationText { get; set; }
        public Guid? ExcludeMovieCategoryId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }

        public Cinema Cinema { get; set; }
        public Day Day { get; set; }
        public Moviecategory ExcludeMovieCategory { get; set; }
        public Flag Flag { get; set; }
        public Moviecategory MovieCategory { get; set; }
        public Movieinstance MovieInstance { get; set; }
        public Movietype MovieType { get; set; }
        public Screen Screen { get; set; }
    }
}
