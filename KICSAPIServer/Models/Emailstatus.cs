using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emailstatus
    {
        public Emailstatus()
        {
            Email = new HashSet<Email>();
        }

        public short EmailStatusId { get; set; }
        public string Name { get; set; }
        public bool IsFinished { get; set; }

        public ICollection<Email> Email { get; set; }
    }
}
