using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Formfield
    {
        public Formfield()
        {
            Formfieldoption = new HashSet<Formfieldoption>();
        }

        public Guid FormFieldId { get; set; }
        public string Question { get; set; }
        public short ListOrder { get; set; }
        public bool IsRequired { get; set; }
        public short FormFieldTypeId { get; set; }
        public Guid FormId { get; set; }
        public string MinorText { get; set; }
        public bool IsMultiline { get; set; }
        public int MaximumLength { get; set; }

        public Form Form { get; set; }
        public Formfieldtype FormFieldType { get; set; }
        public ICollection<Formfieldoption> Formfieldoption { get; set; }
    }
}
