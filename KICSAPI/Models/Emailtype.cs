using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailtype
    {
        public Emailtype()
        {
            Email = new HashSet<Email>();
        }

        public short EmailTypeId { get; set; }
        public string Name { get; set; }
        public bool IsUserEditable { get; set; }

        public ICollection<Email> Email { get; set; }
    }
}
