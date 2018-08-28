using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class MemberTempData
    {
        public int MemberTempDataId { get; set; }
        public short SalutationId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public short CountryId { get; set; }
        public string Phone { get; set; }
        public Guid SiteId { get; set; }
        public Guid? UserId { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsSendEmail { get; set; }
        public DateTime CreateDateTime { get; set; }
        public short GenderId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short EmailFailureCount { get; set; }
        public string MembershipNumber { get; set; }
        public DateTime? MembershipExpiryDate { get; set; }
        public int MembershipPointsBalance { get; set; }
        public Guid MemberTypeId { get; set; }
        public string LegacyMembershipNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastEmailDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int CountryStateId { get; set; }
        public bool IsBannedFromPostingComments { get; set; }
        public string Email { get; set; }
        public bool IsMemberCardCreated { get; set; }
        public bool IsMemberCardCollected { get; set; }
        public int NumberOfEmailsOpened { get; set; }
        public string MembershipPosid { get; set; }
        public string MembershipPospassword { get; set; }
        public string CinemaList { get; set; }
        public string Mobile { get; set; }
        public string ParentOrGuardian { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? PurgeDateTime { get; set; }
        public DateTime? LastCrmreadDateTime { get; set; }
        public int? NumberOfVisits { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public string GenreList { get; set; }
        public string EmailGroupList { get; set; }
        public string Password { get; set; }
        public bool Actioned { get; set; }
        public string PaypalToken { get; set; }
        public int? MemberTypePriceId { get; set; }
    }
}
