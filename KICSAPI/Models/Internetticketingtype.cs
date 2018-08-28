using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Internetticketingtype
    {
        public Internetticketingtype()
        {
            Cinema = new HashSet<Cinema>();
        }

        public short InternetTicketingTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Cinema> Cinema { get; set; }
    }
}
