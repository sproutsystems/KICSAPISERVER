using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Moviereview
    {
        public Moviereview()
        {
            Moviereviewcompanies = new HashSet<Moviereviewcompanies>();
        }

        public int MovieReviewId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CopyrightHolderName { get; set; }
        public decimal RatingOutOfFive { get; set; }
        public Guid MovieId { get; set; }
        public string WebSiteName { get; set; }
        public Guid? CompanyId { get; set; }
        public bool IsActioned { get; set; }

        public Company Company { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Moviereviewcompanies> Moviereviewcompanies { get; set; }
    }
}
