using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ratingchangelog
    {
        public int RatingChangeLogId { get; set; }
        public Guid CmsuserId { get; set; }
        public Guid MovieDetailId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string OldRating { get; set; }
        public string NewRating { get; set; }
        public string OldRunningTime { get; set; }
        public string NewRunningTime { get; set; }
        public string OldConsumerAdvice { get; set; }
        public string NewConsumerAdvice { get; set; }

        public Cmsuser Cmsuser { get; set; }
        public Moviedetail MovieDetail { get; set; }
    }
}
