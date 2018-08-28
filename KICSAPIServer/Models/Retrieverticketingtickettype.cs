using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Retrieverticketingtickettype
    {
        public Retrieverticketingtickettype()
        {
            Retrieverticketingsettingticket = new HashSet<Retrieverticketingsettingticket>();
            Retrieverticketingtickettypemovie = new HashSet<Retrieverticketingtickettypemovie>();
        }

        public Guid RetrieverTicketingTicketTypeId { get; set; }
        public Guid RetrieverTicketingTicketSettingId { get; set; }
        public string TicketCodeToMatch { get; set; }
        public bool IsTicket { get; set; }
        public bool IsExcluded { get; set; }
        public decimal? BookingFee { get; set; }
        public string TicketNameForDisplay { get; set; }
        public string TicketSelectionItemText { get; set; }
        public string PrerequisiteTicketCode { get; set; }
        public string PrerequisiteTicketNameForDisplay { get; set; }
        public int? NumberOfTicketsPremittedPerPrerequisiteTicket { get; set; }
        public int? NumberOfPrerequisiteTicketsRequiredPerTicket { get; set; }
        public string ToolTipMessage { get; set; }
        public int? RetrieverTicketingExternalPartyId { get; set; }
        public string ExternalReference1 { get; set; }
        public string ExternalReference2 { get; set; }
        public string ExternalReference3 { get; set; }
        public int? MaxQty { get; set; }

        public Retrieverticketingexternalparty RetrieverTicketingExternalParty { get; set; }
        public Retrieverticketingticketsetting RetrieverTicketingTicketSetting { get; set; }
        public ICollection<Retrieverticketingsettingticket> Retrieverticketingsettingticket { get; set; }
        public ICollection<Retrieverticketingtickettypemovie> Retrieverticketingtickettypemovie { get; set; }
    }
}
