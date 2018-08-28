using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Countrystate
    {
        public Countrystate()
        {
            Cinema = new HashSet<Cinema>();
            Company = new HashSet<Company>();
            Member = new HashSet<Member>();
            ShoporderCustomerCountryState = new HashSet<Shoporder>();
            ShoporderDeliveryCountryState = new HashSet<Shoporder>();
        }

        public int CountryStateId { get; set; }
        public short CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public Country Country { get; set; }
        public ICollection<Cinema> Cinema { get; set; }
        public ICollection<Company> Company { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Shoporder> ShoporderCustomerCountryState { get; set; }
        public ICollection<Shoporder> ShoporderDeliveryCountryState { get; set; }
    }
}
