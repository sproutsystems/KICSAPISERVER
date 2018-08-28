using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Mobilealert
    {
        public Mobilealert()
        {
            Mobilealertcinemas = new HashSet<Mobilealertcinemas>();
        }

        public int MobileAlertId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime DisplayStartDateTime { get; set; }
        public DateTime DisplayFinishDateTime { get; set; }
        public string Text { get; set; }
        public bool? IsActive { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? OfferId { get; set; }

        public Company Company { get; set; }
        public Offer Offer { get; set; }
        public ICollection<Mobilealertcinemas> Mobilealertcinemas { get; set; }
    }
}
