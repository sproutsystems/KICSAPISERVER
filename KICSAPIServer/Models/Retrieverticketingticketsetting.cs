using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingticketsetting
    {
        public Retrieverticketingticketsetting()
        {
            Retrieverticketingbookingtickets = new HashSet<Retrieverticketingbookingtickets>();
            Retrieverticketingticketsettingcheckbox = new HashSet<Retrieverticketingticketsettingcheckbox>();
            Retrieverticketingticketsettingmembertypes = new HashSet<Retrieverticketingticketsettingmembertypes>();
            Retrieverticketingtickettype = new HashSet<Retrieverticketingtickettype>();
        }

        public Guid RetrieverTicketingTicketSettingId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string AdditionalReceiptTextAfterGenericText { get; set; }
        public string AdditionalTermsAndConditionsText { get; set; }
        public string AdditionalTicketSelectionPageText { get; set; }
        public bool IsPublic { get; set; }
        public bool IsPopUpMessage { get; set; }
        public string PopUpMessageText { get; set; }
        public decimal BookingFee { get; set; }
        public int? RetrieverTicketingPromoId { get; set; }

        public Cinema Cinema { get; set; }
        public Retrieverticketingpromo RetrieverTicketingPromo { get; set; }
        public ICollection<Retrieverticketingbookingtickets> Retrieverticketingbookingtickets { get; set; }
        public ICollection<Retrieverticketingticketsettingcheckbox> Retrieverticketingticketsettingcheckbox { get; set; }
        public ICollection<Retrieverticketingticketsettingmembertypes> Retrieverticketingticketsettingmembertypes { get; set; }
        public ICollection<Retrieverticketingtickettype> Retrieverticketingtickettype { get; set; }
    }
}
