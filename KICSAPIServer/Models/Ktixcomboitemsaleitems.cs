using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixcomboitemsaleitems
    {
        public int KtixComboSaleItemId { get; set; }
        public Guid KtixComboItemId { get; set; }
        public Guid KtixSaleItemId { get; set; }
        public short DisplayOrder { get; set; }
        public int Quantity { get; set; }

        public Ktixcomboitem KtixComboItem { get; set; }
    }
}
