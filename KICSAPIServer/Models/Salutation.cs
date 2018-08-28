using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Salutation
    {
        public Salutation()
        {
            Gender = new HashSet<Gender>();
            Member = new HashSet<Member>();
        }

        public short SalutationId { get; set; }
        public string Name { get; set; }
        public short LanguageId { get; set; }

        public ICollection<Gender> Gender { get; set; }
        public ICollection<Member> Member { get; set; }
    }
}
