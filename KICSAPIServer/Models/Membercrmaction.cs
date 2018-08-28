using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membercrmaction
    {
        public Membercrmaction()
        {
            Venuemastercrmlog = new HashSet<Venuemastercrmlog>();
        }

        public int MemberCrmactionId { get; set; }
        public Guid CinemaId { get; set; }
        public int MemberCrmactionTypeId { get; set; }
        public Guid MemberId { get; set; }
        public bool IsActioned { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ActionDateTime { get; set; }
        public int? MemberTypePriceId { get; set; }
        public int? PaymentGatewayTransactionId { get; set; }
        public string TransactionNumber { get; set; }
        public bool IsCustomerEmailSent { get; set; }
        public bool IsAdminEmailSent { get; set; }
        public bool IsSentToCrm { get; set; }
        public int NumberOfAttempts { get; set; }
        public bool IsError { get; set; }

        public Cinema Cinema { get; set; }
        public Member Member { get; set; }
        public Membercrmactiontype MemberCrmactionType { get; set; }
        public Membertypeprice MemberTypePrice { get; set; }
        public Paymentgatewaytransaction PaymentGatewayTransaction { get; set; }
        public ICollection<Venuemastercrmlog> Venuemastercrmlog { get; set; }
    }
}
