using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Blogpost = new HashSet<Blogpost>();
            Cmsuser = new HashSet<Cmsuser>();
            Company = new HashSet<Company>();
            Countrystate = new HashSet<Countrystate>();
            Distributor = new HashSet<Distributor>();
            Member = new HashSet<Member>();
            Moviedetail = new HashSet<Moviedetail>();
            Rating = new HashSet<Rating>();
        }

        public short CountryId { get; set; }
        public string Name { get; set; }
        public short? LanguageId { get; set; }
        public bool IsActive { get; set; }
        public string PhoneCountryCode { get; set; }

        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Cmsuser> Cmsuser { get; set; }
        public ICollection<Company> Company { get; set; }
        public ICollection<Countrystate> Countrystate { get; set; }
        public ICollection<Distributor> Distributor { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Moviedetail> Moviedetail { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
