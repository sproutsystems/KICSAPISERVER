using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixitemgroup
    {
        public Ktixitemgroup()
        {
            Ktixcomboitem = new HashSet<Ktixcomboitem>();
            Ktixsaleitem = new HashSet<Ktixsaleitem>();
        }

        public Guid KtixItemGroupId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public short DisplayOrder { get; set; }
        public string Introduction { get; set; }
        public string IconURL { get; set; }
        public string bgCode { get; set; }
        public Boolean IsAvaliable { get; set; }
        public Boolean IsTicket { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixcomboitem> Ktixcomboitem { get; set; }
        public ICollection<Ktixsaleitem> Ktixsaleitem { get; set; }
    }
}
