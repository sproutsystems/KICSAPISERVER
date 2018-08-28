using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Specialsessiontype
    {
        public Specialsessiontype()
        {
            Specialsession = new HashSet<Specialsession>();
        }

        public Guid SpecialSessionTypeId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public string TimeWhenNoTimeSelected { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool? IsGenerateReminder { get; set; }
        public short? FlagId { get; set; }
        public bool IsCreateAutomatically { get; set; }

        public Company Company { get; set; }
        public Flag Flag { get; set; }
        public ICollection<Specialsession> Specialsession { get; set; }
    }
}
