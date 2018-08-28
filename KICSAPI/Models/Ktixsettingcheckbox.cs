using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixsettingcheckbox
    {
        public int KtixSettingCheckBoxId { get; set; }
        public Guid KtixSettingId { get; set; }
        public string Text { get; set; }

        public Ktixsetting KtixSetting { get; set; }
    }
}
