using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Member
    {
        public Member()
        {
            Bulksmsrecipient = new HashSet<Bulksmsrecipient>();
            Competitionentry = new HashSet<Competitionentry>();
            Emailmembers = new HashSet<Emailmembers>();
            Filtermembers = new HashSet<Filtermembers>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Memberbounce = new HashSet<Memberbounce>();
            Membercinemas = new HashSet<Membercinemas>();
            Membercrmaction = new HashSet<Membercrmaction>();
            Membercustomanswers = new HashSet<Membercustomanswers>();
            Memberemailgroups = new HashSet<Memberemailgroups>();
            Membergenres = new HashSet<Membergenres>();
            Membermoviecategorypurchaselog = new HashSet<Membermoviecategorypurchaselog>();
            Membermoviegenrepurchaselog = new HashSet<Membermoviegenrepurchaselog>();
            Membermoviepurchaseimport = new HashSet<Membermoviepurchaseimport>();
            Membermoviepurchaselog = new HashSet<Membermoviepurchaselog>();
            Membermovietypepurchaselog = new HashSet<Membermovietypepurchaselog>();
            Membermovieviewlog = new HashSet<Membermovieviewlog>();
            Memberofferviewlog = new HashSet<Memberofferviewlog>();
            Memberpointlog = new HashSet<Memberpointlog>();
            Memberpolloptionlog = new HashSet<Memberpolloptionlog>();
            Membertransaction = new HashSet<Membertransaction>();
            Shoporder = new HashSet<Shoporder>();
        }

        public Guid MemberId { get; set; }
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
        public bool? IsSendEmail { get; set; }
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
        public bool? HasForcedChangedPassword { get; set; }
        public string MemberTokenId { get; set; }
        public bool? IsSendBulkSms { get; set; }

        public Cinema Cinema { get; set; }
        public Country Country { get; set; }
        public Countrystate CountryState { get; set; }
        public Gender Gender { get; set; }
        public Membertype MemberType { get; set; }
        public Salutation Salutation { get; set; }
        public Site Site { get; set; }
        public AspnetUsers User { get; set; }
        public ICollection<Bulksmsrecipient> Bulksmsrecipient { get; set; }
        public ICollection<Competitionentry> Competitionentry { get; set; }
        public ICollection<Emailmembers> Emailmembers { get; set; }
        public ICollection<Filtermembers> Filtermembers { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Memberbounce> Memberbounce { get; set; }
        public ICollection<Membercinemas> Membercinemas { get; set; }
        public ICollection<Membercrmaction> Membercrmaction { get; set; }
        public ICollection<Membercustomanswers> Membercustomanswers { get; set; }
        public ICollection<Memberemailgroups> Memberemailgroups { get; set; }
        public ICollection<Membergenres> Membergenres { get; set; }
        public ICollection<Membermoviecategorypurchaselog> Membermoviecategorypurchaselog { get; set; }
        public ICollection<Membermoviegenrepurchaselog> Membermoviegenrepurchaselog { get; set; }
        public ICollection<Membermoviepurchaseimport> Membermoviepurchaseimport { get; set; }
        public ICollection<Membermoviepurchaselog> Membermoviepurchaselog { get; set; }
        public ICollection<Membermovietypepurchaselog> Membermovietypepurchaselog { get; set; }
        public ICollection<Membermovieviewlog> Membermovieviewlog { get; set; }
        public ICollection<Memberofferviewlog> Memberofferviewlog { get; set; }
        public ICollection<Memberpointlog> Memberpointlog { get; set; }
        public ICollection<Memberpolloptionlog> Memberpolloptionlog { get; set; }
        public ICollection<Membertransaction> Membertransaction { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
    }
}
