using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
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
        public string IconURL { get; set; }
        public string bgCode { get; set; }
        public Boolean IsAvaliable { get; set; }
        public string IconURLDisabled { get; set; }

        public Ktixsetting KtixSetting { get; set; }
        public ICollection<Ktixkiosksaleitem> Ktixkiosksaleitem { get; set; }
    }
}
