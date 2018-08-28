using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Ktixgiftcard
    {
        public Ktixgiftcard()
        {
            Ktixmasterpaymenttype = new HashSet<Ktixmasterpaymenttype>();
        }

        public Guid KtixGiftCardId { get; set; }
        public string GiftCardNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int CurrentState { get; set; }

        public Ktixgiftcardstate CurrentStateNavigation { get; set; }
        public ICollection<Ktixmasterpaymenttype> Ktixmasterpaymenttype { get; set; }
    }
}
