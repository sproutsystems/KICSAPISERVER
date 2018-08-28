using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Filter
    {
        public Filter()
        {
            Bulksms = new HashSet<Bulksms>();
            Companymemberexportjob = new HashSet<Companymemberexportjob>();
            Email = new HashSet<Email>();
            Filtercinemas = new HashSet<Filtercinemas>();
            Filtercustomquestions = new HashSet<Filtercustomquestions>();
            Filteremailgroups = new HashSet<Filteremailgroups>();
            Filtergenders = new HashSet<Filtergenders>();
            Filtergenrepreferences = new HashSet<Filtergenrepreferences>();
            Filtergenrepurchases = new HashSet<Filtergenrepurchases>();
            Filtermembers = new HashSet<Filtermembers>();
            Filtermembertype = new HashSet<Filtermembertype>();
            Filtermoviecategorypurchases = new HashSet<Filtermoviecategorypurchases>();
            Filtermovienotpurchases = new HashSet<Filtermovienotpurchases>();
            Filtermoviepurchases = new HashSet<Filtermoviepurchases>();
            Filtermovietypepurchases = new HashSet<Filtermovietypepurchases>();
        }

        public Guid FilterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public DateTime? ExpiryDateLowerLimit { get; set; }
        public DateTime? ExpiryDateUpperLimit { get; set; }
        public DateTime? JoinDateLowerLimit { get; set; }
        public DateTime? JoinDateUpperLimit { get; set; }
        public short AgeLowerLimit { get; set; }
        public short AgeUpperLimit { get; set; }
        public int MoviePurchaseFilterTypeId { get; set; }
        public short MoviePurchaseFilterNumberOfMovies { get; set; }
        public short MoviePurchaseFilterNumberOfWeeks { get; set; }
        public DateTime LastGeneratedDateTime { get; set; }
        public int LastGeneratedNumberOfMembers { get; set; }
        public bool? IsIncludeMembersWithNoGenrePreferences { get; set; }
        public int FilterEmailStatusId { get; set; }
        public DateTime? ExecuteDateTime { get; set; }
        public bool IsImportedFromFile { get; set; }

        public Company Company { get; set; }
        public Filteremailstatus FilterEmailStatus { get; set; }
        public Moviepurchasefiltertype MoviePurchaseFilterType { get; set; }
        public ICollection<Bulksms> Bulksms { get; set; }
        public ICollection<Companymemberexportjob> Companymemberexportjob { get; set; }
        public ICollection<Email> Email { get; set; }
        public ICollection<Filtercinemas> Filtercinemas { get; set; }
        public ICollection<Filtercustomquestions> Filtercustomquestions { get; set; }
        public ICollection<Filteremailgroups> Filteremailgroups { get; set; }
        public ICollection<Filtergenders> Filtergenders { get; set; }
        public ICollection<Filtergenrepreferences> Filtergenrepreferences { get; set; }
        public ICollection<Filtergenrepurchases> Filtergenrepurchases { get; set; }
        public ICollection<Filtermembers> Filtermembers { get; set; }
        public ICollection<Filtermembertype> Filtermembertype { get; set; }
        public ICollection<Filtermoviecategorypurchases> Filtermoviecategorypurchases { get; set; }
        public ICollection<Filtermovienotpurchases> Filtermovienotpurchases { get; set; }
        public ICollection<Filtermoviepurchases> Filtermoviepurchases { get; set; }
        public ICollection<Filtermovietypepurchases> Filtermovietypepurchases { get; set; }
    }
}
