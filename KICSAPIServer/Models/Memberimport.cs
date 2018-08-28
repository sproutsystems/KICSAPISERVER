using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Memberimport
    {
        public long MemberImportId { get; set; }
        public short SalutationId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public short CountryId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public Guid SiteId { get; set; }
        public Guid CinemaId { get; set; }
        public bool? IsSendEmail { get; set; }
        public DateTime CreateDateTime { get; set; }
        public short? GenderId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MembershipNumber { get; set; }
        public DateTime? MembershipExpiryDate { get; set; }
        public Guid MemberTypeId { get; set; }
        public int CountryStateId { get; set; }
        public bool IsImported { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid? CinemaId2 { get; set; }
        public Guid? CinemaId3 { get; set; }
        public Guid? EmailGroupId1 { get; set; }
        public Guid? EmailGroupId2 { get; set; }
        public Guid? EmailGroupId3 { get; set; }
        public Guid? EmailGroupId4 { get; set; }
    }
}
