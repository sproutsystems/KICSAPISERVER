using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingtickettypemovie
    {
        public int VenueMasterTicketingTicketTypeMovieId { get; set; }
        public Guid VenueMasterTicketingTicketTypeId { get; set; }
        public Guid MovieDetailId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Moviedetail MovieDetail { get; set; }
        public Venuemasterticketingtickettype VenueMasterTicketingTicketType { get; set; }
    }
}
