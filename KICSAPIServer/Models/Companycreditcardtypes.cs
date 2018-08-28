using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Companycreditcardtypes
    {
        public Companycreditcardtypes()
        {
            Haxlenticketingbooking = new HashSet<Haxlenticketingbooking>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Paymentgatewaytransaction = new HashSet<Paymentgatewaytransaction>();
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Shoporder = new HashSet<Shoporder>();
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
        }

        public short CompanyCreditCardTypeId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }

        public Company Company { get; set; }
        public ICollection<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Paymentgatewaytransaction> Paymentgatewaytransaction { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
    }
}
