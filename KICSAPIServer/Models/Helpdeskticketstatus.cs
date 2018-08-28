using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Helpdeskticketstatus
    {
        public Helpdeskticketstatus()
        {
            Helpdeskstandardresponse = new HashSet<Helpdeskstandardresponse>();
            Helpdeskticket = new HashSet<Helpdeskticket>();
        }

        public short HelpdeskTicketStatusId { get; set; }
        public string Name { get; set; }
        public int AdminSortOrder { get; set; }
        public int UserSortOrder { get; set; }
        public bool IsCompleted { get; set; }

        public ICollection<Helpdeskstandardresponse> Helpdeskstandardresponse { get; set; }
        public ICollection<Helpdeskticket> Helpdeskticket { get; set; }
    }
}
