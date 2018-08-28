using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Flag
    {
        public Flag()
        {
            Cinemasessionfilterbuttonflags = new HashSet<Cinemasessionfilterbuttonflags>();
            Companyflagcache = new HashSet<Companyflagcache>();
            Movieinstanceflagdates = new HashSet<Movieinstanceflagdates>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
            Sessionflags = new HashSet<Sessionflags>();
            Specialsessiontype = new HashSet<Specialsessiontype>();
        }

        public short FlagId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public string Code { get; set; }
        public string TooltipText { get; set; }
        public string Color { get; set; }
        public bool IsColorTime { get; set; }
        public bool? IsShowDailyFlagUnderSession { get; set; }
        public bool? IsShowDailyFlagUnderDate { get; set; }
        public bool IsItalic { get; set; }
        public bool? IsShowOnLegend { get; set; }
        public string OnlineTicketingStartMessage { get; set; }
        public bool IsRemoveOnReleaseDate { get; set; }
        public bool IsAlwaysOnLegend { get; set; }
        public bool IsRemoveMemberLoginForOnlineTicketing { get; set; }

        public Company Company { get; set; }
        public ICollection<Cinemasessionfilterbuttonflags> Cinemasessionfilterbuttonflags { get; set; }
        public ICollection<Companyflagcache> Companyflagcache { get; set; }
        public ICollection<Movieinstanceflagdates> Movieinstanceflagdates { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
        public ICollection<Sessionflags> Sessionflags { get; set; }
        public ICollection<Specialsessiontype> Specialsessiontype { get; set; }
    }
}
