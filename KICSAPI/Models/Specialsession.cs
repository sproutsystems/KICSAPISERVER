using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Specialsession
    {
        public Guid SpecialSessionId { get; set; }
        public Guid MovieInstanceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? StartTime { get; set; }
        public Guid SpecialSessionTypeId { get; set; }
        public Guid CinemaId { get; set; }
        public string Synopsis { get; set; }
        public string SessionPointOfSaleId { get; set; }

        public Cinema Cinema { get; set; }
        public Movieinstance MovieInstance { get; set; }
        public Specialsessiontype SpecialSessionType { get; set; }
    }
}
