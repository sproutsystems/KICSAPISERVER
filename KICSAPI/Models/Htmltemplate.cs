using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Htmltemplate
    {
        public int HtmltemplateId { get; set; }
        public string PosReceiptTemplate { get; set; }
        public string PosTicketTemplate { get; set; }
    }
}
