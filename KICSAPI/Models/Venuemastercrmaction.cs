using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemastercrmaction
    {
        public int VenueMasterCrmactionId { get; set; }
        public int VenueMasterCrmconfigId { get; set; }
        public int VenueMasterCrmactionTypeId { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool IsActioned { get; set; }

        public Venuemastercrmactiontype VenueMasterCrmactionType { get; set; }
        public Venuemastercrmconfig VenueMasterCrmconfig { get; set; }
    }
}
