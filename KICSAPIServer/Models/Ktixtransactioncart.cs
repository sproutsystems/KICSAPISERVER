using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixtransactioncart
    {
        public Ktixtransactioncart()
        {
            Ktixmastertransaction = new HashSet<Ktixmastertransaction>();
            Ktixtransactioncartitems = new HashSet<Ktixtransactioncartitems>();
        }

        public long KtixTransactionCartId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ExpiryDateTime { get; set; }

        public ICollection<Ktixmastertransaction> Ktixmastertransaction { get; set; }
        public ICollection<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
    }
}
