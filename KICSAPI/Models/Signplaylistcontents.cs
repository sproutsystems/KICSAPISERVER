using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Signplaylistcontents
    {
        public int SignPlayListContentId { get; set; }
        public Guid SignPlayListId { get; set; }
        public Guid ContentId { get; set; }
        public short PlaybackOrder { get; set; }
        public string PassThroughData { get; set; }
        public short? RatingId { get; set; }

        public Content Content { get; set; }
        public Rating Rating { get; set; }
        public Signplaylist SignPlayList { get; set; }
    }
}
