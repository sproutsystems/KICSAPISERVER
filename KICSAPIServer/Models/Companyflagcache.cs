using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companyflagcache
    {
        public int CompanyFlagCacheId { get; set; }
        public Guid CompanyId { get; set; }
        public short FlagId { get; set; }
        public int DisplayOrder { get; set; }

        public Company Company { get; set; }
        public Flag Flag { get; set; }
    }
}
