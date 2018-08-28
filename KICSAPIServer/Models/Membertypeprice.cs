using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertypeprice
    {
        public Membertypeprice()
        {
            Membercrmaction = new HashSet<Membercrmaction>();
        }

        public int MemberTypePriceId { get; set; }
        public Guid MemberTypeId { get; set; }
        public decimal PriceIncludingTax { get; set; }
        public int NumberOfDays { get; set; }
        public string Name { get; set; }
        public bool? IsSignup { get; set; }
        public string Poscode { get; set; }
        public decimal DeliveryCharge { get; set; }
        public DateTime? ForcedExpiryDate { get; set; }
        public bool? IsActive { get; set; }

        public Membertype MemberType { get; set; }
        public ICollection<Membercrmaction> Membercrmaction { get; set; }
    }
}
