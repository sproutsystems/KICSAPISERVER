using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Content
    {
        public Content()
        {
            MovieinstancePhotoContent = new HashSet<Movieinstance>();
            MovieinstancePosterContent = new HashSet<Movieinstance>();
            Movieinstancecontent = new HashSet<Movieinstancecontent>();
            Signplaylistcontents = new HashSet<Signplaylistcontents>();
        }

        public Guid ContentId { get; set; }
        public short ContentTypeId { get; set; }
        public string RelatedId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string OriginalFilename { get; set; }
        public short ContentFormatId { get; set; }
        public string ShortGuid { get; set; }
        public Guid? CompanyId { get; set; }
        public bool IsNewLocation { get; set; }
        public bool IsDeletedFromOldLocation { get; set; }

        public Company Company { get; set; }
        public Contentformat ContentFormat { get; set; }
        public Contenttype ContentType { get; set; }
        public ICollection<Movieinstance> MovieinstancePhotoContent { get; set; }
        public ICollection<Movieinstance> MovieinstancePosterContent { get; set; }
        public ICollection<Movieinstancecontent> Movieinstancecontent { get; set; }
        public ICollection<Signplaylistcontents> Signplaylistcontents { get; set; }
    }
}
