using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Cinema
    {
        public Cinema()
        {
            Advertisementcinemas = new HashSet<Advertisementcinemas>();
            Alert = new HashSet<Alert>();
            Blogpostcinemas = new HashSet<Blogpostcinemas>();
            Bulksms = new HashSet<Bulksms>();
            Bulksmscinema = new HashSet<Bulksmscinema>();
            Cinemafullimagebackground = new HashSet<Cinemafullimagebackground>();
            Cinemagroupcinemas = new HashSet<Cinemagroupcinemas>();
            Cinemahaxlenconfig = new HashSet<Cinemahaxlenconfig>();
            Cinemamoviecache = new HashSet<Cinemamoviecache>();
            Cinemapaymentgateway = new HashSet<Cinemapaymentgateway>();
            Cinemasessioncache = new HashSet<Cinemasessioncache>();
            Cinemasessiondisplay = new HashSet<Cinemasessiondisplay>();
            Cinemasessionfilter = new HashSet<Cinemasessionfilter>();
            Cinemaveeziconfig = new HashSet<Cinemaveeziconfig>();
            Cinemavenuemasterconfig = new HashSet<Cinemavenuemasterconfig>();
            Cinemavistaconfig = new HashSet<Cinemavistaconfig>();
            Cinemaweeklyemailsetting = new HashSet<Cinemaweeklyemailsetting>();
            Cmsusercinemas = new HashSet<Cmsusercinemas>();
            Companyautopostcinema = new HashSet<Companyautopostcinema>();
            Competitioncinemas = new HashSet<Competitioncinemas>();
            Crmreportrecipientcinemas = new HashSet<Crmreportrecipientcinemas>();
            Email = new HashSet<Email>();
            Emailcinemas = new HashSet<Emailcinemas>();
            Emailtemplatetype = new HashSet<Emailtemplatetype>();
            Faqcinemas = new HashSet<Faqcinemas>();
            Filtercinemas = new HashSet<Filtercinemas>();
            Flyer = new HashSet<Flyer>();
            Flyerimagecinemas = new HashSet<Flyerimagecinemas>();
            Formcinema = new HashSet<Formcinema>();
            Haxlenticketingbooking = new HashSet<Haxlenticketingbooking>();
            Haxlenticketingsetting = new HashSet<Haxlenticketingsetting>();
            Includeelementinstancecinemas = new HashSet<Includeelementinstancecinemas>();
            Ktixbooking = new HashSet<Ktixbooking>();
            Ktixposterminal = new HashSet<Ktixposterminal>();
            Member = new HashSet<Member>();
            Membercinemas = new HashSet<Membercinemas>();
            Membercrmaction = new HashSet<Membercrmaction>();
            Mobilealertcinemas = new HashSet<Mobilealertcinemas>();
            Movieinstancecinemas = new HashSet<Movieinstancecinemas>();
            Offercinemas = new HashSet<Offercinemas>();
            Pagemenupagecinemas = new HashSet<Pagemenupagecinemas>();
            Pageredirect = new HashSet<Pageredirect>();
            Pageregioncinemas = new HashSet<Pageregioncinemas>();
            Popupcinema = new HashSet<Popupcinema>();
            Promotioncinemas = new HashSet<Promotioncinemas>();
            Retrieverticketingbooking = new HashSet<Retrieverticketingbooking>();
            Retrieverticketingsetting = new HashSet<Retrieverticketingsetting>();
            Retrieverticketingticketsetting = new HashSet<Retrieverticketingticketsetting>();
            Retrieverticketingticketsettingcheckbox = new HashSet<Retrieverticketingticketsettingcheckbox>();
            Screen = new HashSet<Screen>();
            Screenfeature = new HashSet<Screenfeature>();
            Screentype = new HashSet<Screentype>();
            Session = new HashSet<Session>();
            Sessioncreationrule = new HashSet<Sessioncreationrule>();
            Sessionimportattempt = new HashSet<Sessionimportattempt>();
            Shopcinema = new HashSet<Shopcinema>();
            Shopnotificationcinemas = new HashSet<Shopnotificationcinemas>();
            Shoporder = new HashSet<Shoporder>();
            Shopproductvariationpricecinemas = new HashSet<Shopproductvariationpricecinemas>();
            Sidebarelementcinemas = new HashSet<Sidebarelementcinemas>();
            Sign = new HashSet<Sign>();
            Sitehomepagetabcinemas = new HashSet<Sitehomepagetabcinemas>();
            Specialsession = new HashSet<Specialsession>();
            Venuemasterticketingbooking = new HashSet<Venuemasterticketingbooking>();
            Venuemasterticketingsetting = new HashSet<Venuemasterticketingsetting>();
            Venuemasterticketingticketsetting = new HashSet<Venuemasterticketingticketsetting>();
            Venuemasterticketingticketsettingcheckbox = new HashSet<Venuemasterticketingticketsettingcheckbox>();
        }

        public Guid CinemaId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string BookingPhone { get; set; }
        public string WebsiteUrl { get; set; }
        public string PointOfSaleId { get; set; }
        public bool IsOnlineTicketing { get; set; }
        public string SessionImportEmail { get; set; }
        public string AdministrationEmail { get; set; }
        public string TimeZoneLocationId { get; set; }
        public bool IsDeleted { get; set; }
        public short PointOfSaleTypeId { get; set; }
        public short InternetTicketingTypeId { get; set; }
        public int CountryStateId { get; set; }
        public bool IsIgnoreScreenErrorsOnImport { get; set; }
        public string LoyaltyPointOfSaleId { get; set; }
        public int SessionNumberOfDaysLimit { get; set; }
        public short? SessionRestrictUntilTimeId { get; set; }
        public short CrmtypeId { get; set; }
        public bool? IsImportSessionsAutomatically { get; set; }
        public string ShortName { get; set; }
        public int NowShowingQueryMethodId { get; set; }
        public DateTime NowShowingCacheExpiryDateTime { get; set; }
        public string FacebookPageUrl { get; set; }
        public string TwitterPageUrl { get; set; }
        public string AppStoreUrl { get; set; }
        public string GooglePlayUrl { get; set; }
        public string MovieTimesComAuUserName { get; set; }
        public string MovieTimesComAuPassword { get; set; }
        public string MovieTimesComAuCinemaName { get; set; }
        public string MobileAppDescription { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string InstagramPageUrl { get; set; }
        public Guid? MemberTypeId { get; set; }
        public bool AllowMultipleSeatsPerTickets { get; set; }
        public bool AllowReDshieldFraudProtection { get; set; }

        public Company Company { get; set; }
        public Countrystate CountryState { get; set; }
        public Crmtype Crmtype { get; set; }
        public Internetticketingtype InternetTicketingType { get; set; }
        public Membertype MemberType { get; set; }
        public Nowshowingquerymethod NowShowingQueryMethod { get; set; }
        public Pointofsaletype PointOfSaleType { get; set; }
        public Time SessionRestrictUntilTime { get; set; }
        public ICollection<Advertisementcinemas> Advertisementcinemas { get; set; }
        public ICollection<Alert> Alert { get; set; }
        public ICollection<Blogpostcinemas> Blogpostcinemas { get; set; }
        public ICollection<Bulksms> Bulksms { get; set; }
        public ICollection<Bulksmscinema> Bulksmscinema { get; set; }
        public ICollection<Cinemafullimagebackground> Cinemafullimagebackground { get; set; }
        public ICollection<Cinemagroupcinemas> Cinemagroupcinemas { get; set; }
        public ICollection<Cinemahaxlenconfig> Cinemahaxlenconfig { get; set; }
        public ICollection<Cinemamoviecache> Cinemamoviecache { get; set; }
        public ICollection<Cinemapaymentgateway> Cinemapaymentgateway { get; set; }
        public ICollection<Cinemasessioncache> Cinemasessioncache { get; set; }
        public ICollection<Cinemasessiondisplay> Cinemasessiondisplay { get; set; }
        public ICollection<Cinemasessionfilter> Cinemasessionfilter { get; set; }
        public ICollection<Cinemaveeziconfig> Cinemaveeziconfig { get; set; }
        public ICollection<Cinemavenuemasterconfig> Cinemavenuemasterconfig { get; set; }
        public ICollection<Cinemavistaconfig> Cinemavistaconfig { get; set; }
        public ICollection<Cinemaweeklyemailsetting> Cinemaweeklyemailsetting { get; set; }
        public ICollection<Cmsusercinemas> Cmsusercinemas { get; set; }
        public ICollection<Companyautopostcinema> Companyautopostcinema { get; set; }
        public ICollection<Competitioncinemas> Competitioncinemas { get; set; }
        public ICollection<Crmreportrecipientcinemas> Crmreportrecipientcinemas { get; set; }
        public ICollection<Email> Email { get; set; }
        public ICollection<Emailcinemas> Emailcinemas { get; set; }
        public ICollection<Emailtemplatetype> Emailtemplatetype { get; set; }
        public ICollection<Faqcinemas> Faqcinemas { get; set; }
        public ICollection<Filtercinemas> Filtercinemas { get; set; }
        public ICollection<Flyer> Flyer { get; set; }
        public ICollection<Flyerimagecinemas> Flyerimagecinemas { get; set; }
        public ICollection<Formcinema> Formcinema { get; set; }
        public ICollection<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public ICollection<Haxlenticketingsetting> Haxlenticketingsetting { get; set; }
        public ICollection<Includeelementinstancecinemas> Includeelementinstancecinemas { get; set; }
        public ICollection<Ktixbooking> Ktixbooking { get; set; }
        public ICollection<Ktixposterminal> Ktixposterminal { get; set; }
        public ICollection<Member> Member { get; set; }
        public ICollection<Membercinemas> Membercinemas { get; set; }
        public ICollection<Membercrmaction> Membercrmaction { get; set; }
        public ICollection<Mobilealertcinemas> Mobilealertcinemas { get; set; }
        public ICollection<Movieinstancecinemas> Movieinstancecinemas { get; set; }
        public ICollection<Offercinemas> Offercinemas { get; set; }
        public ICollection<Pagemenupagecinemas> Pagemenupagecinemas { get; set; }
        public ICollection<Pageredirect> Pageredirect { get; set; }
        public ICollection<Pageregioncinemas> Pageregioncinemas { get; set; }
        public ICollection<Popupcinema> Popupcinema { get; set; }
        public ICollection<Promotioncinemas> Promotioncinemas { get; set; }
        public ICollection<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public ICollection<Retrieverticketingsetting> Retrieverticketingsetting { get; set; }
        public ICollection<Retrieverticketingticketsetting> Retrieverticketingticketsetting { get; set; }
        public ICollection<Retrieverticketingticketsettingcheckbox> Retrieverticketingticketsettingcheckbox { get; set; }
        public ICollection<Screen> Screen { get; set; }
        public ICollection<Screenfeature> Screenfeature { get; set; }
        public ICollection<Screentype> Screentype { get; set; }
        public ICollection<Session> Session { get; set; }
        public ICollection<Sessioncreationrule> Sessioncreationrule { get; set; }
        public ICollection<Sessionimportattempt> Sessionimportattempt { get; set; }
        public ICollection<Shopcinema> Shopcinema { get; set; }
        public ICollection<Shopnotificationcinemas> Shopnotificationcinemas { get; set; }
        public ICollection<Shoporder> Shoporder { get; set; }
        public ICollection<Shopproductvariationpricecinemas> Shopproductvariationpricecinemas { get; set; }
        public ICollection<Sidebarelementcinemas> Sidebarelementcinemas { get; set; }
        public ICollection<Sign> Sign { get; set; }
        public ICollection<Sitehomepagetabcinemas> Sitehomepagetabcinemas { get; set; }
        public ICollection<Specialsession> Specialsession { get; set; }
        public ICollection<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
        public ICollection<Venuemasterticketingsetting> Venuemasterticketingsetting { get; set; }
        public ICollection<Venuemasterticketingticketsetting> Venuemasterticketingticketsetting { get; set; }
        public ICollection<Venuemasterticketingticketsettingcheckbox> Venuemasterticketingticketsettingcheckbox { get; set; }
    }
}
