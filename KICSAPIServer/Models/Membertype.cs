using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Membertype
    {
        public Membertype()
        {
            Blogpostmembertypes = new HashSet<Blogpostmembertypes>();
            Bulksmsmembertype = new HashSet<Bulksmsmembertype>();
            Cinema = new HashSet<Cinema>();
            Competitionmembertypes = new HashSet<Competitionmembertypes>();
            Emailmembertypes = new HashSet<Emailmembertypes>();
            Filtermembertype = new HashSet<Filtermembertype>();
            Haxlenticketingticketsettingmembertypes = new HashSet<Haxlenticketingticketsettingmembertypes>();
            Includeelementinstancemembertypes = new HashSet<Includeelementinstancemembertypes>();
            Member = new HashSet<Member>();
            Membertypecustomquestion = new HashSet<Membertypecustomquestion>();
            Membertypedefaultemailgroups = new HashSet<Membertypedefaultemailgroups>();
            Membertypeemail = new HashSet<Membertypeemail>();
            Membertypeprice = new HashSet<Membertypeprice>();
            Offermembertypes = new HashSet<Offermembertypes>();
            Pageregionmembertypes = new HashSet<Pageregionmembertypes>();
            Pollmembertypes = new HashSet<Pollmembertypes>();
            Promotionmembertypes = new HashSet<Promotionmembertypes>();
            Shoppricegroupmembertypes = new HashSet<Shoppricegroupmembertypes>();
            Sidebarelementmembertypes = new HashSet<Sidebarelementmembertypes>();
            Site = new HashSet<Site>();
        }

        public Guid MemberTypeId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public bool? IsMemberDeletable { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RoleId { get; set; }
        public bool IsAddressRequired { get; set; }
        public bool? IsPostCodeRequired { get; set; }
        public bool IsMembershipNumberRequired { get; set; }
        public bool IsPaidMembership { get; set; }
        public bool? IsWebsiteLoginEnabled { get; set; }
        public string PostCodeWhiteList { get; set; }
        public bool IsAddressDisplayed { get; set; }
        public string SignupIntroductionText { get; set; }
        public string PaymentFormIntroductionText { get; set; }
        public string ReceiptText { get; set; }
        public bool IsMemberCardCreatedByDefault { get; set; }
        public bool IsMemberCardCollectedByDefault { get; set; }
        public string PosmemberTypeId { get; set; }
        public bool? IsWebsitePurchaseEnabled { get; set; }
        public string ProcessingInstructions { get; set; }
        public bool? IsGenreDisplayed { get; set; }
        public string EmailGroupLabelText { get; set; }
        public bool? IsAdditionalCinemasDisplayed { get; set; }
        public bool? IsApplyAllCinemasInCinemaGroup { get; set; }
        public bool IsSendAutomaticEmails { get; set; }
        public bool? IsMobileDisplayed { get; set; }
        public bool IsPhoneDisplayed { get; set; }
        public string CreateAccountTitle { get; set; }
        public int RenewalLimitInWeeks { get; set; }
        public string ExpiryWarningNoticeText { get; set; }
        public string RenewalSuccessText { get; set; }
        public string RenewalPageTitleText { get; set; }
        public string RenewalDescriptionText { get; set; }
        public string ExpiredNoticeText { get; set; }
        public bool IsRenewOnline { get; set; }
        public string GenreLabelText { get; set; }
        public bool IsParentOrGuardianDisplayed { get; set; }
        public int DisplayRenewalWarningWithinWeeks { get; set; }
        public string SignupNotificationEmailAddress { get; set; }
        public string RenewalNotificationEmailAddress { get; set; }
        public bool IsPermitAutomatiedOverwriteByValidPaidMember { get; set; }
        public bool? IsPermitLoginUsingMembershipNumberWhenEmailExists { get; set; }
        public bool? IsEmailAddressRequired { get; set; }
        public bool? IsCreateAspnetAccount { get; set; }
        public bool IsEmailValidationRequired { get; set; }
        public int? NumberOfVisitsForFreeTicket { get; set; }
        public string NumberOfVisitsInformation { get; set; }
        public bool? IsShowPersonalDetailsBeforeActivation { get; set; }
        public int DisplayOrder { get; set; }

        public Company Company { get; set; }
        public AspnetRoles Role { get; set; }
        public ICollection<Blogpostmembertypes> Blogpostmembertypes { get; set; }
        public ICollection<Bulksmsmembertype> Bulksmsmembertype { get; set; }
        public ICollection<Cinema> Cinema { get; set; }
        public ICollection<Competitionmembertypes> Competitionmembertypes { get; set; }
        public ICollection<Emailmembertypes> Emailmembertypes { get; set; }
        public ICollection<Filtermembertype> Filtermembertype { get; set; }
        public ICollection<Haxlenticketingticketsettingmembertypes> Haxlenticketingticketsettingmembertypes { get; set; }
        public ICollection<Includeelementinstancemembertypes> Includeelementinstancemembertypes { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Membertypecustomquestion> Membertypecustomquestion { get; set; }
        public ICollection<Membertypedefaultemailgroups> Membertypedefaultemailgroups { get; set; }
        public ICollection<Membertypeemail> Membertypeemail { get; set; }
        public ICollection<Membertypeprice> Membertypeprice { get; set; }
        public ICollection<Offermembertypes> Offermembertypes { get; set; }
        public ICollection<Pageregionmembertypes> Pageregionmembertypes { get; set; }
        public ICollection<Pollmembertypes> Pollmembertypes { get; set; }
        public ICollection<Promotionmembertypes> Promotionmembertypes { get; set; }
        public ICollection<Shoppricegroupmembertypes> Shoppricegroupmembertypes { get; set; }
        public ICollection<Sidebarelementmembertypes> Sidebarelementmembertypes { get; set; }
        public ICollection<Site> Site { get; set; }
    }
}
