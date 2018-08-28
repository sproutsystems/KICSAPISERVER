using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Filtergenders = new HashSet<Filtergenders>();
            Member = new HashSet<Member>();
        }

        public short GenderId { get; set; }
        public string Name { get; set; }
        public short LanguageId { get; set; }
        public bool IsMale { get; set; }
        public string ShortName { get; set; }
        public short SalutationId { get; set; }

        public Language Language { get; set; }
        public Salutation Salutation { get; set; }
        public ICollection<Filtergenders> Filtergenders { get; set; }
        public ICollection<Member> Member { get; set; }
    }
}
