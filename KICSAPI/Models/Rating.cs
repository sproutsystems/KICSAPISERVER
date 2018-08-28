using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Rating
    {
        public Rating()
        {
            Moviedetail = new HashSet<Moviedetail>();
            Signplaylistcontents = new HashSet<Signplaylistcontents>();
        }

        public short RatingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short CountryId { get; set; }
        public bool? IsRated { get; set; }

        public Country Country { get; set; }
        public ICollection<Moviedetail> Moviedetail { get; set; }
        public ICollection<Signplaylistcontents> Signplaylistcontents { get; set; }
    }
}
