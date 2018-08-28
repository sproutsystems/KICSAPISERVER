using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Formfieldtype
    {
        public Formfieldtype()
        {
            Formfield = new HashSet<Formfield>();
        }

        public short FormFieldTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Formfield> Formfield { get; set; }
    }
}
