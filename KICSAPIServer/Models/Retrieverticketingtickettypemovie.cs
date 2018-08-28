using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingtickettypemovie
    {
        public int RetrieverTicketingTicketTypeMovieId { get; set; }
        public Guid RetrieverTicketingTicketTypeId { get; set; }
        public Guid MovieDetailId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Moviedetail MovieDetail { get; set; }
        public Retrieverticketingtickettype RetrieverTicketingTicketType { get; set; }
    }
}
