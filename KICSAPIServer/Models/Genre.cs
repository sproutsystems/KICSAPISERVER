using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Companygenres = new HashSet<Companygenres>();
            Filtergenrepreferences = new HashSet<Filtergenrepreferences>();
            Filtergenrepurchases = new HashSet<Filtergenrepurchases>();
            Membergenres = new HashSet<Membergenres>();
            Membermoviegenrepurchaselog = new HashSet<Membermoviegenrepurchaselog>();
            Moviegenres = new HashSet<Moviegenres>();
        }

        public short GenreId { get; set; }
        public string Name { get; set; }
        public short LanguageId { get; set; }

        public Language Language { get; set; }
        public ICollection<Companygenres> Companygenres { get; set; }
        public ICollection<Filtergenrepreferences> Filtergenrepreferences { get; set; }
        public ICollection<Filtergenrepurchases> Filtergenrepurchases { get; set; }
        public ICollection<Membergenres> Membergenres { get; set; }
        public ICollection<Membermoviegenrepurchaselog> Membermoviegenrepurchaselog { get; set; }
        public ICollection<Moviegenres> Moviegenres { get; set; }
    }
}
