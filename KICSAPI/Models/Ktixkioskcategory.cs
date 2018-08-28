using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixkioskcategory
    {
        public Ktixkioskcategory()
        {
            Ktixkiosksaleitem = new HashSet<Ktixkiosksaleitem>();
        }

        public Guid KtixKioskCategoryId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Name { get; set; }
        public short DisplayOrder { get; set; }
        public string Introduction { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixkiosksaleitem> Ktixkiosksaleitem { get; set; }
    }
}
