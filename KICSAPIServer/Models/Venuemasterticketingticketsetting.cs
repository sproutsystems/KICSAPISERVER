using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Venuemasterticketingticketsetting
    {
        public Venuemasterticketingticketsetting()
        {
            Venuemasterticketingbookingtickets = new HashSet<Venuemasterticketingbookingtickets>();
            Venuemasterticketingticketsettingcheckbox = new HashSet<Venuemasterticketingticketsettingcheckbox>();
            Venuemasterticketingticketsettingmembertypes = new HashSet<Venuemasterticketingticketsettingmembertypes>();
            Venuemasterticketingtickettype = new HashSet<Venuemasterticketingtickettype>();
        }

        public Guid VenueMasterTicketingTicketSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string AdditionalReceiptTextAfterGenericText { get; set; }
        public string AdditionalTermsAndConditionsText { get; set; }
        public string AdditionalTicketSelectionPageText { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsPopUpMessage { get; set; }
        public string PopUpMessageText { get; set; }
        public decimal BookingFee { get; set; }
        public int? VenueMasterTicketingPromoId { get; set; }

        public Cinema Cinema { get; set; }
        public Venuemasterticketingpromo VenueMasterTicketingPromo { get; set; }
        public ICollection<Venuemasterticketingbookingtickets> Venuemasterticketingbookingtickets { get; set; }
        public ICollection<Venuemasterticketingticketsettingcheckbox> Venuemasterticketingticketsettingcheckbox { get; set; }
        public ICollection<Venuemasterticketingticketsettingmembertypes> Venuemasterticketingticketsettingmembertypes { get; set; }
        public ICollection<Venuemasterticketingtickettype> Venuemasterticketingtickettype { get; set; }
    }
}
