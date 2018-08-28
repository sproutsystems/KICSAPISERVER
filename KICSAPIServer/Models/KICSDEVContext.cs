using KICSAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KICSAPIServer.Models
{
    public partial class KICSDEVContext : DbContext
    {
        public KICSDEVContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Advertisementadvertisementlocations> Advertisementadvertisementlocations { get; set; }
        public virtual DbSet<Advertisementcampaign> Advertisementcampaign { get; set; }
        public virtual DbSet<Advertisementcinemas> Advertisementcinemas { get; set; }
        public virtual DbSet<Advertisementclient> Advertisementclient { get; set; }
        public virtual DbSet<Advertisementdays> Advertisementdays { get; set; }
        public virtual DbSet<Advertisementlocation> Advertisementlocation { get; set; }
        public virtual DbSet<Advertisementlocationcinemagroup> Advertisementlocationcinemagroup { get; set; }
        public virtual DbSet<Advertisementlocationplaylistschedule> Advertisementlocationplaylistschedule { get; set; }
        public virtual DbSet<Advertisementlocationtype> Advertisementlocationtype { get; set; }
        public virtual DbSet<Advertisementplaylist> Advertisementplaylist { get; set; }
        public virtual DbSet<Advertisementplaylistadvertisements> Advertisementplaylistadvertisements { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<Alerttype> Alerttype { get; set; }
        public virtual DbSet<AppPushNoticificationUser> AppPushNoticificationUser { get; set; }
        public virtual DbSet<AppPushNotificationStatistics> AppPushNotificationStatistics { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Autopost> Autopost { get; set; }
        public virtual DbSet<Autopostdestination> Autopostdestination { get; set; }
        public virtual DbSet<Autoposttype> Autoposttype { get; set; }
        public virtual DbSet<Autoposttypetemplate> Autoposttypetemplate { get; set; }
        public virtual DbSet<Blogpost> Blogpost { get; set; }
        public virtual DbSet<Blogpostcinemas> Blogpostcinemas { get; set; }
        public virtual DbSet<Blogpostcomment> Blogpostcomment { get; set; }
        public virtual DbSet<Blogpostmembertypes> Blogpostmembertypes { get; set; }
        public virtual DbSet<Blogpostsection> Blogpostsection { get; set; }
        public virtual DbSet<Bounce> Bounce { get; set; }
        public virtual DbSet<Bulksms> Bulksms { get; set; }
        public virtual DbSet<Bulksmscinema> Bulksmscinema { get; set; }
        public virtual DbSet<Bulksmsmembertype> Bulksmsmembertype { get; set; }
        public virtual DbSet<Bulksmsrecipient> Bulksmsrecipient { get; set; }
        public virtual DbSet<Carousel> Carousel { get; set; }
        public virtual DbSet<Carouselcontent> Carouselcontent { get; set; }
        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Cinemafullimagebackground> Cinemafullimagebackground { get; set; }
        public virtual DbSet<Cinemagroup> Cinemagroup { get; set; }
        public virtual DbSet<Cinemagroupcinemas> Cinemagroupcinemas { get; set; }
        public virtual DbSet<Cinemahaxlenconfig> Cinemahaxlenconfig { get; set; }
        public virtual DbSet<Cinemamoviecache> Cinemamoviecache { get; set; }
        public virtual DbSet<Cinemapaymentgateway> Cinemapaymentgateway { get; set; }
        public virtual DbSet<Cinemaretrieverconfig> Cinemaretrieverconfig { get; set; }
        public virtual DbSet<Cinemasessioncache> Cinemasessioncache { get; set; }
        public virtual DbSet<Cinemasessiondisplay> Cinemasessiondisplay { get; set; }
        public virtual DbSet<Cinemasessiondisplaymoviecategories> Cinemasessiondisplaymoviecategories { get; set; }
        public virtual DbSet<Cinemasessiondisplaymovietypes> Cinemasessiondisplaymovietypes { get; set; }
        public virtual DbSet<Cinemasessionfilter> Cinemasessionfilter { get; set; }
        public virtual DbSet<Cinemasessionfilterbutton> Cinemasessionfilterbutton { get; set; }
        public virtual DbSet<Cinemasessionfilterbuttonflags> Cinemasessionfilterbuttonflags { get; set; }
        public virtual DbSet<Cinemasessionfilterbuttonmoviecategory> Cinemasessionfilterbuttonmoviecategory { get; set; }
        public virtual DbSet<Cinemasessionfilterbuttonmovietype> Cinemasessionfilterbuttonmovietype { get; set; }
        public virtual DbSet<Cinemaveeziconfig> Cinemaveeziconfig { get; set; }
        public virtual DbSet<Cinemavenuemasterconfig> Cinemavenuemasterconfig { get; set; }
        public virtual DbSet<Cinemavistaconfig> Cinemavistaconfig { get; set; }
        public virtual DbSet<Cinemaweeklyemailsetting> Cinemaweeklyemailsetting { get; set; }
        public virtual DbSet<Cmslogintoken> Cmslogintoken { get; set; }
        public virtual DbSet<Cmsnews> Cmsnews { get; set; }
        public virtual DbSet<Cmsnewscmsusers> Cmsnewscmsusers { get; set; }
        public virtual DbSet<Cmsnewscmsusersnew> Cmsnewscmsusersnew { get; set; }
        public virtual DbSet<Cmsuser> Cmsuser { get; set; }
        public virtual DbSet<Cmsuseralerttypes> Cmsuseralerttypes { get; set; }
        public virtual DbSet<Cmsusercinemas> Cmsusercinemas { get; set; }
        public virtual DbSet<Cmsusersites> Cmsusersites { get; set; }
        public virtual DbSet<Cmsusertype> Cmsusertype { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Companyautopost> Companyautopost { get; set; }
        public virtual DbSet<Companyautopostcinema> Companyautopostcinema { get; set; }
        public virtual DbSet<Companyautoposttypetemplates> Companyautoposttypetemplates { get; set; }
        public virtual DbSet<Companybackgroundrate> Companybackgroundrate { get; set; }
        public virtual DbSet<Companybannerrate> Companybannerrate { get; set; }
        public virtual DbSet<Companycontactemail> Companycontactemail { get; set; }
        public virtual DbSet<Companycreditcardtypes> Companycreditcardtypes { get; set; }
        public virtual DbSet<Companydefaults> Companydefaults { get; set; }
        public virtual DbSet<Companyemailrate> Companyemailrate { get; set; }
        public virtual DbSet<Companyemailsubjecttemplate> Companyemailsubjecttemplate { get; set; }
        public virtual DbSet<Companyfeatures> Companyfeatures { get; set; }
        public virtual DbSet<Companyflagcache> Companyflagcache { get; set; }
        public virtual DbSet<Companygenres> Companygenres { get; set; }
        public virtual DbSet<Companymemberexportjob> Companymemberexportjob { get; set; }
        public virtual DbSet<Companymovierate> Companymovierate { get; set; }
        public virtual DbSet<Companyreportrecipient> Companyreportrecipient { get; set; }
        public virtual DbSet<Companyshopsalerate> Companyshopsalerate { get; set; }
        public virtual DbSet<Companyticketingfeerate> Companyticketingfeerate { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Competitioncinemas> Competitioncinemas { get; set; }
        public virtual DbSet<Competitionentry> Competitionentry { get; set; }
        public virtual DbSet<Competitionentryanswers> Competitionentryanswers { get; set; }
        public virtual DbSet<Competitionmembertypes> Competitionmembertypes { get; set; }
        public virtual DbSet<Competitionprize> Competitionprize { get; set; }
        public virtual DbSet<Competitionquestion> Competitionquestion { get; set; }
        public virtual DbSet<Competitionquestionoptions> Competitionquestionoptions { get; set; }
        public virtual DbSet<Competitionwinner> Competitionwinner { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Contentformat> Contentformat { get; set; }
        public virtual DbSet<Contenttype> Contenttype { get; set; }
        public virtual DbSet<Contenttypeformats> Contenttypeformats { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Countrystate> Countrystate { get; set; }
        public virtual DbSet<Crmreportrecipient> Crmreportrecipient { get; set; }
        public virtual DbSet<Crmreportrecipientcinemas> Crmreportrecipientcinemas { get; set; }
        public virtual DbSet<Crmtype> Crmtype { get; set; }
        public virtual DbSet<Cronjob> Cronjob { get; set; }
        public virtual DbSet<Cronjoblog> Cronjoblog { get; set; }
        public virtual DbSet<Css> Css { get; set; }
        public virtual DbSet<Cssversion> Cssversion { get; set; }
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<Distributor> Distributor { get; set; }
        public virtual DbSet<Drawer> Drawer { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Emailarchive> Emailarchive { get; set; }
        public virtual DbSet<Emailcinemas> Emailcinemas { get; set; }
        public virtual DbSet<Emailelement> Emailelement { get; set; }
        public virtual DbSet<Emailemailgroups> Emailemailgroups { get; set; }
        public virtual DbSet<Emailgeneralsettings> Emailgeneralsettings { get; set; }
        public virtual DbSet<Emailgroup> Emailgroup { get; set; }
        public virtual DbSet<Emaillink> Emaillink { get; set; }
        public virtual DbSet<Emailmembers> Emailmembers { get; set; }
        public virtual DbSet<Emailmembertypes> Emailmembertypes { get; set; }
        public virtual DbSet<Emailstatus> Emailstatus { get; set; }
        public virtual DbSet<Emailsubjecttemplate> Emailsubjecttemplate { get; set; }
        public virtual DbSet<Emailtemplatetype> Emailtemplatetype { get; set; }
        public virtual DbSet<Emailtemplatetypeelements> Emailtemplatetypeelements { get; set; }
        public virtual DbSet<Emailtype> Emailtype { get; set; }
        public virtual DbSet<Facebookcolorscheme> Facebookcolorscheme { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<Faqcategory> Faqcategory { get; set; }
        public virtual DbSet<Faqcinemas> Faqcinemas { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Featuredmovieelements> Featuredmovieelements { get; set; }
        public virtual DbSet<Filter> Filter { get; set; }
        public virtual DbSet<Filtercinemas> Filtercinemas { get; set; }
        public virtual DbSet<Filtercustomquestionoptions> Filtercustomquestionoptions { get; set; }
        public virtual DbSet<Filtercustomquestions> Filtercustomquestions { get; set; }
        public virtual DbSet<Filteremailgroups> Filteremailgroups { get; set; }
        public virtual DbSet<Filteremailstatus> Filteremailstatus { get; set; }
        public virtual DbSet<Filtergenders> Filtergenders { get; set; }
        public virtual DbSet<Filtergenrepreferences> Filtergenrepreferences { get; set; }
        public virtual DbSet<Filtergenrepurchases> Filtergenrepurchases { get; set; }
        public virtual DbSet<Filtermembers> Filtermembers { get; set; }
        public virtual DbSet<Filtermembertype> Filtermembertype { get; set; }
        public virtual DbSet<Filtermoviecategorypurchases> Filtermoviecategorypurchases { get; set; }
        public virtual DbSet<Filtermovienotpurchases> Filtermovienotpurchases { get; set; }
        public virtual DbSet<Filtermoviepurchases> Filtermoviepurchases { get; set; }
        public virtual DbSet<Filtermovietypepurchases> Filtermovietypepurchases { get; set; }
        public virtual DbSet<Flag> Flag { get; set; }
        public virtual DbSet<Flyer> Flyer { get; set; }
        public virtual DbSet<Flyerimage> Flyerimage { get; set; }
        public virtual DbSet<Flyerimagecinemas> Flyerimagecinemas { get; set; }
        public virtual DbSet<Flyermovieinstances> Flyermovieinstances { get; set; }
        public virtual DbSet<Flyerpageorientation> Flyerpageorientation { get; set; }
        public virtual DbSet<Flyerpromotions> Flyerpromotions { get; set; }
        public virtual DbSet<Flyertype> Flyertype { get; set; }
        public virtual DbSet<Flyertypeimageposition> Flyertypeimageposition { get; set; }
        public virtual DbSet<Footer> Footer { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<Formcinema> Formcinema { get; set; }
        public virtual DbSet<Formfield> Formfield { get; set; }
        public virtual DbSet<Formfieldoption> Formfieldoption { get; set; }
        public virtual DbSet<Formfieldtype> Formfieldtype { get; set; }
        public virtual DbSet<Fullimagebackground> Fullimagebackground { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GenericLogs> GenericLogs { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Globalcss> Globalcss { get; set; }
        public virtual DbSet<Globalcssversion> Globalcssversion { get; set; }
        public virtual DbSet<Haxlenticketbookingvifprl> Haxlenticketbookingvifprl { get; set; }
        public virtual DbSet<Haxlenticketbookingviftkt> Haxlenticketbookingviftkt { get; set; }
        public virtual DbSet<Haxlenticketingblacklist> Haxlenticketingblacklist { get; set; }
        public virtual DbSet<Haxlenticketingbooking> Haxlenticketingbooking { get; set; }
        public virtual DbSet<Haxlenticketingbookinglog> Haxlenticketingbookinglog { get; set; }
        public virtual DbSet<Haxlenticketingbookingreceipt> Haxlenticketingbookingreceipt { get; set; }
        public virtual DbSet<Haxlenticketingbookingtickets> Haxlenticketingbookingtickets { get; set; }
        public virtual DbSet<Haxlenticketingcreditcardfailurelog> Haxlenticketingcreditcardfailurelog { get; set; }
        public virtual DbSet<Haxlenticketingsetting> Haxlenticketingsetting { get; set; }
        public virtual DbSet<Haxlenticketingsettingseattype> Haxlenticketingsettingseattype { get; set; }
        public virtual DbSet<Haxlenticketingticketsetting> Haxlenticketingticketsetting { get; set; }
        public virtual DbSet<Haxlenticketingticketsettingcheckbox> Haxlenticketingticketsettingcheckbox { get; set; }
        public virtual DbSet<Haxlenticketingticketsettingmembertypes> Haxlenticketingticketsettingmembertypes { get; set; }
        public virtual DbSet<Haxlenticketingtickettype> Haxlenticketingtickettype { get; set; }
        public virtual DbSet<Helpdeskcategory> Helpdeskcategory { get; set; }
        public virtual DbSet<Helpdeskcategoryroles> Helpdeskcategoryroles { get; set; }
        public virtual DbSet<Helpdeskmessage> Helpdeskmessage { get; set; }
        public virtual DbSet<Helpdeskstandardresponse> Helpdeskstandardresponse { get; set; }
        public virtual DbSet<Helpdeskticket> Helpdeskticket { get; set; }
        public virtual DbSet<Helpdeskticketstatus> Helpdeskticketstatus { get; set; }
        public virtual DbSet<Htmltemplate> Htmltemplate { get; set; }
        public virtual DbSet<Includeelement> Includeelement { get; set; }
        public virtual DbSet<Includeelementinstance> Includeelementinstance { get; set; }
        public virtual DbSet<Includeelementinstancecinemas> Includeelementinstancecinemas { get; set; }
        public virtual DbSet<Includeelementinstancemembertypes> Includeelementinstancemembertypes { get; set; }
        public virtual DbSet<Includeelementinstanceversion> Includeelementinstanceversion { get; set; }
        public virtual DbSet<Includeelementsites> Includeelementsites { get; set; }
        public virtual DbSet<Includeelementtype> Includeelementtype { get; set; }
        public virtual DbSet<Informationsite> Informationsite { get; set; }
        public virtual DbSet<Internetticketingtype> Internetticketingtype { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Ktixbooking> Ktixbooking { get; set; }
        public virtual DbSet<Ktixbookingcomboitems> Ktixbookingcomboitems { get; set; }
        public virtual DbSet<Ktixbookinglog> Ktixbookinglog { get; set; }
        public virtual DbSet<Ktixbookingsaleitems> Ktixbookingsaleitems { get; set; }
        public virtual DbSet<Ktixbookingvouchers> Ktixbookingvouchers { get; set; }
        public virtual DbSet<Ktixcomboitem> Ktixcomboitem { get; set; }
        public virtual DbSet<Ktixcomboitemsaleitems> Ktixcomboitemsaleitems { get; set; }
        public virtual DbSet<Ktixgiftcard> Ktixgiftcard { get; set; }
        public virtual DbSet<Ktixgiftcardstate> Ktixgiftcardstate { get; set; }
        public virtual DbSet<Ktixitemgroup> Ktixitemgroup { get; set; }
        public virtual DbSet<Ktixkioskcategory> Ktixkioskcategory { get; set; }
        public virtual DbSet<Ktixkioskorder> Ktixkioskorder { get; set; }
        public virtual DbSet<Ktixkioskordersaleitem> Ktixkioskordersaleitem { get; set; }
        public virtual DbSet<Ktixkiosksaleitem> Ktixkiosksaleitem { get; set; }
        public virtual DbSet<Ktixmasterpaymenttype> Ktixmasterpaymenttype { get; set; }
        public virtual DbSet<Ktixmastertransaction> Ktixmastertransaction { get; set; }
        public virtual DbSet<Ktixpaymenttype> Ktixpaymenttype { get; set; }
        public virtual DbSet<Ktixposterminal> Ktixposterminal { get; set; }
        public virtual DbSet<Ktixposusetype> Ktixposusetype { get; set; }
        public virtual DbSet<Ktixpricegroup> Ktixpricegroup { get; set; }
        public virtual DbSet<Ktixpricegroupcomboitems> Ktixpricegroupcomboitems { get; set; }
        public virtual DbSet<Ktixpricegroupsaleitems> Ktixpricegroupsaleitems { get; set; }
        public virtual DbSet<Ktixpricegroupvouchertypes> Ktixpricegroupvouchertypes { get; set; }
        public virtual DbSet<Ktixsaleitem> Ktixsaleitem { get; set; }
        public virtual DbSet<Ktixsession> Ktixsession { get; set; }
        public virtual DbSet<Ktixsessionsaleitemoverride> Ktixsessionsaleitemoverride { get; set; }
        public virtual DbSet<Ktixsetting> Ktixsetting { get; set; }
        public virtual DbSet<Ktixsettingcheckbox> Ktixsettingcheckbox { get; set; }
        public virtual DbSet<Ktixtransactioncart> Ktixtransactioncart { get; set; }
        public virtual DbSet<Ktixtransactioncartitems> Ktixtransactioncartitems { get; set; }
        public virtual DbSet<Ktixvoucher> Ktixvoucher { get; set; }
        public virtual DbSet<Ktixvouchertype> Ktixvouchertype { get; set; }
        public virtual DbSet<Ktixvouchertypeitems> Ktixvouchertypeitems { get; set; }
        public virtual DbSet<Label> Label { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Languagefilter> Languagefilter { get; set; }
        public virtual DbSet<Loginmethod> Loginmethod { get; set; }
        public virtual DbSet<Maininteractiveautotype> Maininteractiveautotype { get; set; }
        public virtual DbSet<Maininteractiveelement> Maininteractiveelement { get; set; }
        public virtual DbSet<Maininteractiveelementtype> Maininteractiveelementtype { get; set; }
        public virtual DbSet<Maininteractiveimage> Maininteractiveimage { get; set; }
        public virtual DbSet<Maininteractivetype> Maininteractivetype { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Memberbounce> Memberbounce { get; set; }
        public virtual DbSet<Membercinemas> Membercinemas { get; set; }
        public virtual DbSet<Membercrmaction> Membercrmaction { get; set; }
        public virtual DbSet<Membercrmactiontype> Membercrmactiontype { get; set; }
        public virtual DbSet<Membercustomansweroptions> Membercustomansweroptions { get; set; }
        public virtual DbSet<Membercustomanswers> Membercustomanswers { get; set; }
        public virtual DbSet<Memberdetailchangelog> Memberdetailchangelog { get; set; }
        public virtual DbSet<Memberemailgroups> Memberemailgroups { get; set; }
        public virtual DbSet<Memberexitpoll> Memberexitpoll { get; set; }
        public virtual DbSet<Membergenres> Membergenres { get; set; }
        public virtual DbSet<Memberimport> Memberimport { get; set; }
        public virtual DbSet<Membermoviecategorypurchaselog> Membermoviecategorypurchaselog { get; set; }
        public virtual DbSet<Membermoviegenrepurchaselog> Membermoviegenrepurchaselog { get; set; }
        public virtual DbSet<Membermoviepurchaseimport> Membermoviepurchaseimport { get; set; }
        public virtual DbSet<Membermoviepurchaselog> Membermoviepurchaselog { get; set; }
        public virtual DbSet<Membermovietypepurchaselog> Membermovietypepurchaselog { get; set; }
        public virtual DbSet<Membermovieviewlog> Membermovieviewlog { get; set; }
        public virtual DbSet<Memberofferviewlog> Memberofferviewlog { get; set; }
        public virtual DbSet<Memberpointlog> Memberpointlog { get; set; }
        public virtual DbSet<Memberpolloptionlog> Memberpolloptionlog { get; set; }
        public virtual DbSet<MemberTempData> MemberTempData { get; set; }
        public virtual DbSet<Membertransaction> Membertransaction { get; set; }
        public virtual DbSet<Membertype> Membertype { get; set; }
        public virtual DbSet<Membertypecustomquestion> Membertypecustomquestion { get; set; }
        public virtual DbSet<Membertypecustomquestionoption> Membertypecustomquestionoption { get; set; }
        public virtual DbSet<Membertypecustomquestiontype> Membertypecustomquestiontype { get; set; }
        public virtual DbSet<Membertypedefaultemailgroups> Membertypedefaultemailgroups { get; set; }
        public virtual DbSet<Membertypeemail> Membertypeemail { get; set; }
        public virtual DbSet<Membertypeemailtype> Membertypeemailtype { get; set; }
        public virtual DbSet<Membertypeprice> Membertypeprice { get; set; }
        public virtual DbSet<Mobilealert> Mobilealert { get; set; }
        public virtual DbSet<Mobilealertcinemas> Mobilealertcinemas { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Movieaudience> Movieaudience { get; set; }
        public virtual DbSet<Movieaward> Movieaward { get; set; }
        public virtual DbSet<Movieawardcompanies> Movieawardcompanies { get; set; }
        public virtual DbSet<Moviebanner> Moviebanner { get; set; }
        public virtual DbSet<Moviecategory> Moviecategory { get; set; }
        public virtual DbSet<Moviecomment> Moviecomment { get; set; }
        public virtual DbSet<Moviedetail> Moviedetail { get; set; }
        public virtual DbSet<Moviegenres> Moviegenres { get; set; }
        public virtual DbSet<Movieimportancetype> Movieimportancetype { get; set; }
        public virtual DbSet<Movieinformationsite> Movieinformationsite { get; set; }
        public virtual DbSet<Movieinstance> Movieinstance { get; set; }
        public virtual DbSet<Movieinstancecinemalabels> Movieinstancecinemalabels { get; set; }
        public virtual DbSet<Movieinstancecinemas> Movieinstancecinemas { get; set; }
        public virtual DbSet<Movieinstancecontent> Movieinstancecontent { get; set; }
        public virtual DbSet<Movieinstanceflagdates> Movieinstanceflagdates { get; set; }
        public virtual DbSet<Movieinstancelabels> Movieinstancelabels { get; set; }
        public virtual DbSet<Movieinstancemoviecategories> Movieinstancemoviecategories { get; set; }
        public virtual DbSet<Moviepurchasefiltertype> Moviepurchasefiltertype { get; set; }
        public virtual DbSet<Movierating> Movierating { get; set; }
        public virtual DbSet<Moviereview> Moviereview { get; set; }
        public virtual DbSet<Moviereviewcompanies> Moviereviewcompanies { get; set; }
        public virtual DbSet<Movietype> Movietype { get; set; }
        public virtual DbSet<Movietypeelement> Movietypeelement { get; set; }
        public virtual DbSet<NameofMonth> NameofMonth { get; set; }
        public virtual DbSet<Nowshowingquerymethod> Nowshowingquerymethod { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<Offercinemas> Offercinemas { get; set; }
        public virtual DbSet<Offermembertypes> Offermembertypes { get; set; }
        public virtual DbSet<Offersites> Offersites { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Pagelinks> Pagelinks { get; set; }
        public virtual DbSet<Pagemenu> Pagemenu { get; set; }
        public virtual DbSet<Pagemenupagecinemas> Pagemenupagecinemas { get; set; }
        public virtual DbSet<Pagemenupages> Pagemenupages { get; set; }
        public virtual DbSet<Pageredirect> Pageredirect { get; set; }
        public virtual DbSet<Pageregion> Pageregion { get; set; }
        public virtual DbSet<Pageregioncinemas> Pageregioncinemas { get; set; }
        public virtual DbSet<Pageregioncontent> Pageregioncontent { get; set; }
        public virtual DbSet<Pageregionmembertypes> Pageregionmembertypes { get; set; }
        public virtual DbSet<Pagetemplate> Pagetemplate { get; set; }
        public virtual DbSet<Pagetemplateregion> Pagetemplateregion { get; set; }
        public virtual DbSet<Pagetemplateregioncontent> Pagetemplateregioncontent { get; set; }
        public virtual DbSet<Pagetype> Pagetype { get; set; }
        public virtual DbSet<Paymentblacklist> Paymentblacklist { get; set; }
        public virtual DbSet<Paymentcreditcardfailurelog> Paymentcreditcardfailurelog { get; set; }
        public virtual DbSet<Paymentgateway> Paymentgateway { get; set; }
        public virtual DbSet<Paymentgatewaytransaction> Paymentgatewaytransaction { get; set; }
        public virtual DbSet<Pointofsaletype> Pointofsaletype { get; set; }
        public virtual DbSet<Poll> Poll { get; set; }
        public virtual DbSet<Pollmembertypes> Pollmembertypes { get; set; }
        public virtual DbSet<Polloption> Polloption { get; set; }
        public virtual DbSet<Pollsites> Pollsites { get; set; }
        public virtual DbSet<Popup> Popup { get; set; }
        public virtual DbSet<Popupcinema> Popupcinema { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Promotionaloffer> Promotionaloffer { get; set; }
        public virtual DbSet<Promotionalofferlocation> Promotionalofferlocation { get; set; }
        public virtual DbSet<Promotionaloffersimage> Promotionaloffersimage { get; set; }
        public virtual DbSet<Promotioncategory> Promotioncategory { get; set; }
        public virtual DbSet<Promotioncinemas> Promotioncinemas { get; set; }
        public virtual DbSet<Promotionelement> Promotionelement { get; set; }
        public virtual DbSet<Promotionmembertypes> Promotionmembertypes { get; set; }
        public virtual DbSet<Promotionsites> Promotionsites { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<Radcaptchacache> Radcaptchacache { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Ratingchangelog> Ratingchangelog { get; set; }
        public virtual DbSet<Retrieverticketingbooking> Retrieverticketingbooking { get; set; }
        public virtual DbSet<Retrieverticketingbookinglog> Retrieverticketingbookinglog { get; set; }
        public virtual DbSet<Retrieverticketingbookingreceipt> Retrieverticketingbookingreceipt { get; set; }
        public virtual DbSet<Retrieverticketingbookingtickets> Retrieverticketingbookingtickets { get; set; }
        public virtual DbSet<Retrieverticketingexternalparty> Retrieverticketingexternalparty { get; set; }
        public virtual DbSet<Retrieverticketingpromo> Retrieverticketingpromo { get; set; }
        public virtual DbSet<Retrieverticketingsetting> Retrieverticketingsetting { get; set; }
        public virtual DbSet<Retrieverticketingsettingdata> Retrieverticketingsettingdata { get; set; }
        public virtual DbSet<Retrieverticketingsettingexternalparties> Retrieverticketingsettingexternalparties { get; set; }
        public virtual DbSet<Retrieverticketingsettinglog> Retrieverticketingsettinglog { get; set; }
        public virtual DbSet<Retrieverticketingsettingpricegroup> Retrieverticketingsettingpricegroup { get; set; }
        public virtual DbSet<Retrieverticketingsettingseattype> Retrieverticketingsettingseattype { get; set; }
        public virtual DbSet<Retrieverticketingsettingticket> Retrieverticketingsettingticket { get; set; }
        public virtual DbSet<Retrieverticketingticketsetting> Retrieverticketingticketsetting { get; set; }
        public virtual DbSet<Retrieverticketingticketsettingcheckbox> Retrieverticketingticketsettingcheckbox { get; set; }
        public virtual DbSet<Retrieverticketingticketsettingmembertypes> Retrieverticketingticketsettingmembertypes { get; set; }
        public virtual DbSet<Retrieverticketingtickettype> Retrieverticketingtickettype { get; set; }
        public virtual DbSet<Retrieverticketingtickettypemovie> Retrieverticketingtickettypemovie { get; set; }
        public virtual DbSet<Retrieverticketingvoucher> Retrieverticketingvoucher { get; set; }
        public virtual DbSet<Retrieverticketingvouchertype> Retrieverticketingvouchertype { get; set; }
        public virtual DbSet<Salutation> Salutation { get; set; }
        public virtual DbSet<Screen> Screen { get; set; }
        public virtual DbSet<Screenfeature> Screenfeature { get; set; }
        public virtual DbSet<Screenscreenfeatures> Screenscreenfeatures { get; set; }
        public virtual DbSet<Screenseat> Screenseat { get; set; }
        public virtual DbSet<Screentype> Screentype { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Sessioncreationrule> Sessioncreationrule { get; set; }
        public virtual DbSet<Sessionflags> Sessionflags { get; set; }
        public virtual DbSet<Sessionimportattempt> Sessionimportattempt { get; set; }
        public virtual DbSet<Sessionimportattemptimportedsession> Sessionimportattemptimportedsession { get; set; }
        public virtual DbSet<Sessionimportattemptlog> Sessionimportattemptlog { get; set; }
        public virtual DbSet<Sessionimportattemptunmatchedmovie> Sessionimportattemptunmatchedmovie { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Shopcart> Shopcart { get; set; }
        public virtual DbSet<Shopcartitems> Shopcartitems { get; set; }
        public virtual DbSet<Shopcategory> Shopcategory { get; set; }
        public virtual DbSet<Shopcinema> Shopcinema { get; set; }
        public virtual DbSet<Shopdeliverymethod> Shopdeliverymethod { get; set; }
        public virtual DbSet<Shopnotification> Shopnotification { get; set; }
        public virtual DbSet<Shopnotificationcinemas> Shopnotificationcinemas { get; set; }
        public virtual DbSet<Shoporder> Shoporder { get; set; }
        public virtual DbSet<Shoporderactivitylog> Shoporderactivitylog { get; set; }
        public virtual DbSet<Shoporderproducts> Shoporderproducts { get; set; }
        public virtual DbSet<Shoporderstatus> Shoporderstatus { get; set; }
        public virtual DbSet<Shoppricegroup> Shoppricegroup { get; set; }
        public virtual DbSet<Shoppricegroupmembertypes> Shoppricegroupmembertypes { get; set; }
        public virtual DbSet<Shopproduct> Shopproduct { get; set; }
        public virtual DbSet<Shopproductshopdeliverymethods> Shopproductshopdeliverymethods { get; set; }
        public virtual DbSet<Shopproductvariationprice> Shopproductvariationprice { get; set; }
        public virtual DbSet<Shopproductvariationpricecinemas> Shopproductvariationpricecinemas { get; set; }
        public virtual DbSet<Shopsites> Shopsites { get; set; }
        public virtual DbSet<Sidebar> Sidebar { get; set; }
        public virtual DbSet<Sidebarelement> Sidebarelement { get; set; }
        public virtual DbSet<Sidebarelementcinemas> Sidebarelementcinemas { get; set; }
        public virtual DbSet<Sidebarelementmembertypes> Sidebarelementmembertypes { get; set; }
        public virtual DbSet<Sign> Sign { get; set; }
        public virtual DbSet<Signcontent> Signcontent { get; set; }
        public virtual DbSet<Signmode> Signmode { get; set; }
        public virtual DbSet<Signplaylist> Signplaylist { get; set; }
        public virtual DbSet<Signplaylistcontents> Signplaylistcontents { get; set; }
        public virtual DbSet<Signplaylistschedule> Signplaylistschedule { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Siteadvertisementlocationtypes> Siteadvertisementlocationtypes { get; set; }
        public virtual DbSet<Sitecinemagroups> Sitecinemagroups { get; set; }
        public virtual DbSet<Siteconfig> Siteconfig { get; set; }
        public virtual DbSet<Sitedisplaysetting> Sitedisplaysetting { get; set; }
        public virtual DbSet<Siteemailsetting> Siteemailsetting { get; set; }
        public virtual DbSet<Sitefooterlinks> Sitefooterlinks { get; set; }
        public virtual DbSet<Sitehomepagetab> Sitehomepagetab { get; set; }
        public virtual DbSet<Sitehomepagetabcinemas> Sitehomepagetabcinemas { get; set; }
        public virtual DbSet<Siteloginmethods> Siteloginmethods { get; set; }
        public virtual DbSet<Sitemaininteractiveautoorder> Sitemaininteractiveautoorder { get; set; }
        public virtual DbSet<Sitememberpointawardsetting> Sitememberpointawardsetting { get; set; }
        public virtual DbSet<Sitemenu> Sitemenu { get; set; }
        public virtual DbSet<Sitesharingsetting> Sitesharingsetting { get; set; }
        public virtual DbSet<Smslog> Smslog { get; set; }
        public virtual DbSet<Specialsession> Specialsession { get; set; }
        public virtual DbSet<Specialsessiontype> Specialsessiontype { get; set; }
        public virtual DbSet<Statistic> Statistic { get; set; }
        public virtual DbSet<Statisticdaily> Statisticdaily { get; set; }
        public virtual DbSet<Statisticlog> Statisticlog { get; set; }
        public virtual DbSet<Statistictype> Statistictype { get; set; }
        public virtual DbSet<Supportresource> Supportresource { get; set; }
        public virtual DbSet<Supportresourcecomment> Supportresourcecomment { get; set; }
        public virtual DbSet<Supportresourcestep> Supportresourcestep { get; set; }
        public virtual DbSet<Systembug> Systembug { get; set; }
        public virtual DbSet<Systembugcomment> Systembugcomment { get; set; }
        public virtual DbSet<Systembugtype> Systembugtype { get; set; }
        public virtual DbSet<Systemupdate> Systemupdate { get; set; }
        public virtual DbSet<Systemupdatesystembugs> Systemupdatesystembugs { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<TopQueriesByCpu> TopQueriesByCpu { get; set; }
        public virtual DbSet<Transactionlog> Transactionlog { get; set; }
        public virtual DbSet<Venuemastercrmaction> Venuemastercrmaction { get; set; }
        public virtual DbSet<Venuemastercrmactiontype> Venuemastercrmactiontype { get; set; }
        public virtual DbSet<Venuemastercrmconfig> Venuemastercrmconfig { get; set; }
        public virtual DbSet<Venuemastercrmlog> Venuemastercrmlog { get; set; }
        public virtual DbSet<Venuemasterticketingblacklist> Venuemasterticketingblacklist { get; set; }
        public virtual DbSet<Venuemasterticketingbooking> Venuemasterticketingbooking { get; set; }
        public virtual DbSet<Venuemasterticketingbookinglog> Venuemasterticketingbookinglog { get; set; }
        public virtual DbSet<Venuemasterticketingbookingreceipt> Venuemasterticketingbookingreceipt { get; set; }
        public virtual DbSet<Venuemasterticketingbookingtickets> Venuemasterticketingbookingtickets { get; set; }
        public virtual DbSet<Venuemasterticketingcreditcardfailurelog> Venuemasterticketingcreditcardfailurelog { get; set; }
        public virtual DbSet<Venuemasterticketingexternalparty> Venuemasterticketingexternalparty { get; set; }
        public virtual DbSet<Venuemasterticketingpromo> Venuemasterticketingpromo { get; set; }
        public virtual DbSet<Venuemasterticketingsetting> Venuemasterticketingsetting { get; set; }
        public virtual DbSet<Venuemasterticketingsettingexternalparties> Venuemasterticketingsettingexternalparties { get; set; }
        public virtual DbSet<Venuemasterticketingsettinglog> Venuemasterticketingsettinglog { get; set; }
        public virtual DbSet<Venuemasterticketingsettingseattype> Venuemasterticketingsettingseattype { get; set; }
        public virtual DbSet<Venuemasterticketingsettingvifdata> Venuemasterticketingsettingvifdata { get; set; }
        public virtual DbSet<Venuemasterticketingsettingvifprl> Venuemasterticketingsettingvifprl { get; set; }
        public virtual DbSet<Venuemasterticketingsettingviftkt> Venuemasterticketingsettingviftkt { get; set; }
        public virtual DbSet<Venuemasterticketingticketsetting> Venuemasterticketingticketsetting { get; set; }
        public virtual DbSet<Venuemasterticketingticketsettingcheckbox> Venuemasterticketingticketsettingcheckbox { get; set; }
        public virtual DbSet<Venuemasterticketingticketsettingmembertypes> Venuemasterticketingticketsettingmembertypes { get; set; }
        public virtual DbSet<Venuemasterticketingtickettype> Venuemasterticketingtickettype { get; set; }
        public virtual DbSet<Venuemasterticketingtickettypemovie> Venuemasterticketingtickettypemovie { get; set; }
        public virtual DbSet<Venuemasterticketingvoucher> Venuemasterticketingvoucher { get; set; }
        public virtual DbSet<Venuemasterticketingvouchertype> Venuemasterticketingvouchertype { get; set; }
        public virtual DbSet<VistaCache> VistaCache { get; set; }
        public virtual DbSet<VistaCacheLogs> VistaCacheLogs { get; set; }
        public virtual DbSet<VistaCinemas> VistaCinemas { get; set; }
        public virtual DbSet<VistaScheduledFilms> VistaScheduledFilms { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=KEVIN\\KEVIN;Database=KICSDEV;Trusted_Connection=True;user id=KICSUser;password=m8Gn!A@c3L#;");
        //            }
        //        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.ToTable("ADVERTISEMENT");

                entity.HasIndex(e => new { e.AdvertisementClientId, e.AdvertisementCampaignId, e.IsDeleted, e.IsApproved, e.StartDateTime, e.FinishDateTime })
                    .HasName("IX_ADVERTISEMENT_IsDeleted_IsApproved_StartDateTime_FinishDateTime_AdvertisementClientId_AdvertisementCampaignId");

                entity.Property(e => e.AdvertisementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DestinationUrl)
                    .HasColumnName("DestinationURL")
                    .HasMaxLength(400);

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.TooltipText).HasMaxLength(100);

                entity.HasOne(d => d.AdvertisementCampaign)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.AdvertisementCampaignId)
                    .HasConstraintName("FK_ADVERTISEMENT_ADVERTISEMENTCAMPAIGN");

                entity.HasOne(d => d.AdvertisementClient)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.AdvertisementClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENT_ADVERTISEMENTCLIENT");

                entity.HasOne(d => d.AdvertisementLocationType)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.AdvertisementLocationTypeId)
                    .HasConstraintName("FK_ADVERTISEMENT_ADVERTISEMENTLOCATIONTYPE");

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.AdvertisementApprovedByUser)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .HasConstraintName("FK_ADVERTISEMENT_aspnet_Users1");

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.AdvertisementAuthorUser)
                    .HasForeignKey(d => d.AuthorUserId)
                    .HasConstraintName("FK_ADVERTISEMENT_aspnet_Users");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ADVERTISEMENT_BLOGPOST");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENT_COMPANY");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ADVERTISEMENT_COMPETITION");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.MovieDetailId)
                    .HasConstraintName("FK_ADVERTISEMENT_MOVIEDETAIL");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ADVERTISEMENT_OFFER");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_ADVERTISEMENT_PAGE");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_ADVERTISEMENT_PROMOTION");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_ADVERTISEMENT_SHOP");
            });

            modelBuilder.Entity<Advertisementadvertisementlocations>(entity =>
            {
                entity.HasKey(e => e.AdvertisementAdvertisementLocationId);

                entity.ToTable("ADVERTISEMENTADVERTISEMENTLOCATIONS");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Advertisementadvertisementlocations)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_ADVERTISEMENTADVERTISEMENTLOCATIONS_ADVERTISEMENT");

                entity.HasOne(d => d.AdvertisementLocation)
                    .WithMany(p => p.Advertisementadvertisementlocations)
                    .HasForeignKey(d => d.AdvertisementLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTADVERTISEMENTLOCATIONS_ADVERTISEMENTLOCATION");
            });

            modelBuilder.Entity<Advertisementcampaign>(entity =>
            {
                entity.ToTable("ADVERTISEMENTCAMPAIGN");

                entity.Property(e => e.AdvertisementCampaignId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.AdvertisementClient)
                    .WithMany(p => p.Advertisementcampaign)
                    .HasForeignKey(d => d.AdvertisementClientId)
                    .HasConstraintName("FK_ADVERTISEMENTCAMPAIGN_ADVERTISEMENTCLIENT");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Advertisementcampaign)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTCAMPAIGN_COMPANY");
            });

            modelBuilder.Entity<Advertisementcinemas>(entity =>
            {
                entity.HasKey(e => e.AdvertisementCinemaId);

                entity.ToTable("ADVERTISEMENTCINEMAS");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Advertisementcinemas)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_ADVERTISEMENTCINEMAS_ADVERTISEMENT");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Advertisementcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_ADVERTISEMENTCINEMAS_CINEMA");
            });

            modelBuilder.Entity<Advertisementclient>(entity =>
            {
                entity.ToTable("ADVERTISEMENTCLIENT");

                entity.Property(e => e.AdvertisementClientId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Advertisementclient)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_ADVERTISEMENTCLIENT_COMPANY");
            });

            modelBuilder.Entity<Advertisementdays>(entity =>
            {
                entity.HasKey(e => e.AdvertisementDayId);

                entity.ToTable("ADVERTISEMENTDAYS");

                entity.HasIndex(e => new { e.DayId, e.AdvertisementId })
                    .HasName("IX_ADVERTISEMENTDAYS_AdvertisementId_DayId");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Advertisementdays)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_ADVERTISEMENTDAYS_ADVERTISEMENT");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Advertisementdays)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTDAYS_DAY");
            });

            modelBuilder.Entity<Advertisementlocation>(entity =>
            {
                entity.ToTable("ADVERTISEMENTLOCATION");

                entity.Property(e => e.AdvertisementLocationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsDeletable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.AdvertisementLocationType)
                    .WithMany(p => p.Advertisementlocation)
                    .HasForeignKey(d => d.AdvertisementLocationTypeId)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATION_ADVERTISEMENTLOCATIONTYPE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Advertisementlocation)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATION_SITE");
            });

            modelBuilder.Entity<Advertisementlocationcinemagroup>(entity =>
            {
                entity.ToTable("ADVERTISEMENTLOCATIONCINEMAGROUP");

                entity.Property(e => e.AdvertisementLocationCinemaGroupId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.AdvertisementLocation)
                    .WithMany(p => p.Advertisementlocationcinemagroup)
                    .HasForeignKey(d => d.AdvertisementLocationId)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONCINEMAGROUP_ADVERTISEMENTLOCATION");

                entity.HasOne(d => d.CinemaGroup)
                    .WithMany(p => p.Advertisementlocationcinemagroup)
                    .HasForeignKey(d => d.CinemaGroupId)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONCINEMAGROUP_CINEMAGROUP");
            });

            modelBuilder.Entity<Advertisementlocationplaylistschedule>(entity =>
            {
                entity.ToTable("ADVERTISEMENTLOCATIONPLAYLISTSCHEDULE");

                entity.HasOne(d => d.AdvertisementLocationCinemaGroup)
                    .WithMany(p => p.Advertisementlocationplaylistschedule)
                    .HasForeignKey(d => d.AdvertisementLocationCinemaGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONPLAYLISTSCHEDULE_ADVERTISEMENTLOCATIONCINEMAGROUP");

                entity.HasOne(d => d.AdvertisementPlayList)
                    .WithMany(p => p.Advertisementlocationplaylistschedule)
                    .HasForeignKey(d => d.AdvertisementPlayListId)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONPLAYLISTSCHEDULE_ADVERTISEMENTPLAYLIST");

                entity.HasOne(d => d.Time)
                    .WithMany(p => p.Advertisementlocationplaylistschedule)
                    .HasForeignKey(d => d.TimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONPLAYLISTSCHEDULE_TIME");
            });

            modelBuilder.Entity<Advertisementlocationtype>(entity =>
            {
                entity.ToTable("ADVERTISEMENTLOCATIONTYPE");

                entity.Property(e => e.AdvertisementLocationTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsUseDayFilter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Advertisementlocationtype)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTLOCATIONTYPE_CONTENTTYPE");
            });

            modelBuilder.Entity<Advertisementplaylist>(entity =>
            {
                entity.ToTable("ADVERTISEMENTPLAYLIST");

                entity.Property(e => e.AdvertisementPlaylistId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AdvertisementLocationCinemaGroup)
                    .WithMany(p => p.Advertisementplaylist)
                    .HasForeignKey(d => d.AdvertisementLocationCinemaGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVERTISEMENTPLAYLIST_ADVERTISEMENTLOCATIONCINEMAGROUP");
            });

            modelBuilder.Entity<Advertisementplaylistadvertisements>(entity =>
            {
                entity.HasKey(e => e.AdvertisementPlayListContentId);

                entity.ToTable("ADVERTISEMENTPLAYLISTADVERTISEMENTS");

                entity.Property(e => e.PlaybackOrder).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Advertisementplaylistadvertisements)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_ADVERTISEMENTPLAYLISTADVERTISEMENTS_ADVERTISEMENT");

                entity.HasOne(d => d.AdvertisementPlayList)
                    .WithMany(p => p.Advertisementplaylistadvertisements)
                    .HasForeignKey(d => d.AdvertisementPlayListId)
                    .HasConstraintName("FK_ADVERTISEMENTPLAYLISTCONTENTS_ADVERTISEMENTPLAYLIST");
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("ALERT");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RelatedId).HasMaxLength(50);

                entity.Property(e => e.Text).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.AlertType)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.AlertTypeId)
                    .HasConstraintName("FK_ALERT_ALERTTYPE");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_ALERT_CINEMA");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_ALERT_CMSUSER");
            });

            modelBuilder.Entity<Alerttype>(entity =>
            {
                entity.ToTable("ALERTTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppPushNoticificationUser>(entity =>
            {
                entity.Property(e => e.CinemaId).HasColumnName("cinemaId");

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.UserDeviceId)
                    .HasColumnName("UserDeviceID")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AppPushNotificationStatistics>(entity =>
            {
                entity.Property(e => e.Message).HasMaxLength(250);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331164452B1")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.UserId, e.LoweredEmail })
                    .HasName("IX_aspnet_Membership_LoweredEmail_UserId");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__30F848ED");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__31EC6D26");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasName("aspnet_Paths_index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__6A30C649");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId);

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__71D1E811");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__778AC167");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__787EE5A0");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__47DBAE45");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__534D60F1");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion });

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__1CF15040");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__59FA5E80");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__59063A47");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Autopost>(entity =>
            {
                entity.ToTable("AUTOPOST");

                entity.HasIndex(e => new { e.RelatedId, e.CompanyAutoPostId });

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.PostDateTime).HasColumnType("datetime");

                entity.Property(e => e.RelatedId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.AutoPostTypeTemplate)
                    .WithMany(p => p.Autopost)
                    .HasForeignKey(d => d.AutoPostTypeTemplateId)
                    .HasConstraintName("FK_AUTOPOST_AUTOPOSTTYPETEMPLATE");

                entity.HasOne(d => d.CompanyAutoPost)
                    .WithMany(p => p.Autopost)
                    .HasForeignKey(d => d.CompanyAutoPostId)
                    .HasConstraintName("FK_AUTOPOST_COMPANYAUTOPOST");
            });

            modelBuilder.Entity<Autopostdestination>(entity =>
            {
                entity.ToTable("AUTOPOSTDESTINATION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Autoposttype>(entity =>
            {
                entity.ToTable("AUTOPOSTTYPE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Autoposttypetemplate>(entity =>
            {
                entity.ToTable("AUTOPOSTTYPETEMPLATE");

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.Property(e => e.Text).HasMaxLength(1000);

                entity.HasOne(d => d.AutoPostDestination)
                    .WithMany(p => p.Autoposttypetemplate)
                    .HasForeignKey(d => d.AutoPostDestinationId)
                    .HasConstraintName("FK_AUTOPOSTTYPETEMPLATE_AUTOPOSTDESTINATION");

                entity.HasOne(d => d.AutoPostType)
                    .WithMany(p => p.Autoposttypetemplate)
                    .HasForeignKey(d => d.AutoPostTypeId)
                    .HasConstraintName("FK_AUTOPOSTTYPETEMPLATE_AUTOPOSTTYPE");
            });

            modelBuilder.Entity<Blogpost>(entity =>
            {
                entity.ToTable("BLOGPOST");

                entity.HasIndex(e => new { e.MovieDetailId, e.ValidStartDateTime, e.ValidFinishDateTime, e.IsPublic });

                entity.HasIndex(e => new { e.CompanyId, e.MovieDetailId, e.ValidStartDateTime, e.ValidFinishDateTime, e.IsPublic });

                entity.HasIndex(e => new { e.CreateDateTime, e.IsAutoGenerated, e.CountryId, e.LanguageId, e.AutoPostTypeId, e.PromotionId, e.CompetitionId, e.OfferId, e.PageId, e.ShopId, e.AuthorUserId, e.Subject, e.Text, e.IsSticky, e.Url, e.BlogPostSectionId, e.MovieDetailId, e.CompanyId, e.ValidStartDateTime, e.ValidFinishDateTime, e.IsPublic })
                    .HasName("IX_BLOGPOST_CompanyId_ValidStartDateTime_ValidFinishDateTime_IsPublic_CreateDateTime_Subject_Text_IsSticky_URL_BlogPostSectionId");

                entity.Property(e => e.BlogPostId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidStartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BLOGPOST_aspnet_Users");

                entity.HasOne(d => d.AutoPostType)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.AutoPostTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BLOGPOST_AUTOPOSTTYPE");

                entity.HasOne(d => d.BlogPostSection)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.BlogPostSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BLOGPOST_BLOGPOSTSECTION");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_BLOGPOST_COMPANY");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BLOGPOST_COMPETITION");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BLOGPOST_COUNTRY");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_BLOGPOST_LANGUAGE");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.MovieDetailId)
                    .HasConstraintName("FK_BLOGPOST_MOVIEDETAIL");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BLOGPOST_OFFER");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BLOGPOST_PAGE");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_BLOGPOST_PROMOTION");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Blogpost)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_BLOGPOST_SHOP");
            });

            modelBuilder.Entity<Blogpostcinemas>(entity =>
            {
                entity.HasKey(e => e.BlogPostCinemaId);

                entity.ToTable("BLOGPOSTCINEMAS");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.Blogpostcinemas)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("FK_BLOGPOSTCINEMAS_BLOGPOST");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Blogpostcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_BLOGPOSTCINEMAS_CINEMA");
            });

            modelBuilder.Entity<Blogpostcomment>(entity =>
            {
                entity.ToTable("BLOGPOSTCOMMENT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.Blogpostcomment)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("FK_BLOGPOSTCOMMENT_BLOGPOST");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Blogpostcomment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYSTEMNEWSCOMMENT_aspnet_Users");
            });

            modelBuilder.Entity<Blogpostmembertypes>(entity =>
            {
                entity.HasKey(e => e.BlogPostMemberTypeId);

                entity.ToTable("BLOGPOSTMEMBERTYPES");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.Blogpostmembertypes)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("FK_BLOGPOSTMEMBERTYPES_BLOGPOST");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Blogpostmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_BLOGPOSTMEMBERTYPES_MEMBERTYPE");
            });

            modelBuilder.Entity<Blogpostsection>(entity =>
            {
                entity.ToTable("BLOGPOSTSECTION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Bounce>(entity =>
            {
                entity.ToTable("BOUNCE");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.EmailId).HasMaxLength(100);
            });

            modelBuilder.Entity<Bulksms>(entity =>
            {
                entity.ToTable("BULKSMS");

                entity.Property(e => e.BulkSmsId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("createDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GatewayReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Bulksms)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_BULKSMS");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Bulksms)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANY_BULKSMS");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Bulksms)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BULKSMS_FILTER");
            });

            modelBuilder.Entity<Bulksmscinema>(entity =>
            {
                entity.ToTable("BULKSMSCINEMA");

                entity.Property(e => e.BulkSmscinemaId).HasColumnName("BulkSMSCinemaId");

                entity.Property(e => e.BulkSmsid).HasColumnName("BulkSMSid");

                entity.HasOne(d => d.BulkSms)
                    .WithMany(p => p.Bulksmscinema)
                    .HasForeignKey(d => d.BulkSmsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BULKSMSCINEMA_BULKSMS1");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Bulksmscinema)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BULKSMSCINEMA_CINEMA1");
            });

            modelBuilder.Entity<Bulksmsmembertype>(entity =>
            {
                entity.ToTable("BULKSMSMEMBERTYPE");

                entity.HasOne(d => d.BulkSms)
                    .WithMany(p => p.Bulksmsmembertype)
                    .HasForeignKey(d => d.BulkSmsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BulkSmsMemberType_BULKSMS");

                entity.HasOne(d => d.Membertype)
                    .WithMany(p => p.Bulksmsmembertype)
                    .HasForeignKey(d => d.MembertypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BulkSmsMemberType_MEMBERTYPE");
            });

            modelBuilder.Entity<Bulksmsrecipient>(entity =>
            {
                entity.ToTable("BULKSMSRECIPIENT");

                entity.Property(e => e.BulkSmsRecipientId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GatewayReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.GatewayResponse).HasMaxLength(250);

                entity.Property(e => e.RecipientNumber)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.HasOne(d => d.BulkSms)
                    .WithMany(p => p.Bulksmsrecipient)
                    .HasForeignKey(d => d.BulkSmsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BULKSMSRECIPIENT_BULKSMS");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Bulksmsrecipient)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_BULKSMSRECIPIENT_MEMBER");
            });

            modelBuilder.Entity<Carousel>(entity =>
            {
                entity.ToTable("CAROUSEL");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutoPlay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Carousel)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAROUSEL_COMPANY");
            });

            modelBuilder.Entity<Carouselcontent>(entity =>
            {
                entity.ToTable("CAROUSELCONTENT");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Carousel)
                    .WithMany(p => p.Carouselcontent)
                    .HasForeignKey(d => d.CarouselId)
                    .HasConstraintName("FK_CAROUSELCONTENT_CAROUSEL");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Carouselcontent)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("FK_CAROUSELCONTENT_CONTENTTYPE");
            });

            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.ToTable("CINEMA");

                entity.Property(e => e.CinemaId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.AdministrationEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AllowReDshieldFraudProtection).HasColumnName("AllowReDShieldFraudProtection");

                entity.Property(e => e.AppStoreUrl)
                    .HasColumnName("AppStoreURL")
                    .HasMaxLength(350);

                entity.Property(e => e.BookingPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmtypeId)
                    .HasColumnName("CRMTypeId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FacebookPageUrl)
                    .HasColumnName("FacebookPageURL")
                    .HasMaxLength(350);

                entity.Property(e => e.GooglePlayUrl)
                    .HasColumnName("GooglePlayURL")
                    .HasMaxLength(350);

                entity.Property(e => e.InstagramPageUrl)
                    .HasColumnName("InstagramPageURL")
                    .HasMaxLength(350);

                entity.Property(e => e.InternetTicketingTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsImportSessionsAutomatically)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.LoyaltyPointOfSaleId).HasMaxLength(50);

                entity.Property(e => e.MovieTimesComAuCinemaName).HasMaxLength(50);

                entity.Property(e => e.MovieTimesComAuPassword).HasMaxLength(50);

                entity.Property(e => e.MovieTimesComAuUserName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NowShowingCacheExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2000-01-01 00:00:01')");

                entity.Property(e => e.NowShowingQueryMethodId).HasDefaultValueSql("((3))");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PointOfSaleId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PointOfSaleTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SessionImportEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SessionNumberOfDaysLimit).HasDefaultValueSql("((7))");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneLocationId)
                    .IsRequired()
                    .HasColumnName("TimeZoneLocationID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterPageUrl)
                    .HasColumnName("TwitterPageURL")
                    .HasMaxLength(350);

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_COMPANY");

                entity.HasOne(d => d.CountryState)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.CountryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_COUNTRYSTATE");

                entity.HasOne(d => d.Crmtype)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.CrmtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_CRMTYPE");

                entity.HasOne(d => d.InternetTicketingType)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.InternetTicketingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_INTERNETTICKETINGTYPE");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.MemberTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MEMBERTYPE_CINEMA");

                entity.HasOne(d => d.NowShowingQueryMethod)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.NowShowingQueryMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_NOWSHOWINGQUERYMETHOD");

                entity.HasOne(d => d.PointOfSaleType)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.PointOfSaleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CINEMA_POINTOFSALETYPE");

                entity.HasOne(d => d.SessionRestrictUntilTime)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.SessionRestrictUntilTimeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CINEMA_TIME");
            });

            modelBuilder.Entity<Cinemafullimagebackground>(entity =>
            {
                entity.ToTable("CINEMAFULLIMAGEBACKGROUND");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.FullImageBackgroundId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemafullimagebackground)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAFULLIMAGEBACKGROUND_CINEMA");

                entity.HasOne(d => d.FullImageBackground)
                    .WithMany(p => p.Cinemafullimagebackground)
                    .HasForeignKey(d => d.FullImageBackgroundId)
                    .HasConstraintName("FK_CINEMAFULLIMAGEBACKGROUND_FULLIMAGEBACKGROUND");
            });

            modelBuilder.Entity<Cinemagroup>(entity =>
            {
                entity.ToTable("CINEMAGROUP");

                entity.Property(e => e.CinemaGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Cinemagroup)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CINEMAGROUP_COMPANY");
            });

            modelBuilder.Entity<Cinemagroupcinemas>(entity =>
            {
                entity.ToTable("CINEMAGROUPCINEMAS");

                entity.HasOne(d => d.CinemaGroup)
                    .WithMany(p => p.Cinemagroupcinemas)
                    .HasForeignKey(d => d.CinemaGroupId)
                    .HasConstraintName("FK_CINEMAGROUPCINEMAS_CINEMAGROUP");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemagroupcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAGROUPCINEMAS_CINEMA");
            });

            modelBuilder.Entity<Cinemahaxlenconfig>(entity =>
            {
                entity.HasKey(e => e.HaxlenConfigId);

                entity.ToTable("CINEMAHAXLENCONFIG");

                entity.Property(e => e.HaxlenConfigId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId)
                    .IsRequired()
                    .HasColumnName("AgentID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemahaxlenconfig)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAHAXLENCONFIG_CINEMA");
            });

            modelBuilder.Entity<Cinemamoviecache>(entity =>
            {
                entity.ToTable("CINEMAMOVIECACHE");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemamoviecache)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAMOVIECACHE_CINEMA");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Cinemamoviecache)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_CINEMAMOVIECACHE_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Cinemapaymentgateway>(entity =>
            {
                entity.ToTable("CINEMAPAYMENTGATEWAY");

                entity.Property(e => e.CinemaPaymentGatewayId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsTesting)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeZoneLocationId)
                    .IsRequired()
                    .HasColumnName("TimeZoneLocationID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AU-VIC')");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemapaymentgateway)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAPAYMENTGATEWAY_CINEMA");

                entity.HasOne(d => d.PaymentGateway)
                    .WithMany(p => p.Cinemapaymentgateway)
                    .HasForeignKey(d => d.PaymentGatewayId)
                    .HasConstraintName("FK_CINEMAPAYMENTGATEWAY_PAYMENTGATEWAY");
            });

            modelBuilder.Entity<Cinemaretrieverconfig>(entity =>
            {
                entity.ToTable("CINEMARETRIEVERCONFIG");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cinemasessioncache>(entity =>
            {
                entity.ToTable("CINEMASESSIONCACHE");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ShortGuid).HasMaxLength(50);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemasessioncache)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMASESSIONCACHE_CINEMA");
            });

            modelBuilder.Entity<Cinemasessiondisplay>(entity =>
            {
                entity.ToTable("CINEMASESSIONDISPLAY");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((99))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text).HasMaxLength(1500);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemasessiondisplay)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMASESSIONDISPLAY_CINEMA");
            });

            modelBuilder.Entity<Cinemasessiondisplaymoviecategories>(entity =>
            {
                entity.HasKey(e => e.CinemaSessionDisplayMovieCategoryId);

                entity.ToTable("CINEMASESSIONDISPLAYMOVIECATEGORIES");

                entity.HasOne(d => d.CinemaSessionDisplay)
                    .WithMany(p => p.Cinemasessiondisplaymoviecategories)
                    .HasForeignKey(d => d.CinemaSessionDisplayId)
                    .HasConstraintName("FK_CINEMASESSIONDISPLAYMOVIECATEGORIES_CINEMASESSIONDISPLAY");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.Cinemasessiondisplaymoviecategories)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .HasConstraintName("FK_CINEMASESSIONDISPLAYMOVIECATEGORIES_MOVIECATEGORY");
            });

            modelBuilder.Entity<Cinemasessiondisplaymovietypes>(entity =>
            {
                entity.HasKey(e => e.CinemaSessionDisplayMovieTypeId);

                entity.ToTable("CINEMASESSIONDISPLAYMOVIETYPES");

                entity.HasOne(d => d.CinemaSessionDisplay)
                    .WithMany(p => p.Cinemasessiondisplaymovietypes)
                    .HasForeignKey(d => d.CinemaSessionDisplayId)
                    .HasConstraintName("FK_CINEMASESSIONDISPLAYMOVIETYPES_CINEMASESSIONDISPLAY");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Cinemasessiondisplaymovietypes)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_CINEMASESSIONDISPLAYMOVIETYPES_MOVIETYPE");
            });

            modelBuilder.Entity<Cinemasessionfilter>(entity =>
            {
                entity.ToTable("CINEMASESSIONFILTER");

                entity.Property(e => e.CinemaSessionFilterId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultButtonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'All')");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemasessionfilter)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMASESSIONFILTER_CINEMA");
            });

            modelBuilder.Entity<Cinemasessionfilterbutton>(entity =>
            {
                entity.ToTable("CINEMASESSIONFILTERBUTTON");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CinemaSessionFilter)
                    .WithMany(p => p.Cinemasessionfilterbutton)
                    .HasForeignKey(d => d.CinemaSessionFilterId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTON_CINEMASESSIONFILTER");
            });

            modelBuilder.Entity<Cinemasessionfilterbuttonflags>(entity =>
            {
                entity.HasKey(e => e.CinemaSessionFilterButtonFlagId);

                entity.ToTable("CINEMASESSIONFILTERBUTTONFLAGS");

                entity.HasOne(d => d.CinemaSessionFilterButton)
                    .WithMany(p => p.Cinemasessionfilterbuttonflags)
                    .HasForeignKey(d => d.CinemaSessionFilterButtonId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONFLAGS_CINEMASESSIONFILTERBUTTON");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Cinemasessionfilterbuttonflags)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONFLAGS_FLAG");
            });

            modelBuilder.Entity<Cinemasessionfilterbuttonmoviecategory>(entity =>
            {
                entity.ToTable("CINEMASESSIONFILTERBUTTONMOVIECATEGORY");

                entity.Property(e => e.MovieCategoryId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CinemaSessionFilterButton)
                    .WithMany(p => p.Cinemasessionfilterbuttonmoviecategory)
                    .HasForeignKey(d => d.CinemaSessionFilterButtonId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONMOVIECATEGORY_CINEMASESSIONFILTERBUTTON");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.Cinemasessionfilterbuttonmoviecategory)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONMOVIECATEGORY_MOVIECATEGORY");
            });

            modelBuilder.Entity<Cinemasessionfilterbuttonmovietype>(entity =>
            {
                entity.ToTable("CINEMASESSIONFILTERBUTTONMOVIETYPE");

                entity.Property(e => e.MovieTypeId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CinemaSessionFilterButton)
                    .WithMany(p => p.Cinemasessionfilterbuttonmovietype)
                    .HasForeignKey(d => d.CinemaSessionFilterButtonId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONMOVIETYPE_CINEMASESSIONFILTERBUTTON");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Cinemasessionfilterbuttonmovietype)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_CINEMASESSIONFILTERBUTTONMOVIETYPE_MOVIETYPE");
            });

            modelBuilder.Entity<Cinemaveeziconfig>(entity =>
            {
                entity.HasKey(e => e.VeeziConfigId);

                entity.ToTable("CINEMAVEEZICONFIG");

                entity.Property(e => e.VeeziConfigId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OnlineTicketingUrl)
                    .IsRequired()
                    .HasColumnName("OnlineTicketingURL")
                    .HasMaxLength(350);

                entity.Property(e => e.SessionTimesApiurl)
                    .IsRequired()
                    .HasColumnName("SessionTimesAPIURL")
                    .HasMaxLength(350);

                entity.Property(e => e.VeeziAccessToken)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemaveeziconfig)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAVEEZICONFIG_CINEMA");
            });

            modelBuilder.Entity<Cinemavenuemasterconfig>(entity =>
            {
                entity.HasKey(e => e.VenueMasterConfigId);

                entity.ToTable("CINEMAVENUEMASTERCONFIG");

                entity.Property(e => e.VenueMasterConfigId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId)
                    .IsRequired()
                    .HasColumnName("AgentID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCrminstalled).HasColumnName("IsCRMInstalled");

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenueMasterCrmconfigId).HasColumnName("VenueMasterCRMConfigId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemavenuemasterconfig)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAVENUEMASTERCONFIG_CINEMA");

                entity.HasOne(d => d.VenueMasterCrmconfig)
                    .WithMany(p => p.Cinemavenuemasterconfig)
                    .HasForeignKey(d => d.VenueMasterCrmconfigId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CINEMAVENUEMASTERCONFIG_VENUEMASTERCRMCONFIG");
            });

            modelBuilder.Entity<Cinemavistaconfig>(entity =>
            {
                entity.HasKey(e => e.VistaConfigId);

                entity.ToTable("CINEMAVISTACONFIG");

                entity.Property(e => e.VistaConfigId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NextSessionUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.OnlineTicketingUrl)
                    .HasColumnName("OnlineTicketingURL")
                    .HasMaxLength(150);

                entity.Property(e => e.ServerIpaddress)
                    .HasColumnName("ServerIPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemavistaconfig)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAVISTACONFIG_CINEMA");
            });

            modelBuilder.Entity<Cinemaweeklyemailsetting>(entity =>
            {
                entity.ToTable("CINEMAWEEKLYEMAILSETTING");

                entity.Property(e => e.CinemaWeeklyEmailSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultIntroduction).HasMaxLength(1000);

                entity.Property(e => e.DefaultSubject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cinemaweeklyemailsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CINEMAWEEKLYEMAILSETTING_CINEMA");

                entity.HasOne(d => d.EmailGroup)
                    .WithMany(p => p.Cinemaweeklyemailsetting)
                    .HasForeignKey(d => d.EmailGroupId)
                    .HasConstraintName("FK_CINEMAWEEKLYEMAILSETTING_EMAILGROUP");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Cinemaweeklyemailsetting)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CINEMAWEEKLYEMAILSETTING_EMAIL");
            });

            modelBuilder.Entity<Cmslogintoken>(entity =>
            {
                entity.ToTable("CMSLOGINTOKEN");

                entity.Property(e => e.CmsloginTokenId)
                    .HasColumnName("CMSLoginTokenId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.RedemptionDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Cmslogintoken)
                    .HasForeignKey(d => d.CmsuserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMSLOGINTOKEN_CMSUSER");

                entity.HasOne(d => d.HelpdeskTicket)
                    .WithMany(p => p.Cmslogintoken)
                    .HasForeignKey(d => d.HelpdeskTicketId)
                    .HasConstraintName("FK_CMSLOGINTOKEN_HELPDESKTICKET");
            });

            modelBuilder.Entity<Cmsnews>(entity =>
            {
                entity.ToTable("CMSNEWS");

                entity.Property(e => e.CmsnewsId)
                    .HasColumnName("CMSNewsId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmsnewscmsusers>(entity =>
            {
                entity.HasKey(e => e.CmsnewsCmsuserId);

                entity.ToTable("CMSNEWSCMSUSERS");

                entity.Property(e => e.CmsnewsCmsuserId).HasColumnName("CMSNewsCMSUserId");

                entity.Property(e => e.CmsnewsId).HasColumnName("CMSNewsId");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.HasOne(d => d.Cmsnews)
                    .WithMany(p => p.Cmsnewscmsusers)
                    .HasForeignKey(d => d.CmsnewsId)
                    .HasConstraintName("FK_CMSNEWSCMSUSERS_CMSNEWS");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Cmsnewscmsusers)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_CMSNEWSCMSUSERS_CMSUSER");
            });

            modelBuilder.Entity<Cmsnewscmsusersnew>(entity =>
            {
                entity.HasKey(e => e.CmsnewsCmsuserNewId);

                entity.ToTable("CMSNEWSCMSUSERSNEW");

                entity.Property(e => e.CmsnewsCmsuserNewId).HasColumnName("CMSNewsCMSUserNewId");

                entity.Property(e => e.CmsnewsId).HasColumnName("CMSNewsId");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.HasOne(d => d.Cmsnews)
                    .WithMany(p => p.Cmsnewscmsusersnew)
                    .HasForeignKey(d => d.CmsnewsId)
                    .HasConstraintName("FK_CMSNEWSCMSUSERSNEW_CMSNEWSCMSUSERSNEW");

                entity.HasOne(d => d.CmsnewsNavigation)
                    .WithMany(p => p.Cmsnewscmsusersnew)
                    .HasForeignKey(d => d.CmsnewsId)
                    .HasConstraintName("FK_CMSNEWSCMSUSERSNEW_CMSUSER");
            });

            modelBuilder.Entity<Cmsuser>(entity =>
            {
                entity.ToTable("CMSUSER");

                entity.Property(e => e.CmsuserId)
                    .HasColumnName("CMSUserId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CmsuserTypeId).HasColumnName("CMSUserTypeId");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAbleToApproveQuotes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastKtixPosTerminalId).HasColumnName("LastKTixPosTerminalId");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pospin).HasColumnName("POSPIN");

                entity.Property(e => e.PospinexpiryDate)
                    .HasColumnName("POSPINExpiryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeZoneLocationId)
                    .IsRequired()
                    .HasColumnName("TimeZoneLocationID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CmsuserType)
                    .WithMany(p => p.Cmsuser)
                    .HasForeignKey(d => d.CmsuserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMSUSER_CMSUSERTYPE");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Cmsuser)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CMSUSER_COMPANY");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cmsuser)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CMSUSER_COUNTRY");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cmsuser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CMSUSER_aspnet_Users");
            });

            modelBuilder.Entity<Cmsuseralerttypes>(entity =>
            {
                entity.HasKey(e => e.CmsuserAlertTypeId);

                entity.ToTable("CMSUSERALERTTYPES");

                entity.Property(e => e.CmsuserAlertTypeId).HasColumnName("CMSUserAlertTypeId");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.HasOne(d => d.AlertType)
                    .WithMany(p => p.Cmsuseralerttypes)
                    .HasForeignKey(d => d.AlertTypeId)
                    .HasConstraintName("FK_CMSUSERALERTTYPES_ALERTTYPE");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Cmsuseralerttypes)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_CMSUSERALERTTYPES_CMSUSER");
            });

            modelBuilder.Entity<Cmsusercinemas>(entity =>
            {
                entity.HasKey(e => e.CmsuserCinemaId);

                entity.ToTable("CMSUSERCINEMAS");

                entity.Property(e => e.CmsuserCinemaId).HasColumnName("CMSUserCinemaId");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Cmsusercinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CMSUSERCINEMAS_CINEMA");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Cmsusercinemas)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_CMSUSERCINEMAS_CMSUSER");
            });

            modelBuilder.Entity<Cmsusersites>(entity =>
            {
                entity.HasKey(e => e.CmsuserSiteId);

                entity.ToTable("CMSUSERSITES");

                entity.Property(e => e.CmsuserSiteId).HasColumnName("CMSUserSiteId");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Cmsusersites)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_CMSUSERSITES_CMSUSER");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Cmsusersites)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMSUSERSITES_SITE");
            });

            modelBuilder.Entity<Cmsusertype>(entity =>
            {
                entity.ToTable("CMSUSERTYPE");

                entity.Property(e => e.CmsuserTypeId).HasColumnName("CMSUserTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("COMPANY");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.AdministrationEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BillingAddress2).HasMaxLength(200);

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BillingEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BillingNameOfStaff)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BillingPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPostcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.BillingState)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BulkSmscreditLimit).HasColumnName("BulkSMSCreditLimit");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DayId).HasDefaultValueSql("((5))");

                entity.Property(e => e.FlagCacheExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2000)-(1))-(1))");

                entity.Property(e => e.InitialFreePeriodEndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsBillingActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdateLabelsDefault)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdatePointOfSaleTitleDefault)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdateReleaseDateDefault)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageGearsAccountId).HasMaxLength(50);

                entity.Property(e => e.MessageGearsApikey)
                    .HasColumnName("MessageGearsAPIKey")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameForDisplay)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PaymentTerms).HasDefaultValueSql("((14))");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SaasuContactUid).HasMaxLength(50);

                entity.Property(e => e.SmsratePerMessageBilledToCompany)
                    .HasColumnName("SMSRatePerMessageBilledToCompany")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.SmssenderName)
                    .HasColumnName("SMSSenderName")
                    .HasMaxLength(11);

                entity.Property(e => e.TimeZoneLocationId)
                    .IsRequired()
                    .HasColumnName("TimeZoneLocationID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('AU-VIC')");

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANY_COUNTRY");

                entity.HasOne(d => d.CountryState)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.CountryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANY_COUNTRYSTATE");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANY_DAY");
            });

            modelBuilder.Entity<Companyautopost>(entity =>
            {
                entity.ToTable("COMPANYAUTOPOST");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Credential1).HasMaxLength(250);

                entity.Property(e => e.Credential2).HasMaxLength(250);

                entity.Property(e => e.Credential3).HasMaxLength(250);

                entity.Property(e => e.Credential4).HasMaxLength(250);

                entity.Property(e => e.Credential5).HasMaxLength(250);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLastPostSuccessful)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TokenExpiryDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AutoPostDestination)
                    .WithMany(p => p.Companyautopost)
                    .HasForeignKey(d => d.AutoPostDestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANYAUTOPOST_AUTOPOSTDESTINATION");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyautopost)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYAUTOPOST_COMPANY");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Companyautopost)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANYFACEBOOK_SITE");
            });

            modelBuilder.Entity<Companyautopostcinema>(entity =>
            {
                entity.ToTable("COMPANYAUTOPOSTCINEMA");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Companyautopostcinema)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_COMPANYFACEBOOKCINEMA_CINEMA");

                entity.HasOne(d => d.CompanyAutoPost)
                    .WithMany(p => p.Companyautopostcinema)
                    .HasForeignKey(d => d.CompanyAutoPostId)
                    .HasConstraintName("FK_COMPANYFACEBOOKCINEMA_COMPANYFACEBOOK");
            });

            modelBuilder.Entity<Companyautoposttypetemplates>(entity =>
            {
                entity.HasKey(e => e.CompanyAutoPostTypeTemplateId);

                entity.ToTable("COMPANYAUTOPOSTTYPETEMPLATES");

                entity.HasOne(d => d.AutoPostTypeTemplate)
                    .WithMany(p => p.Companyautoposttypetemplates)
                    .HasForeignKey(d => d.AutoPostTypeTemplateId)
                    .HasConstraintName("FK_COMPANYAUTOPOSTTYPETEMPLATES_AUTOPOSTTYPETEMPLATE");

                entity.HasOne(d => d.CompanyAutoPost)
                    .WithMany(p => p.Companyautoposttypetemplates)
                    .HasForeignKey(d => d.CompanyAutoPostId)
                    .HasConstraintName("FK_COMPANYAUTOPOSTTYPETEMPLATES_COMPANYAUTOPOST");
            });

            modelBuilder.Entity<Companybackgroundrate>(entity =>
            {
                entity.ToTable("COMPANYBACKGROUNDRATE");

                entity.Property(e => e.RatePerBackground).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companybackgroundrate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYBACKGROUNDRATE_COMPANY");
            });

            modelBuilder.Entity<Companybannerrate>(entity =>
            {
                entity.ToTable("COMPANYBANNERRATE");

                entity.Property(e => e.RatePerBanner).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companybannerrate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYBANNERRATE_COMPANY");
            });

            modelBuilder.Entity<Companycontactemail>(entity =>
            {
                entity.ToTable("COMPANYCONTACTEMAIL");

                entity.Property(e => e.CompanyContactEmailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companycontactemail)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYCONTACTEMAIL_COMPANY");
            });

            modelBuilder.Entity<Companycreditcardtypes>(entity =>
            {
                entity.HasKey(e => e.CompanyCreditCardTypeId);

                entity.ToTable("COMPANYCREDITCARDTYPES");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companycreditcardtypes)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYCREDITCARDTYPES_COMPANY");
            });

            modelBuilder.Entity<Companydefaults>(entity =>
            {
                entity.HasKey(e => e.CompanyDefaultId);

                entity.ToTable("COMPANYDEFAULTS");

                entity.Property(e => e.CompanyDefaultId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompetitionTermsAndConditions)
                    .IsRequired()
                    .HasDefaultValueSql("(N'Winners will be notified via email address supplied in their website subscription within 7 days of competition closing. Chance Plays no part in this competition. Judges decision is final and no correspondence will be entered into.')");

                entity.Property(e => e.CompetitionTextForWinningEmail)
                    .IsRequired()
                    .HasDefaultValueSql(@"('Congratulations {firstName}!

You''ve been chosen as a winner in the {competitionName} competition!

Your prize: {prizeDescription}

In order for us to inform you on how to collect your prize we ask that you reply to this email with the following details: 
-Your full name and address, including postcode
-A daytime contact phone number, including area code.

Congratulations again and thank you for supporting {companyDisplayName}!')");

                entity.Property(e => e.OfferRedemptionInstruction)
                    .IsRequired()
                    .HasMaxLength(800)
                    .HasDefaultValueSql("(N'Print this offer from your computer, or display this offer on your smartphone, and present it to the Box Office staff.')");

                entity.Property(e => e.OfferTermsAndConditions)
                    .IsRequired()
                    .HasDefaultValueSql("(N'Voucher will be retained by cashier for audit purposes. Offer not valid with any other offer. Valid for use by registered members only.')");

                entity.Property(e => e.WeeklyEmailFrequency).HasDefaultValueSql("((7))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companydefaults)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYDEFAULTS_COMPANY");
            });

            modelBuilder.Entity<Companyemailrate>(entity =>
            {
                entity.ToTable("COMPANYEMAILRATE");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyemailrate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYEMAILRATE_COMPANY");
            });

            modelBuilder.Entity<Companyemailsubjecttemplate>(entity =>
            {
                entity.ToTable("COMPANYEMAILSUBJECTTEMPLATE");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyemailsubjecttemplate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYEMAILSUBJECTTEMPLATE_COMPANY");

                entity.HasOne(d => d.EmailSubjectTemplate)
                    .WithMany(p => p.Companyemailsubjecttemplate)
                    .HasForeignKey(d => d.EmailSubjectTemplateId)
                    .HasConstraintName("FK_COMPANYEMAILSUBJECTTEMPLATE_EMAILSUBJECTTEMPLATE");
            });

            modelBuilder.Entity<Companyfeatures>(entity =>
            {
                entity.HasKey(e => e.CompanyFeatureId);

                entity.ToTable("COMPANYFEATURES");

                entity.Property(e => e.BillingFrequency).HasDefaultValueSql("((7))");

                entity.Property(e => e.CasualRatePerWeek).HasColumnType("money");

                entity.Property(e => e.FinishDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2010-01-01')");

                entity.Property(e => e.LastBilledDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.OngoingRatePerWeek).HasColumnType("money");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2010-01-01')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyfeatures)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYFEATURES_COMPANY");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.Companyfeatures)
                    .HasForeignKey(d => d.FeatureId)
                    .HasConstraintName("FK_COMPANYFEATURES_FEATURE");
            });

            modelBuilder.Entity<Companyflagcache>(entity =>
            {
                entity.ToTable("COMPANYFLAGCACHE");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyflagcache)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPANYFLAGCACHE_COMPANY");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Companyflagcache)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_COMPANYFLAGCACHE_FLAG");
            });

            modelBuilder.Entity<Companygenres>(entity =>
            {
                entity.HasKey(e => e.CompanyGenreId);

                entity.ToTable("COMPANYGENRES");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companygenres)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYGENRES_COMPANY");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Companygenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_COMPANYGENRES_GENRE");
            });

            modelBuilder.Entity<Companymemberexportjob>(entity =>
            {
                entity.ToTable("COMPANYMEMBEREXPORTJOB");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExportFileName).HasMaxLength(250);

                entity.Property(e => e.ProcessedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecipientEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companymemberexportjob)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYMEMBEREXPORTJOB_COMPANY");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Companymemberexportjob)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_COMPANYMEMBEREXPORTJOB_FILTER");
            });

            modelBuilder.Entity<Companymovierate>(entity =>
            {
                entity.ToTable("COMPANYMOVIERATE");

                entity.Property(e => e.RatePerMovie).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companymovierate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYMOVIERATE_COMPANY");
            });

            modelBuilder.Entity<Companyreportrecipient>(entity =>
            {
                entity.ToTable("COMPANYREPORTRECIPIENT");

                entity.Property(e => e.IsCsvformat).HasColumnName("IsCSVFormat");

                entity.Property(e => e.LastReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2011))");

                entity.Property(e => e.NotificationEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryFrequencyInDays).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyreportrecipient)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYREPORTRECIPIENT_COMPANY");
            });

            modelBuilder.Entity<Companyshopsalerate>(entity =>
            {
                entity.ToTable("COMPANYSHOPSALERATE");

                entity.Property(e => e.RatePerShopSale).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyshopsalerate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYSHOPSALERATE_COMPANY");
            });

            modelBuilder.Entity<Companyticketingfeerate>(entity =>
            {
                entity.ToTable("COMPANYTICKETINGFEERATE");

                entity.Property(e => e.RatePerTicket).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyticketingfeerate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYTICKETINGFEERATE_COMPANY");
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("COMPETITION");

                entity.HasIndex(e => new { e.IsClosed, e.IsDeleted, e.StartDateTime, e.FinishDateTime, e.IsActive });

                entity.HasIndex(e => new { e.StartDateTime, e.FinishDateTime, e.IsActive, e.IsApproved, e.IsShowOnMainInteractive });

                entity.Property(e => e.CompetitionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.ExternalLinkUrl)
                    .HasColumnName("ExternalLinkURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsGenerateReminders)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainInteractiveTitle).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Competition)
                    .HasForeignKey(d => d.MovieDetailId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_COMPETITION_MOVIEDETAIL");
            });

            modelBuilder.Entity<Competitioncinemas>(entity =>
            {
                entity.HasKey(e => e.CompetitionCinemaId);

                entity.ToTable("COMPETITIONCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Competitioncinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_COMPETITIONCINEMAS_CINEMA");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitioncinemas)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONCINEMAS_COMPETITION");
            });

            modelBuilder.Entity<Competitionentry>(entity =>
            {
                entity.ToTable("COMPETITIONENTRY");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitionentry)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONENTRY_COMPETITION");

                entity.HasOne(d => d.CompetitionPrize)
                    .WithMany(p => p.Competitionentry)
                    .HasForeignKey(d => d.CompetitionPrizeId)
                    .HasConstraintName("FK_COMPETITIONENTRY_COMPETITIONPRIZE");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Competitionentry)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_COMPETITIONENTRY_MEMBER");
            });

            modelBuilder.Entity<Competitionentryanswers>(entity =>
            {
                entity.HasKey(e => e.CompetitionEntryAnswerId);

                entity.ToTable("COMPETITIONENTRYANSWERS");

                entity.Property(e => e.WrittenAnswer).HasMaxLength(1000);

                entity.HasOne(d => d.CompetitionEntry)
                    .WithMany(p => p.Competitionentryanswers)
                    .HasForeignKey(d => d.CompetitionEntryId)
                    .HasConstraintName("FK_COMPETITIONENTRYANSWERS_COMPETITIONENTRY");

                entity.HasOne(d => d.CompetitionQuestion)
                    .WithMany(p => p.Competitionentryanswers)
                    .HasForeignKey(d => d.CompetitionQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETITIONENTRYANSWERS_COMPETITIONQUESTION");

                entity.HasOne(d => d.CompetitionQuestionOption)
                    .WithMany(p => p.Competitionentryanswers)
                    .HasForeignKey(d => d.CompetitionQuestionOptionId)
                    .HasConstraintName("FK_COMPETITIONENTRYANSWERS_COMPETITIONQUESTIONOPTIONS");
            });

            modelBuilder.Entity<Competitionmembertypes>(entity =>
            {
                entity.HasKey(e => e.CompetitionMemberTypeId);

                entity.ToTable("COMPETITIONMEMBERTYPES");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitionmembertypes)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONMEMBERTYPES_COMPETITION");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Competitionmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_COMPETITIONMEMBERTYPES_MEMBERTYPE");
            });

            modelBuilder.Entity<Competitionprize>(entity =>
            {
                entity.ToTable("COMPETITIONPRIZE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TestRecipientEmailAddress).HasMaxLength(150);

                entity.Property(e => e.TextForWinningEmail).IsRequired();

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitionprize)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONPRIZE_COMPETITION");
            });

            modelBuilder.Entity<Competitionquestion>(entity =>
            {
                entity.ToTable("COMPETITIONQUESTION");

                entity.Property(e => e.CompetitionQuestionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer).HasMaxLength(1000);

                entity.Property(e => e.Points).HasDefaultValueSql("((10))");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitionquestion)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONQUESTION_COMPETITION");
            });

            modelBuilder.Entity<Competitionquestionoptions>(entity =>
            {
                entity.HasKey(e => e.CompetitionQuestionOptionId);

                entity.ToTable("COMPETITIONQUESTIONOPTIONS");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CompetitionQuestion)
                    .WithMany(p => p.Competitionquestionoptions)
                    .HasForeignKey(d => d.CompetitionQuestionId)
                    .HasConstraintName("FK_COMPETITIONQUESTIONOPTIONS_COMPETITIONQUESTION");
            });

            modelBuilder.Entity<Competitionwinner>(entity =>
            {
                entity.ToTable("COMPETITIONWINNER");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CompetitionEntry)
                    .WithMany(p => p.Competitionwinner)
                    .HasForeignKey(d => d.CompetitionEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETITIONWINNER_COMPETITIONENTRY");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Competitionwinner)
                    .HasForeignKey(d => d.CompetitionId)
                    .HasConstraintName("FK_COMPETITIONWINNER_COMPETITION");

                entity.HasOne(d => d.CompetitionPrize)
                    .WithMany(p => p.Competitionwinner)
                    .HasForeignKey(d => d.CompetitionPrizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETITIONWINNER_COMPETITIONPRIZE");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("CONTENT");

                entity.Property(e => e.ContentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalFilename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedId)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.ShortGuid)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CONTENT_COMPANY");

                entity.HasOne(d => d.ContentFormat)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.ContentFormatId)
                    .HasConstraintName("FK_CONTENT_CONTENTFORMAT");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTENT_CONTENTTYPE");
            });

            modelBuilder.Entity<Contentformat>(entity =>
            {
                entity.ToTable("CONTENTFORMAT");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contenttype>(entity =>
            {
                entity.ToTable("CONTENTTYPE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.RelatedTable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contenttypeformats>(entity =>
            {
                entity.HasKey(e => e.ContentTypeFormatId);

                entity.ToTable("CONTENTTYPEFORMATS");

                entity.HasOne(d => d.ContentFormat)
                    .WithMany(p => p.Contenttypeformats)
                    .HasForeignKey(d => d.ContentFormatId)
                    .HasConstraintName("FK_CONTENTTYPEFORMATS_CONTENTFORMAT");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Contenttypeformats)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("FK_CONTENTTYPEFORMATS_CONTENTTYPE");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneCountryCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Countrystate>(entity =>
            {
                entity.ToTable("COUNTRYSTATE");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Countrystate)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_COUNTRYSTATE_COUNTRY");
            });

            modelBuilder.Entity<Crmreportrecipient>(entity =>
            {
                entity.ToTable("CRMREPORTRECIPIENT");

                entity.Property(e => e.CrmreportRecipientId).HasColumnName("CRMReportRecipientId");

                entity.Property(e => e.LastReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2011))");

                entity.Property(e => e.NotificationEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryFrequencyInDays).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Crmreportrecipient)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CRMREPORTRECIPIENT_COMPANY");
            });

            modelBuilder.Entity<Crmreportrecipientcinemas>(entity =>
            {
                entity.HasKey(e => e.CrmreportRecipientCinemaId);

                entity.ToTable("CRMREPORTRECIPIENTCINEMAS");

                entity.Property(e => e.CrmreportRecipientCinemaId).HasColumnName("CRMReportRecipientCinemaId");

                entity.Property(e => e.CrmreportRecipientId).HasColumnName("CRMReportRecipientId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Crmreportrecipientcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_CRMREPORTRECIPIENTCINEMAS_CINEMA");

                entity.HasOne(d => d.CrmreportRecipient)
                    .WithMany(p => p.Crmreportrecipientcinemas)
                    .HasForeignKey(d => d.CrmreportRecipientId)
                    .HasConstraintName("FK_CRMREPORTRECIPIENTCINEMAS_CRMREPORTRECIPIENT");
            });

            modelBuilder.Entity<Crmtype>(entity =>
            {
                entity.ToTable("CRMTYPE");

                entity.Property(e => e.CrmtypeId).HasColumnName("CRMTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cronjob>(entity =>
            {
                entity.ToTable("CRONJOB");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Result).HasMaxLength(2000);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Cronjoblog>(entity =>
            {
                entity.ToTable("CRONJOBLOG");

                entity.HasIndex(e => new { e.CronJobLogId, e.Text, e.CronJobId })
                    .HasName("IX_CRonJobLogText");

                entity.Property(e => e.Text).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.CronJob)
                    .WithMany(p => p.Cronjoblog)
                    .HasForeignKey(d => d.CronJobId)
                    .HasConstraintName("FK_CRONJOBLOG_CRONJOB");
            });

            modelBuilder.Entity<Css>(entity =>
            {
                entity.ToTable("CSS");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DesktopCss)
                    .IsRequired()
                    .HasColumnName("DesktopCSS");

                entity.Property(e => e.MobileCss)
                    .IsRequired()
                    .HasColumnName("MobileCSS");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.TabletCss)
                    .IsRequired()
                    .HasColumnName("TabletCSS");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Css)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CSS_COMPANY");
            });

            modelBuilder.Entity<Cssversion>(entity =>
            {
                entity.ToTable("CSSVERSION");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DesktopCss).HasColumnName("DesktopCSS");

                entity.Property(e => e.MobileCss).HasColumnName("MobileCSS");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.TabletCss).HasColumnName("TabletCSS");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Cssversion)
                    .HasForeignKey(d => d.CssId)
                    .HasConstraintName("FK_CSSVersion_CSS");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("DAY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.ToTable("DISTRIBUTOR");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Distributor)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRIBUTOR_COUNTRY");
            });

            modelBuilder.Entity<Drawer>(entity =>
            {
                entity.ToTable("DRAWER");

                entity.Property(e => e.DrawerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('Default')");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Drawer)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_DRAWER_CSS");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Drawer)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DRAWER_SITE");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("EMAIL");

                entity.Property(e => e.EmailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.ContactUrl)
                    .HasColumnName("ContactURL")
                    .HasMaxLength(300);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Error).HasMaxLength(200);

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.FromAddress).HasMaxLength(300);

                entity.Property(e => e.Html)
                    .HasColumnName("HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.ProofDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProofRecipientEmailAddress).HasMaxLength(150);

                entity.Property(e => e.ReferenceDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyToAddress).HasMaxLength(200);

                entity.Property(e => e.ScheduledDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(300);

                entity.Property(e => e.SummaryText).HasMaxLength(200);

                entity.Property(e => e.UnsubscribeUrl)
                    .HasColumnName("UnsubscribeURL")
                    .HasMaxLength(300);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAIL_CINEMA");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAIL_COMPANY");

                entity.HasOne(d => d.EmailStatus)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.EmailStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAIL_EMAILSTATUS");

                entity.HasOne(d => d.EmailType)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.EmailTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAIL_EMAILTYPE");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_EMAIL_FILTER");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAIL_SITE");
            });

            modelBuilder.Entity<Emailarchive>(entity =>
            {
                entity.ToTable("EMAILARCHIVE");

                entity.Property(e => e.CinemaList)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Html)
                    .IsRequired()
                    .HasColumnName("HTML");

                entity.Property(e => e.MessageGearsResponseId).HasMaxLength(70);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailarchive)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILARCHIVE_EMAIL");
            });

            modelBuilder.Entity<Emailcinemas>(entity =>
            {
                entity.HasKey(e => e.EmailCinemaId);

                entity.ToTable("EMAILCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Emailcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_EMAILCINEMAS_CINEMA");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailcinemas)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILCINEMAS_EMAIL");
            });

            modelBuilder.Entity<Emailelement>(entity =>
            {
                entity.ToTable("EMAILELEMENT");

                entity.Property(e => e.EmailElementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.InformationText).HasMaxLength(2000);

                entity.Property(e => e.IsShowOnIndex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkText).HasMaxLength(250);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PassThroughData).HasMaxLength(2000);

                entity.Property(e => e.SubTitle).HasMaxLength(500);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(400);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailelement)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILELEMENT_EMAIL");

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Emailelement)
                    .HasForeignKey(d => d.IncludeElementId)
                    .HasConstraintName("FK_EMAILELEMENT_INCLUDEELEMENT");
            });

            modelBuilder.Entity<Emailemailgroups>(entity =>
            {
                entity.HasKey(e => e.EmailEmailGroupId);

                entity.ToTable("EMAILEMAILGROUPS");

                entity.HasIndex(e => e.EmailId)
                    .HasName("IX_EmailEmailGroupsByEmailId");

                entity.HasOne(d => d.EmailGroup)
                    .WithMany(p => p.Emailemailgroups)
                    .HasForeignKey(d => d.EmailGroupId)
                    .HasConstraintName("FK_EMAILEMAILGROUPS_EMAILGROUP");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailemailgroups)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILEMAILGROUPS_EMAIL");
            });

            modelBuilder.Entity<Emailgeneralsettings>(entity =>
            {
                entity.ToTable("EMAILGENERALSETTINGS");

                entity.Property(e => e.ButtonBackgroundColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Red')");

                entity.Property(e => e.ButtonFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Arial')");

                entity.Property(e => e.ButtonFontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.ButtonFontSize).HasDefaultValueSql("((14))");

                entity.Property(e => e.ButtonPaddingBottom).HasDefaultValueSql("((20))");

                entity.Property(e => e.ButtonPaddingLeft).HasDefaultValueSql("((20))");

                entity.Property(e => e.ButtonPaddingRight).HasDefaultValueSql("((20))");

                entity.Property(e => e.ButtonPaddingTop).HasDefaultValueSql("((20))");

                entity.Property(e => e.ContentBgColor).HasMaxLength(50);

                entity.Property(e => e.EmailBgColor).HasMaxLength(50);

                entity.Property(e => e.GeneralFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Arial')");

                entity.Property(e => e.GeneralFontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.GeneralFontSize).HasDefaultValueSql("((14))");

                entity.Property(e => e.Header1Font)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Arial')");

                entity.Property(e => e.Header1FontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.Header1FontSize).HasDefaultValueSql("((22))");

                entity.Property(e => e.Header2Font)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Arial')");

                entity.Property(e => e.Header2FontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.Header2FontSize).HasDefaultValueSql("((18))");

                entity.Property(e => e.Header3Font)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Arial')");

                entity.Property(e => e.Header3FontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.Header3FontSize).HasDefaultValueSql("((16))");

                entity.Property(e => e.HyperlinkColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Blue')");

                entity.Property(e => e.SectionInternalPaddingBottom).HasDefaultValueSql("((20))");

                entity.Property(e => e.SectionInternalPaddingLeft).HasDefaultValueSql("((20))");

                entity.Property(e => e.SectionInternalPaddingRight).HasDefaultValueSql("((20))");

                entity.Property(e => e.SectionInternalPaddingTop).HasDefaultValueSql("((20))");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailgeneralsettings)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILGENERALSETTINGS_EMAIL");

                entity.HasOne(d => d.EmailTemplateType)
                    .WithMany(p => p.Emailgeneralsettings)
                    .HasForeignKey(d => d.EmailTemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILGENERALSETTINGS_EMAILTEMPLATETYPE");
            });

            modelBuilder.Entity<Emailgroup>(entity =>
            {
                entity.ToTable("EMAILGROUP");

                entity.Property(e => e.EmailGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.IsDisplayed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Emailgroup)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_EMAILGROUP_COMPANY");
            });

            modelBuilder.Entity<Emaillink>(entity =>
            {
                entity.ToTable("EMAILLINK");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emaillink)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILLINK_EMAIL");
            });

            modelBuilder.Entity<Emailmembers>(entity =>
            {
                entity.HasKey(e => e.EmailMemberId);

                entity.ToTable("EMAILMEMBERS");

                entity.HasIndex(e => e.EmailArchiveId)
                    .HasName("IX_EmailMemberByArchiveId");

                entity.HasIndex(e => new { e.EmailMemberId, e.MemberId })
                    .HasName("IX_EMAILMEMBERSMemberId");

                entity.HasIndex(e => new { e.EmailId, e.MemberId, e.EmailArchiveId })
                    .HasName("IX_EMAILMEMBERS_EmailArchiveId_EmailId_MemberId");

                entity.HasIndex(e => new { e.EmailMemberId, e.SentDateTime, e.IsSent, e.EmailArchiveId, e.IsOpened, e.IsBounced, e.EmailId, e.MemberId })
                    .HasName("IX_EmailMembers_All");

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.EmailArchive)
                    .WithMany(p => p.Emailmembers)
                    .HasForeignKey(d => d.EmailArchiveId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EMAILMEMBERS_EMAILARCHIVE");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailmembers)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILMEMBERS_EMAIL");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Emailmembers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_EMAILMEMBERS_MEMBER");
            });

            modelBuilder.Entity<Emailmembertypes>(entity =>
            {
                entity.HasKey(e => e.EmailMemberTypeId);

                entity.ToTable("EMAILMEMBERTYPES");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Emailmembertypes)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_EMAILMEMBERTYPES_EMAIL");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Emailmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_EMAILMEMBERTYPES_MEMBERTYPE");
            });

            modelBuilder.Entity<Emailstatus>(entity =>
            {
                entity.ToTable("EMAILSTATUS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Emailsubjecttemplate>(entity =>
            {
                entity.ToTable("EMAILSUBJECTTEMPLATE");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Emailsubjecttemplate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_EMAILSUBJECTTEMPLATE_COMPANY");
            });

            modelBuilder.Entity<Emailtemplatetype>(entity =>
            {
                entity.ToTable("EMAILTEMPLATETYPE");

                entity.Property(e => e.ButtonBackgroundColor).HasMaxLength(50);

                entity.Property(e => e.ButtonFont).HasMaxLength(50);

                entity.Property(e => e.ButtonFontColor).HasMaxLength(50);

                entity.Property(e => e.ContentBgColor).HasMaxLength(50);

                entity.Property(e => e.Createdatetime).HasColumnType("datetime");

                entity.Property(e => e.EmailBgColor).HasMaxLength(50);

                entity.Property(e => e.GeneralFont).HasMaxLength(50);

                entity.Property(e => e.GeneralFontBold).HasDefaultValueSql("((0))");

                entity.Property(e => e.GeneralFontColor).HasMaxLength(50);

                entity.Property(e => e.GeneralFontItalic).HasDefaultValueSql("((0))");

                entity.Property(e => e.Header1Font).HasMaxLength(50);

                entity.Property(e => e.Header1FontColor).HasMaxLength(50);

                entity.Property(e => e.Header2Font).HasMaxLength(50);

                entity.Property(e => e.Header2FontColor).HasMaxLength(50);

                entity.Property(e => e.Header3Font).HasMaxLength(50);

                entity.Property(e => e.Header3FontColor).HasMaxLength(50);

                entity.Property(e => e.HyperlinkColor).HasMaxLength(50);

                entity.Property(e => e.LastModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Emailtemplatetype)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILTEMPLATETYPE_CINEMA");
            });

            modelBuilder.Entity<Emailtemplatetypeelements>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateTypeElementId);

                entity.ToTable("EMAILTEMPLATETYPEELEMENTS");

                entity.Property(e => e.InformationText).HasMaxLength(2000);

                entity.Property(e => e.IsShowOnIndex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkText).HasMaxLength(250);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PassThroughData).HasMaxLength(2000);

                entity.Property(e => e.SubTitle).HasMaxLength(500);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(400);

                entity.HasOne(d => d.EmailTemplateType)
                    .WithMany(p => p.Emailtemplatetypeelements)
                    .HasForeignKey(d => d.EmailTemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILTEMPLATETYPEELEMENTS_EmailTemplateType");
            });

            modelBuilder.Entity<Emailtype>(entity =>
            {
                entity.ToTable("EMAILTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Facebookcolorscheme>(entity =>
            {
                entity.ToTable("FACEBOOKCOLORSCHEME");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Faqid)
                    .HasColumnName("FAQId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((99))");

                entity.Property(e => e.FaqcategoryId)
                    .HasColumnName("FAQCategoryId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Faqcategory)
                    .WithMany(p => p.Faq)
                    .HasForeignKey(d => d.FaqcategoryId)
                    .HasConstraintName("FK_FAQ_FAQCATEGORY");
            });

            modelBuilder.Entity<Faqcategory>(entity =>
            {
                entity.ToTable("FAQCATEGORY");

                entity.Property(e => e.FaqcategoryId)
                    .HasColumnName("FAQCategoryId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((99))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Faqcategory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FAQCATEGORY_COMPANY");
            });

            modelBuilder.Entity<Faqcinemas>(entity =>
            {
                entity.HasKey(e => e.FaqcinemaId);

                entity.ToTable("FAQCINEMAS");

                entity.Property(e => e.FaqcinemaId).HasColumnName("FAQCinemaId");

                entity.Property(e => e.Faqid).HasColumnName("FAQId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Faqcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_FAQCINEMAS_CINEMA");

                entity.HasOne(d => d.Faq)
                    .WithMany(p => p.Faqcinemas)
                    .HasForeignKey(d => d.Faqid)
                    .HasConstraintName("FK_FAQCINEMAS_FAQ");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("FEATURE");

                entity.Property(e => e.FeatureId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultBillingFrequency).HasDefaultValueSql("((7))");

                entity.Property(e => e.DefaultCasualRatePerWeek).HasColumnType("money");

                entity.Property(e => e.DefaultOngoingRatePerWeek).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsBilledAutomatically)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Featuredmovieelements>(entity =>
            {
                entity.HasKey(e => e.FeaturedMovieElementId);

                entity.ToTable("FEATUREDMOVIEELEMENTS");

                entity.Property(e => e.FinishDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1 May 2018')");

                entity.Property(e => e.PassThroughData).HasMaxLength(500);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1 April 2018')");

                entity.HasOne(d => d.CinemaGroup)
                    .WithMany(p => p.Featuredmovieelements)
                    .HasForeignKey(d => d.CinemaGroupId)
                    .HasConstraintName("FK_FEATUREDMOVIEELEMENTS_CINEMAGROUP");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Featuredmovieelements)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEATUREDMOVIEELEMENTS_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.ToTable("FILTER");

                entity.Property(e => e.FilterId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgeLowerLimit).HasDefaultValueSql("((1))");

                entity.Property(e => e.AgeUpperLimit).HasDefaultValueSql("((99))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ExecuteDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateLowerLimit).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateUpperLimit).HasColumnType("datetime");

                entity.Property(e => e.FilterEmailStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsIncludeMembersWithNoGenrePreferences)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinDateLowerLimit).HasColumnType("datetime");

                entity.Property(e => e.JoinDateUpperLimit).HasColumnType("datetime");

                entity.Property(e => e.LastGeneratedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.MoviePurchaseFilterTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Filter)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FILTER_COMPANY");

                entity.HasOne(d => d.FilterEmailStatus)
                    .WithMany(p => p.Filter)
                    .HasForeignKey(d => d.FilterEmailStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FILTER_FILTEREMAILSTATUS");

                entity.HasOne(d => d.MoviePurchaseFilterType)
                    .WithMany(p => p.Filter)
                    .HasForeignKey(d => d.MoviePurchaseFilterTypeId)
                    .HasConstraintName("FK_FILTER_MOVIEPURCHASEFILTERTYPE");
            });

            modelBuilder.Entity<Filtercinemas>(entity =>
            {
                entity.HasKey(e => e.FilterCinemaId);

                entity.ToTable("FILTERCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Filtercinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_FILTERCINEMAS_CINEMA");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtercinemas)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERCINEMAS_FILTER");
            });

            modelBuilder.Entity<Filtercustomquestionoptions>(entity =>
            {
                entity.HasKey(e => e.FilterCustomQuestionOptionId);

                entity.ToTable("FILTERCUSTOMQUESTIONOPTIONS");

                entity.HasOne(d => d.FilterCustomQuestion)
                    .WithMany(p => p.Filtercustomquestionoptions)
                    .HasForeignKey(d => d.FilterCustomQuestionId)
                    .HasConstraintName("FK_FILTERCUSTOMQUESTIONOPTIONS_FILTERCUSTOMQUESTIONS");
            });

            modelBuilder.Entity<Filtercustomquestions>(entity =>
            {
                entity.HasKey(e => e.FilterCustomQuestionId);

                entity.ToTable("FILTERCUSTOMQUESTIONS");

                entity.Property(e => e.MemberTypeCustomQuestionId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtercustomquestions)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERCUSTOMQUESTIONS_FILTER");
            });

            modelBuilder.Entity<Filteremailgroups>(entity =>
            {
                entity.HasKey(e => e.FilterEmailGroupId);

                entity.ToTable("FILTEREMAILGROUPS");

                entity.HasOne(d => d.EmailGroup)
                    .WithMany(p => p.Filteremailgroups)
                    .HasForeignKey(d => d.EmailGroupId)
                    .HasConstraintName("FK_FILTEREMAILGROUPS_EMAILGROUP");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filteremailgroups)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTEREMAILGROUPS_FILTER");
            });

            modelBuilder.Entity<Filteremailstatus>(entity =>
            {
                entity.ToTable("FILTEREMAILSTATUS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Filtergenders>(entity =>
            {
                entity.HasKey(e => e.FilterGenderId);

                entity.ToTable("FILTERGENDERS");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtergenders)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERGENDERS_FILTER");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Filtergenders)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_FILTERGENDERS_GENDER");
            });

            modelBuilder.Entity<Filtergenrepreferences>(entity =>
            {
                entity.HasKey(e => e.FilterGenrePreferenceId);

                entity.ToTable("FILTERGENREPREFERENCES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtergenrepreferences)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERGENREPREFERENCES_FILTER");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Filtergenrepreferences)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_FILTERGENREPREFERENCES_GENRE");
            });

            modelBuilder.Entity<Filtergenrepurchases>(entity =>
            {
                entity.HasKey(e => e.FilterGenrePurchaseId);

                entity.ToTable("FILTERGENREPURCHASES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtergenrepurchases)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERGENREPURCHASES_FILTER");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Filtergenrepurchases)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_FILTERGENREPURCHASES_GENRE");
            });

            modelBuilder.Entity<Filtermembers>(entity =>
            {
                entity.HasKey(e => e.FilterMemberId);

                entity.ToTable("FILTERMEMBERS");

                entity.HasIndex(e => e.MemberId);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermembers)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMEMBERS_FILTER");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Filtermembers)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FILTERMEMBERS_MEMBER");
            });

            modelBuilder.Entity<Filtermembertype>(entity =>
            {
                entity.ToTable("FILTERMEMBERTYPE");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermembertype)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMEMBERTYPE_FILTER");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Filtermembertype)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_FILTERMEMBERTYPE_MEMBERTYPE");
            });

            modelBuilder.Entity<Filtermoviecategorypurchases>(entity =>
            {
                entity.HasKey(e => e.FilterMovieCategoryPurchaseId);

                entity.ToTable("FILTERMOVIECATEGORYPURCHASES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermoviecategorypurchases)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMOVIECATEGORYPURCHASES_FILTER");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.Filtermoviecategorypurchases)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .HasConstraintName("FK_FILTERMOVIECATEGORYPURCHASES_MOVIECATEGORY");
            });

            modelBuilder.Entity<Filtermovienotpurchases>(entity =>
            {
                entity.HasKey(e => e.FilterMovieNotPurchasedId);

                entity.ToTable("FILTERMOVIENOTPURCHASES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermovienotpurchases)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMOVIENOTPURCHASES_FILTER");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Filtermovienotpurchases)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_FILTERMOVIENOTPURCHASES_MOVIE");
            });

            modelBuilder.Entity<Filtermoviepurchases>(entity =>
            {
                entity.HasKey(e => e.FilterMoviePurchaseId);

                entity.ToTable("FILTERMOVIEPURCHASES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermoviepurchases)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMOVIEPURCHASES_FILTER");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Filtermoviepurchases)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_FILTERMOVIEPURCHASES_MOVIE");
            });

            modelBuilder.Entity<Filtermovietypepurchases>(entity =>
            {
                entity.ToTable("FILTERMOVIETYPEPURCHASES");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.Filtermovietypepurchases)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_FILTERMOVIETYPEPURCHASES_FILTER");
            });

            modelBuilder.Entity<Flag>(entity =>
            {
                entity.ToTable("FLAG");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsShowDailyFlagUnderDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowDailyFlagUnderSession)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnLegend)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OnlineTicketingStartMessage).HasMaxLength(250);

                entity.Property(e => e.TooltipText)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Flag)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FLAG_COMPANY");
            });

            modelBuilder.Entity<Flyer>(entity =>
            {
                entity.ToTable("FLYER");

                entity.Property(e => e.FlyerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DayId).HasDefaultValueSql("((4))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Flyer)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_FLYER_CINEMA");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Flyer)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_FLYER_DAY");

                entity.HasOne(d => d.FlyerType)
                    .WithMany(p => p.Flyer)
                    .HasForeignKey(d => d.FlyerTypeId)
                    .HasConstraintName("FK_FLYER_FLYERTYPE");
            });

            modelBuilder.Entity<Flyerimage>(entity =>
            {
                entity.ToTable("FLYERIMAGE");

                entity.Property(e => e.FlyerImageId).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Flyerimage)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FLYERIMAGE_COMPANY");

                entity.HasOne(d => d.FlyerTypeImagePosition)
                    .WithMany(p => p.Flyerimage)
                    .HasForeignKey(d => d.FlyerTypeImagePositionId)
                    .HasConstraintName("FK_FLYERIMAGE_FLYERTYPEIMAGEPOSITION");
            });

            modelBuilder.Entity<Flyerimagecinemas>(entity =>
            {
                entity.HasKey(e => e.FlyerImageCinemaId);

                entity.ToTable("FLYERIMAGECINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Flyerimagecinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_FLYERIMAGECINEMAS_CINEMA");

                entity.HasOne(d => d.FlyerImage)
                    .WithMany(p => p.Flyerimagecinemas)
                    .HasForeignKey(d => d.FlyerImageId)
                    .HasConstraintName("FK_FLYERIMAGECINEMAS_FLYERIMAGE");
            });

            modelBuilder.Entity<Flyermovieinstances>(entity =>
            {
                entity.HasKey(e => e.FlyerMovieInstanceId);

                entity.ToTable("FLYERMOVIEINSTANCES");

                entity.HasOne(d => d.Flyer)
                    .WithMany(p => p.Flyermovieinstances)
                    .HasForeignKey(d => d.FlyerId)
                    .HasConstraintName("FK_FLYERMOVIEINSTANCES_FLYER");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Flyermovieinstances)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_FLYERMOVIEINSTANCES_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Flyerpageorientation>(entity =>
            {
                entity.ToTable("FLYERPAGEORIENTATION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Flyerpromotions>(entity =>
            {
                entity.HasKey(e => e.FlyerPromotionId);

                entity.ToTable("FLYERPROMOTIONS");

                entity.HasOne(d => d.Flyer)
                    .WithMany(p => p.Flyerpromotions)
                    .HasForeignKey(d => d.FlyerId)
                    .HasConstraintName("FK_FLYERPROMOTIONS_FLYER");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Flyerpromotions)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_FLYERPROMOTIONS_PROMOTION");
            });

            modelBuilder.Entity<Flyertype>(entity =>
            {
                entity.ToTable("FLYERTYPE");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.FlyerPageOrientation)
                    .WithMany(p => p.Flyertype)
                    .HasForeignKey(d => d.FlyerPageOrientationId)
                    .HasConstraintName("FK_FLYERTYPE_FLYERPAGEORIENTATION");
            });

            modelBuilder.Entity<Flyertypeimageposition>(entity =>
            {
                entity.ToTable("FLYERTYPEIMAGEPOSITION");

                entity.Property(e => e.Height).HasDefaultValueSql("((50))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Width).HasDefaultValueSql("((800))");

                entity.HasOne(d => d.FlyerType)
                    .WithMany(p => p.Flyertypeimageposition)
                    .HasForeignKey(d => d.FlyerTypeId)
                    .HasConstraintName("FK_FLYERTYPEIMAGEPOSITION_FLYERTYPE");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("FOOTER");

                entity.Property(e => e.FooterId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FacebookColorSchemeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('Default')");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Footer)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_FOOTER_CSS");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Footer)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FOOTER_SITE");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("FORM");

                entity.Property(e => e.FormId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EmailMessageSubject).HasMaxLength(250);

                entity.Property(e => e.EmailMessageText).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SendingEmailAddress).HasMaxLength(150);

                entity.Property(e => e.SubmitButtonText).HasMaxLength(50);

                entity.Property(e => e.SuccessText).HasMaxLength(500);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Form)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FORM_COMPANY");
            });

            modelBuilder.Entity<Formcinema>(entity =>
            {
                entity.ToTable("FORMCINEMA");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Formcinema)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_FORMCINEMA_CINEMA");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Formcinema)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_FORMCINEMA_FORM");
            });

            modelBuilder.Entity<Formfield>(entity =>
            {
                entity.ToTable("FORMFIELD");

                entity.Property(e => e.FormFieldId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaximumLength).HasDefaultValueSql("((50))");

                entity.Property(e => e.MinorText).HasMaxLength(250);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FormFieldType)
                    .WithMany(p => p.Formfield)
                    .HasForeignKey(d => d.FormFieldTypeId)
                    .HasConstraintName("FK_FORMFIELD_FORMFIELDTYPE");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Formfield)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_FORMFIELD_FORM");
            });

            modelBuilder.Entity<Formfieldoption>(entity =>
            {
                entity.ToTable("FORMFIELDOPTION");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FormField)
                    .WithMany(p => p.Formfieldoption)
                    .HasForeignKey(d => d.FormFieldId)
                    .HasConstraintName("FK_FORMFIELDOPTION_FORMFIELD");
            });

            modelBuilder.Entity<Formfieldtype>(entity =>
            {
                entity.ToTable("FORMFIELDTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fullimagebackground>(entity =>
            {
                entity.ToTable("FULLIMAGEBACKGROUND");

                entity.Property(e => e.FullImageBackgroundId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Fullimagebackground)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FULLIMAGEBACKGROUND_COMPANY");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Fullimagebackground)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FULLIMAGEBACKGROUND_MOVIE");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("GENDER");

                entity.Property(e => e.LanguageId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalutationId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Gender)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GENDER_LANGUAGE");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.Gender)
                    .HasForeignKey(d => d.SalutationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GENDER_SALUTATION");
            });

            modelBuilder.Entity<GenericLogs>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LogText).HasMaxLength(3000);

                entity.Property(e => e.LogType).HasMaxLength(100);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("GENRE");

                entity.Property(e => e.LanguageId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Genre)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GENRE_LANGUAGE");
            });

            modelBuilder.Entity<Globalcss>(entity =>
            {
                entity.ToTable("GLOBALCSS");

                entity.Property(e => e.GlobalCssid).HasColumnName("GlobalCSSId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DesktopCss).HasColumnName("DesktopCSS");

                entity.Property(e => e.EmailCss).HasColumnName("EmailCSS");

                entity.Property(e => e.GlobalCsstext).HasColumnName("GlobalCSSText");

                entity.Property(e => e.MobileCss).HasColumnName("MobileCSS");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.TabletCss).HasColumnName("TabletCSS");
            });

            modelBuilder.Entity<Globalcssversion>(entity =>
            {
                entity.ToTable("GLOBALCSSVERSION");

                entity.Property(e => e.GlobalCssversionId).HasColumnName("GlobalCSSVersionId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DesktopCss).HasColumnName("DesktopCSS");

                entity.Property(e => e.EmailCss).HasColumnName("EmailCSS");

                entity.Property(e => e.GlobalCssid).HasColumnName("GlobalCSSId");

                entity.Property(e => e.GlobalCsstext).HasColumnName("GlobalCSSText");

                entity.Property(e => e.MobileCss).HasColumnName("MobileCSS");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.TabletCss).HasColumnName("TabletCSS");

                entity.HasOne(d => d.GlobalCss)
                    .WithMany(p => p.Globalcssversion)
                    .HasForeignKey(d => d.GlobalCssid)
                    .HasConstraintName("FK_GLOBALCSSVERSION_GLOBALCSS");
            });

            modelBuilder.Entity<Haxlenticketbookingvifprl>(entity =>
            {
                entity.ToTable("HAXLENTICKETBOOKINGVIFPRL");

                entity.Property(e => e.HaxlenTicketBookingVifprlid).HasColumnName("HaxlenTicketBookingVIFPRLId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaxlenTicketBookingViftktid).HasColumnName("HaxlenTicketBookingVIFTKTId");

                entity.Property(e => e.HaxlenTicketingBookingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PriceGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.HaxlenTicketBookingViftkt)
                    .WithMany(p => p.Haxlenticketbookingvifprl)
                    .HasForeignKey(d => d.HaxlenTicketBookingViftktid)
                    .HasConstraintName("FK_HAXLENTICKETBOOKINGVIFPRL_HAXLENTICKETBOOKINGVIFTKT");

                entity.HasOne(d => d.HaxlenTicketingBooking)
                    .WithMany(p => p.Haxlenticketbookingvifprl)
                    .HasForeignKey(d => d.HaxlenTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HAXLENTICKETBOOKINGVIFPRL_HAXLENTICKETINGBOOKING");
            });

            modelBuilder.Entity<Haxlenticketbookingviftkt>(entity =>
            {
                entity.ToTable("HAXLENTICKETBOOKINGVIFTKT");

                entity.Property(e => e.HaxlenTicketBookingViftktid).HasColumnName("HaxlenTicketBookingVIFTKTId");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultPrice).HasColumnType("money");

                entity.Property(e => e.HaxlenTicketingBookingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.HaxlenTicketingBooking)
                    .WithMany(p => p.Haxlenticketbookingviftkt)
                    .HasForeignKey(d => d.HaxlenTicketingBookingId)
                    .HasConstraintName("FK_HAXLENTICKETBOOKINGVIFTKT_HAXLENTICKETINGBOOKING");

                entity.HasOne(d => d.HaxlenTicketingTicketType)
                    .WithMany(p => p.Haxlenticketbookingviftkt)
                    .HasForeignKey(d => d.HaxlenTicketingTicketTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HAXLENTICKETBOOKINGVIFTKT_HAXLENTICKETINGTICKETTYPE");
            });

            modelBuilder.Entity<Haxlenticketingblacklist>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGBLACKLIST");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Haxlenticketingbooking>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGBOOKING");

                entity.Property(e => e.HaxlenTicketingBookingId).ValueGeneratedNever();

                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.CompanyCreditCardTypeId).HasDefaultValueSql("((15))");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumberCvv)
                    .HasColumnName("CreditCardNumberCVV")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIpaddress)
                    .HasColumnName("CustomerIPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErrorText).HasMaxLength(500);

                entity.Property(e => e.EventName).HasMaxLength(50);

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCreditCard)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PriceGroup).HasMaxLength(50);

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.Property(e => e.SessionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionPointOfSaleId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalCostOfBookingFees).HasColumnType("money");

                entity.Property(e => e.TotalCostOfTickets).HasColumnType("money");

                entity.Property(e => e.VifalternateKey)
                    .HasColumnName("VIFAlternateKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingIndex)
                    .HasColumnName("VIFBookingIndex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingKey)
                    .HasColumnName("VIFBookingKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingPin)
                    .HasColumnName("VIFBookingPIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViftransactionNumber)
                    .HasColumnName("VIFTransactionNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Haxlenticketingbooking)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKING_CINEMA");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Haxlenticketingbooking)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKING_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Haxlenticketingbooking)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKING_PAYMENTGATEWAYTRANSACTION");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Haxlenticketingbooking)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKING_SCREEN");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Haxlenticketingbooking)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKING_SESSION");
            });

            modelBuilder.Entity<Haxlenticketingbookinglog>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGBOOKINGLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.HaxlenTicketingBooking)
                    .WithMany(p => p.Haxlenticketingbookinglog)
                    .HasForeignKey(d => d.HaxlenTicketingBookingId)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKINGLOG_HAXLENTICKETINGBOOKING1");
            });

            modelBuilder.Entity<Haxlenticketingbookingreceipt>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGBOOKINGRECEIPT");

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.HasOne(d => d.HaxlenTicketingBooking)
                    .WithMany(p => p.Haxlenticketingbookingreceipt)
                    .HasForeignKey(d => d.HaxlenTicketingBookingId)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKINGRECEIPT_HAXLENTICKETINGBOOKING");
            });

            modelBuilder.Entity<Haxlenticketingbookingtickets>(entity =>
            {
                entity.HasKey(e => e.HaxlenTicketingBookingTicketId);

                entity.ToTable("HAXLENTICKETINGBOOKINGTICKETS");

                entity.Property(e => e.HaxlenTicketingBookingTicketId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.HaxlenTicketBookingVifprlid).HasColumnName("HaxlenTicketBookingVIFPRLId");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicketName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.HaxlenTicketBookingVifprl)
                    .WithMany(p => p.Haxlenticketingbookingtickets)
                    .HasForeignKey(d => d.HaxlenTicketBookingVifprlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKINGTICKETS_HAXLENTICKETBOOKINGVIFPRL");

                entity.HasOne(d => d.HaxlenTicketingBooking)
                    .WithMany(p => p.Haxlenticketingbookingtickets)
                    .HasForeignKey(d => d.HaxlenTicketingBookingId)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKINGTICKETS_HAXLENTICKETINGBOOKING");

                entity.HasOne(d => d.HaxlenTicketingTicketSetting)
                    .WithMany(p => p.Haxlenticketingbookingtickets)
                    .HasForeignKey(d => d.HaxlenTicketingTicketSettingId)
                    .HasConstraintName("FK_HAXLENTICKETINGBOOKINGTICKETS_HAXLENTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Haxlenticketingcreditcardfailurelog>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGCREDITCARDFAILURELOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Haxlenticketingsetting>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGSETTING");

                entity.Property(e => e.HaxlenTicketingSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CashierProfile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('viftest')");

                entity.Property(e => e.CutoffNumberOfMinutes).HasDefaultValueSql("((60))");

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmergencyContactEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactMobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EwayCustomerNumber)
                    .IsRequired()
                    .HasColumnName("EWayCustomerNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReceiptText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTicketSelectionPageItemIntroduction).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextAboveTable).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextBelowTable).HasMaxLength(1000);

                entity.Property(e => e.IsSortedByPrice)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastWorkstationId).HasDefaultValueSql("((1000))");

                entity.Property(e => e.MaximumTicketsPerOrder).HasDefaultValueSql("((10))");

                entity.Property(e => e.MemberLoginIntroductionText).HasMaxLength(2000);

                entity.Property(e => e.MinimumTicketsPerOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.NotAllocatedSessionPopupText).HasMaxLength(1000);

                entity.Property(e => e.SendReceiptFromEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendReceiptFromName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartPageMessage).HasColumnType("ntext");

                entity.Property(e => e.WorkstationIdFrom).HasDefaultValueSql("((1000))");

                entity.Property(e => e.WorkstationIdTo).HasDefaultValueSql("((2000))");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Haxlenticketingsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_HAXLENTICKETINGSETTING_CINEMA");
            });

            modelBuilder.Entity<Haxlenticketingsettingseattype>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGSETTINGSEATTYPE");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HaxlenTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.HaxlenTicketingTicketSetting)
                    .WithMany(p => p.Haxlenticketingsettingseattype)
                    .HasForeignKey(d => d.HaxlenTicketingTicketSettingId)
                    .HasConstraintName("FK_HAXLENTICKETINGSETTINGSEATTYPE_HAXLENTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Haxlenticketingticketsetting>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGTICKETSETTING");

                entity.Property(e => e.HaxlenTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalReceiptTextAfterGenericText)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.AdditionalTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.AdditionalTicketSelectionPageText).HasMaxLength(1500);

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Regular Tickets')");

                entity.Property(e => e.PopUpMessageText)
                    .HasMaxLength(800)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Haxlenticketingticketsettingcheckbox>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGTICKETSETTINGCHECKBOX");

                entity.Property(e => e.HaxlenTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.HaxlenTicketingTicketSetting)
                    .WithMany(p => p.Haxlenticketingticketsettingcheckbox)
                    .HasForeignKey(d => d.HaxlenTicketingTicketSettingId)
                    .HasConstraintName("FK_HAXLENTICKETINGTICKETSETTINGCHECKBOX_HAXLENTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Haxlenticketingticketsettingmembertypes>(entity =>
            {
                entity.HasKey(e => e.HaxlenTicketingTicketSettingMemberTypeId);

                entity.ToTable("HAXLENTICKETINGTICKETSETTINGMEMBERTYPES");

                entity.HasOne(d => d.HaxlenTicketingTicketSetting)
                    .WithMany(p => p.Haxlenticketingticketsettingmembertypes)
                    .HasForeignKey(d => d.HaxlenTicketingTicketSettingId)
                    .HasConstraintName("FK_HAXLENTICKETINGTICKETSETTINGMEMBERTYPES_HAXLENTICKETINGTICKETSETTING");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Haxlenticketingticketsettingmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_HAXLENTICKETINGTICKETSETTINGMEMBERTYPES_MEMBERTYPE");
            });

            modelBuilder.Entity<Haxlenticketingtickettype>(entity =>
            {
                entity.ToTable("HAXLENTICKETINGTICKETTYPE");

                entity.Property(e => e.HaxlenTicketingTicketTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HaxlenTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TicketCodeToMatch)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TicketNameForDisplay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketSelectionItemText).HasMaxLength(500);

                entity.HasOne(d => d.HaxlenTicketingTicketSetting)
                    .WithMany(p => p.Haxlenticketingtickettype)
                    .HasForeignKey(d => d.HaxlenTicketingTicketSettingId)
                    .HasConstraintName("FK_HAXLENTICKETINGTICKETTYPE_HAXLENTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Helpdeskcategory>(entity =>
            {
                entity.ToTable("HELPDESKCATEGORY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Helpdeskcategoryroles>(entity =>
            {
                entity.ToTable("HELPDESKCATEGORYROLES");

                entity.HasOne(d => d.HelpdeskCategory)
                    .WithMany(p => p.Helpdeskcategoryroles)
                    .HasForeignKey(d => d.HelpdeskCategoryId)
                    .HasConstraintName("FK_HELPDESKCATEGORYROLES_HELPDESKCATEGORY");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Helpdeskcategoryroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_HELPDESKCATEGORYROLES_aspnet_Roles");
            });

            modelBuilder.Entity<Helpdeskmessage>(entity =>
            {
                entity.ToTable("HELPDESKMESSAGE");

                entity.HasIndex(e => e.HelpdeskTicketId);

                entity.Property(e => e.HelpdeskMessageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.HelpdeskTicket)
                    .WithMany(p => p.Helpdeskmessage)
                    .HasForeignKey(d => d.HelpdeskTicketId)
                    .HasConstraintName("FK_HELPDESKMESSAGE_HELPDESKTICKET");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Helpdeskmessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HELPDESKMESSAGE_aspnet_Users");
            });

            modelBuilder.Entity<Helpdeskstandardresponse>(entity =>
            {
                entity.ToTable("HELPDESKSTANDARDRESPONSE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.HelpdeskCategory)
                    .WithMany(p => p.Helpdeskstandardresponse)
                    .HasForeignKey(d => d.HelpdeskCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HELPDESKSTANDARDRESPONSE_HELPDESKCATEGORY");

                entity.HasOne(d => d.HelpdeskTicketStatus)
                    .WithMany(p => p.Helpdeskstandardresponse)
                    .HasForeignKey(d => d.HelpdeskTicketStatusId)
                    .HasConstraintName("FK_HELPDESKSTANDARDRESPONSE_HELPDESKTICKETSTATUS");
            });

            modelBuilder.Entity<Helpdeskticket>(entity =>
            {
                entity.ToTable("HELPDESKTICKET");

                entity.HasIndex(e => new { e.IsSolved, e.UserId });

                entity.Property(e => e.HelpdeskTicketId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.HelpdeskTicketNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ImportanceOutOfFive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendSmsonReply).HasColumnName("IsSendSMSOnReply");

                entity.Property(e => e.LastReplyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Helpdeskticket)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_HELPDESKTICKET_COMPANY");

                entity.HasOne(d => d.HelpdeskCategory)
                    .WithMany(p => p.Helpdeskticket)
                    .HasForeignKey(d => d.HelpdeskCategoryId)
                    .HasConstraintName("FK_HELPDESKTICKET_HELPDESKCATEGORY");

                entity.HasOne(d => d.HelpdeskTicketStatus)
                    .WithMany(p => p.Helpdeskticket)
                    .HasForeignKey(d => d.HelpdeskTicketStatusId)
                    .HasConstraintName("FK_HELPDESKTICKET_HELPDESKTICKETSTATUS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Helpdeskticket)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_HELPDESKTICKET_aspnet_Users");
            });

            modelBuilder.Entity<Helpdeskticketstatus>(entity =>
            {
                entity.ToTable("HELPDESKTICKETSTATUS");

                entity.Property(e => e.AdminSortOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserSortOrder).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Htmltemplate>(entity =>
            {
                entity.ToTable("HTMLTEMPLATE");

                entity.Property(x => x.PosTicketTemplate)
                    .HasColumnType("nvarchar(max)");

                entity.Property(x => x.PosReceiptTemplate)
                 .HasColumnType("nvarchar(max)");
            });


            modelBuilder.Entity<Includeelement>(entity =>
            {
                entity.ToTable("INCLUDEELEMENT");

                entity.Property(e => e.IncludeElementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BooleanToggle1Name).HasMaxLength(50);

                entity.Property(e => e.BooleanToggle2Name).HasMaxLength(50);

                entity.Property(e => e.BooleanToggle3Name).HasMaxLength(50);

                entity.Property(e => e.DataRequirements)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DefaultTitle).HasMaxLength(150);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsCacheable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCanDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCanDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCanDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFixedSize)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsGeneric)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LimitName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NumericOption1Name).HasMaxLength(50);

                entity.Property(e => e.NumericOption2Name).HasMaxLength(50);

                entity.Property(e => e.NumericOption3Name).HasMaxLength(50);

                entity.Property(e => e.UserControlFileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Includeelement)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_INCLUDEELEMENT_CONTENTTYPE");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Includeelement)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_INCLUDEELEMENT_CSS");

                entity.HasOne(d => d.IncludeElementType)
                    .WithMany(p => p.Includeelement)
                    .HasForeignKey(d => d.IncludeElementTypeId)
                    .HasConstraintName("FK_INCLUDEELEMENT_INCLUDEELEMENTTYPE");
            });

            modelBuilder.Entity<Includeelementinstance>(entity =>
            {
                entity.ToTable("INCLUDEELEMENTINSTANCE");

                entity.HasIndex(e => e.CssId);

                entity.HasIndex(e => new { e.RelatedId, e.IsDeleted });

                entity.HasIndex(e => new { e.RelatedId, e.IsDeleted, e.IsConfigured });

                entity.HasIndex(e => new { e.IsDisplayOnDesktop, e.IsConfigured, e.RelatedId, e.IsDeleted });

                entity.HasIndex(e => new { e.IsDisplayOnMobile, e.IsConfigured, e.RelatedId, e.IsDeleted });

                entity.HasIndex(e => new { e.IsDisplayOnTablet, e.IsConfigured, e.RelatedId, e.IsDeleted });

                entity.Property(e => e.Anchor).HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrderDesktop).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderMobile).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderTablet).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnIndex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkText).HasMaxLength(250);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PageTemplateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RelatedId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteHomePageTabId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_CSS");

                entity.HasOne(d => d.Drawer)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.DrawerId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_DRAWER");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_EMAIL");

                entity.HasOne(d => d.Footer)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.FooterId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_FOOTER");

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.IncludeElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_INCLUDEELEMENT");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_MOVIETYPE");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_PAGE");

                entity.HasOne(d => d.PageTemplate)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.PageTemplateId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_PAGETEMPLATE");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_PROMOTION");

                entity.HasOne(d => d.Sidebar)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.SidebarId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_SIDEBAR");

                entity.HasOne(d => d.SiteHomePageTab)
                    .WithMany(p => p.Includeelementinstance)
                    .HasForeignKey(d => d.SiteHomePageTabId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCE_SITEHOMEPAGETAB");
            });

            modelBuilder.Entity<Includeelementinstancecinemas>(entity =>
            {
                entity.HasKey(e => e.IncludeElementInstanceCinemaId);

                entity.ToTable("INCLUDEELEMENTINSTANCECINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Includeelementinstancecinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCECINEMAS_CINEMA");

                entity.HasOne(d => d.IncludeElementInstance)
                    .WithMany(p => p.Includeelementinstancecinemas)
                    .HasForeignKey(d => d.IncludeElementInstanceId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCECINEMAS_INCLUDEELEMENTINSTANCE");
            });

            modelBuilder.Entity<Includeelementinstancemembertypes>(entity =>
            {
                entity.HasKey(e => e.IncludeElementInstanceMemberTypeId);

                entity.ToTable("INCLUDEELEMENTINSTANCEMEMBERTYPES");

                entity.HasOne(d => d.IncludeElementInstance)
                    .WithMany(p => p.Includeelementinstancemembertypes)
                    .HasForeignKey(d => d.IncludeElementInstanceId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCEMEMBERTYPES_INCLUDEELEMENTINSTANCE");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Includeelementinstancemembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCEMEMBERTYPES_MEMBERTYPE");
            });

            modelBuilder.Entity<Includeelementinstanceversion>(entity =>
            {
                entity.ToTable("INCLUDEELEMENTINSTANCEVERSION");

                entity.HasIndex(e => e.IncludeElementInstanceId);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnIndex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkText).HasMaxLength(250);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.IncludeElementInstance)
                    .WithMany(p => p.Includeelementinstanceversion)
                    .HasForeignKey(d => d.IncludeElementInstanceId)
                    .HasConstraintName("FK_INCLUDEELEMENTINSTANCEVERSION_INCLUDEELEMENTINSTANCE");
            });

            modelBuilder.Entity<Includeelementsites>(entity =>
            {
                entity.HasKey(e => e.IncludeElementSiteId);

                entity.ToTable("INCLUDEELEMENTSITES");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Includeelementsites)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_INCLUDEELEMENTSITES_CSS");

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Includeelementsites)
                    .HasForeignKey(d => d.IncludeElementId)
                    .HasConstraintName("FK_INCLUDEELEMENTSITES_INCLUDEELEMENT");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Includeelementsites)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_INCLUDEELEMENTSITES_SITE");
            });

            modelBuilder.Entity<Includeelementtype>(entity =>
            {
                entity.ToTable("INCLUDEELEMENTTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Informationsite>(entity =>
            {
                entity.ToTable("INFORMATIONSITE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Internetticketingtype>(entity =>
            {
                entity.ToTable("INTERNETTICKETINGTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("INVOICE");

                entity.Property(e => e.InvoiceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaasuInvoiceUid).HasColumnName("SaasuInvoiceUId");
            });

            modelBuilder.Entity<Ktixbooking>(entity =>
            {
                entity.ToTable("KTIXBOOKING");

                entity.HasIndex(e => new { e.KtixSessionId, e.IsCommitted })
                    .HasName("IX_KTIXBOOKINGBySession");

                entity.Property(e => e.KtixBookingId)
                    .HasColumnName("KTixBookingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.BookingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCreditCardTypeId).HasDefaultValueSql("((15))");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumberCvv)
                    .HasColumnName("CreditCardNumberCVV")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIpaddress)
                    .HasColumnName("CustomerIPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorText).HasMaxLength(500);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.Property(e => e.KtixSessionId).HasColumnName("KTixSessionId");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCreditCard)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.Property(e => e.SessionDateTime).HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalCostOfBookingFees).HasColumnType("money");

                entity.Property(e => e.TotalCostOfItems).HasColumnType("money");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXBOOKING_CINEMA");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_KTIXBOOKING_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.KtixPriceGroup)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.KtixPriceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXBOOKING_KTIXPRICEGROUP");

                entity.HasOne(d => d.KtixSession)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.KtixSessionId)
                    .HasConstraintName("FK_KTIXBOOKING_KTIXSESSION");

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.KtixSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXBOOKING_KTIXSETTING");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_KTIXBOOKING_MEMBER");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_KTIXBOOKING_PAYMENTGATEWAYTRANSACTION");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXBOOKING_SCREEN");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Ktixbooking)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_KTIXBOOKING_SESSION");
            });

            modelBuilder.Entity<Ktixbookingcomboitems>(entity =>
            {
                entity.HasKey(e => e.KtixBookingComboItemId);

                entity.ToTable("KTIXBOOKINGCOMBOITEMS");

                entity.Property(e => e.KtixBookingComboItemId).HasColumnName("KTixBookingComboItemId");

                entity.Property(e => e.KtixBookingId).HasColumnName("KTixBookingId");

                entity.Property(e => e.KtixPriceGroupComboItemId).HasColumnName("KTixPriceGroupComboItemId");

                entity.HasOne(d => d.KtixBooking)
                    .WithMany(p => p.Ktixbookingcomboitems)
                    .HasForeignKey(d => d.KtixBookingId)
                    .HasConstraintName("FK_KTIXBOOKINGCOMBOITEMS_KTIXBOOKING");

                entity.HasOne(d => d.KtixPriceGroupComboItem)
                    .WithMany(p => p.Ktixbookingcomboitems)
                    .HasForeignKey(d => d.KtixPriceGroupComboItemId)
                    .HasConstraintName("FK_KTIXBOOKINGCOMBOITEMS_KTIXPRICEGROUPCOMBOITEMS");
            });

            modelBuilder.Entity<Ktixbookinglog>(entity =>
            {
                entity.ToTable("KTIXBOOKINGLOG");

                entity.HasIndex(e => e.KtixBookingId);

                entity.Property(e => e.KtixBookingLogId).HasColumnName("KTixBookingLogId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.KtixBookingId).HasColumnName("KTixBookingId");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.KtixBooking)
                    .WithMany(p => p.Ktixbookinglog)
                    .HasForeignKey(d => d.KtixBookingId)
                    .HasConstraintName("FK_KTIXBOOKINGLOG_KTIXBOOKING");
            });

            modelBuilder.Entity<Ktixbookingsaleitems>(entity =>
            {
                entity.HasKey(e => e.KtixBookingSaleItemId);

                entity.ToTable("KTIXBOOKINGSALEITEMS");

                entity.HasIndex(e => e.KtixBookingId)
                    .HasName("IX_KtixBookingSaleItemByBookingId");

                entity.Property(e => e.KtixBookingSaleItemId).HasColumnName("KTixBookingSaleItemId");

                entity.Property(e => e.KtixBookingId).HasColumnName("KTixBookingId");

                entity.Property(e => e.KtixBookingVoucherId).HasColumnName("KTixBookingVoucherId");

                entity.Property(e => e.KtixPriceGroupSaleItemId).HasColumnName("KTixPriceGroupSaleItemId");

                entity.HasOne(d => d.KtixBooking)
                    .WithMany(p => p.Ktixbookingsaleitems)
                    .HasForeignKey(d => d.KtixBookingId)
                    .HasConstraintName("FK_KTIXBOOKINGSALEITEMS_KTIXBOOKING");

                entity.HasOne(d => d.KtixBookingVoucher)
                    .WithMany(p => p.Ktixbookingsaleitems)
                    .HasForeignKey(d => d.KtixBookingVoucherId)
                    .HasConstraintName("FK_KTIXBOOKINGSALEITEMS_KTIXBOOKINGVOUCHERS");

                entity.HasOne(d => d.KtixPriceGroupSaleItem)
                    .WithMany(p => p.Ktixbookingsaleitems)
                    .HasForeignKey(d => d.KtixPriceGroupSaleItemId)
                    .HasConstraintName("FK_KTIXBOOKINGSALEITEMS_KTIXPRICEGROUPSALEITEMS");
            });

            modelBuilder.Entity<Ktixbookingvouchers>(entity =>
            {
                entity.HasKey(e => e.KtixBookingVoucherId);

                entity.ToTable("KTIXBOOKINGVOUCHERS");

                entity.Property(e => e.KtixBookingVoucherId).HasColumnName("KTixBookingVoucherId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.KtixBookingId).HasColumnName("KTixBookingId");

                entity.Property(e => e.KtixVoucherId)
                    .HasColumnName("KTixVoucherId")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.KtixBooking)
                    .WithMany(p => p.Ktixbookingvouchers)
                    .HasForeignKey(d => d.KtixBookingId)
                    .HasConstraintName("FK_KTIXBOOKINGVOUCHERS_KTIXBOOKING");

                entity.HasOne(d => d.KtixVoucher)
                    .WithMany(p => p.Ktixbookingvouchers)
                    .HasForeignKey(d => d.KtixVoucherId)
                    .HasConstraintName("FK_KTIXBOOKINGVOUCHERS_KTIXVOUCHER");
            });

            modelBuilder.Entity<Ktixcomboitem>(entity =>
            {
                entity.ToTable("KTIXCOMBOITEM");

                entity.Property(e => e.KtixComboItemId)
                    .HasColumnName("KTixComboItemId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultBookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultPrice).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.KtixItemGroupId).HasColumnName("KTixItemGroupId");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.KtixItemGroup)
                    .WithMany(p => p.Ktixcomboitem)
                    .HasForeignKey(d => d.KtixItemGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXCOMBOITEM_KTIXITEMGROUP");

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixcomboitem)
                    .HasForeignKey(d => d.KtixSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXCOMBOITEM_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixcomboitemsaleitems>(entity =>
            {
                entity.HasKey(e => e.KtixComboSaleItemId);

                entity.ToTable("KTIXCOMBOITEMSALEITEMS");

                entity.Property(e => e.KtixComboSaleItemId).HasColumnName("KTixComboSaleItemId");

                entity.Property(e => e.KtixComboItemId).HasColumnName("KTixComboItemId");

                entity.Property(e => e.KtixSaleItemId).HasColumnName("KTixSaleItemId");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.KtixComboItem)
                    .WithMany(p => p.Ktixcomboitemsaleitems)
                    .HasForeignKey(d => d.KtixComboItemId)
                    .HasConstraintName("FK_KTIXCOMBOITEMSALEITEMS_KTIXCOMBOITEM");
            });

            modelBuilder.Entity<Ktixgiftcard>(entity =>
            {
                entity.ToTable("KTIXGIFTCARD");

                entity.Property(e => e.KtixGiftCardId).ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GiftCardNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CurrentStateNavigation)
                    .WithMany(p => p.Ktixgiftcard)
                    .HasForeignKey(d => d.CurrentState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXGIFTCARD_KTIXGIFTCARD");
            });

            modelBuilder.Entity<Ktixgiftcardstate>(entity =>
            {
                entity.ToTable("KTIXGIFTCARDSTATE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ktixitemgroup>(entity =>
            {
                entity.ToTable("KTIXITEMGROUP");

                entity.Property(e => e.KtixItemGroupId)
                    .HasColumnName("KTixItemGroupId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Introduction).HasMaxLength(1000);

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixitemgroup)
                    .HasForeignKey(d => d.KtixSettingId)
                    .HasConstraintName("FK_KTIXSALEITEMGROUP_KTIXSETTING1");
            });

            modelBuilder.Entity<Ktixkioskcategory>(entity =>
            {
                entity.ToTable("KTIXKIOSKCATEGORY");

                entity.Property(e => e.KtixKioskCategoryId)
                    .HasColumnName("KTixKioskCategoryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Introduction).HasMaxLength(1000);

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixkioskcategory)
                    .HasForeignKey(d => d.KtixSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXKIOSKCATEGORY_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixkioskorder>(entity =>
            {
                entity.ToTable("KTIXKIOSKORDER");

                entity.Property(e => e.KtixKioskOrderId)
                    .HasColumnName("KTixKioskOrderId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorText).HasMaxLength(500);

                entity.Property(e => e.TotalCostOfKioskItems).HasColumnType("money");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixkioskorder)
                    .HasForeignKey(d => d.KtixSettingId)
                    .HasConstraintName("FK_KTIXKIOSKORDER_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixkioskordersaleitem>(entity =>
            {
                entity.ToTable("KTIXKIOSKORDERSALEITEM");

                entity.Property(e => e.KtixKioskOrderSaleItemId).HasColumnName("KTixKioskOrderSaleItemId");

                entity.Property(e => e.KtixKioskOrderId).HasColumnName("KTixKioskOrderId");

                entity.Property(e => e.KtixKioskSaleItemId).HasColumnName("KTixKioskSaleItemId");

                entity.HasOne(d => d.KtixKioskOrder)
                    .WithMany(p => p.Ktixkioskordersaleitem)
                    .HasForeignKey(d => d.KtixKioskOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXKIOSKORDERSALEITEM_KTIXKIOSKORDER");

                entity.HasOne(d => d.KtixKioskSaleItem)
                    .WithMany(p => p.Ktixkioskordersaleitem)
                    .HasForeignKey(d => d.KtixKioskSaleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXKIOSKORDERSALEITEM_KTIXKIOSKSALEITEM");
            });

            modelBuilder.Entity<Ktixkiosksaleitem>(entity =>
            {
                entity.ToTable("KTIXKIOSKSALEITEM");

                entity.Property(e => e.KtixKioskSaleItemId)
                    .HasColumnName("KTixKioskSaleItemId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultPrice).HasColumnType("money");

                entity.Property(e => e.KtixKioskCategoryId).HasColumnName("KTixKioskCategoryId");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.HasOne(d => d.KtixKioskCategory)
                    .WithMany(p => p.Ktixkiosksaleitem)
                    .HasForeignKey(d => d.KtixKioskCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXKIOSKSALEITEM_KTIXKIOSKCATEGORY");

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixkiosksaleitem)
                    .HasForeignKey(d => d.KtixSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXKIOSKSALEITEM_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixmasterpaymenttype>(entity =>
            {
                entity.ToTable("KTIXMASTERPAYMENTTYPE");

                entity.Property(e => e.KtixMasterPaymentTypeId);

                entity.Property(e => e.CashPaidAmount).HasColumnType("money");

                entity.Property(e => e.CreditCardCardPaidAmount).HasColumnType("money");

                entity.Property(e => e.CreditCardGatewayTransactionNumber).HasMaxLength(500);

                entity.Property(e => e.BankAuthCode).HasMaxLength(500);

                entity.Property(e => e.ResponseCode).HasMaxLength(500);

                entity.Property(e => e.CashReturnedAmount).HasColumnType("money");


                entity.Property(e => e.GiftCardClosingBalance).HasColumnType("money");

                entity.Property(e => e.GiftCardNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GiftCardPaymentAmount).HasColumnType("money");

                entity.Property(e => e.GiftCardStartingBalance).HasColumnType("money");

                entity.HasOne(d => d.KtixGiftCard)
                    .WithMany(p => p.Ktixmasterpaymenttype)
                    .HasForeignKey(d => d.KtixGiftCardId)
                    .HasConstraintName("FK_KTIXBOOKINGPAYMENTTYPE_KTIXGIFTCARD");

                entity.HasOne(d => d.KtixMasterTransaction)
                    .WithMany(p => p.Ktixmasterpaymenttype)
                    .HasForeignKey(d => d.KtixMasterTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXMASTERPAYMENTTYPE_KTIXMASTERPAYMENTTYPE");

                entity.HasOne(d => d.KtixPaymentType)
                    .WithMany(p => p.Ktixmasterpaymenttype)
                    .HasForeignKey(d => d.KtixPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXSALEPAYMENTTYPE_KTIXPAYMENTTYPE");
            });

            modelBuilder.Entity<Ktixmastertransaction>(entity =>
            {
                entity.ToTable("KTIXMASTERTRANSACTION");

                entity.Property(e => e.KtixMasterTransactionId)
                    .HasColumnName("KTixMasterTransactionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.Property(e => e.ErrorMessage).HasMaxLength(500);

                entity.Property(e => e.KtixBookingId).HasColumnName("KTixBookingId");

                entity.Property(e => e.KtixKioskOrderId).HasColumnName("KTixKioskOrderId");

                entity.Property(e => e.KtixPosTerminalId).HasColumnName("KTixPosTerminalId");

                entity.Property(e => e.KtixTransactionCartId).HasColumnName("KTixTransactionCartId");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.RefundedMessage).HasMaxLength(500);

                entity.Property(e => e.TotalCostOfBooking).HasColumnType("money");

                entity.Property(e => e.TotalCostOfKioskOrder).HasColumnType("money");

                entity.Property(e => e.TotalCostOfTransaction).HasColumnType("money");

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Ktixmastertransaction)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_KTIXMASTERTRANSACTION_CMSUSER");

                entity.HasOne(d => d.KtixBooking)
                    .WithMany(p => p.Ktixmastertransaction)
                    .HasForeignKey(d => d.KtixBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXMASTERTRANSACTION_KTIXBOOKING");

                entity.HasOne(d => d.KtixKioskOrder)
                    .WithMany(p => p.Ktixmastertransaction)
                    .HasForeignKey(d => d.KtixKioskOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXMASTERTRANSACTION_KTIXKIOSKORDER");

                entity.HasOne(d => d.KtixPosTerminal)
                    .WithMany(p => p.Ktixmastertransaction)
                    .HasForeignKey(d => d.KtixPosTerminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXMASTERTRANSACTION_KTIXPOSTERMINAL");

                entity.HasOne(d => d.KtixTransactionCart)
                    .WithMany(p => p.Ktixmastertransaction)
                    .HasForeignKey(d => d.KtixTransactionCartId)
                    .HasConstraintName("FK_KTIXMASTERTRANSACTION_KTIXTRANSACTIONCART");
            });

            modelBuilder.Entity<Ktixpaymenttype>(entity =>
            {
                entity.ToTable("KTIXPAYMENTTYPE");

                entity.Property(e => e.KtixpaymentTypeId).HasColumnName("KTIXPaymentTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ktixposterminal>(entity =>
            {
                entity.ToTable("KTIXPOSTERMINAL");

                entity.Property(e => e.KtixPosTerminalId)
                    .HasColumnName("KTixPosTerminalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApiendPoint)
                    .HasColumnName("APIEndPoint")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceId).HasMaxLength(50);

                entity.Property(e => e.DeviceModel).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.KtixDescription)
                    .HasColumnName("KTixDescription")
                    .HasMaxLength(200);

                entity.Property(e => e.KtixPosUseTypeId).HasColumnName("KTixPosUseTypeId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Ktixposterminal)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXPOSTERMINAL_CINEMA");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Ktixposterminal)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXPOSTERMINAL_COMPANY");

                entity.HasOne(d => d.KtixPosUseType)
                    .WithMany(p => p.Ktixposterminal)
                    .HasForeignKey(d => d.KtixPosUseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXPOSTERMINAL_KTIXPOSUSETYPE");
            });

            modelBuilder.Entity<Ktixposusetype>(entity =>
            {
                entity.ToTable("KTIXPOSUSETYPE");

                entity.Property(e => e.KtixPosUseTypeId).HasColumnName("KTixPosUseTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ktixpricegroup>(entity =>
            {
                entity.ToTable("KTIXPRICEGROUP");

                entity.Property(e => e.KtixPriceGroupId)
                    .HasColumnName("KTixPriceGroupId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsAllowTransferDestination)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixpricegroup)
                    .HasForeignKey(d => d.KtixSettingId)
                    .HasConstraintName("FK_KTIXPRICEGROUP_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixpricegroupcomboitems>(entity =>
            {
                entity.HasKey(e => e.KtixPriceGroupComboItemId);

                entity.ToTable("KTIXPRICEGROUPCOMBOITEMS");

                entity.Property(e => e.KtixPriceGroupComboItemId).HasColumnName("KTixPriceGroupComboItemId");

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KtixComboItemId).HasColumnName("KTixComboItemId");

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.Property(e => e.NumberAvailablePerSession).HasDefaultValueSql("((999))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.KtixComboItem)
                    .WithMany(p => p.Ktixpricegroupcomboitems)
                    .HasForeignKey(d => d.KtixComboItemId)
                    .HasConstraintName("FK_KTIXPRICEGROUPCOMBOITEMS_KTIXCOMBOITEM");

                entity.HasOne(d => d.KtixPriceGroup)
                    .WithMany(p => p.Ktixpricegroupcomboitems)
                    .HasForeignKey(d => d.KtixPriceGroupId)
                    .HasConstraintName("FK_KTIXPRICEGROUPCOMBOITEMS_KTIXPRICEGROUP");
            });

            modelBuilder.Entity<Ktixpricegroupsaleitems>(entity =>
            {
                entity.HasKey(e => e.KtixPriceGroupSaleItemId);

                entity.ToTable("KTIXPRICEGROUPSALEITEMS");

                entity.Property(e => e.KtixPriceGroupSaleItemId).HasColumnName("KTixPriceGroupSaleItemId");

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsListed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.Property(e => e.KtixSaleItemId)
                    .HasColumnName("KTixSaleItemId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NumberAvailablePerSession).HasDefaultValueSql("((999))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.KtixPriceGroup)
                    .WithMany(p => p.Ktixpricegroupsaleitems)
                    .HasForeignKey(d => d.KtixPriceGroupId)
                    .HasConstraintName("FK_KTIXPRICEGROUPSALEITEMS_KTIXPRICEGROUP");

                entity.HasOne(d => d.KtixSaleItem)
                    .WithMany(p => p.Ktixpricegroupsaleitems)
                    .HasForeignKey(d => d.KtixSaleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXPRICEGROUPSALEITEMS_KTIXSALEITEM");
            });

            modelBuilder.Entity<Ktixpricegroupvouchertypes>(entity =>
            {
                entity.HasKey(e => e.KtixPriceGroupVoucherTypeId);

                entity.ToTable("KTIXPRICEGROUPVOUCHERTYPES");

                entity.Property(e => e.KtixPriceGroupVoucherTypeId).HasColumnName("KTixPriceGroupVoucherTypeId");

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.Property(e => e.KtixVoucherTypeId).HasColumnName("KTixVoucherTypeId");

                entity.HasOne(d => d.KtixPriceGroup)
                    .WithMany(p => p.Ktixpricegroupvouchertypes)
                    .HasForeignKey(d => d.KtixPriceGroupId)
                    .HasConstraintName("FK_KTIXPRICEGROUPVOUCHERTYPES_KTIXPRICEGROUP");

                entity.HasOne(d => d.KtixVoucherType)
                    .WithMany(p => p.Ktixpricegroupvouchertypes)
                    .HasForeignKey(d => d.KtixVoucherTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXPRICEGROUPVOUCHERTYPES_KTIXVOUCHERTYPE");
            });

            modelBuilder.Entity<Ktixsaleitem>(entity =>
            {
                entity.ToTable("KTIXSALEITEM");

                entity.Property(e => e.KtixSaleItemId)
                    .HasColumnName("KTixSaleItemId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultBookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultPrice).HasColumnType("money");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KtixItemGroupId).HasColumnName("KTixItemGroupId");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.MasterKtixSaleItemId).HasColumnName("MasterKTixSaleItemId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.KtixItemGroup)
                    .WithMany(p => p.Ktixsaleitem)
                    .HasForeignKey(d => d.KtixItemGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXSALEITEM_KTIXSALEITEMGROUP");
            });

            modelBuilder.Entity<Ktixsession>(entity =>
            {
                entity.ToTable("KTIXSESSION");

                entity.Property(e => e.KtixSessionId).HasColumnName("KTixSessionId");

                entity.Property(e => e.CancellationReason).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.HasOne(d => d.KtixPriceGroup)
                    .WithMany(p => p.Ktixsession)
                    .HasForeignKey(d => d.KtixPriceGroupId)
                    .HasConstraintName("FK_KTIXSESSION_KTIXPRICEGROUP");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Ktixsession)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_KTIXSESSION_SESSION");
            });

            modelBuilder.Entity<Ktixsessionsaleitemoverride>(entity =>
            {
                entity.ToTable("KTIXSESSIONSALEITEMOVERRIDE");

                entity.Property(e => e.KtixsessionSaleItemOverrideId).HasColumnName("KTIXSessionSaleItemOverrideId");

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.KtixPriceGroupId).HasColumnName("KTixPriceGroupId");

                entity.Property(e => e.KtixSaleItemId).HasColumnName("KTixSaleItemId");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.KtixSaleItem)
                    .WithMany(p => p.Ktixsessionsaleitemoverride)
                    .HasForeignKey(d => d.KtixSaleItemId)
                    .HasConstraintName("FK_KTIXSESSIONSALEITEMOVERRIDE_KTIXSALEITEM");
            });

            modelBuilder.Entity<Ktixsetting>(entity =>
            {
                entity.ToTable("KTIXSETTING");

                entity.Property(e => e.KtixSettingId)
                    .HasColumnName("KTixSettingId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CutoffNumberOfMinutes).HasDefaultValueSql("((60))");

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmergencyContactEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactMobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReceiptText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.IsSortedByPrice)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaximumTicketsPerOrder).HasDefaultValueSql("((10))");

                entity.Property(e => e.MinimumTicketsPerOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.MobileIntroduction).HasMaxLength(500);

                entity.Property(e => e.MobileReceiptText)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'Present your phone at the boxoffice to collect your tickets.')");

                entity.Property(e => e.SendReceiptFromEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendReceiptFromName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartPageMessage).HasMaxLength(1000);

                entity.Property(e => e.VoucherRedemptionInstructions).HasMaxLength(1000);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Ktixsetting)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXSETTING_COMPANY");
            });

            modelBuilder.Entity<Ktixsettingcheckbox>(entity =>
            {
                entity.ToTable("KTIXSETTINGCHECKBOX");

                entity.Property(e => e.KtixSettingCheckBoxId).HasColumnName("KTixSettingCheckBoxId");

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixsettingcheckbox)
                    .HasForeignKey(d => d.KtixSettingId)
                    .HasConstraintName("FK_KTIXSETTINGCHECKBOX_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixtransactioncart>(entity =>
            {
                entity.ToTable("KTIXTRANSACTIONCART");

                entity.Property(e => e.KtixTransactionCartId).HasColumnName("KTixTransactionCartId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ktixtransactioncartitems>(entity =>
            {
                entity.ToTable("KTIXTRANSACTIONCARTITEMS");

                entity.Property(e => e.KtixTransactionCartItemsId).HasColumnName("KTixTransactionCartItemsId");

                entity.Property(e => e.KtixKioskSaleItemId).HasColumnName("KTixKioskSaleItemId");

                entity.Property(e => e.KtixPriceGroupComboItemId).HasColumnName("KTixPriceGroupComboItemId");

                entity.Property(e => e.KtixPriceGroupSaleItemId).HasColumnName("KTixPriceGroupSaleItemId");

                entity.Property(e => e.KtixTransactionCartId).HasColumnName("KTixTransactionCartId");

                entity.Property(e => e.KtixVoucherId).HasColumnName("KTixVoucherId");

                entity.HasOne(d => d.KtixKioskSaleItem)
                    .WithMany(p => p.Ktixtransactioncartitems)
                    .HasForeignKey(d => d.KtixKioskSaleItemId)
                    .HasConstraintName("FK_KTIXTRANSACTIONCARTITEMS_KTIXKIOSKSALEITEM");

                entity.HasOne(d => d.KtixPriceGroupComboItem)
                    .WithMany(p => p.Ktixtransactioncartitems)
                    .HasForeignKey(d => d.KtixPriceGroupComboItemId)
                    .HasConstraintName("FK_KTIXTRANSACTIONCARTITEMS_KTIXPRICEGROUPCOMBOITEMS");

                entity.HasOne(d => d.KtixPriceGroupSaleItem)
                    .WithMany(p => p.Ktixtransactioncartitems)
                    .HasForeignKey(d => d.KtixPriceGroupSaleItemId)
                    .HasConstraintName("FK_KTIXTRANSACTIONCARTITEMS_KTIXPRICEGROUPSALEITEMS");

                entity.HasOne(d => d.KtixTransactionCart)
                    .WithMany(p => p.Ktixtransactioncartitems)
                    .HasForeignKey(d => d.KtixTransactionCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXTRANSACTIONCARTITEMS_KTIXTRANSACTIONCART");

                entity.HasOne(d => d.KtixVoucher)
                    .WithMany(p => p.Ktixtransactioncartitems)
                    .HasForeignKey(d => d.KtixVoucherId)
                    .HasConstraintName("FK_KTIXTRANSACTIONCARTITEMS_KTIXVOUCHER");
            });

            modelBuilder.Entity<Ktixvoucher>(entity =>
            {
                entity.ToTable("KTIXVOUCHER");

                entity.Property(e => e.KtixVoucherId)
                    .HasColumnName("KTixVoucherId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.KtixVoucherTypeId)
                    .HasColumnName("KTixVoucherTypeId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasColumnName("PIN")
                    .HasMaxLength(8);

                entity.Property(e => e.PurchaseDateTime).HasColumnType("datetime");

                entity.Property(e => e.RedemptionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.KtixVoucherType)
                    .WithMany(p => p.Ktixvoucher)
                    .HasForeignKey(d => d.KtixVoucherTypeId)
                    .HasConstraintName("FK_KTIXVOUCHER_KTIXVOUCHERTYPE");
            });

            modelBuilder.Entity<Ktixvouchertype>(entity =>
            {
                entity.ToTable("KTIXVOUCHERTYPE");

                entity.Property(e => e.KtixVoucherTypeId)
                    .HasColumnName("KTixVoucherTypeId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.GiftHtml)
                    .HasColumnName("GiftHTML")
                    .HasMaxLength(2000);

                entity.Property(e => e.KtixSettingId).HasColumnName("KTixSettingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumberOfDaysUntilExpiry).HasDefaultValueSql("((180))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReceiptHtml)
                    .HasColumnName("ReceiptHTML")
                    .HasMaxLength(2000);

                entity.HasOne(d => d.KtixSetting)
                    .WithMany(p => p.Ktixvouchertype)
                    .HasForeignKey(d => d.KtixSettingId)
                    .HasConstraintName("FK_KTIXVOUCHERTYPE_KTIXSETTING");
            });

            modelBuilder.Entity<Ktixvouchertypeitems>(entity =>
            {
                entity.HasKey(e => e.KtixVoucherTypeItemId);

                entity.ToTable("KTIXVOUCHERTYPEITEMS");

                entity.Property(e => e.KtixVoucherTypeItemId).HasColumnName("KTixVoucherTypeItemId");

                entity.Property(e => e.KtixSaleItemId)
                    .HasColumnName("KTixSaleItemId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.KtixVoucherTypeId)
                    .HasColumnName("KTixVoucherTypeId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.KtixSaleItem)
                    .WithMany(p => p.Ktixvouchertypeitems)
                    .HasForeignKey(d => d.KtixSaleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KTIXVOUCHERTYPEITEMS_KTIXSALEITEM");

                entity.HasOne(d => d.KtixVoucherType)
                    .WithMany(p => p.Ktixvouchertypeitems)
                    .HasForeignKey(d => d.KtixVoucherTypeId)
                    .HasConstraintName("FK_KTIXVOUCHERTYPEITEMS_KTIXVOUCHERTYPE");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("LABEL");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000')");

                entity.Property(e => e.ColorForEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('000000')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Label)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_LABEL_COMPANY");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("LANGUAGE");

                entity.Property(e => e.Encoding)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Languagefilter>(entity =>
            {
                entity.ToTable("LANGUAGEFILTER");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loginmethod>(entity =>
            {
                entity.ToTable("LOGINMETHOD");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Introduction).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialNotes).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            modelBuilder.Entity<Maininteractiveautotype>(entity =>
            {
                entity.ToTable("MAININTERACTIVEAUTOTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Maininteractiveelement>(entity =>
            {
                entity.ToTable("MAININTERACTIVEELEMENT");

                entity.Property(e => e.BuyUrl)
                    .HasColumnName("BuyURL")
                    .HasMaxLength(500);

                entity.Property(e => e.FinishDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1 May 2011')");

                entity.Property(e => e.InformationText).HasMaxLength(300);

                entity.Property(e => e.IsShowDescription)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(500);

                entity.Property(e => e.LongText).HasMaxLength(80);

                entity.Property(e => e.PassThroughData).HasMaxLength(500);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1 April 2011')");

                entity.Property(e => e.Text).HasMaxLength(50);

                entity.HasOne(d => d.CinemaGroup)
                    .WithMany(p => p.Maininteractiveelement)
                    .HasForeignKey(d => d.CinemaGroupId)
                    .HasConstraintName("FK_MAININTERACTIVEELEMENT_CINEMAGROUP");

                entity.HasOne(d => d.MainInteractiveElementType)
                    .WithMany(p => p.Maininteractiveelement)
                    .HasForeignKey(d => d.MainInteractiveElementTypeId)
                    .HasConstraintName("FK_MAININTERACTIVEELEMENT_MAININTERACTIVEELEMENTTYPE");
            });

            modelBuilder.Entity<Maininteractiveelementtype>(entity =>
            {
                entity.ToTable("MAININTERACTIVEELEMENTTYPE");

                entity.Property(e => e.DataRequirements)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Maininteractiveimage>(entity =>
            {
                entity.ToTable("MAININTERACTIVEIMAGE");

                entity.Property(e => e.MainInteractiveImageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Maininteractiveimage)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MAININTERACTIVEIMAGE_COMPANY");
            });

            modelBuilder.Entity<Maininteractivetype>(entity =>
            {
                entity.ToTable("MAININTERACTIVETYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserControlFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Maininteractivetype)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MAININTERACTIVETYPE_CSS");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("MEMBER");

                entity.HasIndex(e => e.MembershipNumber)
                    .HasName("IX_MemberByMemberNo");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_MemberByUserId");

                entity.HasIndex(e => new { e.IsMemberCardCreated, e.IsMemberCardCollected, e.NumberOfEmailsOpened, e.MembershipPosid, e.MembershipPospassword, e.CinemaList, e.LegacyMembershipNumber, e.LastEmailDateTime, e.ModifyDateTime, e.CountryStateId, e.IsBannedFromPostingComments, e.Email, e.DateOfBirth, e.EmailFailureCount, e.MembershipNumber, e.MembershipExpiryDate, e.MembershipPointsBalance, e.MemberTypeId, e.Phone, e.SiteId, e.UserId, e.IsSendEmail, e.CreateDateTime, e.GenderId, e.Firstname, e.Address1, e.Address2, e.City, e.Postcode, e.CountryId, e.Mobile, e.ParentOrGuardian, e.IsActivated, e.MemberId, e.SalutationId, e.Surname, e.CinemaId, e.IsDeleted })
                    .HasName("IX_MemberByCinemaIdIsDeleted");

                entity.HasIndex(e => new { e.MemberId, e.SalutationId, e.Surname, e.Firstname, e.Address1, e.IsActivated, e.NumberOfEmailsOpened, e.MembershipPosid, e.MembershipPospassword, e.CinemaList, e.Mobile, e.ParentOrGuardian, e.ModifyDateTime, e.CountryStateId, e.IsBannedFromPostingComments, e.Email, e.IsMemberCardCreated, e.IsMemberCardCollected, e.MembershipNumber, e.MembershipExpiryDate, e.MembershipPointsBalance, e.MemberTypeId, e.LegacyMembershipNumber, e.LastEmailDateTime, e.UserId, e.IsSendEmail, e.CreateDateTime, e.GenderId, e.DateOfBirth, e.EmailFailureCount, e.Address2, e.City, e.Postcode, e.CountryId, e.Phone, e.SiteId, e.CinemaId, e.IsDeleted })
                    .HasName("IX_MemberForImport");

                entity.Property(e => e.MemberId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.CinemaList).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryStateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.HasForcedChangedPassword)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendBulkSms)
                    .IsRequired()
                    .HasColumnName("IsSendBulkSMS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendEmail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastCrmreadDateTime)
                    .HasColumnName("LastCRMReadDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEmailDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2000))");

                entity.Property(e => e.LegacyMembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberTokenId).HasMaxLength(50);

                entity.Property(e => e.MembershipExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipPosid)
                    .HasColumnName("MembershipPOSId")
                    .HasMaxLength(50);

                entity.Property(e => e.MembershipPospassword)
                    .HasColumnName("MembershipPOSPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ParentOrGuardian).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode).HasMaxLength(30);

                entity.Property(e => e.PurgeDateTime).HasColumnType("datetime");

                entity.Property(e => e.SiteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_MEMBER_CINEMA");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_COUNTRY");

                entity.HasOne(d => d.CountryState)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.CountryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_COUNTRYSTATE");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_GENDER");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_MEMBERTYPE");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.SalutationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_SALUTATION");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBER_SITE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MEMBER_aspnet_Users");
            });

            modelBuilder.Entity<Memberbounce>(entity =>
            {
                entity.ToTable("MEMBERBOUNCE");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberbounce)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERBOUNCE_MEMBER");
            });

            modelBuilder.Entity<Membercinemas>(entity =>
            {
                entity.HasKey(e => e.MemberCinemaId);

                entity.ToTable("MEMBERCINEMAS");

                entity.HasIndex(e => new { e.MemberId, e.CinemaId });

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Membercinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBERCINEMAS_CINEMA");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membercinemas)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERCINEMAS_MEMBER");
            });

            modelBuilder.Entity<Membercrmaction>(entity =>
            {
                entity.ToTable("MEMBERCRMACTION");

                entity.HasIndex(e => e.MemberId);

                entity.HasIndex(e => e.PaymentGatewayTransactionId);

                entity.HasIndex(e => new { e.MemberCrmactionTypeId, e.MemberId, e.IsActioned });

                entity.HasIndex(e => new { e.ActionDateTime, e.MemberTypePriceId, e.PaymentGatewayTransactionId, e.TransactionNumber, e.IsCustomerEmailSent, e.IsAdminEmailSent, e.IsSentToCrm, e.NumberOfAttempts, e.IsError, e.MemberCrmactionTypeId, e.MemberId, e.IsActioned, e.CreateDateTime, e.CinemaId })
                    .HasName("IX_MEMBERCRMACTION_CinemaId_MemberCRMActionTypeId_MemberId_IsActioned_CreateDateTime_ActionDateTime_MemberTypePriceId_PaymentGat");

                entity.HasIndex(e => new { e.MemberCrmactionTypeId, e.MemberId, e.IsActioned, e.CreateDateTime, e.ActionDateTime, e.MemberTypePriceId, e.TransactionNumber, e.IsCustomerEmailSent, e.IsAdminEmailSent, e.IsSentToCrm, e.NumberOfAttempts, e.IsError, e.CinemaId, e.PaymentGatewayTransactionId })
                    .HasName("IX_MEMBERCRMACTION_CinemaId_PaymentGatewayTransactionId_MemberCRMActionTypeId_MemberId_IsActioned_CreateDateTime_ActionDateTime_");

                entity.Property(e => e.MemberCrmactionId).HasColumnName("MemberCRMActionId");

                entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsSentToCrm).HasColumnName("IsSentToCRM");

                entity.Property(e => e.MemberCrmactionTypeId).HasColumnName("MemberCRMActionTypeId");

                entity.Property(e => e.TransactionNumber).HasMaxLength(50);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Membercrmaction)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERCRMACTION_CINEMA");

                entity.HasOne(d => d.MemberCrmactionType)
                    .WithMany(p => p.Membercrmaction)
                    .HasForeignKey(d => d.MemberCrmactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERCRMACTION_VENUEMASTERCRMACTIONTYPE");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membercrmaction)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_VENUEMASTERCRMACTION_MEMBER");

                entity.HasOne(d => d.MemberTypePrice)
                    .WithMany(p => p.Membercrmaction)
                    .HasForeignKey(d => d.MemberTypePriceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MEMBERCRMACTION_MEMBERTYPEPRICE");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Membercrmaction)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MEMBERCRMACTION_PAYMENTGATEWAYTRANSACTION");
            });

            modelBuilder.Entity<Membercrmactiontype>(entity =>
            {
                entity.ToTable("MEMBERCRMACTIONTYPE");

                entity.Property(e => e.MemberCrmactionTypeId).HasColumnName("MemberCRMActionTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Membercustomansweroptions>(entity =>
            {
                entity.HasKey(e => e.MemberCustomAnswerOptionId);

                entity.ToTable("MEMBERCUSTOMANSWEROPTIONS");

                entity.HasOne(d => d.MemberCustomAnswer)
                    .WithMany(p => p.Membercustomansweroptions)
                    .HasForeignKey(d => d.MemberCustomAnswerId)
                    .HasConstraintName("FK_MEMBERCUSTOMANSWEROPTIONS_MEMBERCUSTOMANSWERS");

                entity.HasOne(d => d.MemberTypeCustomQuestionOption)
                    .WithMany(p => p.Membercustomansweroptions)
                    .HasForeignKey(d => d.MemberTypeCustomQuestionOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBERCUSTOMANSWEROPTIONS_MEMBERTYPECUSTOMQUESTIONOPTION");
            });

            modelBuilder.Entity<Membercustomanswers>(entity =>
            {
                entity.HasKey(e => e.MemberCustomAnswerId);

                entity.ToTable("MEMBERCUSTOMANSWERS");

                entity.Property(e => e.WrittenAnswer).HasMaxLength(300);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membercustomanswers)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERCUSTOMANSWERS_MEMBER");

                entity.HasOne(d => d.MemberTypeCustomQuestion)
                    .WithMany(p => p.Membercustomanswers)
                    .HasForeignKey(d => d.MemberTypeCustomQuestionId)
                    .HasConstraintName("FK_MEMBERCUSTOMANSWERS_MEMBERTYPECUSTOMQUESTION");
            });

            modelBuilder.Entity<Memberdetailchangelog>(entity =>
            {
                entity.ToTable("MEMBERDETAILCHANGELOG");

                entity.Property(e => e.MemberDetailChangeLogId).HasColumnName("memberDetailChangeLogId");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("createDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Memberemailgroups>(entity =>
            {
                entity.HasKey(e => e.MemberEmailGroupId);

                entity.ToTable("MEMBEREMAILGROUPS");

                entity.HasIndex(e => new { e.MemberId, e.EmailGroupId, e.MemberEmailGroupId })
                    .HasName("Idx_MEG");

                entity.HasOne(d => d.EmailGroup)
                    .WithMany(p => p.Memberemailgroups)
                    .HasForeignKey(d => d.EmailGroupId)
                    .HasConstraintName("FK_MEMBEREMAILGROUPS_EMAILGROUP");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberemailgroups)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBEREMAILGROUPS_MEMBER");
            });

            modelBuilder.Entity<Memberexitpoll>(entity =>
            {
                entity.ToTable("MEMBEREXITPOLL");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Memberexitpoll)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MEMBEREXITPOLL_COMPANY");
            });

            modelBuilder.Entity<Membergenres>(entity =>
            {
                entity.HasKey(e => e.MemberGenreId);

                entity.ToTable("MEMBERGENRES");

                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_MemberGenresByMemberId");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Membergenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_MEMBERGENRES_GENRE");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membergenres)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERGENRES_MEMBER");
            });

            modelBuilder.Entity<Memberimport>(entity =>
            {
                entity.ToTable("MEMBERIMPORT");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryStateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Firstname).HasMaxLength(250);

                entity.Property(e => e.IsSendEmail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MembershipExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode).HasMaxLength(30);

                entity.Property(e => e.SiteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Surname).HasMaxLength(250);
            });

            modelBuilder.Entity<Membermoviecategorypurchaselog>(entity =>
            {
                entity.ToTable("MEMBERMOVIECATEGORYPURCHASELOG");

                entity.HasIndex(e => e.MemberId);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermoviecategorypurchaselog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIECATEGORYPURCHASELOG_MEMBER");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.Membermoviecategorypurchaselog)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .HasConstraintName("FK_MEMBERMOVIECATEGORYPURCHASELOG_MOVIECATEGORY");
            });

            modelBuilder.Entity<Membermoviegenrepurchaselog>(entity =>
            {
                entity.ToTable("MEMBERMOVIEGENREPURCHASELOG");

                entity.HasIndex(e => e.MemberId);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Membermoviegenrepurchaselog)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_MEMBERMOVIEGENREPURCHASELOG_GENRE");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermoviegenrepurchaselog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIEGENREPURCHASELOG_MEMBER");
            });

            modelBuilder.Entity<Membermoviepurchaseimport>(entity =>
            {
                entity.ToTable("MEMBERMOVIEPURCHASEIMPORT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermoviepurchaseimport)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIEPURCHASEIMPORT_MEMBER");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Membermoviepurchaseimport)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MEMBERMOVIEPURCHASEIMPORT_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Membermoviepurchaselog>(entity =>
            {
                entity.ToTable("MEMBERMOVIEPURCHASELOG");

                entity.HasIndex(e => e.MemberId);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermoviepurchaselog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIEPURCHASELOG_MEMBER");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Membermoviepurchaselog)
                    .HasForeignKey(d => d.MovieDetailId)
                    .HasConstraintName("FK_MEMBERMOVIEPURCHASELOG_MOVIEDETAIL");
            });

            modelBuilder.Entity<Membermovietypepurchaselog>(entity =>
            {
                entity.HasKey(e => e.MemberMovieTypePurchaseLog1);

                entity.ToTable("MEMBERMOVIETYPEPURCHASELOG");

                entity.Property(e => e.MemberMovieTypePurchaseLog1).HasColumnName("MemberMovieTypePurchaseLog");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermovietypepurchaselog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIETYPEPURCHASELOG_MEMBER");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Membermovietypepurchaselog)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_MEMBERMOVIETYPEPURCHASELOG_MOVIETYPE");
            });

            modelBuilder.Entity<Membermovieviewlog>(entity =>
            {
                entity.ToTable("MEMBERMOVIEVIEWLOG");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membermovieviewlog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERMOVIEVIEWLOG_MEMBER");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Membermovieviewlog)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MEMBERMOVIEVIEWLOG_MOVIE");
            });

            modelBuilder.Entity<Memberofferviewlog>(entity =>
            {
                entity.ToTable("MEMBEROFFERVIEWLOG");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberofferviewlog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBEROFFERVIEWLOG_MEMBER");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Memberofferviewlog)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK_MEMBEROFFERVIEWLOG_OFFER");
            });

            modelBuilder.Entity<Memberpointlog>(entity =>
            {
                entity.ToTable("MEMBERPOINTLOG");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberpointlog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERPOINTLOG_MEMBER");
            });

            modelBuilder.Entity<Memberpolloptionlog>(entity =>
            {
                entity.ToTable("MEMBERPOLLOPTIONLOG");

                entity.Property(e => e.VoteDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberpolloptionlog)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERPOLLOPTIONLOG_MEMBER");

                entity.HasOne(d => d.PollOption)
                    .WithMany(p => p.Memberpolloptionlog)
                    .HasForeignKey(d => d.PollOptionId)
                    .HasConstraintName("FK_MEMBERPOLLOPTIONLOG_POLLOPTION");
            });

            modelBuilder.Entity<MemberTempData>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.CinemaList).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.EmailGroupList).HasMaxLength(500);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.GenreList).HasMaxLength(500);

                entity.Property(e => e.LastCrmreadDateTime)
                    .HasColumnName("LastCRMReadDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEmailDateTime).HasColumnType("datetime");

                entity.Property(e => e.LegacyMembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberTypePriceId).HasColumnName("memberTypePriceId");

                entity.Property(e => e.MembershipExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipPosid)
                    .HasColumnName("MembershipPOSId")
                    .HasMaxLength(50);

                entity.Property(e => e.MembershipPospassword)
                    .HasColumnName("MembershipPOSPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ParentOrGuardian).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PaypalToken).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode).HasMaxLength(30);

                entity.Property(e => e.PurgeDateTime).HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Membertransaction>(entity =>
            {
                entity.ToTable("MEMBERTRANSACTION");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionOfTransaction)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Membertransaction)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_MEMBERTRANSACTION_MEMBER");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Membertransaction)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .HasConstraintName("FK_MEMBERTRANSACTION_PAYMENTGATEWAYTRANSACTION");
            });

            modelBuilder.Entity<Membertype>(entity =>
            {
                entity.ToTable("MEMBERTYPE");

                entity.Property(e => e.MemberTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateAccountTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'Create Account')");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayRenewalWarningWithinWeeks).HasDefaultValueSql("((6))");

                entity.Property(e => e.EmailGroupLabelText)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'Email Subscriptions')");

                entity.Property(e => e.ExpiredNoticeText)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('Your membership has expired. Renew online today!')");

                entity.Property(e => e.ExpiryWarningNoticeText)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('Your membership is expiring soon. Renew online today!')");

                entity.Property(e => e.GenreLabelText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Favourite Genres')");

                entity.Property(e => e.IsAdditionalCinemasDisplayed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsApplyAllCinemasInCinemaGroup)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCreateAspnetAccount)
                    .IsRequired()
                    .HasColumnName("IsCreateASPNetAccount")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEmailAddressRequired)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsGenreDisplayed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMemberDeletable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMobileDisplayed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPermitLoginUsingMembershipNumberWhenEmailExists)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPostCodeRequired)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowPersonalDetailsBeforeActivation)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWebsiteLoginEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWebsitePurchaseEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NumberOfVisitsInformation).HasMaxLength(250);

                entity.Property(e => e.PaymentFormIntroductionText).HasMaxLength(1000);

                entity.Property(e => e.PosmemberTypeId)
                    .HasColumnName("POSMemberTypeId")
                    .HasMaxLength(50);

                entity.Property(e => e.PostCodeWhiteList).HasMaxLength(500);

                entity.Property(e => e.ProcessingInstructions).HasMaxLength(1000);

                entity.Property(e => e.ReceiptText).HasMaxLength(1000);

                entity.Property(e => e.RenewalDescriptionText).HasMaxLength(2000);

                entity.Property(e => e.RenewalLimitInWeeks).HasDefaultValueSql("((6))");

                entity.Property(e => e.RenewalNotificationEmailAddress).HasMaxLength(150);

                entity.Property(e => e.RenewalPageTitleText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'Membership Renewal')");

                entity.Property(e => e.RenewalSuccessText).HasMaxLength(2000);

                entity.Property(e => e.SignupIntroductionText)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("(N'As a website member you will receive our weekly newsletter containing all the latest film releases and weekly session times delivered direct to your email inbox. <br /><br />You will also be the first to get the scoop on blockbuster openings, Members only screenings and events, special offers, discounts and entry into our competitions!')");

                entity.Property(e => e.SignupNotificationEmailAddress).HasMaxLength(150);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Membertype)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBERTYPE_COMPANY");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Membertype)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBERTYPE_aspnet_Roles");
            });

            modelBuilder.Entity<Membertypecustomquestion>(entity =>
            {
                entity.ToTable("MEMBERTYPECUSTOMQUESTION");

                entity.Property(e => e.MemberTypeCustomQuestionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DefaultWrittenAnswerForImportedRecords)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.MemberTypeCustomQuestionType)
                    .WithMany(p => p.Membertypecustomquestion)
                    .HasForeignKey(d => d.MemberTypeCustomQuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMBERTYPECUSTOMQUESTION_MEMBERTYPECUSTOMQUESTIONTYPE");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Membertypecustomquestion)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_MEMBERTYPECUSTOMQUESTION_MEMBERTYPE");
            });

            modelBuilder.Entity<Membertypecustomquestionoption>(entity =>
            {
                entity.ToTable("MEMBERTYPECUSTOMQUESTIONOPTION");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.MemberTypeCustomQuestion)
                    .WithMany(p => p.Membertypecustomquestionoption)
                    .HasForeignKey(d => d.MemberTypeCustomQuestionId)
                    .HasConstraintName("FK_MEMBERTYPECUSTOMQUESTIONOPTION_MEMBERTYPECUSTOMQUESTION");
            });

            modelBuilder.Entity<Membertypecustomquestiontype>(entity =>
            {
                entity.ToTable("MEMBERTYPECUSTOMQUESTIONTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Membertypedefaultemailgroups>(entity =>
            {
                entity.HasKey(e => e.MemberTypeDefaultEmailGroupId);

                entity.ToTable("MEMBERTYPEDEFAULTEMAILGROUPS");

                entity.HasOne(d => d.EmailGroup)
                    .WithMany(p => p.Membertypedefaultemailgroups)
                    .HasForeignKey(d => d.EmailGroupId)
                    .HasConstraintName("FK_MEMBERTYPEDEFAULTEMAILGROUPS_EMAILGROUP");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Membertypedefaultemailgroups)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_MEMBERTYPEDEFAULTEMAILGROUPS_MEMBERTYPE");
            });

            modelBuilder.Entity<Membertypeemail>(entity =>
            {
                entity.ToTable("MEMBERTYPEEMAIL");

                entity.Property(e => e.MemberTypeEmailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.MemberTypeEmailType)
                    .WithMany(p => p.Membertypeemail)
                    .HasForeignKey(d => d.MemberTypeEmailTypeId)
                    .HasConstraintName("FK_MEMBERTYPEEMAIL_MEMBERTYPEEMAILTYPE");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Membertypeemail)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_MEMBERTYPEEMAIL_MEMBERTYPE");
            });

            modelBuilder.Entity<Membertypeemailtype>(entity =>
            {
                entity.ToTable("MEMBERTYPEEMAILTYPE");

                entity.Property(e => e.DefaultSubject).HasMaxLength(200);

                entity.Property(e => e.DefaultText).HasMaxLength(1000);

                entity.Property(e => e.IsPaidMemberOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Membertypeprice>(entity =>
            {
                entity.ToTable("MEMBERTYPEPRICE");

                entity.Property(e => e.DeliveryCharge).HasColumnType("money");

                entity.Property(e => e.ForcedExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSignup)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumberOfDays).HasDefaultValueSql("((366))");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceIncludingTax).HasColumnType("money");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Membertypeprice)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_MEMBERTYPEPRICE_MEMBERTYPE");
            });

            modelBuilder.Entity<Mobilealert>(entity =>
            {
                entity.ToTable("MOBILEALERT");

                entity.Property(e => e.DisplayFinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayStartDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Mobilealert)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOBILEALERT_COMPANY");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Mobilealert)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MOBILEALERT_OFFER");
            });

            modelBuilder.Entity<Mobilealertcinemas>(entity =>
            {
                entity.HasKey(e => e.MobileAlertCinemaId);

                entity.ToTable("MOBILEALERTCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Mobilealertcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_MOBILEALERTCINEMAS_CINEMA");

                entity.HasOne(d => d.MobileAlert)
                    .WithMany(p => p.Mobilealertcinemas)
                    .HasForeignKey(d => d.MobileAlertId)
                    .HasConstraintName("FK_MOBILEALERTCINEMAS_MOBILEALERT");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("MOVIE");

                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => new { e.CompanyId, e.IsActive });

                entity.Property(e => e.MovieId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.RatingOutOfFive)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIE_COMPANY");

                entity.HasOne(d => d.MovieAudience)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.MovieAudienceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MOVIE_MOVIEAUDIENCE");
            });

            modelBuilder.Entity<Movieaudience>(entity =>
            {
                entity.ToTable("MOVIEAUDIENCE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.NextMovieAudience)
                    .WithMany(p => p.InverseNextMovieAudience)
                    .HasForeignKey(d => d.NextMovieAudienceId)
                    .HasConstraintName("FK_MOVIEAUDIENCE_MOVIEAUDIENCE");
            });

            modelBuilder.Entity<Movieaward>(entity =>
            {
                entity.ToTable("MOVIEAWARD");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Movieaward)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MOVIEAWARD_COMPANY");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Movieaward)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEAWARD_MOVIE");
            });

            modelBuilder.Entity<Movieawardcompanies>(entity =>
            {
                entity.HasKey(e => e.MovieAwardCompanyId);

                entity.ToTable("MOVIEAWARDCOMPANIES");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Movieawardcompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIEAWARDCOMPANIES_COMPANY");

                entity.HasOne(d => d.MovieAward)
                    .WithMany(p => p.Movieawardcompanies)
                    .HasForeignKey(d => d.MovieAwardId)
                    .HasConstraintName("FK_MOVIEAWARDCOMPANIES_MOVIEAWARD");
            });

            modelBuilder.Entity<Moviebanner>(entity =>
            {
                entity.ToTable("MOVIEBANNER");

                entity.Property(e => e.MovieBannerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AdvertisementLocationType)
                    .WithMany(p => p.Moviebanner)
                    .HasForeignKey(d => d.AdvertisementLocationTypeId)
                    .HasConstraintName("FK_MOVIEBANNER_ADVERTISEMENTLOCATIONTYPE");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Moviebanner)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEBANNER_MOVIE");
            });

            modelBuilder.Entity<Moviecategory>(entity =>
            {
                entity.ToTable("MOVIECATEGORY");

                entity.Property(e => e.MovieCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsUseForYouMightAlsoLike)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OnlineTicketingStartMessage).HasMaxLength(250);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Moviecategory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIECATEGORY_COMPANY");
            });

            modelBuilder.Entity<Moviecomment>(entity =>
            {
                entity.ToTable("MOVIECOMMENT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RatingOutOfFive).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Moviecomment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIECOMMENT_COMPANY");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Moviecomment)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIECOMMENT_MOVIE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Moviecomment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MOVIECOMMENT_aspnet_Users");
            });

            modelBuilder.Entity<Moviedetail>(entity =>
            {
                entity.ToTable("MOVIEDETAIL");

                entity.HasIndex(e => new { e.MovieId, e.CountryId });

                entity.HasIndex(e => new { e.MovieId, e.CountryId, e.Cast })
                    .HasName("IX_MOVIEDETAIL_CountryId_Cast_MovieId");

                entity.HasIndex(e => new { e.MovieId, e.CountryId, e.Director })
                    .HasName("IX_MOVIEDETAIL_CountryId_Director_MovieId");

                entity.HasIndex(e => new { e.PosterContentId, e.PhotoContentId, e.IsSubtitled, e.ReleaseDate, e.DistributorId, e.Cast, e.CreateDateTime, e.ModifyDateTime, e.RatingId, e.ConsumerAdvice, e.Tagline, e.Synopsis, e.CountryOfOriginList, e.AudioLanguageList, e.Title, e.ForeignTitle, e.Director, e.OfficialSiteUrl, e.ExternalTrailerUrl, e.RunningTime, e.MovieId, e.CountryId })
                    .HasName("IX_MOVIEDETAIL_MovieId_CountryId_Title_ForeignTitle_Director_OfficialSiteURL_ExternalTrailerURL_RunningTime_RatingId_ConsumerAdv");

                entity.Property(e => e.MovieDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AudioLanguageList).HasMaxLength(200);

                entity.Property(e => e.Cast).HasMaxLength(300);

                entity.Property(e => e.ConsumerAdvice).HasMaxLength(200);

                entity.Property(e => e.CountryOfOriginList).HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Director).HasMaxLength(150);

                entity.Property(e => e.ExternalTrailerUrl)
                    .HasColumnName("ExternalTrailerURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ForeignTitle).HasMaxLength(300);

                entity.Property(e => e.ImdbRating).HasMaxLength(50);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfficialSiteUrl)
                    .HasColumnName("OfficialSiteURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.RunningTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Synopsis).HasMaxLength(3000);

                entity.Property(e => e.Tagline).HasMaxLength(150);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Moviedetail)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MOVIEDETAIL_COUNTRY");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.Moviedetail)
                    .HasForeignKey(d => d.DistributorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MOVIEDETAIL_DISTRIBUTOR");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Moviedetail)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEDETAIL_MOVIE");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Moviedetail)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK_MOVIEDETAIL_RATING");
            });

            modelBuilder.Entity<Moviegenres>(entity =>
            {
                entity.HasKey(e => e.MovieGenreId);

                entity.ToTable("MOVIEGENRES");

                entity.HasIndex(e => e.MovieId);

                entity.HasIndex(e => new { e.MovieId, e.GenreId });

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Moviegenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_MOVIEGENRES_GENRE");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Moviegenres)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEGENRES_MOVIE");
            });

            modelBuilder.Entity<Movieimportancetype>(entity =>
            {
                entity.ToTable("MOVIEIMPORTANCETYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movieinformationsite>(entity =>
            {
                entity.ToTable("MOVIEINFORMATIONSITE");

                entity.Property(e => e.ExternalId).HasMaxLength(150);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(400);

                entity.HasOne(d => d.InformationSite)
                    .WithMany(p => p.Movieinformationsite)
                    .HasForeignKey(d => d.InformationSiteId)
                    .HasConstraintName("FK_MOVIEINFORMATIONSITE_INFORMATIONSITE");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Movieinformationsite)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEINFORMATIONSITE_MOVIE");
            });

            modelBuilder.Entity<Movieinstance>(entity =>
            {
                entity.ToTable("MOVIEINSTANCE");

                entity.HasIndex(e => e.MovieId);

                entity.HasIndex(e => new { e.IsDeleted, e.IsActive });

                entity.HasIndex(e => new { e.CompanyId, e.IsDeleted, e.MovieDetailId, e.IsActive });

                entity.HasIndex(e => new { e.CreateDateTime, e.MovieDetailId, e.CompanyId, e.IsDeleted, e.IsActive })
                    .HasName("IX_MOVIEINSTANCE_CompanyId_IsDeleted_IsActive_CreateDateTime_MovieDetailId");

                entity.Property(e => e.MovieInstanceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsShowOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnNewsletter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnYouMightAlsoLike)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowReleaseDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdateContent)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdateReleaseDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.MovieImportanceTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.PointOfSaleId).HasMaxLength(50);

                entity.Property(e => e.PointOfSaleTitle).HasMaxLength(250);

                entity.Property(e => e.PromotionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.ShortTitle).HasMaxLength(50);

                entity.Property(e => e.UniqueLabel).HasMaxLength(100);

                entity.Property(e => e.UniqueLabelColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.MovieDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVIEINSTANCE_MOVIEDETAIL");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEINSTANCE_MOVIE");

                entity.HasOne(d => d.MovieImportanceType)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.MovieImportanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVIEINSTANCE_MOVIEIMPORTANCETYPE");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.MovieTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVIEINSTANCE_MOVIETYPE");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_MOVIEINSTANCE_PAGE");

                entity.HasOne(d => d.PhotoContent)
                    .WithMany(p => p.MovieinstancePhotoContent)
                    .HasForeignKey(d => d.PhotoContentId)
                    .HasConstraintName("FK_MOVIEINSTANCE_CONTENT1");

                entity.HasOne(d => d.PosterContent)
                    .WithMany(p => p.MovieinstancePosterContent)
                    .HasForeignKey(d => d.PosterContentId)
                    .HasConstraintName("FK_MOVIEINSTANCE_CONTENT");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Movieinstance)
                    .HasForeignKey(d => d.PromotionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MOVIEINSTANCE_PROMOTION");
            });

            modelBuilder.Entity<Movieinstancecinemalabels>(entity =>
            {
                entity.HasKey(e => e.MovieInstanceCinemaLabelId);

                entity.ToTable("MOVIEINSTANCECINEMALABELS");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.Movieinstancecinemalabels)
                    .HasForeignKey(d => d.LabelId)
                    .HasConstraintName("FK_MOVIEINSTANCECINEMALABELS_LABEL");

                entity.HasOne(d => d.MovieInstanceCinema)
                    .WithMany(p => p.Movieinstancecinemalabels)
                    .HasForeignKey(d => d.MovieInstanceCinemaId)
                    .HasConstraintName("FK_MOVIEINSTANCECINEMALABELS_MOVIEINSTANCECINEMAS");
            });

            modelBuilder.Entity<Movieinstancecinemas>(entity =>
            {
                entity.HasKey(e => e.MovieInstanceCinemaId);

                entity.ToTable("MOVIEINSTANCECINEMAS");

                entity.HasIndex(e => e.MovieInstanceCinemaId)
                    .HasName("IX_MOVIEINSTANCECINEMAS_MovieInstanceId");

                entity.HasIndex(e => new { e.CinemaId, e.PointOfSaleTitle });

                entity.HasIndex(e => new { e.MovieInstanceId, e.CinemaId })
                    .HasName("IDX_MovieInstanceCinemas_CinemaIdAndMovieInstanceId");

                entity.HasIndex(e => new { e.IsUpdateLabels, e.IsUpdatePointOfSaleTitle, e.MovieInstanceId, e.IsUpdateReleaseDate, e.IsSessionBypass, e.AdjustedReleaseDateNowShowing, e.AdjustedReleaseDateComingSoon, e.PointOfSaleTitle, e.CinemaId, e.ReleaseDate })
                    .HasName("IX_MOVIEINSTANCECINEMAS_CinemaId_ReleaseDate_MovieInstanceId_IsUpdateReleaseDate_IsSessionBypass_AdjustedReleaseDateNowShowing_A");

                entity.HasIndex(e => new { e.IsUpdatePointOfSaleTitle, e.IsUpdateReleaseDate, e.IsSessionBypass, e.AdjustedReleaseDateNowShowing, e.AdjustedReleaseDateComingSoon, e.PointOfSaleTitle, e.IsUpdateLabels, e.MovieInstanceId, e.ReleaseDate, e.CinemaId })
                    .HasName("IX_MOVIEINSTANCECINEMAS_CinemaId_MovieInstanceId_ReleaseDate_IsUpdateReleaseDate_IsSessionBypass_AdjustedReleaseDateNowShowing_A");

                entity.Property(e => e.AdjustedReleaseDateComingSoon).HasColumnType("datetime");

                entity.Property(e => e.AdjustedReleaseDateNowShowing).HasColumnType("datetime");

                entity.Property(e => e.IsUpdateLabels)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdatePointOfSaleTitle)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PointOfSaleTitle).HasMaxLength(250);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Movieinstancecinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_MOVIEINSTANCECINEMAS_CINEMA");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Movieinstancecinemas)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MOVIEINSTANCECINEMAS_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Movieinstancecontent>(entity =>
            {
                entity.ToTable("MOVIEINSTANCECONTENT");

                entity.HasIndex(e => e.MovieInstanceId);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Movieinstancecontent)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_MOVIEINSTANCECONTENT_CONTENT");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Movieinstancecontent)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MOVIEINSTANCECONTENT_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Movieinstanceflagdates>(entity =>
            {
                entity.HasKey(e => e.MovieFlagDateId);

                entity.ToTable("MOVIEINSTANCEFLAGDATES");

                entity.HasIndex(e => new { e.MovieInstanceId, e.CinemaId, e.Date });

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Movieinstanceflagdates)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_MOVIEINSTANCEFLAGDATES_FLAG");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Movieinstanceflagdates)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MOVIEINSTANCEFLAGDATES_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Movieinstancelabels>(entity =>
            {
                entity.HasKey(e => e.MovieInstanceLabelId);

                entity.ToTable("MOVIEINSTANCELABELS");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.Movieinstancelabels)
                    .HasForeignKey(d => d.LabelId)
                    .HasConstraintName("FK_MOVIEINSTANCELABELS_LABEL");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Movieinstancelabels)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MOVIEINSTANCELABELS_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Movieinstancemoviecategories>(entity =>
            {
                entity.HasKey(e => e.MovieCategoryMovieId);

                entity.ToTable("MOVIEINSTANCEMOVIECATEGORIES");

                entity.HasIndex(e => e.MovieInstanceId)
                    .HasName("IX_MovieInstanceMovieCategories_MovieInstanceId");

                entity.HasIndex(e => new { e.MovieInstanceId, e.MovieCategoryId })
                    .HasName("IX_MOVIEINSTANCEMOVIECATEGORIES_MovieCategoryId_MovieInstanceId");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.Movieinstancemoviecategories)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .HasConstraintName("FK_MOVIECATEGORYMOVIES_MOVIECATEGORY");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Movieinstancemoviecategories)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_MOVIEINSTANCEMOVIECATEGORIES_MOVIEINSTANCE");
            });

            modelBuilder.Entity<Moviepurchasefiltertype>(entity =>
            {
                entity.ToTable("MOVIEPURCHASEFILTERTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movierating>(entity =>
            {
                entity.ToTable("MOVIERATING");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RatingOutOfFive).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Movierating)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIERATING_MOVIE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Movierating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MOVIERATING_aspnet_Users");
            });

            modelBuilder.Entity<Moviereview>(entity =>
            {
                entity.ToTable("MOVIEREVIEW");

                entity.HasIndex(e => e.MovieId);

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CopyrightHolderName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RatingOutOfFive).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WebSiteName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Moviereview)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MOVIEREVIEW_COMPANY");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Moviereview)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_MOVIEREVIEW_MOVIE");
            });

            modelBuilder.Entity<Moviereviewcompanies>(entity =>
            {
                entity.HasKey(e => e.MovieReviewCompanyId);

                entity.ToTable("MOVIEREVIEWCOMPANIES");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Moviereviewcompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIEREVIEWCOMPANIES_COMPANY");

                entity.HasOne(d => d.MovieReview)
                    .WithMany(p => p.Moviereviewcompanies)
                    .HasForeignKey(d => d.MovieReviewId)
                    .HasConstraintName("FK_MOVIEREVIEWCOMPANIES_MOVIEREVIEW");
            });

            modelBuilder.Entity<Movietype>(entity =>
            {
                entity.ToTable("MOVIETYPE");

                entity.Property(e => e.MovieTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.IsDisplayAllCinemaGroupSessions)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowGallery)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowRatingStars)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowReleaseDateForNowShowing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowTabs)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReleaseDateText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Release Date:')");

                entity.Property(e => e.SessionTimeLabelSuffix)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'Session Times')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Movietype)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MOVIETYPE_COMPANY");
            });

            modelBuilder.Entity<Movietypeelement>(entity =>
            {
                entity.ToTable("MOVIETYPEELEMENT");

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Movietypeelement)
                    .HasForeignKey(d => d.IncludeElementId)
                    .HasConstraintName("FK_MOVIETYPEELEMENT_INCLUDEELEMENT");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Movietypeelement)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_MOVIETYPEELEMENT_MOVIETYPE");
            });

            modelBuilder.Entity<NameofMonth>(entity =>
            {
                entity.HasKey(e => e.MonthNameId);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nowshowingquerymethod>(entity =>
            {
                entity.ToTable("NOWSHOWINGQUERYMETHOD");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("OFFER");

                entity.Property(e => e.OfferId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CashierCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DisplayFinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayStartDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExternalLinkUrl)
                    .HasColumnName("ExternalLinkURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsGenerateReminders)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnMobileApp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVoucherRequired)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainInteractiveTitle).HasMaxLength(30);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PriceInformation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RedemptionInstruction)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.TermsAndConditions).IsRequired();

                entity.Property(e => e.TextOnVoucher)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ValidFinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidStartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OFFER_COMPANY");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.MovieDetailId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OFFER_MOVIEDETAIL");
            });

            modelBuilder.Entity<Offercinemas>(entity =>
            {
                entity.HasKey(e => e.OfferCinemaId);

                entity.ToTable("OFFERCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Offercinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_OFFERCINEMAS_CINEMA");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Offercinemas)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK_OFFERCINEMAS_OFFER");
            });

            modelBuilder.Entity<Offermembertypes>(entity =>
            {
                entity.HasKey(e => e.OfferMemberTypeId);

                entity.ToTable("OFFERMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Offermembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_OFFERMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Offermembertypes)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK_OFFERMEMBERTYPES_OFFER");
            });

            modelBuilder.Entity<Offersites>(entity =>
            {
                entity.HasKey(e => e.OfferSiteId);

                entity.ToTable("OFFERSITES");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Offersites)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK_OFFERSITES_OFFER");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Offersites)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OFFERSITES_SITE");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("PAGE");

                entity.HasIndex(e => new { e.Name, e.Title, e.CarouselId, e.HeaderAdvertisementLocationId, e.CssId, e.IsUnique, e.FooterId, e.DrawerId, e.SiteMenuId, e.Description, e.CreateDateTime, e.ModifyDateTime, e.AuthorUserId, e.PageTypeId, e.SidebarId, e.SiteId, e.IsDeleted, e.IsActive })
                    .HasName("IX_PAGE_SiteId_IsDeleted_IsActive_Name_Title_Description_CreateDateTime_ModifyDateTime_AuthorUserId_PageTypeId_SidebarId_HeaderA");

                entity.Property(e => e.PageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGE_aspnet_Users");

                entity.HasOne(d => d.Carousel)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.CarouselId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_CAROUSEL");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_CSS");

                entity.HasOne(d => d.Drawer)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.DrawerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_DRAWER");

                entity.HasOne(d => d.Footer)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.FooterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_FOOTER");

                entity.HasOne(d => d.PageType)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.PageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGE_PAGETYPE");

                entity.HasOne(d => d.Sidebar)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.SidebarId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_SIDEBAR");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_PAGE_SITE");

                entity.HasOne(d => d.SiteMenu)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.SiteMenuId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGE_SITEMENU");
            });

            modelBuilder.Entity<Pagelinks>(entity =>
            {
                entity.HasKey(e => e.PageLinkId);

                entity.ToTable("PAGELINKS");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.DestinationPage)
                    .WithMany(p => p.PagelinksDestinationPage)
                    .HasForeignKey(d => d.DestinationPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGELINKS_PAGE1");

                entity.HasOne(d => d.OriginPage)
                    .WithMany(p => p.PagelinksOriginPage)
                    .HasForeignKey(d => d.OriginPageId)
                    .HasConstraintName("FK_PAGELINKS_PAGE");
            });

            modelBuilder.Entity<Pagemenu>(entity =>
            {
                entity.ToTable("PAGEMENU");

                entity.Property(e => e.PageMenuId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Anchor).HasMaxLength(50);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((99))");

                entity.Property(e => e.DisplayOrderDesktop).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderMobile).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderTablet).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Pagemenu)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_PAGEMENU_PAGE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Pagemenu)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_PAGEMENU_SITE");
            });

            modelBuilder.Entity<Pagemenupagecinemas>(entity =>
            {
                entity.HasKey(e => e.PageMenuPageCinemaId);

                entity.ToTable("PAGEMENUPAGECINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Pagemenupagecinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_PAGEMENUPAGECINEMAS_CINEMA");

                entity.HasOne(d => d.PageMenuPages)
                    .WithMany(p => p.Pagemenupagecinemas)
                    .HasForeignKey(d => d.PageMenuPagesId)
                    .HasConstraintName("FK_PAGEMENUPAGECINEMAS_PAGEMENUPAGES");
            });

            modelBuilder.Entity<Pagemenupages>(entity =>
            {
                entity.ToTable("PAGEMENUPAGES");

                entity.Property(e => e.Anchor).HasMaxLength(50);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Pagemenupages)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_PAGEMENUPAGES_PAGE");

                entity.HasOne(d => d.PageMenu)
                    .WithMany(p => p.Pagemenupages)
                    .HasForeignKey(d => d.PageMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGEMENUPAGES_PAGEMENU");
            });

            modelBuilder.Entity<Pageredirect>(entity =>
            {
                entity.ToTable("PAGEREDIRECT");

                entity.Property(e => e.PageRedirectId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DestinationPageUrl)
                    .HasColumnName("DestinationPageURL")
                    .HasMaxLength(350);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Pageredirect)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_PAGEREDIRECT_CINEMA");

                entity.HasOne(d => d.DestinationPage)
                    .WithMany(p => p.PageredirectDestinationPage)
                    .HasForeignKey(d => d.DestinationPageId)
                    .HasConstraintName("FK_PAGEREDIRECT_PAGE1");

                entity.HasOne(d => d.OriginPage)
                    .WithMany(p => p.PageredirectOriginPage)
                    .HasForeignKey(d => d.OriginPageId)
                    .HasConstraintName("FK_PAGEREDIRECT_PAGE");
            });

            modelBuilder.Entity<Pageregion>(entity =>
            {
                entity.ToTable("PAGEREGION");

                entity.Property(e => e.PageRegionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DescriptionOfContent)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Pageregion)
                    .HasForeignKey(d => d.IncludeElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGEREGION_INCLUDEELEMENT");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Pageregion)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_PAGEREGION_PAGE");
            });

            modelBuilder.Entity<Pageregioncinemas>(entity =>
            {
                entity.HasKey(e => e.PageRegionCinemaId);

                entity.ToTable("PAGEREGIONCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Pageregioncinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_PAGEREGIONCINEMAS_CINEMA");

                entity.HasOne(d => d.PageRegion)
                    .WithMany(p => p.Pageregioncinemas)
                    .HasForeignKey(d => d.PageRegionId)
                    .HasConstraintName("FK_PAGEREGIONCINEMAS_PAGEREGION");
            });

            modelBuilder.Entity<Pageregioncontent>(entity =>
            {
                entity.ToTable("PAGEREGIONCONTENT");

                entity.Property(e => e.PageRegionContentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.InformationText).HasMaxLength(300);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PassThroughData).HasMaxLength(2000);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.PageregioncontentApprovedByUser)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .HasConstraintName("FK_PAGEREGIONCONTENT_aspnet_Users1");

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.PageregioncontentAuthorUser)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGEREGIONCONTENT_aspnet_Users");

                entity.HasOne(d => d.PageRegion)
                    .WithMany(p => p.Pageregioncontent)
                    .HasForeignKey(d => d.PageRegionId)
                    .HasConstraintName("FK_PAGEREGIONCONTENT_PAGEREGION");
            });

            modelBuilder.Entity<Pageregionmembertypes>(entity =>
            {
                entity.HasKey(e => e.PageRegionMemberTypeId);

                entity.ToTable("PAGEREGIONMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Pageregionmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_PAGEREGIONMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.PageRegion)
                    .WithMany(p => p.Pageregionmembertypes)
                    .HasForeignKey(d => d.PageRegionId)
                    .HasConstraintName("FK_PAGEREGIONMEMBERTYPES_PAGEREGION");
            });

            modelBuilder.Entity<Pagetemplate>(entity =>
            {
                entity.ToTable("PAGETEMPLATE");

                entity.Property(e => e.PageTemplateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Pagetemplate)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGETEMPLATE_CSS");

                entity.HasOne(d => d.PageType)
                    .WithMany(p => p.Pagetemplate)
                    .HasForeignKey(d => d.PageTypeId)
                    .HasConstraintName("FK_PAGETEMPLATE_PAGETYPE");
            });

            modelBuilder.Entity<Pagetemplateregion>(entity =>
            {
                entity.ToTable("PAGETEMPLATEREGION");

                entity.Property(e => e.PageTemplateRegionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DescriptionOfContent)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Pagetemplateregion)
                    .HasForeignKey(d => d.IncludeElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGETEMPLATEREGION_INCLUDEELEMENT");

                entity.HasOne(d => d.PageTemplate)
                    .WithMany(p => p.Pagetemplateregion)
                    .HasForeignKey(d => d.PageTemplateId)
                    .HasConstraintName("FK_PAGETEMPLATEREGION_PAGETEMPLATE");
            });

            modelBuilder.Entity<Pagetemplateregioncontent>(entity =>
            {
                entity.ToTable("PAGETEMPLATEREGIONCONTENT");

                entity.Property(e => e.PageTemplateRegionContentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.InformationText).HasMaxLength(300);

                entity.Property(e => e.PassThroughData).HasMaxLength(500);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Pagetemplateregioncontent)
                    .HasForeignKey(d => d.IncludeElementId)
                    .HasConstraintName("FK_PAGETEMPLATEREGIONCONTENT_INCLUDEELEMENT");
            });

            modelBuilder.Entity<Pagetype>(entity =>
            {
                entity.ToTable("PAGETYPE");

                entity.Property(e => e.Filename).HasMaxLength(50);

                entity.Property(e => e.IsNameEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPageLinksEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPreviewAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShownOnPageLinkList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShownOnPageList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSidebarEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSidebarRequired)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSsl).HasColumnName("IsSSL");

                entity.Property(e => e.IsTitleEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Pagetype)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PAGETYPE_CSS");
            });

            modelBuilder.Entity<Paymentblacklist>(entity =>
            {
                entity.ToTable("PAYMENTBLACKLIST");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Paymentcreditcardfailurelog>(entity =>
            {
                entity.ToTable("PAYMENTCREDITCARDFAILURELOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Paymentgateway>(entity =>
            {
                entity.ToTable("PAYMENTGATEWAY");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.DailyCutOffHour).HasDefaultValueSql("((18))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCreditCard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TestingAddress).HasMaxLength(250);
            });

            modelBuilder.Entity<Paymentgatewaytransaction>(entity =>
            {
                entity.ToTable("PAYMENTGATEWAYTRANSACTION");

                entity.HasIndex(e => new { e.PaymentGatewayTransactionId, e.MerchantDate, e.CreateDateTime, e.CustomerIpaddress, e.CompanyCreditCardTypeId, e.CreditCardNumber, e.CreditCardExpiryMonth, e.CreditCardExpiryYear, e.PaymentGatewayId, e.Amount, e.GatewayTransactionNumber, e.BankAuthCode, e.ResponseCode, e.IsApproved, e.CompanyId, e.CinemaPaymentGatewayId })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankAuthCode).HasMaxLength(500);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIpaddress)
                    .HasColumnName("CustomerIPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.GatewayTransactionNumber).HasMaxLength(500);

                entity.Property(e => e.MerchantDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2000))");

                entity.Property(e => e.ResponseCode).HasMaxLength(500);

                entity.HasOne(d => d.CinemaPaymentGateway)
                    .WithMany(p => p.Paymentgatewaytransaction)
                    .HasForeignKey(d => d.CinemaPaymentGatewayId)
                    .HasConstraintName("FK_PAYMENTGATEWAYTRANSACTION_CINEMAPAYMENTGATEWAY");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Paymentgatewaytransaction)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_PAYMENTGATEWAYTRANSACTION_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Paymentgatewaytransaction)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PAYMENTGATEWAYTRANSACTION_COMPANY");

                entity.HasOne(d => d.PaymentGateway)
                    .WithMany(p => p.Paymentgatewaytransaction)
                    .HasForeignKey(d => d.PaymentGatewayId)
                    .HasConstraintName("FK_PAYMENTGATEWAYTRANSACTION_PAYMENTGATEWAY");
            });

            modelBuilder.Entity<Pointofsaletype>(entity =>
            {
                entity.ToTable("POINTOFSALETYPE");

                entity.Property(e => e.ImportFinishedInformation).HasMaxLength(500);

                entity.Property(e => e.ImportInstructions).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.ToTable("POLL");

                entity.Property(e => e.PollId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsShowResultsAfterEntry)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageToDisplayAfterEntry).HasMaxLength(500);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pollmembertypes>(entity =>
            {
                entity.HasKey(e => e.PollMemberTypeId);

                entity.ToTable("POLLMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Pollmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_POLLMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Pollmembertypes)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_POLLMEMBERTYPES_POLL");
            });

            modelBuilder.Entity<Polloption>(entity =>
            {
                entity.ToTable("POLLOPTION");

                entity.Property(e => e.PollOptionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Polloption)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_POLLOPTION_POLL");
            });

            modelBuilder.Entity<Pollsites>(entity =>
            {
                entity.HasKey(e => e.PollSiteId);

                entity.ToTable("POLLSITES");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Pollsites)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_POLLSITES_POLL");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Pollsites)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_POLLSITES_SITE");
            });

            modelBuilder.Entity<Popup>(entity =>
            {
                entity.ToTable("POPUP");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.ImageAltText).HasMaxLength(350);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHomepageOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(350);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Popup)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POPUP_COMPANY");
            });

            modelBuilder.Entity<Popupcinema>(entity =>
            {
                entity.ToTable("POPUPCINEMA");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Popupcinema)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_POPUPCINEMA_CINEMA");

                entity.HasOne(d => d.PopUp)
                    .WithMany(p => p.Popupcinema)
                    .HasForeignKey(d => d.PopUpId)
                    .HasConstraintName("FK_POPUPCINEMA_POPUP");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("PROMOTION");

                entity.HasIndex(e => new { e.StartDateTime, e.FinishDateTime, e.DisplayStartDateTime, e.DisplayFinishDateTime, e.IsActive, e.IsPublic, e.IsApproved, e.IsShowOnMainInteractive })
                    .HasName("IX_PROMOTION_FinishDateTime_DisplayStartDateTime_DisplayFinishDateTime_IsActive_IsPublic_IsApproved_IsShowOnMainInteractive_Star");

                entity.HasIndex(e => new { e.MainInteractiveTitle, e.IsOngoing, e.IsShowDates, e.AuthorUserId, e.ApprovedByUserId, e.ExternalLinkUrl, e.IsGenerateReminders, e.PromotionCategoryId, e.IsShowOnMainInteractive, e.DisplayStartDateTime, e.DisplayFinishDateTime, e.Name, e.Description, e.IsPublic, e.ApprovalDateTime, e.CreateDateTime, e.StartDateTime, e.FinishDateTime, e.CompanyId, e.IsDeleted, e.IsActive, e.IsApproved })
                    .HasName("IX_PROMOTION_CompanyId_IsDeleted_IsActive_IsApproved_CreateDateTime_StartDateTime_FinishDateTime_DisplayStartDateTime_DisplayFin");

                entity.HasIndex(e => new { e.PromotionCategoryId, e.IsShowOnMainInteractive, e.MainInteractiveTitle, e.IsOngoing, e.IsShowDates, e.ApprovalDateTime, e.AuthorUserId, e.ApprovedByUserId, e.ExternalLinkUrl, e.IsDeleted, e.IsGenerateReminders, e.DisplayFinishDateTime, e.Name, e.Description, e.IsActive, e.IsPublic, e.IsApproved, e.CreateDateTime, e.StartDateTime, e.FinishDateTime, e.DisplayStartDateTime, e.CompanyId })
                    .HasName("IX_PROMOTION_CompanyId_CreateDateTime_StartDateTime_FinishDateTime_DisplayStartDateTime_DisplayFinishDateTime_Name_Description_I");

                entity.Property(e => e.PromotionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DisplayFinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayStartDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExternalLinkUrl)
                    .HasColumnName("ExternalLinkURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsGenerateReminders)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowDates)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainInteractiveTitle).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.PromotionApprovedByUser)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .HasConstraintName("FK_PROMOTION_aspnet_Users1");

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.PromotionAuthorUser)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_aspnet_Users");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Promotion)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PROMOTION_COMPANY");

                entity.HasOne(d => d.PromotionCategory)
                    .WithMany(p => p.Promotion)
                    .HasForeignKey(d => d.PromotionCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_PROMOTIONCATEGORY");
            });

            modelBuilder.Entity<Promotionaloffer>(entity =>
            {
                entity.ToTable("PROMOTIONALOFFER");

                entity.Property(e => e.PromotionalOfferId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.PromotionalOfferImage)
                    .WithMany(p => p.Promotionaloffer)
                    .HasForeignKey(d => d.PromotionalOfferImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PROMOTIONALOFFER_PROMOTIONALOFFERSIMAGE");
            });

            modelBuilder.Entity<Promotionalofferlocation>(entity =>
            {
                entity.ToTable("PROMOTIONALOFFERLOCATION");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Promotionalofferlocation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTIONALOFFERLOCATJON_COMPANY");
            });

            modelBuilder.Entity<Promotionaloffersimage>(entity =>
            {
                entity.ToTable("PROMOTIONALOFFERSIMAGE");

                entity.Property(e => e.PromotionalOffersImageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Promotionaloffersimage)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PROMOTIONALOFFERSIMAGE_COMPANY");
            });

            modelBuilder.Entity<Promotioncategory>(entity =>
            {
                entity.ToTable("PROMOTIONCATEGORY");

                entity.Property(e => e.PromotionCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Promotioncategory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PROMOTIONCATEGORY_COMPANY");
            });

            modelBuilder.Entity<Promotioncinemas>(entity =>
            {
                entity.HasKey(e => e.PromotionCinemaId);

                entity.ToTable("PROMOTIONCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Promotioncinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_PROMOTIONCINEMAS_CINEMA");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Promotioncinemas)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_PROMOTIONCINEMAS_PROMOTION");
            });

            modelBuilder.Entity<Promotionelement>(entity =>
            {
                entity.ToTable("PROMOTIONELEMENT");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.InformationText).HasMaxLength(1000);

                entity.Property(e => e.PassThroughData).HasMaxLength(1000);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Promotionelement)
                    .HasForeignKey(d => d.IncludeElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTIONELEMENT_INCLUDEELEMENT");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Promotionelement)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_PROMOTIONELEMENT_PROMOTION");
            });

            modelBuilder.Entity<Promotionmembertypes>(entity =>
            {
                entity.HasKey(e => e.PromotionMemberTypeId);

                entity.ToTable("PROMOTIONMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Promotionmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_PROMOTIONMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Promotionmembertypes)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_PROMOTIONMEMBERTYPES_PROMOTION");
            });

            modelBuilder.Entity<Promotionsites>(entity =>
            {
                entity.HasKey(e => e.PromotionSiteId);

                entity.ToTable("PROMOTIONSITES");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.ToTable("QUOTE");

                entity.Property(e => e.QuoteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EstimatedCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.HourlyRate).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_QUOTE_CMSUSER");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QUOTE_COMPANY");

                entity.HasOne(d => d.HelpdeskTicket)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.HelpdeskTicketId)
                    .HasConstraintName("FK_QUOTE_HELPDESKTICKET");

                entity.HasOne(d => d.TransactionLog)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.TransactionLogId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_QUOTE_TRANSACTIONLOG");
            });

            modelBuilder.Entity<Radcaptchacache>(entity =>
            {
                entity.ToTable("RADCAPTCHACACHE");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("RATING");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsRated)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_RATING_COUNTRY");
            });

            modelBuilder.Entity<Ratingchangelog>(entity =>
            {
                entity.ToTable("RATINGCHANGELOG");

                entity.Property(e => e.CmsuserId).HasColumnName("CMSUserId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.NewConsumerAdvice).HasMaxLength(200);

                entity.Property(e => e.NewRating)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NewRunningTime).HasMaxLength(50);

                entity.Property(e => e.OldConsumerAdvice).HasMaxLength(200);

                entity.Property(e => e.OldRating)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldRunningTime).HasMaxLength(50);

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Ratingchangelog)
                    .HasForeignKey(d => d.CmsuserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RATINGCHANGELOG_CMSUSER");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Ratingchangelog)
                    .HasForeignKey(d => d.MovieDetailId)
                    .HasConstraintName("FK_RATINGCHANGELOG_MOVIEDETAIL");
            });

            modelBuilder.Entity<Retrieverticketingbooking>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGBOOKING");

                entity.Property(e => e.RetrieverTicketingBookingId).ValueGeneratedNever();

                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumberCvv)
                    .HasColumnName("CreditCardNumberCVV")
                    .HasMaxLength(5);

                entity.Property(e => e.CreditCardPaymentAmount).HasColumnType("money");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIpaddress)
                    .HasColumnName("CustomerIPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultBookingFeePerTicket).HasColumnType("money");

                entity.Property(e => e.ErrorText).HasMaxLength(500);

                entity.Property(e => e.IsSendSms).HasColumnName("IsSendSMS");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCreditCard)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PriceGroup).HasMaxLength(50);

                entity.Property(e => e.RetrieverConfimationNumber).HasMaxLength(50);

                entity.Property(e => e.RetrieverTicketingPromoId).HasColumnName("RetrieverTicketingPromoID");

                entity.Property(e => e.RetrieverTicketingSettingVifdataId).HasColumnName("RetrieverTicketingSettingVIFDataId");

                entity.Property(e => e.SessionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionPointOfSaleId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Smscost)
                    .HasColumnName("SMSCost")
                    .HasColumnType("money");

                entity.Property(e => e.SmslogId).HasColumnName("SMSLogId");

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.StoredValueCardClosingBalance).HasColumnType("money");

                entity.Property(e => e.StoredValueCardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoredValueCardPaymentAmount).HasColumnType("money");

                entity.Property(e => e.StoredValueCardPin)
                    .HasColumnName("StoredValueCardPIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoredValueCardStartingBalance).HasColumnType("money");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalCostOfBookingFees).HasColumnType("money");

                entity.Property(e => e.TotalCostOfTickets).HasColumnType("money");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_CINEMA");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_PAYMENTGATEWAYTRANSACTION");

                entity.HasOne(d => d.RetrieverTicketingBooking)
                    .WithOne(p => p.InverseRetrieverTicketingBooking)
                    .HasForeignKey<Retrieverticketingbooking>(d => d.RetrieverTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_RETRIEVERTICKETINGBOOKING");

                entity.HasOne(d => d.RetrieverTicketingSettingVifdata)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.RetrieverTicketingSettingVifdataId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_RETRIEVERTICKETINGSETTINGDATA");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_SCREEN");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Retrieverticketingbooking)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKING_SESSION");
            });

            modelBuilder.Entity<Retrieverticketingbookinglog>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGBOOKINGLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.HasOne(d => d.RetrieverTicketingBooking)
                    .WithMany(p => p.Retrieverticketingbookinglog)
                    .HasForeignKey(d => d.RetrieverTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKINGLOG_RETRIEVERTICKETINGBOOKING");
            });

            modelBuilder.Entity<Retrieverticketingbookingreceipt>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGBOOKINGRECEIPT");

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.HasOne(d => d.RetrieverTicketingBooking)
                    .WithMany(p => p.Retrieverticketingbookingreceipt)
                    .HasForeignKey(d => d.RetrieverTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKINGRECEIPT_RETRIEVERTICKETINGBOOKING");
            });

            modelBuilder.Entity<Retrieverticketingbookingtickets>(entity =>
            {
                entity.HasKey(e => e.RetrieverTicketingBookingTicketId);

                entity.ToTable("RETRIEVERTICKETINGBOOKINGTICKETS");

                entity.Property(e => e.RetrieverTicketingBookingTicketId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PosseatId)
                    .HasColumnName("POSSeatId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetrieverTicketingSettingVifprlid).HasColumnName("RetrieverTicketingSettingVIFPRLId");

                entity.Property(e => e.RetrieverTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicketName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherCode).HasMaxLength(50);

                entity.HasOne(d => d.RetrieverTicketingBooking)
                    .WithMany(p => p.Retrieverticketingbookingtickets)
                    .HasForeignKey(d => d.RetrieverTicketingBookingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKINGTICKETS_RETRIEVERTICKETINGBOOKING");

                entity.HasOne(d => d.RetrieverTicketingSettingVifprl)
                    .WithMany(p => p.Retrieverticketingbookingtickets)
                    .HasForeignKey(d => d.RetrieverTicketingSettingVifprlid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKINGTICKETS_RETRIEVERTICKETINGSETTINGPRICEGROUP");

                entity.HasOne(d => d.RetrieverTicketingTicketSetting)
                    .WithMany(p => p.Retrieverticketingbookingtickets)
                    .HasForeignKey(d => d.RetrieverTicketingTicketSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGBOOKINGTICKETS_RETRIEVERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Retrieverticketingexternalparty>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGEXTERNALPARTY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Retrieverticketingpromo>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGPROMO");

                entity.Property(e => e.RetrieverTicketingPromoId).HasColumnName("RetrieverTicketingPromoID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.RetrieverTicketingSetting)
                    .WithMany(p => p.Retrieverticketingpromo)
                    .HasForeignKey(d => d.RetrieverTicketingSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGPROMO_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsetting>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGSETTING");

                entity.Property(e => e.RetrieverTicketingSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFeeForVoucherRedemptions).HasColumnType("money");

                entity.Property(e => e.CashierProfile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionTestDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataCacheExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1.00))");

                entity.Property(e => e.EmergencyContactEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactMobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReceiptText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTicketSelectionPageItemIntroduction).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextAboveTable).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextBelowTable).HasMaxLength(1000);

                entity.Property(e => e.IsOfferSms).HasColumnName("IsOfferSMS");

                entity.Property(e => e.JoinMailingListText)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastReportDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.MaximumTicketsPerOrder).HasDefaultValueSql("((10))");

                entity.Property(e => e.MemberLoginIntroductionText).HasMaxLength(2000);

                entity.Property(e => e.MinimumTicketsPerOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.MobileIntroduction).HasMaxLength(500);

                entity.Property(e => e.MobileMemberLoginIntroductionText).HasMaxLength(1000);

                entity.Property(e => e.MobileReceiptText).HasMaxLength(2000);

                entity.Property(e => e.NotAllocatedSessionPopupText).HasMaxLength(1000);

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SendReceiptFromEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendReceiptFromName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmsratePerMessageBilledToCustomer)
                    .HasColumnName("SMSRatePerMessageBilledToCustomer")
                    .HasColumnType("money");

                entity.Property(e => e.StartPageMessage).HasMaxLength(2000);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Retrieverticketingsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTING_CINEMA");
            });

            modelBuilder.Entity<Retrieverticketingsettingdata>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGSETTINGDATA");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.RetrieverTicketingSetting)
                    .WithMany(p => p.Retrieverticketingsettingdata)
                    .HasForeignKey(d => d.RetrieverTicketingSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGDATA_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsettingexternalparties>(entity =>
            {
                entity.HasKey(e => e.RetrieverTicketingSettingExternalPartyId);

                entity.ToTable("RETRIEVERTICKETINGSETTINGEXTERNALPARTIES");

                entity.HasOne(d => d.RetrieverTicketingExternalParty)
                    .WithMany(p => p.Retrieverticketingsettingexternalparties)
                    .HasForeignKey(d => d.RetrieverTicketingExternalPartyId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGEXTERNALPARTIES_RETRIEVERTICKETINGSETTINGEXTERNALPARTIES");

                entity.HasOne(d => d.RetrieverTicketingSetting)
                    .WithMany(p => p.Retrieverticketingsettingexternalparties)
                    .HasForeignKey(d => d.RetrieverTicketingSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGEXTERNALPARTIES_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsettinglog>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGSETTINGLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.HasOne(d => d.RetrieverTicketingSetting)
                    .WithMany(p => p.Retrieverticketingsettinglog)
                    .HasForeignKey(d => d.RetrieverTicketingSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGLOG_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsettingpricegroup>(entity =>
            {
                entity.HasKey(e => e.RetrieverTicketSettingPriceGroupId);

                entity.ToTable("RETRIEVERTICKETINGSETTINGPRICEGROUP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PriceGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceIncludingLinkedTicket).HasColumnType("money");

                entity.Property(e => e.RetrieverCinemaId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.RetrieverTicketSettingTicket)
                    .WithMany(p => p.Retrieverticketingsettingpricegroup)
                    .HasForeignKey(d => d.RetrieverTicketSettingTicketId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGPRICEGROUP_RETRIEVERTICKETINGSETTINGTICKET");

                entity.HasOne(d => d.RetrieverTicketingSettingData)
                    .WithMany(p => p.Retrieverticketingsettingpricegroup)
                    .HasForeignKey(d => d.RetrieverTicketingSettingDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGPRICEGROUP_RETRIEVERTICKETINGSETTINGDATA");

                entity.HasOne(d => d.RetrieverTicketingSetting)
                    .WithMany(p => p.Retrieverticketingsettingpricegroup)
                    .HasForeignKey(d => d.RetrieverTicketingSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGPRICEGROUP_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsettingseattype>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGSETTINGSEATTYPE");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RetrieverTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.RetrieverTicketingTicketSetting)
                    .WithMany(p => p.Retrieverticketingsettingseattype)
                    .HasForeignKey(d => d.RetrieverTicketingTicketSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGSEATTYPE_RETRIEVERTICKETINGSETTING");
            });

            modelBuilder.Entity<Retrieverticketingsettingticket>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGSETTINGTICKET");

                entity.Property(e => e.AreaCatStrCode).HasColumnName("AreaCat_strCode");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfSeats).HasDefaultValueSql("((1))");

                entity.Property(e => e.TicketPrice)
                    .HasColumnName("Ticket_Price")
                    .HasColumnType("money");

                entity.Property(e => e.TicketTax)
                    .HasColumnName("Ticket_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.TicketTotal)
                    .HasColumnName("Ticket_Total")
                    .HasColumnType("money");

                entity.HasOne(d => d.RetrieverTicketingSettingData)
                    .WithMany(p => p.Retrieverticketingsettingticket)
                    .HasForeignKey(d => d.RetrieverTicketingSettingDataId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGTICKET_RETRIEVERTICKETINGSETTINGDATA");

                entity.HasOne(d => d.RetrieverTicketingTicketType)
                    .WithMany(p => p.Retrieverticketingsettingticket)
                    .HasForeignKey(d => d.RetrieverTicketingTicketTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGSETTINGTICKET_RETRIEVERTICKETINGTICKETTYPE");
            });

            modelBuilder.Entity<Retrieverticketingticketsetting>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGTICKETSETTING");

                entity.Property(e => e.RetrieverTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalReceiptTextAfterGenericText)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.AdditionalTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.AdditionalTicketSelectionPageText).HasMaxLength(1500);

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PopUpMessageText).HasMaxLength(800);

                entity.Property(e => e.RetrieverTicketingPromoId).HasColumnName("RetrieverTicketingPromoID");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Retrieverticketingticketsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETSETTING_CINEMA");

                entity.HasOne(d => d.RetrieverTicketingPromo)
                    .WithMany(p => p.Retrieverticketingticketsetting)
                    .HasForeignKey(d => d.RetrieverTicketingPromoId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETSETTING_RETRIEVERTICKETINGPROMO");
            });

            modelBuilder.Entity<Retrieverticketingticketsettingcheckbox>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGTICKETSETTINGCHECKBOX");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Retrieverticketingticketsettingcheckbox)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETSETTINGCHECKBOX_CINEMA");

                entity.HasOne(d => d.RetrieverTicketingTicketSetting)
                    .WithMany(p => p.Retrieverticketingticketsettingcheckbox)
                    .HasForeignKey(d => d.RetrieverTicketingTicketSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETSETTINGCHECKBOX_RETRIEVERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Retrieverticketingticketsettingmembertypes>(entity =>
            {
                entity.HasKey(e => e.RetrieverTicketingTicketSettingMemberTypeId);

                entity.ToTable("RETRIEVERTICKETINGTICKETSETTINGMEMBERTYPES");

                entity.HasOne(d => d.RetrieverTicketingTicketSetting)
                    .WithMany(p => p.Retrieverticketingticketsettingmembertypes)
                    .HasForeignKey(d => d.RetrieverTicketingTicketSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETSETTINGMEMBERTYPES_RETRIEVERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Retrieverticketingtickettype>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGTICKETTYPE");

                entity.Property(e => e.RetrieverTicketingTicketTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.ExternalReference1).HasMaxLength(250);

                entity.Property(e => e.ExternalReference2).HasMaxLength(250);

                entity.Property(e => e.ExternalReference3).HasMaxLength(250);

                entity.Property(e => e.PrerequisiteTicketCode).HasMaxLength(20);

                entity.Property(e => e.PrerequisiteTicketNameForDisplay).HasMaxLength(50);

                entity.Property(e => e.TicketCodeToMatch)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TicketNameForDisplay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketSelectionItemText).HasMaxLength(500);

                entity.Property(e => e.ToolTipMessage).HasMaxLength(200);

                entity.HasOne(d => d.RetrieverTicketingExternalParty)
                    .WithMany(p => p.Retrieverticketingtickettype)
                    .HasForeignKey(d => d.RetrieverTicketingExternalPartyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETTYPE_RETRIEVERTICKETINGEXTERNALPARTY");

                entity.HasOne(d => d.RetrieverTicketingTicketSetting)
                    .WithMany(p => p.Retrieverticketingtickettype)
                    .HasForeignKey(d => d.RetrieverTicketingTicketSettingId)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETTYPE_RETRIEVERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Retrieverticketingtickettypemovie>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGTICKETTYPEMOVIE");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Retrieverticketingtickettypemovie)
                    .HasForeignKey(d => d.MovieDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETTYPEMOVIE_RETRIEVERTICKETINGTICKETTYPEMOVIE");

                entity.HasOne(d => d.RetrieverTicketingTicketType)
                    .WithMany(p => p.Retrieverticketingtickettypemovie)
                    .HasForeignKey(d => d.RetrieverTicketingTicketTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGTICKETTYPEMOVIE_RETRIEVERTICKETINGTICKETTYPE");
            });

            modelBuilder.Entity<Retrieverticketingvoucher>(entity =>
            {
                entity.ToTable("RETRIEVERTICKETINGVOUCHER");

                entity.Property(e => e.VoucherBarcode).HasMaxLength(50);

                entity.Property(e => e.VoucherExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherRedemptionDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherTicketCode).HasMaxLength(10);

                entity.Property(e => e.VoucherTicketDescription).HasMaxLength(50);

                entity.HasOne(d => d.RetrieverTicketingBooking)
                    .WithMany(p => p.Retrieverticketingvoucher)
                    .HasForeignKey(d => d.RetrieverTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RETRIEVERTICKETINGVOUCHER_RETRIEVERTICKETINGBOOKING");
            });

            modelBuilder.Entity<Retrieverticketingvouchertype>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeid);

                entity.ToTable("RETRIEVERTICKETINGVOUCHERTYPE");

                entity.Property(e => e.VoucherName).HasMaxLength(50);
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("SALUTATION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("SCREEN");

                entity.Property(e => e.ScreenId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IsDisplayOnSessionToolTip)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsValidateSeatSelection)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SeatingMapText).HasMaxLength(250);

                entity.Property(e => e.SoldOutLimit).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Screen)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCREEN_CINEMA");

                entity.HasOne(d => d.ScreenType)
                    .WithMany(p => p.Screen)
                    .HasForeignKey(d => d.ScreenTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCREEN_SCREENTYPE");
            });

            modelBuilder.Entity<Screenfeature>(entity =>
            {
                entity.ToTable("SCREENFEATURE");

                entity.Property(e => e.ScreenFeatureId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Screenfeature)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SCREENFEATURE_CINEMA");
            });

            modelBuilder.Entity<Screenscreenfeatures>(entity =>
            {
                entity.HasKey(e => e.ScreenScreenFeatureId);

                entity.ToTable("SCREENSCREENFEATURES");

                entity.Property(e => e.ScreenScreenFeatureId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ScreenFeature)
                    .WithMany(p => p.Screenscreenfeatures)
                    .HasForeignKey(d => d.ScreenFeatureId)
                    .HasConstraintName("FK_SCREENSCREENFEATURES_SCREENFEATURE");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Screenscreenfeatures)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_SCREENSCREENFEATURES_SCREEN");
            });

            modelBuilder.Entity<Screenseat>(entity =>
            {
                entity.ToTable("SCREENSEAT");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Screenseat)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_SCREENSEAT_SCREEN");
            });

            modelBuilder.Entity<Screentype>(entity =>
            {
                entity.ToTable("SCREENTYPE");

                entity.Property(e => e.ScreenTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Abbreviation).HasMaxLength(5);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Screentype)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SCREENTYPE_CINEMA");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("SESSION");

                entity.HasIndex(e => new { e.MovieInstanceId, e.CinemaId, e.DateTime })
                    .HasName("IX_SessionMovieInstanceCinemaDT");

                entity.Property(e => e.BookingUrl)
                    .HasColumnName("BookingURL")
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.PointOfSaleId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESSION_CINEMA");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_SESSION_MOVIEINSTANCE");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_SESSION_SCREEN");
            });

            modelBuilder.Entity<Sessioncreationrule>(entity =>
            {
                entity.ToTable("SESSIONCREATIONRULE");

                entity.Property(e => e.SessionCreationRuleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.InformationText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_CINEMA");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_DAY");

                entity.HasOne(d => d.ExcludeMovieCategory)
                    .WithMany(p => p.SessioncreationruleExcludeMovieCategory)
                    .HasForeignKey(d => d.ExcludeMovieCategoryId)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_MOVIECATEGORY1");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_FLAG");

                entity.HasOne(d => d.MovieCategory)
                    .WithMany(p => p.SessioncreationruleMovieCategory)
                    .HasForeignKey(d => d.MovieCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_MOVIECATEGORY");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_MOVIEINSTANCE");

                entity.HasOne(d => d.MovieType)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.MovieTypeId)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_MOVIETYPE");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Sessioncreationrule)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SESSIONCREATIONRULE_SCREEN");
            });

            modelBuilder.Entity<Sessionflags>(entity =>
            {
                entity.HasKey(e => e.SessionFlagId);

                entity.ToTable("SESSIONFLAGS");

                entity.HasIndex(e => new { e.FlagId, e.SessionId })
                    .HasName("IX_SessionFlagsBySessionId");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Sessionflags)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_SESSIONFLAGS_FLAG");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Sessionflags)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_SESSIONFLAGS_SESSION");
            });

            modelBuilder.Entity<Sessionimportattempt>(entity =>
            {
                entity.ToTable("SESSIONIMPORTATTEMPT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(150);

                entity.Property(e => e.ErrorText).HasMaxLength(1500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnmatchedMovieList).HasMaxLength(1500);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Sessionimportattempt)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SESSIONIMPORTLOG_CINEMA");
            });

            modelBuilder.Entity<Sessionimportattemptimportedsession>(entity =>
            {
                entity.ToTable("SESSIONIMPORTATTEMPTIMPORTEDSESSION");

                entity.Property(e => e.IsAd).HasColumnName("IsAD");

                entity.Property(e => e.IsCc).HasColumnName("IsCC");

                entity.Property(e => e.IsLq).HasColumnName("IsLQ");

                entity.Property(e => e.IsNft).HasColumnName("IsNFT");

                entity.Property(e => e.MovieId).HasMaxLength(50);

                entity.Property(e => e.MovieTitle).HasMaxLength(100);

                entity.Property(e => e.ScreenNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SessionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionPointOfSaleId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.SessionImportAttempt)
                    .WithMany(p => p.Sessionimportattemptimportedsession)
                    .HasForeignKey(d => d.SessionImportAttemptId)
                    .HasConstraintName("FK_SESSIONIMPORTATTEMPTIMPORTEDSESSION_SESSIONIMPORTATTEMPT");
            });

            modelBuilder.Entity<Sessionimportattemptlog>(entity =>
            {
                entity.ToTable("SESSIONIMPORTATTEMPTLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.SessionImportAttempt)
                    .WithMany(p => p.Sessionimportattemptlog)
                    .HasForeignKey(d => d.SessionImportAttemptId)
                    .HasConstraintName("FK_SESSIONIMPORTATTEMPTLOG_SESSIONIMPORTATTEMPT");
            });

            modelBuilder.Entity<Sessionimportattemptunmatchedmovie>(entity =>
            {
                entity.ToTable("SESSIONIMPORTATTEMPTUNMATCHEDMOVIE");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.SessionImportAttempt)
                    .WithMany(p => p.Sessionimportattemptunmatchedmovie)
                    .HasForeignKey(d => d.SessionImportAttemptId)
                    .HasConstraintName("FK_SESSIONIMPORTATTEMPTUNMATCHEDMOVIE_SESSIONIMPORTATTEMPT");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("SHOP");

                entity.Property(e => e.ShopId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('AUD')");

                entity.Property(e => e.DefaultPostageAndHandlingFeeIncludingTax).HasColumnType("money");

                entity.Property(e => e.EmailProductDeliveryText).HasMaxLength(1500);

                entity.Property(e => e.IsGenerateAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShopTaxInformationOnReceipt)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiptText)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.SendingAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('sendingaddress@yourdomain.com')");

                entity.Property(e => e.SendingName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('GST')");

                entity.Property(e => e.TaxPercent).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SHOP_COMPANY");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SHOP_CSS");
            });

            modelBuilder.Entity<Shopcart>(entity =>
            {
                entity.ToTable("SHOPCART");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopcart)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPCART_SHOP");
            });

            modelBuilder.Entity<Shopcartitems>(entity =>
            {
                entity.HasKey(e => e.ShopCartItemId);

                entity.ToTable("SHOPCARTITEMS");

                entity.Property(e => e.ShopProductVariationPriceId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ShopCart)
                    .WithMany(p => p.Shopcartitems)
                    .HasForeignKey(d => d.ShopCartId)
                    .HasConstraintName("FK_SHOPCARTITEMS_SHOPCART");

                entity.HasOne(d => d.ShopProductVariationPrice)
                    .WithMany(p => p.Shopcartitems)
                    .HasForeignKey(d => d.ShopProductVariationPriceId)
                    .HasConstraintName("FK_SHOPCARTITEMS_SHOPPRODUCTVARIATIONPRICE");
            });

            modelBuilder.Entity<Shopcategory>(entity =>
            {
                entity.ToTable("SHOPCATEGORY");

                entity.Property(e => e.ShopCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IntroductionText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsShowProductDetail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopcategory)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPCATEGORY_SHOP");
            });

            modelBuilder.Entity<Shopcinema>(entity =>
            {
                entity.ToTable("SHOPCINEMA");

                entity.Property(e => e.IsSendNotificationEmailPerOrder)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2011))");

                entity.Property(e => e.NotificationEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryFrequencyInDays).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Shopcinema)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPCINEMA_CINEMA");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopcinema)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPCINEMA_SHOP");
            });

            modelBuilder.Entity<Shopdeliverymethod>(entity =>
            {
                entity.ToTable("SHOPDELIVERYMETHOD");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsPhysicalDelivery)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTaxable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderCompleteEmailText).HasMaxLength(2000);

                entity.Property(e => e.PostageAndHandlingFeeIncludingTax).HasColumnType("money");

                entity.Property(e => e.TrackingUrl)
                    .HasColumnName("TrackingURL")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopdeliverymethod)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPDELIVERYMETHOD_SHOP");
            });

            modelBuilder.Entity<Shopnotification>(entity =>
            {
                entity.ToTable("SHOPNOTIFICATION");

                entity.Property(e => e.IsSendNotificationEmailPerOrder)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(2011))");

                entity.Property(e => e.NotificationEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryFrequencyInDays).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopnotification)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPNOTIFICATION_SHOP");
            });

            modelBuilder.Entity<Shopnotificationcinemas>(entity =>
            {
                entity.HasKey(e => e.ShopNotificationCinemaId);

                entity.ToTable("SHOPNOTIFICATIONCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Shopnotificationcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SHOPNOTIFICATIONCINEMAS_CINEMA");

                entity.HasOne(d => d.ShopNotification)
                    .WithMany(p => p.Shopnotificationcinemas)
                    .HasForeignKey(d => d.ShopNotificationId)
                    .HasConstraintName("FK_SHOPNOTIFICATIONCINEMAS_SHOPNOTIFICATION");
            });

            modelBuilder.Entity<Shoporder>(entity =>
            {
                entity.ToTable("SHOPORDER");

                entity.Property(e => e.ShopOrderId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdministratorNotes).HasMaxLength(500);

                entity.Property(e => e.CommitedToVenue).HasColumnName("commitedToVenue");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumberCvv)
                    .HasColumnName("CreditCardNumberCVV")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomerAddress1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerAddress2).HasMaxLength(200);

                entity.Property(e => e.CustomerCompanyName).HasMaxLength(300);

                entity.Property(e => e.CustomerCountryStateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFirstname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerLastname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.CustomerPostCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerSuburb)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryAddress1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DeliveryAddress2).HasMaxLength(200);

                entity.Property(e => e.DeliveryCompanyName).HasMaxLength(300);

                entity.Property(e => e.DeliveryCostIncludingTax).HasColumnType("money");

                entity.Property(e => e.DeliveryCountryStateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryFirstname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryLastname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.DeliveryPostCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DeliverySuburb)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryTaxCost).HasColumnType("money");

                entity.Property(e => e.GiftMessage).HasMaxLength(500);

                entity.Property(e => e.GiftRecipientEmail).HasMaxLength(200);

                entity.Property(e => e.GiftRecipientName).HasMaxLength(250);

                entity.Property(e => e.GiftSenderName).HasMaxLength(250);

                entity.Property(e => e.IsPdfsent).HasColumnName("IsPDFSent");

                entity.Property(e => e.IsSameAddress)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameOnCreditCard)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCostIncludingTax).HasColumnType("money");

                entity.Property(e => e.ProductTaxCost).HasColumnType("money");

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.Property(e => e.ShipDateTime).HasColumnType("datetime");

                entity.Property(e => e.SimpleCode).HasMaxLength(6);

                entity.Property(e => e.TotalCostIncludingTax).HasColumnType("money");

                entity.Property(e => e.TotalTaxCost).HasColumnType("money");

                entity.Property(e => e.TrackingCode).HasMaxLength(250);

                entity.Property(e => e.VifbookingKey)
                    .HasColumnName("VIFBookingKey")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkstationId).HasColumnName("workstationId");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SHOPORDER_CINEMA");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_SHOPORDER_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.CustomerCountryState)
                    .WithMany(p => p.ShoporderCustomerCountryState)
                    .HasForeignKey(d => d.CustomerCountryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPORDER_COUNTRYSTATE");

                entity.HasOne(d => d.DeliveryCountryState)
                    .WithMany(p => p.ShoporderDeliveryCountryState)
                    .HasForeignKey(d => d.DeliveryCountryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPORDER_COUNTRYSTATE1");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SHOPORDER_MEMBER");

                entity.HasOne(d => d.ShopCart)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.ShopCartId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SHOPORDER_SHOPCART");

                entity.HasOne(d => d.ShopDeliveryMethod)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.ShopDeliveryMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPORDER_SHOPDELIVERYMETHOD");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPORDER_SHOP");

                entity.HasOne(d => d.ShopOrderStatus)
                    .WithMany(p => p.Shoporder)
                    .HasForeignKey(d => d.ShopOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPORDER_SHOPORDERSTATUS");
            });

            modelBuilder.Entity<Shoporderactivitylog>(entity =>
            {
                entity.ToTable("SHOPORDERACTIVITYLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(3000);

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.Shoporderactivitylog)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_SHOPORDERACTIVITYLOG_SHOPORDER");
            });

            modelBuilder.Entity<Shoporderproducts>(entity =>
            {
                entity.HasKey(e => e.ShopOrderProductId);

                entity.ToTable("SHOPORDERPRODUCTS");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.TicketCode).HasMaxLength(50);

                entity.Property(e => e.VenueVoucherBarcode).HasMaxLength(150);

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.Shoporderproducts)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_SHOPORDERPRODUCTS_SHOPORDER");

                entity.HasOne(d => d.ShopProductVariationPrice)
                    .WithMany(p => p.Shoporderproducts)
                    .HasForeignKey(d => d.ShopProductVariationPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPORDERPRODUCTS_SHOPPRODUCTVARIATIONPRICE");
            });

            modelBuilder.Entity<Shoporderstatus>(entity =>
            {
                entity.ToTable("SHOPORDERSTATUS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shoppricegroup>(entity =>
            {
                entity.ToTable("SHOPPRICEGROUP");

                entity.Property(e => e.ShopPriceGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shoppricegroup)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPPRICEGROUP_SHOP");
            });

            modelBuilder.Entity<Shoppricegroupmembertypes>(entity =>
            {
                entity.HasKey(e => e.ShopPriceGroupMemberTypeId);

                entity.ToTable("SHOPPRICEGROUPMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Shoppricegroupmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_SHOPPRICEGROUPMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.ShopPriceGroup)
                    .WithMany(p => p.Shoppricegroupmembertypes)
                    .HasForeignKey(d => d.ShopPriceGroupId)
                    .HasConstraintName("FK_SHOPPRICEGROUPMEMBERTYPES_SHOPPRICEGROUP");
            });

            modelBuilder.Entity<Shopproduct>(entity =>
            {
                entity.ToTable("SHOPPRODUCT");

                entity.Property(e => e.ShopProductId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.EmailDeliveryProductHtml).HasColumnName("EmailDeliveryProductHTML");

                entity.Property(e => e.FooterDescription).HasMaxLength(1000);

                entity.Property(e => e.IsTaxable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinimumPurchaseNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PostageAndHandlingFeeIncludingTax).HasColumnType("money");

                entity.Property(e => e.PostageAndHandlingText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'postage and handling per item.')");

                entity.Property(e => e.ProcessingInstructions)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.TermsAndConditions).HasMaxLength(1000);

                entity.HasOne(d => d.ShopCategory)
                    .WithMany(p => p.Shopproduct)
                    .HasForeignKey(d => d.ShopCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPPRODUCT_SHOPCATEGORY");
            });

            modelBuilder.Entity<Shopproductshopdeliverymethods>(entity =>
            {
                entity.HasKey(e => e.ShopProductShopDeliveryMethodId);

                entity.ToTable("SHOPPRODUCTSHOPDELIVERYMETHODS");

                entity.HasOne(d => d.ShopDeliveryMethod)
                    .WithMany(p => p.Shopproductshopdeliverymethods)
                    .HasForeignKey(d => d.ShopDeliveryMethodId)
                    .HasConstraintName("FK_SHOPPRODUCTSHOPDELIVERYMETHODS_SHOPDELIVERYMETHOD");

                entity.HasOne(d => d.ShopProduct)
                    .WithMany(p => p.Shopproductshopdeliverymethods)
                    .HasForeignKey(d => d.ShopProductId)
                    .HasConstraintName("FK_SHOPPRODUCTSHOPDELIVERYMETHODS_SHOPPRODUCT");
            });

            modelBuilder.Entity<Shopproductvariationprice>(entity =>
            {
                entity.ToTable("SHOPPRODUCTVARIATIONPRICE");

                entity.Property(e => e.ShopProductVariationPriceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceIncludingTax).HasColumnType("money");

                entity.Property(e => e.ShopPriceGroupId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ShopPriceGroup)
                    .WithMany(p => p.Shopproductvariationprice)
                    .HasForeignKey(d => d.ShopPriceGroupId)
                    .HasConstraintName("FK_SHOPPRODUCTVARIATIONPRICE_SHOPPRICEGROUP");

                entity.HasOne(d => d.ShopProduct)
                    .WithMany(p => p.Shopproductvariationprice)
                    .HasForeignKey(d => d.ShopProductId)
                    .HasConstraintName("FK_SHOPPRODUCTVARIATIONPRICE_SHOPPRODUCT1");
            });

            modelBuilder.Entity<Shopproductvariationpricecinemas>(entity =>
            {
                entity.HasKey(e => e.ShopProductVariationPriceCinemaId);

                entity.ToTable("SHOPPRODUCTVARIATIONPRICECINEMAS");

                entity.Property(e => e.ShopProductVariationPriceId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Shopproductvariationpricecinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SHOPPRODUCTVARIATIONPRICECINEMAS_CINEMA");

                entity.HasOne(d => d.ShopProductVariationPrice)
                    .WithMany(p => p.Shopproductvariationpricecinemas)
                    .HasForeignKey(d => d.ShopProductVariationPriceId)
                    .HasConstraintName("FK_SHOPPRODUCTVARIATIONPRICECINEMAS_SHOPPRODUCTVARIATIONPRICE");
            });

            modelBuilder.Entity<Shopsites>(entity =>
            {
                entity.HasKey(e => e.ShopSiteId);

                entity.ToTable("SHOPSITES");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Shopsites)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_SHOPSITES_SHOP");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Shopsites)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHOPSITES_SITE");
            });

            modelBuilder.Entity<Sidebar>(entity =>
            {
                entity.ToTable("SIDEBAR");

                entity.Property(e => e.SidebarId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FacebookColorSchemeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('Default')");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Sidebar)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SIDEBAR_CSS");

                entity.HasOne(d => d.FacebookColorScheme)
                    .WithMany(p => p.Sidebar)
                    .HasForeignKey(d => d.FacebookColorSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIDEBAR_FACEBOOKCOLORSCHEME");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sidebar)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIDEBAR_SITE");
            });

            modelBuilder.Entity<Sidebarelement>(entity =>
            {
                entity.ToTable("SIDEBARELEMENT");

                entity.Property(e => e.InformationText).HasMaxLength(300);

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PassThroughData)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Sidebarelement)
                    .HasForeignKey(d => d.IncludeElementId)
                    .HasConstraintName("FK_SIDEBARELEMENT_INCLUDEELEMENT");

                entity.HasOne(d => d.Sidebar)
                    .WithMany(p => p.Sidebarelement)
                    .HasForeignKey(d => d.SidebarId)
                    .HasConstraintName("FK_SIDEBARELEMENT_SIDEBAR");
            });

            modelBuilder.Entity<Sidebarelementcinemas>(entity =>
            {
                entity.HasKey(e => e.SidebarElementCinemaId);

                entity.ToTable("SIDEBARELEMENTCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Sidebarelementcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SIDEBARELEMENTCINEMAS_CINEMA");

                entity.HasOne(d => d.SidebarElement)
                    .WithMany(p => p.Sidebarelementcinemas)
                    .HasForeignKey(d => d.SidebarElementId)
                    .HasConstraintName("FK_SIDEBARELEMENTCINEMAS_SIDEBARELEMENT");
            });

            modelBuilder.Entity<Sidebarelementmembertypes>(entity =>
            {
                entity.HasKey(e => e.SidebarElementMemberTypeId);

                entity.ToTable("SIDEBARELEMENTMEMBERTYPES");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Sidebarelementmembertypes)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_SIDEBARELEMENTMEMBERTYPES_MEMBERTYPE");

                entity.HasOne(d => d.SidebarElement)
                    .WithMany(p => p.Sidebarelementmembertypes)
                    .HasForeignKey(d => d.SidebarElementId)
                    .HasConstraintName("FK_SIDEBARELEMENTMEMBERTYPES_SIDEBARELEMENT");
            });

            modelBuilder.Entity<Sign>(entity =>
            {
                entity.ToTable("SIGN");

                entity.Property(e => e.SignId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsLandscape)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.LocationAndAccessDescription)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NextUpdateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Sign)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SIGN_CINEMA");
            });

            modelBuilder.Entity<Signcontent>(entity =>
            {
                entity.ToTable("SIGNCONTENT");

                entity.Property(e => e.SignContentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsLandscape)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.Signcontent)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIGNCONTENT_aspnet_Users");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Signcontent)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SIGNCONTENT_COMPANY");
            });

            modelBuilder.Entity<Signmode>(entity =>
            {
                entity.ToTable("SIGNMODE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Signplaylist>(entity =>
            {
                entity.ToTable("SIGNPLAYLIST");

                entity.Property(e => e.SignPlaylistId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Sign)
                    .WithMany(p => p.Signplaylist)
                    .HasForeignKey(d => d.SignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIGNPLAYLIST_SIGN");
            });

            modelBuilder.Entity<Signplaylistcontents>(entity =>
            {
                entity.HasKey(e => e.SignPlayListContentId);

                entity.ToTable("SIGNPLAYLISTCONTENTS");

                entity.Property(e => e.PassThroughData).HasMaxLength(500);

                entity.Property(e => e.PlaybackOrder).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Signplaylistcontents)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_SIGNPLAYLISTCONTENTS_CONTENT");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Signplaylistcontents)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK_SIGNPLAYLISTCONTENTS_RATING");

                entity.HasOne(d => d.SignPlayList)
                    .WithMany(p => p.Signplaylistcontents)
                    .HasForeignKey(d => d.SignPlayListId)
                    .HasConstraintName("FK_SIGNPLAYLISTCONTENTS_SIGNPLAYLIST");
            });

            modelBuilder.Entity<Signplaylistschedule>(entity =>
            {
                entity.ToTable("SIGNPLAYLISTSCHEDULE");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Sign)
                    .WithMany(p => p.Signplaylistschedule)
                    .HasForeignKey(d => d.SignId)
                    .HasConstraintName("FK_SIGNPLAYLISTSCHEDULE_SIGN");

                entity.HasOne(d => d.SignMode)
                    .WithMany(p => p.Signplaylistschedule)
                    .HasForeignKey(d => d.SignModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIGNPLAYLISTSCHEDULE_SIGNMODE");

                entity.HasOne(d => d.SignPlayList)
                    .WithMany(p => p.Signplaylistschedule)
                    .HasForeignKey(d => d.SignPlayListId)
                    .HasConstraintName("FK_SIGNPLAYLISTSCHEDULE_SIGNPLAYLIST");

                entity.HasOne(d => d.Time)
                    .WithMany(p => p.Signplaylistschedule)
                    .HasForeignKey(d => d.TimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIGNPLAYLISTSCHEDULE_TIME");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("SITE");

                entity.Property(e => e.SiteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompiledCsstext).HasColumnName("CompiledCSSText");

                entity.Property(e => e.CssversionNumber)
                    .HasColumnName("CSSVersionNumber")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GlobalCssversionId).HasColumnName("GlobalCSSVersionId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SITE_COMPANY");

                entity.HasOne(d => d.Css)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.CssId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITE_CSS1");

                entity.HasOne(d => d.GlobalCssversion)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.GlobalCssversionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITE_GLOBALCSSVERSION");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_SITE_MEMBERTYPE");
            });

            modelBuilder.Entity<Siteadvertisementlocationtypes>(entity =>
            {
                entity.HasKey(e => e.SiteAdvertisementLocationTypeId);

                entity.ToTable("SITEADVERTISEMENTLOCATIONTYPES");

                entity.HasOne(d => d.AdvertisementLocationType)
                    .WithMany(p => p.Siteadvertisementlocationtypes)
                    .HasForeignKey(d => d.AdvertisementLocationTypeId)
                    .HasConstraintName("FK_SITEADVERTISEMENTLOCATIONTYPES_ADVERTISEMENTLOCATIONTYPE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Siteadvertisementlocationtypes)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEADVERTISEMENTLOCATIONTYPES_SITE");
            });

            modelBuilder.Entity<Sitecinemagroups>(entity =>
            {
                entity.HasKey(e => e.SiteCinemaGroupId);

                entity.ToTable("SITECINEMAGROUPS");

                entity.HasOne(d => d.CinemaGroup)
                    .WithMany(p => p.Sitecinemagroups)
                    .HasForeignKey(d => d.CinemaGroupId)
                    .HasConstraintName("FK_SITECINEMAGROUPS_CINEMAGROUP");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitecinemagroups)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITECINEMAGROUPS_SITE");
            });

            modelBuilder.Entity<Siteconfig>(entity =>
            {
                entity.ToTable("SITECONFIG");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_SITECONFIGBySiteId");

                entity.Property(e => e.SiteConfigId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CacheRefreshInMinutesHome).HasDefaultValueSql("((30))");

                entity.Property(e => e.CacheRefreshInMinutesOther).HasDefaultValueSql("((120))");

                entity.Property(e => e.CacheRefreshInMinutesPromotion).HasDefaultValueSql("((60))");

                entity.Property(e => e.DayId).HasDefaultValueSql("((5))");

                entity.Property(e => e.GoogleAnalyticsAccountNumber).HasMaxLength(50);

                entity.Property(e => e.GoogleAnalyticsDomainName).HasMaxLength(100);

                entity.Property(e => e.IsRedirectIpadToMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRedirectNewRequestsOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSslcertificateInstalled).HasColumnName("IsSSLCertificateInstalled");

                entity.Property(e => e.IsUsePopUpCinemaSelection)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWildcardSsl).HasColumnName("IsWildcardSSL");

                entity.Property(e => e.MemberExitPollOptionList)
                    .IsRequired()
                    .HasDefaultValueSql("('I no longer live in the cinema area.|I don''t go to the cinema very often.|The weekly newsletter contains too much information.|The weekly newsletter contains too many advertisements.|I receive too many emails.|The emails I receive are not relevant to me.')");

                entity.Property(e => e.PosterHeightFull).HasDefaultValueSql("((300))");

                entity.Property(e => e.PosterWidthFull).HasDefaultValueSql("((200))");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITECONFIG_DAY");

                entity.HasOne(d => d.Drawer)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.DrawerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITECONFIG_DRAWER");

                entity.HasOne(d => d.Footer)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.FooterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITECONFIG_FOOTER");

                entity.HasOne(d => d.HeaderAdvertisementLocation)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.HeaderAdvertisementLocationId)
                    .HasConstraintName("FK_SITECONFIG_ADVERTISEMENTLOCATION");

                entity.HasOne(d => d.Sidebar)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.SidebarId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITECONFIG_SIDEBAR");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITECONFIG_SITE");

                entity.HasOne(d => d.SiteMenu)
                    .WithMany(p => p.Siteconfig)
                    .HasForeignKey(d => d.SiteMenuId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SITECONFIG_SITEMENU");
            });

            modelBuilder.Entity<Sitedisplaysetting>(entity =>
            {
                entity.ToTable("SITEDISPLAYSETTING");

                entity.Property(e => e.SiteDisplaySettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalHeadScripts).HasMaxLength(2000);

                entity.Property(e => e.AlternateGalleryVideoHeight).HasDefaultValueSql("((300))");

                entity.Property(e => e.ContentAreaWidth).HasDefaultValueSql("((640))");

                entity.Property(e => e.FestivalsKeywords).HasMaxLength(500);

                entity.Property(e => e.GoogleTagBody).HasMaxLength(2000);

                entity.Property(e => e.GoogleTagHead).HasMaxLength(2000);

                entity.Property(e => e.IsAllowPreScreenAdvertisementSkip)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCustomerCommentsApprovedByDefault)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsGlobalBlogPostsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLinkToDirectorAndCast)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMovieRatingStarsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMovieSynopsisShownOnSessionPage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowAllMemberTypesOnSignupPage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowFullRatingOnSessionsPage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStrikeSoldOutSessionTimes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUseUniqueMemberIdForCache)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainInteractiveTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(300);

                entity.Property(e => e.PreScreenShowPercent).HasDefaultValueSql("((20))");

                entity.Property(e => e.SessionTimeSeperatorSuffix).HasMaxLength(5);

                entity.Property(e => e.ShortSynopsisLength).HasDefaultValueSql("((300))");

                entity.HasOne(d => d.MainInteractiveType)
                    .WithMany(p => p.Sitedisplaysetting)
                    .HasForeignKey(d => d.MainInteractiveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITEDISPLAYSETTING_MAININTERACTIVETYPE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitedisplaysetting)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEDISPLAYSETTING_SITE");
            });

            modelBuilder.Entity<Siteemailsetting>(entity =>
            {
                entity.ToTable("SITEEMAILSETTING");

                entity.Property(e => e.SiteEmailSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompetitionSendingAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitionSendingName).HasMaxLength(100);

                entity.Property(e => e.ReplyToAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('replyto@yourdomain.com')");

                entity.Property(e => e.SendToAfriendIntroduction)
                    .IsRequired()
                    .HasColumnName("SendToAFriendIntroduction")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'Do you have a friend that may have an interest in {cinemaName}?')");

                entity.Property(e => e.SendToAfriendSubject)
                    .IsRequired()
                    .HasColumnName("SendToAFriendSubject")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'{toName}, {fromName} knows you like good movies and recommends {cinemaName}.')");

                entity.Property(e => e.SendingAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('sendingaddress@yourdomain.com')");

                entity.Property(e => e.SendingName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Siteemailsetting)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEEMAILSETTING_SITE");
            });

            modelBuilder.Entity<Sitefooterlinks>(entity =>
            {
                entity.HasKey(e => e.SiteFooterLinkId);

                entity.ToTable("SITEFOOTERLINKS");

                entity.Property(e => e.SiteFooterLinkId).ValueGeneratedNever();

                entity.Property(e => e.DisplayOrderDesktop).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderMobile).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrderTablet).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Sitefooterlinks)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_SITEFOOTERLINKS_PAGE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitefooterlinks)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITEFOOTERLINKS_SITE");
            });

            modelBuilder.Entity<Sitehomepagetab>(entity =>
            {
                entity.ToTable("SITEHOMEPAGETAB");

                entity.Property(e => e.SiteHomePageTabId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.InformationText).HasMaxLength(1000);

                entity.Property(e => e.IsDisplayOnDesktop)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnMobile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDisplayOnTablet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowSidebar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PassThroughData).HasMaxLength(1500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.IncludeElement)
                    .WithMany(p => p.Sitehomepagetab)
                    .HasForeignKey(d => d.IncludeElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITEHOMEPAGETAB_INCLUDEELEMENT");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitehomepagetab)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEHOMEPAGETAB_SITE");
            });

            modelBuilder.Entity<Sitehomepagetabcinemas>(entity =>
            {
                entity.HasKey(e => e.SiteHomePageTabCinemaId);

                entity.ToTable("SITEHOMEPAGETABCINEMAS");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Sitehomepagetabcinemas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SITEHOMEPAGETABCINEMAS_CINEMA");

                entity.HasOne(d => d.SiteHomePageTab)
                    .WithMany(p => p.Sitehomepagetabcinemas)
                    .HasForeignKey(d => d.SiteHomePageTabId)
                    .HasConstraintName("FK_SITEHOMEPAGETABCINEMAS_SITEHOMEPAGETAB");
            });

            modelBuilder.Entity<Siteloginmethods>(entity =>
            {
                entity.HasKey(e => e.SiteLoginMethodId);

                entity.ToTable("SITELOGINMETHODS");

                entity.Property(e => e.Introduction).HasMaxLength(1000);

                entity.Property(e => e.SpecialNotes).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(300);

                entity.HasOne(d => d.LoginMethod)
                    .WithMany(p => p.Siteloginmethods)
                    .HasForeignKey(d => d.LoginMethodId)
                    .HasConstraintName("FK_SITELOGINMETHODS_LOGINMETHOD");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Siteloginmethods)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITELOGINMETHODS_SITE");
            });

            modelBuilder.Entity<Sitemaininteractiveautoorder>(entity =>
            {
                entity.ToTable("SITEMAININTERACTIVEAUTOORDER");

                entity.HasOne(d => d.MainInteractiveAutoType)
                    .WithMany(p => p.Sitemaininteractiveautoorder)
                    .HasForeignKey(d => d.MainInteractiveAutoTypeId)
                    .HasConstraintName("FK_SITEMAININTERACTIVEAUTOORDER_MAININTERACTIVEAUTOTYPE");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitemaininteractiveautoorder)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEMAININTERACTIVEAUTOORDER_SITE");
            });

            modelBuilder.Entity<Sitememberpointawardsetting>(entity =>
            {
                entity.HasKey(e => e.SiteMemberPointRewardSettingId);

                entity.ToTable("SITEMEMBERPOINTAWARDSETTING");

                entity.Property(e => e.SiteMemberPointRewardSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitememberpointawardsetting)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITEMEMBERPOINTAWARDSETTING_SITE");
            });

            modelBuilder.Entity<Sitemenu>(entity =>
            {
                entity.ToTable("SITEMENU");

                entity.Property(e => e.SiteMenuId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('Default')");
            });

            modelBuilder.Entity<Sitesharingsetting>(entity =>
            {
                entity.ToTable("SITESHARINGSETTING");

                entity.Property(e => e.SiteSharingSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FacebookColorSchemeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsExternalUserMovieCommentsShown)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowFaceBookIconOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowTwitterIconOnMainInteractive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUserMovieCommentsShared)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FacebookColorScheme)
                    .WithMany(p => p.Sitesharingsetting)
                    .HasForeignKey(d => d.FacebookColorSchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SITESHARINGSETTING_FACEBOOKCOLORSCHEME");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Sitesharingsetting)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SITESHARINGSETTING_SITE");
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.ToTable("SMSLOG");

                entity.Property(e => e.SmslogId).HasColumnName("SMSLogId");

                entity.Property(e => e.ConfirmationDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.GatewayReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.GatewayResponse).HasMaxLength(250);

                entity.Property(e => e.IsSent)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.RecipientNumber)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Smslog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SMSLOG_COMPANY");
            });

            modelBuilder.Entity<Specialsession>(entity =>
            {
                entity.ToTable("SPECIALSESSION");

                entity.Property(e => e.SpecialSessionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SessionPointOfSaleId).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Synopsis).HasMaxLength(1000);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Specialsession)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_SPECIALSESSION_CINEMA");

                entity.HasOne(d => d.MovieInstance)
                    .WithMany(p => p.Specialsession)
                    .HasForeignKey(d => d.MovieInstanceId)
                    .HasConstraintName("FK_SPECIALSESSION_MOVIEINSTANCE");

                entity.HasOne(d => d.SpecialSessionType)
                    .WithMany(p => p.Specialsession)
                    .HasForeignKey(d => d.SpecialSessionTypeId)
                    .HasConstraintName("FK_SPECIALSESSION_SPECIALSESSIONTYPE");
            });

            modelBuilder.Entity<Specialsessiontype>(entity =>
            {
                entity.ToTable("SPECIALSESSIONTYPE");

                entity.Property(e => e.SpecialSessionTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsGenerateReminder)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeWhenNoTimeSelected)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Specialsessiontype)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SPECIALSESSIONTYPE_COMPANY");

                entity.HasOne(d => d.Flag)
                    .WithMany(p => p.Specialsessiontype)
                    .HasForeignKey(d => d.FlagId)
                    .HasConstraintName("FK_SPECIALSESSIONTYPE_FLAG");
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.ToTable("STATISTIC");

                entity.HasIndex(e => new { e.ViewCount, e.Hour, e.DataDate, e.StatisticTypeId, e.RelatedIdValue })
                    .HasName("IX_STATISTIC_Hour_DataDate_StatisticTypeId_RelatedIdValue_ViewCount");

                entity.Property(e => e.DataDate).HasColumnType("datetime");

                entity.Property(e => e.RelatedIdValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticTypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StatisticType)
                    .WithMany(p => p.Statistic)
                    .HasForeignKey(d => d.StatisticTypeId)
                    .HasConstraintName("FK_STATISTIC_STATISTICTYPE");
            });

            modelBuilder.Entity<Statisticdaily>(entity =>
            {
                entity.ToTable("STATISTICDAILY");

                entity.HasIndex(e => new { e.StatisticTypeId, e.RelatedIdValue, e.ClickCount });

                entity.Property(e => e.DataDate).HasColumnType("datetime");

                entity.Property(e => e.RelatedIdValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticTypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StatisticType)
                    .WithMany(p => p.Statisticdaily)
                    .HasForeignKey(d => d.StatisticTypeId)
                    .HasConstraintName("FK_STATISTICDAILY_STATISTICTYPE");
            });

            modelBuilder.Entity<Statisticlog>(entity =>
            {
                entity.ToTable("STATISTICLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsView)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RelatedIdValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticTypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StatisticType)
                    .WithMany(p => p.Statisticlog)
                    .HasForeignKey(d => d.StatisticTypeId)
                    .HasConstraintName("FK_STATISTICLOG_STATISTICTYPE");
            });

            modelBuilder.Entity<Statistictype>(entity =>
            {
                entity.ToTable("STATISTICTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelatedIdName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelatedTable).HasMaxLength(50);
            });

            modelBuilder.Entity<Supportresource>(entity =>
            {
                entity.ToTable("SUPPORTRESOURCE");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tags).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supportresourcecomment>(entity =>
            {
                entity.ToTable("SUPPORTRESOURCECOMMENT");

                entity.Property(e => e.CmsuserId)
                    .HasColumnName("CMSUserId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDatetime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Cmsuser)
                    .WithMany(p => p.Supportresourcecomment)
                    .HasForeignKey(d => d.CmsuserId)
                    .HasConstraintName("FK_SUPPORTRESOURCECOMMENT_CMSUSER");

                entity.HasOne(d => d.SupportResource)
                    .WithMany(p => p.Supportresourcecomment)
                    .HasForeignKey(d => d.SupportResourceId)
                    .HasConstraintName("FK_FEATURESUPPORTRESOURCECOMMENT_FEATURESUPPORTRESOURCE");
            });

            modelBuilder.Entity<Supportresourcestep>(entity =>
            {
                entity.ToTable("SUPPORTRESOURCESTEP");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Instructions).IsRequired();

                entity.Property(e => e.LinkUrl).HasColumnName("LinkURL");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportResource)
                    .WithMany(p => p.Supportresourcestep)
                    .HasForeignKey(d => d.SupportResourceId)
                    .HasConstraintName("FK_SUPPORTRESOURCESTEP_SUPPORTRESOURCE");
            });

            modelBuilder.Entity<Systembug>(entity =>
            {
                entity.ToTable("SYSTEMBUG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ImportanceOutOfFive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProposedSolution).HasMaxLength(2000);

                entity.Property(e => e.SolvedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.WorkAround).HasMaxLength(2000);

                entity.HasOne(d => d.SystemBugType)
                    .WithMany(p => p.Systembug)
                    .HasForeignKey(d => d.SystemBugTypeId)
                    .HasConstraintName("FK_SYSTEMBUG_SYSTEMBUGTYPE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Systembug)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BUG_aspnet_Users");
            });

            modelBuilder.Entity<Systembugcomment>(entity =>
            {
                entity.ToTable("SYSTEMBUGCOMMENT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.SystemBug)
                    .WithMany(p => p.Systembugcomment)
                    .HasForeignKey(d => d.SystemBugId)
                    .HasConstraintName("FK_SYSTEMBUGCOMMENT_SYSTEMBUG");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Systembugcomment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYSTEMBUGCOMMENT_aspnet_Users");
            });

            modelBuilder.Entity<Systembugtype>(entity =>
            {
                entity.ToTable("SYSTEMBUGTYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Systemupdate>(entity =>
            {
                entity.ToTable("SYSTEMUPDATE");

                entity.Property(e => e.AffectedSystems)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EstimatedDowntimeInMinutes).HasDefaultValueSql("((60))");

                entity.Property(e => e.IsMinor)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.UploadDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Systemupdatesystembugs>(entity =>
            {
                entity.HasKey(e => e.SystemUpdateSystemBugId);

                entity.ToTable("SYSTEMUPDATESYSTEMBUGS");

                entity.HasOne(d => d.SystemBug)
                    .WithMany(p => p.Systemupdatesystembugs)
                    .HasForeignKey(d => d.SystemBugId)
                    .HasConstraintName("FK_SYSTEMUPDATESYSTEMBUGS_SYSTEMBUG");

                entity.HasOne(d => d.SystemUpdate)
                    .WithMany(p => p.Systemupdatesystembugs)
                    .HasForeignKey(d => d.SystemUpdateId)
                    .HasConstraintName("FK_SYSTEMUPDATESYSTEMBUGS_SYSTEMUPDATE");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.ToTable("TIME");

                entity.Property(e => e.Text).HasMaxLength(50);

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIME_DAY");
            });

            modelBuilder.Entity<TopQueriesByCpu>(entity =>
            {
                entity.HasKey(e => e.TrackId);

                entity.ToTable("TopQueriesByCPU");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.Property(e => e.CpuTime).HasColumnName("CPU_Time");

                entity.Property(e => e.ITrackDate)
                    .HasColumnName("iTrackDate")
                    .HasComputedColumnSql("(CONVERT([int],CONVERT([varchar],[TrackDate],(112)),(0)))");

                entity.Property(e => e.ITrackTime)
                    .HasColumnName("iTrackTime")
                    .HasComputedColumnSql("(CONVERT([int],replace(CONVERT([varchar],[TrackDate],(108)),':',''),(0)))");

                entity.Property(e => e.TrackDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Transactionlog>(entity =>
            {
                entity.ToTable("TRANSACTIONLOG");

                entity.Property(e => e.AdditionalCinemaAdjustmentAmount).HasColumnType("money");

                entity.Property(e => e.BaseAmount).HasColumnType("money");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RelatedId).HasMaxLength(50);

                entity.Property(e => e.RelatedTable).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Transactionlog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_TRANSACTIONLOG_COMPANY");
            });

            modelBuilder.Entity<Venuemastercrmaction>(entity =>
            {
                entity.ToTable("VENUEMASTERCRMACTION");

                entity.Property(e => e.VenueMasterCrmactionId).HasColumnName("VenueMasterCRMActionId");

                entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

                entity.Property(e => e.VenueMasterCrmactionTypeId).HasColumnName("VenueMasterCRMActionTypeId");

                entity.Property(e => e.VenueMasterCrmconfigId).HasColumnName("VenueMasterCRMConfigId");

                entity.HasOne(d => d.VenueMasterCrmactionType)
                    .WithMany(p => p.Venuemastercrmaction)
                    .HasForeignKey(d => d.VenueMasterCrmactionTypeId)
                    .HasConstraintName("FK_VENUEMASTERCRMACTION_VENUEMASTERCRMACTIONTYPE1");

                entity.HasOne(d => d.VenueMasterCrmconfig)
                    .WithMany(p => p.Venuemastercrmaction)
                    .HasForeignKey(d => d.VenueMasterCrmconfigId)
                    .HasConstraintName("FK_VENUEMASTERCRMACTION_VENUEMASTERCRMCONFIG");
            });

            modelBuilder.Entity<Venuemastercrmactiontype>(entity =>
            {
                entity.ToTable("VENUEMASTERCRMACTIONTYPE");

                entity.Property(e => e.VenueMasterCrmactionTypeId).HasColumnName("VenueMasterCRMActionTypeId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Venuemastercrmconfig>(entity =>
            {
                entity.ToTable("VENUEMASTERCRMCONFIG");

                entity.Property(e => e.VenueMasterCrmconfigId).HasColumnName("VenueMasterCRMConfigId");

                entity.Property(e => e.AdministrationEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('alex@kinesis.com.au')");

                entity.Property(e => e.AuthorisationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionPort).HasDefaultValueSql("((4020))");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsSendEmailMatchingFieldName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Opt_Out_1')");

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebServerPort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((81))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Venuemastercrmconfig)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_VENUEMASTERCRMCONFIG_COMPANY");

                entity.HasOne(d => d.OptOut1EmailGroup)
                    .WithMany(p => p.VenuemastercrmconfigOptOut1EmailGroup)
                    .HasForeignKey(d => d.OptOut1EmailGroupId)
                    .HasConstraintName("FK_VENUEMASTERCRMCONFIG_EMAILGROUP");

                entity.HasOne(d => d.OptOut2EmailGroup)
                    .WithMany(p => p.VenuemastercrmconfigOptOut2EmailGroup)
                    .HasForeignKey(d => d.OptOut2EmailGroupId)
                    .HasConstraintName("FK_VENUEMASTERCRMCONFIG_EMAILGROUP1");

                entity.HasOne(d => d.OptOut3EmailGroup)
                    .WithMany(p => p.VenuemastercrmconfigOptOut3EmailGroup)
                    .HasForeignKey(d => d.OptOut3EmailGroupId)
                    .HasConstraintName("FK_VENUEMASTERCRMCONFIG_EMAILGROUP2");
            });

            modelBuilder.Entity<Venuemastercrmlog>(entity =>
            {
                entity.ToTable("VENUEMASTERCRMLOG");

                entity.HasIndex(e => new { e.VenueMasterCrmlogId, e.MemberCrmactionId })
                    .HasName("IX_VenueMasterCRMLogByMemberCRMActionId");

                entity.Property(e => e.VenueMasterCrmlogId).HasColumnName("VenueMasterCRMLogId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.MemberCrmactionId).HasColumnName("MemberCRMActionId");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.VenueMasterCrmconfigId).HasColumnName("VenueMasterCRMConfigId");

                entity.HasOne(d => d.MemberCrmaction)
                    .WithMany(p => p.Venuemastercrmlog)
                    .HasForeignKey(d => d.MemberCrmactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VENUEMASTERCRMLOG_MEMBERCRMACTION");

                entity.HasOne(d => d.VenueMasterCrmconfig)
                    .WithMany(p => p.Venuemastercrmlog)
                    .HasForeignKey(d => d.VenueMasterCrmconfigId)
                    .HasConstraintName("FK_VENUEMASTERCRMLOG_VENUEMASTERCRMCONFIG");
            });

            modelBuilder.Entity<Venuemasterticketingblacklist>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGBLACKLIST");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Venuemasterticketingbooking>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGBOOKING");

                entity.HasIndex(e => e.PaymentGatewayTransactionId);

                entity.HasIndex(e => e.SessionId);

                entity.HasIndex(e => e.VenueMasterTicketingSettingVifdataId);

                entity.HasIndex(e => new { e.CinemaId, e.BookingDateTime })
                    .HasName("IX_VenueMasterTicketingBookingByCinemaAndDT");

                entity.HasIndex(e => new { e.IsError, e.IsCommitted });

                entity.HasIndex(e => new { e.VenueMasterTicketingPromoId, e.IsRedeemVoucher, e.StoredValueCardClosingBalance, e.StoredValueCardPaymentAmount, e.IsStoredValueCardValid, e.IsStoredValueCardCharged, e.CreditCardPaymentAmount, e.IsJoinMailingList, e.IsSendSms, e.SmslogId, e.Smscost, e.StoredValueCardNumber, e.StoredValueCardPin, e.StoredValueCardStartingBalance, e.IsAllocatedSeating, e.CreditCardNumberCvv, e.CompanyCreditCardTypeId, e.PaymentGatewayTransactionId, e.Source, e.VenueMasterTicketingSettingVifdataId, e.IsCommitted, e.IsReceiptSent, e.IsError, e.ErrorText, e.PriceGroup, e.DefaultBookingFeePerTicket, e.CustomerIpaddress, e.VifalternateKey, e.VifbookingKey, e.VifbookingIndex, e.ViftransactionNumber, e.VifbookingPin, e.CustomerEmail, e.CustomerPhone, e.CustomerPostCode, e.TotalCostOfTickets, e.TotalCostOfBookingFees, e.TotalCost, e.MemberId, e.MembershipNumber, e.NameOnCreditCard, e.CreditCardNumber, e.CreditCardExpiryMonth, e.CreditCardExpiryYear, e.ScreenId, e.SessionPointOfSaleId, e.SessionDateTime, e.MovieTitle, e.BookingDateTime, e.SessionId, e.CinemaId, e.WorkstationId })
                    .HasName("IX_VENUEMASTERTICKETINGBOOKING_CinemaId_WorkstationId_ScreenId_SessionPointOfSaleId_SessionDateTime_MovieTitle_BookingDateTime_S");

                entity.HasIndex(e => new { e.VenueMasterTicketingPromoId, e.IsRedeemVoucher, e.StoredValueCardClosingBalance, e.StoredValueCardPaymentAmount, e.IsStoredValueCardValid, e.IsStoredValueCardCharged, e.CreditCardPaymentAmount, e.IsJoinMailingList, e.IsSendSms, e.SmslogId, e.Smscost, e.StoredValueCardNumber, e.StoredValueCardPin, e.StoredValueCardStartingBalance, e.IsAllocatedSeating, e.CreditCardNumberCvv, e.CompanyCreditCardTypeId, e.PaymentGatewayTransactionId, e.Source, e.VenueMasterTicketingSettingVifdataId, e.IsReceiptSent, e.IsError, e.WorkstationId, e.ErrorText, e.PriceGroup, e.DefaultBookingFeePerTicket, e.CustomerIpaddress, e.VifalternateKey, e.VifbookingKey, e.VifbookingIndex, e.ViftransactionNumber, e.VifbookingPin, e.CustomerEmail, e.CustomerPhone, e.CustomerPostCode, e.TotalCostOfTickets, e.TotalCostOfBookingFees, e.TotalCost, e.SessionId, e.MembershipNumber, e.NameOnCreditCard, e.CreditCardNumber, e.CreditCardExpiryMonth, e.CreditCardExpiryYear, e.CinemaId, e.ScreenId, e.SessionPointOfSaleId, e.SessionDateTime, e.MovieTitle, e.BookingDateTime, e.MemberId, e.IsCommitted })
                    .HasName("IX_VENUEMASTERTICKETINGBOOKING_MemberId_IsCommitted_CinemaId_ScreenId_SessionPointOfSaleId_SessionDateTime_MovieTitle_BookingDat");

                entity.Property(e => e.VenueMasterTicketingBookingId).ValueGeneratedNever();

                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.CompanyCreditCardTypeId).HasDefaultValueSql("((15))");

                entity.Property(e => e.CreditCardExpiryMonth)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiryYear)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumberCvv)
                    .HasColumnName("CreditCardNumberCVV")
                    .HasMaxLength(5);

                entity.Property(e => e.CreditCardPaymentAmount).HasColumnType("money");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerIpaddress)
                    .HasColumnName("CustomerIPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErrorText).HasMaxLength(500);

                entity.Property(e => e.IsRedeemVoucher).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSendSms).HasColumnName("IsSendSMS");

                entity.Property(e => e.IsStoredValueCardCharged).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStoredValueCardValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.MembershipNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCreditCard)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PriceGroup).HasMaxLength(50);

                entity.Property(e => e.SessionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionPointOfSaleId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Smscost)
                    .HasColumnName("SMSCost")
                    .HasColumnType("money");

                entity.Property(e => e.SmslogId).HasColumnName("SMSLogId");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('KICSWEB')");

                entity.Property(e => e.StoredValueCardClosingBalance).HasColumnType("money");

                entity.Property(e => e.StoredValueCardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoredValueCardPaymentAmount).HasColumnType("money");

                entity.Property(e => e.StoredValueCardPin)
                    .HasColumnName("StoredValueCardPIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoredValueCardStartingBalance).HasColumnType("money");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalCostOfBookingFees).HasColumnType("money");

                entity.Property(e => e.TotalCostOfTickets).HasColumnType("money");

                entity.Property(e => e.VenueMasterTicketingPromoId).HasColumnName("VenueMasterTicketingPromoID");

                entity.Property(e => e.VenueMasterTicketingSettingVifdataId).HasColumnName("VenueMasterTicketingSettingVIFDataId");

                entity.Property(e => e.VifalternateKey)
                    .HasColumnName("VIFAlternateKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingIndex)
                    .HasColumnName("VIFBookingIndex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingKey)
                    .HasColumnName("VIFBookingKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VifbookingPin)
                    .HasColumnName("VIFBookingPIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViftransactionNumber)
                    .HasColumnName("VIFTransactionNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_CINEMA");

                entity.HasOne(d => d.CompanyCreditCardType)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.CompanyCreditCardTypeId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_COMPANYCREDITCARDTYPES");

                entity.HasOne(d => d.PaymentGatewayTransaction)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.PaymentGatewayTransactionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_PAYMENTGATEWAYTRANSACTION");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_SCREEN");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_SESSION");

                entity.HasOne(d => d.Smslog)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.SmslogId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_SMSLOG");

                entity.HasOne(d => d.VenueMasterTicketingPromo)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.VenueMasterTicketingPromoId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_VENUEMASTERTICKETINGPROMO");

                entity.HasOne(d => d.VenueMasterTicketingSettingVifdata)
                    .WithMany(p => p.Venuemasterticketingbooking)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingVifdataId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKING_VENUEMASTERTICKETINGSETTINGVIFDATA");
            });

            modelBuilder.Entity<Venuemasterticketingbookinglog>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGBOOKINGLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.HasOne(d => d.VenueMasterTicketingBooking)
                    .WithMany(p => p.Venuemasterticketingbookinglog)
                    .HasForeignKey(d => d.VenueMasterTicketingBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGLOG_VENUEMASTERTICKETINGBOOKING");
            });

            modelBuilder.Entity<Venuemasterticketingbookingreceipt>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGBOOKINGRECEIPT");

                entity.Property(e => e.ReceiptHtml).HasColumnName("ReceiptHTML");

                entity.HasOne(d => d.VenueMasterTicketingBooking)
                    .WithMany(p => p.Venuemasterticketingbookingreceipt)
                    .HasForeignKey(d => d.VenueMasterTicketingBookingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKINGRECEIPT_VENUEMASTERTICKETINGBOOKING");
            });

            modelBuilder.Entity<Venuemasterticketingbookingtickets>(entity =>
            {
                entity.HasKey(e => e.VenueMasterTicketingBookingTicketId);

                entity.ToTable("VENUEMASTERTICKETINGBOOKINGTICKETS");

                entity.HasIndex(e => e.VenueMasterTicketingSettingVifprlid);

                entity.HasIndex(e => new { e.VenueMasterTicketingBookingId, e.VenueMasterTicketingSettingVifprlid })
                    .HasName("IX_VenueMasterTicketingBookingTickets_VIFPRLId");

                entity.HasIndex(e => new { e.VenueMasterTicketingBookingId, e.VenueMasterTicketingTicketSettingId })
                    .HasName("IX_VENUEMASTERTICKETINGBOOKINGTICKETS_VenueMasterTicketingTicketSettingId_VenueMasterTicketingBookingId");

                entity.Property(e => e.VenueMasterTicketingBookingTicketId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee).HasColumnType("money");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicketName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenueMasterTicketingSettingVifprlid).HasColumnName("VenueMasterTicketingSettingVIFPRLId");

                entity.Property(e => e.VenueMasterTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VoucherCode).HasMaxLength(50);

                entity.HasOne(d => d.VenueMasterTicketingBooking)
                    .WithMany(p => p.Venuemasterticketingbookingtickets)
                    .HasForeignKey(d => d.VenueMasterTicketingBookingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKINGTICKETS_VENUEMASTERTICKETINGBOOKING");

                entity.HasOne(d => d.VenueMasterTicketingSettingVifprl)
                    .WithMany(p => p.Venuemasterticketingbookingtickets)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingVifprlid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKINGTICKETS_VENUEMASTERTICKETINGSETTINGVIFPRL");

                entity.HasOne(d => d.VenueMasterTicketingTicketSetting)
                    .WithMany(p => p.Venuemasterticketingbookingtickets)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGBOOKINGTICKETS_VENUEMASTERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingcreditcardfailurelog>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGCREDITCARDFAILURELOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNumber).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Venuemasterticketingexternalparty>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGEXTERNALPARTY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Venuemasterticketingpromo>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGPROMO");

                entity.Property(e => e.VenueMasterTicketingPromoId).HasColumnName("VenueMasterTicketingPromoID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.VenueMasterTicketingSetting)
                    .WithMany(p => p.Venuemasterticketingpromo)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGPROMO_VENUEMASTERTICKETINGSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingsetting>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGSETTING");

                entity.HasIndex(e => e.CinemaId)
                    .HasName("IX_VenueMasterTicketingSettingByCinemaId");

                entity.Property(e => e.VenueMasterTicketingSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFeeForVoucherRedemptions)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CashierProfile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('viftest')");

                entity.Property(e => e.ConnectionTestDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2000)-(1))-(1))");

                entity.Property(e => e.ConnectionTestFrequencyInMinutes).HasDefaultValueSql("((15))");

                entity.Property(e => e.ConnectionTestResult)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CutoffNumberOfMinutes).HasDefaultValueSql("((60))");

                entity.Property(e => e.DefaultBookingFeePerTicket)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmergencyContactEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactMobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReceiptText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.GeneralTicketSelectionPageItemIntroduction).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextAboveTable).HasMaxLength(1000);

                entity.Property(e => e.GeneralTicketSelectionPageTextBelowTable).HasMaxLength(1000);

                entity.Property(e => e.IsOfferSms).HasColumnName("IsOfferSMS");

                entity.Property(e => e.IsSortedByPrice)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinMailingListText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'I would like to receive newsletters and marketing emails.')");

                entity.Property(e => e.LastReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2001)-(1))-(1))");

                entity.Property(e => e.LastWorkstationId).HasDefaultValueSql("((1000))");

                entity.Property(e => e.MaximumTicketsPerOrder).HasDefaultValueSql("((10))");

                entity.Property(e => e.MemberLoginIntroductionText).HasMaxLength(2000);

                entity.Property(e => e.MinimumTicketsPerOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.MobileIntroduction).HasMaxLength(500);

                entity.Property(e => e.MobileMemberLoginIntroductionText)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'Members, enter your membership number and surname below to access member ticket rates.')");

                entity.Property(e => e.MobileReceiptText)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("(N'Present your phone at the boxoffice to collect your tickets.')");

                entity.Property(e => e.NotAllocatedSessionPopupText).HasMaxLength(1000);

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryFrequencyInDays).HasDefaultValueSql("((7))");

                entity.Property(e => e.SendReceiptFromEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendReceiptFromName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmsratePerMessageBilledToCustomer)
                    .HasColumnName("SMSRatePerMessageBilledToCustomer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.StartPageMessage).HasMaxLength(2000);

                entity.Property(e => e.VifdataCache).HasColumnName("VIFDataCache");

                entity.Property(e => e.VifdataCacheExpiryDateTime)
                    .HasColumnName("VIFDataCacheExpiryDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2000)-(1))-(1))");

                entity.Property(e => e.VifdataCacheExpiryInMinutes)
                    .HasColumnName("VIFDataCacheExpiryInMinutes")
                    .HasDefaultValueSql("((15))");

                entity.Property(e => e.VifdataTicketCacheExpiryInMinutes)
                    .HasColumnName("VIFDataTicketCacheExpiryInMinutes")
                    .HasDefaultValueSql("((720))");

                entity.Property(e => e.WorkstationIdFrom).HasDefaultValueSql("((1000))");

                entity.Property(e => e.WorkstationIdTo).HasDefaultValueSql("((2000))");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Venuemasterticketingsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTING_CINEMA");
            });

            modelBuilder.Entity<Venuemasterticketingsettingexternalparties>(entity =>
            {
                entity.HasKey(e => e.VenueMasterTicketingSettingExternalPartyId);

                entity.ToTable("VENUEMASTERTICKETINGSETTINGEXTERNALPARTIES");

                entity.Property(e => e.VenueMasterTicketingSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.VenueMasterTicketingExternalParty)
                    .WithMany(p => p.Venuemasterticketingsettingexternalparties)
                    .HasForeignKey(d => d.VenueMasterTicketingExternalPartyId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGEXTERNALPARTIES_VENUEMASTERTICKETINGEXTERNALPARTY");

                entity.HasOne(d => d.VenueMasterTicketingSetting)
                    .WithMany(p => p.Venuemasterticketingsettingexternalparties)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGEXTERNALPARTIES_VENUEMASTERTICKETINGSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingsettinglog>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGSETTINGLOG");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.HasOne(d => d.VenueMasterTicketingSetting)
                    .WithMany(p => p.Venuemasterticketingsettinglog)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGLOG_VENUEMASTERTICKETINGSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingsettingseattype>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGSETTINGSEATTYPE");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VenueMasterTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.VenueMasterTicketingTicketSetting)
                    .WithMany(p => p.Venuemasterticketingsettingseattype)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGSEATTYPE_VENUEMASTERTICKETINGSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingsettingvifdata>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGSETTINGVIFDATA");

                entity.Property(e => e.VenueMasterTicketingSettingVifdataId).HasColumnName("VenueMasterTicketingSettingVIFDataId");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2000)-(1))-(1))");

                entity.Property(e => e.VifdataCache).HasColumnName("VIFDataCache");

                entity.HasOne(d => d.VenueMasterTicketingSetting)
                    .WithMany(p => p.Venuemasterticketingsettingvifdata)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFDATA_VENUEMASTERTICKETINGSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingsettingvifprl>(entity =>
            {
                entity.HasKey(e => e.VenueMasterTicketSettingVifprlid);

                entity.ToTable("VENUEMASTERTICKETINGSETTINGVIFPRL");

                entity.Property(e => e.VenueMasterTicketSettingVifprlid).HasColumnName("VenueMasterTicketSettingVIFPRLId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PriceGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceIncludingLinkedTicket).HasColumnType("money");

                entity.Property(e => e.VenueMasterTicketSettingViftktid).HasColumnName("VenueMasterTicketSettingVIFTKTId");

                entity.Property(e => e.VenueMasterTicketingSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VenueMasterTicketingSettingVifdataId).HasColumnName("VenueMasterTicketingSettingVIFDataId");

                entity.HasOne(d => d.VenueMasterTicketSettingViftkt)
                    .WithMany(p => p.Venuemasterticketingsettingvifprl)
                    .HasForeignKey(d => d.VenueMasterTicketSettingViftktid)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFPRL_VENUEMASTERTICKETINGSETTINGVIFTKT");

                entity.HasOne(d => d.VenueMasterTicketingSetting)
                    .WithMany(p => p.Venuemasterticketingsettingvifprl)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFPRL_VENUEMASTERTICKETINGSETTING");

                entity.HasOne(d => d.VenueMasterTicketingSettingVifdata)
                    .WithMany(p => p.Venuemasterticketingsettingvifprl)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingVifdataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFPRL_VENUEMASTERTICKETINGSETTINGVIFDATA");
            });

            modelBuilder.Entity<Venuemasterticketingsettingviftkt>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGSETTINGVIFTKT");

                entity.Property(e => e.VenueMasterTicketingSettingViftktid).HasColumnName("VenueMasterTicketingSettingVIFTKTId");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultPrice).HasColumnType("money");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfSeats).HasDefaultValueSql("((1))");

                entity.Property(e => e.VenueMasterTicketingSettingVifdataId).HasColumnName("VenueMasterTicketingSettingVIFDataId");

                entity.HasOne(d => d.VenueMasterTicketingSettingVifdata)
                    .WithMany(p => p.Venuemasterticketingsettingviftkt)
                    .HasForeignKey(d => d.VenueMasterTicketingSettingVifdataId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFTKT_VENUEMASTERTICKETINGSETTINGVIFDATA");

                entity.HasOne(d => d.VenueMasterTicketingTicketType)
                    .WithMany(p => p.Venuemasterticketingsettingviftkt)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGSETTINGVIFTKT_VENUEMASTERTICKETINGTICKETTYPE");
            });

            modelBuilder.Entity<Venuemasterticketingticketsetting>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGTICKETSETTING");

                entity.Property(e => e.VenueMasterTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalReceiptTextAfterGenericText)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.AdditionalTermsAndConditionsText).HasColumnType("ntext");

                entity.Property(e => e.AdditionalTicketSelectionPageText).HasMaxLength(1500);

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Regular Tickets')");

                entity.Property(e => e.PopUpMessageText)
                    .HasMaxLength(800)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VenueMasterTicketingPromoId).HasColumnName("VenueMasterTicketingPromoID");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Venuemasterticketingticketsetting)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETGROUP_CINEMA");

                entity.HasOne(d => d.VenueMasterTicketingPromo)
                    .WithMany(p => p.Venuemasterticketingticketsetting)
                    .HasForeignKey(d => d.VenueMasterTicketingPromoId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETSETTING_VENUEMASTERTICKETINGPROMO");
            });

            modelBuilder.Entity<Venuemasterticketingticketsettingcheckbox>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGTICKETSETTINGCHECKBOX");

                entity.Property(e => e.Text)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.VenueMasterTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Venuemasterticketingticketsettingcheckbox)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETSETTINGCHECKBOX_CINEMA");

                entity.HasOne(d => d.VenueMasterTicketingTicketSetting)
                    .WithMany(p => p.Venuemasterticketingticketsettingcheckbox)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETSETTINGCHECKBOX_VENUEMASTERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingticketsettingmembertypes>(entity =>
            {
                entity.HasKey(e => e.VenueMasterTicketingTicketSettingMemberTypeId);

                entity.ToTable("VENUEMASTERTICKETINGTICKETSETTINGMEMBERTYPES");

                entity.HasOne(d => d.VenueMasterTicketingTicketSetting)
                    .WithMany(p => p.Venuemasterticketingticketsettingmembertypes)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETSETTINGMEMBERTYPES_VENUEMASTERTICKETINGTICKETSETTING");
            });

            modelBuilder.Entity<Venuemasterticketingtickettype>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGTICKETTYPE");

                entity.Property(e => e.VenueMasterTicketingTicketTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookingFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExternalReference1).HasMaxLength(250);

                entity.Property(e => e.ExternalReference2).HasMaxLength(250);

                entity.Property(e => e.ExternalReference3).HasMaxLength(250);

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrerequisiteTicketCode).HasMaxLength(20);

                entity.Property(e => e.PrerequisiteTicketNameForDisplay).HasMaxLength(50);

                entity.Property(e => e.TicketCodeToMatch)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TicketNameForDisplay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketSelectionItemText).HasMaxLength(500);

                entity.Property(e => e.ToolTipMessage).HasMaxLength(200);

                entity.Property(e => e.VenueMasterTicketingTicketSettingId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.VenueMasterTicketingExternalParty)
                    .WithMany(p => p.Venuemasterticketingtickettype)
                    .HasForeignKey(d => d.VenueMasterTicketingExternalPartyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETTYPE_VENUEMASTERTICKETINGEXTERNALPARTYID");

                entity.HasOne(d => d.VenueMasterTicketingTicketSetting)
                    .WithMany(p => p.Venuemasterticketingtickettype)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketSettingId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETTYPE_VENUEMASTERTICKETINGTICKETGROUP");
            });

            modelBuilder.Entity<Venuemasterticketingtickettypemovie>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGTICKETTYPEMOVIE");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.MovieDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VenueMasterTicketingTicketTypeId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.MovieDetail)
                    .WithMany(p => p.Venuemasterticketingtickettypemovie)
                    .HasForeignKey(d => d.MovieDetailId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETTYPEMOVIE_MOVIEDETAIL");

                entity.HasOne(d => d.VenueMasterTicketingTicketType)
                    .WithMany(p => p.Venuemasterticketingtickettypemovie)
                    .HasForeignKey(d => d.VenueMasterTicketingTicketTypeId)
                    .HasConstraintName("FK_VENUEMASTERTICKETINGTICKETTYPEMOVIE_VENUEMASTERTICKETINGTICKETTYPE");
            });

            modelBuilder.Entity<Venuemasterticketingvoucher>(entity =>
            {
                entity.ToTable("VENUEMASTERTICKETINGVOUCHER");

                entity.Property(e => e.VoucherBarcode).HasMaxLength(50);

                entity.Property(e => e.VoucherExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherRedemptionDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherTicketCode).HasMaxLength(10);

                entity.Property(e => e.VoucherTicketDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<Venuemasterticketingvouchertype>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeid);

                entity.ToTable("VENUEMASTERTICKETINGVOUCHERTYPE");

                entity.Property(e => e.VoucherName).HasMaxLength(50);
            });

            modelBuilder.Entity<VistaCache>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDatetime).HasColumnType("datetime");

                entity.Property(e => e.VistaCinemaId)
                    .IsRequired()
                    .HasColumnName("VistaCinemaID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VistaCacheLogs>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(500);

                entity.Property(e => e.VistaCacheId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VistaCinemas>(entity =>
            {
                entity.Property(e => e.VistaCinemasId).ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.CinemaId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DescriptionAlt).HasMaxLength(250);

                entity.Property(e => e.DescriptionTranslations).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.Hopk)
                    .HasColumnName("HOPK")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitute).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.LoyaltyCode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameAlt).HasMaxLength(50);

                entity.Property(e => e.NameTranslations).HasMaxLength(50);

                entity.Property(e => e.ParkingInfo).HasMaxLength(50);

                entity.Property(e => e.ParkingInfoTranslations).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PublicTransport).HasMaxLength(250);

                entity.Property(e => e.PublicTransportTranslations).HasMaxLength(50);

                entity.Property(e => e.ServerName).HasMaxLength(10);

                entity.Property(e => e.TimeZoneId).HasMaxLength(50);

                entity.Property(e => e.TipPercentages).HasMaxLength(50);
            });

            modelBuilder.Entity<VistaScheduledFilms>(entity =>
            {
                entity.Property(e => e.AdvanceBookingDate).HasMaxLength(50);

                entity.Property(e => e.CinemaId).HasMaxLength(50);

                entity.Property(e => e.CinemaName).HasMaxLength(50);

                entity.Property(e => e.CinemaNameAlt).HasMaxLength(50);

                entity.Property(e => e.CorporateFilmId).HasMaxLength(50);

                entity.Property(e => e.CustomerRatingStatisticsAverageScore).HasMaxLength(50);

                entity.Property(e => e.CustomerRatingStatisticsRatingCount).HasMaxLength(50);

                entity.Property(e => e.CustomerRatingTrailerStatisticsAverageScore).HasMaxLength(50);

                entity.Property(e => e.CustomerRatingTrailerStatisticsRatingCount).HasMaxLength(50);

                entity.Property(e => e.DisplaySequence).HasMaxLength(50);

                entity.Property(e => e.Distributor).HasMaxLength(50);

                entity.Property(e => e.Edicode)
                    .HasColumnName("EDICode")
                    .HasMaxLength(50);

                entity.Property(e => e.FilmHocode)
                    .HasColumnName("FilmHOCode")
                    .HasMaxLength(50);

                entity.Property(e => e.FilmHopk)
                    .HasColumnName("FilmHOPK")
                    .HasMaxLength(50);

                entity.Property(e => e.GraphicUrl).HasMaxLength(50);

                entity.Property(e => e.LoyaltyAdvanceBookingDate).HasMaxLength(50);

                entity.Property(e => e.NationalOpeningDate).HasMaxLength(50);

                entity.Property(e => e.OpeningDate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rating).HasMaxLength(50);

                entity.Property(e => e.RatingAlt).HasMaxLength(50);

                entity.Property(e => e.RatingDescription).HasMaxLength(50);

                entity.Property(e => e.RatingDescriptionAlt).HasMaxLength(50);

                entity.Property(e => e.RunTime).HasMaxLength(50);

                entity.Property(e => e.ScheduledFilmId).HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(50);

                entity.Property(e => e.Synopsis).HasMaxLength(1000);

                entity.Property(e => e.SynopsisAlt).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleAlt).HasMaxLength(50);

                entity.Property(e => e.TrailerUrl).HasMaxLength(50);

                entity.Property(e => e.TwitterTag).HasMaxLength(50);

                entity.Property(e => e.VistaId).HasMaxLength(50);
            });
        }
    }
}
