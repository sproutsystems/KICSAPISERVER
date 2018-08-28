using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Formfieldoption
    {
        public short FormFieldOptionId { get; set; }
        public string Text { get; set; }
        public short ListOrder { get; set; }
        public Guid FormFieldId { get; set; }
        public bool IsDefault { get; set; }

        public Formfield FormField { get; set; }
    }
}
