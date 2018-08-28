using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Venuemasterticketingtickettype
    {
        public Venuemasterticketingtickettype()
        {
            Venuemasterticketingsettingviftkt = new HashSet<Venuemasterticketingsettingviftkt>();
            Venuemasterticketingtickettypemovie = new HashSet<Venuemasterticketingtickettypemovie>();
        }

        public Guid VenueMasterTicketingTicketTypeId { get; set; }
        public Guid VenueMasterTicketingTicketSettingId { get; set; }
        public string TicketCodeToMatch { get; set; }
        public bool? IsTicket { get; set; }
        public bool IsExcluded { get; set; }
        public decimal? BookingFee { get; set; }
        public string TicketNameForDisplay { get; set; }
        public string TicketSelectionItemText { get; set; }
        public string PrerequisiteTicketCode { get; set; }
        public string PrerequisiteTicketNameForDisplay { get; set; }
        public int? NumberOfTicketsPremittedPerPrerequisiteTicket { get; set; }
        public int? NumberOfPrerequisiteTicketsRequiredPerTicket { get; set; }
        public string ToolTipMessage { get; set; }
        public int? VenueMasterTicketingExternalPartyId { get; set; }
        public string ExternalReference1 { get; set; }
        public string ExternalReference2 { get; set; }
        public string ExternalReference3 { get; set; }
        public int? MaxQty { get; set; }

        public Venuemasterticketingexternalparty VenueMasterTicketingExternalParty { get; set; }
        public Venuemasterticketingticketsetting VenueMasterTicketingTicketSetting { get; set; }
        public ICollection<Venuemasterticketingsettingviftkt> Venuemasterticketingsettingviftkt { get; set; }
        public ICollection<Venuemasterticketingtickettypemovie> Venuemasterticketingtickettypemovie { get; set; }
    }
}
