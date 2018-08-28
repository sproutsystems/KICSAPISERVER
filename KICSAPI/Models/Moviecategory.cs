using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Moviecategory
    {
        public Moviecategory()
        {
            Cinemasessiondisplaymoviecategories = new HashSet<Cinemasessiondisplaymoviecategories>();
            Cinemasessionfilterbuttonmoviecategory = new HashSet<Cinemasessionfilterbuttonmoviecategory>();
            Filtermoviecategorypurchases = new HashSet<Filtermoviecategorypurchases>();
            Membermoviecategorypurchaselog = new HashSet<Membermoviecategorypurchaselog>();
            Movieinstancemoviecategories = new HashSet<Movieinstancemoviecategories>();
            SessioncreationruleExcludeMovieCategory = new HashSet<Sessioncreationrule>();
            SessioncreationruleMovieCategory = new HashSet<Sessioncreationrule>();
        }

        public Guid MovieCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsSelectedByDefault { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public string OnlineTicketingStartMessage { get; set; }
        public bool? IsUseForYouMightAlsoLike { get; set; }

        public Company Company { get; set; }
        public ICollection<Cinemasessiondisplaymoviecategories> Cinemasessiondisplaymoviecategories { get; set; }
        public ICollection<Cinemasessionfilterbuttonmoviecategory> Cinemasessionfilterbuttonmoviecategory { get; set; }
        public ICollection<Filtermoviecategorypurchases> Filtermoviecategorypurchases { get; set; }
        public ICollection<Membermoviecategorypurchaselog> Membermoviecategorypurchaselog { get; set; }
        public ICollection<Movieinstancemoviecategories> Movieinstancemoviecategories { get; set; }
        public ICollection<Sessioncreationrule> SessioncreationruleExcludeMovieCategory { get; set; }
        public ICollection<Sessioncreationrule> SessioncreationruleMovieCategory { get; set; }
    }
}
