using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cmsnews
    {
        public Cmsnews()
        {
            Cmsnewscmsusers = new HashSet<Cmsnewscmsusers>();
            Cmsnewscmsusersnew = new HashSet<Cmsnewscmsusersnew>();
        }

        public Guid CmsnewsId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool IsSticky { get; set; }
        public string Url { get; set; }
        public bool IsModal { get; set; }

        public ICollection<Cmsnewscmsusers> Cmsnewscmsusers { get; set; }
        public ICollection<Cmsnewscmsusersnew> Cmsnewscmsusersnew { get; set; }
    }
}
