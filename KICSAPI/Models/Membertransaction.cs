using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Membertransaction
    {
        public int MemberTransactionId { get; set; }
        public Guid MemberId { get; set; }
        public int PaymentGatewayTransactionId { get; set; }
        public string DescriptionOfTransaction { get; set; }
        public DateTime CreateDateTime { get; set; }
        public decimal Amount { get; set; }

        public Member Member { get; set; }
        public Paymentgatewaytransaction PaymentGatewayTransaction { get; set; }
    }
}
