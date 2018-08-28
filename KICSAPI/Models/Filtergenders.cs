using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filtergenders
    {
        public int FilterGenderId { get; set; }
        public Guid FilterId { get; set; }
        public short GenderId { get; set; }

        public Filter Filter { get; set; }
        public Gender Gender { get; set; }
    }
}
