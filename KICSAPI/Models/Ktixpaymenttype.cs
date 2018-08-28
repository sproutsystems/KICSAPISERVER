using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixpaymenttype
    {
        public Ktixpaymenttype()
        {
            Ktixmasterpaymenttype = new HashSet<Ktixmasterpaymenttype>();
        }

        public int KtixpaymentTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Ktixmasterpaymenttype> Ktixmasterpaymenttype { get; set; }
    }
}
