using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Bulksms
    {
        public Bulksms()
        {
            Bulksmscinema = new HashSet<Bulksmscinema>();
            Bulksmsmembertype = new HashSet<Bulksmsmembertype>();
            Bulksmsrecipient = new HashSet<Bulksmsrecipient>();
        }

        public Guid BulkSmsId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime? SentDateTime { get; set; }
        public string Message { get; set; }
        public int TotalRecipients { get; set; }
        public string GatewayReferenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public Guid? FilterId { get; set; }

        public Cinema Cinema { get; set; }
        public Company Company { get; set; }
        public Filter Filter { get; set; }
        public ICollection<Bulksmscinema> Bulksmscinema { get; set; }
        public ICollection<Bulksmsmembertype> Bulksmsmembertype { get; set; }
        public ICollection<Bulksmsrecipient> Bulksmsrecipient { get; set; }
    }
}
