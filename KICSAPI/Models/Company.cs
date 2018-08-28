using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            Advertisement = new HashSet<Advertisement>();
            Advertisementcampaign = new HashSet<Advertisementcampaign>();
            Advertisementclient = new HashSet<Advertisementclient>();
            Blogpost = new HashSet<Blogpost>();
            Bulksms = new HashSet<Bulksms>();
            Carousel = new HashSet<Carousel>();
            Cinema = new HashSet<Cinema>();
            Cinemagroup = new HashSet<Cinemagroup>();
            Cmsuser = new HashSet<Cmsuser>();
            Companyautopost = new HashSet<Companyautopost>();
            Companybackgroundrate = new HashSet<Companybackgroundrate>();
            Companybannerrate = new HashSet<Companybannerrate>();
            Companycontactemail = new HashSet<Companycontactemail>();
            Companycreditcardtypes = new HashSet<Companycreditcardtypes>();
            Companydefaults = new HashSet<Companydefaults>();
            Companyemailrate = new HashSet<Companyemailrate>();
            Companyemailsubjecttemplate = new HashSet<Companyemailsubjecttemplate>();
            Companyfeatures = new HashSet<Companyfeatures>();
            Companyflagcache = new HashSet<Companyflagcache>();
            Companygenres = new HashSet<Companygenres>();
            Companymemberexportjob = new HashSet<Companymemberexportjob>();
            Companymovierate = new HashSet<Companymovierate>();
            Companyreportrecipient = new HashSet<Companyreportrecipient>();
            Companyshopsalerate = new HashSet<Companyshopsalerate>();
            Companyticketingfeerate = new HashSet<Companyticketingfeerate>();
            Content = new HashSet<Content>();
            Crmreportrecipient = new HashSet<Crmreportrecipient>();
            Css = new HashSet<Css>();
            Email = new HashSet<Email>();
            Emailgroup = new HashSet<Emailgroup>();
            Emailsubjecttemplate = new HashSet<Emailsubjecttemplate>();
            Faqcategory = new HashSet<Faqcategory>();
            Filter = new HashSet<Filter>();
            Flag = new HashSet<Flag>();
            Flyerimage = new HashSet<Flyerimage>();
            Form = new HashSet<Form>();
            Fullimagebackground = new HashSet<Fullimagebackground>();
            Helpdeskticket = new HashSet<Helpdeskticket>();
            Ktixposterminal = new HashSet<Ktixposterminal>();
            Ktixsetting = new HashSet<Ktixsetting>();
            Label = new HashSet<Label>();
            Maininteractiveimage = new HashSet<Maininteractiveimage>();
            Memberexitpoll = new HashSet<Memberexitpoll>();
            Membertype = new HashSet<Membertype>();
            Mobilealert = new HashSet<Mobilealert>();
            Movie = new HashSet<Movie>();
            Movieaward = new HashSet<Movieaward>();
            Movieawardcompanies = new HashSet<Movieawardcompanies>();
            Moviecategory = new HashSet<Moviecategory>();
            Moviecomment = new HashSet<Moviecomment>();
            Moviereview = new HashSet<Moviereview>();
            Moviereviewcompanies = new HashSet<Moviereviewcompanies>();
            Movietype = new HashSet<Movietype>();
            Offer = new HashSet<Offer>();
            Paymentgatewaytransaction = new HashSet<Paymentgatewaytransaction>();
            Popup = new HashSet<Popup>();
            Promotion = new HashSet<Promotion>();
            Promotionalofferlocation = new HashSet<Promotionalofferlocation>();
            Promotionaloffersimage = new HashSet<Promotionaloffersimage>();
            Promotioncategory = new HashSet<Promotioncategory>();
            Quote = new HashSet<Quote>();
            Shop = new HashSet<Shop>();
            Signcontent = new HashSet<Signcontent>();
            Site = new HashSet<Site>();
            Smslog = new HashSet<Smslog>();
            Specialsessiontype = new HashSet<Specialsessiontype>();
            Transactionlog = new HashSet<Transactionlog>();
            Venuemastercrmconfig = new HashSet<Venuemastercrmconfig>();
        }

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public short CountryId { get; set; }
        public string CompanyNumber { get; set; }
        public string NameForDisplay { get; set; }
        public string AdministrationEmail { get; set; }
        public string BillingNameOfStaff { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingState { get; set; }
        public string BillingPhone { get; set; }
        public string BillingEmail { get; set; }
        public bool IsActive { get; set; }
        public bool? IsBillingActive { get; set; }
        public bool IsDeleted { get; set; }
        public short AdditionalCinemaAdjustmentPercentage { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int CountryStateId { get; set; }
        public short DayId { get; set; }
        public string TimeZoneLocationId { get; set; }
        public bool? IsUpdateReleaseDateDefault { get; set; }
        public bool? IsUpdateLabelsDefault { get; set; }
        public bool? IsUpdatePointOfSaleTitleDefault { get; set; }
        public string SaasuContactUid { get; set; }
        public int PaymentTerms { get; set; }
        public bool IsMemberPurchaseHistoryAvailable { get; set; }
        public string SmssenderName { get; set; }
        public DateTime InitialFreePeriodEndDate { get; set; }
        public decimal SmsratePerMessageBilledToCompany { get; set; }
        public string MessageGearsAccountId { get; set; }
        public string MessageGearsApikey { get; set; }
        public bool IsSendUsingMessageGears { get; set; }
        public bool IsShowOverdueWarning { get; set; }
        public bool IsRestrictedAccess { get; set; }
        public bool IsApplyTestCode { get; set; }
        public DateTime FlagCacheExpiryDateTime { get; set; }
        public int? PurgeDeletedMembersAfterHowManyDays { get; set; }
        public int? BulkSmscreditLimit { get; set; }

        public Country Country { get; set; }
        public Countrystate CountryState { get; set; }
        public Day Day { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<Advertisementcampaign> Advertisementcampaign { get; set; }
        public ICollection<Advertisementclient> Advertisementclient { get; set; }
        public ICollection<Blogpost> Blogpost { get; set; }
        public ICollection<Bulksms> Bulksms { get; set; }
        public ICollection<Carousel> Carousel { get; set; }
        public ICollection<Cinema> Cinema { get; set; }
        public ICollection<Cinemagroup> Cinemagroup { get; set; }
        public ICollection<Cmsuser> Cmsuser { get; set; }
        public ICollection<Companyautopost> Companyautopost { get; set; }
        public ICollection<Companybackgroundrate> Companybackgroundrate { get; set; }
        public ICollection<Companybannerrate> Companybannerrate { get; set; }
        public ICollection<Companycontactemail> Companycontactemail { get; set; }
        public ICollection<Companycreditcardtypes> Companycreditcardtypes { get; set; }
        public ICollection<Companydefaults> Companydefaults { get; set; }
        public ICollection<Companyemailrate> Companyemailrate { get; set; }
        public ICollection<Companyemailsubjecttemplate> Companyemailsubjecttemplate { get; set; }
        public ICollection<Companyfeatures> Companyfeatures { get; set; }
        public ICollection<Companyflagcache> Companyflagcache { get; set; }
        public ICollection<Companygenres> Companygenres { get; set; }
        public ICollection<Companymemberexportjob> Companymemberexportjob { get; set; }
        public ICollection<Companymovierate> Companymovierate { get; set; }
        public ICollection<Companyreportrecipient> Companyreportrecipient { get; set; }
        public ICollection<Companyshopsalerate> Companyshopsalerate { get; set; }
        public ICollection<Companyticketingfeerate> Companyticketingfeerate { get; set; }
        public ICollection<Content> Content { get; set; }
        public ICollection<Crmreportrecipient> Crmreportrecipient { get; set; }
        public ICollection<Css> Css { get; set; }
        public ICollection<Email> Email { get; set; }
        public ICollection<Emailgroup> Emailgroup { get; set; }
        public ICollection<Emailsubjecttemplate> Emailsubjecttemplate { get; set; }
        public ICollection<Faqcategory> Faqcategory { get; set; }
        public ICollection<Filter> Filter { get; set; }
        public ICollection<Flag> Flag { get; set; }
        public ICollection<Flyerimage> Flyerimage { get; set; }
        public ICollection<Form> Form { get; set; }
        public ICollection<Fullimagebackground> Fullimagebackground { get; set; }
        public ICollection<Helpdeskticket> Helpdeskticket { get; set; }
        public ICollection<Ktixposterminal> Ktixposterminal { get; set; }
        public ICollection<Ktixsetting> Ktixsetting { get; set; }
        public ICollection<Label> Label { get; set; }
        public ICollection<Maininteractiveimage> Maininteractiveimage { get; set; }
        public ICollection<Memberexitpoll> Memberexitpoll { get; set; }
        public ICollection<Membertype> Membertype { get; set; }
        public ICollection<Mobilealert> Mobilealert { get; set; }
        public ICollection<Movie> Movie { get; set; }
        public ICollection<Movieaward> Movieaward { get; set; }
        public ICollection<Movieawardcompanies> Movieawardcompanies { get; set; }
        public ICollection<Moviecategory> Moviecategory { get; set; }
        public ICollection<Moviecomment> Moviecomment { get; set; }
        public ICollection<Moviereview> Moviereview { get; set; }
        public ICollection<Moviereviewcompanies> Moviereviewcompanies { get; set; }
        public ICollection<Movietype> Movietype { get; set; }
        public ICollection<Offer> Offer { get; set; }
        public ICollection<Paymentgatewaytransaction> Paymentgatewaytransaction { get; set; }
        public ICollection<Popup> Popup { get; set; }
        public ICollection<Promotion> Promotion { get; set; }
        public ICollection<Promotionalofferlocation> Promotionalofferlocation { get; set; }
        public ICollection<Promotionaloffersimage> Promotionaloffersimage { get; set; }
        public ICollection<Promotioncategory> Promotioncategory { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<Shop> Shop { get; set; }
        public ICollection<Signcontent> Signcontent { get; set; }
        public ICollection<Site> Site { get; set; }
        public ICollection<Smslog> Smslog { get; set; }
        public ICollection<Specialsessiontype> Specialsessiontype { get; set; }
        public ICollection<Transactionlog> Transactionlog { get; set; }
        public ICollection<Venuemastercrmconfig> Venuemastercrmconfig { get; set; }
    }
}
