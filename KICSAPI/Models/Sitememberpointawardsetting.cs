using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sitememberpointawardsetting
    {
        public Guid SiteMemberPointRewardSettingId { get; set; }
        public short MovieCommentRewardPoints { get; set; }
        public short BlogPostCommentRewardPoints { get; set; }
        public short PollVoteRewardPoints { get; set; }
        public Guid SiteId { get; set; }

        public Site Site { get; set; }
    }
}
