using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Shoporderactivitylog
    {
        public long ShopOrderActivityLogId { get; set; }
        public Guid ShopOrderId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Text { get; set; }

        public Shoporder ShopOrder { get; set; }
    }
}
