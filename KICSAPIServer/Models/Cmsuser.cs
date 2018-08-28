using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cmsuser
    {
        public Cmsuser()
        {
            Alert = new HashSet<Alert>();
            Cmslogintoken = new HashSet<Cmslogintoken>();
            Cmsnewscmsusers = new HashSet<Cmsnewscmsusers>();
            Cmsnewscmsusersnew = new HashSet<Cmsnewscmsusersnew>();
            Cmsuseralerttypes = new HashSet<Cmsuseralerttypes>();
            Cmsusercinemas = new HashSet<Cmsusercinemas>();
            Cmsusersites = new HashSet<Cmsusersites>();
            Ktixmastertransaction = new HashSet<Ktixmastertransaction>();
            Quote = new HashSet<Quote>();
            Ratingchangelog = new HashSet<Ratingchangelog>();
            Supportresourcecomment = new HashSet<Supportresourcecomment>();
        }

        public Guid CmsuserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Guid CompanyId { get; set; }
        public short CountryId { get; set; }
        public short CmsuserTypeId { get; set; }
        public Guid UserId { get; set; }
        public string TimeZoneLocationId { get; set; }
        public bool IsDeleted { get; set; }
        public string Mobile { get; set; }
        public bool? IsAbleToApproveQuotes { get; set; }
        public int? Pospin { get; set; }
        public DateTime? PospinexpiryDate { get; set; }
        public bool IsPosUser { get; set; }
        public bool IsLoggedInToPos { get; set; }
        public Guid? LastKtixPosTerminalId { get; set; }

        public Cmsusertype CmsuserType { get; set; }
        public Company Company { get; set; }
        public Country Country { get; set; }
        public AspnetUsers User { get; set; }
        public ICollection<Alert> Alert { get; set; }
        public ICollection<Cmslogintoken> Cmslogintoken { get; set; }
        public ICollection<Cmsnewscmsusers> Cmsnewscmsusers { get; set; }
        public ICollection<Cmsnewscmsusersnew> Cmsnewscmsusersnew { get; set; }
        public ICollection<Cmsuseralerttypes> Cmsuseralerttypes { get; set; }
        public ICollection<Cmsusercinemas> Cmsusercinemas { get; set; }
        public ICollection<Cmsusersites> Cmsusersites { get; set; }
        public ICollection<Ktixmastertransaction> Ktixmastertransaction { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<Ratingchangelog> Ratingchangelog { get; set; }
        public ICollection<Supportresourcecomment> Supportresourcecomment { get; set; }
    }
}
