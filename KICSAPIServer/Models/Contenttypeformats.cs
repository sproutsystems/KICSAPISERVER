using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Contenttypeformats
    {
        public int ContentTypeFormatId { get; set; }
        public short ContentTypeId { get; set; }
        public short ContentFormatId { get; set; }

        public Contentformat ContentFormat { get; set; }
        public Contenttype ContentType { get; set; }
    }
}
