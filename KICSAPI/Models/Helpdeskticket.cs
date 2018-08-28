using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Helpdeskticket
    {
        public Helpdeskticket()
        {
            Cmslogintoken = new HashSet<Cmslogintoken>();
            Helpdeskmessage = new HashSet<Helpdeskmessage>();
            Quote = new HashSet<Quote>();
        }

        public Guid HelpdeskTicketId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime LastReplyDateTime { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public short ImportanceOutOfFive { get; set; }
        public bool IsSolved { get; set; }
        public Guid UserId { get; set; }
        public short HelpdeskTicketStatusId { get; set; }
        public short HelpdeskCategoryId { get; set; }
        public bool IsSendEmailOnReply { get; set; }
        public bool IsSendSmsonReply { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsClosureWarningEmailSent { get; set; }
        public string Phone { get; set; }
        public string HelpdeskTicketNumber { get; set; }

        public Company Company { get; set; }
        public Helpdeskcategory HelpdeskCategory { get; set; }
        public Helpdeskticketstatus HelpdeskTicketStatus { get; set; }
        public AspnetUsers User { get; set; }
        public ICollection<Cmslogintoken> Cmslogintoken { get; set; }
        public ICollection<Helpdeskmessage> Helpdeskmessage { get; set; }
        public ICollection<Quote> Quote { get; set; }
    }
}
