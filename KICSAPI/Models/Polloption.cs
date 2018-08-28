using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Polloption
    {
        public Polloption()
        {
            Memberpolloptionlog = new HashSet<Memberpolloptionlog>();
        }

        public Guid PollOptionId { get; set; }
        public string Text { get; set; }
        public int NumberOfVotes { get; set; }
        public Guid PollId { get; set; }
        public short DisplayOrder { get; set; }

        public Poll Poll { get; set; }
        public ICollection<Memberpolloptionlog> Memberpolloptionlog { get; set; }
    }
}
