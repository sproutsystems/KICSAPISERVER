using System;
using System.Collections.Generic;

namespace KICSAPI.Models
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

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixcomboitem> Ktixcomboitem { get; set; }
        public ICollection<Ktixsaleitem> Ktixsaleitem { get; set; }
    }
}
