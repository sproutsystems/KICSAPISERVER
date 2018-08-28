using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailgroup
    {
        public Emailgroup()
        {
            Cinemaweeklyemailsetting = new HashSet<Cinemaweeklyemailsetting>();
            Emailemailgroups = new HashSet<Emailemailgroups>();
            Filteremailgroups = new HashSet<Filteremailgroups>();
            Memberemailgroups = new HashSet<Memberemailgroups>();
            Membertypedefaultemailgroups = new HashSet<Membertypedefaultemailgroups>();
            VenuemastercrmconfigOptOut1EmailGroup = new HashSet<Venuemastercrmconfig>();
            VenuemastercrmconfigOptOut2EmailGroup = new HashSet<Venuemastercrmconfig>();
            VenuemastercrmconfigOptOut3EmailGroup = new HashSet<Venuemastercrmconfig>();
        }

        public Guid EmailGroupId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDisplayed { get; set; }
        public int ListOrder { get; set; }

        public Company Company { get; set; }
        public ICollection<Cinemaweeklyemailsetting> Cinemaweeklyemailsetting { get; set; }
        public ICollection<Emailemailgroups> Emailemailgroups { get; set; }
        public ICollection<Filteremailgroups> Filteremailgroups { get; set; }
        public ICollection<Memberemailgroups> Memberemailgroups { get; set; }
        public ICollection<Membertypedefaultemailgroups> Membertypedefaultemailgroups { get; set; }
        public ICollection<Venuemastercrmconfig> VenuemastercrmconfigOptOut1EmailGroup { get; set; }
        public ICollection<Venuemastercrmconfig> VenuemastercrmconfigOptOut2EmailGroup { get; set; }
        public ICollection<Venuemastercrmconfig> VenuemastercrmconfigOptOut3EmailGroup { get; set; }
    }
}
